namespace QuanLyCafe
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAdmin_AccountManage = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAdmin_CustomerManage = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAdmin_StaffManage = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAdmin_ManuManage = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTab_ProductManage = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTab_StockManage = new System.Windows.Forms.ToolStripMenuItem();
            this.itemStab_OrderStab = new System.Windows.Forms.ToolStripMenuItem();
            this.itemChild_Order = new System.Windows.Forms.ToolStripMenuItem();
            this.itemChild_OrderManage = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.flpHomeBtn = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.itemTab_ProductManage,
            this.ItemTab_StockManage,
            this.itemStab_OrderStab,
            this.báoCaoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1258, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.adminToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(103, 27);
            this.adminToolStripMenuItem.Tag = "1";
            this.adminToolStripMenuItem.Text = "Trang chủ";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAdmin_AccountManage,
            this.itemAdmin_CustomerManage,
            this.itemAdmin_StaffManage,
            this.itemAdmin_ManuManage});
            this.thôngTinTàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.thôngTinTàiKhoảnToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(99, 27);
            this.thôngTinTàiKhoảnToolStripMenuItem.Tag = "2";
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Hệ thống";
            // 
            // itemAdmin_AccountManage
            // 
            this.itemAdmin_AccountManage.Name = "itemAdmin_AccountManage";
            this.itemAdmin_AccountManage.Size = new System.Drawing.Size(266, 28);
            this.itemAdmin_AccountManage.Text = "Quản lý tài khoản";
            this.itemAdmin_AccountManage.Click += new System.EventHandler(this.AccountManage_Click);
            // 
            // itemAdmin_CustomerManage
            // 
            this.itemAdmin_CustomerManage.Name = "itemAdmin_CustomerManage";
            this.itemAdmin_CustomerManage.Size = new System.Drawing.Size(266, 28);
            this.itemAdmin_CustomerManage.Text = "Quản lý khách hàng";
            this.itemAdmin_CustomerManage.Click += new System.EventHandler(this.CustomerManage_Click);
            // 
            // itemAdmin_StaffManage
            // 
            this.itemAdmin_StaffManage.Name = "itemAdmin_StaffManage";
            this.itemAdmin_StaffManage.Size = new System.Drawing.Size(266, 28);
            this.itemAdmin_StaffManage.Text = "Quản lý nhân viên";
            this.itemAdmin_StaffManage.Click += new System.EventHandler(this.StaffManage_Click);
            // 
            // itemAdmin_ManuManage
            // 
            this.itemAdmin_ManuManage.Name = "itemAdmin_ManuManage";
            this.itemAdmin_ManuManage.Size = new System.Drawing.Size(266, 28);
            this.itemAdmin_ManuManage.Text = "Quản lý nhà cung cấp";
            this.itemAdmin_ManuManage.Click += new System.EventHandler(this.ManuManage_Click);
            // 
            // itemTab_ProductManage
            // 
            this.itemTab_ProductManage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.itemTab_ProductManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.itemTab_ProductManage.Name = "itemTab_ProductManage";
            this.itemTab_ProductManage.Size = new System.Drawing.Size(167, 27);
            this.itemTab_ProductManage.Tag = "3";
            this.itemTab_ProductManage.Text = "Quản lý sản phẩm";
            this.itemTab_ProductManage.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.itemTab_ProductManage.Click += new System.EventHandler(this.ProductMange_Click);
            // 
            // ItemTab_StockManage
            // 
            this.ItemTab_StockManage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ItemTab_StockManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ItemTab_StockManage.Name = "ItemTab_StockManage";
            this.ItemTab_StockManage.Size = new System.Drawing.Size(175, 27);
            this.ItemTab_StockManage.Tag = "4";
            this.ItemTab_StockManage.Text = "Quản lý nhập hàng";
            this.ItemTab_StockManage.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // itemStab_OrderStab
            // 
            this.itemStab_OrderStab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemChild_Order,
            this.itemChild_OrderManage});
            this.itemStab_OrderStab.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.itemStab_OrderStab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.itemStab_OrderStab.Name = "itemStab_OrderStab";
            this.itemStab_OrderStab.Size = new System.Drawing.Size(156, 27);
            this.itemStab_OrderStab.Tag = "5";
            this.itemStab_OrderStab.Text = "Quản lý hóa đơn";
            // 
            // itemChild_Order
            // 
            this.itemChild_Order.Name = "itemChild_Order";
            this.itemChild_Order.Size = new System.Drawing.Size(246, 28);
            this.itemChild_Order.Text = "Lập hóa đơn";
            this.itemChild_Order.Click += new System.EventHandler(this.CreateOrder_Click);
            // 
            // itemChild_OrderManage
            // 
            this.itemChild_OrderManage.Name = "itemChild_OrderManage";
            this.itemChild_OrderManage.Size = new System.Drawing.Size(246, 28);
            this.itemChild_OrderManage.Text = "Danh sách hóa đơn";
            this.itemChild_OrderManage.Click += new System.EventHandler(this.OrderManage_Click);
            // 
            // báoCaoToolStripMenuItem
            // 
            this.báoCaoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.báoCaoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.báoCaoToolStripMenuItem.Name = "báoCaoToolStripMenuItem";
            this.báoCaoToolStripMenuItem.Size = new System.Drawing.Size(163, 27);
            this.báoCaoToolStripMenuItem.Tag = "6";
            this.báoCaoToolStripMenuItem.Text = "Báo cáo thống kê";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(132, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(85, 28);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.Location = new System.Drawing.Point(0, 3);
            this.btnUserInfo.MaximumSize = new System.Drawing.Size(150, 30);
            this.btnUserInfo.MinimumSize = new System.Drawing.Size(86, 28);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(117, 28);
            this.btnUserInfo.TabIndex = 7;
            this.btnUserInfo.Tag = "1";
            this.btnUserInfo.UseVisualStyleBackColor = true;
            // 
            // flpHomeBtn
            // 
            this.flpHomeBtn.Location = new System.Drawing.Point(44, 187);
            this.flpHomeBtn.Name = "flpHomeBtn";
            this.flpHomeBtn.Size = new System.Drawing.Size(977, 313);
            this.flpHomeBtn.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(41, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sky Coffee ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnUserInfo);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Location = new System.Drawing.Point(1038, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(220, 34);
            this.panel1.TabIndex = 11;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1258, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpHomeBtn);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRANG CHỦ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrangChu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrangChu_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TrangChu_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemAdmin_AccountManage;
        private System.Windows.Forms.ToolStripMenuItem itemAdmin_CustomerManage;
        private System.Windows.Forms.ToolStripMenuItem itemStab_OrderStab;
        private System.Windows.Forms.ToolStripMenuItem itemChild_Order;
        private System.Windows.Forms.ToolStripMenuItem itemChild_OrderManage;
        private System.Windows.Forms.ToolStripMenuItem itemTab_ProductManage;
        private System.Windows.Forms.ToolStripMenuItem ItemTab_StockManage;
        private System.Windows.Forms.ToolStripMenuItem báoCaoToolStripMenuItem;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnUserInfo;
        private System.Windows.Forms.FlowLayoutPanel flpHomeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem itemAdmin_StaffManage;
        private System.Windows.Forms.ToolStripMenuItem itemAdmin_ManuManage;
        private System.Windows.Forms.Panel panel1;
    }
}