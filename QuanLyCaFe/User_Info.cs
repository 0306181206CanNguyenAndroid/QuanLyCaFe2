using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using BUS.BusinessObject;
using DTO;
using DTO.Models;

namespace QuanLyCafe
{
    public partial class ThongTinCaNhan : Form
    {
        //Khai báo một biến "chứa thông tin tài khoản" => biến kiểu AccountDTO
        //public AccountDTO thongTinTaiKhoan = new AccountDTO();
        //public NhanVienDTO thongTinNhanVien = new NhanVienDTO();
        public ThongTinCaNhan(UserModel taiKhoan,SystemStaffModel nv) //Khi mở cửa sổ cần truyền vào là tài khoản đang đăng nhập và  nhân viên
        {
            InitializeComponent();
            //Gán taiKhoan cho biến thongTinTaiKhoan
            //thongTinTaiKhoan = taiKhoan;
            //thongTinNhanVien = nv;
            HienThongTin();
            
        }

        //Hàm hiện các thông tin của tài khoản lên giao diện
        public void HienThongTin()
        {
            //Gán dữ liệu cho textBox mà mình tạo trên form
            /* Ví dụ tạo có 1 textBox tên là txt_TenDangNhap
             
            Cú pháp gán
             txt_TenDangNhap.Text = thongTinTaiKhoan.userName; 
             
             */
            //txt_TenDangNhap.Text = thongTinTaiKhoan.userName;
            //txt1.Text = thongTinTaiKhoan.nickName;
            //txt2.Text = thongTinTaiKhoan.Quyen;
            //txt3.Text = thongTinNhanVien.tenNV;
        }





        //Khai báo các BUS kết nối với cơ sở dữ liệu
        List<SystemStaffModel> dsnv = new List<SystemStaffModel>();
        //SystemStaff

        //Sự kiện sửa tên đại diện của tài khoản
        private void btn_SuaTen_Click(object sender, EventArgs e)
        {
            
            //Lấy thông tin trên textBox

            //Kiểm tra xem nó có dữ liệu hay ko

            //nếu có thì Xây dựng 1 hàm update vào SQL Server


        }

        //Đóng form lại
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
