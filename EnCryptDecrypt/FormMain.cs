using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnCryptDecrypt
{
    public partial class FormMain : Form
    {
        private System.Windows.Forms.ErrorProvider error;

        public FormMain()
        {
            InitializeComponent();
            Application.EnableVisualStyles();
        }


        #region Main
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        //static void Main()
        //{
        //    Application.Run(new FormMain());
        //}
        #endregion

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (txtClearText.Text == "")
            {
                error.SetError(txtClearText, "Enter the text you want to encrypt");
            }
            else
            {   
                string clearText = txtClearText.Text.Trim();
                string cipherText = CryptoEngine.Encrypt(clearText, true);
                txtDecryptedText.Visible = false;
                label3.Visible = false;
                txtCipherText.Text = cipherText;
                btnDecrypt.Enabled = true;
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string cipherText = txtCipherText.Text.Trim();
            string decryptedText = CryptoEngine.Decrypt(cipherText, true);
            txtDecryptedText.Text = decryptedText;
            txtDecryptedText.Visible = true;
            label3.Visible = true;
        }
    }
}
