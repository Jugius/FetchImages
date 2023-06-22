﻿using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FetchImages;
public partial class AboutDialog : Form
{
    public const string ApplicationSite = @"https://oohelp.net/software/fetchimages";
    public AboutDialog()
    {
        InitializeComponent();
    }
    public AboutDialog(MainForm app) : this()
    {
        this.Text = $"О программе FetchImages";
        lblProgramName.Text = "FetchImages";
        this.Icon = app.Icon;
        pictureAppImage.Image = FetchImages.Properties.Resources.html_icon;
        var version = app.Version;
        lblVersion.Text = "Версия: " + version.Major + "." + version.Minor +
            (version.Build != 0 ? $" (build {version.Build}" +
            (version.Revision > 0 ? $" rev. {version.Revision}" : null) + ")" : null);

        lblCopyright.Text = GetAssemblyCopyright(Assembly.GetExecutingAssembly());
        linkWWW.Text = $"Страница FetchImages";
    }
    private string GetAssemblyCopyright(Assembly assembly)
    {
        if (assembly == null) return "";
        object[] attributes = assembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
        if (attributes.Length == 0)
        {
            return "";
        }
        return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;

    }
    private void _secondaryPanel_Paint(object sender, PaintEventArgs e)
    {
        VisualStyleRenderer renderer = new VisualStyleRenderer(VisualStyleElement.CreateElement("TASKDIALOG", 8, 0));
        renderer.DrawBackground(e.Graphics, _secondaryPanel.ClientRectangle, e.ClipRectangle);
    }

    private void linkWWW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Process.Start(AboutDialog.ApplicationSite);
    }
}