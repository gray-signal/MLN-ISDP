using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MLN_ISDP_project
{
    public partial class frmServiceWorkOrder : Form
    {

        static System.Data.OleDb.OleDbConnectionStringBuilder csBuilder = new System.Data.OleDb.OleDbConnectionStringBuilder(
                "Provider=MSDAORA;Data Source=localhost;User ID=2023164;Password=#42Paradox;");
        static OracleDB dbConn = new OracleDB(csBuilder.ToString());


        DataTable workOrders;
        BindingSource sourceWO;

        DataTable techTasks;
        BindingSource sourceTechTasks;

        private List<Task> taskList;
        private BindingSource sourceTasks;

        public frmServiceWorkOrder()
        {
            InitializeComponent();

            workOrders = new DataTable();
            sourceWO = new BindingSource();

            techTasks = new DataTable();
            sourceTechTasks = new BindingSource();

            taskList = new List<Task>();
            sourceTasks = new BindingSource();

            sourceTasks.DataSource = taskList;
            lstTasks.DataSource = sourceTasks;

            workOrders = dbConn.readQuery("SELECT * FROM WORKORDER WHERE STATUS != 'DISCHARGED' OR STATUS IS NULL ORDER BY STATUS Desc, PromisedTime");

            cboAssign.SelectedIndex = 0;
            cboTechs.SelectedIndex = 0;

            sourceWO.DataSource = workOrders;
            lstWorkOrders.DataSource = sourceWO;

            sourceTechTasks.DataSource = techTasks;
            lstTechTasks.DataSource = sourceTechTasks;

            setUpTaskColumns();

            dtpPromised.Value = DateTime.Now;
        }

        private void setUpTaskColumns()
        {
            lstTasks.Columns["TaskID"].ReadOnly = true;

            //ordering
            lstTasks.Columns["TaskID"].DisplayIndex = 0;
            lstTasks.Columns["TaskTime"].DisplayIndex = 1;
            lstTasks.Columns["Description"].DisplayIndex = 2;
            lstTasks.Columns["Type"].DisplayIndex = 3;


            //names
            lstTasks.Columns["TaskID"].HeaderText = "Task Number";
            lstTasks.Columns["TaskTime"].HeaderText = "Time";
            lstTasks.Columns["Description"].HeaderText = "Description";
            lstTasks.Columns["Type"].HeaderText = "Type";

            //visibility
            lstTasks.Columns["Dirty"].Visible = false;
            lstTasks.Columns["WorkOrderID"].Visible = false;

            lstTasks.Columns.Remove("Type");

            var Type = new DataGridViewComboBoxColumn();
            Type.DataPropertyName = "Type";
            lstTasks.Columns.Add(Type);

            Type.HeaderText = "Type";
            Type.DataSource = new List<Task.TaskType> { Task.TaskType.NONE, Task.TaskType.RECALL, Task.TaskType.WARRANTY };
        }


        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCxSearch_Click(object sender, EventArgs e)
        {
            String searchedName = txtCxNameSearch.Text.ToUpper();

            DataTable roughSearch = dbConn.readQuery("SELECT * from Customer where UPPER(LastName) LIKE '%" + searchedName + "%'");

            string selectedCxID = "";
            if (roughSearch.Rows.Count > 0)
            {
                if (roughSearch.Rows.Count > 1)
                {
                    selectedCxID = CxSearchModal.ShowDialog("test", "Part Number", roughSearch);
                }

                if (!selectedCxID.Equals(""))
                {
                    populateCxInfo(selectedCxID);

                    DataTable vehicles = dbConn.readQuery("SELECT * from Vehicle where OwnerID = " + selectedCxID);

                    cboVehicle.DisplayMember = "MODEL";
                    cboVehicle.ValueMember = "VIN";
                    cboVehicle.DataSource = vehicles;
                }
            }
            else
            {

            }

        }

        private void cboVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVehicle.SelectedValue != null)
            {
                string vehicleID = cboVehicle.SelectedValue.ToString();

                DataTable vehicle = dbConn.readQuery("SELECT * from Vehicle where VIN = '" + vehicleID + "'");

                txtVin.Text = vehicle.Rows[0].Field<string>("VIN");
                txtModel.Text = vehicle.Rows[0].Field<string>("MODEL");
                txtColour.Text = vehicle.Rows[0].Field<string>("COLOUR");
                txtYear.Text = Convert.ToString(vehicle.Rows[0].Field<double>("YEAR"));
                txtPlateNum.Text = vehicle.Rows[0].Field<string>("LICENSEPLATE");
                //txtWarrantyExp.Text = vehicle.Rows[0].Field<string>("WARRANTY");
            }
        }

        private void populateVehicleInfo(string vehicleID)
        {

        }

        private void populateCxInfo(string customerID)
        {
            DataTable customer = dbConn.readQuery("SELECT * from Customer where CustomerID = " + customerID);

            txtCxNum.Text = Convert.ToString(customer.Rows[0].Field<double>("CUSTOMERID"));
            txtCxFirstName.Text = customer.Rows[0].Field<string>("FIRSTNAME");
            txtCxLastName.Text = customer.Rows[0].Field<string>("LASTNAME");
            txtHomePhone.Text = customer.Rows[0].Field<string>("PHONE");
            txtEmail.Text = customer.Rows[0].Field<string>("EMAIL");
            txtPostCode.Text = customer.Rows[0].Field<string>("POSTALCODE");
            txtAddress.Text = customer.Rows[0].Field<string>("STREETADDRESS");
            txtCity.Text = customer.Rows[0].Field<string>("CITY");
            txtProvince.Text = customer.Rows[0].Field<string>("PROVINCE");
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (!lstTechnicians.Items.Contains(cboAssign.SelectedItem.ToString()))
            {
                lstTechnicians.Items.Add(cboAssign.SelectedItem.ToString());
            }

            lstTechnicians.SelectedIndex = lstTechnicians.Items.Count - 1;
        }

        private void btnRemoveTech_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstTechnicians.SelectedIndex;
            if (selectedIndex != -1)
            {
                lstTechnicians.Items.RemoveAt(selectedIndex);
                lstTechnicians.SelectedIndex = selectedIndex - 1;

                if (lstTechnicians.SelectedIndex == -1 && lstTechnicians.Items.Count > 0)
                    lstTechnicians.SelectedIndex = 0;
            }

            
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            taskList.RemoveAt(lstTasks.CurrentCell.RowIndex);
            sourceTasks.ResetBindings(false);
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {

            Task newTask = new Task();

            newTask.TaskID = taskList[taskList.Count - 1].TaskID + 1;

            taskList.Add(newTask);
            

            sourceTasks.ResetBindings(false);

            

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            numRate.Value = 85;
            numKmIn.Value = 0;
            numKmOut.Value = 0;
            dtpPromised.Value = DateTime.Now;

            txtCxNameSearch.Text = "";
            cboVehicle.DataSource = null;

            txtCxNum.Text = "";
            txtCxFirstName.Text = "";
            txtCxLastName.Text = "";
            txtHomePhone.Text = "";
            txtEmail.Text = "";
            txtPostCode.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtProvince.Text = "";

            txtVin.Text = "";
            txtModel.Text = "";
            txtColour.Text = "";
            txtYear.Text = "";
            txtPlateNum.Text = "";

            taskList.Clear();
            lstTechnicians.Items.Clear();

            cboAssign.SelectedIndex = 0;

            sourceTasks.ResetBindings(false);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtCxNum.Text == "")
            {
                MessageBox.Show("Please select a customer for this work order.");
            }
            else
            {

                DateTime promisedTime = dtpPromised.Value;

                string formattedTime = promisedTime.ToString("yyyy-MM-dd HH:mm:ss");

                decimal rate = numRate.Value;
                decimal kmIn = numKmIn.Value;
                string cxNum = txtCxNum.Text;

                dbConn.insertQuery("INSERT INTO WorkOrder "
                                 + "(PromisedTime, Rate, KMin, CustomerID, VehicleID, Status) "
                                 + "Values (to_date('" + formattedTime + "', 'yyyy-MM-dd hh24:mi:ss'), '"
                                 + rate + "', '" + kmIn + "', '" + cxNum + "', '" + txtVin.Text + "', 'UNASSIGNED')");

                DataTable dt = dbConn.readQuery("SELECT WorkOrderID FROM WorkOrder WHERE PromisedTime = to_date('" + formattedTime + "', 'yyyy-MM-dd hh24:mi:ss')");
                double woID = (double)dt.Rows[0]["WorkOrderID"];

                foreach (Task t in taskList)
                {
                    t.WorkOrderID = woID.ToString();
                    t.commit(dbConn);
                }

                btnReset_Click(sender, e);
            }
        }

        private void dtpPromised_ValueChanged(object sender, EventArgs e)
        {
            double sumHours = 0;
            foreach (Task t in taskList)
            {
                double time = 0.0;
                if (taskList.Count > 0)
                    time = t.TaskTime;
                sumHours = sumHours + time;
            }

            TimeSpan hours = TimeSpan.FromHours(sumHours);

            DateTime minPromised = DateTime.Now + hours;

            if (dtpPromised.Value < minPromised)
            {
                dtpPromised.Value = minPromised;
            }
        }

        private void btnFilAll_Click(object sender, EventArgs e)
        {
            btnDeleteSelected.Enabled = false;
            btnHoldSelected.Enabled = false;
            btnResumeSelected.Enabled = false;
            btnCompleteSelected.Enabled = false;
            btnDischargeSelected.Enabled = false;

            workOrders = dbConn.readQuery("SELECT * FROM WORKORDER WHERE STATUS != 'DISCHARGED' OR STATUS IS NULL ORDER BY STATUS Desc, PromisedTime");
            sourceWO.DataSource = null;
            sourceWO.DataSource = workOrders;
            sourceWO.ResetBindings(false);
        }

        private void btnFilUnassigned_Click(object sender, EventArgs e)
        {
            btnDeleteSelected.Enabled = true;
            btnHoldSelected.Enabled = false;
            btnResumeSelected.Enabled = false;
            btnCompleteSelected.Enabled = false;
            btnDischargeSelected.Enabled = false;

            workOrders = dbConn.readQuery("SELECT * FROM WORKORDER WHERE STATUS = 'UNASSIGNED' ORDER BY PromisedTime");
            sourceWO.DataSource = null;
            sourceWO.DataSource = workOrders;
            sourceWO.ResetBindings(false);
        }

        private void btnFilHold_Click(object sender, EventArgs e)
        {
            btnDeleteSelected.Enabled = false;
            btnHoldSelected.Enabled = false;
            btnResumeSelected.Enabled = true;
            btnCompleteSelected.Enabled = false;
            btnDischargeSelected.Enabled = false;

            workOrders = dbConn.readQuery("SELECT * FROM WORKORDER WHERE STATUS = 'ONHOLD' ORDER BY PromisedTime");
            sourceWO.DataSource = null;
            sourceWO.DataSource = workOrders;
            sourceWO.ResetBindings(false);
        }

        private void btnFilService_Click(object sender, EventArgs e)
        {
            btnDeleteSelected.Enabled = false;
            btnHoldSelected.Enabled = true;
            btnResumeSelected.Enabled = false;
            btnCompleteSelected.Enabled = true;
            btnDischargeSelected.Enabled = false;

            workOrders = dbConn.readQuery("SELECT * FROM WORKORDER WHERE STATUS = 'INSERVICE' ORDER BY PromisedTime");
            sourceWO.DataSource = null;
            sourceWO.DataSource = workOrders;
            sourceWO.ResetBindings(false);
        }

        private void btnFilPickup_Click(object sender, EventArgs e)
        {
            btnDeleteSelected.Enabled = false;
            btnHoldSelected.Enabled = false;
            btnResumeSelected.Enabled = false;
            btnCompleteSelected.Enabled = false;
            btnDischargeSelected.Enabled = true;

            workOrders = dbConn.readQuery("SELECT * FROM WORKORDER WHERE STATUS = 'AWAITINGPICKUP' ORDER BY PromisedTime");
            sourceWO.DataSource = null;
            sourceWO.DataSource = workOrders;
            sourceWO.ResetBindings(false);
        }

        private void btnViewSelected_Click(object sender, EventArgs e)
        {
            string currentWorkOrder = lstWorkOrders.Rows[lstWorkOrders.CurrentRow.Index].Cells["WorkOrderID"].Value.ToString();
            string status = lstWorkOrders.Rows[lstWorkOrders.CurrentRow.Index].Cells["status"].Value.ToString();

            Form frmEditWO = new frmViewEditWorkOrder(currentWorkOrder, status);
            frmEditWO.ShowDialog();

            sourceWO.ResetBindings(false);
        }

        private void btnAddTech_Click(object sender, EventArgs e)
        {
            if (!lstTechnicians.Items.Contains(cboAssign.SelectedItem.ToString()))
            {
                if (taskList.Count > 0)
                {
                    taskList[lstTasks.CurrentCell.RowIndex].TechList.Add(cboAssign.SelectedItem.ToString());
                    lstTechnicians.Items.Add(cboAssign.SelectedItem.ToString());
                }
            }

            lstTechnicians.SelectedIndex = lstTechnicians.Items.Count - 1;
        }

        private void btnNewTask_Click(object sender, EventArgs e)
        {
            Task newTask = new Task();
            if (taskList.Count == 0)
                newTask.TaskID = 1;
            else
                newTask.TaskID = taskList[taskList.Count - 1].TaskID + 1;

            taskList.Add(newTask);


            sourceTasks.ResetBindings(false);
        }

        private void btnRemoveTask_Click_1(object sender, EventArgs e)
        {
            taskList.RemoveAt(lstTasks.CurrentCell.RowIndex);
            sourceTasks.ResetBindings(false);
        }

        private void btnRemoveTech_Click_1(object sender, EventArgs e)
        {
            string tempTechName = "";
            int selectedIndex = lstTechnicians.SelectedIndex;

            if (selectedIndex != -1)
            {
                tempTechName = lstTechnicians.SelectedItem.ToString();
                lstTechnicians.Items.RemoveAt(selectedIndex);
                lstTechnicians.SelectedIndex = selectedIndex - 1;

                if (lstTechnicians.SelectedIndex == -1 && lstTechnicians.Items.Count > 0)
                    lstTechnicians.SelectedIndex = 0;
            }

            if (taskList[lstTasks.CurrentCell.RowIndex].TechList.Contains(tempTechName))
            {
                taskList[lstTasks.CurrentCell.RowIndex].TechList.Remove(tempTechName);
            }
        }

        private void loadCurrentTaskTechs(Task t)
        {
            lstTechnicians.Items.Clear();
            if (t.TechList != null && t.TechList.Count != 0)
            {
                foreach (string tech in t.TechList)
                {
                    lstTechnicians.Items.Add(tech);
                }
            }
        }

        private void lstTasks_SelectionChanged(object sender, EventArgs e)
        {
            if (lstTasks.RowCount > 0)
                loadCurrentTaskTechs(taskList[lstTasks.CurrentCell.RowIndex]);
            else
                lstTechnicians.Items.Clear();
        }

        private void btnHoldSelected_Click(object sender, EventArgs e)
        {
            string currentWorkOrder = lstWorkOrders.Rows[lstWorkOrders.CurrentRow.Index].Cells["WorkOrderID"].Value.ToString();
            changeWorkOrderStatus(currentWorkOrder, "ONHOLD");

            btnFilService_Click(sender, e);
        }

        private void btnResumeSelected_Click(object sender, EventArgs e)
        {
            string currentWorkOrder = lstWorkOrders.Rows[lstWorkOrders.CurrentRow.Index].Cells["WorkOrderID"].Value.ToString();
            changeWorkOrderStatus(currentWorkOrder, "INSERVICE");

            btnFilHold_Click(sender, e);
        }

        public void changeWorkOrderStatus(string workOrderID, string newStatus)
        {
            dbConn.insertQuery("UPDATE WorkOrder "
                             + "SET "
                             + "Status =  '" + newStatus + "' "
                             + "WHERE WorkOrderID = '" + workOrderID + "'");
        }

        private void btnCompleteSelected_Click(object sender, EventArgs e)
        {
            btnViewSelected_Click(sender, e);
        }

        private void btnDischargeSelected_Click(object sender, EventArgs e)
        {
            string currentWorkOrder = lstWorkOrders.Rows[lstWorkOrders.CurrentRow.Index].Cells["WorkOrderID"].Value.ToString();

            DialogResult result = MessageBox.Show("Are you sure you want to discharge this vehicle to the customer?", "Release Car", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                dbConn.insertQuery("UPDATE WorkOrder "
                                 + "SET Status ='DISCHARGED' "
                                 + "WHERE WorkOrderID = '" + currentWorkOrder + "'");
            }

            btnFilPickup_Click(sender, e);
        }

        private void cboTechs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string techName = cboTechs.SelectedItem.ToString();
            if (techName == "All")
                techName = "";

            techTasks = dbConn.readQuery(@"Select
  TASK.TECHLIST,
  TASK.DESCRIPTION,
  TASK.WORKORDERID,
  WORKORDER.PROMISEDTIME,
  VEHICLE.MODEL,
  VEHICLE.YEAR,
  VEHICLE.LICENSEPLATE,
  VEHICLE.COLOUR,
  TASK.TASKTIME
From
  TASK Inner Join
  WORKORDER On TASK.WORKORDERID = WORKORDER.WORKORDERID Inner Join
  VEHICLE On WORKORDER.VEHICLEID = VEHICLE.VIN
Where 
  TASK.TECHLIST LIKE '%" + techName + "%' Order By VEHICLE.LICENSEPLATE, WORKORDER.PROMISEDTIME");

            sourceTechTasks.DataSource = null;
            sourceTechTasks.DataSource = techTasks;
            sourceTechTasks.ResetBindings(false);

            txtTotalTasks.Text = techTasks.Rows.Count.ToString();

            double totalTime = 0.0;
            int totalWorkOrders = 0;

            DataView view = new DataView(techTasks);
            DataTable distinctValues = view.ToTable(true, "WorkOrderID");
            totalWorkOrders = distinctValues.Rows.Count;
            foreach (DataRow row in techTasks.Rows)
            {
                totalTime = totalTime + (double)row["TaskTime"];
            }

            txtTotalTime.Text = totalTime.ToString();
            txtTotalWorkOrders.Text = totalWorkOrders.ToString();
        }


    }
}
