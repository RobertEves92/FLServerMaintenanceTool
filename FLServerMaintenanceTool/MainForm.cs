using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace FLServerMaintenanceTool
{
    public partial class MainForm : Form
    {
        Thread MaintainanceThread;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Common.AutoRun)
            {
                MaintainanceThread = new Thread(AutoMaintainanceThread);
                MaintainanceThread.Start();
            }
            else
            {
                lblCountdown.Text = "Auto Maintainance not running - restart with /autorun";
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Common.MaintainanceRunning)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to cancel auto maintainance?", "Cancel Maintainance?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    //TODO Cancel
                }
            }
            else
            {
                MessageBox.Show("Auto Maintainance is already running.", "Cannot Cancel Maintainance", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        void AutoMaintainanceThread()
        {
            //Countdown
            //Close Processes
            //Perform Backup
            //Start Processes
        }

        void Countdown()
        {
            int minsToGo = 60;

            //Create a connection to flhook and connect it
            //FLHookConnection flhookconnection = new FLHookConnection();
            //flhookconnection.Connect();

            //Send 1hr warning
            AddLogLine("Auto Maintainance in 1hr");
        }

        void AddLogLine(string line)
        {
            if (txtLog.InvokeRequired)
            {
                txtLog.Invoke(new Action<string>(AddLogLine),new object[]{line});
            }
            else { txtLog.Text = txtLog.Text + line + "\r\n"; }
        }
    }
}
