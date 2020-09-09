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
    public partial class AddVideo : Form
    {
        VideoCurdOperation _context = new VideoCurdOperation();
        public AddVideo()
        {
            InitializeComponent();
        }

        private void AddVideo_Load(object sender, EventArgs e)
        {
            getAllVideoList();
            btnSave.Enabled = true;
            btn_edit.Enabled = false;
            btn_del.Enabled = false;
            if (dtpReleaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
            {
                txtCost.Text = "2";
            }
            else
            {
                txtCost.Text = "5";
            }
            cmbGenre.SelectedIndex = 0;
        }
        private void dtpReleaseDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpReleaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
            {
                txtCost.Text = "2";
            }
            else
            {
                txtCost.Text = "5";
            }
        }
        public void getAllVideoList()
        {
            DataTable dt = new DataTable();

            dt = _context.getAllVideoList();
            gridVideo.DataSource = dt;
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("YOU WANT TO DELETE THIS Video ??", "Record Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int success = _context.deleteVideoById(Convert.ToInt32(lblMovieId.Text));
                if (success == 1)
                {
                    lblMovieId.Text = "";

                    ClearTextBoxes();
                    getAllVideoList();

                    MessageBox.Show("Successfully Delete Movie");
                    btnSave.Enabled = true;
                    btn_edit.Enabled = false;
                    btn_del.Enabled = false;
                    if (dtpReleaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
                    {
                        txtCost.Text = "2";
                    }
                    else
                    {
                        txtCost.Text = "5";
                    }
                }

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                MessageBox.Show("Movie Title is required");
                return;
            }
            else if (string.IsNullOrEmpty(txtCost.Text))
            {
                MessageBox.Show("Rental Cost is required");
                return;
            }

            int success = _context.insertVideo(txtTitle.Text, dtpReleaseDate.Value.Date, Convert.ToDecimal(txtCost.Text), cmbGenre.SelectedItem.ToString(), txtPlot.Text);
            if (success == 1)
            {
                lblMovieId.Text = "";

                ClearTextBoxes();
                getAllVideoList();

                MessageBox.Show("Successfully Add Movie");
                btnSave.Enabled = true;
                btn_edit.Enabled = false;
                btn_del.Enabled = false;
                if (dtpReleaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
                {
                    txtCost.Text = "2";
                }
                else
                {
                    txtCost.Text = "5";
                }
            }
            
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            int success = _context.updateVideoById(txtTitle.Text, dtpReleaseDate.Value.Date, Convert.ToDecimal(txtCost.Text), cmbGenre.SelectedItem.ToString(), txtPlot.Text, Convert.ToInt32(lblMovieId.Text));
            if (success == 1)
            {
                lblMovieId.Text = "";

                ClearTextBoxes();
                getAllVideoList();

                MessageBox.Show("Successfully Update Movie");
                btnSave.Enabled = true;
                btn_edit.Enabled = false;
                btn_del.Enabled = false;
                if (dtpReleaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
                {
                    txtCost.Text = "2";
                }
                else
                {
                    txtCost.Text = "5";
                }
            }
            else
            {
                MessageBox.Show("Wrong Data Input");
            }
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

      
       

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridVideo_Click(object sender, EventArgs e)
        {
            if (gridVideo.Rows.Count > 0)
            {
                lblMovieId.Text = gridVideo.CurrentRow.Cells[0].Value.ToString();
                txtTitle.Text = gridVideo.CurrentRow.Cells[1].Value.ToString();
                dtpReleaseDate.Text = gridVideo.CurrentRow.Cells[2].Value.ToString();
                txtCost.Text = gridVideo.CurrentRow.Cells[3].Value.ToString();
                cmbGenre.SelectedItem = gridVideo.CurrentRow.Cells[4].Value.ToString();
                txtPlot.Text = gridVideo.CurrentRow.Cells[5].Value.ToString();
                btnSave.Enabled = false;
                btn_del.Enabled = true;
                btn_edit.Enabled = true;

            }
        }

       

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            lblMovieId.Text = "";
           
            btnSave.Enabled = true;
            btn_edit.Enabled = false;
            btn_del.Enabled = false;
            getAllVideoList();
            txtTitle.Focus();
            if (dtpReleaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
            {
                txtCost.Text = "2";
            }
            else
            {
                txtCost.Text = "5";
            }
        }
    }
}
