namespace FLServerMaintenanceTool
{
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
            this.grpFolders.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.btnSetBackupFolder.Location = new System.Drawing.Point(368, 63);
            this.btnSetBackupFolder.Name = "btnSetBackupFolder";
            this.btnSetBackupFolder.Size = new System.Drawing.Size(24, 23);
            this.btnSetBackupFolder.TabIndex = 8;
            this.btnSetBackupFolder.UseVisualStyleBackColor = true;
            // 
            // txtBackupFolder
            // 
            this.txtBackupFolder.Location = new System.Drawing.Point(72, 65);
            this.txtBackupFolder.Name = "txtBackupFolder";
            this.txtBackupFolder.Size = new System.Drawing.Size(290, 20);
            this.txtBackupFolder.TabIndex = 7;
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
            this.btnSetAccountsFolder.Location = new System.Drawing.Point(368, 37);
            this.btnSetAccountsFolder.Name = "btnSetAccountsFolder";
            this.btnSetAccountsFolder.Size = new System.Drawing.Size(24, 23);
            this.btnSetAccountsFolder.TabIndex = 5;
            this.btnSetAccountsFolder.UseVisualStyleBackColor = true;
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
            this.btnSetFLFolder.Location = new System.Drawing.Point(368, 11);
            this.btnSetFLFolder.Name = "btnSetFLFolder";
            this.btnSetFLFolder.Size = new System.Drawing.Size(24, 23);
            this.btnSetFLFolder.TabIndex = 2;
            this.btnSetFLFolder.UseVisualStyleBackColor = true;
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
            // txtServerPassword
            // 
            this.txtServerPassword.Location = new System.Drawing.Point(262, 13);
            this.txtServerPassword.Name = "txtServerPassword";
            this.txtServerPassword.Size = new System.Drawing.Size(100, 20);
            this.txtServerPassword.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password:";
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.Location = new System.Drawing.Point(94, 13);
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.Size = new System.Drawing.Size(100, 20);
            this.txtServerAddress.TabIndex = 1;
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
            this.groupBox2.Size = new System.Drawing.Size(404, 100);
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
            this.label7.TabIndex = 3;
            this.label7.Text = "Processes to restart:";
            // 
            // txtProcessesRestart
            // 
            this.txtProcessesRestart.Location = new System.Drawing.Point(203, 32);
            this.txtProcessesRestart.Multiline = true;
            this.txtProcessesRestart.Name = "txtProcessesRestart";
            this.txtProcessesRestart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProcessesRestart.Size = new System.Drawing.Size(189, 62);
            this.txtProcessesRestart.TabIndex = 2;
            // 
            // txtProcessesShutdown
            // 
            this.txtProcessesShutdown.Location = new System.Drawing.Point(9, 32);
            this.txtProcessesShutdown.Multiline = true;
            this.txtProcessesShutdown.Name = "txtProcessesShutdown";
            this.txtProcessesShutdown.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProcessesShutdown.Size = new System.Drawing.Size(185, 62);
            this.txtProcessesShutdown.TabIndex = 1;
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
            this.btnCancel.Location = new System.Drawing.Point(341, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(260, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 304);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpFolders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.grpFolders.ResumeLayout(false);
            this.grpFolders.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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

    }
}