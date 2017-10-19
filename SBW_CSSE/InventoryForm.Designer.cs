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
            this.btn_inventoryUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventoryUC.Location = new System.Drawing.Point(114, 92);
            this.btn_inventoryUC.Name = "btn_inventoryUC";
            this.btn_inventoryUC.Size = new System.Drawing.Size(184, 100);
            this.btn_inventoryUC.TabIndex = 0;
            this.btn_inventoryUC.Text = "INVENTORY";
            this.btn_inventoryUC.UseVisualStyleBackColor = true;
            this.btn_inventoryUC.Click += new System.EventHandler(this.btn_inventoryUC_Click);
            // 
            // btn_supplierUC
            // 
            this.btn_supplierUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supplierUC.Location = new System.Drawing.Point(401, 92);
            this.btn_supplierUC.Name = "btn_supplierUC";
            this.btn_supplierUC.Size = new System.Drawing.Size(184, 100);
            this.btn_supplierUC.TabIndex = 1;
            this.btn_supplierUC.Text = "SUPPLIER";
            this.btn_supplierUC.UseVisualStyleBackColor = true;
            this.btn_supplierUC.Click += new System.EventHandler(this.btn_supplierUC_Click);
            // 
            // btn_stockUC
            // 
            this.btn_stockUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stockUC.Location = new System.Drawing.Point(689, 92);
            this.btn_stockUC.Name = "btn_stockUC";
            this.btn_stockUC.Size = new System.Drawing.Size(184, 100);
            this.btn_stockUC.TabIndex = 2;
            this.btn_stockUC.Text = "STOCK";
            this.btn_stockUC.UseVisualStyleBackColor = true;
            this.btn_stockUC.Click += new System.EventHandler(this.btn_stockUC_Click);
            // 
            // panel_InventoryForm
            // 
            this.panel_InventoryForm.Controls.Add(this.btn_inventoryUC);
            this.panel_InventoryForm.Controls.Add(this.btn_stockUC);
            this.panel_InventoryForm.Controls.Add(this.btn_supplierUC);
            this.panel_InventoryForm.Location = new System.Drawing.Point(1, 12);
            this.panel_InventoryForm.MaximumSize = new System.Drawing.Size(1020, 489);
            this.panel_InventoryForm.MinimumSize = new System.Drawing.Size(1020, 489);
            this.panel_InventoryForm.Name = "panel_InventoryForm";
            this.panel_InventoryForm.Size = new System.Drawing.Size(1020, 489);
            this.panel_InventoryForm.TabIndex = 3;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 514);
            this.Controls.Add(this.panel_InventoryForm);
            this.MaximumSize = new System.Drawing.Size(1060, 552);
            this.MinimumSize = new System.Drawing.Size(1060, 552);
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