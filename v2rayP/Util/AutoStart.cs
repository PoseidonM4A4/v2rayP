using Microsoft.Win32;
using System.Diagnostics;
using System.Windows.Forms;

namespace v2rayP.Util
{
    public class AutoStart
    {
        private static string autoRunName = Setting.AppName;
        private static string autoRunRegPath = @"Software\Microsoft\Windows\CurrentVersion\Run";

        public static void SetAutoStart(bool enable)
        {
            using (var regKey = Registry.LocalMachine.CreateSubKey(autoRunRegPath))
            {
                if (enable) regKey.SetValue(autoRunName, Application.ExecutablePath);
                else regKey.DeleteValue(autoRunName, false);
            }
        }
        
        static int RunAs(string args)
        {
            var p = new Process()
            {
                StartInfo = {
                    FileName = Application.ExecutablePath,
                    Arguments = args,
                    Verb = "runas",
                    WindowStyle = ProcessWindowStyle.Hidden,
                }
            };

            p.Start();
            p.WaitForExit();
            return p.ExitCode;
        }

        public static int Enable() => RunAs("--enable-autostart");
        public static int Disable() => RunAs("--disable-autostart");
    }
}
