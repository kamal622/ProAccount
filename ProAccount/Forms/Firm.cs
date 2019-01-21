using ProAccount.Core;
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
    public partial class Firm : Form
    {
        public Firm()
        {
            InitializeComponent();
            txtFirmName.LostFocus += new EventHandler(txtFirmName_LostFocus);
        }

        FirmService firmService = null;
        int firmId = 0;

        private void Firm_Load(object sender, EventArgs e)
        {
            
            try
            {
                firmService = new FirmService();
                firmService.GetAllFirm();
                var firmName = txtFirmName.Text;
                btnFirmDelete.Enabled = false;
                firmId = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                firmService = null;
            }
        }

        private void btnFirmSave_Click(object sender, EventArgs e)
        {
            FirmService firmService = null;
            try
            {
                if (txtFirmName.Text == "" || txtFirmName.Text == null)
                {
                    MessageBox.Show("Name is required!");
                    return;
                }
                else
                {
                    if (!FirmNameValidation())
                    {
                        firmService = new FirmService();
                        var firmName = txtFirmName.Text;
                        firmService.SaveFirm(firmId, firmName);
                        ClearFirmFieldsValues();
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                firmService = null;
            }
        }

        private void btnFirmDelete_Click(object sender, EventArgs e)
        {
            try
            {
                firmService = new FirmService();
                if (firmId > 0)
                {
                    firmService.DeleteFirmById(firmId);
                    ClearFirmFieldsValues();
                    MessageBox.Show("Record deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFirmClear_Click(object sender, EventArgs e)
        {
            try
            {
                ClearFirmFieldsValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFirmClose_Click(object sender, EventArgs e)
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

        private void ClearFirmFieldsValues()
        {
            firmId = 0;
            txtFindFirmName.Text = "";
            txtFirmName.Text = "";
        }

        private void btnFindFirmByName_Click(object sender, EventArgs e)
        {
            string Qry = "select s.Id,s.Name from Firm s";
            string Colwidth = "";
            string test = "";
            var searchName = txtFindFirmName.Text;
            string tblName = "Firm";
            CommonModule.ShowSearchengine(searchName, Qry, 0, "Name",tblName, Colwidth,test,  0);
            if (CommonModule.mId > 0)
            {
                GetFirmById(CommonModule.mId);
            }
        }

        private void GetFirmById(int Id)
        {
           try
            {
                firmService = new FirmService();
                var Firmdata = firmService.GetFirmById(Id);
                assignDatatoFields(Firmdata);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void assignDatatoFields(Data.Models.Firm Firmdata)
        {
            try
            {
                firmId = Firmdata.Id;
                txtFindFirmName.Text = Firmdata.Name;
                txtFirmName.Text = Firmdata.Name;
                btnFirmDelete.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool FirmNameValidation()
        {
            try
            {
                firmService = new FirmService();
                var Name = txtFirmName.Text;
                var status = firmService.FirmIsExists(Name);
                if (status)
                {
                    MessageBox.Show("Firm Is already Exists", Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return status;
                }
                else
                    return status;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void txtFindFirmName_Leave(object sender, EventArgs e)
        {
            try
            {
                firmService = new FirmService();
                if (txtFindFirmName.Text != "")
                {
                    Data.Models.Firm data = firmService.GetFirmByName(txtFindFirmName.Text);
                    if (data != null)
                    {
                        assignDatatoFields(data);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFirmName_LostFocus(object sender, EventArgs e)
        {
            try
            {
                FirmNameValidation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
