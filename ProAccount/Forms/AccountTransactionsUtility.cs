using Microsoft.Reporting.WinForms;
using ProAccount.Core;
using ProAccount.Service.Account;
using ProAccount.Service.AccountTransaction;
using ProAccount.Service.Firm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ProAccount.Forms
{
    public partial class AccountTransactionsUtility : Form
    {
        public AccountTransactionsUtility()
        {
            InitializeComponent();
        }

        FirmService firmService = null;
        AccountService accountService = null;
        AccountTransactionService accountTransacionService = null;

        private void AccountTransactionsUtility_Load(object sender, EventArgs e)
        {
            try
            {
                firmService = new FirmService();
                var firmList = firmService.GetFirmList();
                comboUFirm.ValueMember = "Id";
                comboUFirm.DisplayMember = "Name";
                comboUFirm.SelectedIndex = -1;
                //comboUFirm.Items.Add("All");
                comboUFirm.DataSource = firmList;
                dtFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dtToDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
                //btnTUtilityDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,Comman.Product_Name,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnTUtilityDownload_Click(object sender, EventArgs e)
        {
            try
            {
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;

                string filenameExtension;
                int FirmId = Convert.ToInt32(comboUFirm.SelectedValue);
                int AccountId = Convert.ToInt32(comboUAccount.SelectedValue);
                DateTime fromDate = dtFromDate.Value;
                DateTime toDate = dtToDate.Value;
                accountTransacionService = new AccountTransactionService();
                List<Service.Model.AccountTransactionReportModel> dataSource = accountTransacionService.GetTransactionReportData(FirmId, AccountId, toDate, fromDate);
                var accountData = accountTransacionService.GetOpeningBalance(FirmId,AccountId);
                if (dataSource.Count > 0)
                {
                    using (SaveFileDialog dlgSaveAs = new SaveFileDialog())
                    {
                        dlgSaveAs.InitialDirectory = @"C:\";
                        dlgSaveAs.Title = "Save PDF Files";
                        dlgSaveAs.CheckFileExists = false;
                        dlgSaveAs.CheckPathExists = false;
                        dlgSaveAs.DefaultExt = "pdf";
                        dlgSaveAs.Filter = "Pdf files (*.pdf)|*.pdf";
                        dlgSaveAs.FilterIndex = 2;
                        dlgSaveAs.RestoreDirectory = true;
                        if (dlgSaveAs.ShowDialog() == DialogResult.OK)
                        {

                           
                            using (FileStream stream = new FileStream(dlgSaveAs.FileName, FileMode.OpenOrCreate))
                            {
                                using (ReportViewer ReportViewer1 = new ReportViewer())
                                {
                                    
                                    ReportViewer1.ProcessingMode = ProcessingMode.Local;
                                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("AccountTransactionDataSet", dataSource));
                                    ReportViewer1.LocalReport.ReportPath = Path.GetFullPath(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoryPath"], "Reports\\AccountTransactions.rdlc"));
                                    ReportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("FromDate", fromDate.ToString()));
                                    ReportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ToDate", toDate.ToString()));
                                    ReportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("OpeningDebit", accountData.OpeningDebit.ToString()));
                                    ReportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("OpeningCredit", accountData.OpeningCredit.ToString()));
                                    byte[] bytes = ReportViewer1.LocalReport.Render(
                                    "PDF", null, out mimeType, out encoding, out filenameExtension,
                                    out streamids, out warnings);

                                    stream.Write(bytes, 0, bytes.Length);
                                }
                            }

                            System.Diagnostics.Process.Start(dlgSaveAs.FileName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTUtilityDelete_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTUtilityClear_Click(object sender, EventArgs e)
        {
            try
            {
                gridTransactionUtilty.DataSource = null;
                dtFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dtToDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTUtilityClose_Click(object sender, EventArgs e)
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

        private void comboUFirm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                accountService = new AccountService();
                var firId = comboUFirm.SelectedValue;
                int firmId = Convert.ToInt32(firId);
                var accountList = accountService.GetAccountByFirm(firmId);
                if (accountList.Length > 0)
                {
                    comboUAccount.DataSource = accountList;
                }
                else
                {
                    comboUAccount.DataSource = null;
                }
                comboUAccount.ValueMember = "Id";
                comboUAccount.DisplayMember = "ContactName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSearchTransactions_Click(object sender, EventArgs e)
        {
            try
            {
                GetAllTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridTransactionUtilty_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int transactionId = Convert.ToInt32(gridTransactionUtilty.CurrentRow.Cells["Id"].Value);
                AccountTransaction frmTransaction = new AccountTransaction();
                frmTransaction.GetUtiltyTransactionById(transactionId);
                //frmTransaction.btnATransactionDelete.Enabled = true;
                frmTransaction.ShowDialog();
                GetAllTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetAllTransactions()
        {
            int FirmId = Convert.ToInt32(comboUFirm.SelectedValue);
            int AccountId = Convert.ToInt32(comboUAccount.SelectedValue);
            DateTime fromDate = dtFromDate.Value;
            DateTime toDate = dtToDate.Value;
            accountTransacionService = new AccountTransactionService();
            var utilityData = accountTransacionService.GetAllTransactionData(FirmId, AccountId, toDate, fromDate);
            gridTransactionUtilty.DataSource = utilityData;
            gridTransactionUtilty.ReadOnly = true;
            gridTransactionUtilty.Columns["TransactionDate"].DefaultCellStyle.Format = "dd-MM-yyyy";
            gridTransactionUtilty.Columns["Id"].Visible = false;
        }

       
    }
}
