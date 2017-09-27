using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBW.UI.Sales_n_Profit;

namespace SBW.UI
{
    public partial class SalesNProfit : Form
    {
        public SalesNProfit()
        {
            InitializeComponent();
        }

        private void SalesNProfit_Load(object sender, EventArgs e)
        {

        }

        private void btn_salesNprofit_invoice_Click(object sender, EventArgs e)
        {
            loadUserControl(new Invoiceform());
        }

        private void loadUserControl(UserControl userControl)
        {
            panel_saleNprofit.Controls.Clear();
            panel_saleNprofit.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
