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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_nvl = new System.Windows.Forms.TextBox();
            this.tb_ngayLap = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_TT = new System.Windows.Forms.TextBox();
            this.ckb_khv = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_tenkh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_mahd = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_Xem = new System.Windows.Forms.Button();
            this.rd_today = new System.Windows.Forms.RadioButton();
            this.rd_day = new System.Windows.Forms.RadioButton();
            this.rd_month = new System.Windows.Forms.RadioButton();
            this.rd_year = new System.Windows.Forms.RadioButton();
            this.datgv_HD = new System.Windows.Forms.DataGridView();
            this.col_mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nv = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_ban = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nglap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpk_Find_time = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dtpk_Find_nglap = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datgv_HD)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Reset);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tb_nvl);
            this.groupBox1.Controls.Add(this.tb_ngayLap);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tb_TT);
            this.groupBox1.Controls.Add(this.ckb_khv);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tb_sdt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tb_tenkh);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_mahd);
            this.groupBox1.Controls.Add(this.btn_exit);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_Xem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(805, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 566);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hóa đơn";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(34, 411);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(70, 62);
            this.btn_Reset.TabIndex = 29;
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 284);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "NV_Lập:";
            // 
            // tb_nvl
            // 
            this.tb_nvl.Location = new System.Drawing.Point(170, 281);
            this.tb_nvl.Name = "tb_nvl";
            this.tb_nvl.Size = new System.Drawing.Size(205, 27);
            this.tb_nvl.TabIndex = 27;
            // 
            // tb_ngayLap
            // 
            this.tb_ngayLap.Location = new System.Drawing.Point(170, 232);
            this.tb_ngayLap.Name = "tb_ngayLap";
            this.tb_ngayLap.Size = new System.Drawing.Size(205, 27);
            this.tb_ngayLap.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Ngày lập:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 337);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Tổng tiền:";
            // 
            // tb_TT
            // 
            this.tb_TT.Location = new System.Drawing.Point(170, 337);
            this.tb_TT.Name = "tb_TT";
            this.tb_TT.Size = new System.Drawing.Size(156, 27);
            this.tb_TT.TabIndex = 23;
            // 
            // ckb_khv
            // 
            this.ckb_khv.AutoSize = true;
            this.ckb_khv.Enabled = false;
            this.ckb_khv.Location = new System.Drawing.Point(34, 143);
            this.ckb_khv.Name = "ckb_khv";
            this.ckb_khv.Size = new System.Drawing.Size(178, 24);
            this.ckb_khv.TabIndex = 22;
            this.ckb_khv.Text = "Có thẻ thành viên";
            this.ckb_khv.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "SĐT:";
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(170, 184);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(156, 27);
            this.tb_sdt.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Khách hàng:";
            // 
            // tb_tenkh
            // 
            this.tb_tenkh.Location = new System.Drawing.Point(170, 99);
            this.tb_tenkh.Name = "tb_tenkh";
            this.tb_tenkh.Size = new System.Drawing.Size(205, 27);
            this.tb_tenkh.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Hóa đơn:";
            // 
            // tb_mahd
            // 
            this.tb_mahd.Location = new System.Drawing.Point(170, 48);
            this.tb_mahd.Name = "tb_mahd";
            this.tb_mahd.ReadOnly = true;
            this.tb_mahd.Size = new System.Drawing.Size(205, 27);
            this.tb_mahd.TabIndex = 16;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(34, 497);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(121, 29);
            this.btn_exit.TabIndex = 14;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click_1);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(237, 497);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(121, 29);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click_1);
            // 
            // btn_Xem
            // 
            this.btn_Xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xem.Location = new System.Drawing.Point(237, 411);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Size = new System.Drawing.Size(121, 29);
            this.btn_Xem.TabIndex = 8;
            this.btn_Xem.Text = "Chi tiết";
            this.btn_Xem.UseVisualStyleBackColor = true;
            this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click_1);
            // 
            // rd_today
            // 
            this.rd_today.AutoSize = true;
            this.rd_today.Location = new System.Drawing.Point(679, 148);
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
            this.rd_day.Location = new System.Drawing.Point(442, 148);
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
            this.rd_month.Location = new System.Drawing.Point(228, 148);
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
            this.rd_year.Location = new System.Drawing.Point(46, 148);
            this.rd_year.Name = "rd_year";
            this.rd_year.Size = new System.Drawing.Size(93, 21);
            this.rd_year.TabIndex = 22;
            this.rd_year.TabStop = true;
            this.rd_year.Text = "Theo năm";
            this.rd_year.UseVisualStyleBackColor = true;
            this.rd_year.CheckedChanged += new System.EventHandler(this.rd_year_CheckedChanged_1);
            // 
            // datgv_HD
            // 
            this.datgv_HD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.datgv_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datgv_HD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_mahd,
            this.col_makh,
            this.col_nv,
            this.col_ban,
            this.col_TT,
            this.col_nglap});
            this.datgv_HD.Location = new System.Drawing.Point(12, 212);
            this.datgv_HD.Name = "datgv_HD";
            this.datgv_HD.RowHeadersWidth = 51;
            this.datgv_HD.RowTemplate.Height = 24;
            this.datgv_HD.Size = new System.Drawing.Size(774, 382);
            this.datgv_HD.TabIndex = 21;
            this.datgv_HD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datgv_HD_CellClick_1);
            // 
            // col_mahd
            // 
            this.col_mahd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_mahd.DataPropertyName = "maHD";
            this.col_mahd.HeaderText = "Mã hóa đơn";
            this.col_mahd.MinimumWidth = 6;
            this.col_mahd.Name = "col_mahd";
            this.col_mahd.ReadOnly = true;
            this.col_mahd.Width = 112;
            // 
            // col_makh
            // 
            this.col_makh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_makh.DataPropertyName = "maKH";
            this.col_makh.HeaderText = "Khách hàng";
            this.col_makh.MinimumWidth = 6;
            this.col_makh.Name = "col_makh";
            this.col_makh.Width = 104;
            // 
            // col_nv
            // 
            this.col_nv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_nv.DataPropertyName = "maNV";
            this.col_nv.HeaderText = "Nhân viên lập";
            this.col_nv.MinimumWidth = 6;
            this.col_nv.Name = "col_nv";
            this.col_nv.Width = 80;
            // 
            // col_ban
            // 
            this.col_ban.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_ban.DataPropertyName = "maBan";
            this.col_ban.HeaderText = "Số bàn";
            this.col_ban.MinimumWidth = 6;
            this.col_ban.Name = "col_ban";
            this.col_ban.Width = 80;
            // 
            // col_TT
            // 
            this.col_TT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_TT.DataPropertyName = "tongThanhToan";
            this.col_TT.HeaderText = "Tổng tiền";
            this.col_TT.MinimumWidth = 6;
            this.col_TT.Name = "col_TT";
            this.col_TT.Width = 90;
            // 
            // col_nglap
            // 
            this.col_nglap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_nglap.DataPropertyName = "ngayLap";
            this.col_nglap.HeaderText = "Ngày lập";
            this.col_nglap.MinimumWidth = 6;
            this.col_nglap.Name = "col_nglap";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 45);
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
            this.pictureBox1.Size = new System.Drawing.Size(169, 114);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpk_Find_time);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Dtpk_Find_nglap);
            this.panel1.Location = new System.Drawing.Point(187, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 57);
            this.panel1.TabIndex = 18;
            // 
            // dtpk_Find_time
            // 
            this.dtpk_Find_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpk_Find_time.Location = new System.Drawing.Point(405, 18);
            this.dtpk_Find_time.Name = "dtpk_Find_time";
            this.dtpk_Find_time.Size = new System.Drawing.Size(133, 22);
            this.dtpk_Find_time.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 19);
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
            // BillManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 602);
            this.Controls.Add(this.rd_today);
            this.Controls.Add(this.rd_day);
            this.Controls.Add(this.rd_month);
            this.Controls.Add(this.rd_year);
            this.Controls.Add(this.datgv_HD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "BillManager";
            this.Text = "QuanLyHoaDon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuanLyHoaDon_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datgv_HD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imgSmallIcon;
        private System.Windows.Forms.ImageList imgLargeIcon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_nvl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_TT;
        private System.Windows.Forms.CheckBox ckb_khv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_tenkh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_mahd;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_Xem;
        private System.Windows.Forms.RadioButton rd_today;
        private System.Windows.Forms.RadioButton rd_day;
        private System.Windows.Forms.RadioButton rd_month;
        private System.Windows.Forms.RadioButton rd_year;
        private System.Windows.Forms.DataGridView datgv_HD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_makh;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_nv;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_ban;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nglap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpk_Find_time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dtpk_Find_nglap;
        private System.Windows.Forms.TextBox tb_ngayLap;
    }
}