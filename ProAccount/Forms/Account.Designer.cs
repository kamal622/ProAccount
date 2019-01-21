namespace ProAccount.Forms
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.tblPatientBillHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPatientBillHeader = new System.Windows.Forms.Panel();
            this.lblPatientBillHeader = new System.Windows.Forms.Label();
            this.gbPatientBillSearch = new System.Windows.Forms.GroupBox();
            this.btnFindAccountByName = new System.Windows.Forms.Button();
            this.txtFindAccountName = new System.Windows.Forms.TextBox();
            this.lblAccountFindByName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddFirm = new System.Windows.Forms.Button();
            this.comboFirm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboAccountType = new System.Windows.Forms.ComboBox();
            this.btnAddType = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccountCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOpeningDebit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOpeningCredit = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlFirmBtn = new System.Windows.Forms.Panel();
            this.btnAccountDelete = new System.Windows.Forms.Button();
            this.btnAccountClear = new System.Windows.Forms.Button();
            this.btnAccountClose = new System.Windows.Forms.Button();
            this.btnAccountSave = new System.Windows.Forms.Button();
            this.tblPatientBillHeader.SuspendLayout();
            this.pnlPatientBillHeader.SuspendLayout();
            this.gbPatientBillSearch.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlFirmBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPatientBillHeader
            // 
            this.tblPatientBillHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.tblPatientBillHeader.ColumnCount = 1;
            this.tblPatientBillHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPatientBillHeader.Controls.Add(this.pnlPatientBillHeader, 0, 0);
            this.tblPatientBillHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblPatientBillHeader.Location = new System.Drawing.Point(0, 0);
            this.tblPatientBillHeader.Name = "tblPatientBillHeader";
            this.tblPatientBillHeader.RowCount = 1;
            this.tblPatientBillHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPatientBillHeader.Size = new System.Drawing.Size(615, 40);
            this.tblPatientBillHeader.TabIndex = 1;
            // 
            // pnlPatientBillHeader
            // 
            this.pnlPatientBillHeader.Controls.Add(this.lblPatientBillHeader);
            this.pnlPatientBillHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPatientBillHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlPatientBillHeader.Name = "pnlPatientBillHeader";
            this.pnlPatientBillHeader.Size = new System.Drawing.Size(609, 34);
            this.pnlPatientBillHeader.TabIndex = 0;
            // 
            // lblPatientBillHeader
            // 
            this.lblPatientBillHeader.AutoSize = true;
            this.lblPatientBillHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientBillHeader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPatientBillHeader.Location = new System.Drawing.Point(17, 9);
            this.lblPatientBillHeader.Name = "lblPatientBillHeader";
            this.lblPatientBillHeader.Size = new System.Drawing.Size(66, 17);
            this.lblPatientBillHeader.TabIndex = 0;
            this.lblPatientBillHeader.Text = "Account";
            // 
            // gbPatientBillSearch
            // 
            this.gbPatientBillSearch.BackColor = System.Drawing.Color.Transparent;
            this.gbPatientBillSearch.Controls.Add(this.btnFindAccountByName);
            this.gbPatientBillSearch.Controls.Add(this.txtFindAccountName);
            this.gbPatientBillSearch.Controls.Add(this.lblAccountFindByName);
            this.gbPatientBillSearch.Location = new System.Drawing.Point(13, 52);
            this.gbPatientBillSearch.Name = "gbPatientBillSearch";
            this.gbPatientBillSearch.Size = new System.Drawing.Size(588, 53);
            this.gbPatientBillSearch.TabIndex = 2;
            this.gbPatientBillSearch.TabStop = false;
            this.gbPatientBillSearch.Text = "Search";
            // 
            // btnFindAccountByName
            // 
            this.btnFindAccountByName.BackgroundImage = global::ProAccount.Properties.Resources.F2_Button;
            this.btnFindAccountByName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFindAccountByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindAccountByName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFindAccountByName.Location = new System.Drawing.Point(279, 21);
            this.btnFindAccountByName.Name = "btnFindAccountByName";
            this.btnFindAccountByName.Size = new System.Drawing.Size(29, 20);
            this.btnFindAccountByName.TabIndex = 2;
            this.btnFindAccountByName.Text = "F2";
            this.btnFindAccountByName.UseVisualStyleBackColor = true;
            this.btnFindAccountByName.Click += new System.EventHandler(this.btnFindAccountByName_Click);
            // 
            // txtFindAccountName
            // 
            this.txtFindAccountName.Location = new System.Drawing.Point(91, 21);
            this.txtFindAccountName.Name = "txtFindAccountName";
            this.txtFindAccountName.Size = new System.Drawing.Size(186, 20);
            this.txtFindAccountName.TabIndex = 1;
            this.txtFindAccountName.Leave += new System.EventHandler(this.txtFindAccountName_Leave);
            // 
            // lblAccountFindByName
            // 
            this.lblAccountFindByName.AutoSize = true;
            this.lblAccountFindByName.Location = new System.Drawing.Point(6, 21);
            this.lblAccountFindByName.Name = "lblAccountFindByName";
            this.lblAccountFindByName.Size = new System.Drawing.Size(35, 13);
            this.lblAccountFindByName.TabIndex = 0;
            this.lblAccountFindByName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firm";
            // 
            // btnAddFirm
            // 
            this.btnAddFirm.BackgroundImage = global::ProAccount.Properties.Resources.add;
            this.btnAddFirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddFirm.Location = new System.Drawing.Point(172, 3);
            this.btnAddFirm.Name = "btnAddFirm";
            this.btnAddFirm.Size = new System.Drawing.Size(21, 21);
            this.btnAddFirm.TabIndex = 1;
            this.btnAddFirm.UseVisualStyleBackColor = true;
            this.btnAddFirm.Click += new System.EventHandler(this.btnAddFirm_Click);
            // 
            // comboFirm
            // 
            this.comboFirm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboFirm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboFirm.FormattingEnabled = true;
            this.comboFirm.Location = new System.Drawing.Point(3, 4);
            this.comboFirm.Name = "comboFirm";
            this.comboFirm.Size = new System.Drawing.Size(163, 21);
            this.comboFirm.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(312, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // comboAccountType
            // 
            this.comboAccountType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboAccountType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboAccountType.FormattingEnabled = true;
            this.comboAccountType.Location = new System.Drawing.Point(3, 4);
            this.comboAccountType.Name = "comboAccountType";
            this.comboAccountType.Size = new System.Drawing.Size(169, 21);
            this.comboAccountType.TabIndex = 3;
            // 
            // btnAddType
            // 
            this.btnAddType.BackgroundImage = global::ProAccount.Properties.Resources.add;
            this.btnAddType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddType.Location = new System.Drawing.Point(173, 4);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(21, 21);
            this.btnAddType.TabIndex = 3;
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Account Code";
            // 
            // txtAccountCode
            // 
            this.txtAccountCode.Location = new System.Drawing.Point(91, 35);
            this.txtAccountCode.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.txtAccountCode.Name = "txtAccountCode";
            this.txtAccountCode.Size = new System.Drawing.Size(190, 20);
            this.txtAccountCode.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(395, 35);
            this.txtAccountName.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(190, 20);
            this.txtAccountName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(91, 63);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(190, 20);
            this.txtAddress.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mobile";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(395, 63);
            this.txtMobileNo.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(190, 20);
            this.txtMobileNo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(91, 91);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(190, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Opening Debit";
            // 
            // txtOpeningDebit
            // 
            this.txtOpeningDebit.Location = new System.Drawing.Point(91, 119);
            this.txtOpeningDebit.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.txtOpeningDebit.Name = "txtOpeningDebit";
            this.txtOpeningDebit.Size = new System.Drawing.Size(190, 20);
            this.txtOpeningDebit.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 122);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Opening Credit";
            // 
            // txtOpeningCredit
            // 
            this.txtOpeningCredit.Location = new System.Drawing.Point(395, 119);
            this.txtOpeningCredit.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.txtOpeningCredit.Name = "txtOpeningCredit";
            this.txtOpeningCredit.Size = new System.Drawing.Size(190, 20);
            this.txtOpeningCredit.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.61141F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.16327F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAccountCode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAccountName, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtAddress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtMobileNo, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtOpeningDebit, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtOpeningCredit, 3, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 120);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(588, 145);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboFirm);
            this.panel1.Controls.Add(this.btnAddFirm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(88, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 28);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboAccountType);
            this.panel2.Controls.Add(this.btnAddType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(392, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 28);
            this.panel2.TabIndex = 2;
            // 
            // pnlFirmBtn
            // 
            this.pnlFirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.pnlFirmBtn.Controls.Add(this.btnAccountDelete);
            this.pnlFirmBtn.Controls.Add(this.btnAccountClear);
            this.pnlFirmBtn.Controls.Add(this.btnAccountClose);
            this.pnlFirmBtn.Controls.Add(this.btnAccountSave);
            this.pnlFirmBtn.Location = new System.Drawing.Point(370, 271);
            this.pnlFirmBtn.Name = "pnlFirmBtn";
            this.pnlFirmBtn.Size = new System.Drawing.Size(231, 37);
            this.pnlFirmBtn.TabIndex = 13;
            // 
            // btnAccountDelete
            // 
            this.btnAccountDelete.BackgroundImage = global::ProAccount.Properties.Resources.Button_Bkg;
            this.btnAccountDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountDelete.ForeColor = System.Drawing.Color.White;
            this.btnAccountDelete.Location = new System.Drawing.Point(59, 4);
            this.btnAccountDelete.Name = "btnAccountDelete";
            this.btnAccountDelete.Size = new System.Drawing.Size(56, 30);
            this.btnAccountDelete.TabIndex = 12;
            this.btnAccountDelete.Text = "&Delete";
            this.btnAccountDelete.UseVisualStyleBackColor = true;
            this.btnAccountDelete.Click += new System.EventHandler(this.btnAccountDelete_Click);
            // 
            // btnAccountClear
            // 
            this.btnAccountClear.BackgroundImage = global::ProAccount.Properties.Resources.Button_Bkg;
            this.btnAccountClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountClear.ForeColor = System.Drawing.Color.White;
            this.btnAccountClear.Location = new System.Drawing.Point(115, 4);
            this.btnAccountClear.Name = "btnAccountClear";
            this.btnAccountClear.Size = new System.Drawing.Size(56, 30);
            this.btnAccountClear.TabIndex = 13;
            this.btnAccountClear.Text = "C&lear";
            this.btnAccountClear.UseVisualStyleBackColor = true;
            this.btnAccountClear.Click += new System.EventHandler(this.btnAccountClear_Click);
            // 
            // btnAccountClose
            // 
            this.btnAccountClose.BackgroundImage = global::ProAccount.Properties.Resources.Button_Bkg;
            this.btnAccountClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountClose.ForeColor = System.Drawing.Color.White;
            this.btnAccountClose.Location = new System.Drawing.Point(172, 4);
            this.btnAccountClose.Name = "btnAccountClose";
            this.btnAccountClose.Size = new System.Drawing.Size(56, 30);
            this.btnAccountClose.TabIndex = 14;
            this.btnAccountClose.Text = "&Close";
            this.btnAccountClose.UseVisualStyleBackColor = true;
            this.btnAccountClose.Click += new System.EventHandler(this.btnAccountClose_Click);
            // 
            // btnAccountSave
            // 
            this.btnAccountSave.BackgroundImage = global::ProAccount.Properties.Resources.Button_Bkg;
            this.btnAccountSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountSave.ForeColor = System.Drawing.Color.White;
            this.btnAccountSave.Location = new System.Drawing.Point(3, 4);
            this.btnAccountSave.Name = "btnAccountSave";
            this.btnAccountSave.Size = new System.Drawing.Size(56, 30);
            this.btnAccountSave.TabIndex = 11;
            this.btnAccountSave.Text = "&Save";
            this.btnAccountSave.UseVisualStyleBackColor = true;
            this.btnAccountSave.Click += new System.EventHandler(this.btnAccountSave_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProAccount.Properties.Resources.LeftGradiant;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(615, 318);
            this.Controls.Add(this.pnlFirmBtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gbPatientBillSearch);
            this.Controls.Add(this.tblPatientBillHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.tblPatientBillHeader.ResumeLayout(false);
            this.pnlPatientBillHeader.ResumeLayout(false);
            this.pnlPatientBillHeader.PerformLayout();
            this.gbPatientBillSearch.ResumeLayout(false);
            this.gbPatientBillSearch.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlFirmBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel tblPatientBillHeader;
        internal System.Windows.Forms.Panel pnlPatientBillHeader;
        internal System.Windows.Forms.Label lblPatientBillHeader;
        internal System.Windows.Forms.GroupBox gbPatientBillSearch;
        internal System.Windows.Forms.Button btnFindAccountByName;
        internal System.Windows.Forms.TextBox txtFindAccountName;
        internal System.Windows.Forms.Label lblAccountFindByName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboFirm;
        private System.Windows.Forms.Button btnAddFirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboAccountType;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccountCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOpeningDebit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOpeningCredit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Panel pnlFirmBtn;
        internal System.Windows.Forms.Button btnAccountDelete;
        internal System.Windows.Forms.Button btnAccountClear;
        internal System.Windows.Forms.Button btnAccountClose;
        internal System.Windows.Forms.Button btnAccountSave;
    }
}