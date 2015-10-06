using System;
using System.Windows.Forms;
using System.Threading;

namespace FLServerMaintenanceTool
{
    public partial class MainForm : Form
    {
        Thread maintainanceThread;
        ProcessManager pm;
        int minsToGo = 60;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Common.AutoRun)
            {
                maintainanceThread = new Thread(AutoMaintainanceThread);
                maintainanceThread.Start();
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
                    maintainanceThread.Abort();
                    do { } while (maintainanceThread.ThreadState == ThreadState.Running);
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
            pm = new ProcessManager();

            //Countdown
            Countdown();
            Common.MaintainanceRunning = true;
            //Close Processes
            string[] proccessToClose = Properties.Settings.Default.CloseProcesses.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (string s in proccessToClose)
            {
                AddLogLine("Shutting down " + s);
                pm.CloseProcess(s);
            }
            //Perform Backup
            AddLogLine("Starting Backups");
            Backup backup = new Backup();
            backup.RunBackup();
            AddLogLine("Backups complete");
            //Start Processes
            string[] proccessToStart = Properties.Settings.Default.RestartProcesses.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (string s in proccessToStart)
            {
                AddLogLine("Starting " + s);
                pm.StartProcess(s);
            }
            AddLogLine("Auto Maintainance Completed");
        }

        void AddLogLine(string line)
        {
            if (txtLog.InvokeRequired)
            {
                txtLog.Invoke(new Action<string>(AddLogLine),new object[]{line});
            }
            else { txtLog.Text = txtLog.Text + line + "\r\n"; }
        }

        #region Countdown Methods
        void Countdown()
        {
            //Create a connection to flhook and connect it
            FLHookConnection flhookconnection = new FLHookConnection();
            flhookconnection.Connect();

            //Send 1hr warning
            AddLogLine("Auto Maintainance in 1hr");
            flhookconnection.SendUniverseMessage("The server will be shut down in about 1 hour for auto-maintenance.");
            Wait(15);

            //Send 45min warning
            AddLogLine("AutoMaintainance in 45mins");
            flhookconnection.SendUniverseMessage("The server will be shut down in about 45 minutes for auto-maintenance.");
            Wait(15);

            //Send 30min warning
            AddLogLine("Auto Maintainance in 30mins");
            flhookconnection.SendUniverseMessage("The server will be shut down in about 30 minutes for auto-maintenance.");
            Wait(15);

            //Send 15min warning
            AddLogLine("Auto Maintainance in 15mins");
            flhookconnection.SendUniverseMessage("The server will be shut down in about 15 minutes for auto-maintenance.");
            Wait(5);

            //Send 10min warning
            AddLogLine("Auto Maintainance in 10mins");
            flhookconnection.SendUniverseMessage("The server will be shut down in about 10 minutes for auto-maintenance.");
            Wait(5);

            //Send 5min warning
            AddLogLine("Auto Maintainance in 5mins");
            flhookconnection.SendUniverseMessage("The server will be shut down in about 5 minutes for auto-maintenance.  It will be back up again shortly after.");
            Wait(4);

            //Send 1min warning
            AddLogLine("Auto Maintainance in 1min");
            flhookconnection.SendUniverseMessage("The server will be shut down in about 1 minute for auto-maintenance.  To avoid losing information in your playerfile, please log off NOW!");
            Wait(1);

            //Send shutdown warning
            AddLogLine("Auto Maintainance Started");
            UpdateLblCountdown(0);
            UpdatePgrCountdown(0);

            //Diconnect from FLHook
            flhookconnection.Disconnect();
        }

        private void Wait(int minsToWait)
        {
            for (int i = 0; i < minsToWait; i++)
            {
#if DEBUG
                Thread.Sleep(1000);
#else
                Thread.Sleep(60 * 1000);
#endif
                minsToGo--;
                UpdatePgrCountdown(minsToGo);
                UpdateLblCountdown(minsToGo);
            }
        }

        void UpdatePgrCountdown(int mins)
        {
            if(pgrCountdown.InvokeRequired)
            {
                pgrCountdown.Invoke(new Action<int>(UpdatePgrCountdown),new object[]{mins});
            }
            else
            {
                pgrCountdown.Value=mins;
            }
        }

        void UpdateLblCountdown(int mins)
        {
            if (lblCountdown.InvokeRequired)
            {
                lblCountdown.Invoke(new Action<int>(UpdateLblCountdown), new object[] { mins });
            }
            else
            {
                if (mins > 0)
                {
                    lblCountdown.Text = "Time to Auto Maintainance: " + mins + "mins";
                }
                else
                {
                    lblCountdown.Text = "Auto Maintainance Started";
                }
            }
        }
        #endregion
    }
}
