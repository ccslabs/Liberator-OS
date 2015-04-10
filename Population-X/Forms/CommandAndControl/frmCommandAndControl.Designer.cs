namespace Population_X.Forms.CommandAndControl
{
    partial class frmCommandAndControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckUpdate = new System.Windows.Forms.Button();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFakeLocation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbAnonymity = new Population_X.xControls.XCheckBox();
            this.cbFileSystemEncryption = new Population_X.xControls.XCheckBox();
            this.cbNetworkIntrusion = new Population_X.xControls.XCheckBox();
            this.cbNetworkEncryption = new Population_X.xControls.XCheckBox();
            this.cbNetworkHopping = new Population_X.xControls.XCheckBox();
            this.cbNetworkVPN = new Population_X.xControls.XCheckBox();
            this.cbNetworkSpoofing = new Population_X.xControls.XCheckBox();
            this.cbIdentitySpoofing = new Population_X.xControls.XCheckBox();
            this.cbAntiVirusRunning = new Population_X.xControls.XCheckBox();
            this.cbFirewallRunning = new Population_X.xControls.XCheckBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Command And Control";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.cbAnonymity);
            this.flowLayoutPanel1.Controls.Add(this.cbFileSystemEncryption);
            this.flowLayoutPanel1.Controls.Add(this.cbNetworkIntrusion);
            this.flowLayoutPanel1.Controls.Add(this.cbNetworkEncryption);
            this.flowLayoutPanel1.Controls.Add(this.cbNetworkHopping);
            this.flowLayoutPanel1.Controls.Add(this.cbNetworkVPN);
            this.flowLayoutPanel1.Controls.Add(this.cbNetworkSpoofing);
            this.flowLayoutPanel1.Controls.Add(this.cbIdentitySpoofing);
            this.flowLayoutPanel1.Controls.Add(this.cbAntiVirusRunning);
            this.flowLayoutPanel1.Controls.Add(this.cbFirewallRunning);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(683, 120);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your Fake Location";
            // 
            // btnCheckUpdate
            // 
            this.btnCheckUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckUpdate.BackgroundImage = global::Population_X.Properties.Resources.update;
            this.btnCheckUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.btnCheckUpdate.Location = new System.Drawing.Point(711, 77);
            this.btnCheckUpdate.Name = "btnCheckUpdate";
            this.btnCheckUpdate.Size = new System.Drawing.Size(30, 30);
            this.btnCheckUpdate.TabIndex = 6;
            this.btnCheckUpdate.UseVisualStyleBackColor = false;
            this.btnCheckUpdate.Click += new System.EventHandler(this.btnCheckUpdate_Click);
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitApplication.BackColor = System.Drawing.Color.Transparent;
            this.btnExitApplication.BackgroundImage = global::Population_X.Properties.Resources.stop;
            this.btnExitApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitApplication.ForeColor = System.Drawing.Color.Transparent;
            this.btnExitApplication.Location = new System.Drawing.Point(711, 36);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(30, 30);
            this.btnExitApplication.TabIndex = 5;
            this.btnExitApplication.UseVisualStyleBackColor = false;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::Population_X.Properties.Resources.bullet_arrow_up;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(731, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 23);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // lblFakeLocation
            // 
            this.lblFakeLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFakeLocation.AutoSize = true;
            this.lblFakeLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Population_X.Properties.Settings.Default, "CurrentFakeLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblFakeLocation.Location = new System.Drawing.Point(122, 168);
            this.lblFakeLocation.Name = "lblFakeLocation";
            this.lblFakeLocation.Size = new System.Drawing.Size(16, 13);
            this.lblFakeLocation.TabIndex = 4;
            this.lblFakeLocation.Text = global::Population_X.Properties.Settings.Default.CurrentFakeLocation;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 10);
            this.panel1.TabIndex = 7;
            // 
            // cbAnonymity
            // 
            this.cbAnonymity.AlwaysShowCheck = true;
            this.cbAnonymity.AutoSize = true;
            this.cbAnonymity.Checked = global::Population_X.Properties.Settings.Default.AnonymityRunning;
            this.cbAnonymity.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Population_X.Properties.Settings.Default, "AnonymityRunning", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbAnonymity.Location = new System.Drawing.Point(3, 3);
            this.cbAnonymity.Name = "cbAnonymity";
            this.cbAnonymity.ReadOnly = true;
            this.cbAnonymity.ReadOnlyCheckedColor = System.Drawing.Color.Green;
            this.cbAnonymity.ReadOnlyUncheckedColor = System.Drawing.Color.Transparent;
            this.cbAnonymity.Size = new System.Drawing.Size(74, 17);
            this.cbAnonymity.TabIndex = 13;
            this.cbAnonymity.Text = "Anonymity";
            this.cbAnonymity.UseVisualStyleBackColor = true;
            // 
            // cbFileSystemEncryption
            // 
            this.cbFileSystemEncryption.AlwaysShowCheck = true;
            this.cbFileSystemEncryption.Checked = global::Population_X.Properties.Settings.Default.FileSystemEncryptionRunning;
            this.cbFileSystemEncryption.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Population_X.Properties.Settings.Default, "FileSystemEncryptionRunning", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbFileSystemEncryption.Location = new System.Drawing.Point(3, 26);
            this.cbFileSystemEncryption.Name = "cbFileSystemEncryption";
            this.cbFileSystemEncryption.ReadOnly = true;
            this.cbFileSystemEncryption.ReadOnlyCheckedColor = System.Drawing.Color.Green;
            this.cbFileSystemEncryption.ReadOnlyUncheckedColor = System.Drawing.Color.Transparent;
            this.cbFileSystemEncryption.Size = new System.Drawing.Size(141, 17);
            this.cbFileSystemEncryption.TabIndex = 20;
            this.cbFileSystemEncryption.Text = "File System Encryption";
            this.cbFileSystemEncryption.UseVisualStyleBackColor = true;
            // 
            // cbNetworkIntrusion
            // 
            this.cbNetworkIntrusion.AlwaysShowCheck = true;
            this.cbNetworkIntrusion.AutoSize = true;
            this.cbNetworkIntrusion.Checked = global::Population_X.Properties.Settings.Default.NetworkIntrusionDetection;
            this.cbNetworkIntrusion.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Population_X.Properties.Settings.Default, "NetworkIntrusionDetection", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbNetworkIntrusion.Location = new System.Drawing.Point(3, 49);
            this.cbNetworkIntrusion.Name = "cbNetworkIntrusion";
            this.cbNetworkIntrusion.ReadOnly = true;
            this.cbNetworkIntrusion.ReadOnlyCheckedColor = System.Drawing.Color.Green;
            this.cbNetworkIntrusion.ReadOnlyUncheckedColor = System.Drawing.Color.Transparent;
            this.cbNetworkIntrusion.Size = new System.Drawing.Size(158, 17);
            this.cbNetworkIntrusion.TabIndex = 18;
            this.cbNetworkIntrusion.Text = "Network Intrusion Detection";
            this.cbNetworkIntrusion.UseVisualStyleBackColor = true;
            // 
            // cbNetworkEncryption
            // 
            this.cbNetworkEncryption.AlwaysShowCheck = true;
            this.cbNetworkEncryption.AutoSize = true;
            this.cbNetworkEncryption.Checked = global::Population_X.Properties.Settings.Default.NetworkEncryptionRunning;
            this.cbNetworkEncryption.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Population_X.Properties.Settings.Default, "NetworkEncryptionRunning", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbNetworkEncryption.Location = new System.Drawing.Point(3, 72);
            this.cbNetworkEncryption.Name = "cbNetworkEncryption";
            this.cbNetworkEncryption.ReadOnly = true;
            this.cbNetworkEncryption.ReadOnlyCheckedColor = System.Drawing.Color.Green;
            this.cbNetworkEncryption.ReadOnlyUncheckedColor = System.Drawing.Color.Transparent;
            this.cbNetworkEncryption.Size = new System.Drawing.Size(119, 17);
            this.cbNetworkEncryption.TabIndex = 19;
            this.cbNetworkEncryption.Text = "Network Encryption";
            this.cbNetworkEncryption.UseVisualStyleBackColor = true;
            // 
            // cbNetworkHopping
            // 
            this.cbNetworkHopping.AlwaysShowCheck = true;
            this.cbNetworkHopping.AutoSize = true;
            this.cbNetworkHopping.Checked = global::Population_X.Properties.Settings.Default.NetworkHoppingRunning;
            this.cbNetworkHopping.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Population_X.Properties.Settings.Default, "NetworkHoppingRunning", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbNetworkHopping.Location = new System.Drawing.Point(3, 95);
            this.cbNetworkHopping.Name = "cbNetworkHopping";
            this.cbNetworkHopping.ReadOnly = true;
            this.cbNetworkHopping.ReadOnlyCheckedColor = System.Drawing.Color.Green;
            this.cbNetworkHopping.ReadOnlyUncheckedColor = System.Drawing.Color.Transparent;
            this.cbNetworkHopping.Size = new System.Drawing.Size(109, 17);
            this.cbNetworkHopping.TabIndex = 21;
            this.cbNetworkHopping.Text = "Network Hopping";
            this.cbNetworkHopping.UseVisualStyleBackColor = true;
            // 
            // cbNetworkVPN
            // 
            this.cbNetworkVPN.AlwaysShowCheck = true;
            this.cbNetworkVPN.AutoSize = true;
            this.cbNetworkVPN.Checked = global::Population_X.Properties.Settings.Default.NetworkVPNRunning;
            this.cbNetworkVPN.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Population_X.Properties.Settings.Default, "NetworkVPNRunning", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbNetworkVPN.Location = new System.Drawing.Point(167, 3);
            this.cbNetworkVPN.Name = "cbNetworkVPN";
            this.cbNetworkVPN.ReadOnly = true;
            this.cbNetworkVPN.ReadOnlyCheckedColor = System.Drawing.Color.Green;
            this.cbNetworkVPN.ReadOnlyUncheckedColor = System.Drawing.Color.Transparent;
            this.cbNetworkVPN.Size = new System.Drawing.Size(91, 17);
            this.cbNetworkVPN.TabIndex = 22;
            this.cbNetworkVPN.Text = "Network VPN";
            this.cbNetworkVPN.UseVisualStyleBackColor = true;
            // 
            // cbNetworkSpoofing
            // 
            this.cbNetworkSpoofing.AlwaysShowCheck = true;
            this.cbNetworkSpoofing.Checked = global::Population_X.Properties.Settings.Default.MACSpoofingRunning;
            this.cbNetworkSpoofing.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Population_X.Properties.Settings.Default, "MACSpoofingRunning", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbNetworkSpoofing.Location = new System.Drawing.Point(167, 26);
            this.cbNetworkSpoofing.Name = "cbNetworkSpoofing";
            this.cbNetworkSpoofing.ReadOnly = true;
            this.cbNetworkSpoofing.ReadOnlyCheckedColor = System.Drawing.Color.Green;
            this.cbNetworkSpoofing.ReadOnlyUncheckedColor = System.Drawing.Color.Transparent;
            this.cbNetworkSpoofing.Size = new System.Drawing.Size(141, 17);
            this.cbNetworkSpoofing.TabIndex = 17;
            this.cbNetworkSpoofing.Text = "MAC Spoofing";
            this.cbNetworkSpoofing.UseVisualStyleBackColor = true;
            // 
            // cbIdentitySpoofing
            // 
            this.cbIdentitySpoofing.AlwaysShowCheck = true;
            this.cbIdentitySpoofing.AutoSize = true;
            this.cbIdentitySpoofing.Checked = global::Population_X.Properties.Settings.Default.IdentitySpoofingRunning;
            this.cbIdentitySpoofing.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Population_X.Properties.Settings.Default, "IdentitySpoofingRunning", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbIdentitySpoofing.Location = new System.Drawing.Point(167, 49);
            this.cbIdentitySpoofing.Name = "cbIdentitySpoofing";
            this.cbIdentitySpoofing.ReadOnly = true;
            this.cbIdentitySpoofing.ReadOnlyCheckedColor = System.Drawing.Color.Green;
            this.cbIdentitySpoofing.ReadOnlyUncheckedColor = System.Drawing.Color.Transparent;
            this.cbIdentitySpoofing.Size = new System.Drawing.Size(105, 17);
            this.cbIdentitySpoofing.TabIndex = 16;
            this.cbIdentitySpoofing.Text = "Identity Spoofing";
            this.cbIdentitySpoofing.UseVisualStyleBackColor = true;
            // 
            // cbAntiVirusRunning
            // 
            this.cbAntiVirusRunning.AlwaysShowCheck = true;
            this.cbAntiVirusRunning.AutoSize = true;
            this.cbAntiVirusRunning.Location = new System.Drawing.Point(167, 72);
            this.cbAntiVirusRunning.Name = "cbAntiVirusRunning";
            this.cbAntiVirusRunning.ReadOnly = true;
            this.cbAntiVirusRunning.ReadOnlyCheckedColor = System.Drawing.Color.Green;
            this.cbAntiVirusRunning.ReadOnlyUncheckedColor = System.Drawing.Color.Transparent;
            this.cbAntiVirusRunning.Size = new System.Drawing.Size(113, 17);
            this.cbAntiVirusRunning.TabIndex = 15;
            this.cbAntiVirusRunning.Text = "Anti-Virus Running";
            this.cbAntiVirusRunning.UseVisualStyleBackColor = true;
            // 
            // cbFirewallRunning
            // 
            this.cbFirewallRunning.AlwaysShowCheck = true;
            this.cbFirewallRunning.Checked = global::Population_X.Properties.Settings.Default.FirewallRunning;
            this.cbFirewallRunning.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Population_X.Properties.Settings.Default, "FirewallRunning", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbFirewallRunning.Location = new System.Drawing.Point(167, 95);
            this.cbFirewallRunning.Name = "cbFirewallRunning";
            this.cbFirewallRunning.ReadOnly = true;
            this.cbFirewallRunning.ReadOnlyCheckedColor = System.Drawing.Color.Green;
            this.cbFirewallRunning.ReadOnlyUncheckedColor = System.Drawing.Color.Transparent;
            this.cbFirewallRunning.Size = new System.Drawing.Size(141, 17);
            this.cbFirewallRunning.TabIndex = 14;
            this.cbFirewallRunning.Text = "Firewall Running";
            this.cbFirewallRunning.UseVisualStyleBackColor = true;
            // 
            // frmCommandAndControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(753, 207);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCheckUpdate);
            this.Controls.Add(this.btnExitApplication);
            this.Controls.Add(this.lblFakeLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCommandAndControl";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Command And Control";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private xControls.XCheckBox cbFileSystemEncryption;
        private xControls.XCheckBox cbNetworkEncryption;
        private xControls.XCheckBox cbNetworkIntrusion;
        private xControls.XCheckBox cbNetworkSpoofing;
        private xControls.XCheckBox cbIdentitySpoofing;
        private xControls.XCheckBox cbAntiVirusRunning;
        private xControls.XCheckBox cbFirewallRunning;
        private xControls.XCheckBox cbAnonymity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFakeLocation;
        private xControls.XCheckBox cbNetworkHopping;
        private xControls.XCheckBox cbNetworkVPN;
        private System.Windows.Forms.Button btnExitApplication;
        private System.Windows.Forms.Button btnCheckUpdate;
        private System.Windows.Forms.Panel panel1;
    }
}