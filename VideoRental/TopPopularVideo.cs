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
    public partial class PopularVideo : Form
    {
        SqldbContext _context = new SqldbContext();
        public PopularVideo()
        {
            InitializeComponent();
        }

        private void PopularVideo_Load(object sender, EventArgs e)
        {
            getAllPopularVideo();
        }
        private void getAllPopularVideo()
        {
            DataTable dt = new DataTable();
            dt = _context.getAllPopularVideo();

            gridPopularVideoList.DataSource = dt;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
