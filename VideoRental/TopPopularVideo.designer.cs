namespace VideoRental
{
    partial class PopularVideo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridPopularVideoList = new System.Windows.Forms.DataGridView();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPopularVideoList)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(374, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(394, 46);
            this.label5.TabIndex = 67;
            this.label5.Text = "Popular Video\'s List";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.gridPopularVideoList);
            this.panel1.Location = new System.Drawing.Point(199, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 450);
            this.panel1.TabIndex = 66;
            // 
            // gridPopularVideoList
            // 
            this.gridPopularVideoList.AllowUserToAddRows = false;
            this.gridPopularVideoList.AllowUserToDeleteRows = false;
            this.gridPopularVideoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPopularVideoList.Location = new System.Drawing.Point(25, 13);
            this.gridPopularVideoList.Name = "gridPopularVideoList";
            this.gridPopularVideoList.ReadOnly = true;
            this.gridPopularVideoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPopularVideoList.Size = new System.Drawing.Size(684, 413);
            this.gridPopularVideoList.TabIndex = 5;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_close.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_close.Location = new System.Drawing.Point(12, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Padding = new System.Windows.Forms.Padding(12, 0, 9, 0);
            this.btn_close.Size = new System.Drawing.Size(122, 39);
            this.btn_close.TabIndex = 77;
            this.btn_close.Text = "<<Back";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // PopularVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VideoRentalManagement.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1252, 729);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "PopularVideo";
            this.Text = "PopularVideo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PopularVideo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPopularVideoList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridPopularVideoList;
        private System.Windows.Forms.Button btn_close;
    }
}