using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRental
{
    public partial class AddCustomer : Form
    {
        CustomerCurd _context = new CustomerCurd();
        public AddCustomer()
        {
            InitializeComponent();
        }

       
        public void getAllCustomerList()
        {
            DataTable dt = new DataTable();

            dt = _context.getAllCustomerList();

            CustomerGrid.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textname.Text))
            {
                MessageBox.Show("First Name is required");
                return;
            }
            else if (string.IsNullOrEmpty(textLastName.Text))
            {
                MessageBox.Show("Last Name is required");
                return;
            }
            else if (string.IsNullOrEmpty(textAddress.Text))
            {
                MessageBox.Show("Address is required");
                return;
            }
            else if (string.IsNullOrEmpty(textmobile_no.Text))
            {
                MessageBox.Show("Phone No. is required");
                return;
            }
            int cust = _context.addNewCustomer(textname.Text, textLastName.Text, textAddress.Text, textmobile_no.Text);
            if (cust == 1)
            {
                lblCustId.Text = "";

                ClearTextBoxes();
                getAllCustomerList();

                MessageBox.Show("Successfully Add Customer");
                btnSave.Enabled = true;
                btn_edit.Enabled = false;
                btn_del.Enabled = false;
            }
           
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            getAllCustomerList();
            btnSave.Enabled = true;
            btn_edit.Enabled = false;
            btn_del.Enabled = false;

        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {

            int cust = _context.updateCustomerById(textname.Text, textLastName.Text, textAddress.Text, textmobile_no.Text, Convert.ToInt32(lblCustId.Text));
            if (cust == 1)
            {
                lblCustId.Text = "";

                ClearTextBoxes();
                getAllCustomerList();

                MessageBox.Show("Successfully Update Customer");
                btnSave.Enabled = true;
                btn_edit.Enabled = false;
                btn_del.Enabled = false;
            }
            else
            {
                MessageBox.Show("Wrong Data Input");
            }
        }

        

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
           
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE THIS Customer ??", "Customer Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int cust = _context.deleteCustomerById(Convert.ToInt32(lblCustId.Text));
                if (cust == 1)
                {
                    lblCustId.Text = "";

                    ClearTextBoxes();
                    getAllCustomerList();

                    MessageBox.Show("Successfully Delete Customer");
                   
                    btnSave.Enabled = true;
                    btn_edit.Enabled = false;
                    btn_del.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Wrong Data Input");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
               
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            lblCustId.Text = "";
            //txt_custno.Enabled = true;
            btnSave.Enabled = true;
            btn_edit.Enabled = false;
            btn_del.Enabled = false;
            getAllCustomerList();
            textname.Focus();
        }

        private void CustomerGrid_Click(object sender, EventArgs e)
        {
            if (CustomerGrid.Rows.Count > 0)
            {
                lblCustId.Text = CustomerGrid.CurrentRow.Cells[0].Value.ToString();
                textname.Text = CustomerGrid.CurrentRow.Cells[1].Value.ToString();
                textLastName.Text = CustomerGrid.CurrentRow.Cells[2].Value.ToString();
                textAddress.Text = CustomerGrid.CurrentRow.Cells[3].Value.ToString();
                textmobile_no.Text = CustomerGrid.CurrentRow.Cells[4].Value.ToString();
                btnSave.Enabled = false;
                btn_edit.Enabled = true;
                btn_del.Enabled = true;
            }
        }
    }
}
