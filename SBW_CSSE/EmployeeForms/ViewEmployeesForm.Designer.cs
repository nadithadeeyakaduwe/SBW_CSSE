namespace SBW.UI.EmployeeForms
{
    partial class ViewEmployeesForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_nameNic = new System.Windows.Forms.Label();
            this.dgv_employeeWithTitles = new System.Windows.Forms.DataGridView();
            this.dgvCol_employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_epfNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_performanceHistory = new System.Windows.Forms.Button();
            this.btn_attendance = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_promote = new System.Windows.Forms.Button();
            this.btn_giveIncrement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employeeWithTitles)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(208, 31);
            this.tb_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(679, 25);
            this.tb_search.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(927, 19);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(124, 46);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_nameNic
            // 
            this.lbl_nameNic.AutoSize = true;
            this.lbl_nameNic.Location = new System.Drawing.Point(30, 34);
            this.lbl_nameNic.Name = "lbl_nameNic";
            this.lbl_nameNic.Size = new System.Drawing.Size(139, 18);
            this.lbl_nameNic.TabIndex = 2;
            this.lbl_nameNic.Text = "Employee Name / NIC";
            // 
            // dgv_employeeWithTitles
            // 
            this.dgv_employeeWithTitles.AllowUserToAddRows = false;
            this.dgv_employeeWithTitles.AllowUserToDeleteRows = false;
            this.dgv_employeeWithTitles.AllowUserToResizeColumns = false;
            this.dgv_employeeWithTitles.AllowUserToResizeRows = false;
            this.dgv_employeeWithTitles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_employeeWithTitles.BackgroundColor = System.Drawing.Color.White;
            this.dgv_employeeWithTitles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_employeeWithTitles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employeeWithTitles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCol_employeeID,
            this.dgvCol_epfNo,
            this.dgvCol_Name,
            this.dgvCol_title,
            this.dgvCol_department});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_employeeWithTitles.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_employeeWithTitles.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_employeeWithTitles.Location = new System.Drawing.Point(77, 97);
            this.dgv_employeeWithTitles.MultiSelect = false;
            this.dgv_employeeWithTitles.Name = "dgv_employeeWithTitles";
            this.dgv_employeeWithTitles.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_employeeWithTitles.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_employeeWithTitles.RowHeadersVisible = false;
            this.dgv_employeeWithTitles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_employeeWithTitles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_employeeWithTitles.Size = new System.Drawing.Size(810, 444);
            this.dgv_employeeWithTitles.TabIndex = 3;
            this.dgv_employeeWithTitles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_employeeWithTitles_CellDoubleClick);
            // 
            // dgvCol_employeeID
            // 
            this.dgvCol_employeeID.DataPropertyName = "EmployeeID";
            this.dgvCol_employeeID.HeaderText = "EmployeeID";
            this.dgvCol_employeeID.Name = "dgvCol_employeeID";
            this.dgvCol_employeeID.ReadOnly = true;
            this.dgvCol_employeeID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCol_employeeID.Visible = false;
            // 
            // dgvCol_epfNo
            // 
            this.dgvCol_epfNo.DataPropertyName = "EpfNo";
            this.dgvCol_epfNo.HeaderText = "EpfNo";
            this.dgvCol_epfNo.Name = "dgvCol_epfNo";
            this.dgvCol_epfNo.ReadOnly = true;
            this.dgvCol_epfNo.Visible = false;
            // 
            // dgvCol_Name
            // 
            this.dgvCol_Name.DataPropertyName = "Name";
            this.dgvCol_Name.HeaderText = "Name";
            this.dgvCol_Name.Name = "dgvCol_Name";
            this.dgvCol_Name.ReadOnly = true;
            // 
            // dgvCol_title
            // 
            this.dgvCol_title.DataPropertyName = "Title";
            this.dgvCol_title.HeaderText = "Title";
            this.dgvCol_title.Name = "dgvCol_title";
            this.dgvCol_title.ReadOnly = true;
            // 
            // dgvCol_department
            // 
            this.dgvCol_department.DataPropertyName = "Department";
            this.dgvCol_department.HeaderText = "Department";
            this.dgvCol_department.Name = "dgvCol_department";
            this.dgvCol_department.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_performanceHistory);
            this.panel1.Controls.Add(this.btn_attendance);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btn_promote);
            this.panel1.Controls.Add(this.btn_giveIncrement);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.dgv_employeeWithTitles);
            this.panel1.Controls.Add(this.tb_search);
            this.panel1.Controls.Add(this.lbl_nameNic);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 553);
            this.panel1.TabIndex = 4;
            // 
            // btn_performanceHistory
            // 
            this.btn_performanceHistory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_performanceHistory.Location = new System.Drawing.Point(926, 473);
            this.btn_performanceHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_performanceHistory.Name = "btn_performanceHistory";
            this.btn_performanceHistory.Size = new System.Drawing.Size(124, 46);
            this.btn_performanceHistory.TabIndex = 8;
            this.btn_performanceHistory.Text = "Perfomance History";
            this.btn_performanceHistory.UseVisualStyleBackColor = true;
            this.btn_performanceHistory.Click += new System.EventHandler(this.btn_performanceHistory_Click);
            // 
            // btn_attendance
            // 
            this.btn_attendance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_attendance.Location = new System.Drawing.Point(927, 173);
            this.btn_attendance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_attendance.Name = "btn_attendance";
            this.btn_attendance.Size = new System.Drawing.Size(124, 46);
            this.btn_attendance.TabIndex = 7;
            this.btn_attendance.Text = "Attendance";
            this.btn_attendance.UseVisualStyleBackColor = true;
            this.btn_attendance.Click += new System.EventHandler(this.btn_attendance_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(927, 248);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 46);
            this.button3.TabIndex = 6;
            this.button3.Text = "Leave";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_promote
            // 
            this.btn_promote.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_promote.Location = new System.Drawing.Point(927, 398);
            this.btn_promote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_promote.Name = "btn_promote";
            this.btn_promote.Size = new System.Drawing.Size(124, 46);
            this.btn_promote.TabIndex = 5;
            this.btn_promote.Text = "Promote";
            this.btn_promote.UseVisualStyleBackColor = true;
            this.btn_promote.Click += new System.EventHandler(this.btn_promote_Click);
            // 
            // btn_giveIncrement
            // 
            this.btn_giveIncrement.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_giveIncrement.Location = new System.Drawing.Point(927, 323);
            this.btn_giveIncrement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_giveIncrement.Name = "btn_giveIncrement";
            this.btn_giveIncrement.Size = new System.Drawing.Size(124, 46);
            this.btn_giveIncrement.TabIndex = 4;
            this.btn_giveIncrement.Text = "Give Increment";
            this.btn_giveIncrement.UseVisualStyleBackColor = true;
            this.btn_giveIncrement.Click += new System.EventHandler(this.btn_giveIncrement_Click);
            // 
            // ViewEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 552);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1060, 552);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1060, 552);
            this.Name = "ViewEmployeesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.ViewEmployeesUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employeeWithTitles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_nameNic;
        private System.Windows.Forms.DataGridView dgv_employeeWithTitles;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_performanceHistory;
        private System.Windows.Forms.Button btn_attendance;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_promote;
        private System.Windows.Forms.Button btn_giveIncrement;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_epfNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_department;
    }
}
