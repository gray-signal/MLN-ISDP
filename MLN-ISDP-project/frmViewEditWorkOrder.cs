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

        private string workOrderID;
        private string status;

        private DataTable customer;
        private DataTable vehicle;
        private DataTable workOrder;

        private DataTable tasks;

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

            sourceTasks.DataSource = taskList;

            lstTasks.DataSource = sourceTasks;

            cboAssign.SelectedIndex = 0;

            customer = new DataTable();
            vehicle = new DataTable();
            workOrder = new DataTable();
            tasks = new DataTable();

            workOrder = dbConn.readQuery("SELECT * FROM WORKORDER WHERE WORKORDERID = " + workOrderID);
            customer = dbConn.readQuery("SELECT * FROM CUSTOMER WHERE CUSTOMERID = " + workOrder.Rows[0].Field<double>("CUSTOMERID"));
            vehicle = dbConn.readQuery("SELECT * FROM VEHICLE WHERE VIN = '" + workOrder.Rows[0].Field<string>("VEHICLEID") + "'");

            tasks = dbConn.readQuery("SELECT TASKUNIQ FROM TASK WHERE WORKORDERID = " + workOrderID + " ORDER BY TASKID");


            refreshCxFields();
            setUpTaskColumns();

            loadTasks();
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
            loadCurrentTaskTechs(taskList[lstTasks.CurrentCell.RowIndex]);
        }

        private void btnNewTask_Click(object sender, EventArgs e)
        {
            Task newTask = new Task(workOrderID);

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
            taskList.RemoveAt(lstTasks.CurrentCell.RowIndex);
            sourceTasks.ResetBindings(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //write updated wo items

            //write updated tasks
            foreach (Task t in taskList)
            {
                t.commit(dbConn);
            }

            this.Close();
        }
    }
}
