using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace MLN_ISDP_project
{
    class CxSearchModal
    {
        public static string ShowDialog(string text, string caption, DataTable dt)
        {
            Form cxSearch = new Form();
            cxSearch.Width = 700;
            cxSearch.Height = 400;
            cxSearch.Text = caption;

            string selectedCx = "";
            int selectedrowindex = 0;
            DataGridViewRow selectedRow;

            Label textLabel = new Label() { Left = 25, Top = 20, Text = text, Width = 500 };
            DataGridView results = new DataGridView() { Left = 25, Top = 50, Width = 600, Height = 200 };
            Button confirm = new Button() { Text = "OK", Left = 125, Width = 100, Top = 270 };
            Button cancel = new Button() { Text = "Cancel", Left = 325, Width = 100, Top = 270 };

            results.AllowUserToAddRows = false;
            results.AllowUserToDeleteRows = false;
            results.AutoResizeColumns();
            results.ReadOnly = true;

            results.DataSource = dt;

            confirm.TabIndex = 1;
            cancel.TabIndex = 2;



            confirm.Click += (sender, e) =>
            {
                selectedrowindex = results.SelectedCells[0].RowIndex;
                selectedRow = results.Rows[selectedrowindex];
                selectedCx = Convert.ToString(selectedRow.Cells["CUSTOMERID"].Value);

                cxSearch.Close();
            };

            cancel.Click += (sender, e) =>
            {
                selectedCx = "";
                cxSearch.Close();
            };

            cxSearch.Controls.Add(confirm);
            cxSearch.Controls.Add(cancel);
            cxSearch.Controls.Add(textLabel);
            cxSearch.Controls.Add(results);

            cxSearch.ShowDialog();

            return selectedCx;
        }
    }
}
