using System.Windows;
using System.Windows.Forms;
using v2rayP.Resources.Localization;

namespace v2rayP.Util
{
    public class MsgBox
    {
        public static void Show(string text)
        {
            MessageBox.Show(text, Setting.AppName);
        }

        public static void Error(string text)
        {
            MessageBox.Show(text, Setting.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Info(string text)
        {
            MessageBox.Show(text, Setting.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Warning(string text)
        {
            MessageBox.Show(text, Setting.AppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
