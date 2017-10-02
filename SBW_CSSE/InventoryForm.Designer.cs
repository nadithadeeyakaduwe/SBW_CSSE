namespace SBW.UI
{
    partial class InventoryForm
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
            this.btn_inventoryUC = new System.Windows.Forms.Button();
            this.btn_supplierUC = new System.Windows.Forms.Button();
            this.btn_stockUC = new System.Windows.Forms.Button();
            this.panel_InventoryForm = new System.Windows.Forms.Panel();
            this.panel_InventoryForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_inventoryUC
            // 
            this.btn_inventoryUC.Location = new System.Drawing.Point(114, 92);
            this.btn_inventoryUC.Name = "btn_inventoryUC";
            this.btn_inventoryUC.Size = new System.Drawing.Size(184, 100);
            this.btn_inventoryUC.TabIndex = 0;
            this.btn_inventoryUC.Text = "Inventory";
            this.btn_inventoryUC.UseVisualStyleBackColor = true;
            this.btn_inventoryUC.Click += new System.EventHandler(this.btn_inventoryUC_Click);
            // 
            // btn_supplierUC
            // 
            this.btn_supplierUC.Location = new System.Drawing.Point(401, 92);
            this.btn_supplierUC.Name = "btn_supplierUC";
            this.btn_supplierUC.Size = new System.Drawing.Size(184, 100);
            this.btn_supplierUC.TabIndex = 1;
            this.btn_supplierUC.Text = "Supplier";
            this.btn_supplierUC.UseVisualStyleBackColor = true;
            // 
            // btn_stockUC
            // 
            this.btn_stockUC.Location = new System.Drawing.Point(689, 92);
            this.btn_stockUC.Name = "btn_stockUC";
            this.btn_stockUC.Size = new System.Drawing.Size(184, 100);
            this.btn_stockUC.TabIndex = 2;
            this.btn_stockUC.Text = "Stock";
            this.btn_stockUC.UseVisualStyleBackColor = true;
            // 
            // panel_InventoryForm
            // 
            this.panel_InventoryForm.Controls.Add(this.btn_inventoryUC);
            this.panel_InventoryForm.Controls.Add(this.btn_stockUC);
            this.panel_InventoryForm.Controls.Add(this.btn_supplierUC);
            this.panel_InventoryForm.Location = new System.Drawing.Point(1, 12);
            this.panel_InventoryForm.Name = "panel_InventoryForm";
            this.panel_InventoryForm.Size = new System.Drawing.Size(1005, 437);
            this.panel_InventoryForm.TabIndex = 3;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 451);
            this.Controls.Add(this.panel_InventoryForm);
            this.MaximumSize = new System.Drawing.Size(1020, 489);
            this.MinimumSize = new System.Drawing.Size(1020, 489);
            this.Name = "InventoryForm";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.panel_InventoryForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_inventoryUC;
        private System.Windows.Forms.Button btn_supplierUC;
        private System.Windows.Forms.Button btn_stockUC;
        private System.Windows.Forms.Panel panel_InventoryForm;
    }
}