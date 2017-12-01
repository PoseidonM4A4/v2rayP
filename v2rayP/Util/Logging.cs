using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using v2rayP.Manager;
using v2rayP.Resources.Localization;

namespace v2rayP.Util
{
    public class Logging
    {
        public enum LogLevel {
            None = 0,
            Error,
            Warning,
            Info,
            Debug,
        }

        public static string LogFilePath;
        private static object Lock = new object();
        private static string directory;
        private static string date;
        private static FileStream stream;

        static Logging()
        {
            directory = Path.Combine(Application.StartupPath, Setting.LogDirectory);
            GenerateLogFilename();

            if (!FileHelper.TouchDirectory(directory))
            {
                MsgBox.Error(string.Format(I18n.MsgFailToExtractPrivoxy, I18n.Logging, directory));
                Launcher.Stop();
            }
        }

        public static void Start()
        {
            if (stream != null) stream.Close();
            System.Diagnostics.Debug.Listeners.Clear();
            stream = new FileStream(LogFilePath, FileMode.Append, FileAccess.Write, FileShare.Read);
            System.Diagnostics.Debug.Listeners.Add(new TextWriterTraceListener(stream, "logger"));
            System.Diagnostics.Debug.AutoFlush = true;
        }

        static void Log(LogLevel level, Object obj, string section = null)
        {
            if (level > Setting.LogLevel) return;
            string time = DateTime.Now.ToString("G");
            string levelName = level.ToString();
            string text = $@"[{time}][{levelName}][{section ?? Setting.AppName}] {obj}";
            
            lock (Lock)
            {
                if (!CheckDate()) GenerateLogFilename();
                System.Diagnostics.Debug.WriteLine(text);
            }
        }

        public static void Info(Object obj, string section = null)
        {
            Log(LogLevel.Info, obj, section);
        }

        public static void Debug(Object obj, string section = null)
        {
            Log(LogLevel.Debug, obj, section);
        }

        public static void Warning(Object obj, string section = null)
        {
            Log(LogLevel.Warning, obj, section);
        }

        public static void Error(Object obj, string section = null)
        {
            Log(LogLevel.Error, obj, section);
        }

        public static void Exception(Exception ex, string section = null)
        {
            Log(LogLevel.Error, ex.Message + "\r\n" + ex.StackTrace.ToString(), section);
        }

        private static void GenerateLogFilename()
        {
            date = DateTime.Now.ToString("yyyy-MM");
            LogFilePath = Path.Combine(directory, string.Format(Setting.LogName, date));
        }

        private static bool CheckDate() => DateTime.Now.ToString("yyyy-MM") == date;
    }
}
