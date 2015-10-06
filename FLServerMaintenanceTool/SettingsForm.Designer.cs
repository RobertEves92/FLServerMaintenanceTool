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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFreelancerFolder = new System.Windows.Forms.TextBox();
            this.btnSetFLFolder = new System.Windows.Forms.Button();
            this.btnSetAccountsFolder = new System.Windows.Forms.Button();
            this.txtAccountFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetBackupFolder = new System.Windows.Forms.Button();
            this.txtBackupFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpFolders.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Freelancer:";
            // 
            // txtFreelancerFolder
            // 
            this.txtFreelancerFolder.Location = new System.Drawing.Point(72, 13);
            this.txtFreelancerFolder.Name = "txtFreelancerFolder";
            this.txtFreelancerFolder.Size = new System.Drawing.Size(290, 20);
            this.txtFreelancerFolder.TabIndex = 1;
            // 
            // btnSetFLFolder
            // 
            this.btnSetFLFolder.Location = new System.Drawing.Point(368, 11);
            this.btnSetFLFolder.Name = "btnSetFLFolder";
            this.btnSetFLFolder.Size = new System.Drawing.Size(24, 23);
            this.btnSetFLFolder.TabIndex = 2;
            this.btnSetFLFolder.UseVisualStyleBackColor = true;
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
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 348);
            this.Controls.Add(this.grpFolders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.grpFolders.ResumeLayout(false);
            this.grpFolders.PerformLayout();
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

    }
}