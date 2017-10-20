namespace SBW.UI.InventoryUserControls
{
    partial class inventryAddItemPopup
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbx_invenrtyAddItemPopup_ItemType = new System.Windows.Forms.TextBox();
            this.lbl_inventry_AddIPopup_ItemType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 381);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtbx_invenrtyAddItemPopup_ItemType
            // 
            this.txtbx_invenrtyAddItemPopup_ItemType.Location = new System.Drawing.Point(73, 32);
            this.txtbx_invenrtyAddItemPopup_ItemType.Name = "txtbx_invenrtyAddItemPopup_ItemType";
            this.txtbx_invenrtyAddItemPopup_ItemType.Size = new System.Drawing.Size(365, 20);
            this.txtbx_invenrtyAddItemPopup_ItemType.TabIndex = 1;
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
            // inventryAddItemPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 444);
            this.Controls.Add(this.lbl_inventry_AddIPopup_ItemType);
            this.Controls.Add(this.txtbx_invenrtyAddItemPopup_ItemType);
            this.Controls.Add(this.dataGridView1);
            this.Name = "inventryAddItemPopup";
            this.Text = "inventryAddItemPopup";
            this.Load += new System.EventHandler(this.inventryAddItemPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbx_invenrtyAddItemPopup_ItemType;
        private System.Windows.Forms.Label lbl_inventry_AddIPopup_ItemType;
    }
}