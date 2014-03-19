using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MLN_ISDP_WorkOrders
{
    public static class CxSearchModal
    {
        public static string ShowDialog(string text, string caption, DataTable dt)
        {
            Form cxSearch = new Form();
            cxSearch.Width = 500;
            cxSearch.Height = 200;
            cxSearch.Text = caption;

            Label textLabel = new Label() { Left = 50, Top = 20, Text = text, Width = 300 };
            DataGridView dgvResults = new DataGridView() { Left = 50, Top = 50, Width = 400, Height = 50 };
            Button confirm = new Button() { Text = "OK", Left = 150, Width = 100, Top = 70 };
            Button cancel = new Button() { Text = "Cancel", Left = 350, Width = 100, Top = 70 };

            dgvResults.DataSource = dt;

            confirm.TabIndex = 1;
            cancel.TabIndex = 2;

            confirm.Click += (sender, e) =>
            {
                if (inputBox.Text == "")
                    inputBox.Text = " "; // stupid hack to make cancel close out, but ok on empty field not close.
                cxSearch.Close();
            };

            cancel.Click += (sender, e) =>
            {
                inputBox.Text = null;
                cxSearch.Close();
            };

            cxSearch.Controls.Add(confirm);
            cxSearch.Controls.Add(cancel);
            cxSearch.Controls.Add(textLabel);
            cxSearch.Controls.Add(inputBox);

            cxSearch.ShowDialog();

            return (string)inputBox.Text;
        }
    }
}
