using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using v2rayP.Model;
using v2rayP.Resources.Localization;
using v2rayP.Util;

namespace v2rayP.UI
{
    public partial class EditServersForm : BaseForm
    {
        private BindingList<VMess> servers;
        private int previousSelectedIndex = 0;
        private bool needSync = true;

        private Guid currentItemId;

        public EditServersForm()
        {
            InitializeComponent();
        }

        private void EditServersForm_Load(object sender, EventArgs e)
        {
            Text = I18n.FormEditServers;
            buttonSave.Text = I18n.Save;
            buttonClose.Text = I18n.Close;

            needSync = true;
            previousSelectedIndex = 0;

            // In the form designer, these three panels are set DOCK = None
            // in order to make UI designing easier.
            // But in the runtime environment, only one of these panels will show.
            tableLayoutPanelTCPSettings.Dock = DockStyle.Fill;
            tableLayoutPanelKCPSettings.Dock = DockStyle.Top;
            tableLayoutPanelWebSocketSettings.Dock = DockStyle.Fill;

            comboBoxSecurity.SelectedIndex = 0;
            comboBoxNetwork.SelectedIndex = 0;
            comboBoxTCPType.SelectedIndex = 0;

            comboBoxNetwork_SelectedIndexChanged(sender, e);
            checkBoxEnableTLS_CheckedChanged(sender, e);

            ReloadServers();
        }

        private void ToggleTCPSetting(bool show)
        {
            tableLayoutPanelTCPSettings.Visible = show;
        }

        private void ToggleKCPSetting(bool show)
        {
            tableLayoutPanelKCPSettings.Visible = show;
        }

        private void ToggleWebSocketSetting(bool show)
        {
            tableLayoutPanelWebSocketSettings.Visible = show;
        }

        private void ReloadServers()
        {
            servers = new BindingList<VMess>(new List<VMess>(v2rayP.Setting.Servers));
            listBoxServersList.DataSource = servers;

            if (servers.Count == 0) AddServer();
            LoadSelectedServerIntoEditor();
        }

        private void AddServer()
        {
            servers.Add(new VMess { Remark = I18n.NewV2RayServer });
            listBoxServersList.SelectedIndex = servers.Count - 1;
            LoadSelectedServerIntoEditor();
        }

