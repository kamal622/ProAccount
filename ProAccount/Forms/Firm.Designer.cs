namespace ProAccount.Forms
{
    partial class Firm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Firm));
            this.tblFirmHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCityHeader = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.gbPatientBillSearch = new System.Windows.Forms.GroupBox();
            this.btnFindFirmByName = new System.Windows.Forms.Button();
            this.txtFindFirmName = new System.Windows.Forms.TextBox();
            this.lblFirmFindByName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirmName = new System.Windows.Forms.TextBox();
            this.pnlFirmBtn = new System.Windows.Forms.Panel();
            this.btnFirmDelete = new System.Windows.Forms.Button();
            this.btnFirmClear = new System.Windows.Forms.Button();
            this.btnFirmClose = new System.Windows.Forms.Button();
            this.btnFirmSave = new System.Windows.Forms.Button();
            this.tblFirmHeader.SuspendLayout();
            this.pnlCityHeader.SuspendLayout();
            this.gbPatientBillSearch.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlFirmBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblFirmHeader
            // 
            this.tblFirmHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.tblFirmHeader.ColumnCount = 1;
            this.tblFirmHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFirmHeader.Controls.Add(this.pnlCityHeader, 0, 0);
            this.tblFirmHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblFirmHeader.Location = new System.Drawing.Point(0, 0);
            this.tblFirmHeader.Name = "tblFirmHeader";
            this.tblFirmHeader.RowCount = 1;
            this.tblFirmHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFirmHeader.Size = new System.Drawing.Size(389, 40);
            this.tblFirmHeader.TabIndex = 4;
            // 
            // pnlCityHeader
            // 
            this.pnlCityHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.pnlCityHeader.Controls.Add(this.Label2);
            this.pnlCityHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCityHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCityHeader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlCityHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlCityHeader.Name = "pnlCityHeader";
            this.pnlCityHeader.Size = new System.Drawing.Size(383, 34);
            this.pnlCityHeader.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 6);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(39, 17);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Firm";
            // 
            // gbPatientBillSearch
            // 
            this.gbPatientBillSearch.BackColor = System.Drawing.Color.Transparent;
            this.gbPatientBillSearch.Controls.Add(this.btnFindFirmByName);
            this.gbPatientBillSearch.Controls.Add(this.txtFindFirmName);
            this.gbPatientBillSearch.Controls.Add(this.lblFirmFindByName);
            this.gbPatientBillSearch.Location = new System.Drawing.Point(15, 54);
            this.gbPatientBillSearch.Name = "gbPatientBillSearch";
            this.gbPatientBillSearch.Size = new System.Drawing.Size(359, 53);
            this.gbPatientBillSearch.TabIndex = 5;
            this.gbPatientBillSearch.TabStop = false;
            this.gbPatientBillSearch.Text = "Search";
            // 
            // btnFindFirmByName
            // 
            this.btnFindFirmByName.BackgroundImage = global::ProAccount.Properties.Resources.F2_Button;
            this.btnFindFirmByName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFindFirmByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindFirmByName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFindFirmByName.Location = new System.Drawing.Point(317, 21);
            this.btnFindFirmByName.Name = "btnFindFirmByName";
            this.btnFindFirmByName.Size = new System.Drawing.Size(32, 20);
            this.btnFindFirmByName.TabIndex = 2;
            this.btnFindFirmByName.Text = "F2";
            this.btnFindFirmByName.UseVisualStyleBackColor = true;
            this.btnFindFirmByName.Click += new System.EventHandler(this.btnFindFirmByName_Click);
            // 
            // txtFindFirmName
            // 
            this.txtFindFirmName.Location = new System.Drawing.Point(87, 21);
            this.txtFindFirmName.Name = "txtFindFirmName";
            this.txtFindFirmName.Size = new System.Drawing.Size(224, 20);
            this.txtFindFirmName.TabIndex = 1;
            this.txtFindFirmName.Leave += new System.EventHandler(this.txtFindFirmName_Leave);
            // 
            // lblFirmFindByName
            // 
            this.lblFirmFindByName.AutoSize = true;
            this.lblFirmFindByName.Location = new System.Drawing.Point(6, 21);
            this.lblFirmFindByName.Name = "lblFirmFindByName";
            this.lblFirmFindByName.Size = new System.Drawing.Size(35, 13);
            this.lblFirmFindByName.TabIndex = 0;
            this.lblFirmFindByName.Text = "Name";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.92264F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.07736F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFirmName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 115);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(359, 36);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtFirmName
            // 
            this.txtFirmName.Location = new System.Drawing.Point(87, 8);
            this.txtFirmName.Margin = new System.Windows.Forms.Padding(5, 8, 3, 3);
            this.txtFirmName.Name = "txtFirmName";
            this.txtFirmName.Size = new System.Drawing.Size(265, 20);
            this.txtFirmName.TabIndex = 1;
            // 
            // pnlFirmBtn
            // 
            this.pnlFirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.pnlFirmBtn.Controls.Add(this.btnFirmDelete);
            this.pnlFirmBtn.Controls.Add(this.btnFirmClear);
            this.pnlFirmBtn.Controls.Add(this.btnFirmClose);
            this.pnlFirmBtn.Controls.Add(this.btnFirmSave);
            this.pnlFirmBtn.Location = new System.Drawing.Point(143, 159);
            this.pnlFirmBtn.Name = "pnlFirmBtn";
            this.pnlFirmBtn.Size = new System.Drawing.Size(231, 37);
            this.pnlFirmBtn.TabIndex = 7;
            // 
            // btnFirmDelete
            // 
            this.btnFirmDelete.BackgroundImage = global::ProAccount.Properties.Resources.Button_Bkg;
            this.btnFirmDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirmDelete.ForeColor = System.Drawing.Color.White;
            this.btnFirmDelete.Location = new System.Drawing.Point(59, 4);
            this.btnFirmDelete.Name = "btnFirmDelete";
            this.btnFirmDelete.Size = new System.Drawing.Size(56, 30);
            this.btnFirmDelete.TabIndex = 2;
            this.btnFirmDelete.Text = "&Delete";
            this.btnFirmDelete.UseVisualStyleBackColor = true;
            this.btnFirmDelete.Click += new System.EventHandler(this.btnFirmDelete_Click);
            // 
            // btnFirmClear
            // 
            this.btnFirmClear.BackgroundImage = global::ProAccount.Properties.Resources.Button_Bkg;
            this.btnFirmClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirmClear.ForeColor = System.Drawing.Color.White;
            this.btnFirmClear.Location = new System.Drawing.Point(115, 4);
            this.btnFirmClear.Name = "btnFirmClear";
            this.btnFirmClear.Size = new System.Drawing.Size(56, 30);
            this.btnFirmClear.TabIndex = 3;
            this.btnFirmClear.Text = "C&lear";
            this.btnFirmClear.UseVisualStyleBackColor = true;
            this.btnFirmClear.Click += new System.EventHandler(this.btnFirmClear_Click);
            // 
            // btnFirmClose
            // 
            this.btnFirmClose.BackgroundImage = global::ProAccount.Properties.Resources.Button_Bkg;
            this.btnFirmClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirmClose.ForeColor = System.Drawing.Color.White;
            this.btnFirmClose.Location = new System.Drawing.Point(172, 4);
            this.btnFirmClose.Name = "btnFirmClose";
            this.btnFirmClose.Size = new System.Drawing.Size(56, 30);
            this.btnFirmClose.TabIndex = 4;
            this.btnFirmClose.Text = "&Close";
            this.btnFirmClose.UseVisualStyleBackColor = true;
            this.btnFirmClose.Click += new System.EventHandler(this.btnFirmClose_Click);
            // 
            // btnFirmSave
            // 
            this.btnFirmSave.BackgroundImage = global::ProAccount.Properties.Resources.Button_Bkg;
            this.btnFirmSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirmSave.ForeColor = System.Drawing.Color.White;
            this.btnFirmSave.Location = new System.Drawing.Point(3, 4);
            this.btnFirmSave.Name = "btnFirmSave";
            this.btnFirmSave.Size = new System.Drawing.Size(56, 30);
            this.btnFirmSave.TabIndex = 0;
            this.btnFirmSave.Text = "&Save";
            this.btnFirmSave.UseVisualStyleBackColor = true;
            this.btnFirmSave.Click += new System.EventHandler(this.btnFirmSave_Click);
            // 
            // Firm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProAccount.Properties.Resources.LeftGradiant;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(389, 204);
            this.Controls.Add(this.pnlFirmBtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gbPatientBillSearch);
            this.Controls.Add(this.tblFirmHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Firm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firm";
            this.Load += new System.EventHandler(this.Firm_Load);
            this.tblFirmHeader.ResumeLayout(false);
            this.pnlCityHeader.ResumeLayout(false);
            this.pnlCityHeader.PerformLayout();
            this.gbPatientBillSearch.ResumeLayout(false);
            this.gbPatientBillSearch.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlFirmBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel tblFirmHeader;
        internal System.Windows.Forms.Panel pnlCityHeader;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox gbPatientBillSearch;
        internal System.Windows.Forms.Button btnFindFirmByName;
        internal System.Windows.Forms.TextBox txtFindFirmName;
        internal System.Windows.Forms.Label lblFirmFindByName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirmName;
        internal System.Windows.Forms.Panel pnlFirmBtn;
        internal System.Windows.Forms.Button btnFirmDelete;
        internal System.Windows.Forms.Button btnFirmClear;
        internal System.Windows.Forms.Button btnFirmClose;
        internal System.Windows.Forms.Button btnFirmSave;
    }
}