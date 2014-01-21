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
        private List<Part> selectedParts;

        public Form1()
        {
            InitializeComponent();
            selectedParts = new List<Part>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Test.test();

            lstPartsQuery.DataSource = selectedParts;
        }

        private void resetSource()
        {
            lstPartsQuery.DataSource = null;
            lstPartsQuery.DataSource = selectedParts;
        }

        private void btnAddParts_Click(object sender, EventArgs e)
        {
            string promptValue = PartSearchModal.ShowDialog("Please enter Part Number to add.", "Part Number");

            Part addPart = new Database.PersistenceFactory().Create<Part>(promptValue);

            selectedParts.Add(addPart);

            this.resetSource();
        }
    }
}
