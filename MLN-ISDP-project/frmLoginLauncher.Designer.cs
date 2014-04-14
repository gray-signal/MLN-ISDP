namespace MLN_ISDP_project
{
    partial class frmLoginLauncher
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
            this.btnPartsSale = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPartsSale
            // 
            this.btnPartsSale.Location = new System.Drawing.Point(12, 49);
            this.btnPartsSale.Name = "btnPartsSale";
            this.btnPartsSale.Size = new System.Drawing.Size(165, 75);
            this.btnPartsSale.TabIndex = 0;
            this.btnPartsSale.Text = "Parts";
            this.btnPartsSale.UseVisualStyleBackColor = true;
            this.btnPartsSale.Click += new System.EventHandler(this.btnPartsSale_Click);
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(193, 49);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(165, 75);
            this.btnService.TabIndex = 1;
            this.btnService.Text = "Service";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "This is a login placeholder";
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(12, 130);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(346, 30);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // frmLoginLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 172);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.btnPartsSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLoginLauncher";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPartsSale;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReports;
    }
}