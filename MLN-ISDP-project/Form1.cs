﻿using System;
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

            //lstPartsQuery.AutoGenerateColumns = false;


            lstPartsQuery.DataSource = sourceParts;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Test.test();

            sourceParts.ResetBindings(true);

            columnSetUp();
        }

        private void columnSetUp()
        {
            //order
            lstPartsQuery.Columns["PartID"].DisplayIndex = 0;
            lstPartsQuery.Columns["PartDescription"].DisplayIndex = 1;

            //names
            lstPartsQuery.Columns["PartID"].HeaderText = "Part ID";
            lstPartsQuery.Columns["PartDescription"].HeaderText = "Part Description";
            lstPartsQuery.Columns["ListPrice"].HeaderText = "List Price";
            lstPartsQuery.Columns["CostPrice"].HeaderText = "Cost Price";
            lstPartsQuery.Columns["QuantityOnHand"].HeaderText = "Quantity On Hand";
            lstPartsQuery.Columns["QuantityOnOrder"].HeaderText = "Quantity On Order";
            lstPartsQuery.Columns["PurchaseIndicator"].HeaderText = "Indicator";


            //visibility
            lstPartsQuery.Columns["MinQuantity"].Visible = false;
        }

        //default db conn
        static System.Data.OleDb.OleDbConnectionStringBuilder csBuilder = new System.Data.OleDb.OleDbConnectionStringBuilder(
                "Provider=MSDAORA;Data Source=localhost;User ID=2023164;Password=#42Paradox;");
        static OracleDB dbConn = new OracleDB(csBuilder.ToString());



        private void tallyItems()
        {
            decimal orderCostTotal = 0;
            decimal orderListTotal = 0;

            decimal invoiceCostTotal = 0;
            decimal invoiceListTotal = 0;

            foreach (Part p in selectedPartList)
            {
                if (p.PurchaseIndicator == Part.Indicator.ORDER)
                {
                    orderCostTotal = orderCostTotal + (decimal)p.CostPrice;
                    orderListTotal = orderListTotal + (decimal)p.ListPrice;
                }

                if (p.PurchaseIndicator == Part.Indicator.INVOICE)
                {
                    invoiceCostTotal = invoiceCostTotal + (decimal)p.CostPrice;
                    invoiceListTotal = invoiceListTotal + (decimal)p.ListPrice;
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
