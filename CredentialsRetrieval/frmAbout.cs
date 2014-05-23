using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CredentialsRetrieval
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void frmAbout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 100)
                this.Opacity = this.Opacity + 0.10;
            else
            {
                this.Opacity = 100;
                timer1.Stop();

            }
        }
    }
}
