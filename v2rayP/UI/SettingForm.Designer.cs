namespace v2rayP.UI
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxAutoStart = new System.Windows.Forms.CheckBox();
            this.groupBoxV2RayPSetting = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelV2RaySetting = new System.Windows.Forms.TableLayoutPanel();
            this.labelGFWListURL = new System.Windows.Forms.Label();
            this.comboBoxLogLevel = new System.Windows.Forms.ComboBox();
            this.textBoxGFWListURL = new System.Windows.Forms.TextBox();
            this.labelV2RayPLogLevel = new System.Windows.Forms.Label();
            this.checkBoxEnableAccessLog = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableErrorLog = new System.Windows.Forms.CheckBox();
            this.groupBoxLocalProxySetting = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelLocalProxySetting = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxAcceptLAN = new System.Windows.Forms.CheckBox();
            this.labelSock5ProxyPort = new System.Windows.Forms.Label();
            this.labelHTTPProxyPort = new System.Windows.Forms.Label();
            this.labelPACServerPort = new System.Windows.Forms.Label();
            this.numericUpDownSock5Port = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHTTPPort = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPACPort = new System.Windows.Forms.NumericUpDown();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxUpdateViaProxy = new System.Windows.Forms.CheckBox();
            this.groupBoxV2RayPSetting.SuspendLayout();
            this.tableLayoutPanelV2RaySetting.SuspendLayout();
            this.groupBoxLocalProxySetting.SuspendLayout();
            this.tableLayoutPanelLocalProxySetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSock5Port)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHTTPPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPACPort)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxAutoStart
            // 
            this.checkBoxAutoStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAutoStart.AutoSize = true;
            this.checkBoxAutoStart.Location = new System.Drawing.Point(93, 3);
            this.checkBoxAutoStart.Name = "checkBoxAutoStart";
            this.checkBoxAutoStart.Size = new System.Drawing.Size(251, 21);
            this.checkBoxAutoStart.TabIndex = 0;
            this.checkBoxAutoStart.Text = "AutoStart";
            this.checkBoxAutoStart.UseVisualStyleBackColor = true;
            // 
            // groupBoxV2RayPSetting
            // 
            this.groupBoxV2RayPSetting.AutoSize = true;
            this.groupBoxV2RayPSetting.Controls.Add(this.tableLayoutPanelV2RaySetting);
            this.groupBoxV2RayPSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxV2RayPSetting.Location = new System.Drawing.Point(8, 8);
            this.groupBoxV2RayPSetting.Name = "groupBoxV2RayPSetting";
            this.groupBoxV2RayPSetting.Padding = new System.Windows.Forms.Padding(8);
            this.groupBoxV2RayPSetting.Size = new System.Drawing.Size(363, 200);
            this.groupBoxV2RayPSetting.TabIndex = 1;
            this.groupBoxV2RayPSetting.TabStop = false;
            this.groupBoxV2RayPSetting.Text = "v2rayP Setting";
            // 
            // tableLayoutPanelV2RaySetting
            // 
            this.tableLayoutPanelV2RaySetting.AutoSize = true;
            this.tableLayoutPanelV2RaySetting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelV2RaySetting.ColumnCount = 2;
            this.tableLayoutPanelV2RaySetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelV2RaySetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelV2RaySetting.Controls.Add(this.textBoxGFWListURL, 1, 5);
            this.tableLayoutPanelV2RaySetting.Controls.Add(this.comboBoxLogLevel, 1, 4);
            this.tableLayoutPanelV2RaySetting.Controls.Add(this.labelGFWListURL, 0, 5);
            this.tableLayoutPanelV2RaySetting.Controls.Add(this.labelV2RayPLogLevel, 0, 4);
            this.tableLayoutPanelV2RaySetting.Controls.Add(this.checkBoxAutoStart, 1, 0);
            this.tableLayoutPanelV2RaySetting.Controls.Add(this.checkBoxEnableAccessLog, 1, 2);
            this.tableLayoutPanelV2RaySetting.Controls.Add(this.checkBoxUpdateViaProxy, 1, 1);
            this.tableLayoutPanelV2RaySetting.Controls.Add(this.checkBoxEnableErrorLog, 1, 3);
            this.tableLayoutPanelV2RaySetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelV2RaySetting.Location = new System.Drawing.Point(8, 24);
            this.tableLayoutPanelV2RaySetting.Name = "tableLayoutPanelV2RaySetting";
            this.tableLayoutPanelV2RaySetting.RowCount = 6;
            this.tableLayoutPanelV2RaySetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelV2RaySetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelV2RaySetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelV2RaySetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelV2RaySetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelV2RaySetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelV2RaySetting.Size = new System.Drawing.Size(347, 168);
            this.tableLayoutPanelV2RaySetting.TabIndex = 0;
            // 
            // labelGFWListURL
            // 
            this.labelGFWListURL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelGFWListURL.AutoSize = true;
            this.labelGFWListURL.Location = new System.Drawing.Point(3, 145);
            this.labelGFWListURL.Name = "labelGFWListURL";
            this.labelGFWListURL.Size = new System.Drawing.Size(84, 17);
            this.labelGFWListURL.TabIndex = 2;
            this.labelGFWListURL.Text = "GFWList URL:";
            // 
            // comboBoxLogLevel
            // 
            this.comboBoxLogLevel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxLogLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLogLevel.FormattingEnabled = true;
            this.comboBoxLogLevel.Items.AddRange(new object[] {
            "None",
            "Error",
            "Warning",
            "Info",
            "Debug"});
            this.comboBoxLogLevel.Location = new System.Drawing.Point(93, 111);
            this.comboBoxLogLevel.Name = "comboBoxLogLevel";
            this.comboBoxLogLevel.Size = new System.Drawing.Size(164, 25);
            this.comboBoxLogLevel.TabIndex = 5;
            // 
            // textBoxGFWListURL
            // 
            this.textBoxGFWListURL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxGFWListURL.Location = new System.Drawing.Point(93, 142);
            this.textBoxGFWListURL.Name = "textBoxGFWListURL";
            this.textBoxGFWListURL.Size = new System.Drawing.Size(251, 23);
            this.textBoxGFWListURL.TabIndex = 1;
            // 
            // labelV2RayPLogLevel
            // 
            this.labelV2RayPLogLevel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelV2RayPLogLevel.AutoSize = true;
            this.labelV2RayPLogLevel.Location = new System.Drawing.Point(21, 115);
            this.labelV2RayPLogLevel.Name = "labelV2RayPLogLevel";
            this.labelV2RayPLogLevel.Size = new System.Drawing.Size(66, 17);
            this.labelV2RayPLogLevel.TabIndex = 4;
            this.labelV2RayPLogLevel.Text = "Log Level:";
            // 
            // checkBoxEnableAccessLog
            // 
            this.checkBoxEnableAccessLog.AutoSize = true;
            this.checkBoxEnableAccessLog.Location = new System.Drawing.Point(93, 57);
            this.checkBoxEnableAccessLog.Name = "checkBoxEnableAccessLog";
            this.checkBoxEnableAccessLog.Size = new System.Drawing.Size(135, 21);
            this.checkBoxEnableAccessLog.TabIndex = 4;
            this.checkBoxEnableAccessLog.Text = "Enable Access Log";
            this.checkBoxEnableAccessLog.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableErrorLog
            // 
            this.checkBoxEnableErrorLog.AutoSize = true;
            this.checkBoxEnableErrorLog.Location = new System.Drawing.Point(93, 84);
            this.checkBoxEnableErrorLog.Name = "checkBoxEnableErrorLog";
            this.checkBoxEnableErrorLog.Size = new System.Drawing.Size(126, 21);
            this.checkBoxEnableErrorLog.TabIndex = 4;
            this.checkBoxEnableErrorLog.Text = "Enable Error Log";
            this.checkBoxEnableErrorLog.UseVisualStyleBackColor = true;
            // 
            // groupBoxLocalProxySetting
            // 
            this.groupBoxLocalProxySetting.AutoSize = true;
            this.groupBoxLocalProxySetting.Controls.Add(this.tableLayoutPanelLocalProxySetting);
            this.groupBoxLocalProxySetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxLocalProxySetting.Location = new System.Drawing.Point(8, 208);
            this.groupBoxLocalProxySetting.Name = "groupBoxLocalProxySetting";
            this.groupBoxLocalProxySetting.Padding = new System.Windows.Forms.Padding(8);
            this.groupBoxLocalProxySetting.Size = new System.Drawing.Size(363, 146);
            this.groupBoxLocalProxySetting.TabIndex = 2;
            this.groupBoxLocalProxySetting.TabStop = false;
            this.groupBoxLocalProxySetting.Text = "Local Proxy Setting";
            // 
            // tableLayoutPanelLocalProxySetting
            // 
            this.tableLayoutPanelLocalProxySetting.AutoSize = true;
            this.tableLayoutPanelLocalProxySetting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelLocalProxySetting.ColumnCount = 2;
            this.tableLayoutPanelLocalProxySetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelLocalProxySetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLocalProxySetting.Controls.Add(this.checkBoxAcceptLAN, 1, 0);
            this.tableLayoutPanelLocalProxySetting.Controls.Add(this.labelSock5ProxyPort, 0, 1);
            this.tableLayoutPanelLocalProxySetting.Controls.Add(this.labelHTTPProxyPort, 0, 2);
            this.tableLayoutPanelLocalProxySetting.Controls.Add(this.labelPACServerPort, 0, 3);
            this.tableLayoutPanelLocalProxySetting.Controls.Add(this.numericUpDownSock5Port, 1, 1);
            this.tableLayoutPanelLocalProxySetting.Controls.Add(this.numericUpDownHTTPPort, 1, 2);
            this.tableLayoutPanelLocalProxySetting.Controls.Add(this.numericUpDownPACPort, 1, 3);
            this.tableLayoutPanelLocalProxySetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLocalProxySetting.Location = new System.Drawing.Point(8, 24);
            this.tableLayoutPanelLocalProxySetting.Name = "tableLayoutPanelLocalProxySetting";
            this.tableLayoutPanelLocalProxySetting.RowCount = 4;
            this.tableLayoutPanelLocalProxySetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLocalProxySetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLocalProxySetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLocalProxySetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLocalProxySetting.Size = new System.Drawing.Size(347, 114);
            this.tableLayoutPanelLocalProxySetting.TabIndex = 0;
            // 
            // checkBoxAcceptLAN
            // 
            this.checkBoxAcceptLAN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxAcceptLAN.AutoSize = true;
            this.checkBoxAcceptLAN.Location = new System.Drawing.Point(124, 3);
            this.checkBoxAcceptLAN.Name = "checkBoxAcceptLAN";
            this.checkBoxAcceptLAN.Size = new System.Drawing.Size(169, 21);
            this.checkBoxAcceptLAN.TabIndex = 0;
            this.checkBoxAcceptLAN.Text = "Accept LAN Connections";
            this.checkBoxAcceptLAN.UseVisualStyleBackColor = true;
            // 
            // labelSock5ProxyPort
            // 
            this.labelSock5ProxyPort.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSock5ProxyPort.AutoSize = true;
            this.labelSock5ProxyPort.Location = new System.Drawing.Point(3, 33);
            this.labelSock5ProxyPort.Name = "labelSock5ProxyPort";
            this.labelSock5ProxyPort.Size = new System.Drawing.Size(115, 17);
            this.labelSock5ProxyPort.TabIndex = 1;
            this.labelSock5ProxyPort.Text = "SOCK5 Proxy Port:";
            // 
            // labelHTTPProxyPort
            // 
            this.labelHTTPProxyPort.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelHTTPProxyPort.AutoSize = true;
            this.labelHTTPProxyPort.Location = new System.Drawing.Point(13, 62);
            this.labelHTTPProxyPort.Name = "labelHTTPProxyPort";
            this.labelHTTPProxyPort.Size = new System.Drawing.Size(105, 17);
            this.labelHTTPProxyPort.TabIndex = 1;
            this.labelHTTPProxyPort.Text = "HTTP Proxy Port:";
            // 
            // labelPACServerPort
            // 
            this.labelPACServerPort.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPACServerPort.AutoSize = true;
            this.labelPACServerPort.Location = new System.Drawing.Point(15, 91);
            this.labelPACServerPort.Name = "labelPACServerPort";
            this.labelPACServerPort.Size = new System.Drawing.Size(103, 17);
            this.labelPACServerPort.TabIndex = 1;
            this.labelPACServerPort.Text = "PAC Server Port:";
            // 
            // numericUpDownSock5Port
            // 
            this.numericUpDownSock5Port.Location = new System.Drawing.Point(124, 30);
            this.numericUpDownSock5Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownSock5Port.Name = "numericUpDownSock5Port";
            this.numericUpDownSock5Port.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownSock5Port.TabIndex = 4;
            // 
            // numericUpDownHTTPPort
            // 
            this.numericUpDownHTTPPort.Location = new System.Drawing.Point(124, 59);
            this.numericUpDownHTTPPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownHTTPPort.Name = "numericUpDownHTTPPort";
            this.numericUpDownHTTPPort.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownHTTPPort.TabIndex = 4;
            // 
            // numericUpDownPACPort
            // 
            this.numericUpDownPACPort.Location = new System.Drawing.Point(124, 88);
            this.numericUpDownPACPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPACPort.Name = "numericUpDownPACPort";
            this.numericUpDownPACPort.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownPACPort.TabIndex = 4;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(285, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 36);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSave.Location = new System.Drawing.Point(204, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 36);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.buttonClose);
            this.flowLayoutPanel1.Controls.Add(this.buttonSave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 404);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(363, 42);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // checkBoxUpdateViaProxy
            // 
            this.checkBoxUpdateViaProxy.AutoSize = true;
            this.checkBoxUpdateViaProxy.Location = new System.Drawing.Point(93, 30);
            this.checkBoxUpdateViaProxy.Name = "checkBoxUpdateViaProxy";
            this.checkBoxUpdateViaProxy.Size = new System.Drawing.Size(128, 21);
            this.checkBoxUpdateViaProxy.TabIndex = 6;
            this.checkBoxUpdateViaProxy.Text = "Update Via Proxy";
            this.checkBoxUpdateViaProxy.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(379, 454);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBoxLocalProxySetting);
            this.Controls.Add(this.groupBoxV2RayPSetting);
            this.Name = "SettingForm";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.groupBoxV2RayPSetting.ResumeLayout(false);
            this.groupBoxV2RayPSetting.PerformLayout();
            this.tableLayoutPanelV2RaySetting.ResumeLayout(false);
            this.tableLayoutPanelV2RaySetting.PerformLayout();
            this.groupBoxLocalProxySetting.ResumeLayout(false);
            this.groupBoxLocalProxySetting.PerformLayout();
            this.tableLayoutPanelLocalProxySetting.ResumeLayout(false);
            this.tableLayoutPanelLocalProxySetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSock5Port)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHTTPPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPACPort)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxAutoStart;
        private System.Windows.Forms.GroupBox groupBoxV2RayPSetting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelV2RaySetting;
        private System.Windows.Forms.GroupBox groupBoxLocalProxySetting;
        private System.Windows.Forms.Label labelPACServerPort;
        private System.Windows.Forms.Label labelHTTPProxyPort;
        private System.Windows.Forms.Label labelSock5ProxyPort;
        private System.Windows.Forms.CheckBox checkBoxAcceptLAN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLocalProxySetting;
        private System.Windows.Forms.NumericUpDown numericUpDownSock5Port;
        private System.Windows.Forms.NumericUpDown numericUpDownHTTPPort;
        private System.Windows.Forms.NumericUpDown numericUpDownPACPort;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelV2RayPLogLevel;
        private System.Windows.Forms.ComboBox comboBoxLogLevel;
        private System.Windows.Forms.Label labelGFWListURL;
        private System.Windows.Forms.TextBox textBoxGFWListURL;
        private System.Windows.Forms.CheckBox checkBoxEnableAccessLog;
        private System.Windows.Forms.CheckBox checkBoxEnableErrorLog;
        private System.Windows.Forms.CheckBox checkBoxUpdateViaProxy;
    }
}
