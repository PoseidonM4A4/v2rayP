using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using v2rayP.Manager;
using v2rayP.Model;
using v2rayP.Resources.Localization;

namespace v2rayP.UI
{
    public class TrayIcon: IDisposable
    {
        /*
        {V2Ray Version}
        -----
        Proxy Mode -> 
                        [x]Global Mode
                        [x]PAC Mode
                        [x]Direct Mode
                        [x]Keep System Proxy[default]
        PAC ->
                Update GFWList
                -----
                Edit User Rules
                Copy PAC Script URL
        -----
        Servers -> 
                    [x] Remark|[Transport][Host]:[Port]
                    [x] Server 2
        Edit Servers
        -----
        Options
        Help -> 
                Project Wiki
                Check for Update
                Feedback
                Show Log
                -----
                About 
        Exit
        */
        private NotifyIcon notifyIcon;

        private MenuItem keepSystemProxyModeItem;
        private MenuItem directModeItem;
        private MenuItem pacModeItem;
        private MenuItem globalModeItem;
        private MenuItem serversItem;
        private MenuItem noServersHintItem;

        private Form editServersForm;
        private Form showLogForm;
        private Form settingForm;

        public void Create()
        {
            noServersHintItem = new MenuItem(I18n.NoAvailableServers) { Enabled = false };

            notifyIcon = new NotifyIcon
            {
                Visible = true,
                Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location),
                ContextMenu = CreateMenu(),
            };

            notifyIcon.DoubleClick += EditServersItem_Click;
        }

        private ContextMenu CreateMenu()
        {
            var menu = new ContextMenu(new MenuItem[] {
                new MenuItem($"{Setting.AppName} {Setting.AppVersion}") { Enabled = false },
                CreateMenuSeperator(),
                // -----
                CreateMenuGroup(I18n.MenuGroupProxyMode, new MenuItem[] {
                    globalModeItem = new MenuItem(I18n.MenuItemGlobalMode, new EventHandler(GlobalModeItem_Click)),
                    pacModeItem = new MenuItem(I18n.MenuItemPacMode, new EventHandler(PacModeItem_Click)),
                    directModeItem = new MenuItem(I18n.MenuItemDirectMode, new EventHandler(DirectModeItem_Click)),
                    keepSystemProxyModeItem = new MenuItem(I18n.MenuItemKeepSystemProxyMode, new EventHandler(KeepSystemProxyModeItem_Click)),
                }),
                CreateMenuGroup(I18n.MenuGroupPAC, new MenuItem[] {
                    new MenuItem(I18n.MenuItemUpdateGFWList, new EventHandler(UpdateGFWListItem_Click)),
                    CreateMenuSeperator(),
                    // -----
                    new MenuItem(I18n.MenuItemEditUserRules, new EventHandler(EditUserRulesItem_Click)),
                    new MenuItem(I18n.MenuItemCopyPACScriptURL, new EventHandler(CopyPACScriptURL_Click)),
                }),
                CreateMenuSeperator(),
                // -----
                serversItem = CreateMenuGroup(I18n.MenuGroupServers),
                new MenuItem(I18n.MenuItemEditServers, new EventHandler(EditServersItem_Click)),
                CreateMenuSeperator(),
                // -----
                new MenuItem(I18n.MenuItemSetting, new EventHandler(SettingItem_Click)),
                CreateMenuGroup(I18n.MenuGroupHelp, new MenuItem[] {
                    new MenuItem(I18n.MenuItemWiki, new EventHandler(WikiItem_Click)),
                    new MenuItem(I18n.MenuItemCheckForUpdate, new EventHandler(CheckForUpdateItem_Click)),
                    new MenuItem(I18n.MenuItemFeedback, new EventHandler(FeedbackItem_Click)),
                    new MenuItem(I18n.MenuItemShowLog, new EventHandler(ShowLogItem_Click)),
                    CreateMenuSeperator(),
                    // -----
                    new MenuItem(I18n.MenuItemAbout, new EventHandler(AboutItem_Click)),
                }),
                new MenuItem(I18n.MenuItemExit, new EventHandler(ExitItem_Click))
            });

            return menu;
        }

        public void ShowEditServersForm() => EditServersItem_Click(this, null);

        /// <summary>
        /// Update servers shown in the `servers` menu
        /// </summary>
        public void UpdateServers()
        {
            serversItem.MenuItems.Clear();
            var servers = Setting.Servers;
            if (servers.Count == 0) serversItem.MenuItems.Add(noServersHintItem);
            else
            {
                var activeServer = Setting.ActiveServer;

                var items = servers.Select(s =>
                {
                    var item = new MenuItem(s.ToString(), new EventHandler(ServerItem_Click));
                    item.Checked = s.Equals(activeServer);
                    return item;
                });

                serversItem.MenuItems.AddRange(items.ToArray());
            }
        }

        public void ShowBalloonTip(string content, ToolTipIcon icon, int timeout = 3000)
        {
            notifyIcon.ShowBalloonTip(timeout, Setting.AppName, content, icon);
        }

        public void SwitchProxyMode(ProxyMode mode)
        {
            switch (mode)
            {
                case ProxyMode.Global:
                    keepSystemProxyModeItem.Checked = false;
                    directModeItem.Checked = false;
                    globalModeItem.Checked = true;
                    pacModeItem.Checked = false;
                    break;
                case ProxyMode.PAC:
                    keepSystemProxyModeItem.Checked = false;
                    directModeItem.Checked = false;
                    globalModeItem.Checked = false;
                    pacModeItem.Checked = true;
                    break;
                case ProxyMode.Disable:
                    keepSystemProxyModeItem.Checked = false;
                    directModeItem.Checked = true;
                    globalModeItem.Checked = false;
                    pacModeItem.Checked = false;
                    break;
                case ProxyMode.KeepSystemProxy:
                default:
                    keepSystemProxyModeItem.Checked = true;
                    directModeItem.Checked = false;
                    globalModeItem.Checked = false;
                    pacModeItem.Checked = false;
                    break;
            }
            UpdateText();
        }