        private void LoadSelectedServerIntoEditor()
        {
            var server = servers[previousSelectedIndex];
            currentItemId = server.Id;
            textBoxAddress.Text = server.Address;
            textBoxRemark.Text = server.Remark;
            numericUpDownPort.Value = server.Port;
            numericUpDownAlterID.Value = server.AlterId;
            textBoxID.Text = server.UserId;
            checkBoxEnableMux.Checked = server.EnableMux;

            // Security
            Dictionary<string, int> securityIndexMap = new Dictionary<string, int> { { "aes-128-cfb", 0 }, { "aes-128-gcm", 1 }, { "chacha20-poly1305", 2 }, { "auto", 3 }, { "none", 4 } };
            var security = server.Security;
            comboBoxSecurity.SelectedIndex = securityIndexMap.ContainsKey(security) ? securityIndexMap[security] : 0;

            // TLS
            if (server?.StreamSettings?.Security == "tls")
            {
                var tls = server?.StreamSettings?.TlsSettings;
                checkBoxEnableTLS.Checked = true;
                checkBoxAllowInsecure.Checked = tls?.AllowInsecure ?? false;
                textBoxTLSServerName.Text = tls?.ServerName;
            }

            // Transport
            SetTCPSettingDefaultValue();
            SetKCPSettingDefaultValue();
            SetWebSocketSettingDefaultValue();
            var network = server?.StreamSettings?.Network ?? "tcp";
            switch (network)
            {
                default:
                case "tcp":
                    comboBoxNetwork.SelectedIndex = 0;
                    var header = server?.StreamSettings?.TcpSettings?.Header;
                    if (header == null)
                    {
                        SetTCPSettingDefaultValue();
                        break;
                    }

                    if (header.Type != "http") comboBoxTCPType.SelectedIndex = 0;
                    else
                    {
                        comboBoxTCPType.SelectedIndex = 1;
                        var req = header?.Request;
                        var res = header?.Response;

                        tabControlTCPHTTPSetting.SelectedIndex = 0;
                        if (req == null) SetTCPSettingDefaultValue(type: false, response: false);
                        else
                        {
                            textBoxHTTPRequestVersion.Text = req.Version;
                            textBoxHTTPRequestMethod.Text = req.Method;
                            textBoxHTTPRequestPaths.Text = req.Path is string ? req.Path as string : String.Join(",", (req.Path as string[]));
                            textBoxHTTPRequestHeaders.Text = req.Headers != null ? StringifyHeaders(req.Headers) : "";
                        }

                        if (res == null) SetTCPSettingDefaultValue(type: false, request: false);
                        else
                        {
                            textBoxHTTPResponseVersion.Text = res.Version;
                            textBoxHTTPResponseStatus.Text = res.Status;
                            textBoxHTTPResponseReason.Text = res.Reason;
                            textBoxHTTPResponseHeaders.Text = res.Headers != null ? StringifyHeaders(res.Headers) : "";
                        }
                    }
                    break;
                case "kcp":
                    comboBoxNetwork.SelectedIndex = 1;
                    var kcp = server?.StreamSettings?.KcpSettings;
                    if (kcp == null) SetKCPSettingDefaultValue();
                    else
                    {
                        numericUpDownKCPWriteBufferSize.Value = kcp.WriteBufferSize;
                        numericUpDownKCPReadBufferSize.Value = kcp.ReadBufferSize;
                        checkBoxCongestion.Checked = kcp.Congestion;
                        numericUpDownKCPDownlinkCapacity.Value = kcp.DownlinkCapacity;
                        numericUpDownKCPUplinkCapacity.Value = kcp.UplinkCapacity;
                        numericUpDownKCPMTU.Value = kcp.Mtu;
                        numericUpDownKCPTTI.Value = kcp.Tti;

                        if (!v2rayP.Setting.KCPHeaderTypes.Contains(kcp?.Header?.Type)) comboBoxKCPHeaderType.SelectedValue = kcp.Header.Type;
                        else comboBoxKCPHeaderType.SelectedValue = v2rayP.Setting.KCPHeaderType;
                    }
                    break;
                case "ws":
                    comboBoxNetwork.SelectedIndex = 2;
                    var ws = server?.StreamSettings?.WsSettings;
                    textBoxWebSocketPath.Text = ws?.Path;
                    textBoxWebSocketHeaders.Text = ws?.Headers != null ? StringifyHeaders(ws.Headers, false) : String.Empty;
                    break;
            }
        }

        private bool SyncChange()
        {
            var server = GenerateVMessConfigFromEditor();
            if (server == null) return false;

            server.Id = currentItemId;
            servers[previousSelectedIndex] = server;
            return true;
        }

