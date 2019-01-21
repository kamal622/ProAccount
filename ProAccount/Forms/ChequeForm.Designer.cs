namespace ProAccount.Forms
{
    partial class ChequeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChequeForm));
            this.btnChequeClose = new System.Windows.Forms.Button();
            this.btnChequeClear = new System.Windows.Forms.Button();
            this.btnChequeSave = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnChequeDelete = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.dtChequeDate = new System.Windows.Forms.DateTimePicker();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtChequeNo = new System.Windows.Forms.TextBox();
            this.lblChequeHeader = new System.Windows.Forms.Label();
            this.pnlChequeDetails = new System.Windows.Forms.Panel();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tblChequeHeader = new System.Windows.Forms.TableLayoutPanel();
            this.Panel1.SuspendLayout();
            this.pnlChequeDetails.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.tblChequeHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChequeClose
            // 
            this.btnChequeClose.BackgroundImage = global::ProAccount.Properties.Resources.Button_Bkg;
            this.btnChequeClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChequeClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChequeClose.Location = new System.Drawing.Point(171, 3);
            this.btnChequeClose.Name = "btnChequeClose";
            this.btnChequeClose.Size = new System.Drawing.Size(56, 30);
            this.btnChequeClose.TabIndex = 3;
            this.btnChequeClose.Text = "&Close";
            this.btnChequeClose.UseVisualStyleBackColor = true;
            this.btnChequeClose.Click += new System.EventHandler(this.btnChequeClose_Click);
            // 
            // btnChequeClear
            // 
            this.btnChequeClear.BackgroundImage = global::ProAccount.Properties.Resources.Button_Bkg;
            this.btnChequeClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChequeClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChequeClear.Location = new System.Drawing.Point(115, 3);
            this.btnChequeClear.Name = "btnChequeClear";
            this.btnChequeClear.Size = new System.Drawing.Size(56, 30);
            this.btnChequeClear.TabIndex = 2;
            this.btnChequeClear.Text = "C&lear";
            this.btnChequeClear.UseVisualStyleBackColor = true;
            this.btnChequeClear.Click += new System.EventHandler(this.btnChequeClear_Click);
            // 
            // btnChequeSave
            // 
            this.btnChequeSave.BackgroundImage = global::ProAccount.Properties.Resources.Button_Bkg;
            this.btnChequeSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChequeSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChequeSave.Location = new System.Drawing.Point(3, 3);
            this.btnChequeSave.Name = "btnChequeSave";
            this.btnChequeSave.Size = new System.Drawing.Size(56, 30);
            this.btnChequeSave.TabIndex = 0;
            this.btnChequeSave.Text = "&Save";
            this.btnChequeSave.UseVisualStyleBackColor = true;
            this.btnChequeSave.Click += new System.EventHandler(this.btnChequeSave_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.Panel1.Controls.Add(this.btnChequeClose);
            this.Panel1.Controls.Add(this.btnChequeClear);
            this.Panel1.Controls.Add(this.btnChequeDelete);
            this.Panel1.Controls.Add(this.btnChequeSave);
            this.Panel1.Location = new System.Drawing.Point(232, 114);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(231, 35);
            this.Panel1.TabIndex = 5;
            // 
            // btnChequeDelete
            // 
            this.btnChequeDelete.BackgroundImage = global::ProAccount.Properties.Resources.Button_Bkg;
            this.btnChequeDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChequeDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChequeDelete.Location = new System.Drawing.Point(59, 3);
            this.btnChequeDelete.Name = "btnChequeDelete";
            this.btnChequeDelete.Size = new System.Drawing.Size(56, 30);
            this.btnChequeDelete.TabIndex = 1;
            this.btnChequeDelete.Text = "&Delete";
            this.btnChequeDelete.UseVisualStyleBackColor = true;
            this.btnChequeDelete.Click += new System.EventHandler(this.btnChequeDelete_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(233, 3);
            this.Label2.Margin = new System.Windows.Forms.Padding(3);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(70, 13);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Cheque Date";
            // 
            // dtChequeDate
            // 
            this.dtChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtChequeDate.Location = new System.Drawing.Point(325, 3);
            this.dtChequeDate.Name = "dtChequeDate";
            this.dtChequeDate.Size = new System.Drawing.Size(135, 20);
            this.dtChequeDate.TabIndex = 1;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(0, 28);
            this.Label5.Margin = new System.Windows.Forms.Padding(0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(63, 13);
            this.Label5.TabIndex = 6;
            this.Label5.Text = "Bank Name";
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(95, 31);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(132, 20);
            this.txtBankName.TabIndex = 7;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(233, 31);
            this.Label4.Margin = new System.Windows.Forms.Padding(3);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(61, 13);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "Cheque No";
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.Location = new System.Drawing.Point(325, 31);
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.Size = new System.Drawing.Size(132, 20);
            this.txtChequeNo.TabIndex = 11;
            // 
            // lblChequeHeader
            // 
            this.lblChequeHeader.AutoSize = true;
            this.lblChequeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChequeHeader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblChequeHeader.Location = new System.Drawing.Point(6, 8);
            this.lblChequeHeader.Name = "lblChequeHeader";
            this.lblChequeHeader.Size = new System.Drawing.Size(118, 17);
            this.lblChequeHeader.TabIndex = 0;
            this.lblChequeHeader.Text = "Cheque Details";
            // 
            // pnlChequeDetails
            // 
            this.pnlChequeDetails.Controls.Add(this.lblChequeHeader);
            this.pnlChequeDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChequeDetails.Location = new System.Drawing.Point(3, 3);
            this.pnlChequeDetails.Name = "pnlChequeDetails";
            this.pnlChequeDetails.Size = new System.Drawing.Size(459, 34);
            this.pnlChequeDetails.TabIndex = 0;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutPanel1.ColumnCount = 4;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TableLayoutPanel1.Controls.Add(this.Label2, 2, 0);
            this.TableLayoutPanel1.Controls.Add(this.dtChequeDate, 3, 0);
            this.TableLayoutPanel1.Controls.Add(this.Label5, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.txtBankName, 1, 1);
            this.TableLayoutPanel1.Controls.Add(this.Label4, 2, 1);
            this.TableLayoutPanel1.Controls.Add(this.txtChequeNo, 3, 1);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 51);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 2;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(463, 57);
            this.TableLayoutPanel1.TabIndex = 4;
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
            this.tblChequeHeader.Size = new System.Drawing.Size(465, 40);
            this.tblChequeHeader.TabIndex = 3;
            // 
            // ChequeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProAccount.Properties.Resources.LeftGradiant;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 156);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.tblChequeHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChequeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cheque Details";
            this.Load += new System.EventHandler(this.ChequeForm_Load);
            this.Panel1.ResumeLayout(false);
            this.pnlChequeDetails.ResumeLayout(false);
            this.pnlChequeDetails.PerformLayout();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.tblChequeHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnChequeClose;
        internal System.Windows.Forms.Button btnChequeClear;
        internal System.Windows.Forms.Button btnChequeSave;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnChequeDelete;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DateTimePicker dtChequeDate;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtBankName;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtChequeNo;
        internal System.Windows.Forms.Label lblChequeHeader;
        internal System.Windows.Forms.Panel pnlChequeDetails;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.TableLayoutPanel tblChequeHeader;
    }
}