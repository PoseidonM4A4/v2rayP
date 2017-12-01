using System;
using System.Threading;
using v2rayP.UI;
using v2rayP.Resources.Localization;
using System.Windows.Forms;
using v2rayP.Util;
using v2rayP.Manager;
using v2rayP.Model;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace v2rayP
{
    static class Program
    {
        public static JobManager Job = new JobManager();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Helper.SetAllowUnsafeHeaderParsing(true);

            string firstArgument = args.Length > 0 ? args[0] : String.Empty;
            if (firstArgument == "--enable-autostart")
            {
                AutoStart.SetAutoStart(true);
                return;
            }
            else if (firstArgument == "--disable-autostart")
            {
                AutoStart.SetAutoStart(false);
                return;
            }

            var createdNew = true;
            var mutexName = Setting.AppName + ":" + Application.StartupPath.GetHashCode();
            using (var mutex = new Mutex(true, mutexName, out createdNew))
            {
                if (!createdNew)
                {
                    MsgBox.Info(string.Format(I18n.MsgInstanceExist, Setting.AppName));
                    return;
                }

                Launcher.Start();
            }
        }

        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            String resourceName = "v2rayP.Library." + new AssemblyName(args.Name).Name + ".dll";
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                Byte[] assemblyData = new Byte[stream.Length];
                stream.Read(assemblyData, 0, assemblyData.Length);
                return Assembly.Load(assemblyData);
            }
        }
    }
}
