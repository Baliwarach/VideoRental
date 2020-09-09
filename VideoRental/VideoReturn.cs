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
    public partial class VideoReturn : Form
    {
        SqldbContext _context = new SqldbContext();
        public VideoReturn()
        {
            InitializeComponent();
        }

        private void VideoReturn_Load(object sender, EventArgs e)
        {
            allRentedOutVideo();
        }
        private void buttonReturnVideo_Click(object sender, EventArgs e)
        {
            var rentalId = "";
            var videoId = "";
            if (gridRentedMovie.Rows.Count > 0)
            {
                rentalId = gridRentedMovie.CurrentRow.Cells["RMID"].Value.ToString();

                videoId = gridRentedMovie.CurrentRow.Cells["MovieId"].Value.ToString();
            }
            if (string.IsNullOrEmpty(rentalId))
            {
                MessageBox.Show("No any Video for Rental");
                return;
            }



            int i = _context.returnedMovie(Convert.ToInt32(rentalId));
            if (i == 1)
            {
                int chngeStatus = _context.changedAvailableStatus(Convert.ToInt32(videoId), "Yes");
                MessageBox.Show("Video Returned successfully");

                allRentedOutVideo();
            }
        }
        private void allRentedOutVideo()
        {
            DataTable dt = new DataTable();

            dt = _context.allRentedOutVideo();
            gridRentedMovie.DataSource = dt;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
