using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThiMini.HardCodeClass.Vi
{
    public static class Message_Vi
    {
        public static void TB_Login(int kq)
        {
            if (kq == 0)
                MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập");
            else if (kq == -1)
                MessageBox.Show("Lỗi hệ thống!");
            //else
            //    MessageBox.Show("Tên và mật khẩu không đúng");

            //if (kq == 5)
            //    MessageBox.Show("Tài khoản chưa được cấp phép sử dụng!");
            //else
            //    MessageBox.Show("Tên và mật khẩu không đúng");
        }
    }
}
