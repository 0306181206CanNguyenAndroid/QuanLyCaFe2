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
using BUS.BusinessObjectBase;
using DTO;
using DTO.Models;
using DTO.ModelsBase;

namespace QuanLyCafe
{
    public partial class fLogin : Form
    {
        UserModel taikhoan = new UserModel();
        UserBus tkBus = new UserBus();
        public fLogin()
        {
            InitializeComponent();
        }
       

        private void T_logout(object sender, Action_LogoutSuccessEventArgs e)
        {
            //throw new NotImplementedException();
            this.Show();
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            //textBoxten.Text = "Admin123";
            //txtPass.Text = "123@abc";
            
            
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình?","Thông Báo",MessageBoxButtons.OKCancel)
                != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            taikhoan.UserName = txtUserName.Text;
            taikhoan.Pass = txtPass.Text;

            string getUser = tkBus.CheckLogin(taikhoan);
            switch (getUser)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Tài khoản không được trống");
                    return;
                case "requeid_pass":
                    MessageBox.Show("Mật khẩu không được trống");
                    return;
                case "Tài khoản hoặc mật khẩu không chính xác":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                    return;
            }
            this.Hide();
            QuanLyNhanVien Qlnv = new QuanLyNhanVien();
            Qlnv.ShowDialog();
        }

        
    }
}
