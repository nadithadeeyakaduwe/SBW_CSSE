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
using SBW.Entities.CustomerModule;
using System.Data.SqlClient;

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

            btn_loy_update.Enabled = false;
            btn_loy_delete.Enabled = false;

            cmb_loy_cardtype.Items.Add("GOLD");
            cmb_loy_cardtype.Items.Add("SILVER");
            cmb_loy_cardtype.Items.Add("BRONZE");
            cmb_loy_selectCardType.SelectedItem = 0;
            //lbl_loymem_cardno.Visible = false;
        }

        //customer loyalty fillgrid
        public void CustomerLotaltyCardFillGrid()
        {
            try
            {
                service = ServiceFactory.GetCustomerSeriveice();
                DataTable dt = new DataTable();

                string cardType = cmb_loy_selectCardType.Text;
                dt = service.ViewCustomerLoyaltyDetails(cardType);
                dgv_loyalty_table.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }         
        }

        //feild validation for loyalty from 
        public bool CustomerLoyaltyCardValidation()
        {
            bool status = false;

            if (txt_loy_nic.Text == "")
                MessageBox.Show("Please fill the Customer NIC field");
            else if (txt_loy_nic.TextLength != 10)
                MessageBox.Show("Required Length of Customer NIC is wrong");
            else if (!txt_loy_nic.ToString().EndsWith("v") || txt_loy_nic.ToString().EndsWith("V"))
                MessageBox.Show("please end the Customer NIC with letter 'v' or 'V'");
            else if (cmb_loy_cardtype.Text == "")
                MessageBox.Show("Please click on the card type feild to generate card type (Gold / Silver / bronze)");
            else if (lbl_loymem_cardno.Text == "")
                MessageBox.Show("Please click on the card no feild");
            // else if (txtb_loy_cardpoints == null)
            // MessageBox.Show("Please add card points");
            // else if (Convert.ToInt32(txtb_loy_cardpoints) < 0)
            //MessageBox.Show("Please enter only positive values");
            else
            {
                status = true;

            }
            return status;
        }
   
        //add loyalty member
        private void btn_loy_add_Click(object sender, EventArgs e)
        {
            if (CustomerLoyaltyCardValidation())
            {             
                addLoyaltyCardDetails();              
            }
            else
                MessageBox.Show("Add customer request cannot complete. Please fill valid data");

            CustomerLotaltyCardFillGrid();
            Clear();
        }

        private void addLoyaltyCardDetails() {
         
            string customerNIC = txt_loy_nic.Text;

            service = ServiceFactory.GetCustomerSeriveice();
            bool result1 = service.CheckForCustomerAvailability(customerNIC);

            if (!result1)
            {
                MessageBox.Show("This customer is not registered customer cannot issue a loyalty card");
            }
            else {
                if (CustomerLoyaltyCardValidation())
                {
                    Customer customer = new Customer();

                    customer.NIC = txt_loy_nic.Text;
                    customer.CardType = cmb_loy_cardtype.SelectedItem.ToString();
                    customer.CardNo = lbl_loymem_cardno.Text;
                    //customer.CardPoints = Convert.ToInt32(txtb_loy_cardpoints.Text);
                    customer.CardPoints = 0;

                    //show the confirmation dialog box
                    DialogResult dr;
                    dr = MessageBox.Show("Do you want to save the record", "Confirm", MessageBoxButtons.YesNo);
                    if (dr.ToString() == "Yes")
                    {
                        try
                        {
                            bool result2 = service.AddLoyaltyCustomer(customer);

                            if (result2)
                            {
                                MessageBox.Show("Successfully Saved", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //tb_cus_tabcontroller.SelectedTab = tab_customermanagement;
                            }
                            else
                            {
                                MessageBox.Show("Unable to Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        catch (ApplicationException appEx)
                        {
                            MessageBox.Show(appEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Number == 2627)
                            {
                                MessageBox.Show("This loyalty customer is alreay exist, please add new customer ");
                                //Violation of primary key. Handle Exception
                            }
                        }
                    }
                    else
                        MessageBox.Show("Record is not saved", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            CustomerLotaltyCardFillGrid();
            Clear();          
        }

        private void combo_grid_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerLotaltyCardFillGrid();
        }

        private void dgv_loyalty_table_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {           
            btn_loy_update.Enabled = true;
            btn_loy_delete.Enabled = true;

            try
            {
                string nic = ((DataGridView)sender).Rows[e.RowIndex].Cells[1].Value.ToString();
                string cardNo = ((DataGridView)sender).Rows[e.RowIndex].Cells[2].Value.ToString();
                string cardPoints = ((DataGridView)sender).Rows[e.RowIndex].Cells[3].Value.ToString();
                string cardType = ((DataGridView)sender).Rows[e.RowIndex].Cells[4].Value.ToString();

                txt_loy_nic.Text = nic;
                lbl_loymem_cardno.Text = cardNo;
                cmb_loy_cardtype.Text = cardType;

                txt_loy_nic.Enabled = false;
                btn_loy_add.Enabled = false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Clear Customer loyalty feilds
        public void Clear()
        {

            txt_loy_nic.Clear();
            cmb_loy_cardtype.SelectedIndex = -1;
            lbl_loymem_cardno.Text = "Click";
            
            txt_loy_nic.Enabled = true;
            btn_loy_add.Enabled = true;
            btn_loy_update.Enabled = false;
            btn_loy_delete.Enabled = false;

            CustomerLotaltyCardFillGrid();
        }

        private void btn_cusLoy_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //card no generation
        private void lbl_loymem_cardno_Click(object sender, EventArgs e)
        {
            if (txt_loy_nic.Text != "" && txt_loy_nic.TextLength == 10 && cmb_loy_cardtype.Text != "")
            {

                String card1 = cmb_loy_cardtype.Text.Substring(0, 2).ToUpper();
                String card2 = txt_loy_nic.Text.Substring(0, 9);

                String cardNo = string.Concat(card1, card2);
                lbl_loymem_cardno.Text = cardNo;

            }
            else if (txt_loy_nic.Text == "")
                MessageBox.Show("Please fill the NIC feild");
            else if (txt_loy_nic.TextLength != 10)
                MessageBox.Show("Required Length of Customer NIC is wrong");

        }

        private void gpb_cuc_loyalty_Enter(object sender, EventArgs e)
        {

        }

        private void txt_loy_nic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back || e.KeyChar == 'v' || e.KeyChar == 'V')
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }       
    }
}
