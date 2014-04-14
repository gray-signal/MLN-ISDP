using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MLN_ISDP_project
{
    public partial class frmViewEditWorkOrder : Form
    {

        private List<Task> taskList;
        private BindingSource sourceTasks;

        private List<Part> availableParts;
        private BindingSource sourceAvailParts;

        private List<Task> tasksToBeDeleted;

        //list associated with this binding source exists on the task objects
        private BindingSource sourcePartsForSelectedTask;

        private string workOrderID;
        private string status;

        private DataTable customer;
        private DataTable vehicle;
        private DataTable workOrder;

        private DataTable tasks;

        private DataTable parts;

        static System.Data.OleDb.OleDbConnectionStringBuilder csBuilder = new System.Data.OleDb.OleDbConnectionStringBuilder(
                "Provider=MSDAORA;Data Source=localhost;User ID=2023164;Password=#42Paradox;");
        static OracleDB dbConn = new OracleDB(csBuilder.ToString());

        public frmViewEditWorkOrder()
        {
            InitializeComponent();
        }

        public frmViewEditWorkOrder(string workOrderID, string status)
        {
            this.workOrderID = workOrderID;
            this.status = status;

            InitializeComponent();
        }

        private void frmViewEditWorkOrder_Load(object sender, EventArgs e)
        {

            taskList = new List<Task>();
            sourceTasks = new BindingSource();

            availableParts = new List<Part>();
            sourceAvailParts = new BindingSource();

            tasksToBeDeleted = new List<Task>();

            sourcePartsForSelectedTask = new BindingSource();

            sourceTasks.DataSource = taskList;
            lstTasks.DataSource = sourceTasks;

            lstTasksForParts.DataSource = sourceTasks;

            cboAssign.SelectedIndex = 0;

            customer = new DataTable();
            vehicle = new DataTable();
            workOrder = new DataTable();
            tasks = new DataTable();
            parts = new DataTable();

            workOrder = dbConn.readQuery("SELECT * FROM WORKORDER WHERE WORKORDERID = " + workOrderID);
            customer = dbConn.readQuery("SELECT * FROM CUSTOMER WHERE CUSTOMERID = " + workOrder.Rows[0].Field<double>("CUSTOMERID"));
            vehicle = dbConn.readQuery("SELECT * FROM VEHICLE WHERE VIN = '" + workOrder.Rows[0].Field<string>("VEHICLEID") + "'");

            tasks = dbConn.readQuery("SELECT TASKUNIQ FROM TASK WHERE WORKORDERID = " + workOrderID + " ORDER BY TASKID");

            parts = dbConn.readQuery("SELECT PARTID, REQUESTED, TASKUNIQ FROM TASKPART WHERE WORKORDERID = " + workOrderID);

            

            sourceAvailParts.DataSource = availableParts;
            lstAvailableParts.DataSource = sourceAvailParts;

            

            dtpPromised.Value = DateTime.Now;

            refreshCxFields();
            setUpTaskColumns();
            setUpTaskForPartsColumns();
            
            

            loadTasks();
            setUpAssignPartsColumns(lstAvailableParts);
            
            
            addSavedPartsToTasks();
            sourcePartsForSelectedTask.DataSource = taskList[lstTasksForParts.CurrentRow.Index].PartsList;
            lstPartsForSelectedTask.DataSource = sourcePartsForSelectedTask;

            setUpAssignPartsColumns(lstPartsForSelectedTask);
            sourcePartsForSelectedTask.ResetBindings(false);
        }

        private void refreshCxFields()
        {
            //customer fields
            txtCxNum.Text = customer.Rows[0].Field<double>("CUSTOMERID").ToString();
            txtCxFirstName.Text = customer.Rows[0].Field<string>("FIRSTNAME");
            txtCxLastName.Text = customer.Rows[0].Field<string>("LASTNAME");
            txtHomePhone.Text = customer.Rows[0].Field<string>("PHONE");
            txtEmail.Text = customer.Rows[0].Field<string>("EMAIL");
            txtPostCode.Text = customer.Rows[0].Field<string>("POSTALCODE");
            txtAddress.Text = customer.Rows[0].Field<string>("STREETADDRESS");
            txtCity.Text = customer.Rows[0].Field<string>("CITY");
            txtProvince.Text = customer.Rows[0].Field<string>("PROVINCE");

            //vehicle fields
            txtVin.Text = vehicle.Rows[0].Field<string>("VIN");
            txtModel.Text = vehicle.Rows[0].Field<string>("MODEL");
            txtColour.Text = vehicle.Rows[0].Field<string>("COLOUR");
            txtYear.Text = vehicle.Rows[0].Field<double>("YEAR").ToString();
            txtPlateNum.Text = vehicle.Rows[0].Field<string>("LICENSEPLATE");

            //workOrder fields
            txtWorkOrderID.Text = workOrder.Rows[0].Field<double>("WORKORDERID").ToString();
            dtpPromised.Value = workOrder.Rows[0].Field<DateTime>("PROMISEDTIME");
            numRate.Value = (decimal)workOrder.Rows[0].Field<double>("RATE");
            numKmIn.Value = (decimal)workOrder.Rows[0].Field<double>("KMIN");
            var kmout = workOrder.Rows[0].Field<double?>("KMOUT") ?? 0.0;
            numKmOut.Value = (decimal)kmout;
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

        private void setUpTaskForPartsColumns()
        {
            lstTasksForParts.Columns["TaskID"].ReadOnly = true;
            lstTasksForParts.Columns["TaskTime"].ReadOnly = true;
            lstTasksForParts.Columns["Description"].ReadOnly = true;
            lstTasksForParts.Columns["Type"].ReadOnly = true;

            //ordering
            lstTasksForParts.Columns["TaskID"].DisplayIndex = 0;
            lstTasksForParts.Columns["TaskTime"].DisplayIndex = 1;
            lstTasksForParts.Columns["Description"].DisplayIndex = 2;
            lstTasksForParts.Columns["Type"].DisplayIndex = 3;


            //names
            lstTasksForParts.Columns["TaskID"].HeaderText = "Task Number";
            lstTasksForParts.Columns["TaskTime"].HeaderText = "Time";
            lstTasksForParts.Columns["Description"].HeaderText = "Description";
            lstTasksForParts.Columns["Type"].HeaderText = "Type";

            //visibility
            lstTasksForParts.Columns["Dirty"].Visible = false;
            lstTasksForParts.Columns["WorkOrderID"].Visible = false;

            
        }

        private void setUpAssignPartsColumns(DataGridView lstToSetUp)
        {
            //ordering
            lstToSetUp.Columns["Request"].DisplayIndex = 0;
            lstToSetUp.Columns["PartID"].DisplayIndex = 1;
            lstToSetUp.Columns["PartDescription"].DisplayIndex = 2;

            //names
            lstToSetUp.Columns["Request"].HeaderText = "Quantity";
            lstToSetUp.Columns["PartID"].HeaderText = "Part Number";
            lstToSetUp.Columns["PartDescription"].HeaderText = "Description";

            //visibility
            lstToSetUp.Columns["MinQuantity"].Visible = false;
            lstToSetUp.Columns["Section"].Visible = false;
            lstToSetUp.Columns["QuantityOnHand"].Visible = false;
            lstToSetUp.Columns["QuantityOnOrder"].Visible = false;
            lstToSetUp.Columns["Reserved"].Visible = false;
            lstToSetUp.Columns["Dirty"].Visible = false;
            lstToSetUp.Columns["CostPrice"].Visible = false;
            lstToSetUp.Columns["PurchaseIndicator"].Visible = false;
            lstToSetUp.Columns["TotalCost"].Visible = false;
            lstToSetUp.Columns["TotalList"].Visible = false;
            lstToSetUp.Columns["OrderedFor"].Visible = false;
            lstToSetUp.Columns["ListPrice"].Visible = false;
            lstToSetUp.Columns["Receive"].Visible = false;
            lstToSetUp.Columns["BackOrder"].Visible = false;
            lstToSetUp.Columns["Net"].Visible = false;
            lstToSetUp.Columns["Amount"].Visible = false;
            lstToSetUp.Columns["Deposit"].Visible = false;


            lstToSetUp.RowHeadersVisible = false;
        }

        private void loadTasks()
        {
            foreach (DataRow taskRow in tasks.Rows)
            {
                string idString = taskRow["TaskUniq"].ToString();
                int tempID = int.Parse(idString);

                Task addTask = new Task(tempID);
                if (addTask.load(dbConn))
                {
                    taskList.Add(addTask);
                }
            }

            loadCurrentTaskTechs(taskList[0]);
            sourceTasks.ResetBindings(false);
        }

        private void addSavedPartsToTasks()
        {
            foreach (DataRow row in parts.Rows)
            {
                Part addPart = new Part(row["PARTID"].ToString(), row["REQUESTED"].ToString());
                if (addPart.load(dbConn))
                {
                    string targetTaskUniq = row["TASKUNIQ"].ToString();
                    if (targetTaskUniq == "")
                    {
                        availableParts.Add(addPart);
                    }
                    else
                    {
                        foreach (Task t in taskList)
                        {
                            string thisTaskUniq = t.getUniq().ToString();
                            if (targetTaskUniq == thisTaskUniq)
                            {
                                t.PartsList.Add(addPart);
                            }
                        }
                    }
                }
            }

            sourceAvailParts.ResetBindings(false);
            sourcePartsForSelectedTask.ResetBindings(false);
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
            {
                loadCurrentTaskTechs(taskList[lstTasks.CurrentCell.RowIndex]);
            }
        }

        private void btnNewTask_Click(object sender, EventArgs e)
        {
            Task newTask = new Task(workOrderID);
            if (taskList.Count == 0)
                newTask.TaskID = 1;
            else
                newTask.TaskID = taskList[taskList.Count - 1].TaskID + 1;

            taskList.Add(newTask);
            

            sourceTasks.ResetBindings(false);
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (!lstTechnicians.Items.Contains(cboAssign.SelectedItem.ToString()))
            {
                taskList[lstTasks.CurrentCell.RowIndex].TechList.Add(cboAssign.SelectedItem.ToString());
                lstTechnicians.Items.Add(cboAssign.SelectedItem.ToString());
            }

            lstTechnicians.SelectedIndex = lstTechnicians.Items.Count - 1;
        }

        private void btnRemoveTech_Click(object sender, EventArgs e)
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

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            tasksToBeDeleted.Add(taskList[lstTasks.CurrentCell.RowIndex]);
            taskList.RemoveAt(lstTasks.CurrentCell.RowIndex);
            sourceTasks.ResetBindings(false);
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

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabParts && status != "INSERVICE")
            {
                e.Cancel = true;
                MessageBox.Show("You can only add parts if you're done and the car's awaiting pick up!");
            }
        }

        private void btnSaveAndClose_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string changedStatus = status;
            bool allTasksAssigned = true;
            if (taskList.Count == 0)
                allTasksAssigned = false;


            //write updated tasks
            foreach (Task t in taskList)
            {
                t.commit(dbConn);
                if (t.TechList.Count == 0)
                    allTasksAssigned = false;

                foreach (Part p in t.PartsList)
                {
                    dbConn.insertQuery("UPDATE TaskPart SET TaskUniq = " + t.getUniq()
                                     + " WHERE WorkOrderID = " + workOrderID 
                                     + " AND PartID = '" + p.PartID + "'");
                }
            }

            //delete deleted tasks from db
            foreach (Task t in tasksToBeDeleted)
            {
                //if you tried to delete a task with parts, set them free
                if (t.PartsList.Count != 0)
                {
                    foreach (Part p in t.PartsList)
                    {
                        availableParts.Add(p);
                    }
                    t.PartsList.Clear();
                }
                //DESTROY
                t.selfDestruct(dbConn);
            }

            //set the uniq of all taskparts still not in (or removed from) a task.
            foreach (Part p in availableParts)
            {
                dbConn.insertQuery("UPDATE TaskPart SET TaskUniq = ''"
                                 + " WHERE WorkOrderID = " + workOrderID
                                 + " AND PartID = '" + p.PartID + "'");
            }
            

            //prompt to change statuses
            if (allTasksAssigned && status == "UNASSIGNED")
            {
                DialogResult result = MessageBox.Show("All of the tasks are assigned, do you want to set this to 'On Hold'?", "Set to On Hold", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    changedStatus = "ONHOLD";
                }
            }

            if (availableParts.Count == 0 && status == "INSERVICE")
            {
                DialogResult result = MessageBox.Show("No parts left to add to tasks, do you want to set this to 'Awaiting Pick Up'?", "Set to Awaiting Pick Up", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    changedStatus = "AWAITINGPICKUP";
                }
            }

            //write updated wo items
            DateTime promisedTime = dtpPromised.Value;

            string formattedTime = promisedTime.ToString("yyyy-MM-dd HH:mm:ss");

            decimal rate = numRate.Value;
            decimal kmIn = numKmIn.Value;
            decimal kmOut = numKmOut.Value;

            dbConn.insertQuery("UPDATE WorkOrder "
                                 + "SET "
                                 + "PromisedTime = to_date('" + formattedTime + "', 'yyyy-MM-dd hh24:mi:ss'), "
                                 + "Rate = '" + rate + "', "
                                 + "KMin = '" + kmIn + "',"
                                 + "KMout = '" + kmOut + "',"
                                 + "Status ='" + changedStatus + "' "
                                 + "WHERE WorkOrderID = '" + workOrderID + "'");

            MessageBox.Show("Saved!");
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            while (lstAvailableParts.Rows.Count > 0)
            {
                btnAddSelected_Click(sender, e);
            }
        }

        private void btnAddSelected_Click(object sender, EventArgs e)
        {
            if (lstAvailableParts.Rows.Count > 0)
            {
                taskList[lstTasksForParts.CurrentRow.Index].PartsList.Add(availableParts[lstAvailableParts.CurrentRow.Index]);

                availableParts.Remove(taskList[lstTasksForParts.CurrentRow.Index].PartsList[taskList[lstTasksForParts.CurrentRow.Index].PartsList.Count - 1]);

                sourcePartsForSelectedTask.DataSource = taskList[lstTasksForParts.CurrentRow.Index].PartsList;

                setUpAssignPartsColumns(lstPartsForSelectedTask);
            }

            sourcePartsForSelectedTask.ResetBindings(false);
            sourceAvailParts.ResetBindings(false);
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (lstPartsForSelectedTask.Rows.Count > 0)
            {
                availableParts.Add(taskList[lstTasksForParts.CurrentRow.Index].PartsList[lstPartsForSelectedTask.CurrentRow.Index]);

                sourceAvailParts.ResetBindings(false);

                taskList[lstTasksForParts.CurrentRow.Index].PartsList.Remove(availableParts[lstAvailableParts.Rows.Count - 1]);

                sourcePartsForSelectedTask.DataSource = taskList[lstTasksForParts.CurrentRow.Index].PartsList;

                sourcePartsForSelectedTask.ResetBindings(false);
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            while (lstPartsForSelectedTask.Rows.Count > 0)
            {
                btnRemoveSelected_Click(sender, e);
            }
        }

        private void lstTasksForParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sourcePartsForSelectedTask.DataSource = taskList[lstTasksForParts.CurrentRow.Index].PartsList;
            sourcePartsForSelectedTask.ResetBindings(false);
        }
    }
}
