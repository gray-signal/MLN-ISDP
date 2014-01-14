namespace MLN_ISDP_project
{
    partial class Form1
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
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partsInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPartsScreen = new System.Windows.Forms.Button();
            this.btnAcctsScreen = new System.Windows.Forms.Button();
            this.tabPartsActions = new System.Windows.Forms.TabControl();
            this.tabLookUp = new System.Windows.Forms.TabPage();
            this.lblQuery = new System.Windows.Forms.Label();
            this.tabInvoice = new System.Windows.Forms.TabPage();
            this.mnuMenu.SuspendLayout();
            this.tabPartsActions.SuspendLayout();
            this.tabLookUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.partsInventoryToolStripMenuItem,
            this.accountsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(697, 25);
            this.mnuMenu.TabIndex = 0;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // partsInventoryToolStripMenuItem
            // 
            this.partsInventoryToolStripMenuItem.Name = "partsInventoryToolStripMenuItem";
            this.partsInventoryToolStripMenuItem.Size = new System.Drawing.Size(115, 21);
            this.partsInventoryToolStripMenuItem.Text = "&Parts Inventory";
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.accountsToolStripMenuItem.Text = "&Accounts";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 21);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // btnPartsScreen
            // 
            this.btnPartsScreen.Location = new System.Drawing.Point(12, 28);
            this.btnPartsScreen.Name = "btnPartsScreen";
            this.btnPartsScreen.Size = new System.Drawing.Size(101, 50);
            this.btnPartsScreen.TabIndex = 1;
            this.btnPartsScreen.Text = "Parts Inventory";
            this.btnPartsScreen.UseVisualStyleBackColor = true;
            // 
            // btnAcctsScreen
            // 
            this.btnAcctsScreen.Location = new System.Drawing.Point(119, 28);
            this.btnAcctsScreen.Name = "btnAcctsScreen";
            this.btnAcctsScreen.Size = new System.Drawing.Size(101, 50);
            this.btnAcctsScreen.TabIndex = 2;
            this.btnAcctsScreen.Text = "Accounts";
            this.btnAcctsScreen.UseVisualStyleBackColor = true;
            // 
            // tabPartsActions
            // 
            this.tabPartsActions.Controls.Add(this.tabLookUp);
            this.tabPartsActions.Controls.Add(this.tabInvoice);
            this.tabPartsActions.Location = new System.Drawing.Point(12, 85);
            this.tabPartsActions.Name = "tabPartsActions";
            this.tabPartsActions.SelectedIndex = 0;
            this.tabPartsActions.Size = new System.Drawing.Size(673, 273);
            this.tabPartsActions.TabIndex = 3;
            // 
            // tabLookUp
            // 
            this.tabLookUp.Controls.Add(this.lblQuery);
            this.tabLookUp.Location = new System.Drawing.Point(4, 23);
            this.tabLookUp.Name = "tabLookUp";
            this.tabLookUp.Padding = new System.Windows.Forms.Padding(3);
            this.tabLookUp.Size = new System.Drawing.Size(665, 246);
            this.tabLookUp.TabIndex = 0;
            this.tabLookUp.Text = "Look-Up";
            this.tabLookUp.UseVisualStyleBackColor = true;
            // 
            // lblQuery
            // 
            this.lblQuery.AutoSize = true;
            this.lblQuery.Location = new System.Drawing.Point(7, 7);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(65, 13);
            this.lblQuery.TabIndex = 0;
            this.lblQuery.Text = "Parts Query:";
            // 
            // tabInvoice
            // 
            this.tabInvoice.Location = new System.Drawing.Point(4, 23);
            this.tabInvoice.Name = "tabInvoice";
            this.tabInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tabInvoice.Size = new System.Drawing.Size(665, 246);
            this.tabInvoice.TabIndex = 1;
            this.tabInvoice.Text = "Invoice";
            this.tabInvoice.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 370);
            this.Controls.Add(this.tabPartsActions);
            this.Controls.Add(this.btnAcctsScreen);
            this.Controls.Add(this.btnPartsScreen);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.tabPartsActions.ResumeLayout(false);
            this.tabLookUp.ResumeLayout(false);
            this.tabLookUp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partsInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnPartsScreen;
        private System.Windows.Forms.Button btnAcctsScreen;
        private System.Windows.Forms.TabControl tabPartsActions;
        private System.Windows.Forms.TabPage tabLookUp;
        private System.Windows.Forms.TabPage tabInvoice;
        private System.Windows.Forms.Label lblQuery;

    }
}

