using SBW.UI.InventoryUserControls;
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
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_inventoryUC_Click(object sender, EventArgs e)
        {
            loadUserControl(new InventoryDetailsForm());
        }

        private void loadUserControl(UserControl userControl)
        {
            panel_InventoryForm.Controls.Clear();
            panel_InventoryForm.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.Show();
        }
    }
}
