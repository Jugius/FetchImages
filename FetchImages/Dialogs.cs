using System;
using System.Linq;

namespace FetchImages;

internal static class Dialogs
{
    public static string[] GetLines()
    {
        using (var dlg = new Ookii.Dialogs.InputDialog())
        {
            dlg.Multiline = true;
            dlg.MaxLength = Int32.MaxValue;
            dlg.WindowTitle = dlg.MainInstruction = "Импорт адресов";
            dlg.Content = "Введите адреса или вставьте из буфера обмена.";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return dlg.InputLines.Where(a => !string.IsNullOrEmpty(a)).ToArray();
            }
            return Array.Empty<string>();
        }
    }
    public static string GetLine()
    {
        using (var dlg = new Ookii.Dialogs.InputDialog())
        {
            dlg.Multiline = false;
            dlg.WindowTitle = dlg.MainInstruction = "Импорт адресов";
            dlg.Content = "Введите адрес или вставьте из буфера обмена.";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(dlg.Input))
            {
                return dlg.Input;
            }
            return null;
        }
    }
}
