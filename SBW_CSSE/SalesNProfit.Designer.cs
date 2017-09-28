namespace SBW.UI
{
    partial class SalesNProfit
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
            this.btn_salesNprofit_invoice = new System.Windows.Forms.Button();
            this.btn_salesNprofit_profit = new System.Windows.Forms.Button();
            this.panel_saleNprofit = new System.Windows.Forms.Panel();
            this.panel_saleNprofit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_salesNprofit_invoice
            // 
            this.btn_salesNprofit_invoice.Location = new System.Drawing.Point(109, 116);
            this.btn_salesNprofit_invoice.Name = "btn_salesNprofit_invoice";
            this.btn_salesNprofit_invoice.Size = new System.Drawing.Size(232, 88);
            this.btn_salesNprofit_invoice.TabIndex = 0;
            this.btn_salesNprofit_invoice.Text = "INVOICE";
            this.btn_salesNprofit_invoice.UseVisualStyleBackColor = true;
            this.btn_salesNprofit_invoice.Click += new System.EventHandler(this.btn_salesNprofit_invoice_Click);
            // 
            // btn_salesNprofit_profit
            // 
            this.btn_salesNprofit_profit.Location = new System.Drawing.Point(578, 116);
            this.btn_salesNprofit_profit.Name = "btn_salesNprofit_profit";
            this.btn_salesNprofit_profit.Size = new System.Drawing.Size(232, 88);
            this.btn_salesNprofit_profit.TabIndex = 1;
            this.btn_salesNprofit_profit.Text = "PROFIT";
            this.btn_salesNprofit_profit.UseVisualStyleBackColor = true;
            // 
            // panel_saleNprofit
            // 
            this.panel_saleNprofit.Controls.Add(this.btn_salesNprofit_invoice);
            this.panel_saleNprofit.Controls.Add(this.btn_salesNprofit_profit);
            this.panel_saleNprofit.Location = new System.Drawing.Point(12, 12);
            this.panel_saleNprofit.MaximumSize = new System.Drawing.Size(1030, 499);
            this.panel_saleNprofit.MinimumSize = new System.Drawing.Size(1030, 499);
            this.panel_saleNprofit.Name = "panel_saleNprofit";
            this.panel_saleNprofit.Size = new System.Drawing.Size(1030, 499);
            this.panel_saleNprofit.TabIndex = 2;
            this.panel_saleNprofit.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SalesNProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 337);
            this.Controls.Add(this.panel_saleNprofit);
            this.Name = "SalesNProfit";
            this.Text = "Sales and Profit";
            this.Load += new System.EventHandler(this.SalesNProfit_Load);
            this.panel_saleNprofit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_salesNprofit_invoice;
        private System.Windows.Forms.Button btn_salesNprofit_profit;
        private System.Windows.Forms.Panel panel_saleNprofit;
    }
}