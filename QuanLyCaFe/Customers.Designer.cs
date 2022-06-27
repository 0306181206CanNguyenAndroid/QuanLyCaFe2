namespace QuanLyCafe
{
    partial class Customers
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
            this.dtgv_listCustomer = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_dk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date_birth = new System.Windows.Forms.DateTimePicker();
            this.tb_tenkh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_listCustomer)).BeginInit();
            this.groupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.point)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_listCustomer
            // 
            this.dtgv_listCustomer.AllowUserToAddRows = false;
            this.dtgv_listCustomer.AllowUserToDeleteRows = false;
            this.dtgv_listCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_listCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_listCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CustomerCode,
            this.col_kh,
            this.col_sdt,
            this.Address,
            this.col_Point});
            this.dtgv_listCustomer.Location = new System.Drawing.Point(439, 61);
            this.dtgv_listCustomer.Name = "dtgv_listCustomer";
            this.dtgv_listCustomer.ReadOnly = true;
            this.dtgv_listCustomer.RowHeadersWidth = 51;
            this.dtgv_listCustomer.RowTemplate.Height = 24;
            this.dtgv_listCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_listCustomer.Size = new System.Drawing.Size(775, 470);
            this.dtgv_listCustomer.TabIndex = 0;
            this.dtgv_listCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ttkh_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // CustomerCode
            // 
            this.CustomerCode.DataPropertyName = "Code";
            this.CustomerCode.HeaderText = "Mã khách hàng";
            this.CustomerCode.MinimumWidth = 6;
            this.CustomerCode.Name = "CustomerCode";
            this.CustomerCode.ReadOnly = true;
            // 
            // col_kh
            // 
            this.col_kh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_kh.DataPropertyName = "Name";
            this.col_kh.HeaderText = "Tên khách hàng";
            this.col_kh.MinimumWidth = 6;
            this.col_kh.Name = "col_kh";
            this.col_kh.ReadOnly = true;
            // 
            // col_sdt
            // 
            this.col_sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_sdt.DataPropertyName = "Phone";
            this.col_sdt.HeaderText = "Số điện thoại";
            this.col_sdt.MinimumWidth = 6;
            this.col_sdt.Name = "col_sdt";
            this.col_sdt.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa chỉ";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // col_Point
            // 
            this.col_Point.DataPropertyName = "Point";
            this.col_Point.HeaderText = "Điểm ưu đãi";
            this.col_Point.MinimumWidth = 6;
            this.col_Point.Name = "col_Point";
            this.col_Point.ReadOnly = true;
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.point);
            this.groupbox1.Controls.Add(this.tb_tenkh);
            this.groupbox1.Controls.Add(this.label1);
            this.groupbox1.Controls.Add(this.date_birth);
            this.groupbox1.Controls.Add(this.txt_diachi);
            this.groupbox1.Controls.Add(this.label6);
            this.groupbox1.Controls.Add(this.label5);
            this.groupbox1.Controls.Add(this.btn_exit);
            this.groupbox1.Controls.Add(this.btn_del);
            this.groupbox1.Controls.Add(this.btn_update);
            this.groupbox1.Controls.Add(this.btn_dk);
            this.groupbox1.Controls.Add(this.label3);
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Controls.Add(this.tb_sdt);
            this.groupbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox1.ForeColor = System.Drawing.Color.LightSalmon;
            this.groupbox1.Location = new System.Drawing.Point(24, 169);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(408, 372);
            this.groupbox1.TabIndex = 1;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Chi tiết khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Năm sinh:";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_exit.Location = new System.Drawing.Point(258, 318);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(135, 42);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_del.ForeColor = System.Drawing.Color.Red;
            this.btn_del.Location = new System.Drawing.Point(13, 318);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(135, 42);
            this.btn_del.TabIndex = 9;
            this.btn_del.Text = "Xoá";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_update.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_update.Location = new System.Drawing.Point(258, 269);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(135, 42);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_dk
            // 
            this.btn_dk.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_dk.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_dk.Location = new System.Drawing.Point(13, 269);
            this.btn_dk.Name = "btn_dk";
            this.btn_dk.Size = new System.Drawing.Size(135, 42);
            this.btn_dk.TabIndex = 7;
            this.btn_dk.Text = "Đăng ký";
            this.btn_dk.UseVisualStyleBackColor = false;
            this.btn_dk.Click += new System.EventHandler(this.btn_dk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Điểm ưu đãi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số điện thoại:";
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(209, 190);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(190, 30);
            this.tb_sdt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(432, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 134);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(163, 143);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(235, 30);
            this.txt_diachi.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Địa chỉ:";
            // 
            // date_birth
            // 
            this.date_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_birth.Location = new System.Drawing.Point(167, 96);
            this.date_birth.Name = "date_birth";
            this.date_birth.Size = new System.Drawing.Size(231, 30);
            this.date_birth.TabIndex = 15;
            // 
            // tb_tenkh
            // 
            this.tb_tenkh.Location = new System.Drawing.Point(209, 47);
            this.tb_tenkh.Name = "tb_tenkh";
            this.tb_tenkh.Size = new System.Drawing.Size(190, 30);
            this.tb_tenkh.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Khách hàng:";
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(279, 229);
            this.point.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(120, 30);
            this.point.TabIndex = 18;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1226, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.dtgv_listCustomer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Customers";
            this.Text = "Quản lý khách hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Customers_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_listCustomer)).EndInit();
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.point)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_listCustomer;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_dk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Point;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_tenkh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_birth;
        private System.Windows.Forms.NumericUpDown point;
    }
}