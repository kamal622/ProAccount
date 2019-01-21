namespace ProAccount.Forms
{
    partial class AccountTransactionsUtility
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountTransactionsUtility));
            this.tblChequeHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pnlChequeDetails = new System.Windows.Forms.Panel();
            this.lblChequeHeader = new System.Windows.Forms.Label();
            this.gbTransactionUtility = new System.Windows.Forms.GroupBox();
            this.btnSearchTransactions = new System.Windows.Forms.Button();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboUAccount = new System.Windows.Forms.ComboBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.comboUFirm = new System.Windows.Forms.ComboBox();
            this.lblFirm = new System.Windows.Forms.Label();
            this.gridTransactionUtilty = new System.Windows.Forms.DataGridView();
            this.pnlFirmBtn = new System.Windows.Forms.Panel();
            this.btnTUtilityDelete = new System.Windows.Forms.Button();
            this.btnTUtilityClear = new System.Windows.Forms.Button();
            this.btnTUtilityClose = new System.Windows.Forms.Button();
            this.btnTUtilityDownload = new System.Windows.Forms.Button();
            this.tblChequeHeader.SuspendLayout();
            this.pnlChequeDetails.SuspendLayout();
            this.gbTransactionUtility.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactionUtilty)).BeginInit();
            this.pnlFirmBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblChequeHeader
            // 
            this.tblChequeHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.tblChequeHeader.ColumnCount = 1;
            this.tblChequeHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblChequeHeader.Controls.Add(this.pnlChequeDetails, 0, 0);
            this.tblChequeHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblChequeHeader.Location = new System.Drawing.Point(0, 0);
            this.tblChequeHeader.Name = "tblChequeHeader";
            this.tblChequeHeader.RowCount = 1;
            this.tblChequeHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblChequeHeader.Size = new System.Drawing.Size(819, 40);
            this.tblChequeHeader.TabIndex = 4;
            // 
            // pnlChequeDetails
            // 
            this.pnlChequeDetails.Controls.Add(this.lblChequeHeader);
            this.pnlChequeDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChequeDetails.Location = new System.Drawing.Point(3, 3);
            this.pnlChequeDetails.Name = "pnlChequeDetails";
            this.pnlChequeDetails.Size = new System.Drawing.Size(813, 34);
            this.pnlChequeDetails.TabIndex = 0;
            // 
            // lblChequeHeader
            // 
            this.lblChequeHeader.AutoSize = true;
            this.lblChequeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChequeHeader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblChequeHeader.Location = new System.Drawing.Point(6, 8);
            this.lblChequeHeader.Name = "lblChequeHeader";
            this.lblChequeHeader.Size = new System.Drawing.Size(140, 17);
            this.lblChequeHeader.TabIndex = 0;
            this.lblChequeHeader.Text = "Transaction Utility";
            // 
            // gbTransactionUtility
            // 
            this.gbTransactionUtility.BackColor = System.Drawing.Color.Transparent;
            this.gbTransactionUtility.Controls.Add(this.btnSearchTransactions);
            this.gbTransactionUtility.Controls.Add(this.dtToDate);
            this.gbTransactionUtility.Controls.Add(this.label2);
            this.gbTransactionUtility.Controls.Add(this.dtFromDate);
            this.gbTransactionUtility.Controls.Add(this.label1);
            this.gbTransactionUtility.Controls.Add(this.comboUAccount);
            this.gbTransactionUtility.Controls.Add(this.lblAccount);
            this.gbTransactionUtility.Controls.Add(this.comboUFirm);
            this.gbTransactionUtility.Controls.Add(this.lblFirm);
            this.gbTransactionUtility.Location = new System.Drawing.Point(12, 50);
            this.gbTransactionUtility.Name = "gbTransactionUtility";
            this.gbTransactionUtility.Size = new System.Drawing.Size(793, 56);
            this.gbTransactionUtility.TabIndex = 5;
            this.gbTransactionUtility.TabStop = false;
            this.gbTransactionUtility.Text = "Search";
            // 
            // btnSearchTransactions
            // 
            this.btnSearchTransactions.BackgroundImage = global::ProAccount.Properties.Resources.Button_Bkg;
            this.btnSearchTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTransactions.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearchTransactions.Location = new System.Drawing.Point(723, 22);
            this.btnSearchTransactions.Name = "btnSearchTransactions";
            this.btnSearchTransactions.Size = new System.Drawing.Size(58, 21);
            this.btnSearchTransactions.TabIndex = 8;
            this.btnSearchTransactions.Text = "Search";
            this.btnSearchTransactions.Click += new System.EventHandler(this.btnSearchTransactions_Click);
            // 
            // dtToDate
            // 
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToDate.Location = new System.Drawing.Point(624, 23);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(90, 20);
            this.dtToDate.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "To Date";
            // 
            // dtFromDate
            // 
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFromDate.Location = new System.Drawing.Point(465, 23);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(90, 20);
            this.dtFromDate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "From Date";
            // 
            // comboUAccount
            // 
            this.comboUAccount.Location = new System.Drawing.Point(245, 22);
            this.comboUAccount.Name = "comboUAccount";
            this.comboUAccount.Size = new System.Drawing.Size(140, 21);
            this.comboUAccount.TabIndex = 2;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(192, 25);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(47, 13);
            this.lblAccount.TabIndex = 2;
            this.lblAccount.Text = "Account";
            // 
            // comboUFirm
            // 
            this.comboUFirm.FormattingEnabled = true;
            this.comboUFirm.Location = new System.Drawing.Point(41, 22);
            this.comboUFirm.Name = "comboUFirm";
            this.comboUFirm.Size = new System.Drawing.Size(140, 21);
            this.comboUFirm.TabIndex = 1;
            this.comboUFirm.SelectedIndexChanged += new System.EventHandler(this.comboUFirm_SelectedIndexChanged);
            // 
            // lblFirm
            // 
            this.lblFirm.AutoSize = true;
            this.lblFirm.Location = new System.Drawing.Point(11, 25);
            this.lblFirm.Name = "lblFirm";
            this.lblFirm.Size = new System.Drawing.Size(26, 13);
            this.lblFirm.TabIndex = 0;
            this.lblFirm.Text = "Firm";
            // 
            // gridTransactionUtilty
            // 
            this.gridTransactionUtilty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTransactionUtilty.Location = new System.Drawing.Point(12, 116);
            this.gridTransactionUtilty.Name = "gridTransactionUtilty";
            this.gridTransactionUtilty.Size = new System.Drawing.Size(793, 150);
            this.gridTransactionUtilty.TabIndex = 6;
            this.gridTransactionUtilty.DoubleClick += new System.EventHandler(this.gridTransactionUtilty_DoubleClick);
            // 
            // pnlFirmBtn
            // 
            this.pnlFirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.pnlFirmBtn.Controls.Add(this.btnTUtilityDelete);
            this.pnlFirmBtn.Controls.Add(this.btnTUtilityClear);
            this.pnlFirmBtn.Controls.Add(this.btnTUtilityClose);
            this.pnlFirmBtn.Controls.Add(this.btnTUtilityDownload);
            this.pnlFirmBtn.Location = new System.Drawing.Point(555, 272);
            this.pnlFirmBtn.Name = "pnlFirmBtn";
            this.pnlFirmBtn.Size = new System.Drawing.Size(250, 35);
            this.pnlFirmBtn.TabIndex = 10;
            // 
            // btnTUtilityDelete
            // 
            this.btnTUtilityDelete.BackgroundImage = global::ProAccount.Properties.Resources.Button_Bkg;
            this.btnTUtilityDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTUtilityDelete.ForeColor = System.Drawing.Color.White;
            this.btnTUtilityDelete.Location = new System.Drawing.Point(78, 4);
            this.btnTUtilityDelete.Name = "btnTUtilityDelete";
            this.btnTUtilityDelete.Size = new System.Drawing.Size(56, 30);
            this.btnTUtilityDelete.TabIndex = 2;
            this.btnTUtilityDelete.Text = "&Delete";
            this.btnTUtilityDelete.UseVisualStyleBackColor = true;
            this.btnTUtilityDelete.Click += new System.EventHandler(this.btnTUtilityDelete_Click);
            // 
            // btnTUtilityClear
            // 
            this.btnTUtilityClear.BackgroundImage = global::ProAccount.Properties.Resources.Button_Bkg;
            this.btnTUtilityClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTUtilityClear.ForeColor = System.Drawing.Color.White;
            this.btnTUtilityClear.Location = new System.Drawing.Point(134, 4);
            this.btnTUtilityClear.Name = "btnTUtilityClear";
            this.btnTUtilityClear.Size = new System.Drawing.Size(56, 30);
            this.btnTUtilityClear.TabIndex = 3;
            this.btnTUtilityClear.Text = "C&lear";
            this.btnTUtilityClear.UseVisualStyleBackColor = true;
            this.btnTUtilityClear.Click += new System.EventHandler(this.btnTUtilityClear_Click);
            // 
            // btnTUtilityClose
            // 
            this.btnTUtilityClose.BackgroundImage = global::ProAccount.Properties.Resources.Button_Bkg;
            this.btnTUtilityClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTUtilityClose.ForeColor = System.Drawing.Color.White;
            this.btnTUtilityClose.Location = new System.Drawing.Point(191, 4);
            this.btnTUtilityClose.Name = "btnTUtilityClose";
            this.btnTUtilityClose.Size = new System.Drawing.Size(56, 30);
            this.btnTUtilityClose.TabIndex = 4;
            this.btnTUtilityClose.Text = "&Close";
            this.btnTUtilityClose.UseVisualStyleBackColor = true;
            this.btnTUtilityClose.Click += new System.EventHandler(this.btnTUtilityClose_Click);
            // 
            // btnTUtilityDownload
            // 
            this.btnTUtilityDownload.BackgroundImage = global::ProAccount.Properties.Resources.Button_Bkg;
            this.btnTUtilityDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTUtilityDownload.ForeColor = System.Drawing.Color.White;
            this.btnTUtilityDownload.Location = new System.Drawing.Point(3, 4);
            this.btnTUtilityDownload.Name = "btnTUtilityDownload";
            this.btnTUtilityDownload.Size = new System.Drawing.Size(74, 30);
            this.btnTUtilityDownload.TabIndex = 0;
            this.btnTUtilityDownload.Text = "Do&wnload";
            this.btnTUtilityDownload.UseVisualStyleBackColor = true;
            this.btnTUtilityDownload.Click += new System.EventHandler(this.btnTUtilityDownload_Click);
            // 
            // AccountTransactionsUtility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProAccount.Properties.Resources.LeftGradiant;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 315);
            this.Controls.Add(this.pnlFirmBtn);
            this.Controls.Add(this.gridTransactionUtilty);
            this.Controls.Add(this.gbTransactionUtility);
            this.Controls.Add(this.tblChequeHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountTransactionsUtility";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions Utility";
            this.Load += new System.EventHandler(this.AccountTransactionsUtility_Load);
            this.tblChequeHeader.ResumeLayout(false);
            this.pnlChequeDetails.ResumeLayout(false);
            this.pnlChequeDetails.PerformLayout();
            this.gbTransactionUtility.ResumeLayout(false);
            this.gbTransactionUtility.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactionUtilty)).EndInit();
            this.pnlFirmBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel tblChequeHeader;
        internal System.Windows.Forms.Panel pnlChequeDetails;
        internal System.Windows.Forms.Label lblChequeHeader;
        private System.Windows.Forms.GroupBox gbTransactionUtility;
        private System.Windows.Forms.Label lblFirm;
        private System.Windows.Forms.ComboBox comboUFirm;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.ComboBox comboUAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.Button btnSearchTransactions;
        private System.Windows.Forms.DataGridView gridTransactionUtilty;
        internal System.Windows.Forms.Panel pnlFirmBtn;
        internal System.Windows.Forms.Button btnTUtilityDelete;
        internal System.Windows.Forms.Button btnTUtilityClear;
        internal System.Windows.Forms.Button btnTUtilityDownload;
        internal System.Windows.Forms.Button btnTUtilityClose;
    }
}