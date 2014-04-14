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
    public partial class frmReportLauncher : Form
    {
        public frmReportLauncher()
        {
            InitializeComponent();
        }

        private void btnWorkOrderInvoice_Click(object sender, EventArgs e)
        {
            Form frmWOInv = new frmWorkOrderInvoice();

            frmWOInv.ShowDialog();
        }

        private void btnSalesInvoice_Click(object sender, EventArgs e)
        {
            Form frmSale = new frmSaleInvoice();

            frmSale.ShowDialog();
        }

        private void btnTechReport_Click(object sender, EventArgs e)
        {
            Form frmTechSheet = new frmWorkOrderTechnicianReport();

            frmTechSheet.ShowDialog();
        }

        private void btnOrdersReport_Click(object sender, EventArgs e)
        {
            Form frmDay = new frmDayOrders();

            frmDay.ShowDialog();
        }
    }
}
