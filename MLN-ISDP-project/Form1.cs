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

        //klugeing, sorry
        private double grandTotal; 
        private double depositTotal;
        private double partsTotal;
        private double taxTotal;
        double owedAfterDeposit;

        public Form1()
        {
            InitializeComponent();

            //initialize temp value
            EmployeeID = "1234";

            //initializing a whole bunch, setting datasources
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

            //read in the discount types and then stick them into the proper combobox
            discountTable = dbConn.readQuery("SELECT DiscountID, DiscountPercent, DiscountType from Discount ORDER BY DiscountPercent");

            cboDiscountType.ValueMember = "DiscountPercent";
            cboDiscountType.DisplayMember = "DiscountType";
            cboDiscountType.DataSource = discountTable;

            //sets the datasources to the proper binding sources which were set to List<Part>'s
            lstPartsQuery.DataSource = sourceParts;
            lstPartsInvoice.DataSource = sourceInvoice;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Test.test(); // test class, ignore safely

            //soon as we load, set up the datagrid view columns
            lookUpColumnSetUp();
            invoiceColumnSetUp();
        }

        private void lookUpColumnSetUp()
        {
            //ordering
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

            //fuckery, just to get the indicator as a combobox column
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

        //default db connection
        static System.Data.OleDb.OleDbConnectionStringBuilder csBuilder = new System.Data.OleDb.OleDbConnectionStringBuilder(
                "Provider=MSDAORA;Data Source=localhost;User ID=2023164;Password=#42Paradox;");
        static OracleDB dbConn = new OracleDB(csBuilder.ToString());

        private void calculateLookUpFields()
        {
            //iterate selected parts, total the costs
            foreach (Part p in selectedPartList)
            {
                p.TotalCost = p.Request * (decimal)p.CostPrice;
                p.TotalList = p.Request * (decimal)p.ListPrice;

                //flag them as edited
                p.Dirty = true;
            }
        }

        private double calculateDeposit(Part p)
        {
            double totalDeposit = 0;

            //if any are being backordered, set the deposit price
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

            //if any are being purchased now, set the price, and apply a dicount if any
            if (p.Receive > 0)
            {
                totalNet = (double)p.ListPrice;

                if (discount > 0)
                {
                    totalNet = totalNet - (totalNet * (discount / 100));
                }
            }

            //if any on backorder, add the deposit to the net value
            if (p.BackOrder > 0)
            {
                totalNet = totalNet + p.Deposit;
            }

            return totalNet;
        }

        private double calculateAmount(Part p)
        {
            double totalAmount = 0;

            //if on backorder, add the deposits to the total amount
            if (p.BackOrder > 0)
            {
                totalAmount = totalAmount + (p.Deposit * p.BackOrder);
            }

            //if any being picked up, add their value to the total amount
            if (p.Receive > 0)
            {
                //have to separate back out the deposit amount, as it's been added in
                totalAmount = totalAmount + ((p.Net - p.Deposit) * p.Receive); 
            }

            return totalAmount;
        }

        private void calculateInvoiceFields()
        {
            double salesTax = .13;

            owedAfterDeposit = 0;
            
            depositTotal = 0;
            partsTotal = 0;
            taxTotal = 0;
            grandTotal = 0;

            //iterate each part and calculate all its fields
            foreach (Part p in invoicePartList)
            {
                //calculate columns
                p.Deposit = calculateDeposit(p);
                p.Net = calculateNet(p);
                p.Amount = calculateAmount(p);

                //check quantity and error correct
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

                //running total of deposit, parts, etc. amounts for text fields
                depositTotal = depositTotal + (p.Deposit * p.BackOrder);
                if (p.BackOrder > 0)
                {
                    owedAfterDeposit = owedAfterDeposit + (((double)p.ListPrice - p.Deposit) * p.BackOrder);
                }

                partsTotal = partsTotal + p.Amount;

                p.Dirty = true;
            }

            //calc tax and final totals, add to text fields
            taxTotal = partsTotal * salesTax;
            grandTotal = partsTotal + taxTotal;

            txtDepositAmt.Text = string.Format("{0:c}", depositTotal);
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

            //iterate parts list (i do this a lot) and total some fields
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
            //if there are rows, assign the current part and load its details
            if (!(e.RowIndex == -1))
            {
                selectedPart = selectedPartList[e.RowIndex];

                loadPartDetail(selectedPart);
            }
        }

        private void loadPartDetail(Part detailedPart)
        {
            //if that part isn't null, stick all its values into text fields
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
            //TODO: remove this method and handler for it
        }

        #region Button Methods

        //lookup buttons

        private void btnAddParts_Click(object sender, EventArgs e)
        {
            Part addPart;
            String dialogText = "Please enter Part Number to add.";
            string promptValue;

            //loop until a valid part is returned, or cancel is clicked
            do
            {
                //show the prompt
                promptValue = PartSearchModal.ShowDialog(dialogText, "Part Number");

                //Part addPart = new Database.PersistenceFactory().Create<Part>(promptValue); //i was messing with factory patterns, ignore this too

                //create the new part (will always work, but won't always be able to load)
                addPart = new Part(promptValue);

                //resets the text in case we do end up looping
                dialogText = "Part number not found. Please enter Part Number.";

            } while (!addPart.load(dbConn) && promptValue != ""); //tries to load the part from the db. they're smart enough, they can load themselves

            //if not cancelled, add the part to the list and refresh
            if (promptValue != "")
            {
                selectedPartList.Add(addPart);
                sourceParts.ResetBindings(false);
            }

            //if the current part selection is null or an empty part, select this one
            if (selectedPart == null || selectedPart.PartID.Equals("NO PART"))
            {
                selectedPart = addPart;
            }

            //load that detail in and retally stuff
            loadPartDetail(selectedPart);
            tallyItems();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //TODO: add confirmation dialog to this
            //clears out the whole damn list
            selectedPartList.Clear();
            sourceParts.ResetBindings(false);
        }

        private void btnLoadParts_Click(object sender, EventArgs e)
        {
            //send file to FAST parsing class, returns some sort of collection of Parts
            //List<Part> partsFromFast = FastParser(filename);
            //foreach (Part p in partsFromFast)
            //{
            //    selectedPartList.Add(p);
            //    sourceParts.ResetBindings(false);
            //}

            //leave these uncommented, so we have a nudge button, i guess
            tallyItems();
            calculateLookUpFields();
            sourceParts.ResetBindings(false);
        }

        private void btnSetOrder_Click(object sender, EventArgs e)
        {
            //loops parts, and if we haven't got 'em, sets them to order. and if none are selected, sets it to one as a default
            foreach (Part p in selectedPartList)
            {
                if (p.QuantityOnHand <= 0)
                {
                    p.PurchaseIndicator = Part.Indicator.ORDER;
                    if (p.Request <= 0)
                        p.Request = 1;

                    p.Dirty = true;
                }
            }
                
            sourceParts.ResetBindings(false);
            tallyItems();
        }

        private void btnSetInvoice_Click(object sender, EventArgs e)
        {
            //loops parts, and if there's any around, sets them to invoice. sets the request to at least one, just in case
            foreach (Part p in selectedPartList)
            {
                if (p.QuantityOnHand > 0)
                {
                    p.PurchaseIndicator = Part.Indicator.INVOICE;
                    if (p.Request <= 0)
                        p.Request = 1;

                    p.Dirty = true;
                }
                
            }
            sourceParts.ResetBindings(false);
            tallyItems();
        }

        private void btnAddIndicated_Click(object sender, EventArgs e)
        {
            //loops parts, if they're indicated, adds them to the list backing the other dgv
            foreach (Part p in selectedPartList)
            {
                if (p.PurchaseIndicator == Part.Indicator.INVOICE || p.PurchaseIndicator == Part.Indicator.ORDER)
                {
                    invoicePartList.Add(p);
                }

            }

            //i didn't really expect this to work, so it's mostly magic happening
            //if i get some time, i'll look into how c# compares objects.
            //are the parts in the lookup list the SAME parts as in the invoice list? i really hope not.
            //but this removes them regardless. maybe it compares properties? dunno.
            foreach (Part p in invoicePartList)
                selectedPartList.Remove(p);

            //reset BOTH dgvs, and calculate the new fields.
            sourceParts.ResetBindings(false);
            sourceInvoice.ResetBindings(false);

            calculateInvoiceFields();
        }

        //invoice buttons

        private void btnClearInvoice_Click(object sender, EventArgs e)
        {
            //TODO: add confirmation dialog to this
            //clears this one
            invoicePartList.Clear();
            sourceInvoice.ResetBindings(false);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //if there are any rows, clear the current one. ran into some weirdness, so i added the check. might not need it anymore
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

            //inserts the data on the invoice into the table. primary keys are autogenerated from a seq, so no worries there.
            dbConn.insertQuery("INSERT INTO Invoice "
                              + "(DateTime, Total, PaymentMethod, CustomerID, DiscountID, EmployeeID, PartsTotal, DepositTotal, TaxTotal, BalanceOwed) "
                              + "VALUES (to_date('" + formattedCurrent + "', 'yyyy-MM-dd hh24:mi:ss'), '"
                              + grandTotal + "', NULL, '" + txtAccountNo.Text + "', '" + strDiscount + "', '" + EmployeeID + "', '"
                              + partsTotal + "', '" + depositTotal + "', '" + taxTotal + "', '" + owedAfterDeposit + "')");

            //we save the date and use it to pull the generated PK back in. i could modify my oracle class to return a value, but that's too much digression
            DataTable dt = dbConn.readQuery("SELECT InvoiceID FROM Invoice WHERE DateTime = to_date('" + formattedCurrent + "', 'yyyy-MM-dd hh24:mi:ss')");
            string invID = (string)dt.Rows[0]["InvoiceID"];

            //loops the parts, writes invoice line data.
            //and then the parts save themselves, just like they loaded themselves before
            foreach (Part p in invoicePartList)
            {
                dbConn.insertQuery("INSERT INTO InvoiceDetails "
                                 + "(InvoiceID, PartID, Request, Receive, BackOrder, Net, Amount) "
                                 + "VALUES ('" + invID + "', '" + p.PartID + "', '" + p.Request + "', '"
                                 + p.Receive + "', '" + p.BackOrder + "', '" + p.Net + "', '" + p.Amount  + "')");

                p.commit(dbConn);
            }

            //don't know if i should do this, but there's no other way of indicating that it worked as of yet?
            btnClearInvoice_Click(sender, e);
        }

        #endregion

        //when a cell has been edited, run some checks and updates
        private void lstPartsQuery_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            

            int editedRowIndex = lstPartsQuery.CurrentRow.Index;

            //pull the part to edit out
            Part editedPart = selectedPartList[editedRowIndex];

            //if they're askin' for more than we've got, correct them.
            if (editedPart.Request > editedPart.QuantityOnHand)
            {
                int difference = (int)(editedPart.Request - editedPart.QuantityOnHand);
                editedPart.QuantityOnOrder = editedPart.QuantityOnOrder + difference;
            }

            editedPart.Dirty = true;

            //stick the edited part back in
            selectedPartList[editedRowIndex] = editedPart;

            calculateLookUpFields();
            tallyItems();
        }

        private void lstPartsInvoice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int editedRowIndex = lstPartsInvoice.CurrentRow.Index;

            Part editedPart = invoicePartList[editedRowIndex];

            //do things to part here, if we had anything to do. but we don't yet


            editedPart.Dirty = true;

            invoicePartList[editedRowIndex] = editedPart;

            //refresh the fields every time any damn thing changes
            calculateInvoiceFields();
        }


        //like when the discount changes
        private void cboDiscountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateInvoiceFields();
        }

        //or when the deposit percentage changes
        private void numDepositPct_ValueChanged(object sender, EventArgs e)
        {
            calculateInvoiceFields();
        }

        //even when we select this damn tab, just in case
        private void tabPartsActions_Selected(object sender, TabControlEventArgs e)
        {
            calculateInvoiceFields();
        }
    }
}