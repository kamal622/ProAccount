namespace ProAccount.Forms
{
    partial class AccountType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountType));
            this.tblAccountypeHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTYpeHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchType = new System.Windows.Forms.Button();
            this.txtSearchType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tblAccountBody = new System.Windows.Forms.TableLayoutPanel();
            this.lblTYpe = new System.Windows.Forms.Label();
            this.txtAccountType = new System.Windows.Forms.TextBox();
            this.pnlbutton = new System.Windows.Forms.Panel();
            this.btnTypeClose = new System.Windows.Forms.Button();
            this.btnTypeClear = new System.Windows.Forms.Button();
            this.btnTypeDelete = new System.Windows.Forms.Button();
            this.btnTypeSave = new System.Windows.Forms.Button();
            this.tblAccountypeHeader.SuspendLayout();
            this.pnlTYpeHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tblAccountBody.SuspendLayout();
            this.pnlbutton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblAccountypeHeader
            // 
            this.tblAccountypeHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.tblAccountypeHeader.ColumnCount = 1;
            this.tblAccountypeHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblAccountypeHeader.Controls.Add(this.pnlTYpeHeader, 0, 0);
            this.tblAccountypeHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblAccountypeHeader.Location = new System.Drawing.Point(0, 0);
            this.tblAccountypeHeader.Name = "tblAccountypeHeader";
            this.tblAccountypeHeader.RowCount = 1;
            this.tblAccountypeHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblAccountypeHeader.Size = new System.Drawing.Size(308, 40);
            this.tblAccountypeHeader.TabIndex = 0;
            // 
            // pnlTYpeHeader
            // 
            this.pnlTYpeHeader.Controls.Add(this.label1);
            this.pnlTYpeHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTYpeHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlTYpeHeader.Name = "pnlTYpeHeader";
            this.pnlTYpeHeader.Size = new System.Drawing.Size(302, 34);
            this.pnlTYpeHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Type";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSearchType);
            this.groupBox1.Controls.Add(this.txtSearchType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 48);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // btnSearchType
            // 
            this.btnSearchType.BackgroundImage = global::ProAccount.Properties.Resources.F2_Button;
            this.btnSearchType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearchType.Location = new System.Drawing.Point(230, 17);
            this.btnSearchType.Name = "btnSearchType";
            this.btnSearchType.Size = new System.Drawing.Size(36, 23);
            this.btnSearchType.TabIndex = 2;
            this.btnSearchType.Text = "F2";
            this.btnSearchType.UseVisualStyleBackColor = true;
            this.btnSearchType.Click += new System.EventHandler(this.btnSearchType_Click);
            // 
            // txtSearchType
            // 
            this.txtSearchType.Location = new System.Drawing.Point(61, 18);
            this.txtSearchType.Name = "txtSearchType";
            this.txtSearchType.Size = new System.Drawing.Size(159, 20);
            this.txtSearchType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Type";
            // 
            // tblAccountBody
            // 
            this.tblAccountBody.BackColor = System.Drawing.Color.Transparent;
            this.tblAccountBody.ColumnCount = 2;
            this.tblAccountBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.64057F));
            this.tblAccountBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.35943F));
            this.tblAccountBody.Controls.Add(this.lblTYpe, 0, 0);
            this.tblAccountBody.Controls.Add(this.txtAccountType, 1, 0);
            this.tblAccountBody.Location = new System.Drawing.Point(13, 101);
            this.tblAccountBody.Name = "tblAccountBody";
            this.tblAccountBody.RowCount = 1;
            this.tblAccountBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblAccountBody.Size = new System.Drawing.Size(281, 30);
            this.tblAccountBody.TabIndex = 2;
            // 
            // lblTYpe
            // 
            this.lblTYpe.AutoSize = true;
            this.lblTYpe.Location = new System.Drawing.Point(14, 7);
            this.lblTYpe.Margin = new System.Windows.Forms.Padding(14, 7, 3, 0);
            this.lblTYpe.Name = "lblTYpe";
            this.lblTYpe.Size = new System.Drawing.Size(31, 13);
            this.lblTYpe.TabIndex = 0;
            this.lblTYpe.Text = "Type";
            // 
            // txtAccountType
            // 
            this.txtAccountType.Location = new System.Drawing.Point(61, 5);
            this.txtAccountType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txtAccountType.Name = "txtAccountType";
            this.txtAccountType.Size = new System.Drawing.Size(205, 20);
            this.txtAccountType.TabIndex = 1;
            this.txtAccountType.Leave += new System.EventHandler(this.txtAccountType_Leave);
            // 
            // pnlbutton
            // 
            this.pnlbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.pnlbutton.Controls.Add(this.btnTypeClose);
            this.pnlbutton.Controls.Add(this.btnTypeClear);
            this.pnlbutton.Controls.Add(this.btnTypeDelete);
            this.pnlbutton.Controls.Add(this.btnTypeSave);
            this.pnlbutton.Location = new System.Drawing.Point(64, 137);
            this.pnlbutton.Name = "pnlbutton";
            this.pnlbutton.Size = new System.Drawing.Size(230, 37);
            this.pnlbutton.TabIndex = 3;
            // 
            // btnTypeClose
            // 
            this.btnTypeClose.BackgroundImage = global::ProAccount.Properties.Resources.Button_Bkg;
            this.btnTypeClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTypeClose.Location = new System.Drawing.Point(172, 3);
            this.btnTypeClose.Name = "btnTypeClose";
            this.btnTypeClose.Size = new System.Drawing.Size(56, 30);
            this.btnTypeClose.TabIndex = 3;
            this.btnTypeClose.Text = "&Close";
            this.btnTypeClose.UseVisualStyleBackColor = true;
            this.btnTypeClose.Click += new System.EventHandler(this.btnTypeClose_Click);
            // 
            // btnTypeClear
            // 
            this.btnTypeClear.BackgroundImage = global::ProAccount.Properties.Resources.Button_Bkg;
            this.btnTypeClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTypeClear.Location = new System.Drawing.Point(115, 3);
            this.btnTypeClear.Name = "btnTypeClear";
            this.btnTypeClear.Size = new System.Drawing.Size(56, 30);
            this.btnTypeClear.TabIndex = 2;
            this.btnTypeClear.Text = "C&lear";
            this.btnTypeClear.UseVisualStyleBackColor = true;
            this.btnTypeClear.Click += new System.EventHandler(this.btnTypeClear_Click);
            // 
            // btnTypeDelete
            // 
            this.btnTypeDelete.BackgroundImage = global::ProAccount.Properties.Resources.Button_Bkg;
            this.btnTypeDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTypeDelete.Location = new System.Drawing.Point(59, 3);
            this.btnTypeDelete.Name = "btnTypeDelete";
            this.btnTypeDelete.Size = new System.Drawing.Size(56, 30);
            this.btnTypeDelete.TabIndex = 1;
            this.btnTypeDelete.Text = "&Delete";
            this.btnTypeDelete.UseVisualStyleBackColor = true;
            this.btnTypeDelete.Click += new System.EventHandler(this.btnTypeDelete_Click);
            // 
            // btnTypeSave
            // 
            this.btnTypeSave.BackgroundImage = global::ProAccount.Properties.Resources.Button_Bkg;
            this.btnTypeSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTypeSave.Location = new System.Drawing.Point(3, 3);
            this.btnTypeSave.Name = "btnTypeSave";
            this.btnTypeSave.Size = new System.Drawing.Size(56, 30);
            this.btnTypeSave.TabIndex = 0;
            this.btnTypeSave.Text = "&Save";
            this.btnTypeSave.UseVisualStyleBackColor = true;
            this.btnTypeSave.Click += new System.EventHandler(this.btnTypeSave_Click);
            // 
            // AccountType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProAccount.Properties.Resources.LeftGradiant;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(308, 186);
            this.Controls.Add(this.pnlbutton);
            this.Controls.Add(this.tblAccountBody);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tblAccountypeHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountType";
            this.Load += new System.EventHandler(this.AccountType_Load);
            this.tblAccountypeHeader.ResumeLayout(false);
            this.pnlTYpeHeader.ResumeLayout(false);
            this.pnlTYpeHeader.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tblAccountBody.ResumeLayout(false);
            this.tblAccountBody.PerformLayout();
            this.pnlbutton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblAccountypeHeader;
        private System.Windows.Forms.Panel pnlTYpeHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchType;
        private System.Windows.Forms.Button btnSearchType;
        private System.Windows.Forms.TableLayoutPanel tblAccountBody;
        private System.Windows.Forms.Label lblTYpe;
        private System.Windows.Forms.TextBox txtAccountType;
        private System.Windows.Forms.Panel pnlbutton;
        private System.Windows.Forms.Button btnTypeSave;
        private System.Windows.Forms.Button btnTypeDelete;
        private System.Windows.Forms.Button btnTypeClear;
        private System.Windows.Forms.Button btnTypeClose;
    }
}