using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using v2rayP.Resources.Localization;
using v2rayP.Util;

namespace v2rayP.UI
{
    public partial class ShowLogForm : BaseForm
    {
        Timer timer;
        string filename;
        long lastPosition;
        long maxLength = 10000;

        public ShowLogForm()
        {
            InitializeComponent();
        }

        private void ShowLogForm_Load(object sender, EventArgs e)
        {
            Text = I18n.FormShowLog;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (s, ev) => LoadLog();
            timer.Start();
        }

        private void LoadLog()
        {
            if (Logging.LogFilePath != filename)
            {
                filename = Logging.LogFilePath;
                lastPosition = -1;
            }

            try
            {
                var stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                using (var reader = new StreamReader(stream))
                {
                    if (lastPosition == -1)  // start form beginning, let's skip some lines
                    {
                        var length = reader.BaseStream.Length;
                        if (length > maxLength)
                        {
                            reader.BaseStream.Seek(-maxLength, SeekOrigin.End);
                            reader.ReadLine();
                        }
                    }
                    else
                    {
                        reader.BaseStream.Seek(lastPosition, SeekOrigin.Begin);
                    }

                    var text = reader.ReadToEnd();
                    if (!string.IsNullOrEmpty(text))
                    {
                        textBoxLog.AppendText(text);
                        textBoxLog.ScrollToCaret();
                    }

                    lastPosition = reader.BaseStream.Position;
                }
            }
            catch { }
        }

        private void ShowLogForm_Shown(object sender, EventArgs e)
        {
            LoadLog();
        }
    }
}
