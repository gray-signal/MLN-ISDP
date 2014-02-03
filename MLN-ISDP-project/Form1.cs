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
    public partial class Form1 : Form
    {
        private List<Part> selectedPartList;
        private BindingSource sourceParts;
        private Part selectedPart;

        public Form1()
        {
            InitializeComponent();
            selectedPartList = new List<Part>();
            sourceParts = new BindingSource();
            sourceParts.DataSource = selectedPartList;



            //lstPartsQuery.AutoGenerateColumns = true;


            lstPartsQuery.DataSource = sourceParts;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Test.test();

            //sourceParts.ResetBindings(true);

            columnSetUp();
        }

        private void columnSetUp()
        {
            //lstPartsQuery.Columns["PartID"].CellType.

            //order
            lstPartsQuery.Columns["PartID"].DisplayIndex = 0;
            lstPartsQuery.Columns["PartDescription"].DisplayIndex = 1;
            lstPartsQuery.Columns["QuantityOnHand"].DisplayIndex = 2;
            lstPartsQuery.Columns["Request"].DisplayIndex = 3;
            lstPartsQuery.Columns["CostPrice"].DisplayIndex = 4;
            lstPartsQuery.Columns["ListPrice"].DisplayIndex = 5;
            lstPartsQuery.Columns["TotalCost"].DisplayIndex = 6;
            lstPartsQuery.Columns["TotalList"].DisplayIndex = 7;
            lstPartsQuery.Columns["PurchaseIndicator"].DisplayIndex = 8;

            //names
            lstPartsQuery.Columns["PartID"].HeaderText = "Part ID";
            lstPartsQuery.Columns["PartDescription"].HeaderText = "Description";
            lstPartsQuery.Columns["ListPrice"].HeaderText = "List ($)";
            lstPartsQuery.Columns["CostPrice"].HeaderText = "Cost ($)";
            lstPartsQuery.Columns["TotalCost"].HeaderText = "Total Cost ($)";
            lstPartsQuery.Columns["TotalList"].HeaderText = "Total List ($)";
            lstPartsQuery.Columns["QuantityOnHand"].HeaderText = "Q.O.H.";
            lstPartsQuery.Columns["QuantityOnOrder"].HeaderText = "Quantity On Order";
            lstPartsQuery.Columns["PurchaseIndicator"].HeaderText = "Indicator";


            //visibility
            lstPartsQuery.Columns["MinQuantity"].Visible = false;
            lstPartsQuery.Columns["Section"].Visible = false;
            lstPartsQuery.Columns["QuantityOnOrder"].Visible = false;
            lstPartsQuery.Columns["Reserved"].Visible = false;

            //fuckery
            lstPartsQuery.Columns.Remove("PurchaseIndicator");

            var PurchaseIndicator = new DataGridViewComboBoxColumn();
            PurchaseIndicator.DataPropertyName = "PurchaseIndicator";
            lstPartsQuery.Columns.Add(PurchaseIndicator);

            PurchaseIndicator.HeaderText = "Indicator";
            PurchaseIndicator.DataSource = new List<Part.Indicator> { Part.Indicator.NONE, Part.Indicator.INVOICE, Part.Indicator.ORDER };

        }

        //default db conn
        static System.Data.OleDb.OleDbConnectionStringBuilder csBuilder = new System.Data.OleDb.OleDbConnectionStringBuilder(
                "Provider=MSDAORA;Data Source=localhost;User ID=2023164;Password=#42Paradox;");
        static OracleDB dbConn = new OracleDB(csBuilder.ToString());

        private void calculateFields()
        {
            foreach (Part p in selectedPartList)
            {
                p.TotalCost = p.Request * (decimal)p.CostPrice;
                p.TotalList = p.Request * (decimal)p.ListPrice;
            }
        }

        private void tallyItems()
        {
            decimal orderCostTotal = 0;
            decimal orderListTotal = 0;

            decimal invoiceCostTotal = 0;
            decimal invoiceListTotal = 0;

            List<Part> markedForDeletion = new List<Part>();

            foreach (Part p in selectedPartList)
            {
                if (p.PurchaseIndicator == Part.Indicator.ORDER)
                {
                    orderCostTotal = orderCostTotal + (decimal)p.TotalCost;
                    orderListTotal = orderListTotal + (decimal)p.TotalList;
                }

                if (p.PurchaseIndicator == Part.Indicator.INVOICE)
                {
                    invoiceCostTotal = invoiceCostTotal + (decimal)p.TotalCost;
                    invoiceListTotal = invoiceListTotal + (decimal)p.TotalList;
                }


            }

            txtOrderCost.Text = "$" + orderCostTotal;
            txtOrderList.Text = "$" + orderListTotal;
            txtInvCost.Text = "$" + invoiceCostTotal;
            txtInvList.Text = "$" + invoiceListTotal;
        }

        private void lstPartsQuery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedPart = selectedPartList[e.RowIndex];

            loadPartDetail(selectedPart);
        }

        private void loadPartDetail(Part detailedPart)
        {
            if (detailedPart != null)
            {
                txtPartNum.Text = detailedPart.PartID;
                txtDescription.Text = detailedPart.PartDescription;
                txtSection.Text = detailedPart.Section.ToString();
                txtQOH.Text = detailedPart.QuantityOnHand.ToString();
                txtQOO.Text = detailedPart.QuantityOnOrder.ToString();
            }
        }

        #region Button Methods

        private void btnAddParts_Click(object sender, EventArgs e)
        {
            Part addPart;
            String dialogText = "Please enter Part Number to add.";
            string promptValue;
            do
            {
                promptValue = PartSearchModal.ShowDialog(dialogText, "Part Number");

                //Part addPart = new Database.PersistenceFactory().Create<Part>(promptValue);
                addPart = new Part(promptValue);

                dialogText = "Part number not found. Please enter Part Number.";

            } while (!addPart.load(dbConn) && promptValue != "");

            if (promptValue != "")
            {
                selectedPartList.Add(addPart);
                sourceParts.ResetBindings(false);
            }

            if (selectedPart == null || selectedPart.PartID.Equals("NO PART"))
            {
                selectedPart = addPart;
            }

            loadPartDetail(selectedPart);
            tallyItems();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //TODO: add confirmation dialog to this
            selectedPartList.Clear();
            sourceParts.ResetBindings(false);
        }

        private void btnLoadParts_Click(object sender, EventArgs e)
        {
            //send file to FAST parsing class, returns some sort of collection of Parts
            //List<Part> partsFromFast;
            //foreach (Part p in partsFromFast)
            //{
            //    selectedPartList.Add(p);
            //    sourceParts.ResetBindings(false);
            //}

            tallyItems();
            calculateFields();
            sourceParts.ResetBindings(false);
        }

        private void btnSetOrder_Click(object sender, EventArgs e)
        {
            foreach (Part p in selectedPartList)
            {
                if (p.QuantityOnHand > 0)
                {
                    p.PurchaseIndicator = Part.Indicator.ORDER;
                }
                sourceParts.ResetBindings(false);
            }

            tallyItems();
        }

        private void btnSetInvoice_Click(object sender, EventArgs e)
        {
            foreach (Part p in selectedPartList)
            {
                if (p.QuantityOnHand <= 0)
                {
                    p.PurchaseIndicator = Part.Indicator.INVOICE;
                }
                sourceParts.ResetBindings(false);
            }
            tallyItems();
        }

        #endregion
    }
}
