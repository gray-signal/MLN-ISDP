using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MLN_ISDP_project
{
    public static class PartSearchModal
    {
        public static string ShowDialog(string text, string caption)
        {
            Form partSearch = new Form();
            partSearch.Width = 500;
            partSearch.Height = 200;
            partSearch.Text = caption;

            Label textLabel = new Label() { Left = 50, Top = 20, Text = text, Width = 200 };
            TextBox inputBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirm = new Button() { Text = "OK", Left = 150, Width = 100, Top = 70 };
            Button cancel = new Button() { Text = "Cancel", Left = 350, Width = 100, Top = 70 };

            confirm.Click += (sender, e) => { partSearch.Close(); };

            cancel.Click += (sender, e) => { inputBox.Text = null;
                                             partSearch.Close(); };

            partSearch.Controls.Add(confirm);
            partSearch.Controls.Add(cancel);
            partSearch.Controls.Add(textLabel);
            partSearch.Controls.Add(inputBox);
            partSearch.ShowDialog();

            return (string)inputBox.Text;
        }
    }
}
