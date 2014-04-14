namespace MLN_ISDP_project
{
    partial class frmReportLauncher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWorkOrderInvoice = new System.Windows.Forms.Button();
            this.btnSalesInvoice = new System.Windows.Forms.Button();
            this.btnTechReport = new System.Windows.Forms.Button();
            this.btnOrdersReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWorkOrderInvoice
            // 
            this.btnWorkOrderInvoice.Location = new System.Drawing.Point(105, 12);
            this.btnWorkOrderInvoice.Name = "btnWorkOrderInvoice";
            this.btnWorkOrderInvoice.Size = new System.Drawing.Size(87, 48);
            this.btnWorkOrderInvoice.TabIndex = 0;
            this.btnWorkOrderInvoice.Text = "Work Order Invoice";
            this.btnWorkOrderInvoice.UseVisualStyleBackColor = true;
            this.btnWorkOrderInvoice.Click += new System.EventHandler(this.btnWorkOrderInvoice_Click);
            // 
            // btnSalesInvoice
            // 
            this.btnSalesInvoice.Location = new System.Drawing.Point(12, 12);
            this.btnSalesInvoice.Name = "btnSalesInvoice";
            this.btnSalesInvoice.Size = new System.Drawing.Size(87, 48);
            this.btnSalesInvoice.TabIndex = 1;
            this.btnSalesInvoice.Text = "Sales Invoice";
            this.btnSalesInvoice.UseVisualStyleBackColor = true;
            this.btnSalesInvoice.Click += new System.EventHandler(this.btnSalesInvoice_Click);
            // 
            // btnTechReport
            // 
            this.btnTechReport.Location = new System.Drawing.Point(12, 66);
            this.btnTechReport.Name = "btnTechReport";
            this.btnTechReport.Size = new System.Drawing.Size(87, 48);
            this.btnTechReport.TabIndex = 2;
            this.btnTechReport.Text = "Technician Work Sheet";
            this.btnTechReport.UseVisualStyleBackColor = true;
            this.btnTechReport.Click += new System.EventHandler(this.btnTechReport_Click);
            // 
            // btnOrdersReport
            // 
            this.btnOrdersReport.Location = new System.Drawing.Point(105, 66);
            this.btnOrdersReport.Name = "btnOrdersReport";
            this.btnOrdersReport.Size = new System.Drawing.Size(87, 48);
            this.btnOrdersReport.TabIndex = 3;
            this.btnOrdersReport.Text = "Day\'s Orders";
            this.btnOrdersReport.UseVisualStyleBackColor = true;
            this.btnOrdersReport.Click += new System.EventHandler(this.btnOrdersReport_Click);
            // 
            // frmReportLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 127);
            this.Controls.Add(this.btnOrdersReport);
            this.Controls.Add(this.btnTechReport);
            this.Controls.Add(this.btnSalesInvoice);
            this.Controls.Add(this.btnWorkOrderInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmReportLauncher";
            this.Text = "Report Launcher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWorkOrderInvoice;
        private System.Windows.Forms.Button btnSalesInvoice;
        private System.Windows.Forms.Button btnTechReport;
        private System.Windows.Forms.Button btnOrdersReport;
    }
}