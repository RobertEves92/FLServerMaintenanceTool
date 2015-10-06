using System;
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

        private void BtnCancelClick(object sender, EventArgs e)
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

        private void BtnSaveClick(object sender, EventArgs e)
        {
            //Save new settings
            Properties.Settings.Default.FLFolder = txtFreelancerFolder.Text;
            Properties.Settings.Default.AccountsFolder = txtAccountFolder.Text;
            Properties.Settings.Default.BackupsFolder = txtBackupFolder.Text;
            Properties.Settings.Default.ServerAddress = txtServerAddress.Text;
            Properties.Settings.Default.ServerPassword = txtServerPassword.Text;
            Properties.Settings.Default.ServerPort = Convert.ToInt32(numServerPort.Value);
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
            numServerPort.Value = Properties.Settings.Default.ServerPort;
            txtProcessesShutdown.Text = Properties.Settings.Default.CloseProcesses;
            txtProcessesRestart.Text = Properties.Settings.Default.RestartProcesses;
        }

        private void BtnSetFLFolderClick(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            txtFreelancerFolder.Text = folderBrowserDialog.SelectedPath;
        }

        private void BtnSetAccountsFolderClick(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            txtAccountFolder.Text = folderBrowserDialog.SelectedPath;
        }

        private void BtnSetBackupFolderClick(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            txtBackupFolder.Text = folderBrowserDialog.SelectedPath;
        }
    }
}