        public void UpdateText(string text)
        {
            if (text.Length >= 128) text = text.Substring(0, 124) + "...";
            var t = notifyIcon.GetType();
            var hidden = BindingFlags.NonPublic | BindingFlags.Instance;
            var textField = t.GetField("text", hidden);
            textField.SetValue(notifyIcon, text);
            if ((bool)t.GetField("added", hidden).GetValue(notifyIcon))
                t.GetMethod("UpdateIcon", hidden).Invoke(notifyIcon, new object[] { true });
        }

        public void UpdateText()
        {
            var mode = string.Empty;
            switch (v2rayP.Setting.Mode)
            {
                case ProxyMode.Disable: mode = I18n.ProxyModeDirect; break;
                case ProxyMode.PAC: mode = I18n.ProxyModePac; break;
                case ProxyMode.Global: mode = I18n.ProxyModeGlobal; break;
                case ProxyMode.KeepSystemProxy: mode = I18n.ProxyModeKeepSystemProxy; break;
                default: break;
            }

            var server = Setting.ActiveServer?.ToString() ?? I18n.None;
            UpdateText(string.Format(I18n.NotifyIconTextTemplate, mode, server));
        }

        #region Menu Click Handlers
        private void SettingItem_Click(object sender, EventArgs e)
        {
            if (settingForm == null)
            {
                settingForm = new SettingForm();
                settingForm.FormClosed += (s, ev) =>
                {
                    settingForm.Dispose();
                    settingForm = null;
                };
            }

            settingForm.Show();
            settingForm.Activate();
            settingForm.BringToFront();
        }

        private void KeepSystemProxyModeItem_Click(object sender, EventArgs e)
        {
            Launcher.SwitchProxyMode(ProxyMode.KeepSystemProxy);
        }

        private void DirectModeItem_Click(object sender, EventArgs e)
        {
            Launcher.SwitchProxyMode(ProxyMode.Disable);
        }

        private void PacModeItem_Click(object sender, EventArgs e)
        {
            Launcher.SwitchProxyMode(ProxyMode.PAC);
        }

        private void GlobalModeItem_Click(object sender, EventArgs e)
        {
            Launcher.SwitchProxyMode(ProxyMode.Global);
        }

        private void EditServersItem_Click(object sender, EventArgs e)
        {
            if (editServersForm == null)
            {
                editServersForm = new EditServersForm();
                editServersForm.FormClosed += (s, ev) =>
                {
                    editServersForm.Dispose();
                    editServersForm = null;
                };
            }

            editServersForm.Show();
            editServersForm.Activate();
            editServersForm.BringToFront();
        }

        private void WikiItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/PoseidonM4A4/v2rayP/wiki");
        }

        private void CheckForUpdateItem_Click(object sender, EventArgs e)
        {
            ShowBalloonTip(I18n.ComingSoon, ToolTipIcon.Error);
        }

        private void ShowLogItem_Click(object sender, EventArgs e)
        {
            if (showLogForm == null)
            {
                showLogForm = new ShowLogForm();
                showLogForm.FormClosed += (s, ev) =>
                {
                    showLogForm.Dispose();
                    showLogForm = null;
                };
            }

            showLogForm.Show();
            showLogForm.Activate();
            showLogForm.BringToFront();
        }

        private void FeedbackItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/PoseidonM4A4/v2rayP/issues");
        }

        private void AboutItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/PoseidonM4A4/v2rayP");
        }

        private void ExitItem_Click(object sender, EventArgs e)
        {
            Launcher.Stop();
        }

        private void ServerItem_Click(object sender, EventArgs e)
        {
            var item = sender as MenuItem;
            var index = item.Index;

            if (!item.Checked)
            {
                item.Checked = true;
                item.Parent.MenuItems[Setting.ActiveServerIndex].Checked = false;
            }

            Launcher.ActivateServer(index);
            UpdateText();
        }

        private void CopyPACScriptURL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Launcher.Pac.PacScriptURL);
        }

        private void EditUserRulesItem_Click(object sender, EventArgs e)
        {
            var customRulePath = Launcher.Pac.CustomRulePath;
            System.Diagnostics.Process.Start("explorer.exe", $"/select,\"{customRulePath}\"");
        }

        private void UpdateGFWListItem_Click(object sender, EventArgs e)
        {
            Launcher.GetGFWList(v2rayP.Setting.GFWListURL);
        }
        #endregion

        #region Create Context Menu Methods
        private static MenuItem CreateMenuGroup(string text, MenuItem[] items)
        {
            return new MenuItem(text, items);
        }

        private MenuItem CreateMenuGroup(string text)
        {
            return new MenuItem(text);
        }

        private MenuItem CreateMenuSeperator()
        {
            return new MenuItem("-");
        }
        #endregion

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    notifyIcon = null;

                    keepSystemProxyModeItem = null;
                    directModeItem = null;
                    pacModeItem = null;
                    globalModeItem = null;
                    serversItem = null;
                    noServersHintItem = null;

                    if (editServersForm != null) editServersForm.Dispose();
                    if (showLogForm != null) showLogForm.Dispose();
                    if (settingForm != null) settingForm.Dispose(); ;
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~NotifyIcon() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
