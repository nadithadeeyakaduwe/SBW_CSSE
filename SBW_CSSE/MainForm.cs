using SBW.BusinessService;
using SBW.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBW.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IEmployeeService employeeService = ServiceFactory.GetEmployeeSeriveice();

            label1.Text = employeeService.getEmployeeName(Convert.ToInt32(textBox1.Text));
        }
    }
}
