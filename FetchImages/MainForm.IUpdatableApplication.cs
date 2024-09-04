using System;
using System.Reflection;
using System.Windows.Forms;
using OohelpWebApps.Software.Updater;

namespace FetchImages;

public partial class MainForm : IUpdatableApplication
{
    private const string _name = "FetchImages";
    private const string _updatesServer = @"https://software.oohelp.net";
    public string ApplicationName => _name;
    public Form MainWindow => this;
    public Version Version => Assembly.GetExecutingAssembly().GetName().Version;
    public Uri UpdatesServer => new Uri(_updatesServer);
    public Uri DownloadPage => new Uri("https://oohelp.net/software/fetchimages");
}
