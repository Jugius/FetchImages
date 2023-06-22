using OfficeOpenXml;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FetchImages
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            //try to delete temp folder
            Task.Run(() => {
                string path = Configuration.AppSettings.Application.TempDirectory;
                if (System.IO.Directory.Exists(path))
                {
                    try
                    {
                        System.IO.Directory.Delete(path, true);
                    }
                    catch { }
                }
            });

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }        
    }
}
