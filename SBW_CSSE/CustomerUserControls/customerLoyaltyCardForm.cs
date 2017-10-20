using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBW.Services;
using SBW.BusinessService;

namespace SBW.UI.CustomerUserControls
{
    public partial class customerLoyaltyCardForm : UserControl
    {
        ICustomerService service;
        public customerLoyaltyCardForm()
        {
            InitializeComponent();
        }

        private void customerLoyaltyCardForm_Load(object sender, EventArgs e)
        {
            CustomerLotaltyCardFillGrid();
        }

        //customer loyalty fillgrid
        public void CustomerLotaltyCardFillGrid()
        {
            try
            {
                service = ServiceFactory.GetCustomerSeriveice();
                DataTable dt = new DataTable();
                dt = service.ViewCustomerLoyaltyDetails();
                dgv_loyalty_table.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_loy_add_Click(object sender, EventArgs e)
        {

        }

    }
}
