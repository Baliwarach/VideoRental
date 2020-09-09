using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRental
{
    public partial class CustomerList : Form
    {
        SqldbContext _context = new SqldbContext();
        public CustomerList()
        {
            InitializeComponent();
        }

        private void RegularCustomer_Load(object sender, EventArgs e)
        {
            WhoMostBorrowList();
        }
        private void WhoMostBorrowList()
        {
            DataTable dt = new DataTable();
            dt = _context.WhoMostBorrowList();

            gridMostBorrowList.DataSource = dt;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
