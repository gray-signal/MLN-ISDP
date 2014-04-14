namespace MLN_ISDP_project
{
    partial class frmServiceWorkOrder
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceWorkOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCreate = new System.Windows.Forms.TabPage();
            this.grpServiceInfo = new System.Windows.Forms.GroupBox();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.btnNewTask = new System.Windows.Forms.Button();
            this.lstTasks = new System.Windows.Forms.DataGridView();
            this.btnRemoveTech = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lstTechnicians = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblTechnicianList = new System.Windows.Forms.Label();
            this.btnAddTech = new System.Windows.Forms.Button();
            this.cboAssign = new System.Windows.Forms.ComboBox();
            this.lblAssign = new System.Windows.Forms.Label();
            this.grpWorkInfo = new System.Windows.Forms.GroupBox();
            this.numKmOut = new System.Windows.Forms.NumericUpDown();
            this.lblKmOut = new System.Windows.Forms.Label();
            this.numKmIn = new System.Windows.Forms.NumericUpDown();
            this.lblKmIn = new System.Windows.Forms.Label();
            this.numRate = new System.Windows.Forms.NumericUpDown();
            this.lblRate = new System.Windows.Forms.Label();
            this.dtpPromised = new System.Windows.Forms.DateTimePicker();
            this.lblPromised = new System.Windows.Forms.Label();
            this.grpVehicleInfo = new System.Windows.Forms.GroupBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtPlateNum = new System.Windows.Forms.TextBox();
            this.lblPlateNum = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.lblColour = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtVin = new System.Windows.Forms.TextBox();
            this.lblVin = new System.Windows.Forms.Label();
            this.grpCxInfo = new System.Windows.Forms.GroupBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.txtCxLastName = new System.Windows.Forms.TextBox();
            this.lblCxLastName = new System.Windows.Forms.Label();
            this.txtCxFirstName = new System.Windows.Forms.TextBox();
            this.lblCxFirstName = new System.Windows.Forms.Label();
            this.txtCxNum = new System.Windows.Forms.TextBox();
            this.lblCxNum = new System.Windows.Forms.Label();
            this.cboVehicle = new System.Windows.Forms.ComboBox();
            this.lblSelectVehicle = new System.Windows.Forms.Label();
            this.btnCxSearch = new System.Windows.Forms.Button();
            this.txtCxNameSearch = new System.Windows.Forms.TextBox();
            this.lblCxSearch = new System.Windows.Forms.Label();
            this.tabView = new System.Windows.Forms.TabPage();
            this.grpFilters = new System.Windows.Forms.GroupBox();
            this.btnFilPickup = new System.Windows.Forms.Button();
            this.btnFilService = new System.Windows.Forms.Button();
            this.btnFilHold = new System.Windows.Forms.Button();
            this.btnFilUnassigned = new System.Windows.Forms.Button();
            this.btnFilAll = new System.Windows.Forms.Button();
            this.lstWorkOrders = new System.Windows.Forms.DataGridView();
            this.grpViewActions = new System.Windows.Forms.GroupBox();
            this.btnCompleteSelected = new System.Windows.Forms.Button();
            this.btnDischargeSelected = new System.Windows.Forms.Button();
            this.btnResumeSelected = new System.Windows.Forms.Button();
            this.btnHoldSelected = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.btnViewSelected = new System.Windows.Forms.Button();
            this.tabViewTechTasks = new System.Windows.Forms.TabPage();
            this.grpTechSummary = new System.Windows.Forms.GroupBox();
            this.txtTotalWorkOrders = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalTasks = new System.Windows.Forms.TextBox();
            this.txtTotalTime = new System.Windows.Forms.TextBox();
            this.cboTechs = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstTechTasks = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCreate.SuspendLayout();
            this.grpServiceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstTasks)).BeginInit();
            this.grpWorkInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKmOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKmIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).BeginInit();
            this.grpVehicleInfo.SuspendLayout();
            this.grpCxInfo.SuspendLayout();
            this.tabView.SuspendLayout();
            this.grpFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstWorkOrders)).BeginInit();
            this.grpViewActions.SuspendLayout();
            this.tabViewTechTasks.SuspendLayout();
            this.grpTechSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstTechTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.serviceWorkOrderToolStripMenuItem,
            this.accountsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // serviceWorkOrderToolStripMenuItem
            // 
            this.serviceWorkOrderToolStripMenuItem.Name = "serviceWorkOrderToolStripMenuItem";
            this.serviceWorkOrderToolStripMenuItem.Size = new System.Drawing.Size(138, 21);
            this.serviceWorkOrderToolStripMenuItem.Text = "&Service Work Order";
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.accountsToolStripMenuItem.Text = "&Accounts";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.aboutToolStripMenuItem.Text = "Abou&t";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCreate);
            this.tabControl1.Controls.Add(this.tabView);
            this.tabControl1.Controls.Add(this.tabViewTechTasks);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 585);
            this.tabControl1.TabIndex = 3;
            // 
            // tabCreate
            // 
            this.tabCreate.Controls.Add(this.grpServiceInfo);
            this.tabCreate.Controls.Add(this.grpWorkInfo);
            this.tabCreate.Controls.Add(this.grpVehicleInfo);
            this.tabCreate.Controls.Add(this.grpCxInfo);
            this.tabCreate.Controls.Add(this.btnReset);
            this.tabCreate.Controls.Add(this.cboVehicle);
            this.tabCreate.Controls.Add(this.lblSelectVehicle);
            this.tabCreate.Controls.Add(this.btnCxSearch);
            this.tabCreate.Controls.Add(this.btnCreate);
            this.tabCreate.Controls.Add(this.txtCxNameSearch);
            this.tabCreate.Controls.Add(this.lblCxSearch);
            this.tabCreate.Location = new System.Drawing.Point(4, 23);
            this.tabCreate.Name = "tabCreate";
            this.tabCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreate.Size = new System.Drawing.Size(749, 558);
            this.tabCreate.TabIndex = 0;
            this.tabCreate.Text = "Create";
            this.tabCreate.UseVisualStyleBackColor = true;
            // 
            // grpServiceInfo
            // 
            this.grpServiceInfo.Controls.Add(this.btnRemoveTask);
            this.grpServiceInfo.Controls.Add(this.btnNewTask);
            this.grpServiceInfo.Controls.Add(this.lstTasks);
            this.grpServiceInfo.Controls.Add(this.btnRemoveTech);
            this.grpServiceInfo.Controls.Add(this.lstTechnicians);
            this.grpServiceInfo.Controls.Add(this.lblTechnicianList);
            this.grpServiceInfo.Controls.Add(this.btnAddTech);
            this.grpServiceInfo.Controls.Add(this.cboAssign);
            this.grpServiceInfo.Controls.Add(this.lblAssign);
            this.grpServiceInfo.Location = new System.Drawing.Point(10, 307);
            this.grpServiceInfo.Name = "grpServiceInfo";
            this.grpServiceInfo.Size = new System.Drawing.Size(733, 245);
            this.grpServiceInfo.TabIndex = 13;
            this.grpServiceInfo.TabStop = false;
            this.grpServiceInfo.Text = "Service Information";
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Location = new System.Drawing.Point(634, 19);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(93, 38);
            this.btnRemoveTask.TabIndex = 18;
            this.btnRemoveTask.Text = "Delete Task";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click_1);
            // 
            // btnNewTask
            // 
            this.btnNewTask.Location = new System.Drawing.Point(541, 19);
            this.btnNewTask.Name = "btnNewTask";
            this.btnNewTask.Size = new System.Drawing.Size(87, 38);
            this.btnNewTask.TabIndex = 17;
            this.btnNewTask.Text = "New Task";
            this.btnNewTask.UseVisualStyleBackColor = true;
            this.btnNewTask.Click += new System.EventHandler(this.btnNewTask_Click);
            // 
            // lstTasks
            // 
            this.lstTasks.AllowUserToAddRows = false;
            this.lstTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lstTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstTasks.Location = new System.Drawing.Point(6, 19);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(526, 220);
            this.lstTasks.TabIndex = 16;
            this.lstTasks.SelectionChanged += new System.EventHandler(this.lstTasks_SelectionChanged);
            // 
            // btnRemoveTech
            // 
            this.btnRemoveTech.Location = new System.Drawing.Point(634, 115);
            this.btnRemoveTech.Name = "btnRemoveTech";
            this.btnRemoveTech.Size = new System.Drawing.Size(93, 23);
            this.btnRemoveTech.TabIndex = 14;
            this.btnRemoveTech.Text = "Remove Tech";
            this.btnRemoveTech.UseVisualStyleBackColor = true;
            this.btnRemoveTech.Click += new System.EventHandler(this.btnRemoveTech_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(551, 7);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 38);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lstTechnicians
            // 
            this.lstTechnicians.FormattingEnabled = true;
            this.lstTechnicians.Location = new System.Drawing.Point(541, 157);
            this.lstTechnicians.Name = "lstTechnicians";
            this.lstTechnicians.Size = new System.Drawing.Size(186, 82);
            this.lstTechnicians.TabIndex = 13;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(644, 7);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(93, 37);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Create Work Order";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblTechnicianList
            // 
            this.lblTechnicianList.AutoSize = true;
            this.lblTechnicianList.Location = new System.Drawing.Point(538, 141);
            this.lblTechnicianList.Name = "lblTechnicianList";
            this.lblTechnicianList.Size = new System.Drawing.Size(120, 13);
            this.lblTechnicianList.TabIndex = 12;
            this.lblTechnicianList.Text = "Assigned Technician(s):";
            // 
            // btnAddTech
            // 
            this.btnAddTech.Location = new System.Drawing.Point(541, 116);
            this.btnAddTech.Name = "btnAddTech";
            this.btnAddTech.Size = new System.Drawing.Size(87, 23);
            this.btnAddTech.TabIndex = 11;
            this.btnAddTech.Text = "Add Tech";
            this.btnAddTech.UseVisualStyleBackColor = true;
            this.btnAddTech.Click += new System.EventHandler(this.btnAddTech_Click);
            // 
            // cboAssign
            // 
            this.cboAssign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAssign.FormattingEnabled = true;
            this.cboAssign.Items.AddRange(new object[] {
            "Eduardo Concepcion",
            "Raymond Roach",
            "Will McAvoy",
            "Sarah White"});
            this.cboAssign.Location = new System.Drawing.Point(541, 91);
            this.cboAssign.Name = "cboAssign";
            this.cboAssign.Size = new System.Drawing.Size(186, 21);
            this.cboAssign.TabIndex = 10;
            // 
            // lblAssign
            // 
            this.lblAssign.AutoSize = true;
            this.lblAssign.Location = new System.Drawing.Point(541, 75);
            this.lblAssign.Name = "lblAssign";
            this.lblAssign.Size = new System.Drawing.Size(68, 13);
            this.lblAssign.TabIndex = 9;
            this.lblAssign.Text = "Technicians:";
            // 
            // grpWorkInfo
            // 
            this.grpWorkInfo.Controls.Add(this.numKmOut);
            this.grpWorkInfo.Controls.Add(this.lblKmOut);
            this.grpWorkInfo.Controls.Add(this.numKmIn);
            this.grpWorkInfo.Controls.Add(this.lblKmIn);
            this.grpWorkInfo.Controls.Add(this.numRate);
            this.grpWorkInfo.Controls.Add(this.lblRate);
            this.grpWorkInfo.Controls.Add(this.dtpPromised);
            this.grpWorkInfo.Controls.Add(this.lblPromised);
            this.grpWorkInfo.Location = new System.Drawing.Point(10, 240);
            this.grpWorkInfo.Name = "grpWorkInfo";
            this.grpWorkInfo.Size = new System.Drawing.Size(733, 61);
            this.grpWorkInfo.TabIndex = 7;
            this.grpWorkInfo.TabStop = false;
            this.grpWorkInfo.Text = "Work Order Information";
            // 
            // numKmOut
            // 
            this.numKmOut.Location = new System.Drawing.Point(332, 33);
            this.numKmOut.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numKmOut.Name = "numKmOut";
            this.numKmOut.Size = new System.Drawing.Size(75, 20);
            this.numKmOut.TabIndex = 7;
            // 
            // lblKmOut
            // 
            this.lblKmOut.AutoSize = true;
            this.lblKmOut.Location = new System.Drawing.Point(329, 16);
            this.lblKmOut.Name = "lblKmOut";
            this.lblKmOut.Size = new System.Drawing.Size(78, 13);
            this.lblKmOut.TabIndex = 6;
            this.lblKmOut.Text = "Kilometers Out:";
            // 
            // numKmIn
            // 
            this.numKmIn.Location = new System.Drawing.Point(236, 33);
            this.numKmIn.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numKmIn.Name = "numKmIn";
            this.numKmIn.Size = new System.Drawing.Size(67, 20);
            this.numKmIn.TabIndex = 5;
            // 
            // lblKmIn
            // 
            this.lblKmIn.AutoSize = true;
            this.lblKmIn.Location = new System.Drawing.Point(233, 16);
            this.lblKmIn.Name = "lblKmIn";
            this.lblKmIn.Size = new System.Drawing.Size(70, 13);
            this.lblKmIn.TabIndex = 4;
            this.lblKmIn.Text = "Kilometers In:";
            // 
            // numRate
            // 
            this.numRate.DecimalPlaces = 2;
            this.numRate.Location = new System.Drawing.Point(153, 33);
            this.numRate.Name = "numRate";
            this.numRate.Size = new System.Drawing.Size(57, 20);
            this.numRate.TabIndex = 3;
            this.numRate.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(150, 16);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(30, 13);
            this.lblRate.TabIndex = 2;
            this.lblRate.Text = "Rate";
            // 
            // dtpPromised
            // 
            this.dtpPromised.CustomFormat = "dd MMM yyyy - hh:mm tt";
            this.dtpPromised.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPromised.Location = new System.Drawing.Point(6, 32);
            this.dtpPromised.Name = "dtpPromised";
            this.dtpPromised.ShowUpDown = true;
            this.dtpPromised.Size = new System.Drawing.Size(139, 20);
            this.dtpPromised.TabIndex = 1;
            this.dtpPromised.Value = new System.DateTime(2014, 3, 19, 13, 30, 0, 0);
            this.dtpPromised.ValueChanged += new System.EventHandler(this.dtpPromised_ValueChanged);
            // 
            // lblPromised
            // 
            this.lblPromised.AutoSize = true;
            this.lblPromised.Location = new System.Drawing.Point(6, 16);
            this.lblPromised.Name = "lblPromised";
            this.lblPromised.Size = new System.Drawing.Size(79, 13);
            this.lblPromised.TabIndex = 0;
            this.lblPromised.Text = "Promised Time:";
            // 
            // grpVehicleInfo
            // 
            this.grpVehicleInfo.Controls.Add(this.txtYear);
            this.grpVehicleInfo.Controls.Add(this.txtPlateNum);
            this.grpVehicleInfo.Controls.Add(this.lblPlateNum);
            this.grpVehicleInfo.Controls.Add(this.lblYear);
            this.grpVehicleInfo.Controls.Add(this.txtColour);
            this.grpVehicleInfo.Controls.Add(this.lblColour);
            this.grpVehicleInfo.Controls.Add(this.txtModel);
            this.grpVehicleInfo.Controls.Add(this.lblModel);
            this.grpVehicleInfo.Controls.Add(this.txtVin);
            this.grpVehicleInfo.Controls.Add(this.lblVin);
            this.grpVehicleInfo.Location = new System.Drawing.Point(10, 171);
            this.grpVehicleInfo.Name = "grpVehicleInfo";
            this.grpVehicleInfo.Size = new System.Drawing.Size(733, 63);
            this.grpVehicleInfo.TabIndex = 6;
            this.grpVehicleInfo.TabStop = false;
            this.grpVehicleInfo.Text = "Vehicle Information";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(351, 32);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(55, 20);
            this.txtYear.TabIndex = 14;
            // 
            // txtPlateNum
            // 
            this.txtPlateNum.Location = new System.Drawing.Point(425, 32);
            this.txtPlateNum.Name = "txtPlateNum";
            this.txtPlateNum.ReadOnly = true;
            this.txtPlateNum.Size = new System.Drawing.Size(100, 20);
            this.txtPlateNum.TabIndex = 11;
            // 
            // lblPlateNum
            // 
            this.lblPlateNum.AutoSize = true;
            this.lblPlateNum.Location = new System.Drawing.Point(422, 16);
            this.lblPlateNum.Name = "lblPlateNum";
            this.lblPlateNum.Size = new System.Drawing.Size(44, 13);
            this.lblPlateNum.TabIndex = 10;
            this.lblPlateNum.Text = "Plate #:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(348, 16);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Year";
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(236, 32);
            this.txtColour.Name = "txtColour";
            this.txtColour.ReadOnly = true;
            this.txtColour.Size = new System.Drawing.Size(100, 20);
            this.txtColour.TabIndex = 7;
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(233, 16);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(40, 13);
            this.lblColour.TabIndex = 6;
            this.lblColour.Text = "Colour:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(144, 32);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(85, 20);
            this.txtModel.TabIndex = 3;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(141, 16);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model:";
            // 
            // txtVin
            // 
            this.txtVin.Location = new System.Drawing.Point(6, 32);
            this.txtVin.Name = "txtVin";
            this.txtVin.ReadOnly = true;
            this.txtVin.Size = new System.Drawing.Size(125, 20);
            this.txtVin.TabIndex = 1;
            // 
            // lblVin
            // 
            this.lblVin.AutoSize = true;
            this.lblVin.Location = new System.Drawing.Point(7, 16);
            this.lblVin.Name = "lblVin";
            this.lblVin.Size = new System.Drawing.Size(25, 13);
            this.lblVin.TabIndex = 0;
            this.lblVin.Text = "Vin:";
            // 
            // grpCxInfo
            // 
            this.grpCxInfo.Controls.Add(this.txtProvince);
            this.grpCxInfo.Controls.Add(this.lblProvince);
            this.grpCxInfo.Controls.Add(this.txtCity);
            this.grpCxInfo.Controls.Add(this.lblCity);
            this.grpCxInfo.Controls.Add(this.txtAddress);
            this.grpCxInfo.Controls.Add(this.lblAddress);
            this.grpCxInfo.Controls.Add(this.txtPostCode);
            this.grpCxInfo.Controls.Add(this.lblPostCode);
            this.grpCxInfo.Controls.Add(this.txtEmail);
            this.grpCxInfo.Controls.Add(this.lblEmail);
            this.grpCxInfo.Controls.Add(this.txtHomePhone);
            this.grpCxInfo.Controls.Add(this.lblHomePhone);
            this.grpCxInfo.Controls.Add(this.txtCxLastName);
            this.grpCxInfo.Controls.Add(this.lblCxLastName);
            this.grpCxInfo.Controls.Add(this.txtCxFirstName);
            this.grpCxInfo.Controls.Add(this.lblCxFirstName);
            this.grpCxInfo.Controls.Add(this.txtCxNum);
            this.grpCxInfo.Controls.Add(this.lblCxNum);
            this.grpCxInfo.Location = new System.Drawing.Point(10, 51);
            this.grpCxInfo.Name = "grpCxInfo";
            this.grpCxInfo.Size = new System.Drawing.Size(733, 114);
            this.grpCxInfo.TabIndex = 5;
            this.grpCxInfo.TabStop = false;
            this.grpCxInfo.Text = "Customer Information:";
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(351, 76);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.ReadOnly = true;
            this.txtProvince.Size = new System.Drawing.Size(100, 20);
            this.txtProvince.TabIndex = 17;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(348, 58);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(49, 13);
            this.lblProvince.TabIndex = 16;
            this.lblProvince.Text = "Province";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(236, 76);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 15;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(233, 58);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 14;
            this.lblCity.Text = "City:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(120, 76);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 13;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(117, 59);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(79, 13);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Street Address:";
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(6, 76);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.ReadOnly = true;
            this.txtPostCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostCode.TabIndex = 11;
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(6, 59);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(67, 13);
            this.lblPostCode.TabIndex = 10;
            this.lblPostCode.Text = "Postal Code:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(460, 30);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(152, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(457, 16);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(351, 31);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.ReadOnly = true;
            this.txtHomePhone.Size = new System.Drawing.Size(100, 20);
            this.txtHomePhone.TabIndex = 7;
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(348, 16);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(72, 13);
            this.lblHomePhone.TabIndex = 6;
            this.lblHomePhone.Text = "Home Phone:";
            // 
            // txtCxLastName
            // 
            this.txtCxLastName.Location = new System.Drawing.Point(236, 31);
            this.txtCxLastName.Name = "txtCxLastName";
            this.txtCxLastName.ReadOnly = true;
            this.txtCxLastName.Size = new System.Drawing.Size(100, 20);
            this.txtCxLastName.TabIndex = 5;
            // 
            // lblCxLastName
            // 
            this.lblCxLastName.AutoSize = true;
            this.lblCxLastName.Location = new System.Drawing.Point(233, 16);
            this.lblCxLastName.Name = "lblCxLastName";
            this.lblCxLastName.Size = new System.Drawing.Size(61, 13);
            this.lblCxLastName.TabIndex = 4;
            this.lblCxLastName.Text = "Last Name:";
            // 
            // txtCxFirstName
            // 
            this.txtCxFirstName.Location = new System.Drawing.Point(120, 32);
            this.txtCxFirstName.Name = "txtCxFirstName";
            this.txtCxFirstName.ReadOnly = true;
            this.txtCxFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtCxFirstName.TabIndex = 3;
            // 
            // lblCxFirstName
            // 
            this.lblCxFirstName.AutoSize = true;
            this.lblCxFirstName.Location = new System.Drawing.Point(117, 16);
            this.lblCxFirstName.Name = "lblCxFirstName";
            this.lblCxFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblCxFirstName.TabIndex = 2;
            this.lblCxFirstName.Text = "First Name:";
            // 
            // txtCxNum
            // 
            this.txtCxNum.Location = new System.Drawing.Point(6, 32);
            this.txtCxNum.Name = "txtCxNum";
            this.txtCxNum.ReadOnly = true;
            this.txtCxNum.Size = new System.Drawing.Size(100, 20);
            this.txtCxNum.TabIndex = 1;
            // 
            // lblCxNum
            // 
            this.lblCxNum.AutoSize = true;
            this.lblCxNum.Location = new System.Drawing.Point(7, 16);
            this.lblCxNum.Name = "lblCxNum";
            this.lblCxNum.Size = new System.Drawing.Size(64, 13);
            this.lblCxNum.TabIndex = 0;
            this.lblCxNum.Text = "Customer #:";
            // 
            // cboVehicle
            // 
            this.cboVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicle.FormattingEnabled = true;
            this.cboVehicle.Location = new System.Drawing.Point(134, 24);
            this.cboVehicle.Name = "cboVehicle";
            this.cboVehicle.Size = new System.Drawing.Size(99, 21);
            this.cboVehicle.TabIndex = 4;
            this.cboVehicle.SelectedIndexChanged += new System.EventHandler(this.cboVehicle_SelectedIndexChanged);
            // 
            // lblSelectVehicle
            // 
            this.lblSelectVehicle.AutoSize = true;
            this.lblSelectVehicle.Location = new System.Drawing.Point(131, 7);
            this.lblSelectVehicle.Name = "lblSelectVehicle";
            this.lblSelectVehicle.Size = new System.Drawing.Size(102, 13);
            this.lblSelectVehicle.TabIndex = 3;
            this.lblSelectVehicle.Text = "Select/Add Vehicle:";
            // 
            // btnCxSearch
            // 
            this.btnCxSearch.Location = new System.Drawing.Point(86, 24);
            this.btnCxSearch.Name = "btnCxSearch";
            this.btnCxSearch.Size = new System.Drawing.Size(19, 20);
            this.btnCxSearch.TabIndex = 2;
            this.btnCxSearch.UseVisualStyleBackColor = true;
            this.btnCxSearch.Click += new System.EventHandler(this.btnCxSearch_Click);
            // 
            // txtCxNameSearch
            // 
            this.txtCxNameSearch.Location = new System.Drawing.Point(10, 24);
            this.txtCxNameSearch.Name = "txtCxNameSearch";
            this.txtCxNameSearch.Size = new System.Drawing.Size(72, 20);
            this.txtCxNameSearch.TabIndex = 1;
            // 
            // lblCxSearch
            // 
            this.lblCxSearch.AutoSize = true;
            this.lblCxSearch.Location = new System.Drawing.Point(7, 7);
            this.lblCxSearch.Name = "lblCxSearch";
            this.lblCxSearch.Size = new System.Drawing.Size(91, 13);
            this.lblCxSearch.TabIndex = 0;
            this.lblCxSearch.Text = "Customer Search:";
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.grpFilters);
            this.tabView.Controls.Add(this.lstWorkOrders);
            this.tabView.Controls.Add(this.grpViewActions);
            this.tabView.Location = new System.Drawing.Point(4, 23);
            this.tabView.Name = "tabView";
            this.tabView.Padding = new System.Windows.Forms.Padding(3);
            this.tabView.Size = new System.Drawing.Size(749, 558);
            this.tabView.TabIndex = 1;
            this.tabView.Text = "View";
            this.tabView.UseVisualStyleBackColor = true;
            // 
            // grpFilters
            // 
            this.grpFilters.Controls.Add(this.btnFilPickup);
            this.grpFilters.Controls.Add(this.btnFilService);
            this.grpFilters.Controls.Add(this.btnFilHold);
            this.grpFilters.Controls.Add(this.btnFilUnassigned);
            this.grpFilters.Controls.Add(this.btnFilAll);
            this.grpFilters.Location = new System.Drawing.Point(6, 6);
            this.grpFilters.Name = "grpFilters";
            this.grpFilters.Size = new System.Drawing.Size(737, 62);
            this.grpFilters.TabIndex = 2;
            this.grpFilters.TabStop = false;
            this.grpFilters.Text = "Work Order Filters:";
            // 
            // btnFilPickup
            // 
            this.btnFilPickup.Location = new System.Drawing.Point(330, 17);
            this.btnFilPickup.Name = "btnFilPickup";
            this.btnFilPickup.Size = new System.Drawing.Size(75, 37);
            this.btnFilPickup.TabIndex = 4;
            this.btnFilPickup.Text = "Awaiting Pick Up";
            this.btnFilPickup.UseVisualStyleBackColor = true;
            this.btnFilPickup.Click += new System.EventHandler(this.btnFilPickup_Click);
            // 
            // btnFilService
            // 
            this.btnFilService.Location = new System.Drawing.Point(249, 17);
            this.btnFilService.Name = "btnFilService";
            this.btnFilService.Size = new System.Drawing.Size(75, 37);
            this.btnFilService.TabIndex = 3;
            this.btnFilService.Text = "In Service";
            this.btnFilService.UseVisualStyleBackColor = true;
            this.btnFilService.Click += new System.EventHandler(this.btnFilService_Click);
            // 
            // btnFilHold
            // 
            this.btnFilHold.Location = new System.Drawing.Point(168, 17);
            this.btnFilHold.Name = "btnFilHold";
            this.btnFilHold.Size = new System.Drawing.Size(75, 37);
            this.btnFilHold.TabIndex = 2;
            this.btnFilHold.Text = "Hold";
            this.btnFilHold.UseVisualStyleBackColor = true;
            this.btnFilHold.Click += new System.EventHandler(this.btnFilHold_Click);
            // 
            // btnFilUnassigned
            // 
            this.btnFilUnassigned.Location = new System.Drawing.Point(87, 17);
            this.btnFilUnassigned.Name = "btnFilUnassigned";
            this.btnFilUnassigned.Size = new System.Drawing.Size(75, 37);
            this.btnFilUnassigned.TabIndex = 1;
            this.btnFilUnassigned.Text = "Unassigned";
            this.btnFilUnassigned.UseVisualStyleBackColor = true;
            this.btnFilUnassigned.Click += new System.EventHandler(this.btnFilUnassigned_Click);
            // 
            // btnFilAll
            // 
            this.btnFilAll.Location = new System.Drawing.Point(6, 17);
            this.btnFilAll.Name = "btnFilAll";
            this.btnFilAll.Size = new System.Drawing.Size(75, 37);
            this.btnFilAll.TabIndex = 0;
            this.btnFilAll.Text = "All";
            this.btnFilAll.UseVisualStyleBackColor = true;
            this.btnFilAll.Click += new System.EventHandler(this.btnFilAll_Click);
            // 
            // lstWorkOrders
            // 
            this.lstWorkOrders.AllowUserToAddRows = false;
            this.lstWorkOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lstWorkOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstWorkOrders.Location = new System.Drawing.Point(6, 74);
            this.lstWorkOrders.Name = "lstWorkOrders";
            this.lstWorkOrders.RowHeadersVisible = false;
            this.lstWorkOrders.Size = new System.Drawing.Size(737, 393);
            this.lstWorkOrders.TabIndex = 1;
            // 
            // grpViewActions
            // 
            this.grpViewActions.Controls.Add(this.btnCompleteSelected);
            this.grpViewActions.Controls.Add(this.btnDischargeSelected);
            this.grpViewActions.Controls.Add(this.btnResumeSelected);
            this.grpViewActions.Controls.Add(this.btnHoldSelected);
            this.grpViewActions.Controls.Add(this.btnDeleteSelected);
            this.grpViewActions.Controls.Add(this.btnViewSelected);
            this.grpViewActions.Location = new System.Drawing.Point(6, 473);
            this.grpViewActions.Name = "grpViewActions";
            this.grpViewActions.Size = new System.Drawing.Size(737, 79);
            this.grpViewActions.TabIndex = 0;
            this.grpViewActions.TabStop = false;
            // 
            // btnCompleteSelected
            // 
            this.btnCompleteSelected.Enabled = false;
            this.btnCompleteSelected.Location = new System.Drawing.Point(575, 15);
            this.btnCompleteSelected.Name = "btnCompleteSelected";
            this.btnCompleteSelected.Size = new System.Drawing.Size(75, 54);
            this.btnCompleteSelected.TabIndex = 5;
            this.btnCompleteSelected.Text = "Complete Selected";
            this.btnCompleteSelected.UseVisualStyleBackColor = true;
            this.btnCompleteSelected.Click += new System.EventHandler(this.btnCompleteSelected_Click);
            // 
            // btnDischargeSelected
            // 
            this.btnDischargeSelected.Enabled = false;
            this.btnDischargeSelected.Location = new System.Drawing.Point(656, 15);
            this.btnDischargeSelected.Name = "btnDischargeSelected";
            this.btnDischargeSelected.Size = new System.Drawing.Size(75, 54);
            this.btnDischargeSelected.TabIndex = 4;
            this.btnDischargeSelected.Text = "Discharge Selected";
            this.btnDischargeSelected.UseVisualStyleBackColor = true;
            this.btnDischargeSelected.Click += new System.EventHandler(this.btnDischargeSelected_Click);
            // 
            // btnResumeSelected
            // 
            this.btnResumeSelected.Enabled = false;
            this.btnResumeSelected.Location = new System.Drawing.Point(249, 15);
            this.btnResumeSelected.Name = "btnResumeSelected";
            this.btnResumeSelected.Size = new System.Drawing.Size(75, 54);
            this.btnResumeSelected.TabIndex = 3;
            this.btnResumeSelected.Text = "Resume Selected";
            this.btnResumeSelected.UseVisualStyleBackColor = true;
            this.btnResumeSelected.Click += new System.EventHandler(this.btnResumeSelected_Click);
            // 
            // btnHoldSelected
            // 
            this.btnHoldSelected.Enabled = false;
            this.btnHoldSelected.Location = new System.Drawing.Point(168, 15);
            this.btnHoldSelected.Name = "btnHoldSelected";
            this.btnHoldSelected.Size = new System.Drawing.Size(75, 54);
            this.btnHoldSelected.TabIndex = 2;
            this.btnHoldSelected.Text = "Hold Selected";
            this.btnHoldSelected.UseVisualStyleBackColor = true;
            this.btnHoldSelected.Click += new System.EventHandler(this.btnHoldSelected_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Enabled = false;
            this.btnDeleteSelected.Location = new System.Drawing.Point(87, 15);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(75, 54);
            this.btnDeleteSelected.TabIndex = 1;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            // 
            // btnViewSelected
            // 
            this.btnViewSelected.Location = new System.Drawing.Point(6, 15);
            this.btnViewSelected.Name = "btnViewSelected";
            this.btnViewSelected.Size = new System.Drawing.Size(75, 54);
            this.btnViewSelected.TabIndex = 0;
            this.btnViewSelected.Text = "View Selected";
            this.btnViewSelected.UseVisualStyleBackColor = true;
            this.btnViewSelected.Click += new System.EventHandler(this.btnViewSelected_Click);
            // 
            // tabViewTechTasks
            // 
            this.tabViewTechTasks.Controls.Add(this.grpTechSummary);
            this.tabViewTechTasks.Controls.Add(this.lstTechTasks);
            this.tabViewTechTasks.Location = new System.Drawing.Point(4, 23);
            this.tabViewTechTasks.Name = "tabViewTechTasks";
            this.tabViewTechTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewTechTasks.Size = new System.Drawing.Size(749, 558);
            this.tabViewTechTasks.TabIndex = 2;
            this.tabViewTechTasks.Text = "View Tasks By Tech";
            this.tabViewTechTasks.UseVisualStyleBackColor = true;
            // 
            // grpTechSummary
            // 
            this.grpTechSummary.Controls.Add(this.txtTotalWorkOrders);
            this.grpTechSummary.Controls.Add(this.label4);
            this.grpTechSummary.Controls.Add(this.txtTotalTasks);
            this.grpTechSummary.Controls.Add(this.txtTotalTime);
            this.grpTechSummary.Controls.Add(this.cboTechs);
            this.grpTechSummary.Controls.Add(this.label3);
            this.grpTechSummary.Controls.Add(this.label2);
            this.grpTechSummary.Controls.Add(this.label1);
            this.grpTechSummary.Location = new System.Drawing.Point(6, 6);
            this.grpTechSummary.Name = "grpTechSummary";
            this.grpTechSummary.Size = new System.Drawing.Size(737, 73);
            this.grpTechSummary.TabIndex = 2;
            this.grpTechSummary.TabStop = false;
            // 
            // txtTotalWorkOrders
            // 
            this.txtTotalWorkOrders.Location = new System.Drawing.Point(550, 32);
            this.txtTotalWorkOrders.Name = "txtTotalWorkOrders";
            this.txtTotalWorkOrders.ReadOnly = true;
            this.txtTotalWorkOrders.Size = new System.Drawing.Size(100, 20);
            this.txtTotalWorkOrders.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Work Orders Active:";
            // 
            // txtTotalTasks
            // 
            this.txtTotalTasks.Location = new System.Drawing.Point(370, 32);
            this.txtTotalTasks.Name = "txtTotalTasks";
            this.txtTotalTasks.ReadOnly = true;
            this.txtTotalTasks.Size = new System.Drawing.Size(100, 20);
            this.txtTotalTasks.TabIndex = 5;
            // 
            // txtTotalTime
            // 
            this.txtTotalTime.Location = new System.Drawing.Point(194, 32);
            this.txtTotalTime.Name = "txtTotalTime";
            this.txtTotalTime.ReadOnly = true;
            this.txtTotalTime.Size = new System.Drawing.Size(100, 20);
            this.txtTotalTime.TabIndex = 4;
            // 
            // cboTechs
            // 
            this.cboTechs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTechs.FormattingEnabled = true;
            this.cboTechs.Items.AddRange(new object[] {
            "All",
            "Eduardo Concepcion",
            "Will McAvoy",
            "Sarah White",
            "Raymond Roach"});
            this.cboTechs.Location = new System.Drawing.Point(9, 32);
            this.cboTechs.Name = "cboTechs";
            this.cboTechs.Size = new System.Drawing.Size(149, 21);
            this.cboTechs.TabIndex = 0;
            this.cboTechs.SelectedIndexChanged += new System.EventHandler(this.cboTechs_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Assigned Task Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Task Time (hours):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Stats for Tech:";
            // 
            // lstTechTasks
            // 
            this.lstTechTasks.AllowUserToAddRows = false;
            this.lstTechTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lstTechTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstTechTasks.Location = new System.Drawing.Point(6, 85);
            this.lstTechTasks.Name = "lstTechTasks";
            this.lstTechTasks.ReadOnly = true;
            this.lstTechTasks.RowHeadersVisible = false;
            this.lstTechTasks.Size = new System.Drawing.Size(737, 467);
            this.lstTechTasks.TabIndex = 1;
            // 
            // frmServiceWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 622);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmServiceWorkOrder";
            this.Text = "Service";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabCreate.ResumeLayout(false);
            this.tabCreate.PerformLayout();
            this.grpServiceInfo.ResumeLayout(false);
            this.grpServiceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstTasks)).EndInit();
            this.grpWorkInfo.ResumeLayout(false);
            this.grpWorkInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKmOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKmIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).EndInit();
            this.grpVehicleInfo.ResumeLayout(false);
            this.grpVehicleInfo.PerformLayout();
            this.grpCxInfo.ResumeLayout(false);
            this.grpCxInfo.PerformLayout();
            this.tabView.ResumeLayout(false);
            this.grpFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstWorkOrders)).EndInit();
            this.grpViewActions.ResumeLayout(false);
            this.tabViewTechTasks.ResumeLayout(false);
            this.grpTechSummary.ResumeLayout(false);
            this.grpTechSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstTechTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceWorkOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCreate;
        private System.Windows.Forms.TabPage tabView;
        private System.Windows.Forms.Button btnCxSearch;
        private System.Windows.Forms.TextBox txtCxNameSearch;
        private System.Windows.Forms.Label lblCxSearch;
        private System.Windows.Forms.ComboBox cboVehicle;
        private System.Windows.Forms.Label lblSelectVehicle;
        private System.Windows.Forms.GroupBox grpWorkInfo;
        private System.Windows.Forms.GroupBox grpVehicleInfo;
        private System.Windows.Forms.GroupBox grpCxInfo;
        private System.Windows.Forms.TextBox txtCxFirstName;
        private System.Windows.Forms.Label lblCxFirstName;
        private System.Windows.Forms.TextBox txtCxNum;
        private System.Windows.Forms.Label lblCxNum;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.TextBox txtCxLastName;
        private System.Windows.Forms.Label lblCxLastName;
        private System.Windows.Forms.TextBox txtVin;
        private System.Windows.Forms.Label lblVin;
        private System.Windows.Forms.TextBox txtPlateNum;
        private System.Windows.Forms.Label lblPlateNum;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.DateTimePicker dtpPromised;
        private System.Windows.Forms.Label lblPromised;
        private System.Windows.Forms.NumericUpDown numKmOut;
        private System.Windows.Forms.Label lblKmOut;
        private System.Windows.Forms.Label lblKmIn;
        private System.Windows.Forms.NumericUpDown numRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.NumericUpDown numKmIn;
        private System.Windows.Forms.DataGridView lstWorkOrders;
        private System.Windows.Forms.GroupBox grpViewActions;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnViewSelected;
        private System.Windows.Forms.Button btnCompleteSelected;
        private System.Windows.Forms.Button btnDischargeSelected;
        private System.Windows.Forms.Button btnResumeSelected;
        private System.Windows.Forms.Button btnHoldSelected;
        private System.Windows.Forms.GroupBox grpFilters;
        private System.Windows.Forms.Button btnFilPickup;
        private System.Windows.Forms.Button btnFilService;
        private System.Windows.Forms.Button btnFilHold;
        private System.Windows.Forms.Button btnFilUnassigned;
        private System.Windows.Forms.Button btnFilAll;
        private System.Windows.Forms.GroupBox grpServiceInfo;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Button btnNewTask;
        private System.Windows.Forms.DataGridView lstTasks;
        private System.Windows.Forms.Button btnRemoveTech;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox lstTechnicians;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblTechnicianList;
        private System.Windows.Forms.Button btnAddTech;
        private System.Windows.Forms.ComboBox cboAssign;
        private System.Windows.Forms.Label lblAssign;
        private System.Windows.Forms.TabPage tabViewTechTasks;
        private System.Windows.Forms.GroupBox grpTechSummary;
        private System.Windows.Forms.DataGridView lstTechTasks;
        private System.Windows.Forms.ComboBox cboTechs;
        private System.Windows.Forms.TextBox txtTotalTasks;
        private System.Windows.Forms.TextBox txtTotalTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalWorkOrders;
        private System.Windows.Forms.Label label4;
    }
}