        private VMess GenerateVMessConfigFromEditor()
        {
            // Base Server Config
            if (String.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                MsgBox.Error(I18n.MsgPleaseInputAddress);
                textBoxAddress.Focus();
                return null;
            }

            if (String.IsNullOrWhiteSpace(textBoxID.Text) || !Guid.TryParse(textBoxID.Text, out Guid result))
            {
                MsgBox.Error(I18n.MsgPleaseInputId);
                textBoxID.Focus();
                return null;
            }

            if (!v2rayP.Setting.VmessSecurity.Contains(comboBoxSecurity.Text))
            {
                MsgBox.Error(string.Format(I18n.MsgPleaseSelectGivenValues, "Security"));
                comboBoxSecurity.Focus();
                return null;
            }

            string remark = String.IsNullOrWhiteSpace(textBoxRemark.Text) ? String.Empty : textBoxRemark.Text;

            var config = new VMess
            {
                Address = textBoxAddress.Text.Trim(),
                Port = Convert.ToInt32(numericUpDownPort.Value),
                AlterId = Convert.ToInt32(numericUpDownAlterID.Value),
                UserId = textBoxID.Text.Trim(),
                Security = comboBoxSecurity.Text.Trim(),
                Remark = remark,
                EnableMux = checkBoxEnableMux.Checked,
            };
            var stream = new StreamSetting();
            var streamChanged = false;

            // TLS Settings
            var enableTLS = checkBoxEnableTLS.Checked;
            if (enableTLS)
            {
                streamChanged = true;
                stream.Security = "tls";
                stream.TlsSettings = new TLSSetting
                {
                    AllowInsecure = checkBoxAllowInsecure.Checked,
                    ServerName = textBoxTLSServerName.Text.Trim(),
                };
            }

            // TCP Settings
            if (comboBoxNetwork.SelectedIndex == 0)
            {
                stream.Network = "tcp";
                if (comboBoxTCPType.Text == "http")
                {
                    streamChanged = true;

                    object path = null;
                    if (!String.IsNullOrWhiteSpace(textBoxHTTPRequestPaths.Text))
                    {
                        var paths = textBoxHTTPRequestPaths.Text.Split(',').Select(p => p.Trim()).ToArray();
                        if (paths.Length == 1) path = paths[0];
                        else path = paths;
                    }

                    stream.TcpSettings = new TCPSetting
                    {
                        Header = {
                            Type = "http",
                            Request =
                            {
                                Version = textBoxHTTPRequestVersion.Text.Trim(),
                                Method = textBoxHTTPRequestMethod.Text.Trim(),
                                Headers = ParseHeaders(textBoxHTTPRequestHeaders.Text, true),
                                Path = path,
                            },
                            Response =
                            {
                                Version = textBoxHTTPResponseVersion.Text.Trim(),
                                Status = textBoxHTTPResponseStatus.Text.Trim(),
                                Reason = textBoxHTTPResponseReason.Text.Trim(),
                                Headers = ParseHeaders(textBoxHTTPResponseHeaders.Text, true),
                            }
                        },

                    };

                }
            }

            // KCP Settings
            else if (comboBoxNetwork.SelectedIndex == 1)
            {
                string headerType = comboBoxKCPHeaderType.Text;
                if (!v2rayP.Setting.KCPHeaderTypes.Contains(headerType))
                {
                    MsgBox.Error(string.Format(I18n.MsgPleaseSelectGivenValues, "Header Type"));
                    comboBoxKCPHeaderType.SelectedIndex = 0;
                    return null;
                }

                stream.Network = "kcp";
                stream.KcpSettings = new KCPSetting
                {
                    Congestion = checkBoxCongestion.Checked,
                    Mtu = Convert.ToInt32(numericUpDownKCPMTU.Value),
                    Tti = Convert.ToInt32(numericUpDownKCPTTI.Value),
                    UplinkCapacity = Convert.ToInt32(numericUpDownKCPUplinkCapacity.Value),
                    DownlinkCapacity = Convert.ToInt32(numericUpDownKCPDownlinkCapacity.Value),
                    WriteBufferSize = Convert.ToInt32(numericUpDownKCPWriteBufferSize.Value),
                    ReadBufferSize = Convert.ToInt32(numericUpDownKCPReadBufferSize.Value),
                    Header =
                    {
                        Type = headerType
                    }
                };
                streamChanged = true;
            }

            // WebSocket Settings
            else if (comboBoxNetwork.SelectedIndex == 2)
            {
                stream.Network = "ws";
                stream.WsSettings = new WebSocketSetting
                {
                    Path = textBoxWebSocketPath.Text.Trim(),
                    Headers = ParseHeaders(textBoxWebSocketHeaders.Text, false),
                };
                streamChanged = true;
            }

            else
            {
                MsgBox.Error(String.Format(I18n.MsgPleaseSelectGivenValues, "Network Type"));
                comboBoxNetwork.Focus();
                return null;
            }

            if (streamChanged) config.StreamSettings = stream;
            return config;
        }

        private string StringifyHeaders(Dictionary<string, object> headers, bool allowRandomValue = true)
        {
            var lines = new List<string>();
            foreach (var pair in headers)
            {
                var value = pair.Value;
                var field = pair.Key;
                var values = (value is string) ? new List<string> { value as string } : (value as List<string>);
                
                if (allowRandomValue) foreach (var v in values) lines.Add($"{field}: {v}");
                else lines.Add($"{field}: {values[0]}");
            }

            return String.Join(Environment.NewLine, lines);
        }

        private Dictionary<string, object> ParseHeaders(string headers, bool allowRandomValue)
        {
            if (String.IsNullOrWhiteSpace(headers)) return null;
            var dict = new Dictionary<string, object>();

            foreach (var line in headers.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                var lineSplited = line.Split(new[] { ':' }, 2);
                if (lineSplited.Length == 1) continue;

                var field = lineSplited[0].Trim();
                var value = lineSplited[1].Trim();

                if (dict.ContainsKey(field))
                {
                    if (allowRandomValue)
                    {
                        var obj = dict[field];
                        if (obj is string)
                        {
                            dict[field] = new List<string> { obj as string, value };
                        }
                        else
                        {
                            var values = (dict[field] as List<string>);
                            values.Add(value);
                        }
                    }
                }
                else
                {
                    dict[field] = value;
                }

            }

            return dict.Count > 0 ? dict : null;
        }

