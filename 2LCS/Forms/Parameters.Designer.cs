namespace LCS.Forms
{
    partial class Parameters
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
            AutoRefreshCheckBox = new System.Windows.Forms.CheckBox();
            closeButton = new System.Windows.Forms.Button();
            groupBoxExportConfig = new System.Windows.Forms.GroupBox();
            labelOrgNameExcl = new System.Windows.Forms.Label();
            textBoxProjectExcl = new System.Windows.Forms.TextBox();
            groupBoxUIConfig = new System.Windows.Forms.GroupBox();
            minimizeToNotificationArea = new System.Windows.Forms.CheckBox();
            groupBoxCaching = new System.Windows.Forms.GroupBox();
            ClearCacheButton = new System.Windows.Forms.Button();
            StoreCacheCheckBox = new System.Windows.Forms.CheckBox();
            CachingEnabledCheckbox = new System.Windows.Forms.CheckBox();
            groupCHE = new System.Windows.Forms.GroupBox();
            uriSchemeEnabled = new System.Windows.Forms.CheckBox();
            alwaysLogAsAdmin = new System.Windows.Forms.CheckBox();
            groupBoxCredentials = new System.Windows.Forms.GroupBox();
            LocalCredentialsCheckbox = new System.Windows.Forms.CheckBox();
            RDPCredentialsCheckbox = new System.Windows.Forms.CheckBox();
            groupBoxLCSUrls = new System.Windows.Forms.GroupBox();
            labelLcsDiagUrl = new System.Windows.Forms.Label();
            labelLcsFixUrl = new System.Windows.Forms.Label();
            labelLcsUpdateUrl = new System.Windows.Forms.Label();
            labelLcsUrl = new System.Windows.Forms.Label();
            textBoxLcsDiagUrl = new System.Windows.Forms.TextBox();
            textBoxLcsFixUrl = new System.Windows.Forms.TextBox();
            textBoxLcsUpdateUrl = new System.Windows.Forms.TextBox();
            textBoxLcsUrl = new System.Windows.Forms.TextBox();
            rdpFullScreenEnabled = new System.Windows.Forms.CheckBox();
            groupBoxExportConfig.SuspendLayout();
            groupBoxUIConfig.SuspendLayout();
            groupBoxCaching.SuspendLayout();
            groupCHE.SuspendLayout();
            groupBoxCredentials.SuspendLayout();
            groupBoxLCSUrls.SuspendLayout();
            SuspendLayout();
            // 
            // AutoRefreshCheckBox
            // 
            AutoRefreshCheckBox.AutoSize = true;
            AutoRefreshCheckBox.Location = new System.Drawing.Point(7, 19);
            AutoRefreshCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            AutoRefreshCheckBox.Name = "AutoRefreshCheckBox";
            AutoRefreshCheckBox.Size = new System.Drawing.Size(298, 19);
            AutoRefreshCheckBox.TabIndex = 0;
            AutoRefreshCheckBox.Text = "Auto-refresh list of instances after switching project";
            AutoRefreshCheckBox.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            closeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            closeButton.Location = new System.Drawing.Point(273, 565);
            closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(143, 24);
            closeButton.TabIndex = 4;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += OkButton_Click;
            // 
            // groupBoxExportConfig
            // 
            groupBoxExportConfig.Controls.Add(labelOrgNameExcl);
            groupBoxExportConfig.Controls.Add(textBoxProjectExcl);
            groupBoxExportConfig.Location = new System.Drawing.Point(10, 167);
            groupBoxExportConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxExportConfig.Name = "groupBoxExportConfig";
            groupBoxExportConfig.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxExportConfig.Size = new System.Drawing.Size(405, 68);
            groupBoxExportConfig.TabIndex = 5;
            groupBoxExportConfig.TabStop = false;
            groupBoxExportConfig.Text = "Export instances/updates";
            // 
            // labelOrgNameExcl
            // 
            labelOrgNameExcl.Location = new System.Drawing.Point(4, 23);
            labelOrgNameExcl.Name = "labelOrgNameExcl";
            labelOrgNameExcl.Size = new System.Drawing.Size(211, 32);
            labelOrgNameExcl.TabIndex = 1;
            labelOrgNameExcl.Text = "Exclude projects for all organizations containing the following string\r\n\r\n";
            // 
            // textBoxProjectExcl
            // 
            textBoxProjectExcl.Location = new System.Drawing.Point(220, 28);
            textBoxProjectExcl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textBoxProjectExcl.Name = "textBoxProjectExcl";
            textBoxProjectExcl.Size = new System.Drawing.Size(183, 23);
            textBoxProjectExcl.TabIndex = 0;
            // 
            // groupBoxUIConfig
            // 
            groupBoxUIConfig.Controls.Add(minimizeToNotificationArea);
            groupBoxUIConfig.Controls.Add(AutoRefreshCheckBox);
            groupBoxUIConfig.Location = new System.Drawing.Point(10, 8);
            groupBoxUIConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxUIConfig.Name = "groupBoxUIConfig";
            groupBoxUIConfig.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxUIConfig.Size = new System.Drawing.Size(405, 76);
            groupBoxUIConfig.TabIndex = 6;
            groupBoxUIConfig.TabStop = false;
            groupBoxUIConfig.Text = "UI";
            // 
            // minimizeToNotificationArea
            // 
            minimizeToNotificationArea.AutoSize = true;
            minimizeToNotificationArea.Location = new System.Drawing.Point(7, 43);
            minimizeToNotificationArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            minimizeToNotificationArea.Name = "minimizeToNotificationArea";
            minimizeToNotificationArea.Size = new System.Drawing.Size(291, 19);
            minimizeToNotificationArea.TabIndex = 2;
            minimizeToNotificationArea.Text = "Closing the window minimizes to notification area";
            minimizeToNotificationArea.UseVisualStyleBackColor = true;
            // 
            // groupBoxCaching
            // 
            groupBoxCaching.Controls.Add(ClearCacheButton);
            groupBoxCaching.Controls.Add(StoreCacheCheckBox);
            groupBoxCaching.Controls.Add(CachingEnabledCheckbox);
            groupBoxCaching.Location = new System.Drawing.Point(10, 88);
            groupBoxCaching.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxCaching.Name = "groupBoxCaching";
            groupBoxCaching.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxCaching.Size = new System.Drawing.Size(405, 74);
            groupBoxCaching.TabIndex = 7;
            groupBoxCaching.TabStop = false;
            groupBoxCaching.Text = "Caching";
            // 
            // ClearCacheButton
            // 
            ClearCacheButton.Location = new System.Drawing.Point(276, 37);
            ClearCacheButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            ClearCacheButton.Name = "ClearCacheButton";
            ClearCacheButton.Size = new System.Drawing.Size(123, 26);
            ClearCacheButton.TabIndex = 2;
            ClearCacheButton.Text = "Clear cache";
            ClearCacheButton.UseVisualStyleBackColor = true;
            ClearCacheButton.Click += ClearCacheButton_Click;
            // 
            // StoreCacheCheckBox
            // 
            StoreCacheCheckBox.AutoSize = true;
            StoreCacheCheckBox.Location = new System.Drawing.Point(7, 43);
            StoreCacheCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            StoreCacheCheckBox.Name = "StoreCacheCheckBox";
            StoreCacheCheckBox.Size = new System.Drawing.Size(229, 19);
            StoreCacheCheckBox.TabIndex = 1;
            StoreCacheCheckBox.Text = "Save cache on exit and load on startup";
            StoreCacheCheckBox.UseVisualStyleBackColor = true;
            // 
            // CachingEnabledCheckbox
            // 
            CachingEnabledCheckbox.AutoSize = true;
            CachingEnabledCheckbox.Location = new System.Drawing.Point(7, 19);
            CachingEnabledCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            CachingEnabledCheckbox.Name = "CachingEnabledCheckbox";
            CachingEnabledCheckbox.Size = new System.Drawing.Size(124, 19);
            CachingEnabledCheckbox.TabIndex = 0;
            CachingEnabledCheckbox.Text = "Enabled (memory)";
            CachingEnabledCheckbox.UseVisualStyleBackColor = true;
            CachingEnabledCheckbox.CheckedChanged += CachingEnabledCheckbox_CheckedChanged;
            // 
            // groupCHE
            // 
            groupCHE.Controls.Add(rdpFullScreenEnabled);
            groupCHE.Controls.Add(uriSchemeEnabled);
            groupCHE.Controls.Add(alwaysLogAsAdmin);
            groupCHE.Location = new System.Drawing.Point(10, 324);
            groupCHE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupCHE.Name = "groupCHE";
            groupCHE.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupCHE.Size = new System.Drawing.Size(403, 104);
            groupCHE.TabIndex = 9;
            groupCHE.TabStop = false;
            groupCHE.Text = "Cloud-hosted environments";
            // 
            // uriSchemeEnabled
            // 
            uriSchemeEnabled.Location = new System.Drawing.Point(7, 49);
            uriSchemeEnabled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            uriSchemeEnabled.Name = "uriSchemeEnabled";
            uriSchemeEnabled.Size = new System.Drawing.Size(197, 23);
            uriSchemeEnabled.TabIndex = 1;
            uriSchemeEnabled.Text = "Enable URI scheme support";
            uriSchemeEnabled.CheckedChanged += OnUriSchemeEnabledCheckedChanged;
            // 
            // alwaysLogAsAdmin
            // 
            alwaysLogAsAdmin.Location = new System.Drawing.Point(7, 21);
            alwaysLogAsAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            alwaysLogAsAdmin.Name = "alwaysLogAsAdmin";
            alwaysLogAsAdmin.Size = new System.Drawing.Size(178, 23);
            alwaysLogAsAdmin.TabIndex = 0;
            alwaysLogAsAdmin.Text = "Always log as admin user";
            // 
            // groupBoxCredentials
            // 
            groupBoxCredentials.Controls.Add(LocalCredentialsCheckbox);
            groupBoxCredentials.Controls.Add(RDPCredentialsCheckbox);
            groupBoxCredentials.Location = new System.Drawing.Point(10, 240);
            groupBoxCredentials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxCredentials.Name = "groupBoxCredentials";
            groupBoxCredentials.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxCredentials.Size = new System.Drawing.Size(405, 79);
            groupBoxCredentials.TabIndex = 6;
            groupBoxCredentials.TabStop = false;
            groupBoxCredentials.Text = "Export project data";
            // 
            // LocalCredentialsCheckbox
            // 
            LocalCredentialsCheckbox.Location = new System.Drawing.Point(7, 47);
            LocalCredentialsCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            LocalCredentialsCheckbox.Name = "LocalCredentialsCheckbox";
            LocalCredentialsCheckbox.Size = new System.Drawing.Size(178, 23);
            LocalCredentialsCheckbox.TabIndex = 2;
            LocalCredentialsCheckbox.Text = "Include local credentials";
            // 
            // RDPCredentialsCheckbox
            // 
            RDPCredentialsCheckbox.Location = new System.Drawing.Point(7, 20);
            RDPCredentialsCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            RDPCredentialsCheckbox.Name = "RDPCredentialsCheckbox";
            RDPCredentialsCheckbox.Size = new System.Drawing.Size(178, 23);
            RDPCredentialsCheckbox.TabIndex = 1;
            RDPCredentialsCheckbox.Text = "Include RDP credentials";
            // 
            // groupBoxLCSUrls
            // 
            groupBoxLCSUrls.Controls.Add(labelLcsDiagUrl);
            groupBoxLCSUrls.Controls.Add(labelLcsFixUrl);
            groupBoxLCSUrls.Controls.Add(labelLcsUpdateUrl);
            groupBoxLCSUrls.Controls.Add(labelLcsUrl);
            groupBoxLCSUrls.Controls.Add(textBoxLcsDiagUrl);
            groupBoxLCSUrls.Controls.Add(textBoxLcsFixUrl);
            groupBoxLCSUrls.Controls.Add(textBoxLcsUpdateUrl);
            groupBoxLCSUrls.Controls.Add(textBoxLcsUrl);
            groupBoxLCSUrls.Location = new System.Drawing.Point(10, 434);
            groupBoxLCSUrls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxLCSUrls.Name = "groupBoxLCSUrls";
            groupBoxLCSUrls.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxLCSUrls.Size = new System.Drawing.Size(403, 124);
            groupBoxLCSUrls.TabIndex = 10;
            groupBoxLCSUrls.TabStop = false;
            groupBoxLCSUrls.Text = "LCS Urls";
            // 
            // labelLcsDiagUrl
            // 
            labelLcsDiagUrl.AutoSize = true;
            labelLcsDiagUrl.Location = new System.Drawing.Point(8, 99);
            labelLcsDiagUrl.Name = "labelLcsDiagUrl";
            labelLcsDiagUrl.Size = new System.Drawing.Size(104, 15);
            labelLcsDiagUrl.TabIndex = 7;
            labelLcsDiagUrl.Text = "LCS Diagnostic Url";
            // 
            // labelLcsFixUrl
            // 
            labelLcsFixUrl.AutoSize = true;
            labelLcsFixUrl.Location = new System.Drawing.Point(8, 74);
            labelLcsFixUrl.Name = "labelLcsFixUrl";
            labelLcsFixUrl.Size = new System.Drawing.Size(112, 15);
            labelLcsFixUrl.TabIndex = 6;
            labelLcsFixUrl.Text = "LCS Issue Search Url";
            // 
            // labelLcsUpdateUrl
            // 
            labelLcsUpdateUrl.AutoSize = true;
            labelLcsUpdateUrl.Location = new System.Drawing.Point(8, 50);
            labelLcsUpdateUrl.Name = "labelLcsUpdateUrl";
            labelLcsUpdateUrl.Size = new System.Drawing.Size(86, 15);
            labelLcsUpdateUrl.TabIndex = 5;
            labelLcsUpdateUrl.Text = "LCS Update Url";
            // 
            // labelLcsUrl
            // 
            labelLcsUrl.AutoSize = true;
            labelLcsUrl.Location = new System.Drawing.Point(8, 25);
            labelLcsUrl.Name = "labelLcsUrl";
            labelLcsUrl.Size = new System.Drawing.Size(45, 15);
            labelLcsUrl.TabIndex = 4;
            labelLcsUrl.Text = "LCS Url";
            // 
            // textBoxLcsDiagUrl
            // 
            textBoxLcsDiagUrl.Location = new System.Drawing.Point(220, 94);
            textBoxLcsDiagUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textBoxLcsDiagUrl.Name = "textBoxLcsDiagUrl";
            textBoxLcsDiagUrl.Size = new System.Drawing.Size(178, 23);
            textBoxLcsDiagUrl.TabIndex = 3;
            // 
            // textBoxLcsFixUrl
            // 
            textBoxLcsFixUrl.Location = new System.Drawing.Point(220, 69);
            textBoxLcsFixUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textBoxLcsFixUrl.Name = "textBoxLcsFixUrl";
            textBoxLcsFixUrl.Size = new System.Drawing.Size(178, 23);
            textBoxLcsFixUrl.TabIndex = 2;
            // 
            // textBoxLcsUpdateUrl
            // 
            textBoxLcsUpdateUrl.Location = new System.Drawing.Point(220, 44);
            textBoxLcsUpdateUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textBoxLcsUpdateUrl.Name = "textBoxLcsUpdateUrl";
            textBoxLcsUpdateUrl.Size = new System.Drawing.Size(178, 23);
            textBoxLcsUpdateUrl.TabIndex = 1;
            // 
            // textBoxLcsUrl
            // 
            textBoxLcsUrl.Location = new System.Drawing.Point(220, 20);
            textBoxLcsUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textBoxLcsUrl.Name = "textBoxLcsUrl";
            textBoxLcsUrl.Size = new System.Drawing.Size(178, 23);
            textBoxLcsUrl.TabIndex = 0;
            // 
            // rdpFullScreenEnabled
            // 
            rdpFullScreenEnabled.Location = new System.Drawing.Point(7, 75);
            rdpFullScreenEnabled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            rdpFullScreenEnabled.Name = "rdpFullScreenEnabled";
            rdpFullScreenEnabled.Size = new System.Drawing.Size(229, 23);
            rdpFullScreenEnabled.TabIndex = 2;
            rdpFullScreenEnabled.Text = "Force full screen RDP connection";
            // 
            // Parameters
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(454, 601);
            Controls.Add(groupBoxLCSUrls);
            Controls.Add(groupBoxCredentials);
            Controls.Add(groupBoxUIConfig);
            Controls.Add(groupBoxCaching);
            Controls.Add(groupBoxExportConfig);
            Controls.Add(groupCHE);
            Controls.Add(closeButton);
            Icon = Properties.Resources.favicon_blue;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Parameters";
            ShowInTaskbar = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Parameters";
            Load += Parameters_Load;
            groupBoxExportConfig.ResumeLayout(false);
            groupBoxExportConfig.PerformLayout();
            groupBoxUIConfig.ResumeLayout(false);
            groupBoxUIConfig.PerformLayout();
            groupBoxCaching.ResumeLayout(false);
            groupBoxCaching.PerformLayout();
            groupCHE.ResumeLayout(false);
            groupBoxCredentials.ResumeLayout(false);
            groupBoxLCSUrls.ResumeLayout(false);
            groupBoxLCSUrls.PerformLayout();
            ResumeLayout(false);
        }

        private void CachingEnabledCheckbox_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.CheckBox AutoRefreshCheckBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox groupBoxExportConfig;
        private System.Windows.Forms.Label labelOrgNameExcl;
        private System.Windows.Forms.TextBox textBoxProjectExcl;
        private System.Windows.Forms.GroupBox groupBoxUIConfig;
        private System.Windows.Forms.GroupBox groupBoxCaching;
        private System.Windows.Forms.CheckBox StoreCacheCheckBox;
        private System.Windows.Forms.CheckBox CachingEnabledCheckbox;
        private System.Windows.Forms.Button ClearCacheButton;
        private System.Windows.Forms.CheckBox minimizeToNotificationArea;
        private System.Windows.Forms.GroupBox groupCHE;
        private System.Windows.Forms.CheckBox alwaysLogAsAdmin;
        private System.Windows.Forms.CheckBox uriSchemeEnabled;
        private System.Windows.Forms.GroupBox groupBoxCredentials;
        private System.Windows.Forms.CheckBox RDPCredentialsCheckbox;
        private System.Windows.Forms.CheckBox LocalCredentialsCheckbox;
        private System.Windows.Forms.GroupBox groupBoxLCSUrls;
        private System.Windows.Forms.Label labelLcsUrl;
        private System.Windows.Forms.TextBox textBoxLcsDiagUrl;
        private System.Windows.Forms.TextBox textBoxLcsFixUrl;
        private System.Windows.Forms.TextBox textBoxLcsUpdateUrl;
        private System.Windows.Forms.TextBox textBoxLcsUrl;
        private System.Windows.Forms.Label labelLcsDiagUrl;
        private System.Windows.Forms.Label labelLcsFixUrl;
        private System.Windows.Forms.Label labelLcsUpdateUrl;
        private System.Windows.Forms.CheckBox rdpFullScreenEnabled;
    }
}