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
        private BindingSource sourceParts;

        public Form1()
        {
            InitializeComponent();
            selectedParts = new List<Part>();
            sourceParts = new BindingSource();
            sourceParts.DataSource = selectedParts;

            //lstPartsQuery.AutoGenerateColumns = false;


            lstPartsQuery.DataSource = sourceParts;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Test.test();

            sourceParts.ResetBindings(true);
        }

        //default db conn
        static System.Data.OleDb.OleDbConnectionStringBuilder csBuilder = new System.Data.OleDb.OleDbConnectionStringBuilder(
                "Provider=MSDAORA;Data Source=localhost;User ID=2023164;Password=#42Paradox;");
        static OracleDB dbConn = new OracleDB(csBuilder.ToString());

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
                selectedParts.Add(addPart);
                sourceParts.ResetBindings(true);
            }
        }
    }
}
