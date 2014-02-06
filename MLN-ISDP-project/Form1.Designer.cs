﻿namespace MLN_ISDP_project
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
            this.grpInfo = new System.Windows.Forms.GroupBox();
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
            this.tabInvoiceActions = new System.Windows.Forms.TabControl();
            this.tabInvoiceCreate = new System.Windows.Forms.TabPage();
            this.lstPartsInvoice = new System.Windows.Forms.DataGridView();
            this.lblInvoicePartsList = new System.Windows.Forms.Label();
            this.tabInvoiceHistory = new System.Windows.Forms.TabPage();
            this.grpOrderInfo = new System.Windows.Forms.GroupBox();
            this.grpCustInfo = new System.Windows.Forms.GroupBox();
            this.lblDepositPct = new System.Windows.Forms.Label();
            this.numDepositPct = new System.Windows.Forms.NumericUpDown();
            this.lblDepositPayAmt = new System.Windows.Forms.Label();
            this.txtDepositAmt = new System.Windows.Forms.TextBox();
            this.lblDepositRem = new System.Windows.Forms.Label();
            this.lblPartsTotal = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.txtDepositRem = new System.Windows.Forms.TextBox();
            this.txtPartsTotal = new System.Windows.Forms.TextBox();
            this.txtSalesTax = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDiscountType = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.btnAccountSearch = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cboDiscountType = new System.Windows.Forms.ComboBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPostal = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPostal = new System.Windows.Forms.TextBox();
            this.cboProvince = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClearInvoice = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.mnuMenu.SuspendLayout();
            this.tabPartsActions.SuspendLayout();
            this.tabLookUp.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.grpTotals.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstPartsQuery)).BeginInit();
            this.tabInvoice.SuspendLayout();
            this.tabInvoiceActions.SuspendLayout();
            this.tabInvoiceCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstPartsInvoice)).BeginInit();
            this.grpOrderInfo.SuspendLayout();
            this.grpCustInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDepositPct)).BeginInit();
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
            this.tabLookUp.Controls.Add(this.grpInfo);
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
            this.btnAddIndicated.Click += new System.EventHandler(this.btnAddIndicated_Click);
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
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblPartNum);
            this.grpInfo.Controls.Add(this.txtQOO);
            this.grpInfo.Controls.Add(this.txtPartNum);
            this.grpInfo.Controls.Add(this.lblQOO);
            this.grpInfo.Controls.Add(this.lblSection);
            this.grpInfo.Controls.Add(this.txtDescription);
            this.grpInfo.Controls.Add(this.txtSection);
            this.grpInfo.Controls.Add(this.lblDescription);
            this.grpInfo.Controls.Add(this.lblQOH);
            this.grpInfo.Controls.Add(this.txtQOH);
            this.grpInfo.Location = new System.Drawing.Point(10, 169);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(379, 115);
            this.grpInfo.TabIndex = 13;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Selected Item Information";
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
            this.lstPartsQuery.AllowUserToAddRows = false;
            this.lstPartsQuery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.lstPartsQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstPartsQuery.Location = new System.Drawing.Point(10, 24);
            this.lstPartsQuery.Name = "lstPartsQuery";
            this.lstPartsQuery.Size = new System.Drawing.Size(649, 139);
            this.lstPartsQuery.TabIndex = 1;
            this.lstPartsQuery.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstPartsQuery_CellClick);
            this.lstPartsQuery.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstPartsQuery_CellEndEdit);
            this.lstPartsQuery.CurrentCellDirtyStateChanged += new System.EventHandler(this.lstPartsQuery_CurrentCellDirtyStateChanged);
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
            this.tabInvoice.Controls.Add(this.tabInvoiceActions);
            this.tabInvoice.Location = new System.Drawing.Point(4, 23);
            this.tabInvoice.Name = "tabInvoice";
            this.tabInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tabInvoice.Size = new System.Drawing.Size(665, 373);
            this.tabInvoice.TabIndex = 1;
            this.tabInvoice.Text = "Invoicing";
            this.tabInvoice.UseVisualStyleBackColor = true;
            // 
            // tabInvoiceActions
            // 
            this.tabInvoiceActions.Controls.Add(this.tabInvoiceCreate);
            this.tabInvoiceActions.Controls.Add(this.tabInvoiceHistory);
            this.tabInvoiceActions.Location = new System.Drawing.Point(7, 7);
            this.tabInvoiceActions.Name = "tabInvoiceActions";
            this.tabInvoiceActions.SelectedIndex = 0;
            this.tabInvoiceActions.Size = new System.Drawing.Size(652, 360);
            this.tabInvoiceActions.TabIndex = 0;
            // 
            // tabInvoiceCreate
            // 
            this.tabInvoiceCreate.Controls.Add(this.btnComplete);
            this.tabInvoiceCreate.Controls.Add(this.btnClearInvoice);
            this.tabInvoiceCreate.Controls.Add(this.btnRemove);
            this.tabInvoiceCreate.Controls.Add(this.grpCustInfo);
            this.tabInvoiceCreate.Controls.Add(this.grpOrderInfo);
            this.tabInvoiceCreate.Controls.Add(this.lstPartsInvoice);
            this.tabInvoiceCreate.Controls.Add(this.lblInvoicePartsList);
            this.tabInvoiceCreate.Location = new System.Drawing.Point(4, 23);
            this.tabInvoiceCreate.Name = "tabInvoiceCreate";
            this.tabInvoiceCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tabInvoiceCreate.Size = new System.Drawing.Size(644, 333);
            this.tabInvoiceCreate.TabIndex = 0;
            this.tabInvoiceCreate.Text = "Create";
            this.tabInvoiceCreate.UseVisualStyleBackColor = true;
            // 
            // lstPartsInvoice
            // 
            this.lstPartsInvoice.AllowUserToAddRows = false;
            this.lstPartsInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.lstPartsInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstPartsInvoice.Location = new System.Drawing.Point(7, 24);
            this.lstPartsInvoice.Name = "lstPartsInvoice";
            this.lstPartsInvoice.Size = new System.Drawing.Size(631, 84);
            this.lstPartsInvoice.TabIndex = 1;
            this.lstPartsInvoice.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstPartsInvoice_CellEndEdit);
            // 
            // lblInvoicePartsList
            // 
            this.lblInvoicePartsList.AutoSize = true;
            this.lblInvoicePartsList.Location = new System.Drawing.Point(7, 7);
            this.lblInvoicePartsList.Name = "lblInvoicePartsList";
            this.lblInvoicePartsList.Size = new System.Drawing.Size(87, 13);
            this.lblInvoicePartsList.TabIndex = 0;
            this.lblInvoicePartsList.Text = "Parts on Invoice:";
            // 
            // tabInvoiceHistory
            // 
            this.tabInvoiceHistory.Location = new System.Drawing.Point(4, 23);
            this.tabInvoiceHistory.Name = "tabInvoiceHistory";
            this.tabInvoiceHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInvoiceHistory.Size = new System.Drawing.Size(644, 333);
            this.tabInvoiceHistory.TabIndex = 1;
            this.tabInvoiceHistory.Text = "History";
            this.tabInvoiceHistory.UseVisualStyleBackColor = true;
            // 
            // grpOrderInfo
            // 
            this.grpOrderInfo.Controls.Add(this.txtGrandTotal);
            this.grpOrderInfo.Controls.Add(this.txtSalesTax);
            this.grpOrderInfo.Controls.Add(this.txtPartsTotal);
            this.grpOrderInfo.Controls.Add(this.txtDepositRem);
            this.grpOrderInfo.Controls.Add(this.lblGrandTotal);
            this.grpOrderInfo.Controls.Add(this.lblSalesTax);
            this.grpOrderInfo.Controls.Add(this.lblPartsTotal);
            this.grpOrderInfo.Controls.Add(this.lblDepositRem);
            this.grpOrderInfo.Controls.Add(this.txtDepositAmt);
            this.grpOrderInfo.Controls.Add(this.lblDepositPayAmt);
            this.grpOrderInfo.Controls.Add(this.numDepositPct);
            this.grpOrderInfo.Controls.Add(this.lblDepositPct);
            this.grpOrderInfo.Location = new System.Drawing.Point(7, 114);
            this.grpOrderInfo.Name = "grpOrderInfo";
            this.grpOrderInfo.Size = new System.Drawing.Size(631, 63);
            this.grpOrderInfo.TabIndex = 2;
            this.grpOrderInfo.TabStop = false;
            this.grpOrderInfo.Text = "Order Information:";
            // 
            // grpCustInfo
            // 
            this.grpCustInfo.Controls.Add(this.cboProvince);
            this.grpCustInfo.Controls.Add(this.txtPostal);
            this.grpCustInfo.Controls.Add(this.txtCity);
            this.grpCustInfo.Controls.Add(this.txtEmail);
            this.grpCustInfo.Controls.Add(this.txtPhone);
            this.grpCustInfo.Controls.Add(this.lblProvince);
            this.grpCustInfo.Controls.Add(this.lblPostal);
            this.grpCustInfo.Controls.Add(this.lblCity);
            this.grpCustInfo.Controls.Add(this.lblEmail);
            this.grpCustInfo.Controls.Add(this.lblPhone);
            this.grpCustInfo.Controls.Add(this.cboDiscountType);
            this.grpCustInfo.Controls.Add(this.txtAddress);
            this.grpCustInfo.Controls.Add(this.txtLastName);
            this.grpCustInfo.Controls.Add(this.txtFirstName);
            this.grpCustInfo.Controls.Add(this.btnAccountSearch);
            this.grpCustInfo.Controls.Add(this.txtAccountNo);
            this.grpCustInfo.Controls.Add(this.lblDiscountType);
            this.grpCustInfo.Controls.Add(this.lblAddress);
            this.grpCustInfo.Controls.Add(this.lblLastName);
            this.grpCustInfo.Controls.Add(this.lblFirstName);
            this.grpCustInfo.Controls.Add(this.lblAccountNo);
            this.grpCustInfo.Location = new System.Drawing.Point(7, 181);
            this.grpCustInfo.Name = "grpCustInfo";
            this.grpCustInfo.Size = new System.Drawing.Size(631, 107);
            this.grpCustInfo.TabIndex = 3;
            this.grpCustInfo.TabStop = false;
            this.grpCustInfo.Text = "Customer Information:";
            // 
            // lblDepositPct
            // 
            this.lblDepositPct.AutoSize = true;
            this.lblDepositPct.Location = new System.Drawing.Point(7, 16);
            this.lblDepositPct.Name = "lblDepositPct";
            this.lblDepositPct.Size = new System.Drawing.Size(57, 13);
            this.lblDepositPct.TabIndex = 0;
            this.lblDepositPct.Text = "Deposit %:";
            // 
            // numDepositPct
            // 
            this.numDepositPct.Location = new System.Drawing.Point(10, 33);
            this.numDepositPct.Name = "numDepositPct";
            this.numDepositPct.Size = new System.Drawing.Size(54, 20);
            this.numDepositPct.TabIndex = 1;
            this.numDepositPct.Value = new decimal(new int[] {
            1000,
            0,
            0,
            131072});
            // 
            // lblDepositPayAmt
            // 
            this.lblDepositPayAmt.AutoSize = true;
            this.lblDepositPayAmt.Location = new System.Drawing.Point(91, 16);
            this.lblDepositPayAmt.Name = "lblDepositPayAmt";
            this.lblDepositPayAmt.Size = new System.Drawing.Size(106, 13);
            this.lblDepositPayAmt.TabIndex = 2;
            this.lblDepositPayAmt.Text = "Deposit Pay Amount:";
            // 
            // txtDepositAmt
            // 
            this.txtDepositAmt.Location = new System.Drawing.Point(94, 32);
            this.txtDepositAmt.Name = "txtDepositAmt";
            this.txtDepositAmt.Size = new System.Drawing.Size(103, 20);
            this.txtDepositAmt.TabIndex = 3;
            // 
            // lblDepositRem
            // 
            this.lblDepositRem.AutoSize = true;
            this.lblDepositRem.Location = new System.Drawing.Point(224, 16);
            this.lblDepositRem.Name = "lblDepositRem";
            this.lblDepositRem.Size = new System.Drawing.Size(99, 13);
            this.lblDepositRem.TabIndex = 4;
            this.lblDepositRem.Text = "Deposit Remaining:";
            // 
            // lblPartsTotal
            // 
            this.lblPartsTotal.AutoSize = true;
            this.lblPartsTotal.Location = new System.Drawing.Point(350, 16);
            this.lblPartsTotal.Name = "lblPartsTotal";
            this.lblPartsTotal.Size = new System.Drawing.Size(61, 13);
            this.lblPartsTotal.TabIndex = 5;
            this.lblPartsTotal.Text = "Parts Total:";
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.AutoSize = true;
            this.lblSalesTax.Location = new System.Drawing.Point(438, 16);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(86, 13);
            this.lblSalesTax.TabIndex = 6;
            this.lblSalesTax.Text = "Sales Tax (13%):";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(551, 16);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(61, 13);
            this.lblGrandTotal.TabIndex = 7;
            this.lblGrandTotal.Text = "Total Price:";
            // 
            // txtDepositRem
            // 
            this.txtDepositRem.Location = new System.Drawing.Point(227, 32);
            this.txtDepositRem.Name = "txtDepositRem";
            this.txtDepositRem.Size = new System.Drawing.Size(96, 20);
            this.txtDepositRem.TabIndex = 8;
            // 
            // txtPartsTotal
            // 
            this.txtPartsTotal.Location = new System.Drawing.Point(353, 32);
            this.txtPartsTotal.Name = "txtPartsTotal";
            this.txtPartsTotal.Size = new System.Drawing.Size(71, 20);
            this.txtPartsTotal.TabIndex = 9;
            // 
            // txtSalesTax
            // 
            this.txtSalesTax.Location = new System.Drawing.Point(441, 32);
            this.txtSalesTax.Name = "txtSalesTax";
            this.txtSalesTax.Size = new System.Drawing.Size(90, 20);
            this.txtSalesTax.TabIndex = 10;
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Location = new System.Drawing.Point(554, 32);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(71, 20);
            this.txtGrandTotal.TabIndex = 11;
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Location = new System.Drawing.Point(7, 20);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(90, 13);
            this.lblAccountNo.TabIndex = 0;
            this.lblAccountNo.Text = "Account Number:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(137, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(241, 20);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(345, 20);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address:";
            // 
            // lblDiscountType
            // 
            this.lblDiscountType.AutoSize = true;
            this.lblDiscountType.Location = new System.Drawing.Point(532, 20);
            this.lblDiscountType.Name = "lblDiscountType";
            this.lblDiscountType.Size = new System.Drawing.Size(79, 13);
            this.lblDiscountType.TabIndex = 4;
            this.lblDiscountType.Text = "Discount Type:";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(10, 37);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(69, 20);
            this.txtAccountNo.TabIndex = 5;
            // 
            // btnAccountSearch
            // 
            this.btnAccountSearch.Location = new System.Drawing.Point(81, 35);
            this.btnAccountSearch.Name = "btnAccountSearch";
            this.btnAccountSearch.Size = new System.Drawing.Size(21, 23);
            this.btnAccountSearch.TabIndex = 6;
            this.btnAccountSearch.UseVisualStyleBackColor = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(140, 37);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(73, 20);
            this.txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(244, 37);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(73, 20);
            this.txtLastName.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(348, 37);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(164, 20);
            this.txtAddress.TabIndex = 9;
            // 
            // cboDiscountType
            // 
            this.cboDiscountType.FormattingEnabled = true;
            this.cboDiscountType.Location = new System.Drawing.Point(535, 36);
            this.cboDiscountType.Name = "cboDiscountType";
            this.cboDiscountType.Size = new System.Drawing.Size(89, 21);
            this.cboDiscountType.TabIndex = 10;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(10, 64);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(88, 13);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Primary Phone #:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(140, 64);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(76, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email Address:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(345, 64);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 13;
            this.lblCity.Text = "City:";
            // 
            // lblPostal
            // 
            this.lblPostal.AutoSize = true;
            this.lblPostal.Location = new System.Drawing.Point(423, 64);
            this.lblPostal.Name = "lblPostal";
            this.lblPostal.Size = new System.Drawing.Size(67, 13);
            this.lblPostal.TabIndex = 14;
            this.lblPostal.Text = "Postal Code:";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(532, 64);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(52, 13);
            this.lblProvince.TabIndex = 15;
            this.lblProvince.Text = "Province:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(10, 81);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(143, 81);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(174, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(348, 81);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(63, 20);
            this.txtCity.TabIndex = 18;
            // 
            // txtPostal
            // 
            this.txtPostal.Location = new System.Drawing.Point(426, 81);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(86, 20);
            this.txtPostal.TabIndex = 19;
            // 
            // cboProvince
            // 
            this.cboProvince.FormattingEnabled = true;
            this.cboProvince.Location = new System.Drawing.Point(535, 81);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.Size = new System.Drawing.Size(89, 21);
            this.cboProvince.TabIndex = 20;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(11, 294);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(83, 33);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClearInvoice
            // 
            this.btnClearInvoice.Location = new System.Drawing.Point(101, 294);
            this.btnClearInvoice.Name = "btnClearInvoice";
            this.btnClearInvoice.Size = new System.Drawing.Size(83, 33);
            this.btnClearInvoice.TabIndex = 5;
            this.btnClearInvoice.Text = "Clear";
            this.btnClearInvoice.UseVisualStyleBackColor = true;
            this.btnClearInvoice.Click += new System.EventHandler(this.btnClearInvoice_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(533, 294);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(99, 33);
            this.btnComplete.TabIndex = 6;
            this.btnComplete.Text = "Complete Invoice";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
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
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstPartsQuery)).EndInit();
            this.tabInvoice.ResumeLayout(false);
            this.tabInvoiceActions.ResumeLayout(false);
            this.tabInvoiceCreate.ResumeLayout(false);
            this.tabInvoiceCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstPartsInvoice)).EndInit();
            this.grpOrderInfo.ResumeLayout(false);
            this.grpOrderInfo.PerformLayout();
            this.grpCustInfo.ResumeLayout(false);
            this.grpCustInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDepositPct)).EndInit();
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
        private System.Windows.Forms.GroupBox grpInfo;
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
        private System.Windows.Forms.TabControl tabInvoiceActions;
        private System.Windows.Forms.TabPage tabInvoiceCreate;
        private System.Windows.Forms.DataGridView lstPartsInvoice;
        private System.Windows.Forms.Label lblInvoicePartsList;
        private System.Windows.Forms.TabPage tabInvoiceHistory;
        private System.Windows.Forms.GroupBox grpCustInfo;
        private System.Windows.Forms.GroupBox grpOrderInfo;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.Label lblPartsTotal;
        private System.Windows.Forms.Label lblDepositRem;
        private System.Windows.Forms.TextBox txtDepositAmt;
        private System.Windows.Forms.Label lblDepositPayAmt;
        private System.Windows.Forms.NumericUpDown numDepositPct;
        private System.Windows.Forms.Label lblDepositPct;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.TextBox txtPartsTotal;
        private System.Windows.Forms.TextBox txtDepositRem;
        private System.Windows.Forms.Label lblDiscountType;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnAccountSearch;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.ComboBox cboDiscountType;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.ComboBox cboProvince;
        private System.Windows.Forms.TextBox txtPostal;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblPostal;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnClearInvoice;
        private System.Windows.Forms.Button btnRemove;

    }
}

