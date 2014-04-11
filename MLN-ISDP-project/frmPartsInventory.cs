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
    public partial class frmPartsInventory : Form
    {
        private string EmployeeID;

        private List<Part> selectedPartList;
        private List<Part> invoicePartList;
        private List<Part> orderPartList;
        private List<Part> spOrderPartList;
        private List<Part> spOrderPartViewList;
        private List<Part> workOrderPartList;

        private BindingSource sourceParts;
        private BindingSource sourceInvoice;
        private BindingSource sourceOrder;
        private BindingSource sourceSpOrder;
        private BindingSource sourceSpOrderView;
        private BindingSource sourceWorkOrder;

        private DataTable discountTable;
        private DataTable workOrderTable;

        private Part selectedPart;

        //klugeing, sorry
        private double grandTotal; 
        private double depositTotal;
        private double partsTotal;
        private double taxTotal;
        double owedAfterDeposit;
        private double owedDepositTax;

        private string activeWOID;

        public frmPartsInventory()
        {
            InitializeComponent();

            //initialize temp value
            EmployeeID = "1234";

            //initializing a whole bunch, setting datasources
            selectedPartList = new List<Part>();
            orderPartList = new List<Part>();
            invoicePartList = new List<Part>();
            spOrderPartList = new List<Part>();
            spOrderPartViewList = new List<Part>();
            workOrderPartList = new List<Part>();

            discountTable = new DataTable();
            workOrderTable = new DataTable();

            sourceParts = new BindingSource();
            sourceParts.DataSource = selectedPartList;

            sourceInvoice = new BindingSource();
            sourceInvoice.DataSource = invoicePartList;

            sourceOrder = new BindingSource();
            sourceOrder.DataSource = orderPartList;

            sourceSpOrder = new BindingSource();
            sourceSpOrder.DataSource = spOrderPartList;

            sourceSpOrderView = new BindingSource();
            sourceSpOrderView.DataSource = spOrderPartViewList;

            sourceWorkOrder = new BindingSource();
            sourceWorkOrder.DataSource = workOrderPartList;

            //read in the discount types and then stick them into the proper combobox
            discountTable = dbConn.readQuery("SELECT DiscountID, DiscountPercent, DiscountType from Discount ORDER BY DiscountPercent");

            //
            workOrderTable = dbConn.readQuery(@"Select WORKORDER.WORKORDERID,CUSTOMER.FIRSTNAME, CUSTOMER.LASTNAME, VEHICLE.MODEL, VEHICLE.YEAR, VEHICLE.LICENSEPLATE, VEHICLE.COLOUR
From
  WORKORDER Inner Join
  VEHICLE On WORKORDER.VEHICLEID = VEHICLE.VIN Inner Join
  CUSTOMER On WORKORDER.CUSTOMERID = CUSTOMER.CUSTOMERID And
    VEHICLE.OWNERID = CUSTOMER.CUSTOMERID
Order By
  WORKORDER.WORKORDERID Desc");

            cboDiscountType.ValueMember = "DiscountPercent";
            cboDiscountType.DisplayMember = "DiscountType";
            cboDiscountType.DataSource = discountTable;

            lstInServWO.DataSource = workOrderTable;

            //sets the datasources to the proper binding sources which were set to List<Part>'s
            lstPartsQuery.DataSource = sourceParts;
            lstPartsInvoice.DataSource = sourceInvoice;
            lstPartsOrder.DataSource = sourceOrder;
            lstPartsSpOrder.DataSource = sourceSpOrder;
            lstPartsSpOrderView.DataSource = sourceSpOrderView;
            lstPartReq.DataSource = sourceWorkOrder;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Test.test(); // test class, ignore safely

            //soon as we load, set up the datagrid view columns
            lookUpColumnSetUp();
            invoiceColumnSetUp();
            orderColumnSetup();
            spOrderColumnSetUp();
            spOrderViewColumnSetUp();
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
            lstPartsQuery.Columns["OrderedFor"].Visible = false;

            //formatting currency
            lstPartsQuery.Columns["CostPrice"].DefaultCellStyle.Format = "c";
            lstPartsQuery.Columns["ListPrice"].DefaultCellStyle.Format = "c";
            lstPartsQuery.Columns["TotalCost"].DefaultCellStyle.Format = "c";
            lstPartsQuery.Columns["TotalList"].DefaultCellStyle.Format = "c";

            //formatting nums right justified
            lstPartsQuery.Columns["CostPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            lstPartsQuery.Columns["ListPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            lstPartsQuery.Columns["TotalCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            lstPartsQuery.Columns["TotalList"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //fuckery, just to get the indicator as a combobox column
            lstPartsQuery.Columns.Remove("PurchaseIndicator");

            var PurchaseIndicator = new DataGridViewComboBoxColumn();
            PurchaseIndicator.DataPropertyName = "PurchaseIndicator";
            lstPartsQuery.Columns.Add(PurchaseIndicator);

            PurchaseIndicator.HeaderText = "Indicator";
            PurchaseIndicator.DataSource = new List<Part.Indicator> { Part.Indicator.NONE, Part.Indicator.INVOICE, Part.Indicator.ORDER };

            lstPartsQuery.RowHeadersVisible = false;

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
            lstPartsInvoice.Columns["OrderedFor"].Visible = false;

            //formatting currency
            lstPartsInvoice.Columns["ListPrice"].DefaultCellStyle.Format = "c";
            lstPartsInvoice.Columns["Deposit"].DefaultCellStyle.Format = "c";
            lstPartsInvoice.Columns["Net"].DefaultCellStyle.Format = "c";
            lstPartsInvoice.Columns["Amount"].DefaultCellStyle.Format = "c";

            //formatting nums right justified
            lstPartsInvoice.Columns["ListPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            lstPartsInvoice.Columns["Deposit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            lstPartsInvoice.Columns["Net"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            lstPartsInvoice.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            lstPartsInvoice.RowHeadersVisible = false;
        }

        private void orderColumnSetup()
        {
            //ordering
            lstPartsOrder.Columns["PartID"].DisplayIndex = 0;
            lstPartsOrder.Columns["PartDescription"].DisplayIndex = 1;
            lstPartsOrder.Columns["BackOrder"].DisplayIndex = 2;
            lstPartsOrder.Columns["CostPrice"].DisplayIndex = 3;
            lstPartsOrder.Columns["TotalCost"].DisplayIndex = 4;
            lstPartsOrder.Columns["OrderedFor"].DisplayIndex = 5;


            //names
            lstPartsOrder.Columns["BackOrder"].HeaderText = "Request";
            lstPartsOrder.Columns["CostPrice"].HeaderText = "Cost Price ($)";
            lstPartsOrder.Columns["TotalCost"].HeaderText = "Total Cost ($)";
            lstPartsOrder.Columns["OrderedFor"].HeaderText = "Ordered For";

            //visibility
            lstPartsOrder.Columns["MinQuantity"].Visible = false;
            lstPartsOrder.Columns["Section"].Visible = false;
            lstPartsOrder.Columns["QuantityOnHand"].Visible = false;
            lstPartsOrder.Columns["QuantityOnOrder"].Visible = false;
            lstPartsOrder.Columns["Reserved"].Visible = false;
            lstPartsOrder.Columns["Dirty"].Visible = false;
            lstPartsOrder.Columns["PurchaseIndicator"].Visible = false;
            lstPartsOrder.Columns["Net"].Visible = false;
            lstPartsOrder.Columns["Deposit"].Visible = false;
            lstPartsOrder.Columns["Request"].Visible = false;
            lstPartsOrder.Columns["Receive"].Visible = false;
            lstPartsOrder.Columns["Amount"].Visible = false;
            lstPartsOrder.Columns["ListPrice"].Visible = false;
            lstPartsOrder.Columns["TotalList"].Visible = false;

            //formatting currency
            lstPartsOrder.Columns["ListPrice"].DefaultCellStyle.Format = "c";
            lstPartsOrder.Columns["CostPrice"].DefaultCellStyle.Format = "c";
            lstPartsOrder.Columns["TotalCost"].DefaultCellStyle.Format = "c";
            lstPartsOrder.Columns["TotalList"].DefaultCellStyle.Format = "c";

            //formatting nums right justified
            lstPartsOrder.Columns["CostPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            lstPartsOrder.Columns["TotalCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            lstPartsOrder.RowHeadersVisible = false;
        }

        private void spOrderColumnSetUp()
        {
            //ordering
            lstPartsSpOrder.Columns["PartID"].DisplayIndex = 0;
            lstPartsSpOrder.Columns["PartDescription"].DisplayIndex = 1;
            lstPartsSpOrder.Columns["BackOrder"].DisplayIndex = 2;
            lstPartsSpOrder.Columns["CostPrice"].DisplayIndex = 4;
            lstPartsSpOrder.Columns["ListPrice"].DisplayIndex = 5;
            lstPartsSpOrder.Columns["TotalCost"].DisplayIndex = 6;
            lstPartsSpOrder.Columns["TotalList"].DisplayIndex = 7;
            lstPartsSpOrder.Columns["OrderedFor"].DisplayIndex = 8;


            //names
            lstPartsSpOrder.Columns["BackOrder"].HeaderText = "Request";
            lstPartsSpOrder.Columns["ListPrice"].HeaderText = "List Price ($)";
            lstPartsSpOrder.Columns["CostPrice"].HeaderText = "Cost Price ($)";
            lstPartsSpOrder.Columns["TotalCost"].HeaderText = "Total Cost ($)";
            lstPartsSpOrder.Columns["TotalList"].HeaderText = "Total List ($)";
            lstPartsSpOrder.Columns["OrderedFor"].HeaderText = "Ordered For";

            //visibility
            lstPartsSpOrder.Columns["MinQuantity"].Visible = false;
            lstPartsSpOrder.Columns["Section"].Visible = false;
            lstPartsSpOrder.Columns["QuantityOnHand"].Visible = false;
            lstPartsSpOrder.Columns["QuantityOnOrder"].Visible = false;
            lstPartsSpOrder.Columns["Reserved"].Visible = false;
            lstPartsSpOrder.Columns["Dirty"].Visible = false;
            lstPartsSpOrder.Columns["PurchaseIndicator"].Visible = false;
            lstPartsSpOrder.Columns["Net"].Visible = false;
            lstPartsSpOrder.Columns["Deposit"].Visible = false;
            lstPartsSpOrder.Columns["Request"].Visible = false;
            lstPartsSpOrder.Columns["Receive"].Visible = false;
            lstPartsSpOrder.Columns["Amount"].Visible = false;

            //formatting currency
            lstPartsSpOrder.Columns["ListPrice"].DefaultCellStyle.Format = "c";
            lstPartsSpOrder.Columns["CostPrice"].DefaultCellStyle.Format = "c";
            lstPartsSpOrder.Columns["TotalCost"].DefaultCellStyle.Format = "c";
            lstPartsSpOrder.Columns["TotalList"].DefaultCellStyle.Format = "c";

            //formatting nums right justified
            lstPartsSpOrder.Columns["ListPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            lstPartsSpOrder.Columns["CostPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            lstPartsSpOrder.Columns["TotalCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            lstPartsSpOrder.Columns["TotalList"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            


            lstPartsSpOrder.RowHeadersVisible = false;
        }

        private void spOrderViewColumnSetUp()
        {

            //ordering
            lstPartReq.Columns["PartID"].DisplayIndex = 0;
            lstPartReq.Columns["PartDescription"].DisplayIndex = 1;
            lstPartReq.Columns["BackOrder"].DisplayIndex = 2;
            lstPartReq.Columns["CostPrice"].DisplayIndex = 4;
            lstPartReq.Columns["ListPrice"].DisplayIndex = 5;
            lstPartReq.Columns["TotalCost"].DisplayIndex = 6;
            lstPartReq.Columns["TotalList"].DisplayIndex = 7;
            lstPartReq.Columns["OrderedFor"].DisplayIndex = 8;


            //names
            lstPartReq.Columns["BackOrder"].HeaderText = "Request";
            lstPartReq.Columns["ListPrice"].HeaderText = "List Price ($)";
            lstPartReq.Columns["CostPrice"].HeaderText = "Cost Price ($)";
            lstPartReq.Columns["TotalCost"].HeaderText = "Total Cost ($)";
            lstPartReq.Columns["TotalList"].HeaderText = "Total List ($)";
            lstPartReq.Columns["OrderedFor"].HeaderText = "Ordered For";

            //visibility
            lstPartReq.Columns["MinQuantity"].Visible = false;
            lstPartReq.Columns["Section"].Visible = false;
            lstPartReq.Columns["QuantityOnHand"].Visible = false;
            lstPartReq.Columns["QuantityOnOrder"].Visible = false;
            lstPartReq.Columns["Reserved"].Visible = false;
            lstPartReq.Columns["Dirty"].Visible = false;
            lstPartReq.Columns["PurchaseIndicator"].Visible = false;
            lstPartReq.Columns["Net"].Visible = false;
            lstPartReq.Columns["Deposit"].Visible = false;
            lstPartReq.Columns["Request"].Visible = false;
            lstPartReq.Columns["Receive"].Visible = false;
            lstPartReq.Columns["Amount"].Visible = false;

            //formatting currency
            lstPartReq.Columns["ListPrice"].DefaultCellStyle.Format = "c";
            lstPartReq.Columns["CostPrice"].DefaultCellStyle.Format = "c";
            lstPartReq.Columns["TotalCost"].DefaultCellStyle.Format = "c";
            lstPartReq.Columns["TotalList"].DefaultCellStyle.Format = "c";

            //formatting nums right justified
            lstPartReq.Columns["ListPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            lstPartReq.Columns["CostPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            lstPartReq.Columns["TotalCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            lstPartReq.Columns["TotalList"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            lstPartReq.RowHeadersVisible = false;
        }

        private void workOrderColumnSetup()
        {

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
            double discount = Double.Parse(cboDiscountType.SelectedValue.ToString());
            double tempList = (double)p.ListPrice;

            //if any are being backordered, set the deposit price
            if (p.BackOrder > 0)
            {
                if (discount > 0)
                {
                    tempList = tempList - (tempList * (discount / 100));
                }

                totalDeposit = (tempList * (double)(numDepositPct.Value / 100)); 
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
                totalAmount = totalAmount + (p.Net * p.Receive); 
            }

            return totalAmount;
        }

        private void calculateInvoiceFields()
        {
            double salesTax = .13;

            owedAfterDeposit = 0;
            
            depositTotal = 0;
            owedDepositTax = 0;
            partsTotal = 0;
            taxTotal = 0;
            grandTotal = 0;

            //iterate each part and calculate all its fields
            foreach (Part p in invoicePartList)
            {
                resolveRequest(p);

                //calculate columns
                p.Deposit = calculateDeposit(p);
                p.Net = calculateNet(p);
                p.Amount = calculateAmount(p);

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
            owedDepositTax = owedAfterDeposit + (owedAfterDeposit * salesTax);

            txtDepositAmt.Text = string.Format("{0:c}", depositTotal);
            txtDepositRem.Text = string.Format("{0:c}", owedAfterDeposit);
            txtDepositWithTax.Text = string.Format("{0:c}", owedDepositTax);
            txtPartsTotal.Text = string.Format("{0:c}", partsTotal);
            txtSalesTax.Text = string.Format("{0:c}", taxTotal);
            txtGrandTotal.Text = string.Format("{0:c}", grandTotal);

            sourceInvoice.ResetBindings(false);
        }

        private void resolveRequest(Part p)
        {
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
                if (addPart.Request == 0)
                {
                    addPart.Request = 1;
                }
                if (addPart.QuantityOnHand > 0)
                {
                    addPart.PurchaseIndicator = Part.Indicator.INVOICE;
                }
                else
                {
                    addPart.PurchaseIndicator = Part.Indicator.ORDER;
                }
                selectedPartList.Add(addPart);
                sourceParts.ResetBindings(false);
            }

            //if the current part selection is null or an empty part, select this one
            //if (selectedPart == null || selectedPart.PartID.Equals("NO PART"))
            //{
                selectedPart = addPart;
                lstPartsQuery.ClearSelection();

                int rowIndex = lstPartsQuery.Rows.Count - 1;

                lstPartsQuery.Rows[rowIndex].Selected = true;
                lstPartsQuery.Rows[rowIndex].Cells[0].Selected = true;
                lstPartsQuery.FirstDisplayedScrollingRowIndex = rowIndex;

            //}

            //load that detail in and retally stuff
            updateCurrentRow();
            loadPartDetail(selectedPart);
            tallyItems();
            calculateLookUpFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //TODO: add confirmation dialog to this
            //clears out the whole damn list
            selectedPartList.Clear();
            sourceParts.ResetBindings(false);

            clearItemInfoAndTotals();
        }

        private void clearItemInfoAndTotals()
        {
            txtPartNum.Text = "";
            txtDescription.Text = "";
            txtSection.Text = "";
            txtQOH.Text = "";
            txtQOO.Text = "";

            txtOrderCost.Text = "";
            txtOrderList.Text = "";
            txtInvCost.Text = "";
            txtInvList.Text = "";
        }

        private void btnLoadParts_Click(object sender, EventArgs e)
        {
            string fileLoc = "";
            FastParser fast = new FastParser();

            OpenFileDialog fileDia = new OpenFileDialog();

            fileDia.Filter = "FAST Part File|*.DAT";

            DialogResult okSelected = fileDia.ShowDialog();

            if (okSelected == System.Windows.Forms.DialogResult.OK)
            {
                fileLoc = fileDia.InitialDirectory + fileDia.FileName;


                fast.loadFile(fileLoc);
                List<Part> partsFromFast = fast.createParts();

                foreach (Part p in partsFromFast)
                {
                    p.PurchaseIndicator = Part.Indicator.INVOICE;
                    selectedPartList.Add(p);
                    sourceParts.ResetBindings(false);
                }
            }

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
                resolveRequest(p);
                if (p.PurchaseIndicator == Part.Indicator.INVOICE)
                {
                    invoicePartList.Add(p);
                }
                if (p.BackOrder > 0 || p.PurchaseIndicator == Part.Indicator.ORDER)
                {
                    spOrderPartList.Add(p);
                }

            }
            calcSpOrder();

            //i didn't really expect this to work, so it's mostly magic happening
            //if i get some time, i'll look into how c# compares objects.
            //are the parts in the lookup list the SAME parts as in the invoice list? i really hope not.
            //but this removes them regardless. maybe it compares properties? dunno.

            //update, c# stores a reference to the same object in each list<>. so they are the same
            foreach (Part p in invoicePartList)
                selectedPartList.Remove(p);

            foreach (Part p in spOrderPartList)
                selectedPartList.Remove(p);

            //reset BOTH dgvs, and calculate the new fields.
            sourceParts.ResetBindings(false);
            sourceInvoice.ResetBindings(false);
            sourceSpOrder.ResetBindings(false);

            clearItemInfoAndTotals();

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
            updateCurrentRow();
            calculateLookUpFields();
            tallyItems();
        }

        private void updateCurrentRow()
        {
            int editedRowIndex = lstPartsQuery.CurrentRow.Index;

            //pull the part to edit out
            Part editedPart = selectedPartList[editedRowIndex];

            //if they're askin' for more than we've got, order some.
            if (editedPart.Request > editedPart.QuantityOnHand)
            {
                int difference = (int)(editedPart.Request - editedPart.QuantityOnHand);
                editedPart.QuantityOnOrder = editedPart.QuantityOnOrder + difference;
            }

            editedPart.Dirty = true;

            //stick the edited part back in
            selectedPartList[editedRowIndex] = editedPart;
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

        private void btnPartsScreen_Click(object sender, EventArgs e)
        {

        }

        private void btnSpLoadParts_Click(object sender, EventArgs e)
        {
            string fileLoc = "";
            FastParser fast = new FastParser();

            OpenFileDialog fileDia = new OpenFileDialog();

            fileDia.Filter = "FAST Part File|*.DAT";

            DialogResult okSelected = fileDia.ShowDialog();

            if (okSelected == System.Windows.Forms.DialogResult.OK)
            {
                fileLoc = fileDia.InitialDirectory + fileDia.FileName;


                fast.loadFile(fileLoc);
                List<Part> partsFromFast = fast.createParts();

                foreach (Part p in partsFromFast)
                {
                    if (p.BackOrder == 0)
                    {
                        p.BackOrder = 1;
                    }
                    spOrderPartList.Add(p);
                    sourceSpOrder.ResetBindings(false);
                }

                calcSpOrder();
            }
            if (txtOrderedFor.Text != "")
            {
                foreach (Part p in spOrderPartList)
                {
                    p.OrderedFor = txtOrderedFor.Text;
                }
            }
        }

        private void btnSpAddPart_Click(object sender, EventArgs e)
        {
            Part addPart;
            String dialogText = "Please enter Part Number to add.";
            string promptValue;

            //loop until a valid part is returned, or cancel is clicked
            do
            {
                //show the prompt
                promptValue = PartSearchModal.ShowDialog(dialogText, "Part Number");

                //create the new part (will always work, but won't always be able to load)
                addPart = new Part(promptValue);

                //resets the text in case we do end up looping
                dialogText = "Part number not found. Please enter Part Number.";

            } while (!addPart.load(dbConn) && promptValue != ""); //tries to load the part from the db. they're smart enough, they can load themselves

            //if not cancelled, add the part to the list and refresh
            if (promptValue != "")
            {
                if (addPart.BackOrder == 0)
                {
                    addPart.BackOrder = 1;
                }
                if (txtOrderedFor.Text != "")
                {
                    addPart.OrderedFor = txtOrderedFor.Text;
                }
                spOrderPartList.Add(addPart);
                sourceSpOrder.ResetBindings(false);
            }

            lstPartsSpOrder.ClearSelection();

            int rowIndex = lstPartsSpOrder.Rows.Count - 1;

            lstPartsSpOrder.Rows[rowIndex].Selected = true;
            lstPartsSpOrder.Rows[rowIndex].Cells[0].Selected = true;
            lstPartsSpOrder.FirstDisplayedScrollingRowIndex = rowIndex;

            calcSpOrder();
        }

        private void calcSpOrder()
        {
            decimal totalCost = 0;
            decimal totalList = 0;
            foreach (Part p in spOrderPartList)
            {
                p.TotalCost = (decimal)(p.BackOrder * p.CostPrice);
                p.TotalList = (decimal)(p.BackOrder * p.ListPrice);

                totalCost = totalCost + p.TotalCost;
                totalList = totalList + p.TotalList;
            }

            txtSpOrderCost.Text = string.Format("{0:c}", totalCost);
            txtSpOrderList.Text = string.Format("{0:c}", totalList);
        }

        private void btnSpRemovePart_Click(object sender, EventArgs e)
        {
            if (lstPartsSpOrder.Rows.Count > 0)
            {
                lstPartsSpOrder.Rows.Remove(lstPartsSpOrder.CurrentRow);
                sourceSpOrder.ResetBindings(false);
            }
        }

        private void btnSpClear_Click(object sender, EventArgs e)
        {
            spOrderPartList.Clear();
            txtAcctSearch.Text = "";
            txtOrderedFor.Text = "";
            txtSpOrderCost.Text = "";
            txtSpOrderList.Text = "";
            sourceSpOrder.ResetBindings(false);
        }

        private void lstPartsSpOrder_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            calcSpOrder();
        }

        private void btnSpSaveOrder_Click(object sender, EventArgs e)
        {
            foreach (Part p in spOrderPartList)
            {
                spOrderPartViewList.Add(p);
            }
            spOrderPartList.Clear();

            txtAcctSearch.Text = "";
            txtOrderedFor.Text = "";
            txtSpOrderCost.Text = "";
            txtSpOrderList.Text = "";

            sourceSpOrder.ResetBindings(false);
        }

        private void lstPartsSpOrderView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            calcSpOrderView();
        }

        private void calcSpOrderView()
        {
            int count = lstPartsSpOrderView.Rows.Count;
            double totalCost = 0;
            double totalList = 0;
            foreach (Part p in spOrderPartViewList)
            {
                totalCost = totalCost + (double)p.TotalCost;
                totalList = totalList + (double)p.TotalList;
            }

            txtSpItemCountView.Text = count.ToString(); ;
            txtSpOrderCostView.Text = string.Format("{0:c}", totalCost);
            txtSpOrderListView.Text = string.Format("{0:c}", totalList);

            
        }

        private void lstPartsSpOrderView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calcSpOrderView();
        }

        private void tabSpOrderView_Enter(object sender, EventArgs e)
        {
            sourceSpOrderView.ResetBindings(false);
        }

        private void btnSpOrderClear_Click(object sender, EventArgs e)
        {
            spOrderPartViewList.Clear();
            sourceSpOrderView.ResetBindings(false);
        }

        private void btnAcctSearch_Click(object sender, EventArgs e)
        {
            String searchedName = txtOrderedFor.Text.ToUpper();
            String actualName = "";

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
                    DataTable customer = dbConn.readQuery("SELECT * from Customer where CustomerID = " + selectedCxID);
                    txtAcctSearch.Text = Convert.ToString(customer.Rows[0].Field<double>("CUSTOMERID"));

                    String first = Convert.ToString(customer.Rows[0].Field<string>("FIRSTNAME"));
                    String last = Convert.ToString(customer.Rows[0].Field<string>("LASTNAME"));

                    actualName = first + " " + last;
                    txtOrderedFor.Text = actualName;

                    foreach (Part p in spOrderPartList)
                    {
                        p.OrderedFor = actualName;
                    }
                }
            }

            sourceSpOrder.ResetBindings(false);

        }

        private void btnLoadPartsFileOrder_Click(object sender, EventArgs e)
        {
            string fileLoc = "";
            FastParser fast = new FastParser();

            OpenFileDialog fileDia = new OpenFileDialog();

            fileDia.Filter = "FAST Part File|*.DAT";

            DialogResult okSelected = fileDia.ShowDialog();

            if (okSelected == System.Windows.Forms.DialogResult.OK)
            {
                fileLoc = fileDia.InitialDirectory + fileDia.FileName;


                fast.loadFile(fileLoc);
                List<Part> partsFromFast = fast.createParts();

                foreach (Part p in partsFromFast)
                {
                    if (p.BackOrder == 0)
                    {
                        p.BackOrder = 1;
                    }
                    orderPartList.Add(p);
                    
                }
            }

            sourceOrder.ResetBindings(false);
        }

        private void btnAddPartOrder_Click(object sender, EventArgs e)
        {
            Part addPart;
            String dialogText = "Please enter Part Number to add.";
            string promptValue;

            //loop until a valid part is returned, or cancel is clicked
            do
            {
                //show the prompt
                promptValue = PartSearchModal.ShowDialog(dialogText, "Part Number");

                //create the new part (will always work, but won't always be able to load)
                addPart = new Part(promptValue);

                //resets the text in case we do end up looping
                dialogText = "Part number not found. Please enter Part Number.";

            } while (!addPart.load(dbConn) && promptValue != ""); //tries to load the part from the db. they're smart enough, they can load themselves

            //if not cancelled, add the part to the list and refresh
            if (promptValue != "")
            {
                if (addPart.BackOrder == 0)
                {
                    addPart.BackOrder = 1;
                }
                orderPartList.Add(addPart);
                sourceOrder.ResetBindings(false);
            }

            lstPartsOrder.ClearSelection();

            int rowIndex = lstPartsOrder.Rows.Count - 1;

            lstPartsOrder.Rows[rowIndex].Selected = true;
            lstPartsOrder.Rows[rowIndex].Cells[0].Selected = true;
            lstPartsOrder.FirstDisplayedScrollingRowIndex = rowIndex;
        }

        private void btnAddSpecialOrder_Click(object sender, EventArgs e)
        {
            foreach (Part p in spOrderPartViewList)
            {
                orderPartList.Add(p);
            }

            foreach (Part p in orderPartList)
            {
                spOrderPartViewList.Remove(p);
            }

            sourceOrder.ResetBindings(false);
            sourceSpOrderView.ResetBindings(false);
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            orderPartList.Clear();
            sourceOrder.ResetBindings(false);
        }

        private void btnAddGeneralOrder_Click(object sender, EventArgs e)
        {
            DataTable generalOrder = dbConn.readQuery("select PARTID from PARTS where MINQUANTITY > (QUANTITYONHAND + QUANTITYONORDER)");

            List<Part> tempOrderPartsList = new List<Part>();

            foreach (DataRow row in generalOrder.Rows)
            {
                Part tempPart = new Part(Convert.ToString(row.Field<string>("PARTID")));
                if (tempPart.load(dbConn))
                {
                    if (tempPart.BackOrder == 0)
                    {
                        tempPart.BackOrder = (int)(tempPart.MinQuantity - (tempPart.QuantityOnHand + tempPart.QuantityOnOrder));
                        tempPart.QuantityOnOrder = tempPart.QuantityOnOrder + tempPart.Request;
                    }
                    tempPart.TotalCost = (decimal)(tempPart.BackOrder * tempPart.CostPrice);
                    orderPartList.Add(tempPart);
                }
            }

            sourceOrder.ResetBindings(false);
        }

        private void lstPartsOrder_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            updateOrder();
        }

        private void lstPartsOrder_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            updateOrder();
        }

        private void updateOrder()
        {
            int count = lstPartsOrder.Rows.Count;
            double totalCost = 0;

            foreach (Part p in orderPartList)
            {
                totalCost = totalCost + (double)p.TotalCost;
            }

            txtTotalItems.Text = count.ToString();
            txtTotalOrderCost.Text = string.Format("{0:c}" ,totalCost);
        }

        private void btnSendOrder_Click(object sender, EventArgs e)
        {

        }

        private void lstInServWO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            if (selectedRow != -1)
            {
                activeWOID = lstInServWO.Rows[selectedRow].Cells["WORKORDERID"].Value.ToString();
            }
        }

        private void btnWOLoadParts_Click(object sender, EventArgs e)
        {
            string fileLoc = "";
            FastParser fast = new FastParser();

            OpenFileDialog fileDia = new OpenFileDialog();

            fileDia.Filter = "FAST Part File|*.DAT";

            DialogResult okSelected = fileDia.ShowDialog();

            if (okSelected == System.Windows.Forms.DialogResult.OK)
            {
                fileLoc = fileDia.InitialDirectory + fileDia.FileName;


                fast.loadFile(fileLoc);
                List<Part> partsFromFast = fast.createParts();

                foreach (Part p in partsFromFast)
                {

                    workOrderPartList.Add(p);

                }
            }

            sourceWorkOrder.ResetBindings(false);
        }

    }
}