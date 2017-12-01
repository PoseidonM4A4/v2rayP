using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v2rayP.Util
{
    public class ProcessHelper
    {
        public static bool KillProcess(string ProcessName)
        {
            var processes = System.Diagnostics.Process.GetProcessesByName(ProcessName);
            foreach (var process in processes)
            {
                process.Kill();
                process.Close();
            }

            return false;
        }
    }
}
