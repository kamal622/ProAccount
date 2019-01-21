using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProAccount.Core;
using ProAccount.Service.Comman;

namespace ProAccount
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        CommanService commanService = null;

        string UserName = "";
        string Password = "";
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                UserName = txtLoginUserName.Text;
                Password = txtLoginPassword.Text;
                if (IsValidateUser(UserName, Password))
                {
                    PLMDIForm frmMDI = new PLMDIForm();
                    frmMDI.Show();
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool IsValidateUser(string UserName,string UserPassword)
        {
            string Encodedpassword = "";
            try
            {
                commanService = new CommanService();
                var userData = commanService.GetUserName(UserName);
                if (userData == null)
                {
                    MessageBox.Show("Invalid User,Please Check", Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                Encodedpassword = Cryptography.EncryptString(UserPassword);
                if (!(string.Compare(userData.Password, Encodedpassword, StringComparison.Ordinal) == 0))
                {
                   MessageBox.Show("Incorrect Password,Please Check", Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           try
            {
                this.Close();
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
         
    }
}
