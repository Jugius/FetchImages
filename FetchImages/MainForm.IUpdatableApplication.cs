using System;
using System.Reflection;
using System.Windows.Forms;
using SoftwareManagement.Updater;

namespace FetchImages;

public partial class MainForm : IUpdatableApplication
{
    private const string _name = "FetchImages";
    private const string _updatesServer = @"https://software.oohelp.net";
    public string ApplicationName => _name;
    public Form MainWindow => this;
    public Version Version => Assembly.GetExecutingAssembly().GetName().Version;
    public string UpdatesServerPath => _updatesServer;
}
