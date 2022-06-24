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
            this.btn_Order = new System.Windows.Forms.Button();
            this.btn_correct = new System.Windows.Forms.Button();
            this.nbud_quantity = new System.Windows.Forms.NumericUpDown();
            this.cb_product = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_TotalPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_ProductType = new System.Windows.Forms.ComboBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_Table = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_BillCode = new System.Windows.Forms.TextBox();
            this.dtgv_listOrder = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_slmua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_addNewCustomer = new System.Windows.Forms.Button();
            this.tb_Staff = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nrud_Sales = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ckb_OrderFrom = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nbud_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_listOrder)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrud_Sales)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Order
            // 
            this.btn_Order.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Order.BackgroundImage = global::QuanLyCafe.Properties.Resources.btnAdd;
            this.btn_Order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Order.ForeColor = System.Drawing.Color.Navy;
            this.btn_Order.Location = new System.Drawing.Point(647, 158);
            this.btn_Order.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(56, 50);
            this.btn_Order.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_Order, "Thêm món");
            this.btn_Order.UseVisualStyleBackColor = false;
            this.btn_Order.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_correct
            // 
            this.btn_correct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_correct.BackgroundImage = global::QuanLyCafe.Properties.Resources.icon_del3;
            this.btn_correct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_correct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_correct.ForeColor = System.Drawing.Color.Red;
            this.btn_correct.Location = new System.Drawing.Point(736, 159);
            this.btn_correct.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_correct.Name = "btn_correct";
            this.btn_correct.Size = new System.Drawing.Size(56, 48);
            this.btn_correct.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_correct, "Bỏ chọn");
            this.btn_correct.UseVisualStyleBackColor = false;
            this.btn_correct.Click += new System.EventHandler(this.btn_Loaibo_Click);
            // 
            // nbud_quantity
            // 
            this.nbud_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbud_quantity.Location = new System.Drawing.Point(444, 118);
            this.nbud_quantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nbud_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbud_quantity.Name = "nbud_quantity";
            this.nbud_quantity.Size = new System.Drawing.Size(105, 28);
            this.nbud_quantity.TabIndex = 4;
            this.nbud_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nbud_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cb_product
            // 
            this.cb_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_product.FormattingEnabled = true;
            this.cb_product.Location = new System.Drawing.Point(191, 179);
            this.cb_product.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_product.Name = "cb_product";
            this.cb_product.Size = new System.Drawing.Size(179, 28);
            this.cb_product.TabIndex = 5;
            this.cb_product.SelectedIndexChanged += new System.EventHandler(this.cb_Sanpham_SelectedIndexChanged);
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
            // tb_TotalPrice
            // 
            this.tb_TotalPrice.Enabled = false;
            this.tb_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TotalPrice.Location = new System.Drawing.Point(302, 469);
            this.tb_TotalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_TotalPrice.Name = "tb_TotalPrice";
            this.tb_TotalPrice.ReadOnly = true;
            this.tb_TotalPrice.Size = new System.Drawing.Size(178, 30);
            this.tb_TotalPrice.TabIndex = 17;
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
            // cb_ProductType
            // 
            this.cb_ProductType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb_ProductType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_ProductType.DisplayMember = "none";
            this.cb_ProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ProductType.FormattingEnabled = true;
            this.cb_ProductType.Items.AddRange(new object[] {
            "Trà Sữa",
            "Cà Phê",
            "Cooktail",
            "Sinh Tố",
            "Nước Ngọt",
            "Thức ăn nhanh",
            "Tea"});
            this.cb_ProductType.Location = new System.Drawing.Point(192, 118);
            this.cb_ProductType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_ProductType.Name = "cb_ProductType";
            this.cb_ProductType.Size = new System.Drawing.Size(178, 28);
            this.cb_ProductType.TabIndex = 20;
            this.cb_ProductType.SelectedIndexChanged += new System.EventHandler(this.cb_LoaiSP_SelectedIndexChanged);
            // 
            // tb_Price
            // 
            this.tb_Price.Enabled = false;
            this.tb_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(446, 180);
            this.tb_Price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(146, 27);
            this.tb_Price.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 20);
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
            // cb_Table
            // 
            this.cb_Table.FormattingEnabled = true;
            this.cb_Table.Location = new System.Drawing.Point(12, 180);
            this.cb_Table.Name = "cb_Table";
            this.cb_Table.Size = new System.Drawing.Size(139, 26);
            this.cb_Table.TabIndex = 27;
            this.cb_Table.SelectedIndexChanged += new System.EventHandler(this.cb_Ban_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(8, 219);
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
            this.label10.Location = new System.Drawing.Point(7, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "Mã hóa đơn:";
            // 
            // tb_BillCode
            // 
            this.tb_BillCode.Enabled = false;
            this.tb_BillCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_BillCode.Location = new System.Drawing.Point(13, 120);
            this.tb_BillCode.Name = "tb_BillCode";
            this.tb_BillCode.Size = new System.Drawing.Size(139, 26);
            this.tb_BillCode.TabIndex = 31;
            // 
            // dtgv_listOrder
            // 
            this.dtgv_listOrder.AllowUserToAddRows = false;
            this.dtgv_listOrder.AllowUserToDeleteRows = false;
            this.dtgv_listOrder.AllowUserToOrderColumns = true;
            this.dtgv_listOrder.AllowUserToResizeColumns = false;
            this.dtgv_listOrder.AllowUserToResizeRows = false;
            this.dtgv_listOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_listOrder.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_listOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_listOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.col_sp,
            this.col_slmua,
            this.col_giaban});
            this.dtgv_listOrder.Location = new System.Drawing.Point(191, 217);
            this.dtgv_listOrder.Name = "dtgv_listOrder";
            this.dtgv_listOrder.RowHeadersWidth = 51;
            this.dtgv_listOrder.RowTemplate.Height = 24;
            this.dtgv_listOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_listOrder.Size = new System.Drawing.Size(601, 234);
            this.dtgv_listOrder.TabIndex = 35;
            this.dtgv_listOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_listOrder_CellClick);
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
            // col_sp
            // 
            this.col_sp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_sp.DataPropertyName = "Name";
            this.col_sp.HeaderText = "Tên món";
            this.col_sp.MinimumWidth = 6;
            this.col_sp.Name = "col_sp";
            this.col_sp.ReadOnly = true;
            // 
            // col_slmua
            // 
            this.col_slmua.DataPropertyName = "Quantity";
            this.col_slmua.HeaderText = "Số lượng mua";
            this.col_slmua.MinimumWidth = 6;
            this.col_slmua.Name = "col_slmua";
            this.col_slmua.ReadOnly = true;
            // 
            // col_giaban
            // 
            this.col_giaban.DataPropertyName = "RealPrice";
            this.col_giaban.HeaderText = "Giá bán";
            this.col_giaban.MinimumWidth = 6;
            this.col_giaban.Name = "col_giaban";
            this.col_giaban.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckb_OrderFrom);
            this.panel1.Controls.Add(this.bt_addNewCustomer);
            this.panel1.Location = new System.Drawing.Point(12, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 111);
            this.panel1.TabIndex = 38;
            // 
            // bt_addNewCustomer
            // 
            this.bt_addNewCustomer.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.bt_addNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_addNewCustomer.ForeColor = System.Drawing.Color.Red;
            this.bt_addNewCustomer.Location = new System.Drawing.Point(9, 49);
            this.bt_addNewCustomer.Name = "bt_addNewCustomer";
            this.bt_addNewCustomer.Size = new System.Drawing.Size(133, 48);
            this.bt_addNewCustomer.TabIndex = 38;
            this.bt_addNewCustomer.Text = "Đăng ký Vip";
            this.bt_addNewCustomer.UseVisualStyleBackColor = false;
            this.bt_addNewCustomer.Click += new System.EventHandler(this.bt_dkKHV_Click);
            // 
            // tb_Staff
            // 
            this.tb_Staff.Enabled = false;
            this.tb_Staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Staff.Location = new System.Drawing.Point(13, 258);
            this.tb_Staff.Name = "tb_Staff";
            this.tb_Staff.Size = new System.Drawing.Size(139, 26);
            this.tb_Staff.TabIndex = 39;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Reset.BackgroundImage = global::QuanLyCafe.Properties.Resources.iconReset;
            this.btn_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Reset.Location = new System.Drawing.Point(658, 455);
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
            this.btn_create.BackgroundImage = global::QuanLyCafe.Properties.Resources.btnBilled;
            this.btn_create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.Color.Maroon;
            this.btn_create.Location = new System.Drawing.Point(496, 455);
            this.btn_create.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(66, 57);
            this.btn_create.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btn_create, "Thanh toán");
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Close.BackgroundImage = global::QuanLyCafe.Properties.Resources.icon_off2;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(735, 455);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(57, 57);
            this.btn_Close.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btn_Close, "Thoát");
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_del.BackgroundImage = global::QuanLyCafe.Properties.Resources.btnDel;
            this.btn_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_del.Location = new System.Drawing.Point(578, 455);
            this.btn_del.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(63, 57);
            this.btn_del.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btn_del, "Xóa hóa đơn");
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(615, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 26);
            this.textBox1.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(444, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 25);
            this.label12.TabIndex = 41;
            this.label12.Text = "Tìm kiếm:";
            // 
            // nrud_Sales
            // 
            this.nrud_Sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrud_Sales.Location = new System.Drawing.Point(16, 330);
            this.nrud_Sales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nrud_Sales.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nrud_Sales.Name = "nrud_Sales";
            this.nrud_Sales.Size = new System.Drawing.Size(130, 28);
            this.nrud_Sales.TabIndex = 44;
            this.nrud_Sales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 43;
            this.label3.Text = "Sales(%)";
            // 
            // ckb_OrderFrom
            // 
            this.ckb_OrderFrom.AutoCheck = false;
            this.ckb_OrderFrom.AutoSize = true;
            this.ckb_OrderFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_OrderFrom.Location = new System.Drawing.Point(9, 10);
            this.ckb_OrderFrom.Name = "ckb_OrderFrom";
            this.ckb_OrderFrom.Size = new System.Drawing.Size(139, 33);
            this.ckb_OrderFrom.TabIndex = 39;
            this.ckb_OrderFrom.Text = "Đặt trước";
            this.ckb_OrderFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckb_OrderFrom.UseVisualStyleBackColor = true;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 518);
            this.Controls.Add(this.nrud_Sales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.tb_Staff);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgv_listOrder);
            this.Controls.Add(this.tb_BillCode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_Table);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_Price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_ProductType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_TotalPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_product);
            this.Controls.Add(this.nbud_quantity);
            this.Controls.Add(this.btn_correct);
            this.Controls.Add(this.btn_Order);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(825, 565);
            this.MinimumSize = new System.Drawing.Size(825, 565);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Order";
            this.toolTip1.SetToolTip(this, "Thêm món");
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbud_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_listOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrud_Sales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Button btn_correct;
        private System.Windows.Forms.NumericUpDown nbud_quantity;
        private System.Windows.Forms.ComboBox cb_product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_TotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_ProductType;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_Table;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_BillCode;
        private System.Windows.Forms.DataGridView dtgv_listOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_addNewCustomer;
        private System.Windows.Forms.TextBox tb_Staff;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_slmua;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_giaban;
        private System.Windows.Forms.CheckBox ckb_OrderFrom;
        private System.Windows.Forms.NumericUpDown nrud_Sales;
        private System.Windows.Forms.Label label3;
    }
}