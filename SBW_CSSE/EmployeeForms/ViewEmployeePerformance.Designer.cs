namespace SBW.UI.EmployeeForms
{
    partial class ViewEmployeePerformance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_employeeID = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_nameValue = new System.Windows.Forms.Label();
            this.lbl_epfNo = new System.Windows.Forms.Label();
            this.lbl_epfNoValue = new System.Windows.Forms.Label();
            this.lbl_joinedDate = new System.Windows.Forms.Label();
            this.lbl_joinedDateValue = new System.Windows.Forms.Label();
            this.dgv_employeePerformance = new System.Windows.Forms.DataGridView();
            this.dgvCol_promotedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_newPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_previousPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_newBasicSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_previousBasicSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employeePerformance)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(956, 41);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(92, 47);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_employeeID
            // 
            this.lbl_employeeID.AutoSize = true;
            this.lbl_employeeID.Location = new System.Drawing.Point(12, 9);
            this.lbl_employeeID.Name = "lbl_employeeID";
            this.lbl_employeeID.Size = new System.Drawing.Size(70, 15);
            this.lbl_employeeID.TabIndex = 1;
            this.lbl_employeeID.Text = "EmployeeID";
            this.lbl_employeeID.Visible = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(45, 41);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(39, 15);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name";
            // 
            // lbl_nameValue
            // 
            this.lbl_nameValue.AutoSize = true;
            this.lbl_nameValue.Location = new System.Drawing.Point(180, 41);
            this.lbl_nameValue.Name = "lbl_nameValue";
            this.lbl_nameValue.Size = new System.Drawing.Size(94, 15);
            this.lbl_nameValue.TabIndex = 3;
            this.lbl_nameValue.Text = "Employee Name";
            // 
            // lbl_epfNo
            // 
            this.lbl_epfNo.AutoSize = true;
            this.lbl_epfNo.Location = new System.Drawing.Point(45, 89);
            this.lbl_epfNo.Name = "lbl_epfNo";
            this.lbl_epfNo.Size = new System.Drawing.Size(45, 15);
            this.lbl_epfNo.TabIndex = 4;
            this.lbl_epfNo.Text = "EPF No";
            // 
            // lbl_epfNoValue
            // 
            this.lbl_epfNoValue.AutoSize = true;
            this.lbl_epfNoValue.Location = new System.Drawing.Point(180, 89);
            this.lbl_epfNoValue.Name = "lbl_epfNoValue";
            this.lbl_epfNoValue.Size = new System.Drawing.Size(45, 15);
            this.lbl_epfNoValue.TabIndex = 5;
            this.lbl_epfNoValue.Text = "EPF No";
            // 
            // lbl_joinedDate
            // 
            this.lbl_joinedDate.AutoSize = true;
            this.lbl_joinedDate.Location = new System.Drawing.Point(489, 41);
            this.lbl_joinedDate.Name = "lbl_joinedDate";
            this.lbl_joinedDate.Size = new System.Drawing.Size(68, 15);
            this.lbl_joinedDate.TabIndex = 6;
            this.lbl_joinedDate.Text = "Joined Date";
            // 
            // lbl_joinedDateValue
            // 
            this.lbl_joinedDateValue.AutoSize = true;
            this.lbl_joinedDateValue.Location = new System.Drawing.Point(624, 41);
            this.lbl_joinedDateValue.Name = "lbl_joinedDateValue";
            this.lbl_joinedDateValue.Size = new System.Drawing.Size(68, 15);
            this.lbl_joinedDateValue.TabIndex = 7;
            this.lbl_joinedDateValue.Text = "Joined Date";
            // 
            // dgv_employeePerformance
            // 
            this.dgv_employeePerformance.AllowUserToAddRows = false;
            this.dgv_employeePerformance.AllowUserToDeleteRows = false;
            this.dgv_employeePerformance.AllowUserToResizeColumns = false;
            this.dgv_employeePerformance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_employeePerformance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_employeePerformance.BackgroundColor = System.Drawing.Color.White;
            this.dgv_employeePerformance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employeePerformance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCol_promotedDate,
            this.dgvCol_newPosition,
            this.dgvCol_previousPosition,
            this.dgvCol_newBasicSalary,
            this.dgvCol_previousBasicSalary,
            this.dgvCol_status,
            this.dgvCol_reason});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_employeePerformance.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_employeePerformance.Location = new System.Drawing.Point(15, 124);
            this.dgv_employeePerformance.MultiSelect = false;
            this.dgv_employeePerformance.Name = "dgv_employeePerformance";
            this.dgv_employeePerformance.ReadOnly = true;
            this.dgv_employeePerformance.RowHeadersVisible = false;
            this.dgv_employeePerformance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_employeePerformance.Size = new System.Drawing.Size(1033, 416);
            this.dgv_employeePerformance.TabIndex = 8;
            // 
            // dgvCol_promotedDate
            // 
            this.dgvCol_promotedDate.DataPropertyName = "EffectiveDate";
            this.dgvCol_promotedDate.HeaderText = "Promoted Date";
            this.dgvCol_promotedDate.Name = "dgvCol_promotedDate";
            this.dgvCol_promotedDate.ReadOnly = true;
            // 
            // dgvCol_newPosition
            // 
            this.dgvCol_newPosition.DataPropertyName = "NewPosition";
            this.dgvCol_newPosition.HeaderText = "New Position";
            this.dgvCol_newPosition.Name = "dgvCol_newPosition";
            this.dgvCol_newPosition.ReadOnly = true;
            // 
            // dgvCol_previousPosition
            // 
            this.dgvCol_previousPosition.DataPropertyName = "OldPosition";
            this.dgvCol_previousPosition.HeaderText = "Previous Position";
            this.dgvCol_previousPosition.Name = "dgvCol_previousPosition";
            this.dgvCol_previousPosition.ReadOnly = true;
            // 
            // dgvCol_newBasicSalary
            // 
            this.dgvCol_newBasicSalary.DataPropertyName = "NewSalary";
            this.dgvCol_newBasicSalary.HeaderText = "New Basic Salary";
            this.dgvCol_newBasicSalary.Name = "dgvCol_newBasicSalary";
            this.dgvCol_newBasicSalary.ReadOnly = true;
            // 
            // dgvCol_previousBasicSalary
            // 
            this.dgvCol_previousBasicSalary.DataPropertyName = "OldSalary";
            this.dgvCol_previousBasicSalary.HeaderText = "Previous Basic Salary";
            this.dgvCol_previousBasicSalary.Name = "dgvCol_previousBasicSalary";
            this.dgvCol_previousBasicSalary.ReadOnly = true;
            // 
            // dgvCol_status
            // 
            this.dgvCol_status.DataPropertyName = "Status";
            this.dgvCol_status.HeaderText = "Promotion / Increment";
            this.dgvCol_status.Name = "dgvCol_status";
            this.dgvCol_status.ReadOnly = true;
            // 
            // dgvCol_reason
            // 
            this.dgvCol_reason.DataPropertyName = "Reason";
            this.dgvCol_reason.HeaderText = "Reason";
            this.dgvCol_reason.Name = "dgvCol_reason";
            this.dgvCol_reason.ReadOnly = true;
            // 
            // ViewEmployeePerformance
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 552);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_employeePerformance);
            this.Controls.Add(this.lbl_joinedDateValue);
            this.Controls.Add(this.lbl_joinedDate);
            this.Controls.Add(this.lbl_epfNoValue);
            this.Controls.Add(this.lbl_epfNo);
            this.Controls.Add(this.lbl_nameValue);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_employeeID);
            this.Controls.Add(this.btn_back);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1060, 552);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1060, 552);
            this.Name = "ViewEmployeePerformance";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.ViewEmployeePerformance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employeePerformance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_employeeID;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_nameValue;
        private System.Windows.Forms.Label lbl_epfNo;
        private System.Windows.Forms.Label lbl_epfNoValue;
        private System.Windows.Forms.Label lbl_joinedDate;
        private System.Windows.Forms.Label lbl_joinedDateValue;
        private System.Windows.Forms.DataGridView dgv_employeePerformance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_promotedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_newPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_previousPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_newBasicSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_previousBasicSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_reason;
    }
}