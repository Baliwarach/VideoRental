namespace VideoRental
{
    partial class CustomerList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridMostBorrowList = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMostBorrowList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.gridMostBorrowList);
            this.panel1.Location = new System.Drawing.Point(221, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 450);
            this.panel1.TabIndex = 64;
            // 
            // gridMostBorrowList
            // 
            this.gridMostBorrowList.AllowUserToAddRows = false;
            this.gridMostBorrowList.AllowUserToDeleteRows = false;
            this.gridMostBorrowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMostBorrowList.Location = new System.Drawing.Point(30, 23);
            this.gridMostBorrowList.Name = "gridMostBorrowList";
            this.gridMostBorrowList.ReadOnly = true;
            this.gridMostBorrowList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMostBorrowList.Size = new System.Drawing.Size(665, 399);
            this.gridMostBorrowList.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(291, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(515, 46);
            this.label5.TabIndex = 65;
            this.label5.Text = "Most Rental Customer List";
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
            this.btn_close.Size = new System.Drawing.Size(119, 39);
            this.btn_close.TabIndex = 77;
            this.btn_close.Text = "<<Back";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // CustomerList
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
            this.Name = "CustomerList";
            this.Text = "RegularCustomer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RegularCustomer_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMostBorrowList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridMostBorrowList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_close;
    }
}