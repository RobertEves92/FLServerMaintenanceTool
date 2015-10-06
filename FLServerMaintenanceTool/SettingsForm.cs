using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FLServerMaintenanceTool
{
    public partial class SettingsForm : Form
    {
        private static bool warnClose = true;
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (warnClose)
            {
                DialogResult result = MessageBox.Show("Cancel all changes?", "Cancel?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == System.Windows.Forms.DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save new settings
            Properties.Settings.Default.FLFolder = txtFreelancerFolder.Text;
            Properties.Settings.Default.AccountsFolder = txtAccountFolder.Text;
            Properties.Settings.Default.BackupsFolder = txtBackupFolder.Text;
            Properties.Settings.Default.ServerAddress = txtServerAddress.Text;
            Properties.Settings.Default.ServerPassword = txtServerPassword.Text;
            Properties.Settings.Default.CloseProcesses = txtProcessesShutdown.Text;
            Properties.Settings.Default.RestartProcesses = txtProcessesRestart.Text;
            Properties.Settings.Default.Save();
            //close without warning
            warnClose = false;
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            txtFreelancerFolder.Text = Properties.Settings.Default.FLFolder;
            txtAccountFolder.Text = Properties.Settings.Default.AccountsFolder;
            txtBackupFolder.Text = Properties.Settings.Default.BackupsFolder;
            txtServerAddress.Text = Properties.Settings.Default.ServerAddress;
            txtServerPassword.Text = Properties.Settings.Default.ServerPassword;
            txtProcessesShutdown.Text = Properties.Settings.Default.CloseProcesses;
            txtProcessesRestart.Text = Properties.Settings.Default.RestartProcesses;
        }
    }
}
