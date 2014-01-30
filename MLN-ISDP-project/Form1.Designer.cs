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
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnAddIndicated = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSetInvoice = new System.Windows.Forms.Button();
            this.btnSetOrder = new System.Windows.Forms.Button();
            this.btnAddParts = new System.Windows.Forms.Button();
            this.btnLoadParts = new System.Windows.Forms.Button();
            this.grpTotals = new System.Windows.Forms.GroupBox();
            this.txtInvList = new System.Windows.Forms.TextBox();
            this.lblInvList = new System.Windows.Forms.Label();
            this.txtInvCost = new System.Windows.Forms.TextBox();
            this.lblInvCost = new System.Windows.Forms.Label();
            this.txtOrderList = new System.Windows.Forms.TextBox();
            this.lblOrderList = new System.Windows.Forms.Label();
            this.txtOrderCost = new System.Windows.Forms.TextBox();
            this.lblOrderCost = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPartNum = new System.Windows.Forms.Label();
            this.txtQOO = new System.Windows.Forms.TextBox();
            this.txtPartNum = new System.Windows.Forms.TextBox();
            this.lblQOO = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblQOH = new System.Windows.Forms.Label();
            this.txtQOH = new System.Windows.Forms.TextBox();
            this.lstPartsQuery = new System.Windows.Forms.DataGridView();
            this.lblQuery = new System.Windows.Forms.Label();
            this.tabInvoice = new System.Windows.Forms.TabPage();
            this.mnuMenu.SuspendLayout();
            this.tabPartsActions.SuspendLayout();
            this.tabLookUp.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.grpTotals.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstPartsQuery)).BeginInit();
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
            this.tabPartsActions.Size = new System.Drawing.Size(673, 400);
            this.tabPartsActions.TabIndex = 3;
            // 
            // tabLookUp
            // 
            this.tabLookUp.Controls.Add(this.grpActions);
            this.tabLookUp.Controls.Add(this.grpTotals);
            this.tabLookUp.Controls.Add(this.groupBox1);
            this.tabLookUp.Controls.Add(this.lstPartsQuery);
            this.tabLookUp.Controls.Add(this.lblQuery);
            this.tabLookUp.Location = new System.Drawing.Point(4, 23);
            this.tabLookUp.Name = "tabLookUp";
            this.tabLookUp.Padding = new System.Windows.Forms.Padding(3);
            this.tabLookUp.Size = new System.Drawing.Size(665, 373);
            this.tabLookUp.TabIndex = 0;
            this.tabLookUp.Text = "Look-Up";
            this.tabLookUp.UseVisualStyleBackColor = true;
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.btnAddIndicated);
            this.grpActions.Controls.Add(this.btnClear);
            this.grpActions.Controls.Add(this.btnSetInvoice);
            this.grpActions.Controls.Add(this.btnSetOrder);
            this.grpActions.Controls.Add(this.btnAddParts);
            this.grpActions.Controls.Add(this.btnLoadParts);
            this.grpActions.Location = new System.Drawing.Point(10, 290);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(649, 77);
            this.grpActions.TabIndex = 15;
            this.grpActions.TabStop = false;
            // 
            // btnAddIndicated
            // 
            this.btnAddIndicated.Location = new System.Drawing.Point(568, 16);
            this.btnAddIndicated.Name = "btnAddIndicated";
            this.btnAddIndicated.Size = new System.Drawing.Size(75, 51);
            this.btnAddIndicated.TabIndex = 5;
            this.btnAddIndicated.Text = "Add Parts Indicated";
            this.btnAddIndicated.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(336, 16);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 51);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSetInvoice
            // 
            this.btnSetInvoice.Location = new System.Drawing.Point(255, 16);
            this.btnSetInvoice.Name = "btnSetInvoice";
            this.btnSetInvoice.Size = new System.Drawing.Size(75, 51);
            this.btnSetInvoice.TabIndex = 3;
            this.btnSetInvoice.Text = "Set All to Invoice";
            this.btnSetInvoice.UseVisualStyleBackColor = true;
            this.btnSetInvoice.Click += new System.EventHandler(this.btnSetInvoice_Click);
            // 
            // btnSetOrder
            // 
            this.btnSetOrder.Location = new System.Drawing.Point(174, 16);
            this.btnSetOrder.Name = "btnSetOrder";
            this.btnSetOrder.Size = new System.Drawing.Size(75, 51);
            this.btnSetOrder.TabIndex = 2;
            this.btnSetOrder.Text = "Set All to Order";
            this.btnSetOrder.UseVisualStyleBackColor = true;
            this.btnSetOrder.Click += new System.EventHandler(this.btnSetOrder_Click);
            // 
            // btnAddParts
            // 
            this.btnAddParts.Location = new System.Drawing.Point(93, 16);
            this.btnAddParts.Name = "btnAddParts";
            this.btnAddParts.Size = new System.Drawing.Size(75, 51);
            this.btnAddParts.TabIndex = 1;
            this.btnAddParts.Text = "Add Part";
            this.btnAddParts.UseVisualStyleBackColor = true;
            this.btnAddParts.Click += new System.EventHandler(this.btnAddParts_Click);
            // 
            // btnLoadParts
            // 
            this.btnLoadParts.Location = new System.Drawing.Point(12, 16);
            this.btnLoadParts.Name = "btnLoadParts";
            this.btnLoadParts.Size = new System.Drawing.Size(75, 51);
            this.btnLoadParts.TabIndex = 0;
            this.btnLoadParts.Text = "Load Parts File";
            this.btnLoadParts.UseVisualStyleBackColor = true;
            this.btnLoadParts.Click += new System.EventHandler(this.btnLoadParts_Click);
            // 
            // grpTotals
            // 
            this.grpTotals.Controls.Add(this.txtInvList);
            this.grpTotals.Controls.Add(this.lblInvList);
            this.grpTotals.Controls.Add(this.txtInvCost);
            this.grpTotals.Controls.Add(this.lblInvCost);
            this.grpTotals.Controls.Add(this.txtOrderList);
            this.grpTotals.Controls.Add(this.lblOrderList);
            this.grpTotals.Controls.Add(this.txtOrderCost);
            this.grpTotals.Controls.Add(this.lblOrderCost);
            this.grpTotals.Location = new System.Drawing.Point(396, 170);
            this.grpTotals.Name = "grpTotals";
            this.grpTotals.Size = new System.Drawing.Size(263, 114);
            this.grpTotals.TabIndex = 14;
            this.grpTotals.TabStop = false;
            this.grpTotals.Text = "Indicated Item(s) Totals ($)";
            // 
            // txtInvList
            // 
            this.txtInvList.Location = new System.Drawing.Point(138, 78);
            this.txtInvList.Name = "txtInvList";
            this.txtInvList.Size = new System.Drawing.Size(100, 20);
            this.txtInvList.TabIndex = 7;
            // 
            // lblInvList
            // 
            this.lblInvList.AutoSize = true;
            this.lblInvList.Location = new System.Drawing.Point(135, 62);
            this.lblInvList.Name = "lblInvList";
            this.lblInvList.Size = new System.Drawing.Size(64, 13);
            this.lblInvList.TabIndex = 6;
            this.lblInvList.Text = "Invoice List:";
            // 
            // txtInvCost
            // 
            this.txtInvCost.Location = new System.Drawing.Point(13, 78);
            this.txtInvCost.Name = "txtInvCost";
            this.txtInvCost.Size = new System.Drawing.Size(100, 20);
            this.txtInvCost.TabIndex = 5;
            // 
            // lblInvCost
            // 
            this.lblInvCost.AutoSize = true;
            this.lblInvCost.Location = new System.Drawing.Point(10, 62);
            this.lblInvCost.Name = "lblInvCost";
            this.lblInvCost.Size = new System.Drawing.Size(69, 13);
            this.lblInvCost.TabIndex = 4;
            this.lblInvCost.Text = "Invoice Cost:";
            // 
            // txtOrderList
            // 
            this.txtOrderList.Location = new System.Drawing.Point(135, 32);
            this.txtOrderList.Name = "txtOrderList";
            this.txtOrderList.Size = new System.Drawing.Size(100, 20);
            this.txtOrderList.TabIndex = 3;
            // 
            // lblOrderList
            // 
            this.lblOrderList.AutoSize = true;
            this.lblOrderList.Location = new System.Drawing.Point(132, 15);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(55, 13);
            this.lblOrderList.TabIndex = 2;
            this.lblOrderList.Text = "Order List:";
            // 
            // txtOrderCost
            // 
            this.txtOrderCost.Location = new System.Drawing.Point(10, 32);
            this.txtOrderCost.Name = "txtOrderCost";
            this.txtOrderCost.Size = new System.Drawing.Size(100, 20);
            this.txtOrderCost.TabIndex = 1;
            // 
            // lblOrderCost
            // 
            this.lblOrderCost.AutoSize = true;
            this.lblOrderCost.Location = new System.Drawing.Point(7, 15);
            this.lblOrderCost.Name = "lblOrderCost";
            this.lblOrderCost.Size = new System.Drawing.Size(60, 13);
            this.lblOrderCost.TabIndex = 0;
            this.lblOrderCost.Text = "Order Cost:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPartNum);
            this.groupBox1.Controls.Add(this.txtQOO);
            this.groupBox1.Controls.Add(this.txtPartNum);
            this.groupBox1.Controls.Add(this.lblQOO);
            this.groupBox1.Controls.Add(this.lblSection);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtSection);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.lblQOH);
            this.groupBox1.Controls.Add(this.txtQOH);
            this.groupBox1.Location = new System.Drawing.Point(10, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 115);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Item Information";
            // 
            // lblPartNum
            // 
            this.lblPartNum.AutoSize = true;
            this.lblPartNum.Location = new System.Drawing.Point(6, 16);
            this.lblPartNum.Name = "lblPartNum";
            this.lblPartNum.Size = new System.Drawing.Size(54, 13);
            this.lblPartNum.TabIndex = 3;
            this.lblPartNum.Text = "Part Num:";
            // 
            // txtQOO
            // 
            this.txtQOO.Location = new System.Drawing.Point(271, 79);
            this.txtQOO.Name = "txtQOO";
            this.txtQOO.Size = new System.Drawing.Size(100, 20);
            this.txtQOO.TabIndex = 12;
            // 
            // txtPartNum
            // 
            this.txtPartNum.Location = new System.Drawing.Point(9, 32);
            this.txtPartNum.Name = "txtPartNum";
            this.txtPartNum.Size = new System.Drawing.Size(100, 20);
            this.txtPartNum.TabIndex = 4;
            // 
            // lblQOO
            // 
            this.lblQOO.AutoSize = true;
            this.lblQOO.Location = new System.Drawing.Point(268, 63);
            this.lblQOO.Name = "lblQOO";
            this.lblQOO.Size = new System.Drawing.Size(95, 13);
            this.lblQOO.TabIndex = 11;
            this.lblQOO.Text = "Quantity On Order:";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(137, 16);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(46, 13);
            this.lblSection.TabIndex = 5;
            this.lblSection.Text = "Section:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 80);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 10;
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(140, 32);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(100, 20);
            this.txtSection.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(9, 63);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description:";
            // 
            // lblQOH
            // 
            this.lblQOH.AutoSize = true;
            this.lblQOH.Location = new System.Drawing.Point(268, 16);
            this.lblQOH.Name = "lblQOH";
            this.lblQOH.Size = new System.Drawing.Size(95, 13);
            this.lblQOH.TabIndex = 7;
            this.lblQOH.Text = "Quantity On Hand:";
            // 
            // txtQOH
            // 
            this.txtQOH.Location = new System.Drawing.Point(271, 32);
            this.txtQOH.Name = "txtQOH";
            this.txtQOH.Size = new System.Drawing.Size(100, 20);
            this.txtQOH.TabIndex = 8;
            // 
            // lstPartsQuery
            // 
            this.lstPartsQuery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.lstPartsQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstPartsQuery.Location = new System.Drawing.Point(10, 24);
            this.lstPartsQuery.Name = "lstPartsQuery";
            this.lstPartsQuery.Size = new System.Drawing.Size(649, 139);
            this.lstPartsQuery.TabIndex = 1;
            this.lstPartsQuery.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstPartsQuery_CellClick);
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
            this.tabInvoice.Size = new System.Drawing.Size(665, 373);
            this.tabInvoice.TabIndex = 1;
            this.tabInvoice.Text = "Invoice";
            this.tabInvoice.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 497);
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
            this.grpActions.ResumeLayout(false);
            this.grpTotals.ResumeLayout(false);
            this.grpTotals.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstPartsQuery)).EndInit();
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
        private System.Windows.Forms.DataGridView lstPartsQuery;
        private System.Windows.Forms.Label lblPartNum;
        private System.Windows.Forms.TextBox txtPartNum;
        private System.Windows.Forms.TextBox txtQOH;
        private System.Windows.Forms.Label lblQOH;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.TextBox txtQOO;
        private System.Windows.Forms.Label lblQOO;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.GroupBox grpTotals;
        private System.Windows.Forms.TextBox txtOrderCost;
        private System.Windows.Forms.Label lblOrderCost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOrderList;
        private System.Windows.Forms.Label lblOrderList;
        private System.Windows.Forms.Label lblInvCost;
        private System.Windows.Forms.TextBox txtInvCost;
        private System.Windows.Forms.TextBox txtInvList;
        private System.Windows.Forms.Label lblInvList;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnLoadParts;
        private System.Windows.Forms.Button btnAddIndicated;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSetInvoice;
        private System.Windows.Forms.Button btnSetOrder;
        private System.Windows.Forms.Button btnAddParts;

    }
}

