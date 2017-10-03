using SBW.UI.CustomerUserControls;
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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void btn_customerUC_Click(object sender, EventArgs e)
        {
            loadUserControl(new customerDetailsForm());
        }

        private void btn_loyaltycardUC_Click(object sender, EventArgs e)
        {
            loadUserControl(new customerLoyaltyCardForm());
        }

        private void btn_emailUC_Click(object sender, EventArgs e)
        {
            loadUserControl(new customerEmailForm());
        }

        private void loadUserControl(UserControl userControl)
        {
            panel_customerform.Controls.Clear();
            panel_customerform.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.Show();
        }

        
    }
}
