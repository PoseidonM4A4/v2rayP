namespace v2rayP.UI
{
    partial class EditServersForm
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
            System.Windows.Forms.TableLayoutPanel tableLayoutPanelServerListControl;
            System.Windows.Forms.Label labelKCPHeaderType;
            System.Windows.Forms.Label labelKCPMTU;
            System.Windows.Forms.Label labelKCPTTI;
            System.Windows.Forms.Label labelDownlinkCapacity;
            System.Windows.Forms.Label labelWriteBufferSize;
            System.Windows.Forms.Label labelReadBufferSize;
            System.Windows.Forms.Label labelUplinkCapacity;
            System.Windows.Forms.Label WebSocketPath;
            System.Windows.Forms.Label labelWebSocketHeaders;
            this.buttonAddServer = new System.Windows.Forms.Button();
            this.buttonRemoveServer = new System.Windows.Forms.Button();
            this.panelServerList = new System.Windows.Forms.Panel();
            this.listBoxServersList = new System.Windows.Forms.ListBox();
            this.panelEditServer = new System.Windows.Forms.Panel();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxV2RayServerConfig = new System.Windows.Forms.GroupBox();
            this.groupBoxTLSSetting = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelTLSSettings = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxEnableTLS = new System.Windows.Forms.CheckBox();
            this.checkBoxAllowInsecure = new System.Windows.Forms.CheckBox();
            this.labelServerName = new System.Windows.Forms.Label();
            this.textBoxTLSServerName = new System.Windows.Forms.TextBox();
            this.groupBoxStreamSettings = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelKCPSettings = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxKCPHeaderType = new System.Windows.Forms.ComboBox();
            this.checkBoxCongestion = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanelTCPSettings = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlTCPHTTPSetting = new System.Windows.Forms.TabControl();
            this.tabPageHTTPReqeustSetting = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelHTTPRequest = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxHTTPRequestHeaders = new System.Windows.Forms.TextBox();
            this.textBoxHTTPRequestMethod = new System.Windows.Forms.TextBox();
            this.labelHTTPRequestMethod = new System.Windows.Forms.Label();
            this.labelHTTPRequestVersion = new System.Windows.Forms.Label();
            this.textBoxHTTPRequestVersion = new System.Windows.Forms.TextBox();
            this.textBoxHTTPRequestPaths = new System.Windows.Forms.TextBox();
            this.labelHTTPRequestPaths = new System.Windows.Forms.Label();
            this.labelHTTPRequestHeaders = new System.Windows.Forms.Label();
            this.tabPageHTTPResponseSetting = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelHTTPResponse = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxHTTPResponseHeaders = new System.Windows.Forms.TextBox();
            this.textBoxHTTPResponseStatus = new System.Windows.Forms.TextBox();
            this.labelHTTPResponseStatus = new System.Windows.Forms.Label();
            this.labelHTTPResponseVersion = new System.Windows.Forms.Label();
            this.textBoxHTTPResponseVersion = new System.Windows.Forms.TextBox();
            this.textBoxHTTPResponseReason = new System.Windows.Forms.TextBox();
            this.labelHTTPResponseReason = new System.Windows.Forms.Label();
            this.labelHTTPResponseHeaders = new System.Windows.Forms.Label();
            this.labelTCPType = new System.Windows.Forms.Label();
            this.comboBoxTCPType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelWebSocketSettings = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxWebSocketPath = new System.Windows.Forms.TextBox();
            this.textBoxWebSocketHeaders = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelStreamSettings = new System.Windows.Forms.TableLayoutPanel();
            this.labelNetwork = new System.Windows.Forms.Label();
            this.comboBoxNetwork = new System.Windows.Forms.ComboBox();
            this.checkBoxEnableMux = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanelVMessBasic = new System.Windows.Forms.TableLayoutPanel();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.comboBoxSecurity = new System.Windows.Forms.ComboBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelSecurity = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelAlterId = new System.Windows.Forms.Label();
            this.buttonGenerateID = new System.Windows.Forms.Button();
            this.labelRemark = new System.Windows.Forms.Label();
            this.textBoxRemark = new System.Windows.Forms.TextBox();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAlterID = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKCPMTU = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKCPWriteBufferSize = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKCPReadBufferSize = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKCPDownlinkCapacity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKCPUplinkCapacity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKCPTTI = new System.Windows.Forms.NumericUpDown();
            tableLayoutPanelServerListControl = new System.Windows.Forms.TableLayoutPanel();
            labelKCPHeaderType = new System.Windows.Forms.Label();
            labelKCPMTU = new System.Windows.Forms.Label();
            labelKCPTTI = new System.Windows.Forms.Label();
            labelDownlinkCapacity = new System.Windows.Forms.Label();
            labelWriteBufferSize = new System.Windows.Forms.Label();
            labelReadBufferSize = new System.Windows.Forms.Label();
            labelUplinkCapacity = new System.Windows.Forms.Label();
            WebSocketPath = new System.Windows.Forms.Label();
            labelWebSocketHeaders = new System.Windows.Forms.Label();
            tableLayoutPanelServerListControl.SuspendLayout();
            this.panelServerList.SuspendLayout();
            this.panelEditServer.SuspendLayout();
            this.flowLayoutPanelButtons.SuspendLayout();
            this.groupBoxV2RayServerConfig.SuspendLayout();
            this.groupBoxTLSSetting.SuspendLayout();
            this.tableLayoutPanelTLSSettings.SuspendLayout();
            this.groupBoxStreamSettings.SuspendLayout();
            this.tableLayoutPanelKCPSettings.SuspendLayout();
            this.tableLayoutPanelTCPSettings.SuspendLayout();
            this.tabControlTCPHTTPSetting.SuspendLayout();
            this.tabPageHTTPReqeustSetting.SuspendLayout();
            this.tableLayoutPanelHTTPRequest.SuspendLayout();
            this.tabPageHTTPResponseSetting.SuspendLayout();
            this.tableLayoutPanelHTTPResponse.SuspendLayout();
            this.tableLayoutPanelWebSocketSettings.SuspendLayout();
            this.tableLayoutPanelStreamSettings.SuspendLayout();
            this.tableLayoutPanelVMessBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKCPMTU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKCPWriteBufferSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKCPReadBufferSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKCPDownlinkCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKCPUplinkCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKCPTTI)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelServerListControl
            // 
            tableLayoutPanelServerListControl.ColumnCount = 2;
            tableLayoutPanelServerListControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelServerListControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelServerListControl.Controls.Add(this.buttonAddServer, 0, 0);
            tableLayoutPanelServerListControl.Controls.Add(this.buttonRemoveServer, 1, 0);
            tableLayoutPanelServerListControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            tableLayoutPanelServerListControl.Location = new System.Drawing.Point(5, 590);
            tableLayoutPanelServerListControl.Name = "tableLayoutPanelServerListControl";
            tableLayoutPanelServerListControl.RowCount = 1;
            tableLayoutPanelServerListControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelServerListControl.Size = new System.Drawing.Size(199, 40);
            tableLayoutPanelServerListControl.TabIndex = 1;
            // 
            // buttonAddServer
            // 
            this.buttonAddServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddServer.Location = new System.Drawing.Point(0, 0);
            this.buttonAddServer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddServer.Name = "buttonAddServer";
            this.buttonAddServer.Size = new System.Drawing.Size(99, 40);
            this.buttonAddServer.TabIndex = 0;
            this.buttonAddServer.Text = "&Add";
            this.buttonAddServer.UseVisualStyleBackColor = true;
            this.buttonAddServer.Click += new System.EventHandler(this.buttonAddServer_Click);
            // 
            // buttonRemoveServer
            // 
            this.buttonRemoveServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemoveServer.Location = new System.Drawing.Point(99, 0);
            this.buttonRemoveServer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemoveServer.Name = "buttonRemoveServer";
            this.buttonRemoveServer.Size = new System.Drawing.Size(100, 40);
            this.buttonRemoveServer.TabIndex = 1;
            this.buttonRemoveServer.Text = "&Remove";
            this.buttonRemoveServer.UseVisualStyleBackColor = true;
            this.buttonRemoveServer.Click += new System.EventHandler(this.buttonRemoveServer_Click);
            // 
            // labelKCPHeaderType
            // 
            labelKCPHeaderType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelKCPHeaderType.AutoSize = true;
            labelKCPHeaderType.Location = new System.Drawing.Point(42, 7);
            labelKCPHeaderType.Name = "labelKCPHeaderType";
            labelKCPHeaderType.Size = new System.Drawing.Size(86, 17);
            labelKCPHeaderType.TabIndex = 0;
            labelKCPHeaderType.Text = "Header Type:";
            // 
            // labelKCPMTU
            // 
            labelKCPMTU.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelKCPMTU.AutoSize = true;
            labelKCPMTU.Location = new System.Drawing.Point(95, 37);
            labelKCPMTU.Name = "labelKCPMTU";
            labelKCPMTU.Size = new System.Drawing.Size(33, 17);
            labelKCPMTU.TabIndex = 0;
            labelKCPMTU.Text = "mtu:";
            // 
            // labelKCPTTI
            // 
            labelKCPTTI.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelKCPTTI.AutoSize = true;
            labelKCPTTI.Location = new System.Drawing.Point(357, 37);
            labelKCPTTI.Name = "labelKCPTTI";
            labelKCPTTI.Size = new System.Drawing.Size(22, 17);
            labelKCPTTI.TabIndex = 0;
            labelKCPTTI.Text = "tti:";
            // 
            // labelDownlinkCapacity
            // 
            labelDownlinkCapacity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelDownlinkCapacity.AutoSize = true;
            labelDownlinkCapacity.Location = new System.Drawing.Point(228, 95);
            labelDownlinkCapacity.Name = "labelDownlinkCapacity";
            labelDownlinkCapacity.Size = new System.Drawing.Size(151, 17);
            labelDownlinkCapacity.TabIndex = 0;
            labelDownlinkCapacity.Text = "downlinkCapacity(MB/s):";
            // 
            // labelWriteBufferSize
            // 
            labelWriteBufferSize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelWriteBufferSize.AutoSize = true;
            labelWriteBufferSize.Location = new System.Drawing.Point(3, 66);
            labelWriteBufferSize.Name = "labelWriteBufferSize";
            labelWriteBufferSize.Size = new System.Drawing.Size(125, 17);
            labelWriteBufferSize.TabIndex = 0;
            labelWriteBufferSize.Text = "writeBufferSize(MB):";
            // 
            // labelReadBufferSize
            // 
            labelReadBufferSize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelReadBufferSize.AutoSize = true;
            labelReadBufferSize.Location = new System.Drawing.Point(4, 95);
            labelReadBufferSize.Name = "labelReadBufferSize";
            labelReadBufferSize.Size = new System.Drawing.Size(124, 17);
            labelReadBufferSize.TabIndex = 0;
            labelReadBufferSize.Text = "readBufferSize(MB):";
            // 
            // labelUplinkCapacity
            // 
            labelUplinkCapacity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelUplinkCapacity.AutoSize = true;
            labelUplinkCapacity.Location = new System.Drawing.Point(245, 66);
            labelUplinkCapacity.Name = "labelUplinkCapacity";
            labelUplinkCapacity.Size = new System.Drawing.Size(134, 17);
            labelUplinkCapacity.TabIndex = 0;
            labelUplinkCapacity.Text = "uplinkCapacity(MB/s):";
            // 
            // WebSocketPath
            // 
            WebSocketPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            WebSocketPath.AutoSize = true;
            WebSocketPath.Location = new System.Drawing.Point(3, 6);
            WebSocketPath.Name = "WebSocketPath";
            WebSocketPath.Size = new System.Drawing.Size(36, 17);
            WebSocketPath.TabIndex = 0;
            WebSocketPath.Text = "Path:";
            // 
            // labelWebSocketHeaders
            // 
            labelWebSocketHeaders.Anchor = System.Windows.Forms.AnchorStyles.Left;
            labelWebSocketHeaders.AutoSize = true;
            this.tableLayoutPanelWebSocketSettings.SetColumnSpan(labelWebSocketHeaders, 2);
            labelWebSocketHeaders.Location = new System.Drawing.Point(3, 32);
            labelWebSocketHeaders.Margin = new System.Windows.Forms.Padding(3);
            labelWebSocketHeaders.Name = "labelWebSocketHeaders";
            labelWebSocketHeaders.Size = new System.Drawing.Size(60, 17);
            labelWebSocketHeaders.TabIndex = 0;
            labelWebSocketHeaders.Text = "Headers:";
            // 
            // panelServerList
            // 
            this.panelServerList.Controls.Add(tableLayoutPanelServerListControl);
            this.panelServerList.Controls.Add(this.listBoxServersList);
            this.panelServerList.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelServerList.Location = new System.Drawing.Point(0, 0);
            this.panelServerList.Name = "panelServerList";
            this.panelServerList.Padding = new System.Windows.Forms.Padding(5);
            this.panelServerList.Size = new System.Drawing.Size(209, 635);
            this.panelServerList.TabIndex = 0;
            // 
            // listBoxServersList
            // 
            this.listBoxServersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxServersList.FormattingEnabled = true;
            this.listBoxServersList.ItemHeight = 17;
            this.listBoxServersList.Location = new System.Drawing.Point(5, 5);
            this.listBoxServersList.Name = "listBoxServersList";
            this.listBoxServersList.Size = new System.Drawing.Size(199, 582);
            this.listBoxServersList.TabIndex = 0;
            this.listBoxServersList.SelectedIndexChanged += new System.EventHandler(this.listBoxServersList_SelectedIndexChanged);
            // 
            // panelEditServer
            // 
            this.panelEditServer.Controls.Add(this.flowLayoutPanelButtons);
            this.panelEditServer.Controls.Add(this.groupBoxV2RayServerConfig);
            this.panelEditServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEditServer.Location = new System.Drawing.Point(209, 0);
            this.panelEditServer.Name = "panelEditServer";
            this.panelEditServer.Padding = new System.Windows.Forms.Padding(5);
            this.panelEditServer.Size = new System.Drawing.Size(522, 635);
            this.panelEditServer.TabIndex = 1;
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.Controls.Add(this.buttonClose);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonSave);
            this.flowLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(5, 590);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(512, 40);
            this.flowLayoutPanelButtons.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(426, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(86, 40);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(335, 0);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(86, 40);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBoxV2RayServerConfig
            // 
            this.groupBoxV2RayServerConfig.Controls.Add(this.groupBoxTLSSetting);
            this.groupBoxV2RayServerConfig.Controls.Add(this.groupBoxStreamSettings);
            this.groupBoxV2RayServerConfig.Controls.Add(this.tableLayoutPanelVMessBasic);
            this.groupBoxV2RayServerConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxV2RayServerConfig.Location = new System.Drawing.Point(5, 5);
            this.groupBoxV2RayServerConfig.Name = "groupBoxV2RayServerConfig";
            this.groupBoxV2RayServerConfig.Padding = new System.Windows.Forms.Padding(8);
            this.groupBoxV2RayServerConfig.Size = new System.Drawing.Size(512, 579);
            this.groupBoxV2RayServerConfig.TabIndex = 0;
            this.groupBoxV2RayServerConfig.TabStop = false;
            this.groupBoxV2RayServerConfig.Text = "V2Ray Server Config";
            // 
            // groupBoxTLSSetting
            // 
            this.groupBoxTLSSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTLSSetting.AutoSize = true;
            this.groupBoxTLSSetting.Controls.Add(this.tableLayoutPanelTLSSettings);
            this.groupBoxTLSSetting.Location = new System.Drawing.Point(8, 481);
            this.groupBoxTLSSetting.Name = "groupBoxTLSSetting";
            this.groupBoxTLSSetting.Padding = new System.Windows.Forms.Padding(8);
            this.groupBoxTLSSetting.Size = new System.Drawing.Size(497, 88);
            this.groupBoxTLSSetting.TabIndex = 2;
            this.groupBoxTLSSetting.TabStop = false;
            this.groupBoxTLSSetting.Text = "TLSSettings";
            // 
            // tableLayoutPanelTLSSettings
            // 
            this.tableLayoutPanelTLSSettings.AutoSize = true;
            this.tableLayoutPanelTLSSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelTLSSettings.ColumnCount = 2;
            this.tableLayoutPanelTLSSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelTLSSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelTLSSettings.Controls.Add(this.checkBoxEnableTLS, 0, 0);
            this.tableLayoutPanelTLSSettings.Controls.Add(this.checkBoxAllowInsecure, 1, 0);
            this.tableLayoutPanelTLSSettings.Controls.Add(this.labelServerName, 0, 1);
            this.tableLayoutPanelTLSSettings.Controls.Add(this.textBoxTLSServerName, 1, 1);
            this.tableLayoutPanelTLSSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTLSSettings.Location = new System.Drawing.Point(8, 24);
            this.tableLayoutPanelTLSSettings.Name = "tableLayoutPanelTLSSettings";
            this.tableLayoutPanelTLSSettings.RowCount = 2;
            this.tableLayoutPanelTLSSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTLSSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTLSSettings.Size = new System.Drawing.Size(481, 56);
            this.tableLayoutPanelTLSSettings.TabIndex = 0;
            // 
            // checkBoxEnableTLS
            // 
            this.checkBoxEnableTLS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxEnableTLS.AutoSize = true;
            this.checkBoxEnableTLS.Location = new System.Drawing.Point(3, 3);
            this.checkBoxEnableTLS.Name = "checkBoxEnableTLS";
            this.checkBoxEnableTLS.Size = new System.Drawing.Size(90, 21);
            this.checkBoxEnableTLS.TabIndex = 0;
            this.checkBoxEnableTLS.Text = "Enable TLS";
            this.checkBoxEnableTLS.UseVisualStyleBackColor = true;
            this.checkBoxEnableTLS.CheckedChanged += new System.EventHandler(this.checkBoxEnableTLS_CheckedChanged);
            // 
            // checkBoxAllowInsecure
            // 
            this.checkBoxAllowInsecure.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxAllowInsecure.AutoSize = true;
            this.checkBoxAllowInsecure.Location = new System.Drawing.Point(99, 3);
            this.checkBoxAllowInsecure.Name = "checkBoxAllowInsecure";
            this.checkBoxAllowInsecure.Size = new System.Drawing.Size(180, 21);
            this.checkBoxAllowInsecure.TabIndex = 6;
            this.checkBoxAllowInsecure.Text = "Allow Insecure Connection";
            this.checkBoxAllowInsecure.UseVisualStyleBackColor = true;
            // 
            // labelServerName
            // 
            this.labelServerName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelServerName.AutoSize = true;
            this.labelServerName.Location = new System.Drawing.Point(3, 33);
            this.labelServerName.Name = "labelServerName";
            this.labelServerName.Size = new System.Drawing.Size(87, 17);
            this.labelServerName.TabIndex = 2;
            this.labelServerName.Text = "Server Name:";
            // 
            // textBoxTLSServerName
            // 
            this.textBoxTLSServerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTLSServerName.Location = new System.Drawing.Point(99, 30);
            this.textBoxTLSServerName.Name = "textBoxTLSServerName";
            this.textBoxTLSServerName.Size = new System.Drawing.Size(379, 23);
            this.textBoxTLSServerName.TabIndex = 3;
            // 
            // groupBoxStreamSettings
            // 
            this.groupBoxStreamSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStreamSettings.Controls.Add(this.tableLayoutPanelKCPSettings);
            this.groupBoxStreamSettings.Controls.Add(this.tableLayoutPanelTCPSettings);
            this.groupBoxStreamSettings.Controls.Add(this.tableLayoutPanelWebSocketSettings);
            this.groupBoxStreamSettings.Controls.Add(this.tableLayoutPanelStreamSettings);
            this.groupBoxStreamSettings.Location = new System.Drawing.Point(8, 148);
            this.groupBoxStreamSettings.Name = "groupBoxStreamSettings";
            this.groupBoxStreamSettings.Padding = new System.Windows.Forms.Padding(8);
            this.groupBoxStreamSettings.Size = new System.Drawing.Size(497, 327);
            this.groupBoxStreamSettings.TabIndex = 16;
            this.groupBoxStreamSettings.TabStop = false;
            this.groupBoxStreamSettings.Text = "StreamSettings";
            // 
            // tableLayoutPanelKCPSettings
            // 
            this.tableLayoutPanelKCPSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelKCPSettings.ColumnCount = 4;
            this.tableLayoutPanelKCPSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelKCPSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanelKCPSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelKCPSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanelKCPSettings.Controls.Add(labelReadBufferSize, 0, 3);
            this.tableLayoutPanelKCPSettings.Controls.Add(labelKCPTTI, 2, 1);
            this.tableLayoutPanelKCPSettings.Controls.Add(labelKCPMTU, 0, 1);
            this.tableLayoutPanelKCPSettings.Controls.Add(labelWriteBufferSize, 0, 2);
            this.tableLayoutPanelKCPSettings.Controls.Add(labelDownlinkCapacity, 2, 3);
            this.tableLayoutPanelKCPSettings.Controls.Add(labelUplinkCapacity, 2, 2);
            this.tableLayoutPanelKCPSettings.Controls.Add(this.comboBoxKCPHeaderType, 1, 0);
            this.tableLayoutPanelKCPSettings.Controls.Add(labelKCPHeaderType, 0, 0);
            this.tableLayoutPanelKCPSettings.Controls.Add(this.checkBoxCongestion, 3, 0);
            this.tableLayoutPanelKCPSettings.Controls.Add(this.numericUpDownKCPMTU, 1, 1);
            this.tableLayoutPanelKCPSettings.Controls.Add(this.numericUpDownKCPWriteBufferSize, 1, 2);
            this.tableLayoutPanelKCPSettings.Controls.Add(this.numericUpDownKCPReadBufferSize, 1, 3);
            this.tableLayoutPanelKCPSettings.Controls.Add(this.numericUpDownKCPDownlinkCapacity, 3, 3);
            this.tableLayoutPanelKCPSettings.Controls.Add(this.numericUpDownKCPUplinkCapacity, 3, 2);
            this.tableLayoutPanelKCPSettings.Controls.Add(this.numericUpDownKCPTTI, 3, 1);
            this.tableLayoutPanelKCPSettings.Location = new System.Drawing.Point(11, 186);
            this.tableLayoutPanelKCPSettings.Name = "tableLayoutPanelKCPSettings";
            this.tableLayoutPanelKCPSettings.RowCount = 4;
            this.tableLayoutPanelKCPSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelKCPSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelKCPSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelKCPSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelKCPSettings.Size = new System.Drawing.Size(481, 118);
            this.tableLayoutPanelKCPSettings.TabIndex = 20;
            // 
            // comboBoxKCPHeaderType
            // 
            this.comboBoxKCPHeaderType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanelKCPSettings.SetColumnSpan(this.comboBoxKCPHeaderType, 2);
            this.comboBoxKCPHeaderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKCPHeaderType.FormattingEnabled = true;
            this.comboBoxKCPHeaderType.Items.AddRange(new object[] {
            "none",
            "srtp",
            "utp",
            "wechat-video"});
            this.comboBoxKCPHeaderType.Location = new System.Drawing.Point(134, 3);
            this.comboBoxKCPHeaderType.Name = "comboBoxKCPHeaderType";
            this.comboBoxKCPHeaderType.Size = new System.Drawing.Size(188, 25);
            this.comboBoxKCPHeaderType.TabIndex = 1;
            // 
            // checkBoxCongestion
            // 
            this.checkBoxCongestion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBoxCongestion.AutoSize = true;
            this.checkBoxCongestion.Location = new System.Drawing.Point(393, 5);
            this.checkBoxCongestion.Name = "checkBoxCongestion";
            this.checkBoxCongestion.Size = new System.Drawing.Size(93, 21);
            this.checkBoxCongestion.TabIndex = 2;
            this.checkBoxCongestion.Text = "Congestion";
            this.checkBoxCongestion.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelTCPSettings
            // 
            this.tableLayoutPanelTCPSettings.ColumnCount = 2;
            this.tableLayoutPanelTCPSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelTCPSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelTCPSettings.Controls.Add(this.tabControlTCPHTTPSetting, 0, 1);
            this.tableLayoutPanelTCPSettings.Controls.Add(this.labelTCPType, 0, 0);
            this.tableLayoutPanelTCPSettings.Controls.Add(this.comboBoxTCPType, 1, 0);
            this.tableLayoutPanelTCPSettings.Location = new System.Drawing.Point(184, 68);
            this.tableLayoutPanelTCPSettings.Name = "tableLayoutPanelTCPSettings";
            this.tableLayoutPanelTCPSettings.RowCount = 2;
            this.tableLayoutPanelTCPSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTCPSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTCPSettings.Size = new System.Drawing.Size(438, 248);
            this.tableLayoutPanelTCPSettings.TabIndex = 19;
            // 
            // tabControlTCPHTTPSetting
            // 
            this.tableLayoutPanelTCPSettings.SetColumnSpan(this.tabControlTCPHTTPSetting, 2);
            this.tabControlTCPHTTPSetting.Controls.Add(this.tabPageHTTPReqeustSetting);
            this.tabControlTCPHTTPSetting.Controls.Add(this.tabPageHTTPResponseSetting);
            this.tabControlTCPHTTPSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTCPHTTPSetting.Location = new System.Drawing.Point(0, 34);
            this.tabControlTCPHTTPSetting.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tabControlTCPHTTPSetting.Name = "tabControlTCPHTTPSetting";
            this.tabControlTCPHTTPSetting.SelectedIndex = 0;
            this.tabControlTCPHTTPSetting.Size = new System.Drawing.Size(438, 214);
            this.tabControlTCPHTTPSetting.TabIndex = 22;
            // 
            // tabPageHTTPReqeustSetting
            // 
            this.tabPageHTTPReqeustSetting.Controls.Add(this.tableLayoutPanelHTTPRequest);
            this.tabPageHTTPReqeustSetting.Location = new System.Drawing.Point(4, 26);
            this.tabPageHTTPReqeustSetting.Name = "tabPageHTTPReqeustSetting";
            this.tabPageHTTPReqeustSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHTTPReqeustSetting.Size = new System.Drawing.Size(430, 184);
            this.tabPageHTTPReqeustSetting.TabIndex = 0;
            this.tabPageHTTPReqeustSetting.Text = "Request";
            this.tabPageHTTPReqeustSetting.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelHTTPRequest
            // 
            this.tableLayoutPanelHTTPRequest.ColumnCount = 4;
            this.tableLayoutPanelHTTPRequest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHTTPRequest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelHTTPRequest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHTTPRequest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelHTTPRequest.Controls.Add(this.textBoxHTTPRequestHeaders, 0, 3);
            this.tableLayoutPanelHTTPRequest.Controls.Add(this.textBoxHTTPRequestMethod, 3, 0);
            this.tableLayoutPanelHTTPRequest.Controls.Add(this.labelHTTPRequestMethod, 2, 0);
            this.tableLayoutPanelHTTPRequest.Controls.Add(this.labelHTTPRequestVersion, 0, 0);
            this.tableLayoutPanelHTTPRequest.Controls.Add(this.textBoxHTTPRequestVersion, 1, 0);
            this.tableLayoutPanelHTTPRequest.Controls.Add(this.textBoxHTTPRequestPaths, 1, 1);
            this.tableLayoutPanelHTTPRequest.Controls.Add(this.labelHTTPRequestPaths, 0, 1);
            this.tableLayoutPanelHTTPRequest.Controls.Add(this.labelHTTPRequestHeaders, 0, 2);
            this.tableLayoutPanelHTTPRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelHTTPRequest.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHTTPRequest.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelHTTPRequest.Name = "tableLayoutPanelHTTPRequest";
            this.tableLayoutPanelHTTPRequest.RowCount = 4;
            this.tableLayoutPanelHTTPRequest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelHTTPRequest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelHTTPRequest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHTTPRequest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHTTPRequest.Size = new System.Drawing.Size(424, 178);
            this.tableLayoutPanelHTTPRequest.TabIndex = 0;
            // 
            // textBoxHTTPRequestHeaders
            // 
            this.tableLayoutPanelHTTPRequest.SetColumnSpan(this.textBoxHTTPRequestHeaders, 4);
            this.textBoxHTTPRequestHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHTTPRequestHeaders.Location = new System.Drawing.Point(3, 81);
            this.textBoxHTTPRequestHeaders.Multiline = true;
            this.textBoxHTTPRequestHeaders.Name = "textBoxHTTPRequestHeaders";
            this.textBoxHTTPRequestHeaders.Size = new System.Drawing.Size(418, 94);
            this.textBoxHTTPRequestHeaders.TabIndex = 8;
            // 
            // textBoxHTTPRequestMethod
            // 
            this.textBoxHTTPRequestMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHTTPRequestMethod.Location = new System.Drawing.Point(277, 3);
            this.textBoxHTTPRequestMethod.Name = "textBoxHTTPRequestMethod";
            this.textBoxHTTPRequestMethod.Size = new System.Drawing.Size(144, 23);
            this.textBoxHTTPRequestMethod.TabIndex = 3;
            // 
            // labelHTTPRequestMethod
            // 
            this.labelHTTPRequestMethod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelHTTPRequestMethod.AutoSize = true;
            this.labelHTTPRequestMethod.Location = new System.Drawing.Point(214, 6);
            this.labelHTTPRequestMethod.Name = "labelHTTPRequestMethod";
            this.labelHTTPRequestMethod.Size = new System.Drawing.Size(57, 17);
            this.labelHTTPRequestMethod.TabIndex = 2;
            this.labelHTTPRequestMethod.Text = "Method:";
            // 
            // labelHTTPRequestVersion
            // 
            this.labelHTTPRequestVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelHTTPRequestVersion.AutoSize = true;
            this.labelHTTPRequestVersion.Location = new System.Drawing.Point(3, 6);
            this.labelHTTPRequestVersion.Name = "labelHTTPRequestVersion";
            this.labelHTTPRequestVersion.Size = new System.Drawing.Size(55, 17);
            this.labelHTTPRequestVersion.TabIndex = 0;
            this.labelHTTPRequestVersion.Text = "Version:";
            // 
            // textBoxHTTPRequestVersion
            // 
            this.textBoxHTTPRequestVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHTTPRequestVersion.Location = new System.Drawing.Point(64, 3);
            this.textBoxHTTPRequestVersion.Name = "textBoxHTTPRequestVersion";
            this.textBoxHTTPRequestVersion.Size = new System.Drawing.Size(144, 23);
            this.textBoxHTTPRequestVersion.TabIndex = 1;
            // 
            // textBoxHTTPRequestPaths
            // 
            this.tableLayoutPanelHTTPRequest.SetColumnSpan(this.textBoxHTTPRequestPaths, 3);
            this.textBoxHTTPRequestPaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHTTPRequestPaths.Location = new System.Drawing.Point(64, 32);
            this.textBoxHTTPRequestPaths.Name = "textBoxHTTPRequestPaths";
            this.textBoxHTTPRequestPaths.Size = new System.Drawing.Size(357, 23);
            this.textBoxHTTPRequestPaths.TabIndex = 5;
            // 
            // labelHTTPRequestPaths
            // 
            this.labelHTTPRequestPaths.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelHTTPRequestPaths.AutoSize = true;
            this.labelHTTPRequestPaths.Location = new System.Drawing.Point(3, 35);
            this.labelHTTPRequestPaths.Name = "labelHTTPRequestPaths";
            this.labelHTTPRequestPaths.Size = new System.Drawing.Size(50, 17);
            this.labelHTTPRequestPaths.TabIndex = 6;
            this.labelHTTPRequestPaths.Text = "Path(s):";
            // 
            // labelHTTPRequestHeaders
            // 
            this.labelHTTPRequestHeaders.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelHTTPRequestHeaders.AutoSize = true;
            this.tableLayoutPanelHTTPRequest.SetColumnSpan(this.labelHTTPRequestHeaders, 4);
            this.labelHTTPRequestHeaders.Location = new System.Drawing.Point(3, 59);
            this.labelHTTPRequestHeaders.Name = "labelHTTPRequestHeaders";
            this.labelHTTPRequestHeaders.Size = new System.Drawing.Size(60, 17);
            this.labelHTTPRequestHeaders.TabIndex = 6;
            this.labelHTTPRequestHeaders.Text = "Headers:";
            // 
            // tabPageHTTPResponseSetting
            // 
            this.tabPageHTTPResponseSetting.Controls.Add(this.tableLayoutPanelHTTPResponse);
            this.tabPageHTTPResponseSetting.Location = new System.Drawing.Point(4, 26);
            this.tabPageHTTPResponseSetting.Name = "tabPageHTTPResponseSetting";
            this.tabPageHTTPResponseSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHTTPResponseSetting.Size = new System.Drawing.Size(430, 189);
            this.tabPageHTTPResponseSetting.TabIndex = 2;
            this.tabPageHTTPResponseSetting.Text = "Response";
            this.tabPageHTTPResponseSetting.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelHTTPResponse
            // 
            this.tableLayoutPanelHTTPResponse.ColumnCount = 4;
            this.tableLayoutPanelHTTPResponse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHTTPResponse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelHTTPResponse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHTTPResponse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelHTTPResponse.Controls.Add(this.textBoxHTTPResponseHeaders, 0, 5);
            this.tableLayoutPanelHTTPResponse.Controls.Add(this.textBoxHTTPResponseStatus, 3, 0);
            this.tableLayoutPanelHTTPResponse.Controls.Add(this.labelHTTPResponseStatus, 2, 0);
            this.tableLayoutPanelHTTPResponse.Controls.Add(this.labelHTTPResponseVersion, 0, 0);
            this.tableLayoutPanelHTTPResponse.Controls.Add(this.textBoxHTTPResponseVersion, 1, 0);
            this.tableLayoutPanelHTTPResponse.Controls.Add(this.textBoxHTTPResponseReason, 1, 1);
            this.tableLayoutPanelHTTPResponse.Controls.Add(this.labelHTTPResponseReason, 0, 1);
            this.tableLayoutPanelHTTPResponse.Controls.Add(this.labelHTTPResponseHeaders, 0, 4);
            this.tableLayoutPanelHTTPResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelHTTPResponse.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHTTPResponse.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelHTTPResponse.Name = "tableLayoutPanelHTTPResponse";
            this.tableLayoutPanelHTTPResponse.RowCount = 6;
            this.tableLayoutPanelHTTPResponse.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelHTTPResponse.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelHTTPResponse.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelHTTPResponse.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelHTTPResponse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHTTPResponse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHTTPResponse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHTTPResponse.Size = new System.Drawing.Size(424, 183);
            this.tableLayoutPanelHTTPResponse.TabIndex = 0;
            // 
            // textBoxHTTPResponseHeaders
            // 
            this.tableLayoutPanelHTTPResponse.SetColumnSpan(this.textBoxHTTPResponseHeaders, 4);
            this.textBoxHTTPResponseHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHTTPResponseHeaders.Location = new System.Drawing.Point(3, 81);
            this.textBoxHTTPResponseHeaders.Multiline = true;
            this.textBoxHTTPResponseHeaders.Name = "textBoxHTTPResponseHeaders";
            this.textBoxHTTPResponseHeaders.Size = new System.Drawing.Size(418, 99);
            this.textBoxHTTPResponseHeaders.TabIndex = 9;
            // 
            // textBoxHTTPResponseStatus
            // 
            this.textBoxHTTPResponseStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHTTPResponseStatus.Location = new System.Drawing.Point(274, 3);
            this.textBoxHTTPResponseStatus.Name = "textBoxHTTPResponseStatus";
            this.textBoxHTTPResponseStatus.Size = new System.Drawing.Size(147, 23);
            this.textBoxHTTPResponseStatus.TabIndex = 3;
            // 
            // labelHTTPResponseStatus
            // 
            this.labelHTTPResponseStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelHTTPResponseStatus.AutoSize = true;
            this.labelHTTPResponseStatus.Location = new System.Drawing.Point(222, 6);
            this.labelHTTPResponseStatus.Name = "labelHTTPResponseStatus";
            this.labelHTTPResponseStatus.Size = new System.Drawing.Size(46, 17);
            this.labelHTTPResponseStatus.TabIndex = 2;
            this.labelHTTPResponseStatus.Text = "Status:";
            // 
            // labelHTTPResponseVersion
            // 
            this.labelHTTPResponseVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelHTTPResponseVersion.AutoSize = true;
            this.labelHTTPResponseVersion.Location = new System.Drawing.Point(3, 6);
            this.labelHTTPResponseVersion.Name = "labelHTTPResponseVersion";
            this.labelHTTPResponseVersion.Size = new System.Drawing.Size(55, 17);
            this.labelHTTPResponseVersion.TabIndex = 0;
            this.labelHTTPResponseVersion.Text = "Version:";
            // 
            // textBoxHTTPResponseVersion
            // 
            this.textBoxHTTPResponseVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHTTPResponseVersion.Location = new System.Drawing.Point(69, 3);
            this.textBoxHTTPResponseVersion.Name = "textBoxHTTPResponseVersion";
            this.textBoxHTTPResponseVersion.Size = new System.Drawing.Size(147, 23);
            this.textBoxHTTPResponseVersion.TabIndex = 1;
            // 
            // textBoxHTTPResponseReason
            // 
            this.tableLayoutPanelHTTPResponse.SetColumnSpan(this.textBoxHTTPResponseReason, 3);
            this.textBoxHTTPResponseReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHTTPResponseReason.Location = new System.Drawing.Point(69, 32);
            this.textBoxHTTPResponseReason.Name = "textBoxHTTPResponseReason";
            this.textBoxHTTPResponseReason.Size = new System.Drawing.Size(352, 23);
            this.textBoxHTTPResponseReason.TabIndex = 5;
            // 
            // labelHTTPResponseReason
            // 
            this.labelHTTPResponseReason.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelHTTPResponseReason.AutoSize = true;
            this.labelHTTPResponseReason.Location = new System.Drawing.Point(3, 35);
            this.labelHTTPResponseReason.Name = "labelHTTPResponseReason";
            this.labelHTTPResponseReason.Size = new System.Drawing.Size(54, 17);
            this.labelHTTPResponseReason.TabIndex = 6;
            this.labelHTTPResponseReason.Text = "Reason:";
            // 
            // labelHTTPResponseHeaders
            // 
            this.labelHTTPResponseHeaders.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelHTTPResponseHeaders.AutoSize = true;
            this.labelHTTPResponseHeaders.Location = new System.Drawing.Point(3, 59);
            this.labelHTTPResponseHeaders.Name = "labelHTTPResponseHeaders";
            this.labelHTTPResponseHeaders.Size = new System.Drawing.Size(60, 17);
            this.labelHTTPResponseHeaders.TabIndex = 6;
            this.labelHTTPResponseHeaders.Text = "Headers:";
            // 
            // labelTCPType
            // 
            this.labelTCPType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTCPType.AutoSize = true;
            this.labelTCPType.Location = new System.Drawing.Point(3, 7);
            this.labelTCPType.Name = "labelTCPType";
            this.labelTCPType.Size = new System.Drawing.Size(39, 17);
            this.labelTCPType.TabIndex = 18;
            this.labelTCPType.Text = "Type:";
            // 
            // comboBoxTCPType
            // 
            this.comboBoxTCPType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTCPType.FormattingEnabled = true;
            this.comboBoxTCPType.Items.AddRange(new object[] {
            "none",
            "http"});
            this.comboBoxTCPType.Location = new System.Drawing.Point(48, 3);
            this.comboBoxTCPType.Name = "comboBoxTCPType";
            this.comboBoxTCPType.Size = new System.Drawing.Size(152, 25);
            this.comboBoxTCPType.TabIndex = 19;
            this.comboBoxTCPType.SelectedIndexChanged += new System.EventHandler(this.comboBoxTCPType_SelectedIndexChanged);
            // 
            // tableLayoutPanelWebSocketSettings
            // 
            this.tableLayoutPanelWebSocketSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelWebSocketSettings.ColumnCount = 2;
            this.tableLayoutPanelWebSocketSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelWebSocketSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.14089F));
            this.tableLayoutPanelWebSocketSettings.Controls.Add(WebSocketPath, 0, 0);
            this.tableLayoutPanelWebSocketSettings.Controls.Add(labelWebSocketHeaders, 0, 1);
            this.tableLayoutPanelWebSocketSettings.Controls.Add(this.textBoxWebSocketPath, 1, 0);
            this.tableLayoutPanelWebSocketSettings.Controls.Add(this.textBoxWebSocketHeaders, 0, 2);
            this.tableLayoutPanelWebSocketSettings.Location = new System.Drawing.Point(11, 63);
            this.tableLayoutPanelWebSocketSettings.Name = "tableLayoutPanelWebSocketSettings";
            this.tableLayoutPanelWebSocketSettings.RowCount = 3;
            this.tableLayoutPanelWebSocketSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelWebSocketSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelWebSocketSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelWebSocketSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelWebSocketSettings.Size = new System.Drawing.Size(344, 117);
            this.tableLayoutPanelWebSocketSettings.TabIndex = 21;
            // 
            // textBoxWebSocketPath
            // 
            this.textBoxWebSocketPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxWebSocketPath.Location = new System.Drawing.Point(45, 3);
            this.textBoxWebSocketPath.Name = "textBoxWebSocketPath";
            this.textBoxWebSocketPath.Size = new System.Drawing.Size(296, 23);
            this.textBoxWebSocketPath.TabIndex = 1;
            // 
            // textBoxWebSocketHeaders
            // 
            this.tableLayoutPanelWebSocketSettings.SetColumnSpan(this.textBoxWebSocketHeaders, 2);
            this.textBoxWebSocketHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxWebSocketHeaders.Location = new System.Drawing.Point(3, 55);
            this.textBoxWebSocketHeaders.Multiline = true;
            this.textBoxWebSocketHeaders.Name = "textBoxWebSocketHeaders";
            this.textBoxWebSocketHeaders.Size = new System.Drawing.Size(338, 59);
            this.textBoxWebSocketHeaders.TabIndex = 2;
            // 
            // tableLayoutPanelStreamSettings
            // 
            this.tableLayoutPanelStreamSettings.AutoSize = true;
            this.tableLayoutPanelStreamSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelStreamSettings.ColumnCount = 3;
            this.tableLayoutPanelStreamSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelStreamSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelStreamSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tableLayoutPanelStreamSettings.Controls.Add(this.labelNetwork, 0, 0);
            this.tableLayoutPanelStreamSettings.Controls.Add(this.comboBoxNetwork, 1, 0);
            this.tableLayoutPanelStreamSettings.Controls.Add(this.checkBoxEnableMux, 2, 0);
            this.tableLayoutPanelStreamSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelStreamSettings.Location = new System.Drawing.Point(8, 24);
            this.tableLayoutPanelStreamSettings.Name = "tableLayoutPanelStreamSettings";
            this.tableLayoutPanelStreamSettings.RowCount = 1;
            this.tableLayoutPanelStreamSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelStreamSettings.Size = new System.Drawing.Size(481, 31);
            this.tableLayoutPanelStreamSettings.TabIndex = 18;
            // 
            // labelNetwork
            // 
            this.labelNetwork.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNetwork.AutoSize = true;
            this.labelNetwork.Location = new System.Drawing.Point(3, 7);
            this.labelNetwork.Name = "labelNetwork";
            this.labelNetwork.Size = new System.Drawing.Size(61, 17);
            this.labelNetwork.TabIndex = 16;
            this.labelNetwork.Text = "Network:";
            // 
            // comboBoxNetwork
            // 
            this.comboBoxNetwork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNetwork.FormattingEnabled = true;
            this.comboBoxNetwork.Items.AddRange(new object[] {
            "TCP - tcp",
            "mKCP - kcp",
            "WebSocket - ws"});
            this.comboBoxNetwork.Location = new System.Drawing.Point(70, 3);
            this.comboBoxNetwork.Name = "comboBoxNetwork";
            this.comboBoxNetwork.Size = new System.Drawing.Size(152, 25);
            this.comboBoxNetwork.TabIndex = 17;
            this.comboBoxNetwork.SelectedIndexChanged += new System.EventHandler(this.comboBoxNetwork_SelectedIndexChanged);
            // 
            // checkBoxEnableMux
            // 
            this.checkBoxEnableMux.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxEnableMux.AutoSize = true;
            this.checkBoxEnableMux.Location = new System.Drawing.Point(228, 5);
            this.checkBoxEnableMux.Name = "checkBoxEnableMux";
            this.checkBoxEnableMux.Size = new System.Drawing.Size(52, 21);
            this.checkBoxEnableMux.TabIndex = 18;
            this.checkBoxEnableMux.Text = "Mux";
            this.checkBoxEnableMux.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelVMessBasic
            // 
            this.tableLayoutPanelVMessBasic.AutoSize = true;
            this.tableLayoutPanelVMessBasic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelVMessBasic.ColumnCount = 4;
            this.tableLayoutPanelVMessBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelVMessBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelVMessBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelVMessBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanelVMessBasic.Controls.Add(this.labelAddress, 0, 0);
            this.tableLayoutPanelVMessBasic.Controls.Add(this.textBoxAddress, 1, 0);
            this.tableLayoutPanelVMessBasic.Controls.Add(this.labelID, 0, 2);
            this.tableLayoutPanelVMessBasic.Controls.Add(this.comboBoxSecurity, 1, 4);
            this.tableLayoutPanelVMessBasic.Controls.Add(this.textBoxID, 1, 2);
            this.tableLayoutPanelVMessBasic.Controls.Add(this.labelSecurity, 0, 4);
            this.tableLayoutPanelVMessBasic.Controls.Add(this.labelPort, 2, 0);
            this.tableLayoutPanelVMessBasic.Controls.Add(this.labelAlterId, 2, 2);
            this.tableLayoutPanelVMessBasic.Controls.Add(this.buttonGenerateID, 2, 4);
            this.tableLayoutPanelVMessBasic.Controls.Add(this.labelRemark, 0, 6);
            this.tableLayoutPanelVMessBasic.Controls.Add(this.textBoxRemark, 1, 6);
            this.tableLayoutPanelVMessBasic.Controls.Add(this.numericUpDownPort, 3, 0);
            this.tableLayoutPanelVMessBasic.Controls.Add(this.numericUpDownAlterID, 3, 2);
            this.tableLayoutPanelVMessBasic.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelVMessBasic.Location = new System.Drawing.Point(8, 24);
            this.tableLayoutPanelVMessBasic.Name = "tableLayoutPanelVMessBasic";
            this.tableLayoutPanelVMessBasic.RowCount = 7;
            this.tableLayoutPanelVMessBasic.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelVMessBasic.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelVMessBasic.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelVMessBasic.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelVMessBasic.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelVMessBasic.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelVMessBasic.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelVMessBasic.Size = new System.Drawing.Size(496, 118);
            this.tableLayoutPanelVMessBasic.TabIndex = 4;
            // 
            // labelAddress
            // 
            this.labelAddress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(3, 6);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(59, 17);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAddress.Location = new System.Drawing.Point(68, 3);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(278, 23);
            this.textBoxAddress.TabIndex = 1;
            // 
            // labelID
            // 
            this.labelID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(7, 35);
            this.labelID.Name = "labelID";
            this.labelID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelID.Size = new System.Drawing.Size(55, 17);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "User ID:";
            // 
            // comboBoxSecurity
            // 
            this.comboBoxSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSecurity.FormattingEnabled = true;
            this.comboBoxSecurity.Items.AddRange(new object[] {
            "aes-128-cfb",
            "aes-128-gcm",
            "chacha20-poly1305",
            "auto",
            "none"});
            this.comboBoxSecurity.Location = new System.Drawing.Point(68, 61);
            this.comboBoxSecurity.Name = "comboBoxSecurity";
            this.comboBoxSecurity.Size = new System.Drawing.Size(162, 25);
            this.comboBoxSecurity.TabIndex = 12;
            // 
            // textBoxID
            // 
            this.textBoxID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxID.Location = new System.Drawing.Point(68, 32);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(278, 23);
            this.textBoxID.TabIndex = 3;
            // 
            // labelSecurity
            // 
            this.labelSecurity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSecurity.AutoSize = true;
            this.labelSecurity.Location = new System.Drawing.Point(6, 65);
            this.labelSecurity.Name = "labelSecurity";
            this.labelSecurity.Size = new System.Drawing.Size(56, 17);
            this.labelSecurity.TabIndex = 11;
            this.labelSecurity.Text = "Security:";
            // 
            // labelPort
            // 
            this.labelPort.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(367, 6);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(35, 17);
            this.labelPort.TabIndex = 1;
            this.labelPort.Text = "Port:";
            // 
            // labelAlterId
            // 
            this.labelAlterId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelAlterId.AutoSize = true;
            this.labelAlterId.Location = new System.Drawing.Point(352, 35);
            this.labelAlterId.Name = "labelAlterId";
            this.labelAlterId.Size = new System.Drawing.Size(50, 17);
            this.labelAlterId.TabIndex = 2;
            this.labelAlterId.Text = "AlterId:";
            // 
            // buttonGenerateID
            // 
            this.tableLayoutPanelVMessBasic.SetColumnSpan(this.buttonGenerateID, 2);
            this.buttonGenerateID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGenerateID.Location = new System.Drawing.Point(351, 60);
            this.buttonGenerateID.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateID.Name = "buttonGenerateID";
            this.buttonGenerateID.Size = new System.Drawing.Size(143, 27);
            this.buttonGenerateID.TabIndex = 14;
            this.buttonGenerateID.Text = "Generate ID";
            this.buttonGenerateID.UseVisualStyleBackColor = true;
            this.buttonGenerateID.Click += new System.EventHandler(this.buttonGenerateID_Click);
            // 
            // labelRemark
            // 
            this.labelRemark.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelRemark.AutoSize = true;
            this.labelRemark.Location = new System.Drawing.Point(6, 95);
            this.labelRemark.Name = "labelRemark";
            this.labelRemark.Size = new System.Drawing.Size(56, 17);
            this.labelRemark.TabIndex = 11;
            this.labelRemark.Text = "Remark:";
            // 
            // textBoxRemark
            // 
            this.textBoxRemark.Location = new System.Drawing.Point(68, 92);
            this.textBoxRemark.Name = "textBoxRemark";
            this.textBoxRemark.Size = new System.Drawing.Size(265, 23);
            this.textBoxRemark.TabIndex = 4;
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Location = new System.Drawing.Point(408, 3);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(85, 23);
            this.numericUpDownPort.TabIndex = 15;
            // 
            // numericUpDownAlterID
            // 
            this.numericUpDownAlterID.Location = new System.Drawing.Point(408, 32);
            this.numericUpDownAlterID.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownAlterID.Name = "numericUpDownAlterID";
            this.numericUpDownAlterID.Size = new System.Drawing.Size(85, 23);
            this.numericUpDownAlterID.TabIndex = 15;
            // 
            // numericUpDownKCPMTU
            // 
            this.numericUpDownKCPMTU.Location = new System.Drawing.Point(134, 34);
            this.numericUpDownKCPMTU.Maximum = new decimal(new int[] {
            1460,
            0,
            0,
            0});
            this.numericUpDownKCPMTU.Minimum = new decimal(new int[] {
            576,
            0,
            0,
            0});
            this.numericUpDownKCPMTU.Name = "numericUpDownKCPMTU";
            this.numericUpDownKCPMTU.Size = new System.Drawing.Size(88, 23);
            this.numericUpDownKCPMTU.TabIndex = 3;
            this.numericUpDownKCPMTU.Value = new decimal(new int[] {
            576,
            0,
            0,
            0});
            // 
            // numericUpDownKCPWriteBufferSize
            // 
            this.numericUpDownKCPWriteBufferSize.Location = new System.Drawing.Point(134, 63);
            this.numericUpDownKCPWriteBufferSize.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownKCPWriteBufferSize.Name = "numericUpDownKCPWriteBufferSize";
            this.numericUpDownKCPWriteBufferSize.Size = new System.Drawing.Size(88, 23);
            this.numericUpDownKCPWriteBufferSize.TabIndex = 3;
            // 
            // numericUpDownKCPReadBufferSize
            // 
            this.numericUpDownKCPReadBufferSize.Location = new System.Drawing.Point(134, 92);
            this.numericUpDownKCPReadBufferSize.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownKCPReadBufferSize.Name = "numericUpDownKCPReadBufferSize";
            this.numericUpDownKCPReadBufferSize.Size = new System.Drawing.Size(88, 23);
            this.numericUpDownKCPReadBufferSize.TabIndex = 3;
            // 
            // numericUpDownKCPDownlinkCapacity
            // 
            this.numericUpDownKCPDownlinkCapacity.Location = new System.Drawing.Point(385, 92);
            this.numericUpDownKCPDownlinkCapacity.Name = "numericUpDownKCPDownlinkCapacity";
            this.numericUpDownKCPDownlinkCapacity.Size = new System.Drawing.Size(88, 23);
            this.numericUpDownKCPDownlinkCapacity.TabIndex = 3;
            // 
            // numericUpDownKCPUplinkCapacity
            // 
            this.numericUpDownKCPUplinkCapacity.Location = new System.Drawing.Point(385, 63);
            this.numericUpDownKCPUplinkCapacity.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownKCPUplinkCapacity.Name = "numericUpDownKCPUplinkCapacity";
            this.numericUpDownKCPUplinkCapacity.Size = new System.Drawing.Size(88, 23);
            this.numericUpDownKCPUplinkCapacity.TabIndex = 3;
            // 
            // numericUpDownKCPTTI
            // 
            this.numericUpDownKCPTTI.Location = new System.Drawing.Point(385, 34);
            this.numericUpDownKCPTTI.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownKCPTTI.Name = "numericUpDownKCPTTI";
            this.numericUpDownKCPTTI.Size = new System.Drawing.Size(88, 23);
            this.numericUpDownKCPTTI.TabIndex = 3;
            this.numericUpDownKCPTTI.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // EditServersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 635);
            this.Controls.Add(this.panelEditServer);
            this.Controls.Add(this.panelServerList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.MaximizeBox = false;
            this.Name = "EditServersForm";
            this.Text = "EditServersForm";
            this.Load += new System.EventHandler(this.EditServersForm_Load);
            tableLayoutPanelServerListControl.ResumeLayout(false);
            this.panelServerList.ResumeLayout(false);
            this.panelEditServer.ResumeLayout(false);
            this.flowLayoutPanelButtons.ResumeLayout(false);
            this.groupBoxV2RayServerConfig.ResumeLayout(false);
            this.groupBoxV2RayServerConfig.PerformLayout();
            this.groupBoxTLSSetting.ResumeLayout(false);
            this.groupBoxTLSSetting.PerformLayout();
            this.tableLayoutPanelTLSSettings.ResumeLayout(false);
            this.tableLayoutPanelTLSSettings.PerformLayout();
            this.groupBoxStreamSettings.ResumeLayout(false);
            this.groupBoxStreamSettings.PerformLayout();
            this.tableLayoutPanelKCPSettings.ResumeLayout(false);
            this.tableLayoutPanelKCPSettings.PerformLayout();
            this.tableLayoutPanelTCPSettings.ResumeLayout(false);
            this.tableLayoutPanelTCPSettings.PerformLayout();
            this.tabControlTCPHTTPSetting.ResumeLayout(false);
            this.tabPageHTTPReqeustSetting.ResumeLayout(false);
            this.tableLayoutPanelHTTPRequest.ResumeLayout(false);
            this.tableLayoutPanelHTTPRequest.PerformLayout();
            this.tabPageHTTPResponseSetting.ResumeLayout(false);
            this.tableLayoutPanelHTTPResponse.ResumeLayout(false);
            this.tableLayoutPanelHTTPResponse.PerformLayout();
            this.tableLayoutPanelWebSocketSettings.ResumeLayout(false);
            this.tableLayoutPanelWebSocketSettings.PerformLayout();
            this.tableLayoutPanelStreamSettings.ResumeLayout(false);
            this.tableLayoutPanelStreamSettings.PerformLayout();
            this.tableLayoutPanelVMessBasic.ResumeLayout(false);
            this.tableLayoutPanelVMessBasic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKCPMTU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKCPWriteBufferSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKCPReadBufferSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKCPDownlinkCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKCPUplinkCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKCPTTI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelServerList;
        private System.Windows.Forms.ListBox listBoxServersList;
        private System.Windows.Forms.Panel panelEditServer;
        private System.Windows.Forms.Button buttonRemoveServer;
        private System.Windows.Forms.Button buttonAddServer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBoxV2RayServerConfig;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelVMessBasic;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAlterId;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.ComboBox comboBoxSecurity;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelSecurity;
        private System.Windows.Forms.GroupBox groupBoxStreamSettings;
        private System.Windows.Forms.ComboBox comboBoxNetwork;
        private System.Windows.Forms.Label labelNetwork;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStreamSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTCPSettings;
        private System.Windows.Forms.TabControl tabControlTCPHTTPSetting;
        private System.Windows.Forms.TabPage tabPageHTTPReqeustSetting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHTTPRequest;
        private System.Windows.Forms.TextBox textBoxHTTPRequestHeaders;
        private System.Windows.Forms.TextBox textBoxHTTPRequestMethod;
        private System.Windows.Forms.Label labelHTTPRequestMethod;
        private System.Windows.Forms.Label labelHTTPRequestVersion;
        private System.Windows.Forms.TextBox textBoxHTTPRequestVersion;
        private System.Windows.Forms.TextBox textBoxHTTPRequestPaths;
        private System.Windows.Forms.Label labelHTTPRequestPaths;
        private System.Windows.Forms.Label labelHTTPRequestHeaders;
        private System.Windows.Forms.TabPage tabPageHTTPResponseSetting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHTTPResponse;
        private System.Windows.Forms.TextBox textBoxHTTPResponseHeaders;
        private System.Windows.Forms.TextBox textBoxHTTPResponseStatus;
        private System.Windows.Forms.Label labelHTTPResponseStatus;
        private System.Windows.Forms.Label labelHTTPResponseVersion;
        private System.Windows.Forms.TextBox textBoxHTTPResponseVersion;
        private System.Windows.Forms.TextBox textBoxHTTPResponseReason;
        private System.Windows.Forms.Label labelHTTPResponseReason;
        private System.Windows.Forms.Label labelHTTPResponseHeaders;
        private System.Windows.Forms.Label labelTCPType;
        private System.Windows.Forms.ComboBox comboBoxTCPType;
        private System.Windows.Forms.GroupBox groupBoxTLSSetting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTLSSettings;
        private System.Windows.Forms.CheckBox checkBoxEnableTLS;
        private System.Windows.Forms.Label labelServerName;
        private System.Windows.Forms.TextBox textBoxTLSServerName;
        private System.Windows.Forms.CheckBox checkBoxAllowInsecure;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelKCPSettings;
        private System.Windows.Forms.ComboBox comboBoxKCPHeaderType;
        private System.Windows.Forms.CheckBox checkBoxCongestion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWebSocketSettings;
        private System.Windows.Forms.TextBox textBoxWebSocketPath;
        private System.Windows.Forms.TextBox textBoxWebSocketHeaders;
        private System.Windows.Forms.Button buttonGenerateID;
        private System.Windows.Forms.Label labelRemark;
        private System.Windows.Forms.TextBox textBoxRemark;
        private System.Windows.Forms.CheckBox checkBoxEnableMux;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.NumericUpDown numericUpDownAlterID;
        private System.Windows.Forms.NumericUpDown numericUpDownKCPMTU;
        private System.Windows.Forms.NumericUpDown numericUpDownKCPWriteBufferSize;
        private System.Windows.Forms.NumericUpDown numericUpDownKCPReadBufferSize;
        private System.Windows.Forms.NumericUpDown numericUpDownKCPDownlinkCapacity;
        private System.Windows.Forms.NumericUpDown numericUpDownKCPUplinkCapacity;
        private System.Windows.Forms.NumericUpDown numericUpDownKCPTTI;
    }
}