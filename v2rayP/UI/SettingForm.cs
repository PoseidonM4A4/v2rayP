using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using v2rayP.Model;
using v2rayP.Resources.Localization;
using v2rayP.Util;
using static v2rayP.Util.Logging;

namespace v2rayP.UI
{
    public partial class SettingForm : v2rayP.UI.BaseForm
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool changed = false;
            bool restartV2Ray = false;
            bool restartPAC = false;
            bool updatePAC = false;

            if (textBoxGFWListURL.Text != Setting.GFWListURL)
            {
                changed = true;
                Setting.GFWListURL = textBoxGFWListURL.Text;
            }

            if (checkBoxEnableAccessLog.Checked != Setting.EnableAccessLog)
            {
                changed = restartV2Ray = true;
                Setting.EnableAccessLog = checkBoxEnableAccessLog.Checked;
            }

            if (checkBoxEnableErrorLog.Checked != Setting.EnableErrorLog)
            {
                changed = restartV2Ray = true;
                Setting.EnableErrorLog = checkBoxEnableErrorLog.Checked;
            }

            if (checkBoxAutoStart.Checked != Setting.AutoStart)
            {
                changed = updatePAC = true;

                int exitCode = -1;
                if (checkBoxAutoStart.Checked) exitCode = AutoStart.Enable();
                else exitCode = AutoStart.Disable();

                if (exitCode == 0)
                    Setting.AutoStart = checkBoxAutoStart.Checked;
            }

            if (comboBoxLogLevel.SelectedIndex != (int)Setting.LogLevel)
            {
                changed = restartV2Ray = true;
                Setting.LogLevel = (LogLevel)comboBoxLogLevel.SelectedIndex;
            }

            if (checkBoxAcceptLAN.Checked != Setting.AcceptLAN)
            {
                changed = restartV2Ray = true;
                Setting.AcceptLAN = checkBoxAcceptLAN.Checked;
            }

            if (numericUpDownSock5Port.Value != Setting.SocksPort)
            {
                changed = restartV2Ray = true;
                Setting.SocksPort = Convert.ToInt32(numericUpDownSock5Port.Value);
            }

            if (numericUpDownHTTPPort.Value != Setting.HttpPort)
            {
                changed = restartV2Ray = true;
                Setting.HttpPort = Convert.ToInt32(numericUpDownHTTPPort.Value);
            }

            if (numericUpDownPACPort.Value != Setting.PacPort)
            {
                changed = restartPAC = true;
                Setting.PacPort = Convert.ToInt32(numericUpDownPACPort.Value);
            }

            if (Setting.UpdateViaProxy != checkBoxUpdateViaProxy.Checked)
            {
                changed = true;
                Setting.UpdateViaProxy = checkBoxUpdateViaProxy.Checked;
            }


            if (changed)
            {
                if (restartV2Ray)
                {
                    Launcher.ActivateServer(Setting.ActiveServerIndex);
                }

                if (restartPAC)
                {
                    Launcher.Pac.Start();
                    if (Setting.Mode == Model.ProxyMode.PAC) Launcher.SwitchProxyMode(Model.ProxyMode.PAC);
                }

                if (updatePAC)
                {
                    Launcher.GetGFWList(Setting.GFWListURL);
                }
                Setting.Save();
            }
            Close();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            Text = I18n.FormSetting;
            groupBoxV2RayPSetting.Text = I18n.SettingFormV2RayPSetting;
            checkBoxAutoStart.Text = I18n.SettingFormAutoStart;
            labelV2RayPLogLevel.Text = I18n.SettingFormLogLevel;
            labelGFWListURL.Text = I18n.SettingFormGFWListURL;
            groupBoxLocalProxySetting.Text = I18n.SettingFormLocalProxySetting;
            labelSock5ProxyPort.Text = I18n.SettingFormSOCKPort;
            labelHTTPProxyPort.Text = I18n.SettingFormHTTPPort;
            labelPACServerPort.Text = I18n.SettingFormPACServerPort;
            checkBoxAcceptLAN.Text = I18n.SettingFormAcceptLAN;
            checkBoxEnableAccessLog.Text = I18n.SettingFormEnableAccessLog;
            checkBoxEnableErrorLog.Text = I18n.SettingFormEnableErrorLog;
            checkBoxUpdateViaProxy.Text = I18n.SettingFormUpdateViaProxy;
            buttonSave.Text = I18n.Save;
            buttonClose.Text = I18n.Close;

            checkBoxAutoStart.Checked = Setting.AutoStart;
            textBoxGFWListURL.Text = Setting.GFWListURL;

            comboBoxLogLevel.SelectedIndex = (int)Setting.LogLevel;
            checkBoxEnableAccessLog.Checked = Setting.EnableAccessLog;
            checkBoxEnableErrorLog.Checked = Setting.EnableErrorLog;
            checkBoxUpdateViaProxy.Checked = Setting.UpdateViaProxy;
            checkBoxAcceptLAN.Checked = Setting.AcceptLAN;
            numericUpDownSock5Port.Value = Setting.SocksPort;
            numericUpDownHTTPPort.Value = Setting.HttpPort;
            numericUpDownPACPort.Value = Setting.PacPort;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
