using System;
using System.Windows.Forms;

namespace FLServerMaintainanceSettings
{
    /// <summary>
    /// Input Box for creating or editing countdown items
    /// </summary>
    public partial class InputBox : Form
    {
        /// <summary>
        /// Input Box Constructor
        /// </summary>
        public InputBox()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Message to write to the console
        /// </summary>
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

        /// <summary>
        /// Message to send to FL Universe
        /// </summary>
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

        /// <summary>
        /// Number of minutes to wait after displaying messages
        /// </summary>
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