        private void SetTCPSettingDefaultValue(bool type = true, bool request = true, bool response = true)
        {
            if (type)
            {
                comboBoxTCPType.SelectedIndex = 0;
            }

            if (request)
            {
                textBoxHTTPRequestVersion.Text = "1.1";
                textBoxHTTPRequestMethod.Text = "GET";
                textBoxHTTPRequestPaths.Text = "/";
                textBoxHTTPRequestHeaders.Text = "";
            }

            if (response)
            {
                textBoxHTTPResponseVersion.Text = "1.1";
                textBoxHTTPResponseStatus.Text = "200";
                textBoxHTTPResponseReason.Text = "OK";
                textBoxHTTPRequestHeaders.Text = "";
            }
        }

        private void SetKCPSettingDefaultValue()
        {
            numericUpDownKCPWriteBufferSize.Value = Setting.KCPWriteBufferSize;
            numericUpDownKCPReadBufferSize.Value = Setting.KCPReadBufferSize;
            checkBoxCongestion.Checked = Setting.KCPCongestion;
            numericUpDownKCPDownlinkCapacity.Value = Setting.KCPDownlinkCapacity;
            numericUpDownKCPUplinkCapacity.Value = Setting.KCPUplinkCapacity;
            numericUpDownKCPMTU.Value = Setting.KCPMtu;
            numericUpDownKCPTTI.Value = Setting.KCPTti;
            comboBoxKCPHeaderType.SelectedIndex = 0;
        }

        private void SetWebSocketSettingDefaultValue()
        {
            textBoxWebSocketPath.Text = "/";
            textBoxWebSocketHeaders.Text = "";
        }

        private void comboBoxNetwork_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxNetwork.SelectedIndex)
            {
                default:
                case 0:  // TCP
                    ToggleTCPSetting(true);
                    ToggleKCPSetting(false);
                    ToggleWebSocketSetting(false);
                    break;
                case 1:  // mKCP
                    ToggleTCPSetting(false);
                    ToggleKCPSetting(true);
                    ToggleWebSocketSetting(false);
                    break;
                case 2: // WebSocket
                    ToggleTCPSetting(false);
                    ToggleKCPSetting(false);
                    ToggleWebSocketSetting(true);
                    break;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            needSync = false;
            listBoxServersList.DataSource = servers = null;
            Close();
        }

        private void checkBoxEnableTLS_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxAllowInsecure.Enabled =
            textBoxTLSServerName.Enabled = checkBoxEnableTLS.Checked;
        }

        private void comboBoxTCPType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTCPType.SelectedIndex)
            {
                default:
                case 0:  // None
                    tabControlTCPHTTPSetting.Visible = false;
                    break;

                case 1:
                    tabControlTCPHTTPSetting.Visible = true;
                    break;
            }

        }

        private void listBoxServersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (previousSelectedIndex == listBoxServersList.SelectedIndex || listBoxServersList.SelectedIndex == -1) return;
            if (!needSync) return;

            if (SyncChange())
            {
                previousSelectedIndex = listBoxServersList.SelectedIndex;
                LoadSelectedServerIntoEditor();
                needSync = true;
            }
            else
            {
                listBoxServersList.SelectedIndex = previousSelectedIndex;
            }
        }

        private void buttonGenerateID_Click(object sender, EventArgs e)
        {
            textBoxID.Text = System.Guid.NewGuid().ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!SyncChange()) return;

            var newServers = servers.ToList();
            var activeServerId = Setting.ActiveServer?.Id;
            Launcher.UpdateServers(newServers);
            if (activeServerId != null)
            {
                var activeServerIndex = newServers.FindIndex(server => server.Id.Equals(activeServerId));
                Launcher.ActivateServer(activeServerIndex);
            }
            else
            {
                Launcher.ActivateServer(0);
            }
            buttonClose_Click(sender, e);
        }

        private void buttonAddServer_Click(object sender, EventArgs e)
        {
            if (SyncChange()) AddServer();
        }

        private void buttonRemoveServer_Click(object sender, EventArgs e)
        {
            if (servers.Count == 1) return;
            needSync = false;
            servers.RemoveAt(previousSelectedIndex);
            previousSelectedIndex -= 1;
            LoadSelectedServerIntoEditor();
            needSync = true;
        }
    }
}
