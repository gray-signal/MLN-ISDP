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
        private string EmployeeID;

        private List<Part> selectedPartList;
        private List<Part> invoicePartList;
        private List<Part> orderPartList;

        private BindingSource sourceParts;
        private BindingSource sourceInvoice;
        private BindingSource sourceOrder;

        private DataTable discountTable;

        private Part selectedPart;

        private double grandTotal; //klugeing, sorry

        public Form1()
        {
            InitializeComponent();

            EmployeeID = "1234";

            selectedPartList = new List<Part>();
            orderPartList = new List<Part>();
            invoicePartList = new List<Part>();

            discountTable = new DataTable();

            sourceParts = new BindingSource();
            sourceParts.DataSource = selectedPartList;

            sourceInvoice = new BindingSource();
            sourceInvoice.DataSource = invoicePartList;

            sourceOrder = new BindingSource();
            sourceOrder.DataSource = orderPartList;

            discountTable = dbConn.readQuery("SELECT DiscountID, DiscountPercent, DiscountType from Discount ORDER BY DiscountPercent");

            cboDiscountType.ValueMember = "DiscountPercent";
            cboDiscountType.DisplayMember = "DiscountType";
            cboDiscountType.DataSource = discountTable;

            //lstPartsQuery.AutoGenerateColumns = true;


            lstPartsQuery.DataSource = sourceParts;
            lstPartsInvoice.DataSource = sourceInvoice;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Test.test();

            //sourceParts.ResetBindings(true);

            lookUpColumnSetUp();
            invoiceColumnSetUp();
        }

        private void lookUpColumnSetUp()
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
            lstPartsQuery.Columns["Dirty"].Visible = false;
            lstPartsQuery.Columns["Receive"].Visible = false;
            lstPartsQuery.Columns["BackOrder"].Visible = false;
            lstPartsQuery.Columns["Deposit"].Visible = false;
            lstPartsQuery.Columns["Net"].Visible = false;
            lstPartsQuery.Columns["Amount"].Visible = false;

            //formatting
            lstPartsQuery.Columns["CostPrice"].DefaultCellStyle.Format = "c";
            lstPartsQuery.Columns["ListPrice"].DefaultCellStyle.Format = "c";
            lstPartsQuery.Columns["TotalCost"].DefaultCellStyle.Format = "c";
            lstPartsQuery.Columns["TotalList"].DefaultCellStyle.Format = "c";

            //fuckery
            lstPartsQuery.Columns.Remove("PurchaseIndicator");

            var PurchaseIndicator = new DataGridViewComboBoxColumn();
            PurchaseIndicator.DataPropertyName = "PurchaseIndicator";
            lstPartsQuery.Columns.Add(PurchaseIndicator);

            PurchaseIndicator.HeaderText = "Indicator";
            PurchaseIndicator.DataSource = new List<Part.Indicator> { Part.Indicator.NONE, Part.Indicator.INVOICE, Part.Indicator.ORDER };

        }

        private void invoiceColumnSetUp()
        {
            //ordering
            lstPartsInvoice.Columns["PartID"].DisplayIndex = 0;
            lstPartsInvoice.Columns["PartDescription"].DisplayIndex = 1;
            lstPartsInvoice.Columns["Request"].DisplayIndex = 2;
            lstPartsInvoice.Columns["Receive"].DisplayIndex = 3;
            lstPartsInvoice.Columns["BackOrder"].DisplayIndex = 4;
            lstPartsInvoice.Columns["ListPrice"].DisplayIndex = 5;
            lstPartsInvoice.Columns["Deposit"].DisplayIndex = 7; //skipped a number because for some reason it just doesn't... count right? here?
            lstPartsInvoice.Columns["Net"].DisplayIndex = 8;     //and i have no idea why and no time to fuck with it, so this works
            lstPartsInvoice.Columns["Amount"].DisplayIndex = 9;


            //names
            lstPartsInvoice.Columns["Request"].HeaderText = "Order";
            lstPartsInvoice.Columns["BackOrder"].HeaderText = "B.O.";
            lstPartsInvoice.Columns["ListPrice"].HeaderText = "List ($)";
            lstPartsInvoice.Columns["Deposit"].HeaderText = "Deposit ($)";
            lstPartsInvoice.Columns["Net"].HeaderText = "Net ($)";
            lstPartsInvoice.Columns["Amount"].HeaderText = "Amount ($)";

            //visibility
            lstPartsInvoice.Columns["MinQuantity"].Visible = false;
            lstPartsInvoice.Columns["Section"].Visible = false;
            lstPartsInvoice.Columns["QuantityOnHand"].Visible = false;
            lstPartsInvoice.Columns["QuantityOnOrder"].Visible = false;
            lstPartsInvoice.Columns["Reserved"].Visible = false;
            lstPartsInvoice.Columns["Dirty"].Visible = false;
            lstPartsInvoice.Columns["CostPrice"].Visible = false;
            lstPartsInvoice.Columns["PurchaseIndicator"].Visible = false;
            lstPartsInvoice.Columns["TotalCost"].Visible = false;
            lstPartsInvoice.Columns["TotalList"].Visible = false;

            //formatting
            lstPartsInvoice.Columns["ListPrice"].DefaultCellStyle.Format = "c";
            lstPartsInvoice.Columns["Deposit"].DefaultCellStyle.Format = "c";
            lstPartsInvoice.Columns["Net"].DefaultCellStyle.Format = "c";
            lstPartsInvoice.Columns["Amount"].DefaultCellStyle.Format = "c";

        }

        //default db conn
        static System.Data.OleDb.OleDbConnectionStringBuilder csBuilder = new System.Data.OleDb.OleDbConnectionStringBuilder(
                "Provider=MSDAORA;Data Source=localhost;User ID=2023164;Password=#42Paradox;");
        static OracleDB dbConn = new OracleDB(csBuilder.ToString());

        private void calculateLookUpFields()
        {
            foreach (Part p in selectedPartList)
            {
                p.TotalCost = p.Request * (decimal)p.CostPrice;
                p.TotalList = p.Request * (decimal)p.ListPrice;
            }
        }

        private double calculateDeposit(Part p)
        {
            double totalDeposit = 0;

            if (p.BackOrder > 0)
            {
                totalDeposit = (double)(p.ListPrice * (numDepositPct.Value / 100));
            }

            return totalDeposit;
        }

        private double calculateNet(Part p)
        {
            double totalNet = 0;
            double discount = Double.Parse(cboDiscountType.SelectedValue.ToString());

            if (p.Receive > 0)
            {
                totalNet = (double)p.ListPrice;

                if (discount > 0)
                {
                    totalNet = totalNet - (totalNet * (discount / 100));
                }
            }

            if (p.BackOrder > 0)
            {
                totalNet = totalNet + p.Deposit;
            }

            return totalNet;
        }

        private double calculateAmount(Part p)
        {
            double totalAmount = 0;

            if (p.BackOrder > 0)
            {
                totalAmount = totalAmount + (p.Deposit * p.BackOrder);
            }

            if (p.Receive > 0)
            {
                totalAmount = totalAmount + ((p.Net - p.Deposit) * p.Receive);
            }

            return totalAmount;
        }

        private void calculateInvoiceFields()
        {
            double salesTax = .13;

            double totalDeposit = 0;
            double owedAfterDeposit = 0;
            double partsTotal = 0;
            double taxTotal = 0;
            grandTotal = 0;

            foreach (Part p in invoicePartList)
            {
                //calculate columns
                p.Deposit = calculateDeposit(p);
                p.Net = calculateNet(p);
                p.Amount = calculateAmount(p);

                //check quantity
                if (p.Request > p.QuantityOnHand)
                {
                    p.Receive = (int)p.QuantityOnHand;
                    p.BackOrder = p.Request - p.Receive;
                }
                else
                {
                    p.Receive = p.Request;
                    p.BackOrder = 0;
                }


                totalDeposit = totalDeposit + (p.Deposit * p.BackOrder);
                if (p.BackOrder > 0)
                {
                    owedAfterDeposit = owedAfterDeposit + (((double)p.ListPrice - p.Deposit) * p.BackOrder);
                }
                partsTotal = partsTotal + p.Amount;
            }

            taxTotal = partsTotal * salesTax;
            grandTotal = partsTotal + taxTotal;

            txtDepositAmt.Text = string.Format("{0:c}", totalDeposit);
            txtDepositRem.Text = string.Format("{0:c}", owedAfterDeposit);
            txtPartsTotal.Text = string.Format("{0:c}", partsTotal);
            txtSalesTax.Text = string.Format("{0:c}", taxTotal);
            txtGrandTotal.Text = string.Format("{0:c}", grandTotal);

            sourceInvoice.ResetBindings(false);
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
            if (!(e.RowIndex == -1))
            {
                selectedPart = selectedPartList[e.RowIndex];

                loadPartDetail(selectedPart);
            }
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

        private void lstPartsQuery_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //calculateFields();
            //tallyItems();

            //int editedRowIndex = lstPartsQuery.CurrentRow.Index;

            //Part editedPart = selectedPartList[editedRowIndex];

            //if (editedPart.Request > editedPart.QuantityOnHand)
            //{
            //    int difference = (int)(editedPart.Request - editedPart.QuantityOnHand);
            //    editedPart.QuantityOnOrder = editedPart.QuantityOnOrder + difference;
            //    editedPart.Request = (int)editedPart.QuantityOnHand;
            //}

            //selectedPartList[editedRowIndex] = editedPart;
        }

        #region Button Methods

        //lookup buttons

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
            calculateLookUpFields();
            sourceParts.ResetBindings(false);
        }

        private void btnSetOrder_Click(object sender, EventArgs e)
        {
            foreach (Part p in selectedPartList)
            {
                if (p.QuantityOnHand <= 0)
                {
                    p.PurchaseIndicator = Part.Indicator.ORDER;
                }
                if (p.Request <= 0)
                    p.Request = 1;
            }
            sourceParts.ResetBindings(false);
            tallyItems();
        }

        private void btnSetInvoice_Click(object sender, EventArgs e)
        {
            foreach (Part p in selectedPartList)
            {
                if (p.QuantityOnHand > 0)
                {
                    p.PurchaseIndicator = Part.Indicator.INVOICE;
                }
                if (p.Request <= 0)
                    p.Request = 1;
            }
            sourceParts.ResetBindings(false);
            tallyItems();
        }

        private void btnAddIndicated_Click(object sender, EventArgs e)
        {
            foreach (Part p in selectedPartList)
            {
                if (p.PurchaseIndicator == Part.Indicator.INVOICE || p.PurchaseIndicator == Part.Indicator.ORDER)
                {
                    invoicePartList.Add(p);
                }

            }

            foreach (Part p in invoicePartList)
                selectedPartList.Remove(p);

            sourceParts.ResetBindings(false);
            sourceInvoice.ResetBindings(false);

            calculateInvoiceFields();
        }

        //invoice buttons

        private void btnClearInvoice_Click(object sender, EventArgs e)
        {
            //TODO: add confirmation dialog to this
            invoicePartList.Clear();
            sourceInvoice.ResetBindings(false);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstPartsInvoice.Rows.Count > 0)
            {
                lstPartsInvoice.Rows.Remove(lstPartsInvoice.CurrentRow);
                sourceInvoice.ResetBindings(false);
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {

            string strDiscount = discountTable.Rows[cboDiscountType.SelectedIndex]["DiscountID"].ToString();

            DateTime current = DateTime.Now;

            string formattedCurrent = current.ToString("yyyy-MM-dd HH:mm:ss");

            dbConn.insertQuery("INSERT INTO Invoice "
                              + "(DateTime, Total, PaymentMethod, CustomerID, DiscountID, EmployeeID) "
                              + "VALUES (to_date('" + formattedCurrent + "', 'yyyy-MM-dd hh24:mi:ss'), '"
                              + grandTotal + "', NULL, '" + txtAccountNo.Text + "', '" + strDiscount + "', '" + EmployeeID + "')");

            DataTable dt = dbConn.readQuery("SELECT InvoiceID FROM Invoice WHERE DateTime = to_date('" + formattedCurrent + "', 'yyyy-MM-dd hh24:mi:ss')");
            string invID = (string)dt.Rows[0]["InvoiceID"];

            foreach (Part p in invoicePartList)
            {
                dbConn.insertQuery("INSERT INTO InvoiceDetails "
                                 + "(InvoiceID, PartID, Quantity) "
                                 + "VALUES ('" + invID + "', '" + p.PartID + "', '" + p.Receive + "')");

                p.commit(dbConn);
            }
        }

        #endregion

        private void lstPartsQuery_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            

            int editedRowIndex = lstPartsQuery.CurrentRow.Index;

            Part editedPart = selectedPartList[editedRowIndex];

            if (editedPart.Request > editedPart.QuantityOnHand)
            {
                int difference = (int)(editedPart.Request - editedPart.QuantityOnHand);
                editedPart.QuantityOnOrder = editedPart.QuantityOnOrder + difference;
                //editedPart.Request = (int)editedPart.QuantityOnHand;
            }

            editedPart.Dirty = true;

            selectedPartList[editedRowIndex] = editedPart;

            calculateLookUpFields();
            tallyItems();
        }

        private void lstPartsInvoice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int editedRowIndex = lstPartsInvoice.CurrentRow.Index;

            Part editedPart = invoicePartList[editedRowIndex];

            //do things to part here


            editedPart.Dirty = true;

            invoicePartList[editedRowIndex] = editedPart;

            calculateInvoiceFields();
        }

        private void cboDiscountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateInvoiceFields();
        }

        private void numDepositPct_ValueChanged(object sender, EventArgs e)
        {
            calculateInvoiceFields();
        }

        private void tabPartsActions_Selected(object sender, TabControlEventArgs e)
        {
            calculateInvoiceFields();
        }
    }
}