namespace QuanLyCafe
{
    partial class BillManager
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
            this.components = new System.ComponentModel.Container();
            this.imgLargeIcon = new System.Windows.Forms.ImageList(this.components);
            this.imgSmallIcon = new System.Windows.Forms.ImageList(this.components);
            this.rd_today = new System.Windows.Forms.RadioButton();
            this.rd_day = new System.Windows.Forms.RadioButton();
            this.rd_month = new System.Windows.Forms.RadioButton();
            this.rd_year = new System.Windows.Forms.RadioButton();
            this.datgv_listOrder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpk_Find_time = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dtpk_Find_nglap = new System.Windows.Forms.DateTimePicker();
            this.col_mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nglap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbButton = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datgv_listOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgLargeIcon
            // 
            this.imgLargeIcon.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgLargeIcon.ImageSize = new System.Drawing.Size(45, 45);
            this.imgLargeIcon.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imgSmallIcon
            // 
            this.imgSmallIcon.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgSmallIcon.ImageSize = new System.Drawing.Size(70, 70);
            this.imgSmallIcon.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // rd_today
            // 
            this.rd_today.AutoSize = true;
            this.rd_today.Location = new System.Drawing.Point(1031, 161);
            this.rd_today.Name = "rd_today";
            this.rd_today.Size = new System.Drawing.Size(85, 21);
            this.rd_today.TabIndex = 25;
            this.rd_today.Text = "Hôm nay";
            this.rd_today.UseVisualStyleBackColor = true;
            this.rd_today.CheckedChanged += new System.EventHandler(this.rd_today_CheckedChanged_1);
            // 
            // rd_day
            // 
            this.rd_day.AutoSize = true;
            this.rd_day.Location = new System.Drawing.Point(852, 161);
            this.rd_day.Name = "rd_day";
            this.rd_day.Size = new System.Drawing.Size(97, 21);
            this.rd_day.TabIndex = 24;
            this.rd_day.Text = "Theo ngày";
            this.rd_day.UseVisualStyleBackColor = true;
            this.rd_day.CheckedChanged += new System.EventHandler(this.rd_day_CheckedChanged_1);
            // 
            // rd_month
            // 
            this.rd_month.AutoSize = true;
            this.rd_month.Location = new System.Drawing.Point(653, 161);
            this.rd_month.Name = "rd_month";
            this.rd_month.Size = new System.Drawing.Size(102, 21);
            this.rd_month.TabIndex = 23;
            this.rd_month.Text = "Theo tháng";
            this.rd_month.UseVisualStyleBackColor = true;
            this.rd_month.CheckedChanged += new System.EventHandler(this.rd_month_CheckedChanged_1);
            // 
            // rd_year
            // 
            this.rd_year.AutoSize = true;
            this.rd_year.Checked = true;
            this.rd_year.Location = new System.Drawing.Point(460, 161);
            this.rd_year.Name = "rd_year";
            this.rd_year.Size = new System.Drawing.Size(93, 21);
            this.rd_year.TabIndex = 22;
            this.rd_year.TabStop = true;
            this.rd_year.Text = "Theo năm";
            this.rd_year.UseVisualStyleBackColor = true;
            this.rd_year.CheckedChanged += new System.EventHandler(this.rd_year_CheckedChanged_1);
            // 
            // datgv_listOrder
            // 
            this.datgv_listOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.datgv_listOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datgv_listOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_mahd,
            this.col_customer,
            this.col_staff,
            this.col_ban,
            this.col_TT,
            this.col_nglap,
            this.tbButton});
            this.datgv_listOrder.Location = new System.Drawing.Point(12, 212);
            this.datgv_listOrder.Name = "datgv_listOrder";
            this.datgv_listOrder.RowHeadersWidth = 51;
            this.datgv_listOrder.RowTemplate.Height = 24;
            this.datgv_listOrder.Size = new System.Drawing.Size(1151, 382);
            this.datgv_listOrder.TabIndex = 21;
            this.datgv_listOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datgv_HD_CellClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "THE SKY COFFEE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 178);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpk_Find_time);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Dtpk_Find_nglap);
            this.panel1.Location = new System.Drawing.Point(430, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 57);
            this.panel1.TabIndex = 18;
            // 
            // dtpk_Find_time
            // 
            this.dtpk_Find_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpk_Find_time.Location = new System.Drawing.Point(487, 19);
            this.dtpk_Find_time.Name = "dtpk_Find_time";
            this.dtpk_Find_time.Size = new System.Drawing.Size(133, 22);
            this.dtpk_Find_time.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giờ lập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày lập:";
            // 
            // Dtpk_Find_nglap
            // 
            this.Dtpk_Find_nglap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtpk_Find_nglap.Location = new System.Drawing.Point(125, 18);
            this.Dtpk_Find_nglap.Name = "Dtpk_Find_nglap";
            this.Dtpk_Find_nglap.Size = new System.Drawing.Size(122, 22);
            this.Dtpk_Find_nglap.TabIndex = 0;
            // 
            // col_mahd
            // 
            this.col_mahd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_mahd.DataPropertyName = "Id";
            this.col_mahd.HeaderText = "Mã hóa đơn";
            this.col_mahd.MinimumWidth = 4;
            this.col_mahd.Name = "col_mahd";
            this.col_mahd.ReadOnly = true;
            this.col_mahd.Width = 112;
            // 
            // col_customer
            // 
            this.col_customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_customer.DataPropertyName = "CustomerName";
            this.col_customer.HeaderText = "Khách hàng";
            this.col_customer.MinimumWidth = 6;
            this.col_customer.Name = "col_customer";
            this.col_customer.ReadOnly = true;
            this.col_customer.Width = 150;
            // 
            // col_staff
            // 
            this.col_staff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_staff.DataPropertyName = "StaffName";
            this.col_staff.HeaderText = "Nhân viên lập";
            this.col_staff.MinimumWidth = 6;
            this.col_staff.Name = "col_staff";
            this.col_staff.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_staff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_staff.Width = 180;
            // 
            // col_ban
            // 
            this.col_ban.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_ban.DataPropertyName = "TableCode";
            this.col_ban.HeaderText = "Số bàn";
            this.col_ban.MinimumWidth = 6;
            this.col_ban.Name = "col_ban";
            this.col_ban.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_ban.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_ban.Width = 80;
            // 
            // col_TT
            // 
            this.col_TT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_TT.DataPropertyName = "TotalPrice";
            this.col_TT.HeaderText = "Tổng tiền";
            this.col_TT.MinimumWidth = 6;
            this.col_TT.Name = "col_TT";
            // 
            // col_nglap
            // 
            this.col_nglap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_nglap.DataPropertyName = "CreatedDate";
            this.col_nglap.FillWeight = 50F;
            this.col_nglap.HeaderText = "Ngày lập";
            this.col_nglap.MinimumWidth = 6;
            this.col_nglap.Name = "col_nglap";
            this.col_nglap.Width = 126;
            // 
            // tbButton
            // 
            this.tbButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tbButton.HeaderText = "Tùy chọn";
            this.tbButton.MinimumWidth = 6;
            this.tbButton.Name = "tbButton";
            this.tbButton.ReadOnly = true;
            this.tbButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // BillManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 602);
            this.Controls.Add(this.rd_today);
            this.Controls.Add(this.rd_day);
            this.Controls.Add(this.rd_month);
            this.Controls.Add(this.rd_year);
            this.Controls.Add(this.datgv_listOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "BillManager";
            this.Text = "QuanLyHoaDon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuanLyHoaDon_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.datgv_listOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imgSmallIcon;
        private System.Windows.Forms.ImageList imgLargeIcon;
        private System.Windows.Forms.RadioButton rd_today;
        private System.Windows.Forms.RadioButton rd_day;
        private System.Windows.Forms.RadioButton rd_month;
        private System.Windows.Forms.RadioButton rd_year;
        private System.Windows.Forms.DataGridView datgv_listOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpk_Find_time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dtpk_Find_nglap;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ban;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nglap;
        private System.Windows.Forms.DataGridViewImageColumn tbButton;
    }
}