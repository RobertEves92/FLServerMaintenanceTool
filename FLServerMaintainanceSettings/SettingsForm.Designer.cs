using FLServerMaintainanceSettings;

namespace FLServerMaintainanceSettings
{
    /// <summary>
    /// Maintainance Tool Settings Form
    /// </summary>
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Auto Maintainance in 1hr",
            "The server will be shut down in about 1 hour for auto-maintenance.",
            "15"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Auto Maintainance in 45mins",
            "The server will be shut down in about 45 minutes for auto-maintenance.",
            "15"}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Auto Maintainance in 30mins",
            "The server will be shut down in about 30 minutes for auto-maintenance.",
            "15"}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Auto Maintainance in 15mins",
            "The server will be shut down in about 15 minutes for auto-maintenance.",
            "5"}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Auto Maintainance in 10mins",
            "The server will be shut down in about 10 minutes for auto-maintenance.",
            "5"}, -1);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "Auto Maintainance in 5mins",
            "The server will be shut down in about 5 minutes for auto-maintenance.  It will be" +
                " back up again shortly after.",
            "4"}, -1);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "Auto Maintainance in 1min",
            "The server will be shut down in about 1 minute for auto-maintenance.  To avoid lo" +
                "sing information in your playerfile, please log off NOW!",
            "1"}, -1);
            this.grpFolders = new System.Windows.Forms.GroupBox();
            this.btnSetBackupFolder = new System.Windows.Forms.Button();
            this.txtBackupFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSetAccountsFolder = new System.Windows.Forms.Button();
            this.txtAccountFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetFLFolder = new System.Windows.Forms.Button();
            this.txtFreelancerFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numServerPort = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtServerPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServerAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProcessesRestart = new System.Windows.Forms.TextBox();
            this.txtProcessesShutdown = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.grpCountdown = new System.Windows.Forms.GroupBox();
            this.listViewCountdown = new System.Windows.Forms.ListView();
            this.clmConsoleMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmUniverseMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmWaitTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.chkCountdown = new System.Windows.Forms.CheckBox();
            this.grpFolders.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServerPort)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpCountdown.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFolders
            // 
            this.grpFolders.Controls.Add(this.btnSetBackupFolder);
            this.grpFolders.Controls.Add(this.txtBackupFolder);
            this.grpFolders.Controls.Add(this.label3);
            this.grpFolders.Controls.Add(this.btnSetAccountsFolder);
            this.grpFolders.Controls.Add(this.txtAccountFolder);
            this.grpFolders.Controls.Add(this.label2);
            this.grpFolders.Controls.Add(this.btnSetFLFolder);
            this.grpFolders.Controls.Add(this.txtFreelancerFolder);
            this.grpFolders.Controls.Add(this.label1);
            this.grpFolders.Location = new System.Drawing.Point(12, 12);
            this.grpFolders.Name = "grpFolders";
            this.grpFolders.Size = new System.Drawing.Size(404, 100);
            this.grpFolders.TabIndex = 0;
            this.grpFolders.TabStop = false;
            this.grpFolders.Text = "Folders";
            // 
            // btnSetBackupFolder
            // 
            this.btnSetBackupFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnSetBackupFolder.Image")));
            this.btnSetBackupFolder.Location = new System.Drawing.Point(368, 63);
            this.btnSetBackupFolder.Name = "btnSetBackupFolder";
            this.btnSetBackupFolder.Size = new System.Drawing.Size(24, 23);
            this.btnSetBackupFolder.TabIndex = 8;
            this.btnSetBackupFolder.UseVisualStyleBackColor = true;
            this.btnSetBackupFolder.Click += new System.EventHandler(this.BtnSetBackupFolderClick);
            // 
            // txtBackupFolder
            // 
            this.txtBackupFolder.Location = new System.Drawing.Point(72, 65);
            this.txtBackupFolder.Name = "txtBackupFolder";
            this.txtBackupFolder.Size = new System.Drawing.Size(290, 20);
            this.txtBackupFolder.TabIndex = 7;
            this.txtBackupFolder.Text = "C:\\Freelancer Server Backups";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Backup:";
            // 
            // btnSetAccountsFolder
            // 
            this.btnSetAccountsFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnSetAccountsFolder.Image")));
            this.btnSetAccountsFolder.Location = new System.Drawing.Point(368, 37);
            this.btnSetAccountsFolder.Name = "btnSetAccountsFolder";
            this.btnSetAccountsFolder.Size = new System.Drawing.Size(24, 23);
            this.btnSetAccountsFolder.TabIndex = 5;
            this.btnSetAccountsFolder.UseVisualStyleBackColor = true;
            this.btnSetAccountsFolder.Click += new System.EventHandler(this.BtnSetAccountsFolderClick);
            // 
            // txtAccountFolder
            // 
            this.txtAccountFolder.Location = new System.Drawing.Point(72, 39);
            this.txtAccountFolder.Name = "txtAccountFolder";
            this.txtAccountFolder.Size = new System.Drawing.Size(290, 20);
            this.txtAccountFolder.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Accounts:";
            // 
            // btnSetFLFolder
            // 
            this.btnSetFLFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnSetFLFolder.Image")));
            this.btnSetFLFolder.Location = new System.Drawing.Point(368, 11);
            this.btnSetFLFolder.Name = "btnSetFLFolder";
            this.btnSetFLFolder.Size = new System.Drawing.Size(24, 23);
            this.btnSetFLFolder.TabIndex = 2;
            this.btnSetFLFolder.UseVisualStyleBackColor = true;
            this.btnSetFLFolder.Click += new System.EventHandler(this.BtnSetFLFolderClick);
            // 
            // txtFreelancerFolder
            // 
            this.txtFreelancerFolder.Location = new System.Drawing.Point(72, 13);
            this.txtFreelancerFolder.Name = "txtFreelancerFolder";
            this.txtFreelancerFolder.Size = new System.Drawing.Size(290, 20);
            this.txtFreelancerFolder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Freelancer:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numServerPort);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtServerPassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtServerAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 46);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FLHook";
            // 
            // numServerPort
            // 
            this.numServerPort.Location = new System.Drawing.Point(194, 13);
            this.numServerPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numServerPort.Name = "numServerPort";
            this.numServerPort.Size = new System.Drawing.Size(45, 20);
            this.numServerPort.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Port:";
            // 
            // txtServerPassword
            // 
            this.txtServerPassword.Location = new System.Drawing.Point(311, 13);
            this.txtServerPassword.Name = "txtServerPassword";
            this.txtServerPassword.Size = new System.Drawing.Size(81, 20);
            this.txtServerPassword.TabIndex = 5;
            this.txtServerPassword.Text = "password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password:";
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.Location = new System.Drawing.Point(94, 13);
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.Size = new System.Drawing.Size(63, 20);
            this.txtServerAddress.TabIndex = 1;
            this.txtServerAddress.Text = "127.0.0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Server Address:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtProcessesRestart);
            this.groupBox2.Controls.Add(this.txtProcessesShutdown);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 105);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Processes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Processes to restart:";
            // 
            // txtProcessesRestart
            // 
            this.txtProcessesRestart.Location = new System.Drawing.Point(203, 32);
            this.txtProcessesRestart.Multiline = true;
            this.txtProcessesRestart.Name = "txtProcessesRestart";
            this.txtProcessesRestart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProcessesRestart.Size = new System.Drawing.Size(189, 62);
            this.txtProcessesRestart.TabIndex = 3;
            // 
            // txtProcessesShutdown
            // 
            this.txtProcessesShutdown.Location = new System.Drawing.Point(9, 32);
            this.txtProcessesShutdown.Multiline = true;
            this.txtProcessesShutdown.Name = "txtProcessesShutdown";
            this.txtProcessesShutdown.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProcessesShutdown.Size = new System.Drawing.Size(185, 62);
            this.txtProcessesShutdown.TabIndex = 1;
            this.txtProcessesShutdown.Text = "FLServer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Processes to shutdown:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(879, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(798, 281);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // grpCountdown
            // 
            this.grpCountdown.Controls.Add(this.listViewCountdown);
            this.grpCountdown.Controls.Add(this.btnAdd);
            this.grpCountdown.Controls.Add(this.btnEdit);
            this.grpCountdown.Controls.Add(this.btnRemove);
            this.grpCountdown.Location = new System.Drawing.Point(431, 12);
            this.grpCountdown.Name = "grpCountdown";
            this.grpCountdown.Size = new System.Drawing.Size(529, 263);
            this.grpCountdown.TabIndex = 4;
            this.grpCountdown.TabStop = false;
            // 
            // listViewCountdown
            // 
            this.listViewCountdown.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmConsoleMessage,
            this.clmUniverseMessage,
            this.clmWaitTime});
            this.listViewCountdown.FullRowSelect = true;
            this.listViewCountdown.GridLines = true;
            this.listViewCountdown.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewCountdown.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14});
            this.listViewCountdown.Location = new System.Drawing.Point(6, 18);
            this.listViewCountdown.Name = "listViewCountdown";
            this.listViewCountdown.Size = new System.Drawing.Size(517, 210);
            this.listViewCountdown.TabIndex = 0;
            this.listViewCountdown.UseCompatibleStateImageBehavior = false;
            this.listViewCountdown.View = System.Windows.Forms.View.Details;
            // 
            // clmConsoleMessage
            // 
            this.clmConsoleMessage.Text = "Console Message";
            this.clmConsoleMessage.Width = 138;
            // 
            // clmUniverseMessage
            // 
            this.clmUniverseMessage.Text = "Universe Message";
            this.clmUniverseMessage.Width = 302;
            // 
            // clmWaitTime
            // 
            this.clmWaitTime.Text = "Wait (mins)";
            this.clmWaitTime.Width = 70;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(286, 234);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(367, 234);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEditClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(448, 234);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Delete";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemoveClick);
            // 
            // chkCountdown
            // 
            this.chkCountdown.AutoSize = true;
            this.chkCountdown.Checked = true;
            this.chkCountdown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCountdown.Location = new System.Drawing.Point(440, 12);
            this.chkCountdown.Name = "chkCountdown";
            this.chkCountdown.Size = new System.Drawing.Size(161, 17);
            this.chkCountdown.TabIndex = 3;
            this.chkCountdown.Text = "Countdown (Recommended)";
            this.chkCountdown.UseVisualStyleBackColor = true;
            this.chkCountdown.CheckedChanged += new System.EventHandler(this.ChkCountdownCheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 311);
            this.Controls.Add(this.chkCountdown);
            this.Controls.Add(this.grpCountdown);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpFolders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Freelancer Maintainance Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.grpFolders.ResumeLayout(false);
            this.grpFolders.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServerPort)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpCountdown.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFolders;
        private System.Windows.Forms.Button btnSetBackupFolder;
        private System.Windows.Forms.TextBox txtBackupFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSetAccountsFolder;
        private System.Windows.Forms.TextBox txtAccountFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSetFLFolder;
        private System.Windows.Forms.TextBox txtFreelancerFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtServerPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtServerAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProcessesRestart;
        private System.Windows.Forms.TextBox txtProcessesShutdown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numServerPort;
        private System.Windows.Forms.GroupBox grpCountdown;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.CheckBox chkCountdown;
        private System.Windows.Forms.ListView listViewCountdown;
        private System.Windows.Forms.ColumnHeader clmConsoleMessage;
        private System.Windows.Forms.ColumnHeader clmUniverseMessage;
        private System.Windows.Forms.ColumnHeader clmWaitTime;

    }
}