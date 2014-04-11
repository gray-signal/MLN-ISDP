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
    public partial class frmLoginLauncher : Form
    {
        public frmLoginLauncher()
        {
            InitializeComponent();
        }

        private void btnPartsSale_Click(object sender, EventArgs e)
        {
            Form frmSale = new frmPartsInventory();

            frmSale.ShowDialog();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            Form frmWork = new frmServiceWorkOrder();

            frmWork.ShowDialog();
        }
    }
}
