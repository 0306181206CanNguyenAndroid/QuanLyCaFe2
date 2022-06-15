namespace QuanLyCafe
{
    partial class Order
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Loaibo = new System.Windows.Forms.Button();
            this.nbud_solgmua = new System.Windows.Forms.NumericUpDown();
            this.cb_Sanpham = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_TT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_LoaiSP = new System.Windows.Forms.ComboBox();
            this.tb_Gia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_Ban = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_mahd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_slmua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_sdtKHV = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nrud_Sales = new System.Windows.Forms.NumericUpDown();
            this.ckB_kh = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_dkKHV = new System.Windows.Forms.Button();
            this.tb_nv = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nbud_solgmua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrud_Sales)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.ControlLightLight;
            
            this.btn_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Navy;
            this.btn_Them.Location = new System.Drawing.Point(615, 127);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(71, 57);
            this.btn_Them.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_Them, "Thêm món");
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Loaibo
            // 
            this.btn_Loaibo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            
            this.btn_Loaibo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Loaibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Loaibo.ForeColor = System.Drawing.Color.Red;
            this.btn_Loaibo.Location = new System.Drawing.Point(709, 127);
            this.btn_Loaibo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_Loaibo.Name = "btn_Loaibo";
            this.btn_Loaibo.Size = new System.Drawing.Size(71, 57);
            this.btn_Loaibo.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_Loaibo, "Bỏ chọn");
            this.btn_Loaibo.UseVisualStyleBackColor = false;
            this.btn_Loaibo.Click += new System.EventHandler(this.btn_Loaibo_Click);
            // 
            // nbud_solgmua
            // 
            this.nbud_solgmua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbud_solgmua.Location = new System.Drawing.Point(444, 118);
            this.nbud_solgmua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nbud_solgmua.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbud_solgmua.Name = "nbud_solgmua";
            this.nbud_solgmua.Size = new System.Drawing.Size(105, 28);
            this.nbud_solgmua.TabIndex = 4;
            this.nbud_solgmua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nbud_solgmua.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cb_Sanpham
            // 
            this.cb_Sanpham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Sanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Sanpham.FormattingEnabled = true;
            this.cb_Sanpham.Location = new System.Drawing.Point(191, 179);
            this.cb_Sanpham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_Sanpham.Name = "cb_Sanpham";
            this.cb_Sanpham.Size = new System.Drawing.Size(234, 28);
            this.cb_Sanpham.TabIndex = 5;
            this.cb_Sanpham.SelectedIndexChanged += new System.EventHandler(this.cb_Sanpham_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(444, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(187, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sản phẩm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tổng tiền:";
            // 
            // tb_TT
            // 
            this.tb_TT.Enabled = false;
            this.tb_TT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TT.Location = new System.Drawing.Point(302, 469);
            this.tb_TT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_TT.Name = "tb_TT";
            this.tb_TT.ReadOnly = true;
            this.tb_TT.Size = new System.Drawing.Size(178, 30);
            this.tb_TT.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(441, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Giá: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(188, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Loại:";
            // 
            // cb_LoaiSP
            // 
            this.cb_LoaiSP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb_LoaiSP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_LoaiSP.DisplayMember = "none";
            this.cb_LoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_LoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_LoaiSP.FormattingEnabled = true;
            this.cb_LoaiSP.Items.AddRange(new object[] {
            "Trà Sữa",
            "Cà Phê",
            "Cooktail",
            "Sinh Tố",
            "Nước Ngọt",
            "Thức ăn nhanh",
            "Tea"});
            this.cb_LoaiSP.Location = new System.Drawing.Point(192, 118);
            this.cb_LoaiSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_LoaiSP.Name = "cb_LoaiSP";
            this.cb_LoaiSP.Size = new System.Drawing.Size(234, 28);
            this.cb_LoaiSP.TabIndex = 20;
            this.cb_LoaiSP.SelectedIndexChanged += new System.EventHandler(this.cb_LoaiSP_SelectedIndexChanged);
            // 
            // tb_Gia
            // 
            this.tb_Gia.Enabled = false;
            this.tb_Gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Gia.Location = new System.Drawing.Point(446, 180);
            this.tb_Gia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Gia.Name = "tb_Gia";
            this.tb_Gia.Size = new System.Drawing.Size(146, 27);
            this.tb_Gia.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(313, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 42);
            this.label7.TabIndex = 25;
            this.label7.Text = "Hóa đơn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Bàn:";
            // 
            // cb_Ban
            // 
            this.cb_Ban.FormattingEnabled = true;
            this.cb_Ban.Location = new System.Drawing.Point(12, 180);
            this.cb_Ban.Name = "cb_Ban";
            this.cb_Ban.Size = new System.Drawing.Size(139, 26);
            this.cb_Ban.TabIndex = 27;
            this.cb_Ban.SelectedIndexChanged += new System.EventHandler(this.cb_Ban_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(8, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "Nhân viên lập:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "Mã hóa đơn:";
            // 
            // tb_mahd
            // 
            this.tb_mahd.Enabled = false;
            this.tb_mahd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mahd.Location = new System.Drawing.Point(12, 120);
            this.tb_mahd.Name = "tb_mahd";
            this.tb_mahd.Size = new System.Drawing.Size(139, 26);
            this.tb_mahd.TabIndex = 31;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_sp,
            this.col_slmua,
            this.col_giaban});
            this.dataGridView1.Location = new System.Drawing.Point(191, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(601, 234);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // col_sp
            // 
            this.col_sp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_sp.DataPropertyName = "tensp";
            this.col_sp.HeaderText = "Tên món";
            this.col_sp.Name = "col_sp";
            this.col_sp.ReadOnly = true;
            // 
            // col_slmua
            // 
            this.col_slmua.DataPropertyName = "slmua";
            this.col_slmua.HeaderText = "Số lượng mua";
            this.col_slmua.Name = "col_slmua";
            this.col_slmua.ReadOnly = true;
            // 
            // col_giaban
            // 
            this.col_giaban.DataPropertyName = "giaban";
            this.col_giaban.HeaderText = "Giá bán";
            this.col_giaban.Name = "col_giaban";
            this.col_giaban.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_sdtKHV);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.nrud_Sales);
            this.panel1.Controls.Add(this.ckB_kh);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bt_dkKHV);
            this.panel1.Location = new System.Drawing.Point(6, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 219);
            this.panel1.TabIndex = 38;
            // 
            // cb_sdtKHV
            // 
            this.cb_sdtKHV.FormattingEnabled = true;
            this.cb_sdtKHV.Location = new System.Drawing.Point(14, 91);
            this.cb_sdtKHV.Name = "cb_sdtKHV";
            this.cb_sdtKHV.Size = new System.Drawing.Size(131, 26);
            this.cb_sdtKHV.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 22);
            this.label11.TabIndex = 39;
            this.label11.Text = "SĐT:";
            // 
            // nrud_Sales
            // 
            this.nrud_Sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrud_Sales.Location = new System.Drawing.Point(97, 133);
            this.nrud_Sales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nrud_Sales.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nrud_Sales.Name = "nrud_Sales";
            this.nrud_Sales.Size = new System.Drawing.Size(48, 28);
            this.nrud_Sales.TabIndex = 41;
            this.nrud_Sales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nrud_Sales.ValueChanged += new System.EventHandler(this.nrud_Sales_ValueChanged);
            // 
            // ckB_kh
            // 
            this.ckB_kh.AutoSize = true;
            this.ckB_kh.Checked = true;
            this.ckB_kh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckB_kh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckB_kh.Location = new System.Drawing.Point(15, 14);
            this.ckB_kh.Name = "ckB_kh";
            this.ckB_kh.Size = new System.Drawing.Size(128, 28);
            this.ckB_kh.TabIndex = 40;
            this.ckB_kh.Text = "Khách Vip";
            this.ckB_kh.UseVisualStyleBackColor = true;
            this.ckB_kh.CheckedChanged += new System.EventHandler(this.ckB_kh_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Sales(%)";
            // 
            // bt_dkKHV
            // 
            this.bt_dkKHV.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.bt_dkKHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dkKHV.ForeColor = System.Drawing.Color.Red;
            this.bt_dkKHV.Location = new System.Drawing.Point(12, 167);
            this.bt_dkKHV.Name = "bt_dkKHV";
            this.bt_dkKHV.Size = new System.Drawing.Size(133, 48);
            this.bt_dkKHV.TabIndex = 38;
            this.bt_dkKHV.Text = "Đăng ký Vip";
            this.bt_dkKHV.UseVisualStyleBackColor = false;
            this.bt_dkKHV.Click += new System.EventHandler(this.bt_dkKHV_Click);
            // 
            // tb_nv
            // 
            this.tb_nv.Enabled = false;
            this.tb_nv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nv.Location = new System.Drawing.Point(12, 245);
            this.tb_nv.Name = "tb_nv";
            this.tb_nv.Size = new System.Drawing.Size(139, 26);
            this.tb_nv.TabIndex = 39;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Reset.Location = new System.Drawing.Point(655, 455);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(57, 57);
            this.btn_Reset.TabIndex = 40;
            this.toolTip1.SetToolTip(this.btn_Reset, "ReLoad");
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.Snow;
            this.btn_create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.Color.Maroon;
            this.btn_create.Location = new System.Drawing.Point(496, 455);
            this.btn_create.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(66, 57);
            this.btn_create.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btn_create, "Lập hóa đơn thanh toán");
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(724, 455);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(68, 57);
            this.btn_Close.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btn_Close, "Thoát");
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_del.Location = new System.Drawing.Point(576, 455);
            this.btn_del.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(63, 57);
            this.btn_del.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btn_del, "Xóa hóa đơn");
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 518);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.tb_nv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_mahd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_Ban);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_Gia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_LoaiSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_TT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Sanpham);
            this.Controls.Add(this.nbud_solgmua);
            this.Controls.Add(this.btn_Loaibo);
            this.Controls.Add(this.btn_Them);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(825, 565);
            this.MinimumSize = new System.Drawing.Size(825, 565);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.nbud_solgmua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrud_Sales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Loaibo;
        private System.Windows.Forms.NumericUpDown nbud_solgmua;
        private System.Windows.Forms.ComboBox cb_Sanpham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_TT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_LoaiSP;
        private System.Windows.Forms.TextBox tb_Gia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_Ban;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_mahd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_slmua;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_giaban;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_sdtKHV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nrud_Sales;
        private System.Windows.Forms.CheckBox ckB_kh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_dkKHV;
        private System.Windows.Forms.TextBox tb_nv;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_Reset;
    }
}