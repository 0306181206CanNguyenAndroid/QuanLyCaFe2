using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThiMini
{
    public static class constans
    {
        public static string conectionString = "";
        public static string path_picture = "../../temp";
        public static string path_openFile = "C:\\";

        public static void TB_ThanhToan(bool f)
        {
            if(f)
            MessageBox.Show("Đã thanh toán thành công!");
            else
            MessageBox.Show("Thất bại!");
        }

        public static void TB_XoaKH(int kq)
        {
            if (kq == 2) 
            {
                MessageBox.Show("Khách hàng hiện tại đang trong giỏ hàng! Ko thể xóa!");
            }
            else
            {
                if (kq == 1)
                    MessageBox.Show("Đã xóa!");
                else
                    MessageBox.Show("Xóa thất bại! Có lỗi xảy ra!");
            }
        }

        public static void TB_XoaBan(bool f)
        {
            if (f)
            {
                MessageBox.Show("Bàn đang được sử dụng!");
            }
            else
            {
                MessageBox.Show("Đã xóa!");
            }

        }

        public static void TB_KTNV(int f)
        {
            if(true)
            {

            }
            else
            {

            }
        }

        public static bool TB_Close()
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông Báo", MessageBoxButtons.OKCancel)
                == System.Windows.Forms.DialogResult.OK)
            {
                return true;
            }
            return false;
        }

        public static void TB_ThieuTT()
        {
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
        }

        public static void TB_KQ(bool f)
        {
            if(f)
                MessageBox.Show("Thành công!");
            else
                MessageBox.Show("Thất bại!");
        }

        public static void TB_ThieuTT_pass()
        {
            MessageBox.Show("Mật khẩu xác nhận không khớp! Vui lòng nhập lại!");
        }

        public static void TB_Pass_lenght()
        {
            MessageBox.Show("Mật khẩu quá dài! Giới hạn 6 - 15 ký tự!");
        }

        public static void TB_Sdt_lenght()
        {
            MessageBox.Show("Số điện thoại không hợp lệ!");
        }

        public static void TB_NgaySinh_Err()
        {
            MessageBox.Show("Ngày sinh không hợp lệ!");
        }
        
        public static void TB_userName_Exist()
        {
            MessageBox.Show("Tên đăng nhập đã tồn tại!");
        }

        public static void TB_Err()
        {
            MessageBox.Show("Có lỗi xảy ra!");
        }

        public static void TB_Err_LoadData()
        {
            MessageBox.Show("Không thể lấy dữ liệu!");
        }

        public static void Err_ChuaThuHoiTK()
        {
            MessageBox.Show("Tài khoản đã được cấp! Cần thu hồi trước khi cấp cho nhân viên này!");
        }

        public static void TB_Account_Using()
        {
            MessageBox.Show("Tài khoản đang được sử dụng!");
        }


        //Sửa TB_Login
        public static void TB_Login(int kq)
        {
            if (kq == 3)
                MessageBox.Show("Sai mật khẩu");
            else
                    if (kq == 4)
                MessageBox.Show("Sai tên đăng nhập");
            else
                if (kq == 5)
                MessageBox.Show("Tài khoản chưa được cấp phép sử dụng!");
            else
                MessageBox.Show("Tên và mật khẩu không đúng");
        }

        //Thêm code
        public static void TB_TK_HanCheChucNang()
        {
            MessageBox.Show("Tài khoản của bạn không có quyền sử dụng chức năng này!");
        }
    }
}
