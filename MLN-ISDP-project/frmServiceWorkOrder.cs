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
    public partial class frmServiceWorkOrder : Form
    {

        static System.Data.OleDb.OleDbConnectionStringBuilder csBuilder = new System.Data.OleDb.OleDbConnectionStringBuilder(
                "Provider=MSDAORA;Data Source=localhost;User ID=2023164;Password=#42Paradox;");
        static OracleDB dbConn = new OracleDB(csBuilder.ToString());

        DataTable workOrderTasks;

        public frmServiceWorkOrder()
        {
            InitializeComponent();

            workOrderTasks = new DataTable();

            workOrderTasks.Columns.Add("TaskValue");
            workOrderTasks.PrimaryKey = new DataColumn[] { workOrderTasks.Columns["TaskValue"] };
            

            workOrderTasks.Columns.Add("TaskTime");
            workOrderTasks.Columns.Add("TypeValue");
            workOrderTasks.Columns.Add("Description");
            workOrderTasks.Columns.Add("Technicians");

            cboAssign.SelectedIndex = 0;
            cboType.SelectedIndex = 0;

            cboTask.Items.Add(1);
            cboTask.Items.Add("Add new task");

            cboTask.SelectedIndex = 0;

            dataGridView1.DataSource = workOrderTasks;

            dtpPromised.Value = DateTime.Now;
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
            string vehicleID = cboVehicle.SelectedValue.ToString();

            DataTable vehicle = dbConn.readQuery("SELECT * from Vehicle where VIN = '" + vehicleID + "'");

            txtVin.Text = vehicle.Rows[0].Field<string>("VIN");
            txtModel.Text = vehicle.Rows[0].Field<string>("MODEL");
            txtColour.Text = vehicle.Rows[0].Field<string>("COLOUR");
            txtYear.Text = Convert.ToString(vehicle.Rows[0].Field<double>("YEAR"));
            txtPlateNum.Text = vehicle.Rows[0].Field<string>("LICENSEPLATE");
            //txtWarrantyExp.Text = vehicle.Rows[0].Field<string>("WARRANTY");

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
            int selectedIndex = lstTasks.SelectedIndex;
            if (selectedIndex != -1)
            {
                workOrderTasks.Rows.Remove(workOrderTasks.Rows[lstTasks.SelectedIndex]);
                lstTasks.Items.RemoveAt(lstTasks.SelectedIndex);

                if (lstTasks.SelectedIndex == -1 && lstTasks.Items.Count > 0)
                    lstTasks.SelectedIndex = 0;
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {

            if (lstTasks.FindString(cboTask.SelectedItem.ToString() + " - ") != ListBox.NoMatches)
            {
                workOrderTasks.Rows.Remove(workOrderTasks.Rows.Find(cboTask.SelectedItem.ToString()));
                lstTasks.Items.RemoveAt(lstTasks.FindString(cboTask.SelectedItem.ToString() + " - "));
            }

            if (lstTechnicians.Items.Count < 1)
            {
                MessageBox.Show("Please assign at least one technician.");
            }
            else
            {

                string descSummary = "";
                if (txtDescription.Text.Length > 15)
                {
                    descSummary = txtDescription.Text.Substring(0, 15);
                }
                else
                {
                    descSummary = txtDescription.Text;
                }
                if (txtDescription.Text.Equals("")) descSummary = "no description";

                lstTasks.Items.Add(cboTask.SelectedItem + " - " + descSummary);

                string techs = "";

                foreach (string tech in lstTechnicians.Items)
                {
                    techs = techs + tech + ", ";
                }

                workOrderTasks.Rows.Add(

                    cboTask.SelectedItem,
                    numTaskTime.Value,
                    cboType.SelectedItem,
                    txtDescription.Text,
                    techs
                );


                lstTasks.SelectedIndex = lstTasks.Items.Count - 1;

                dtpPromised_ValueChanged(sender, e);
            }

        }

        private void cboTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboTask_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if the last item is selected. means new task
            if (cboTask.SelectedIndex == (cboTask.Items.Count - 1))
            {
                cboTask.Items.Remove("Add new task");
                cboTask.Items.Add(cboTask.Items.Count + 1);

                cboTask.SelectedIndex = cboTask.Items.Count - 1;

                cboTask.Items.Add("Add new task");
            }

            //reset when new task is changed.
            //if it's new, this stays reset, but if it's a saved task, then these will be overwritten next up anyway
            numTaskTime.Value = 0;
            cboType.SelectedIndex = 0;
            cboAssign.SelectedItem = 0;
            txtDescription.Text = "";


            //all else, means task is being switched
            DataRow selectedTask = workOrderTasks.Rows.Find(cboTask.SelectedIndex + 1);

            if (selectedTask != null)
            {
                numTaskTime.Value = Decimal.Parse(selectedTask.Field<string>("TaskTime"));
                cboType.SelectedItem = selectedTask.Field<string>("TypeValue");
                txtDescription.Text = selectedTask.Field<string>("Description");
                //lstTechnicians.Items.AddRange(selectedTask.Field<ListBox.ObjectCollection>("Technicians"));
                lstTechnicians.Items.Clear();
                string tempTech = "";
                foreach (var letter in selectedTask.Field<string>("Technicians"))
                {
                    if (letter.Equals(','))
                    {
                        lstTechnicians.Items.Add(tempTech.Trim());
                        tempTech = "";
                    }
                    else
                    {
                        tempTech = tempTech + letter;
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            numRate.Value = 0;
            numKmIn.Value = 0;
            numKmOut.Value = 0;

            cboTask.Items.Clear();
            cboTask.Items.Add(1);
            cboTask.Items.Add("Add new task");

            numTaskTime.Value = 0;

            lstTasks.Items.Clear();
            lstTechnicians.Items.Clear();
            txtDescription.Text = "";

            cboType.SelectedIndex = 0;
            cboAssign.SelectedIndex = 0;

            workOrderTasks.Clear();
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
                                 + "(PromisedTime, Rate, KMin, CustomerID, VehicleID) "
                                 + "Values (to_date('" + formattedTime + "', 'yyyy-MM-dd hh24:mi:ss'), '"
                                 + rate + "', '" + kmIn + "', '" + cxNum + "', '" + txtVin.Text + "')");

                DataTable dt = dbConn.readQuery("SELECT WorkOrderID FROM WorkOrder WHERE PromisedTime = to_date('" + formattedTime + "', 'yyyy-MM-dd hh24:mi:ss')");
                double woID = (double)dt.Rows[0]["WorkOrderID"];

                foreach (DataRow dr in workOrderTasks.Rows)
                {
                    string value = dr.Field<string>("TaskValue");
                    string time = dr.Field<string>("TaskTime");
                    string type = dr.Field<string>("TypeValue");
                    string desc = dr.Field<string>("Description");
                    string tech = dr.Field<string>("Technicians");

                    dbConn.insertQuery("INSERT INTO Task "
                                     + "(TaskID, TaskTime, Type, TechList, Description, WorkOrderID) "
                                     + "Values ('" + value + "', '" + time + "', '" + type + "', '" + tech + "', '" + desc + "', '" + woID + "')");
                }

                btnReset_Click(sender, e);
            }
        }

        private void dtpPromised_ValueChanged(object sender, EventArgs e)
        {
            double sumHours = 0;
            foreach (DataRow row in workOrderTasks.Rows)
            {
                var temp = Double.Parse(row.Field<string>("TaskTime"));
                sumHours = sumHours + temp;
            }

            TimeSpan hours = TimeSpan.FromHours(sumHours);

            DateTime minPromised = DateTime.Now + hours;

            if (dtpPromised.Value < minPromised)
            {
                dtpPromised.Value = minPromised;
            }
        }


    }
}
