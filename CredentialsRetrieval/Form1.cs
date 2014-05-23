using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;

namespace CredentialsRetrieval
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel2.Text = System.DateTime.Now.ToString();
            timer1.Start();
        }

        private void btnGetMachineCredentials_Click(object sender, EventArgs e)
        {
            string userInfo = "";
			string NTDomain = "";
			string NTUserID = "";
            int slashPos;

            userInfo = WindowsIdentity.GetCurrent().Name.ToString();

            slashPos = userInfo.IndexOf("\\");
            NTDomain = userInfo.Substring(0, slashPos);
            NTUserID = userInfo.Substring(slashPos + 1, userInfo.Length - slashPos - 1);

            MessageBox.Show("You are logged in as " + NTUserID + " in the " + NTDomain + " domain.");

            MessageBox.Show(SystemInformation.UserName.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = System.DateTime.Now.ToString();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout aboutForm = new frmAbout();

            aboutForm.Show();
        }
    }
}
