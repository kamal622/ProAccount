using ProAccount.Core;
using ProAccount.Service.Account;
using ProAccount.Service.AccountTransaction;
using ProAccount.Service.Firm;
using ProAccount.Service.Model;
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
    public partial class AccountTransaction : Form
    {
        int transactionId = 0;
        bool IsEditable = false;
        bool IsPostBack = false;

        FirmService firmService = null;
        AccountService accountService = null;
        AccountTransactionService accountTransactionService = null;

        private string chequeNo = "";
        //private string ifscCode = "";
        private string bankName = "";
        private DateTime chequeDate = DateTime.Now;

        public AccountTransaction()
        {
            InitializeComponent();
            txtAmount.LostFocus += new EventHandler(txtMobileNo_LostFocus);
        }
        
        private void BindFirmCombo()
        {
            try
            {
                if (IsPostBack)
                {

                }
                else
                {
                    firmService = new FirmService();
                    var firmList = firmService.GetFirmList();
                    comboFirm.ValueMember = "Id";
                    comboFirm.DisplayMember = "Name";
                    comboFirm.DataSource = firmList;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AccountTransaction_Load(object sender, EventArgs e)
        {

        }

        private void btnAddFirm_Click(object sender, EventArgs e)
        {
            try
            {
                Firm frmfirm = new Firm();
                frmfirm.ShowDialog();
                BindFirmCombo();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            try
            {
                Account frmAccount = new Account();
                frmAccount.ShowDialog();
                BindAccountCombo();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnATransactionSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateTransactionFields())
                {
                    accountTransactionService = new AccountTransactionService();
                    var firId = comboFirm.SelectedValue;
                    int firmId = Convert.ToInt32(firId);
                    var accId = comboAccount.SelectedValue;
                    int accountId = Convert.ToInt32(accId);
                    string paymetMode = "";
                    string transactionType = "";
                    if (rbtnDebit.Checked)
                    {
                        transactionType = "Dr";
                    }
                    else
                    {
                        transactionType = "Cr";
                    }

                    if (rbtnCash.Checked)
                    {
                        paymetMode = rbtnCash.Text;
                    }
                    else
                    {
                        paymetMode = rbtnCheque.Text;
                        if (bankName == "" || chequeNo == "")
                        {
                            MessageBox.Show("Bank details is required", Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    Data.Models.AccountTransaction data = new Data.Models.AccountTransaction();
                    data.Id = transactionId;
                    data.TransactionDate = dtTransactionDate.Value;
                    data.FirmId = firmId;
                    data.AccountId = accountId;
                    data.Amount = Convert.ToDecimal(txtAmount.Text);
                    data.TransactionsType = transactionType;
                    data.PaymentType = paymetMode;
                    data.Remarks =txtTransactionRemarks.Text;

                    Data.Models.ChequeDetail chequeData = new Data.Models.ChequeDetail();
                    chequeData.BankName = bankName;
                    //chequeData.IFSCCode = ifscCode;
                    chequeData.ChequeNo = chequeNo;
                    chequeData.ChequeDate = chequeDate;
                    accountTransactionService.SaveTransaction(data, chequeData);
                    ClearTransactionFieldsData();
                    GetGirdViewData();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnATransactionDelete_Click(object sender, EventArgs e)
        {
            try
            {
                accountTransactionService = new AccountTransactionService();
                if (transactionId > 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure Delete ??", "Ok", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result.Equals(DialogResult.OK))
                    {
                        accountTransactionService.DeleteTransactionById(transactionId);
                        GetGirdViewData();
                        ClearTransactionFieldsData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnATransactionClear_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnATransactionClose_Click(object sender, EventArgs e)
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
        private void ClearTransactionFieldsData()
        {
            try
            {
                txtAmount.Text = "";
                txtTransactionRemarks.Text = "";
                rbtnCash.Checked = true;
                rbtnCheque.Checked = false;
                rbtnCredit.Checked = true;
                rbtnDebit.Checked = false;
                transactionId = 0;
                IsPostBack = false;
                dtTransactionDate.Value = DateTime.Now.Date;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateTransactionFields()
        {
            try
            {
                string firmMessage = "";
                string accountMessage = "";
                string amountMessage = "";
                if(comboFirm.SelectedIndex == -1)
                {
                    firmMessage = "Firm is required!";
                }
                if(comboAccount.SelectedIndex == -1)
                {
                    accountMessage = "Account is required!";
                }
                if (txtAmount.Text == "" || txtAmount.Text == null)
                {
                    amountMessage = "Amount is required!";
                }

                if(firmMessage != "" || accountMessage != "" || amountMessage != "")
                {
                    MessageBox.Show(firmMessage + accountMessage + amountMessage);
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
        
        private void comboFirm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BindAccountCombo();
                GetGirdViewData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindAccountCombo()
        {
            accountService = new AccountService();
            var firId = comboFirm.SelectedValue;
            int firmId = Convert.ToInt32(firId);
            comboAccount.ValueMember = "Id";
            comboAccount.DisplayMember = "ContactName";
            var accountList = accountService.GetAccountByFirm(firmId);
            if (accountList == null)
            {
                comboAccount.SelectedItem = null;
                //return;

            }
            else
            {
                var finalData = accountList.Select(s => new { s.Id, s.ContactName }).ToList();
                comboAccount.DataSource = finalData;
            }
        }

        private void GetGirdViewData()
        {
            try
            {
                accountTransactionService = new AccountTransactionService();
                int firmId = Convert.ToInt32(comboFirm.SelectedValue);
                int accountId = Convert.ToInt32(comboAccount.SelectedValue);
                DateTime transactionDate = dtTransactionDate.Value;
                var data = accountTransactionService.GetTodayTransactionData(firmId, accountId, transactionDate);
                gridAccountTransactions.DataSource = data;
                gridAccountTransactions.Columns["TransactionDate"].DefaultCellStyle.Format = "dd-MM-yyyy";
                gridAccountTransactions.Columns["Id"].Visible = false;
                gridAccountTransactions.Columns["Remarks"].Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtnCheque_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (IsEditable)
                {
                    return;
                }
                else
                {
                    if (rbtnCheque.Checked)
                    {
                        ChequeForm frmcheque = new ChequeForm();
                        frmcheque.ShowDialog();
                        bankName = frmcheque.bankName;
                       // ifscCode = frmcheque.ifscCode;
                        chequeNo = frmcheque.chequeNo;
                        chequeDate = frmcheque.chequeDate;
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetUtiltyTransactionById(int Id)
        {
            try
            {
                accountTransactionService = new AccountTransactionService();
                var transactionData = accountTransactionService.GetTransactionById(Id);
                AssignFormFieldsValues(transactionData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AssignFormFieldsValues(Data.Models.AccountTransaction transactionData)
        {
            try
            {
                if (comboFirm.DataSource == null) {
                    BindFirmCombo();
                }

                transactionId = transactionData.Id;
                comboFirm.SelectedValue = transactionData.FirmId;
                comboAccount.SelectedValue = transactionData.AccountId;
                if (transactionData.TransactionsType == "Cr")
                {
                    rbtnCredit.Checked = true;
                }
                else
                {
                    rbtnDebit.Checked = true;
                }
                if (transactionData.PaymentType == "Cash")
                {
                    rbtnCash.Checked = true;
                }
                else
                {
                    IsEditable = true;
                    ChequeForm frmCheuqe = new ChequeForm();
                    frmCheuqe.Close();
                    rbtnCheque.Checked = true;
                    GetBankDetailsByTransactionById(transactionId);
                }
                IsPostBack = true;
                txtTransactionRemarks.Text = transactionData.Remarks;
                dtTransactionDate.Value = transactionData.TransactionDate;
                txtAmount.Text = transactionData.Amount.ToString();
                gridAccountTransactions.DataSource = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int test;
                var accountId = comboAccount.SelectedValue;
                bool result = Int32.TryParse(accountId.ToString(),out test);
                if (result)
                {
                    int AccountId = Convert.ToInt32(accountId);
                    if (AccountId > 0)
                    {
                        GetGirdViewData();
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetBankDetailsByTransactionById(int TransactionId)
        {
            try
            {
                accountTransactionService = new AccountTransactionService();
                var chequeData = accountTransactionService.GetChequeDetailsById(TransactionId);
                if (chequeData != null)
                {
                    chequeNo = chequeData.ChequeNo;
                    chequeDate = chequeData.ChequeDate;
                    bankName = chequeData.BankName;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateAmount()
        {
            decimal i;
            return decimal.TryParse(txtAmount.Text, out i);
        }

        private void txtMobileNo_LostFocus(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateAmount())
                {
                    MessageBox.Show("Only Number allow", Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAmount.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
