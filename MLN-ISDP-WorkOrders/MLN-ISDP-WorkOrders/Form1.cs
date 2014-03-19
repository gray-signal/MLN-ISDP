using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MLN_ISDP_WorkOrders
{
    public partial class Form1 : Form
    {

        static System.Data.OleDb.OleDbConnectionStringBuilder csBuilder = new System.Data.OleDb.OleDbConnectionStringBuilder(
                "Provider=MSDAORA;Data Source=localhost;User ID=2023164;Password=#42Paradox;");
        static OracleDB dbConn = new OracleDB(csBuilder.ToString());

        DataTable workOrderTasks;

        public Form1()
        {
            InitializeComponent();

            workOrderTasks = new DataTable();

            workOrderTasks.Columns.Add("TaskValue");
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

                populateCxInfo(selectedCxID);

                DataTable vehicles = dbConn.readQuery("SELECT * from Vehicle where OwnerID = " + selectedCxID);

                cboVehicle.DisplayMember = "MODEL";
                cboVehicle.ValueMember = "VIN";
                cboVehicle.DataSource = vehicles;
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
            if (lstTasks.FindString(cboTask.SelectedItem.ToString() + " - ") == ListBox.NoMatches)
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

                workOrderTasks.Rows.Add(

                    cboTask.SelectedItem,
                    numTaskTime.Value,
                    cboType.SelectedItem,
                    txtDescription.Text,
                    lstTechnicians.Items
                );

                lstTasks.SelectedIndex = lstTasks.Items.Count - 1;
            }
        }

        private void cboTask_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboTask.SelectedIndex == (cboTask.Items.Count - 1))
            {
                cboTask.Items.Remove("Add new task");
                cboTask.Items.Add(cboTask.Items.Count + 1);

                cboTask.SelectedIndex = cboTask.Items.Count - 1;

                cboTask.Items.Add("Add new task");
            }
        }

        private void cboTask_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
