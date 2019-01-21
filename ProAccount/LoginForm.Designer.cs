namespace ProAccount
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.UserNamelabel = new System.Windows.Forms.Label();
            this.txtLoginUserName = new System.Windows.Forms.TextBox();
            this.lblUserPassoword = new System.Windows.Forms.Label();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNamelabel
            // 
            this.UserNamelabel.Location = new System.Drawing.Point(143, 17);
            this.UserNamelabel.Name = "UserNamelabel";
            this.UserNamelabel.Size = new System.Drawing.Size(165, 19);
            this.UserNamelabel.TabIndex = 1;
            this.UserNamelabel.Text = "UserName";
            // 
            // txtLoginUserName
            // 
            this.txtLoginUserName.Location = new System.Drawing.Point(146, 34);
            this.txtLoginUserName.Name = "txtLoginUserName";
            this.txtLoginUserName.Size = new System.Drawing.Size(165, 20);
            this.txtLoginUserName.TabIndex = 2;
            this.txtLoginUserName.Text = "Admin";
            // 
            // lblUserPassoword
            // 
            this.lblUserPassoword.Location = new System.Drawing.Point(143, 67);
            this.lblUserPassoword.Name = "lblUserPassoword";
            this.lblUserPassoword.Size = new System.Drawing.Size(168, 19);
            this.lblUserPassoword.TabIndex = 3;
            this.lblUserPassoword.Text = "Password";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(146, 84);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(165, 20);
            this.txtLoginPassword.TabIndex = 4;
            this.txtLoginPassword.Text = "Test!1234";
            this.txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(165, 125);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(70, 24);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(241, 125);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 24);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProAccount.Properties.Resources.accountingicon;
            this.pictureBox1.Location = new System.Drawing.Point(8, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.lblUserPassoword);
            this.Controls.Add(this.txtLoginUserName);
            this.Controls.Add(this.UserNamelabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UserNamelabel;
        private System.Windows.Forms.TextBox txtLoginUserName;
        private System.Windows.Forms.Label lblUserPassoword;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}