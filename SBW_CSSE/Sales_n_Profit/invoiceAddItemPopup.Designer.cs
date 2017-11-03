namespace SBW.UI.InventoryUserControls
{
    partial class inviocAddItemPopup
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
            this.dgv_invoiceAddItemPopup = new System.Windows.Forms.DataGridView();
            this.txtbx_invenrtyAddItemPopup_ItemType = new System.Windows.Forms.TextBox();
            this.lbl_inventry_AddIPopup_ItemType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoiceAddItemPopup)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_invoiceAddItemPopup
            // 
            this.dgv_invoiceAddItemPopup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_invoiceAddItemPopup.Location = new System.Drawing.Point(5, 59);
            this.dgv_invoiceAddItemPopup.Name = "dgv_invoiceAddItemPopup";
            this.dgv_invoiceAddItemPopup.Size = new System.Drawing.Size(766, 381);
            this.dgv_invoiceAddItemPopup.TabIndex = 0;
            this.dgv_invoiceAddItemPopup.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_invoiceAddItemPopup_RowHeaderMouseClick);
            // 
            // txtbx_invenrtyAddItemPopup_ItemType
            // 
            this.txtbx_invenrtyAddItemPopup_ItemType.Location = new System.Drawing.Point(73, 32);
            this.txtbx_invenrtyAddItemPopup_ItemType.Name = "txtbx_invenrtyAddItemPopup_ItemType";
            this.txtbx_invenrtyAddItemPopup_ItemType.Size = new System.Drawing.Size(365, 20);
            this.txtbx_invenrtyAddItemPopup_ItemType.TabIndex = 1;
            this.txtbx_invenrtyAddItemPopup_ItemType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_invenrtyAddItemPopup_ItemType_KeyPress);
            // 
            // lbl_inventry_AddIPopup_ItemType
            // 
            this.lbl_inventry_AddIPopup_ItemType.AutoSize = true;
            this.lbl_inventry_AddIPopup_ItemType.Location = new System.Drawing.Point(13, 35);
            this.lbl_inventry_AddIPopup_ItemType.Name = "lbl_inventry_AddIPopup_ItemType";
            this.lbl_inventry_AddIPopup_ItemType.Size = new System.Drawing.Size(54, 13);
            this.lbl_inventry_AddIPopup_ItemType.TabIndex = 2;
            this.lbl_inventry_AddIPopup_ItemType.Text = "Item Type";
            // 
            // inviocAddItemPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 444);
            this.Controls.Add(this.lbl_inventry_AddIPopup_ItemType);
            this.Controls.Add(this.txtbx_invenrtyAddItemPopup_ItemType);
            this.Controls.Add(this.dgv_invoiceAddItemPopup);
            this.Name = "inviocAddItemPopup";
            this.Text = "inventryAddItemPopup";
            this.Load += new System.EventHandler(this.inventryAddItemPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoiceAddItemPopup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_invoiceAddItemPopup;
        private System.Windows.Forms.TextBox txtbx_invenrtyAddItemPopup_ItemType;
        private System.Windows.Forms.Label lbl_inventry_AddIPopup_ItemType;
    }
}