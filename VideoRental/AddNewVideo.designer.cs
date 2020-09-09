namespace VideoRental
{
    partial class AddVideo
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
            this.lblMovieId = new System.Windows.Forms.Label();
            this.gridVideo = new System.Windows.Forms.DataGridView();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMovieId
            // 
            this.lblMovieId.AutoSize = true;
            this.lblMovieId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieId.Location = new System.Drawing.Point(57, 76);
            this.lblMovieId.Name = "lblMovieId";
            this.lblMovieId.Size = new System.Drawing.Size(0, 13);
            this.lblMovieId.TabIndex = 66;
            this.lblMovieId.Visible = false;
            // 
            // gridVideo
            // 
            this.gridVideo.AllowUserToAddRows = false;
            this.gridVideo.AllowUserToDeleteRows = false;
            this.gridVideo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVideo.Location = new System.Drawing.Point(366, 105);
            this.gridVideo.Name = "gridVideo";
            this.gridVideo.ReadOnly = true;
            this.gridVideo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVideo.Size = new System.Drawing.Size(735, 273);
            this.gridVideo.TabIndex = 64;
            this.gridVideo.Click += new System.EventHandler(this.gridVideo_Click);
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReleaseDate.Location = new System.Drawing.Point(156, 151);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(180, 20);
            this.dtpReleaseDate.TabIndex = 51;
            this.dtpReleaseDate.ValueChanged += new System.EventHandler(this.dtpReleaseDate_ValueChanged);
            // 
            // txtPlot
            // 
            this.txtPlot.Location = new System.Drawing.Point(156, 288);
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(180, 20);
            this.txtPlot.TabIndex = 54;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(156, 197);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(180, 20);
            this.txtCost.TabIndex = 52;
            this.txtCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCost_KeyPress);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(156, 105);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(180, 20);
            this.txtTitle.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(310, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 46);
            this.label1.TabIndex = 67;
            this.label1.Text = "Add New Video";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(38, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(31, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Release Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(31, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 70;
            this.label6.Text = "Rental Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(31, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(31, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 72;
            this.label5.Text = "Plot";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.White;
            this.btn_cancel.BackgroundImage = global::VideoRentalManagement.Properties.Resources._1;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_cancel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_cancel.Location = new System.Drawing.Point(554, 435);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Padding = new System.Windows.Forms.Padding(12, 0, 9, 0);
            this.btn_cancel.Size = new System.Drawing.Size(118, 39);
            this.btn_cancel.TabIndex = 77;
            this.btn_cancel.Text = "Clear";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.BackgroundImage = global::VideoRentalManagement.Properties.Resources._1;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_close.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_close.Location = new System.Drawing.Point(687, 435);
            this.btn_close.Name = "btn_close";
            this.btn_close.Padding = new System.Windows.Forms.Padding(12, 0, 9, 0);
            this.btn_close.Size = new System.Drawing.Size(122, 39);
            this.btn_close.TabIndex = 76;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.White;
            this.btn_del.BackgroundImage = global::VideoRentalManagement.Properties.Resources._1;
            this.btn_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_del.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_del.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_del.Location = new System.Drawing.Point(424, 435);
            this.btn_del.Name = "btn_del";
            this.btn_del.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_del.Size = new System.Drawing.Size(116, 39);
            this.btn_del.TabIndex = 75;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.White;
            this.btn_edit.BackgroundImage = global::VideoRentalManagement.Properties.Resources._1;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_edit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_edit.Location = new System.Drawing.Point(279, 435);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Padding = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.btn_edit.Size = new System.Drawing.Size(132, 39);
            this.btn_edit.TabIndex = 74;
            this.btn_edit.Text = "Update";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BackgroundImage = global::VideoRentalManagement.Properties.Resources._1;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(156, 435);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.btnSave.Size = new System.Drawing.Size(112, 39);
            this.btnSave.TabIndex = 73;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Items.AddRange(new object[] {
            "Action",
            "Comedy",
            "Romentic",
            "Horror",
            "Drama",
            "Thriller"});
            this.cmbGenre.Location = new System.Drawing.Point(156, 243);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(180, 21);
            this.cmbGenre.TabIndex = 78;
            // 
            // AddVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VideoRentalManagement.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1252, 729);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMovieId);
            this.Controls.Add(this.gridVideo);
            this.Controls.Add(this.dtpReleaseDate);
            this.Controls.Add(this.txtPlot);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtTitle);
            this.DoubleBuffered = true;
            this.Name = "AddVideo";
            this.Text = "AddVideo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMovieId;
        private System.Windows.Forms.DataGridView gridVideo;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbGenre;
    }
}