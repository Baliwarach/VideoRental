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
    public partial class RentalVideo : Form
    {
        SqldbContext _context = new SqldbContext();
        CustomerCurd _CusromerContext = new CustomerCurd();
        SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["VRSDatabase"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        public RentalVideo()
        {
            InitializeComponent();
        }

        private void Issue_ReturnVideo_Load(object sender, EventArgs e)
        {
            getAllCustomerList();
            getAvailableVideo();
            GetAllRentedVideoView();
           
        }
        private void getAllCustomerList()
        {

            DataTable dt = new DataTable();

            dt = _CusromerContext.getAllCustomerList();
          
            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "Select Customer";
            dt.Rows.InsertAt(row, 0);
            cmbCustomer.DataSource = dt;
            cmbCustomer.ValueMember = "CustId";
            cmbCustomer.DisplayMember = "FirstName";

         
        }
        private void getAvailableVideo()
        {

            DataTable dt = new DataTable();

            dt = _context.getAvailableVideo();
           
            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "Select Movie";
            dt.Rows.InsertAt(row, 0);
            cmbVideo.DataSource = dt;
            cmbVideo.ValueMember = "MovieId";
            cmbVideo.DisplayMember = "Title";

           
        }

        private void btnRentalVideo_Click(object sender, EventArgs e)
        {
            bool verifyRental = Verify();
            if (verifyRental == true)
            {
                int rental = _context.insertVideoOnRental(Convert.ToInt32(cmbVideo.SelectedValue.ToString()), Convert.ToInt32(cmbCustomer.SelectedValue.ToString()), dtpRentedDate.Value.Date);

                if (rental == 1)
                {
                    int chngeStatus = _context.changedAvailableStatus(Convert.ToInt32(cmbVideo.SelectedValue.ToString()), "No");
                    MessageBox.Show("Movie Rented successfully");
                    getAllCustomerList();
                    getAvailableVideo();
                    GetAllRentedVideoView();

                }
            }
            
        }
        private void GetAllRentedVideoView()
        {
            DataTable dt = new DataTable();

            dt = _context.GetAllRentedVideoView();

            //custGrid.AutoGenerateColumns = false;
            gridRentedMovie.DataSource = dt;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
       
        private void allRentedOutVideo()
        {
            DataTable dt = new DataTable();

            dt = _context.allRentedOutVideo();

            //custGrid.AutoGenerateColumns = false;
            gridRentedMovie.DataSource = dt;
        }
        public bool Verify()
        {
            if (cmbCustomer.SelectedValue == null || cmbVideo.SelectedValue == null)
            {
                MessageBox.Show("Please Select the Customer and Video");
                return false;
            }
            if (cmbCustomer.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Customer");
                return false;
            }
            if (cmbVideo.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Video");
                return false;
            }
            if (string.IsNullOrEmpty(cmbCustomer.SelectedValue.ToString()) || string.IsNullOrEmpty(cmbVideo.SelectedValue.ToString()))
            {
                MessageBox.Show("Please Select the Customer and Movie for rental");
                return false;
            }

            return true;
        }
       
    }
}
