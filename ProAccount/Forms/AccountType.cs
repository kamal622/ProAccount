using ProAccount.Core;
using ProAccount.Service.Account;
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
    public partial class AccountType : Form
    {
        public AccountType()
        {
            InitializeComponent();
        }
        AccountService accountService = null;
        int TypeId = 0;

        private void AccountType_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTypeSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAccountType.Text != "")
                {
                    accountService = new AccountService();
                    Data.Models.AccountType accountData = new Data.Models.AccountType();
                    accountData.Id = TypeId;
                    accountData.Type = txtAccountType.Text;
                    accountService.SaveAccountType(accountData);
                    txtAccountType.Text = "";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTypeDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TypeId > 0)
                {
                    accountService = new AccountService();
                    accountService.DeleteAccountTypeById(TypeId);
                    MessageBox.Show("Record deleted");
                    txtAccountType.Text = "";
                    TypeId = 0;
                    txtSearchType.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTypeClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtAccountType.Text = "";
                txtSearchType.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTypeClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchType_Click(object sender, EventArgs e)
        {
            string Qry = "select s.Id,s.Type from AccountType s";
            string Colwidth = "";
            string test = "";
            var searchName = txtSearchType.Text;
            string tblName = "AccountType";
            CommonModule.ShowSearchengine(searchName, Qry, 0, "Name", tblName, Colwidth, test, 0);
            if (CommonModule.mId > 0)
            {
                GetTypeById(CommonModule.mId);
            }
        }

        private void GetTypeById(int Id)
        {
            try
            {
                accountService = new AccountService();
                var accountTypedata = accountService.GetAccountTypeById(Id);
                assignDatatoFields(accountTypedata);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void assignDatatoFields(Data.Models.AccountType accountTypedata)
        {
            try
            {
                TypeId = accountTypedata.Id;
                txtSearchType.Text = accountTypedata.Type;
                txtAccountType.Text = accountTypedata.Type;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAccountType_Leave(object sender, EventArgs e)
        {
            try
            {
                CheckAccountType();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckAccountType()
        {
            try
            {
                accountService = new AccountService();
                bool isexits = accountService.IsAccountTypeExists(txtAccountType.Text);
                if (isexits)
                {
                    MessageBox.Show("Account Type is aleardy Exits");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
