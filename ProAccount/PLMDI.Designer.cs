namespace ProAccount
{
    partial class PLMDIForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PLMDIForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFirmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionUtilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(689, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFirmToolStripMenuItem,
            this.newAccountToolStripMenuItem,
            this.accountTransactionToolStripMenuItem,
            this.transactionUtilityToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFirmToolStripMenuItem
            // 
            this.newFirmToolStripMenuItem.Name = "newFirmToolStripMenuItem";
            this.newFirmToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.newFirmToolStripMenuItem.Text = "New Firm";
            this.newFirmToolStripMenuItem.Click += new System.EventHandler(this.newFirmToolStripMenuItem_Click);
            // 
            // newAccountToolStripMenuItem
            // 
            this.newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem";
            this.newAccountToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.newAccountToolStripMenuItem.Text = "New Account";
            this.newAccountToolStripMenuItem.Click += new System.EventHandler(this.newAccountToolStripMenuItem_Click);
            // 
            // accountTransactionToolStripMenuItem
            // 
            this.accountTransactionToolStripMenuItem.Name = "accountTransactionToolStripMenuItem";
            this.accountTransactionToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.accountTransactionToolStripMenuItem.Text = "Account Transaction";
            this.accountTransactionToolStripMenuItem.Click += new System.EventHandler(this.accountTransactionToolStripMenuItem_Click);
            // 
            // transactionUtilityToolStripMenuItem
            // 
            this.transactionUtilityToolStripMenuItem.Name = "transactionUtilityToolStripMenuItem";
            this.transactionUtilityToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.transactionUtilityToolStripMenuItem.Text = "Transaction Utility";
            this.transactionUtilityToolStripMenuItem.Click += new System.EventHandler(this.transactionUtilityToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PLMDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 427);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PLMDIForm";
            this.Text = "Pro Account";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PLMDIForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFirmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionUtilityToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

