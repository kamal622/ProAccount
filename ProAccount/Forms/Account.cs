using ProAccount.Core;
using ProAccount.Service.Account;
using ProAccount.Service.Firm;
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
    public partial class Account : Form
    {
        FirmService firmService = null;
        AccountService accountService = null;
        int accountId = 0;

        public Account()
        {
            InitializeComponent();
            txtAccountName.LostFocus += new EventHandler(txtAccountName_LostFocus);
            txtOpeningDebit.LostFocus += new EventHandler(txtOpeningDebit_LostFocus);
            txtOpeningCredit.LostFocus += new EventHandler(txtOpeningCredit_LostFocus);
            txtAccountCode.LostFocus += new EventHandler(txtAccountCode_LostFocus);
            txtMobileNo.LostFocus += new EventHandler(txtMobileNo_LostFocus);
        }
        
        private void Account_Load(object sender, EventArgs e)
        {
            try
            {
                BindFirmCombo();
                accountId = 0;
                //BindAccountTypeCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFindAccountByName_Click(object sender, EventArgs e)
        {
            try
            {
                string Qry = "select a.Id,b.Name as FirmName,c.Type,a.AccountCode,a.ContactName,a.ContactNo,b.Name,a.OpeningCredit,a.OpeningDebit,a.Address,a.Email from Account a join Firm b on a.FirmId = b.Id join AccountType c on a.AccountTypes=c.Id";
                string Colwidth = "";
                string test = "";
                string tblName = "Account";
                //var searchName = txtContactName.Text;
                CommonModule.ShowSearchengine(txtAccountName, Qry, 0, "ContactName",tblName, Colwidth, test, 0);
                if (CommonModule.mId > 0)
                {
                    GetAccountData(CommonModule.mId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetAccountData(int Id)
        {
            try
            {
                accountService = new AccountService();
                if (Id > 0)
                {
                    var accountData = accountService.GetAccountById(Id);
                    assignFormFieldsData(accountData);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void assignFormFieldsData(Data.Models.Account accountData)
        {
            try
            {
                accountId = accountData.Id;
                comboFirm.SelectedValue = accountData.FirmId;
                comboAccountType.SelectedValue = accountData.AccountTypes;
                txtAccountName.Text = accountData.ContactName;
                txtMobileNo.Text = accountData.ContactNo;
                txtFindAccountName.Text = accountData.ContactName;
                txtAccountCode.Text= accountData.AccountCode;
                txtAddress.Text = accountData.Address;
                txtEmail.Text = accountData.Email;
                txtOpeningCredit.Text = accountData.OpeningCredit.ToString();
                txtOpeningDebit.Text = accountData.OpeningDebit.ToString();
                // btnAccountDelete.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAccountFieldsValues()
        {
            try
            {
                accountId = 0;
                comboFirm.SelectedIndex = -1;
                txtAccountName.Text = "";
                txtFindAccountName.Text = "";
                txtMobileNo.Text = "";
                txtAccountCode.Text = "";
                txtEmail.Text = "";
                txtOpeningCredit.Text = "";
                txtOpeningDebit.Text = "";
                txtAddress.Text = "";
               // btnAccountDelete.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnAccountSave_Click(object sender, EventArgs e)
        {
             try
            {
                if (ValidateAccountFields())
                {
                    accountService = new AccountService();

                    var firId = comboFirm.SelectedValue;
                    string Name = txtAccountName.Text;
                    string MobileNo = txtMobileNo.Text;
                    string accountCode = txtAccountCode.Text;
                    int firmId = Convert.ToInt32(firId);
                    int AccountType = Convert.ToInt32(comboAccountType.SelectedValue);

                    Data.Models.Account accounData = new Data.Models.Account();
                    accounData.Id = accountId;
                    accounData.ContactName = Name;
                    accounData.ContactNo = MobileNo;
                    accounData.FirmId = firmId;
                    accounData.AccountTypes = AccountType;
                    accounData.AccountCode = accountCode;
                    accounData.Address = txtAddress.Text;
                    accounData.OpeningCredit = Convert.ToDecimal(txtOpeningCredit.Text);
                    accounData.OpeningDebit = Convert.ToDecimal(txtOpeningDebit.Text);
                    accounData.Email = txtEmail.Text;      
                        
                    accountService.SaveAccount(accounData);
                    ClearAccountFieldsValues();
                    MessageBox.Show("Account added", Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateAccountFields()
        {
            try
            {
                string firmessage = "";
                string nameMsg = "";
                string cNoMsg = "";
                string accountCodeMessage = "";
                string accountTypeMsg = "";
                if (comboFirm.SelectedIndex == -1)
                {
                    firmessage = "Firm is required!\n";
                }
                if (comboAccountType.SelectedIndex == -1)
                {
                    accountTypeMsg = "Type is required!\n";
                }
                if (txtAccountName.Text == "" || txtAccountName.Text == null)
                {
                    nameMsg = "Contact name is required!\n";
                }
                if(txtMobileNo.Text == "" || txtMobileNo.Text == null)
                {
                    cNoMsg = "Conatct No is required!\n";
                }
                if (txtAccountCode.Text == "" || txtAccountCode.Text == null)
                {
                    accountCodeMessage = "Account code is required!\n";
                }

                CheckAccountCode();
                ValidateopeningDebit();
                ValidateopeningCredit();
                ConatctNameValidaton();

                if (accountCodeMessage !="" || firmessage != "" || nameMsg != "" || cNoMsg != "" || accountTypeMsg!= "")
                {
                    MessageBox.Show(accountTypeMsg + accountCodeMessage + firmessage + nameMsg + cNoMsg);
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

        private void CheckAccountCode()
        {
            try
            {
                accountService = new AccountService();
                bool isexits = accountService.IsAccountCodeExists(txtAccountCode.Text);
                if (isexits)
                {
                    if (accountId > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Account code is aleardy Exits");
                        txtAccountCode.Focus();
                        return;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateopeningCredit()
        {
            try
            {
                decimal i;
                return decimal.TryParse(txtOpeningCredit.Text, out i);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool ValidateopeningDebit()
        {
            try
            {
                decimal i;
                return decimal.TryParse(txtOpeningDebit.Text, out i);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void ConatctNameValidaton()
        {
            try
            {
                accountService = new AccountService();
                bool isexits = accountService.IsAccountExists(txtAccountName.Text);
                if (isexits)
                {
                    if (accountId > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Account is aleardy exits", Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAccountName.Focus();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnAccountDelete_Click(object sender, EventArgs e)
        {
            try
            {
                accountService = new AccountService();
                if (accountId > 0)
                {
                    accountService.DeleteAccountById(accountId);
                    ClearAccountFieldsValues();
                    MessageBox.Show("Record deleted", Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAccountClear_Click(object sender, EventArgs e)
        {
            try
            {
                ClearAccountFieldsValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAccountClose_Click(object sender, EventArgs e)
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


        
        private void GetSearchData()
        {
            string Qry = "select a.Id,a.ContactName,a.ContactNo,b.Name from Account a join Firm b on a.FirmId = b.Id";
            string Colwidth = "";
            string test = "";
            string tblName = "Account";
            //var searchName = txtContactName.Text;
            CommonModule.ShowSearchengine(txtAccountName, Qry, 0, "ContactName", tblName, Colwidth, test, 0);
            if (CommonModule.mId > 0)
            {
                GetAccountData(CommonModule.mId);
            }
        }

        private void txtFindAccountName_Leave(object sender, EventArgs e)
        {
            try
            {
                accountService = new AccountService();
                var data = accountService.GetAccountByName(txtFindAccountName.Text);
                if (data != null)
                {
                    assignFormFieldsData(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            AccountType frmType = new AccountType();
            frmType.ShowDialog();
            BindAccountTypeCombo();
        }

        private void btnAddFirm_Click(object sender, EventArgs e)
        {
            Firm frmFirm = new Firm();
            frmFirm.ShowDialog();
            BindFirmCombo();
        }

        private void BindFirmCombo()
        {
            try
            {
                    firmService = new FirmService();
                    var firmList = firmService.GetFirmList();
                    comboFirm.ValueMember = "Id";
                    comboFirm.DisplayMember = "Name";
                    comboFirm.DataSource = firmList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindAccountTypeCombo()
        {
            try
            {
                accountService = new AccountService();
                var accountType = accountService.GetAccountType();
                comboAccountType.ValueMember = "Id";
                comboAccountType.DisplayMember = "Type";
                comboAccountType.DataSource = accountType;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   
        private bool ValidateMobile()
        {
            try
            {
                decimal i;
                return decimal.TryParse(txtMobileNo.Text, out i);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }

        private void txtMobileNo_LostFocus(object sender, EventArgs e)
        {
            if (!ValidateMobile())
            {
                MessageBox.Show("Only Number allow", Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMobileNo.Text = "";
                txtMobileNo.Focus();
            }
        }

        private void txtAccountCode_LostFocus(object sender, EventArgs e)
        {
            try
            {
                CheckAccountCode();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAccountName_LostFocus(object sender, EventArgs e)
        {
            try
            {
                ConatctNameValidaton();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtOpeningDebit_LostFocus(object sender, EventArgs e)
        {
            if (!ValidateopeningDebit())
            {
                MessageBox.Show("Only Number allow", Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOpeningDebit.Text = "0";
                txtOpeningDebit.Focus();
            }
        }

        private void txtOpeningCredit_LostFocus(object sender, EventArgs e)
        {
            if (!ValidateopeningCredit())
            {
                MessageBox.Show("Only Number allow", Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOpeningCredit.Text = "";
                txtOpeningCredit.Focus();
            }
        }

    }
}
