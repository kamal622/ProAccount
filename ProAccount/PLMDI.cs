using ProAccount.Core;
using ProAccount.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProAccount
{
    public partial class PLMDIForm : Form
    {
        public PLMDIForm()
        {
            InitializeComponent();
        }

        Firm frmFirm = null;
        Account frmAccount = null;
        AccountTransaction frmTransaction = null;
        AccountTransactionsUtility frmUtility = null;

        private void PLMDIForm_Load(object sender, EventArgs e)
        {
            try
            {
                IsMdiContainer = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newFirmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmFirm == null || frmFirm.IsDisposed)
                {
                    frmFirm = new Firm();
                    frmFirm.Show();
                    frmFirm.MdiParent = this;
                }
                else
                {
                    frmFirm.Activate();
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmAccount == null || frmAccount.IsDisposed)
                {
                    frmAccount = new Account();
                    frmAccount.Show();
                    frmAccount.MdiParent = this;
                }
                else
                {
                    frmAccount.Activate();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure exit ??", Comman.Product_Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result.Equals(DialogResult.OK))
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void accountTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmTransaction == null || frmTransaction.IsDisposed)
                {
                    frmTransaction = new AccountTransaction();
                    frmTransaction.Show();
                    frmTransaction.MdiParent = this;
                }
                else
                {
                    frmTransaction.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void transactionUtilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmUtility == null || frmUtility.IsDisposed)
                {
                    frmUtility = new AccountTransactionsUtility();
                    frmUtility.Show();
                    frmUtility.MdiParent = this;
                }
                else
                {
                    frmUtility.Activate();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        
    }
}
