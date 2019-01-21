using ProAccount.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProAccount.Forms
{
    public partial class ChequeForm : Form
    {
        public ChequeForm()
        {
            InitializeComponent();
        }

        public string chequeNo = "";
        public string bankName = "";
        //public string ifscCode = "";
        public DateTime chequeDate = DateTime.Today;

        private void ChequeForm_Load(object sender, EventArgs e)
        {
            btnChequeDelete.Enabled = false;
        }

        private void btnChequeSave_Click(object sender, EventArgs e)
        {
            chequeNo = txtChequeNo.Text;
            chequeDate = dtChequeDate.Value;
            bankName = txtBankName.Text;
            //ifscCode = txtIFSCCode.Text;
            this.Close();
        }

        private void btnChequeDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnChequeClear_Click(object sender, EventArgs e)
        {
            txtBankName.Text = "";
            dtChequeDate.Value = DateTime.Today;
            txtChequeNo.Text = "";
            //txtIFSCCode.Text = "";
        }

        private void btnChequeClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateChequeForm()
        {
            try
            {
                string bankNameMessage = "";
                string ifscMessage = "";
                string chequeNoMessage = "";
                if(txtBankName.Text == "" || txtBankName.Text == null)
                {
                    bankNameMessage = "Bank name is requored!\n";
                }
                if (txtChequeNo.Text == "" || txtChequeNo.Text == null)
                {
                    chequeNoMessage = "ChequeNo is requored!\n";
                }
                //if (txtIFSCCode.Text == "" || txtIFSCCode.Text == null)
                //{
                  //  ifscMessage = "IFSC code is requored!\n";
                //}

                if(bankNameMessage != "" || ifscMessage != "" || chequeNoMessage != "")
                {
                    MessageBox.Show(bankNameMessage + ifscMessage + chequeNoMessage);
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

       
    }
}
