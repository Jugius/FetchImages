using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FetchImages.Configuration
{
    internal class AppSettings
    {
        private static AppSettings instance;
        public static AppSettings Instance => instance ??= LoadOrGetDefault();

        private static readonly JsonSerializerOptions jsonDefaultOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        };        
        public static class Application
        {
            private const string _appName = "FetchImages";
            public static string Name => _appName;
            public static string RoamingDirectory { get; } = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + _appName;
            public static string TempDirectory { get; } = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Temp";
        }

        public RequestProperties RequestProperties { get; set; }
        public FetchProperties FetchProperties { get; set; }

        public void Save()
        {

            string file = Path.Combine(Application.RoamingDirectory, "AppSettings.json");
            

            var jsonString = System.Text.Json.JsonSerializer.Serialize(this, jsonDefaultOptions);
            System.IO.Directory.CreateDirectory(Application.RoamingDirectory);
            System.IO.File.WriteAllText(file, jsonString);
        }
        private static AppSettings LoadOrGetDefault()
        {
            string file = Path.Combine(Application.RoamingDirectory, "AppSettings.json");
            if (File.Exists(file))
            {                
                return JsonSerializer.Deserialize<AppSettings>(File.ReadAllText(file), jsonDefaultOptions);
            }
            else
            {
                return new AppSettings
                {
                    RequestProperties = new RequestProperties(),
                    FetchProperties = new FetchProperties
                    {
                        UseHtmlSrcCode = true,
                        UseRegexp = true,
                        UseCustomRegexpPattern = false,
                        CustomRegexpPattern = null,
                        UseEmbeddedStrategies = false
                    }
                };
            }
        }
    }
}
