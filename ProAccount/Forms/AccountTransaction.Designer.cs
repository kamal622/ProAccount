namespace ProAccount.Forms
{
    partial class AccountTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountTransaction));
            this.tblPatientBillHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPatientBillHeader = new System.Windows.Forms.Panel();
            this.lblPatientBillHeader = new System.Windows.Forms.Label();
            this.tblAccountTransactions = new System.Windows.Forms.TableLayoutPanel();
            this.lblFirm = new System.Windows.Forms.Label();
            this.pnlFirm = new System.Windows.Forms.Panel();
            this.btnAddFirm = new System.Windows.Forms.Button();
            this.comboFirm = new System.Windows.Forms.ComboBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.comboAccount = new System.Windows.Forms.ComboBox();
            this.lblTransactionDate = new System.Windows.Forms.Label();
            this.dtTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.pnlPaymentMode = new System.Windows.Forms.Panel();
            this.rbtnCredit = new System.Windows.Forms.RadioButton();
            this.rbtnDebit = new System.Windows.Forms.RadioButton();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblPaymentMode = new System.Windows.Forms.Label();
            this.lblPaymentsMode = new System.Windows.Forms.Panel();
            this.rbtnCheque = new System.Windows.Forms.RadioButton();
            this.rbtnCash = new System.Windows.Forms.RadioButton();
            this.tblRemarks = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRemarks = new System.Windows.Forms.Panel();
            this.txtTransactionRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.gridAccountTransactions = new System.Windows.Forms.DataGridView();
            this.pnlFirmBtn = new System.Windows.Forms.Panel();
            this.btnATransactionDelete = new System.Windows.Forms.Button();
            this.btnATransactionClear = new System.Windows.Forms.Button();
            this.btnATransactionClose = new System.Windows.Forms.Button();
            this.btnATransactionSave = new System.Windows.Forms.Button();
            this.tblPatientBillHeader.SuspendLayout();
            this.pnlPatientBillHeader.SuspendLayout();
            this.tblAccountTransactions.SuspendLayout();
            this.pnlFirm.SuspendLayout();
            this.pnlAccount.SuspendLayout();
            this.pnlPaymentMode.SuspendLayout();
            this.lblPaymentsMode.SuspendLayout();
            this.tblRemarks.SuspendLayout();
            this.pnlRemarks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAccountTransactions)).BeginInit();
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
            this.tblPatientBillHeader.Size = new System.Drawing.Size(668, 40);
            this.tblPatientBillHeader.TabIndex = 2;
            // 
            // pnlPatientBillHeader
            // 
            this.pnlPatientBillHeader.Controls.Add(this.lblPatientBillHeader);
            this.pnlPatientBillHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPatientBillHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlPatientBillHeader.Name = "pnlPatientBillHeader";
            this.pnlPatientBillHeader.Size = new System.Drawing.Size(662, 34);
            this.pnlPatientBillHeader.TabIndex = 0;
            // 
            // lblPatientBillHeader
            // 
            this.lblPatientBillHeader.AutoSize = true;
            this.lblPatientBillHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientBillHeader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPatientBillHeader.Location = new System.Drawing.Point(9, 6);
            this.lblPatientBillHeader.Name = "lblPatientBillHeader";
            this.lblPatientBillHeader.Size = new System.Drawing.Size(165, 17);
            this.lblPatientBillHeader.TabIndex = 0;
            this.lblPatientBillHeader.Text = "Account Transactions";
            // 
            // tblAccountTransactions
            // 
            this.tblAccountTransactions.BackColor = System.Drawing.Color.Transparent;
            this.tblAccountTransactions.ColumnCount = 4;
            this.tblAccountTransactions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.5521F));
            this.tblAccountTransactions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.19284F));
            this.tblAccountTransactions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.86314F));
            this.tblAccountTransactions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.23639F));
            this.tblAccountTransactions.Controls.Add(this.lblFirm, 0, 0);
            this.tblAccountTransactions.Controls.Add(this.pnlFirm, 1, 0);
            this.tblAccountTransactions.Controls.Add(this.lblAccount, 2, 0);
            this.tblAccountTransactions.Controls.Add(this.pnlAccount, 3, 0);
            this.tblAccountTransactions.Controls.Add(this.lblTransactionDate, 0, 1);
            this.tblAccountTransactions.Controls.Add(this.dtTransactionDate, 1, 1);
            this.tblAccountTransactions.Controls.Add(this.pnlPaymentMode, 3, 2);
            this.tblAccountTransactions.Controls.Add(this.lblPaymentType, 2, 2);
            this.tblAccountTransactions.Controls.Add(this.lblAmount, 0, 2);
            this.tblAccountTransactions.Controls.Add(this.txtAmount, 1, 2);
            this.tblAccountTransactions.Controls.Add(this.lblPaymentMode, 0, 3);
            this.tblAccountTransactions.Controls.Add(this.lblPaymentsMode, 1, 3);
            this.tblAccountTransactions.Location = new System.Drawing.Point(9, 52);
            this.tblAccountTransactions.Name = "tblAccountTransactions";
            this.tblAccountTransactions.RowCount = 4;
            this.tblAccountTransactions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblAccountTransactions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblAccountTransactions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblAccountTransactions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblAccountTransactions.Size = new System.Drawing.Size(643, 124);
            this.tblAccountTransactions.TabIndex = 4;
            // 
            // lblFirm
            // 
            this.lblFirm.AutoSize = true;
            this.lblFirm.Location = new System.Drawing.Point(3, 8);
            this.lblFirm.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblFirm.Name = "lblFirm";
            this.lblFirm.Size = new System.Drawing.Size(26, 13);
            this.lblFirm.TabIndex = 0;
            this.lblFirm.Text = "Firm";
            // 
            // pnlFirm
            // 
            this.pnlFirm.Controls.Add(this.btnAddFirm);
            this.pnlFirm.Controls.Add(this.comboFirm);
            this.pnlFirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFirm.Location = new System.Drawing.Point(100, 0);
            this.pnlFirm.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFirm.Name = "pnlFirm";
            this.pnlFirm.Size = new System.Drawing.Size(207, 31);
            this.pnlFirm.TabIndex = 1;
            // 
            // btnAddFirm
            // 
            this.btnAddFirm.BackgroundImage = global::ProAccount.Properties.Resources.add;
            this.btnAddFirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddFirm.Location = new System.Drawing.Point(184, 5);
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
            this.comboFirm.Location = new System.Drawing.Point(3, 5);
            this.comboFirm.Name = "comboFirm";
            this.comboFirm.Size = new System.Drawing.Size(180, 21);
            this.comboFirm.TabIndex = 0;
            this.comboFirm.SelectedIndexChanged += new System.EventHandler(this.comboFirm_SelectedIndexChanged);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(310, 8);
            this.lblAccount.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(47, 13);
            this.lblAccount.TabIndex = 2;
            this.lblAccount.Text = "Account";
            // 
            // pnlAccount
            // 
            this.pnlAccount.Controls.Add(this.btnAddAccount);
            this.pnlAccount.Controls.Add(this.comboAccount);
            this.pnlAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAccount.Location = new System.Drawing.Point(409, 0);
            this.pnlAccount.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(234, 31);
            this.pnlAccount.TabIndex = 3;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackgroundImage = global::ProAccount.Properties.Resources.add;
            this.btnAddAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAccount.Location = new System.Drawing.Point(186, 5);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(21, 21);
            this.btnAddAccount.TabIndex = 3;
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // comboAccount
            // 
            this.comboAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboAccount.Location = new System.Drawing.Point(3, 5);
            this.comboAccount.Name = "comboAccount";
            this.comboAccount.Size = new System.Drawing.Size(180, 21);
            this.comboAccount.TabIndex = 2;
            this.comboAccount.SelectedIndexChanged += new System.EventHandler(this.comboAccount_SelectedIndexChanged);
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.AutoSize = true;
            this.lblTransactionDate.Location = new System.Drawing.Point(3, 39);
            this.lblTransactionDate.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(89, 13);
            this.lblTransactionDate.TabIndex = 4;
            this.lblTransactionDate.Text = "Transaction Date";
            // 
            // dtTransactionDate
            // 
            this.dtTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTransactionDate.Location = new System.Drawing.Point(103, 34);
            this.dtTransactionDate.Name = "dtTransactionDate";
            this.dtTransactionDate.Size = new System.Drawing.Size(94, 20);
            this.dtTransactionDate.TabIndex = 5;
            // 
            // pnlPaymentMode
            // 
            this.pnlPaymentMode.Controls.Add(this.rbtnCredit);
            this.pnlPaymentMode.Controls.Add(this.rbtnDebit);
            this.pnlPaymentMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaymentMode.Location = new System.Drawing.Point(409, 62);
            this.pnlPaymentMode.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPaymentMode.Name = "pnlPaymentMode";
            this.pnlPaymentMode.Size = new System.Drawing.Size(234, 31);
            this.pnlPaymentMode.TabIndex = 7;
            // 
            // rbtnCredit
            // 
            this.rbtnCredit.AutoSize = true;
            this.rbtnCredit.Location = new System.Drawing.Point(61, 8);
            this.rbtnCredit.Name = "rbtnCredit";
            this.rbtnCredit.Size = new System.Drawing.Size(52, 17);
            this.rbtnCredit.TabIndex = 8;
            this.rbtnCredit.TabStop = true;
            this.rbtnCredit.Text = "Credit";
            this.rbtnCredit.UseVisualStyleBackColor = true;
            // 
            // rbtnDebit
            // 
            this.rbtnDebit.AutoSize = true;
            this.rbtnDebit.Checked = true;
            this.rbtnDebit.Location = new System.Drawing.Point(3, 8);
            this.rbtnDebit.Name = "rbtnDebit";
            this.rbtnDebit.Size = new System.Drawing.Size(50, 17);
            this.rbtnDebit.TabIndex = 7;
            this.rbtnDebit.TabStop = true;
            this.rbtnDebit.Text = "Debit";
            this.rbtnDebit.UseVisualStyleBackColor = true;
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Location = new System.Drawing.Point(310, 70);
            this.lblPaymentType.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(95, 13);
            this.lblPaymentType.TabIndex = 6;
            this.lblPaymentType.Text = "Transactions Type";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(3, 70);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(103, 68);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(182, 20);
            this.txtAmount.TabIndex = 6;
            // 
            // lblPaymentMode
            // 
            this.lblPaymentMode.AutoSize = true;
            this.lblPaymentMode.Location = new System.Drawing.Point(3, 101);
            this.lblPaymentMode.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblPaymentMode.Name = "lblPaymentMode";
            this.lblPaymentMode.Size = new System.Drawing.Size(93, 13);
            this.lblPaymentMode.TabIndex = 10;
            this.lblPaymentMode.Text = "Transaction Mode";
            // 
            // lblPaymentsMode
            // 
            this.lblPaymentsMode.Controls.Add(this.rbtnCheque);
            this.lblPaymentsMode.Controls.Add(this.rbtnCash);
            this.lblPaymentsMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaymentsMode.Location = new System.Drawing.Point(100, 93);
            this.lblPaymentsMode.Margin = new System.Windows.Forms.Padding(0);
            this.lblPaymentsMode.Name = "lblPaymentsMode";
            this.lblPaymentsMode.Size = new System.Drawing.Size(207, 31);
            this.lblPaymentsMode.TabIndex = 12;
            // 
            // rbtnCheque
            // 
            this.rbtnCheque.AutoSize = true;
            this.rbtnCheque.Location = new System.Drawing.Point(65, 6);
            this.rbtnCheque.Name = "rbtnCheque";
            this.rbtnCheque.Size = new System.Drawing.Size(62, 17);
            this.rbtnCheque.TabIndex = 10;
            this.rbtnCheque.TabStop = true;
            this.rbtnCheque.Text = "Cheque";
            this.rbtnCheque.UseVisualStyleBackColor = true;
            this.rbtnCheque.CheckedChanged += new System.EventHandler(this.rbtnCheque_CheckedChanged);
            // 
            // rbtnCash
            // 
            this.rbtnCash.AutoSize = true;
            this.rbtnCash.Checked = true;
            this.rbtnCash.Location = new System.Drawing.Point(3, 6);
            this.rbtnCash.Name = "rbtnCash";
            this.rbtnCash.Size = new System.Drawing.Size(49, 17);
            this.rbtnCash.TabIndex = 9;
            this.rbtnCash.TabStop = true;
            this.rbtnCash.Text = "Cash";
            this.rbtnCash.UseVisualStyleBackColor = true;
            // 
            // tblRemarks
            // 
            this.tblRemarks.BackColor = System.Drawing.Color.Transparent;
            this.tblRemarks.ColumnCount = 1;
            this.tblRemarks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRemarks.Controls.Add(this.pnlRemarks, 0, 0);
            this.tblRemarks.Location = new System.Drawing.Point(9, 176);
            this.tblRemarks.Name = "tblRemarks";
            this.tblRemarks.RowCount = 1;
            this.tblRemarks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRemarks.Size = new System.Drawing.Size(643, 47);
            this.tblRemarks.TabIndex = 5;
            // 
            // pnlRemarks
            // 
            this.pnlRemarks.Controls.Add(this.txtTransactionRemarks);
            this.pnlRemarks.Controls.Add(this.lblRemarks);
            this.pnlRemarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRemarks.Location = new System.Drawing.Point(0, 0);
            this.pnlRemarks.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRemarks.Name = "pnlRemarks";
            this.pnlRemarks.Size = new System.Drawing.Size(643, 47);
            this.pnlRemarks.TabIndex = 0;
            // 
            // txtTransactionRemarks
            // 
            this.txtTransactionRemarks.Location = new System.Drawing.Point(103, 4);
            this.txtTransactionRemarks.Multiline = true;
            this.txtTransactionRemarks.Name = "txtTransactionRemarks";
            this.txtTransactionRemarks.Size = new System.Drawing.Size(525, 39);
            this.txtTransactionRemarks.TabIndex = 11;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(3, 8);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(49, 13);
            this.lblRemarks.TabIndex = 0;
            this.lblRemarks.Text = "Remarks";
            // 
            // gridAccountTransactions
            // 
            this.gridAccountTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAccountTransactions.Location = new System.Drawing.Point(9, 227);
            this.gridAccountTransactions.Name = "gridAccountTransactions";
            this.gridAccountTransactions.Size = new System.Drawing.Size(646, 150);
            this.gridAccountTransactions.TabIndex = 6;
            // 
            // pnlFirmBtn
            // 
            this.pnlFirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.pnlFirmBtn.Controls.Add(this.btnATransactionDelete);
            this.pnlFirmBtn.Controls.Add(this.btnATransactionClear);
            this.pnlFirmBtn.Controls.Add(this.btnATransactionClose);
            this.pnlFirmBtn.Controls.Add(this.btnATransactionSave);
            this.pnlFirmBtn.Location = new System.Drawing.Point(424, 383);
            this.pnlFirmBtn.Name = "pnlFirmBtn";
            this.pnlFirmBtn.Size = new System.Drawing.Size(231, 37);
            this.pnlFirmBtn.TabIndex = 9;
            // 
            // btnATransactionDelete
            // 
            this.btnATransactionDelete.BackgroundImage = global::ProAccount.Properties.Resources.Button_Bkg;
            this.btnATransactionDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnATransactionDelete.ForeColor = System.Drawing.Color.White;
            this.btnATransactionDelete.Location = new System.Drawing.Point(59, 4);
            this.btnATransactionDelete.Name = "btnATransactionDelete";
            this.btnATransactionDelete.Size = new System.Drawing.Size(56, 30);
            this.btnATransactionDelete.TabIndex = 2;
            this.btnATransactionDelete.Text = "&Delete";
            this.btnATransactionDelete.UseVisualStyleBackColor = true;
            this.btnATransactionDelete.Click += new System.EventHandler(this.btnATransactionDelete_Click);
            // 
            // btnATransactionClear
            // 
            this.btnATransactionClear.BackgroundImage = global::ProAccount.Properties.Resources.Button_Bkg;
            this.btnATransactionClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnATransactionClear.ForeColor = System.Drawing.Color.White;
            this.btnATransactionClear.Location = new System.Drawing.Point(115, 4);
            this.btnATransactionClear.Name = "btnATransactionClear";
            this.btnATransactionClear.Size = new System.Drawing.Size(56, 30);
            this.btnATransactionClear.TabIndex = 3;
            this.btnATransactionClear.Text = "C&lear";
            this.btnATransactionClear.UseVisualStyleBackColor = true;
            this.btnATransactionClear.Click += new System.EventHandler(this.btnATransactionClear_Click);
            // 
            // btnATransactionClose
            // 
            this.btnATransactionClose.BackgroundImage = global::ProAccount.Properties.Resources.Button_Bkg;
            this.btnATransactionClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnATransactionClose.ForeColor = System.Drawing.Color.White;
            this.btnATransactionClose.Location = new System.Drawing.Point(172, 4);
            this.btnATransactionClose.Name = "btnATransactionClose";
            this.btnATransactionClose.Size = new System.Drawing.Size(56, 30);
            this.btnATransactionClose.TabIndex = 4;
            this.btnATransactionClose.Text = "&Close";
            this.btnATransactionClose.UseVisualStyleBackColor = true;
            this.btnATransactionClose.Click += new System.EventHandler(this.btnATransactionClose_Click);
            // 
            // btnATransactionSave
            // 
            this.btnATransactionSave.BackgroundImage = global::ProAccount.Properties.Resources.Button_Bkg;
            this.btnATransactionSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnATransactionSave.ForeColor = System.Drawing.Color.White;
            this.btnATransactionSave.Location = new System.Drawing.Point(3, 4);
            this.btnATransactionSave.Name = "btnATransactionSave";
            this.btnATransactionSave.Size = new System.Drawing.Size(56, 30);
            this.btnATransactionSave.TabIndex = 0;
            this.btnATransactionSave.Text = "&Save";
            this.btnATransactionSave.UseVisualStyleBackColor = true;
            this.btnATransactionSave.Click += new System.EventHandler(this.btnATransactionSave_Click);
            // 
            // AccountTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProAccount.Properties.Resources.LeftGradiant;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 427);
            this.Controls.Add(this.pnlFirmBtn);
            this.Controls.Add(this.gridAccountTransactions);
            this.Controls.Add(this.tblRemarks);
            this.Controls.Add(this.tblAccountTransactions);
            this.Controls.Add(this.tblPatientBillHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountTransaction";
            this.Load += new System.EventHandler(this.AccountTransaction_Load);
            this.tblPatientBillHeader.ResumeLayout(false);
            this.pnlPatientBillHeader.ResumeLayout(false);
            this.pnlPatientBillHeader.PerformLayout();
            this.tblAccountTransactions.ResumeLayout(false);
            this.tblAccountTransactions.PerformLayout();
            this.pnlFirm.ResumeLayout(false);
            this.pnlAccount.ResumeLayout(false);
            this.pnlPaymentMode.ResumeLayout(false);
            this.pnlPaymentMode.PerformLayout();
            this.lblPaymentsMode.ResumeLayout(false);
            this.lblPaymentsMode.PerformLayout();
            this.tblRemarks.ResumeLayout(false);
            this.pnlRemarks.ResumeLayout(false);
            this.pnlRemarks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAccountTransactions)).EndInit();
            this.pnlFirmBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel tblPatientBillHeader;
        internal System.Windows.Forms.Panel pnlPatientBillHeader;
        internal System.Windows.Forms.Label lblPatientBillHeader;
        private System.Windows.Forms.TableLayoutPanel tblAccountTransactions;
        private System.Windows.Forms.Label lblFirm;
        private System.Windows.Forms.Panel pnlFirm;
        private System.Windows.Forms.ComboBox comboFirm;
        private System.Windows.Forms.Button btnAddFirm;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Panel pnlAccount;
        private System.Windows.Forms.ComboBox comboAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Label lblTransactionDate;
        private System.Windows.Forms.DateTimePicker dtTransactionDate;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblPaymentMode;
        private System.Windows.Forms.TableLayoutPanel tblRemarks;
        private System.Windows.Forms.Panel pnlRemarks;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtTransactionRemarks;
        private System.Windows.Forms.DataGridView gridAccountTransactions;
        internal System.Windows.Forms.Panel pnlFirmBtn;
        internal System.Windows.Forms.Button btnATransactionDelete;
        internal System.Windows.Forms.Button btnATransactionClear;
        internal System.Windows.Forms.Button btnATransactionClose;
        internal System.Windows.Forms.Button btnATransactionSave;
        private System.Windows.Forms.Panel lblPaymentsMode;
        private System.Windows.Forms.RadioButton rbtnCheque;
        private System.Windows.Forms.RadioButton rbtnCash;
        private System.Windows.Forms.Panel pnlPaymentMode;
        private System.Windows.Forms.RadioButton rbtnCredit;
        private System.Windows.Forms.RadioButton rbtnDebit;
    }
}