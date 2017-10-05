namespace SBW.UI
{
    partial class EmployeeForm
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
            this.panel_UC = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_viewEmployee = new System.Windows.Forms.Button();
            this.btn_addEmployeeUC = new System.Windows.Forms.Button();
            this.panel_UC.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_UC
            // 
            this.panel_UC.Controls.Add(this.button6);
            this.panel_UC.Controls.Add(this.button5);
            this.panel_UC.Controls.Add(this.button4);
            this.panel_UC.Controls.Add(this.button3);
            this.panel_UC.Controls.Add(this.btn_viewEmployee);
            this.panel_UC.Controls.Add(this.btn_addEmployeeUC);
            this.panel_UC.Location = new System.Drawing.Point(-1, 0);
            this.panel_UC.MaximumSize = new System.Drawing.Size(1060, 552);
            this.panel_UC.MinimumSize = new System.Drawing.Size(1060, 552);
            this.panel_UC.Name = "panel_UC";
            this.panel_UC.Size = new System.Drawing.Size(1060, 552);
            this.panel_UC.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(623, 277);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(184, 100);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(374, 277);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 100);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(127, 277);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 100);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(623, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 100);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_viewEmployee
            // 
            this.btn_viewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewEmployee.Location = new System.Drawing.Point(374, 88);
            this.btn_viewEmployee.Name = "btn_viewEmployee";
            this.btn_viewEmployee.Size = new System.Drawing.Size(184, 100);
            this.btn_viewEmployee.TabIndex = 1;
            this.btn_viewEmployee.Text = "View Employees";
            this.btn_viewEmployee.UseVisualStyleBackColor = true;
            this.btn_viewEmployee.Click += new System.EventHandler(this.btn_viewEmployee_Click);
            // 
            // btn_addEmployeeUC
            // 
            this.btn_addEmployeeUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addEmployeeUC.Location = new System.Drawing.Point(127, 88);
            this.btn_addEmployeeUC.Name = "btn_addEmployeeUC";
            this.btn_addEmployeeUC.Size = new System.Drawing.Size(184, 100);
            this.btn_addEmployeeUC.TabIndex = 0;
            this.btn_addEmployeeUC.Text = "Add Employee";
            this.btn_addEmployeeUC.UseVisualStyleBackColor = true;
            this.btn_addEmployeeUC.Click += new System.EventHandler(this.btn_addEmployeeUC_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 552);
            this.ControlBox = false;
            this.Controls.Add(this.panel_UC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1060, 552);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1060, 552);
            this.Name = "EmployeeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.panel_UC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_UC;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_viewEmployee;
        private System.Windows.Forms.Button btn_addEmployeeUC;
    }
}