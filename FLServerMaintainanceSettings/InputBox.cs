using System;
using System.Windows.Forms;

namespace FLServerMaintainanceSettings
{
    public partial class InputBox : Form
    {
        public InputBox()
        {
            this.InitializeComponent();
        }

        public string ConsoleMessage
        {
            get
            {
                return this.txtConsole.Text;
            }
            set
            {
                this.txtConsole.Text = value;
            }
        }

        public string UniverseMessage
        {
            get
            {
                return this.txtUniverse.Text;
            }
            set
            {
                this.txtUniverse.Text = value;
            }
        }

        public string WaitTime
        {
            get
            {
                return Convert.ToInt32(this.numWait.Value).ToString();
            }
            set
            {
                this.numWait.Value = decimal.Parse(value);
            }
        }

        private void BtnOKClick(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}