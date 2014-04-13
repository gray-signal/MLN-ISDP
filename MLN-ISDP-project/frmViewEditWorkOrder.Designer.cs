namespace MLN_ISDP_project
{
    partial class frmViewEditWorkOrder
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabViewEdit = new System.Windows.Forms.TabPage();
            this.grpServiceInfo = new System.Windows.Forms.GroupBox();
            this.btnNewTask = new System.Windows.Forms.Button();
            this.lstTasks = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemoveTech = new System.Windows.Forms.Button();
            this.lstTechnicians = new System.Windows.Forms.ListBox();
            this.lblTechnicianList = new System.Windows.Forms.Label();
            this.btnAddTech = new System.Windows.Forms.Button();
            this.cboAssign = new System.Windows.Forms.ComboBox();
            this.lblAssign = new System.Windows.Forms.Label();
            this.grpWorkInfo = new System.Windows.Forms.GroupBox();
            this.lblWOID = new System.Windows.Forms.Label();
            this.txtWorkOrderID = new System.Windows.Forms.TextBox();
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
            this.tabParts = new System.Windows.Forms.TabPage();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabViewEdit.SuspendLayout();
            this.grpServiceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstTasks)).BeginInit();
            this.grpWorkInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKmOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKmIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).BeginInit();
            this.grpVehicleInfo.SuspendLayout();
            this.grpCxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabViewEdit);
            this.tabControl1.Controls.Add(this.tabParts);
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(726, 547);
            this.tabControl1.TabIndex = 0;
            // 
            // tabViewEdit
            // 
            this.tabViewEdit.Controls.Add(this.grpServiceInfo);
            this.tabViewEdit.Controls.Add(this.grpWorkInfo);
            this.tabViewEdit.Controls.Add(this.grpVehicleInfo);
            this.tabViewEdit.Controls.Add(this.grpCxInfo);
            this.tabViewEdit.Location = new System.Drawing.Point(4, 23);
            this.tabViewEdit.Name = "tabViewEdit";
            this.tabViewEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewEdit.Size = new System.Drawing.Size(718, 520);
            this.tabViewEdit.TabIndex = 0;
            this.tabViewEdit.Text = "View/Edit";
            this.tabViewEdit.UseVisualStyleBackColor = true;
            // 
            // grpServiceInfo
            // 
            this.grpServiceInfo.Controls.Add(this.btnRemoveTask);
            this.grpServiceInfo.Controls.Add(this.btnNewTask);
            this.grpServiceInfo.Controls.Add(this.lstTasks);
            this.grpServiceInfo.Controls.Add(this.btnSave);
            this.grpServiceInfo.Controls.Add(this.btnRemoveTech);
            this.grpServiceInfo.Controls.Add(this.lstTechnicians);
            this.grpServiceInfo.Controls.Add(this.lblTechnicianList);
            this.grpServiceInfo.Controls.Add(this.btnAddTech);
            this.grpServiceInfo.Controls.Add(this.cboAssign);
            this.grpServiceInfo.Controls.Add(this.lblAssign);
            this.grpServiceInfo.Location = new System.Drawing.Point(6, 262);
            this.grpServiceInfo.Name = "grpServiceInfo";
            this.grpServiceInfo.Size = new System.Drawing.Size(702, 245);
            this.grpServiceInfo.TabIndex = 12;
            this.grpServiceInfo.TabStop = false;
            this.grpServiceInfo.Text = "Service Information";
            // 
            // btnNewTask
            // 
            this.btnNewTask.Location = new System.Drawing.Point(503, 184);
            this.btnNewTask.Name = "btnNewTask";
            this.btnNewTask.Size = new System.Drawing.Size(75, 23);
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
            this.lstTasks.Size = new System.Drawing.Size(486, 220);
            this.lstTasks.TabIndex = 16;
            this.lstTasks.SelectionChanged += new System.EventHandler(this.lstTasks_SelectionChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(603, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 55);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save and Close";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemoveTech
            // 
            this.btnRemoveTech.Location = new System.Drawing.Point(596, 54);
            this.btnRemoveTech.Name = "btnRemoveTech";
            this.btnRemoveTech.Size = new System.Drawing.Size(93, 23);
            this.btnRemoveTech.TabIndex = 14;
            this.btnRemoveTech.Text = "Remove Tech";
            this.btnRemoveTech.UseVisualStyleBackColor = true;
            this.btnRemoveTech.Click += new System.EventHandler(this.btnRemoveTech_Click);
            // 
            // lstTechnicians
            // 
            this.lstTechnicians.FormattingEnabled = true;
            this.lstTechnicians.Location = new System.Drawing.Point(503, 96);
            this.lstTechnicians.Name = "lstTechnicians";
            this.lstTechnicians.Size = new System.Drawing.Size(186, 82);
            this.lstTechnicians.TabIndex = 13;
            // 
            // lblTechnicianList
            // 
            this.lblTechnicianList.AutoSize = true;
            this.lblTechnicianList.Location = new System.Drawing.Point(503, 80);
            this.lblTechnicianList.Name = "lblTechnicianList";
            this.lblTechnicianList.Size = new System.Drawing.Size(120, 13);
            this.lblTechnicianList.TabIndex = 12;
            this.lblTechnicianList.Text = "Assigned Technician(s):";
            // 
            // btnAddTech
            // 
            this.btnAddTech.Location = new System.Drawing.Point(503, 54);
            this.btnAddTech.Name = "btnAddTech";
            this.btnAddTech.Size = new System.Drawing.Size(87, 23);
            this.btnAddTech.TabIndex = 11;
            this.btnAddTech.Text = "Add Tech";
            this.btnAddTech.UseVisualStyleBackColor = true;
            this.btnAddTech.Click += new System.EventHandler(this.btnAssign_Click);
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
            this.cboAssign.Location = new System.Drawing.Point(503, 29);
            this.cboAssign.Name = "cboAssign";
            this.cboAssign.Size = new System.Drawing.Size(186, 21);
            this.cboAssign.TabIndex = 10;
            // 
            // lblAssign
            // 
            this.lblAssign.AutoSize = true;
            this.lblAssign.Location = new System.Drawing.Point(503, 13);
            this.lblAssign.Name = "lblAssign";
            this.lblAssign.Size = new System.Drawing.Size(68, 13);
            this.lblAssign.TabIndex = 9;
            this.lblAssign.Text = "Technicians:";
            // 
            // grpWorkInfo
            // 
            this.grpWorkInfo.Controls.Add(this.lblWOID);
            this.grpWorkInfo.Controls.Add(this.txtWorkOrderID);
            this.grpWorkInfo.Controls.Add(this.numKmOut);
            this.grpWorkInfo.Controls.Add(this.lblKmOut);
            this.grpWorkInfo.Controls.Add(this.numKmIn);
            this.grpWorkInfo.Controls.Add(this.lblKmIn);
            this.grpWorkInfo.Controls.Add(this.numRate);
            this.grpWorkInfo.Controls.Add(this.lblRate);
            this.grpWorkInfo.Controls.Add(this.dtpPromised);
            this.grpWorkInfo.Controls.Add(this.lblPromised);
            this.grpWorkInfo.Location = new System.Drawing.Point(6, 195);
            this.grpWorkInfo.Name = "grpWorkInfo";
            this.grpWorkInfo.Size = new System.Drawing.Size(702, 61);
            this.grpWorkInfo.TabIndex = 11;
            this.grpWorkInfo.TabStop = false;
            this.grpWorkInfo.Text = "Work Order Information";
            // 
            // lblWOID
            // 
            this.lblWOID.AutoSize = true;
            this.lblWOID.Location = new System.Drawing.Point(457, 16);
            this.lblWOID.Name = "lblWOID";
            this.lblWOID.Size = new System.Drawing.Size(79, 13);
            this.lblWOID.TabIndex = 9;
            this.lblWOID.Text = "Work Order ID:";
            // 
            // txtWorkOrderID
            // 
            this.txtWorkOrderID.Location = new System.Drawing.Point(460, 32);
            this.txtWorkOrderID.Name = "txtWorkOrderID";
            this.txtWorkOrderID.ReadOnly = true;
            this.txtWorkOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtWorkOrderID.TabIndex = 8;
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
            this.grpVehicleInfo.Location = new System.Drawing.Point(6, 126);
            this.grpVehicleInfo.Name = "grpVehicleInfo";
            this.grpVehicleInfo.Size = new System.Drawing.Size(702, 63);
            this.grpVehicleInfo.TabIndex = 10;
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
            this.grpCxInfo.Location = new System.Drawing.Point(6, 6);
            this.grpCxInfo.Name = "grpCxInfo";
            this.grpCxInfo.Size = new System.Drawing.Size(702, 114);
            this.grpCxInfo.TabIndex = 9;
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
            // tabParts
            // 
            this.tabParts.Location = new System.Drawing.Point(4, 23);
            this.tabParts.Name = "tabParts";
            this.tabParts.Padding = new System.Windows.Forms.Padding(3);
            this.tabParts.Size = new System.Drawing.Size(750, 520);
            this.tabParts.TabIndex = 1;
            this.tabParts.Text = "Parts List";
            this.tabParts.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Location = new System.Drawing.Point(503, 213);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveTask.TabIndex = 18;
            this.btnRemoveTask.Text = "Delete Task";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // frmViewEditWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 582);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmViewEditWorkOrder";
            this.Text = "frmViewEditWorkOrder";
            this.Load += new System.EventHandler(this.frmViewEditWorkOrder_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabViewEdit.ResumeLayout(false);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabViewEdit;
        private System.Windows.Forms.TabPage tabParts;
        private System.Windows.Forms.GroupBox grpServiceInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemoveTech;
        private System.Windows.Forms.ListBox lstTechnicians;
        private System.Windows.Forms.Label lblTechnicianList;
        private System.Windows.Forms.Button btnAddTech;
        private System.Windows.Forms.ComboBox cboAssign;
        private System.Windows.Forms.Label lblAssign;
        private System.Windows.Forms.GroupBox grpWorkInfo;
        private System.Windows.Forms.NumericUpDown numKmOut;
        private System.Windows.Forms.Label lblKmOut;
        private System.Windows.Forms.NumericUpDown numKmIn;
        private System.Windows.Forms.Label lblKmIn;
        private System.Windows.Forms.NumericUpDown numRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.DateTimePicker dtpPromised;
        private System.Windows.Forms.Label lblPromised;
        private System.Windows.Forms.GroupBox grpVehicleInfo;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtPlateNum;
        private System.Windows.Forms.Label lblPlateNum;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtVin;
        private System.Windows.Forms.Label lblVin;
        private System.Windows.Forms.GroupBox grpCxInfo;
        private System.Windows.Forms.TextBox txtProvince;
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
        private System.Windows.Forms.TextBox txtCxFirstName;
        private System.Windows.Forms.Label lblCxFirstName;
        private System.Windows.Forms.TextBox txtCxNum;
        private System.Windows.Forms.Label lblCxNum;
        private System.Windows.Forms.TextBox txtWorkOrderID;
        private System.Windows.Forms.Label lblWOID;
        private System.Windows.Forms.DataGridView lstTasks;
        private System.Windows.Forms.Button btnNewTask;
        private System.Windows.Forms.Button btnRemoveTask;
    }
}