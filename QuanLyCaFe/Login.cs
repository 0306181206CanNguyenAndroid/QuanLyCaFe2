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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string usn = txtUserName.Text;
            string Pass = txtPass.Text;
           
            int kqkt = UserBus.check_Account(usn, Pass);

            if (kqkt == 1)
            {
                Home t = new Home(UserBus.SelectWithUserAndPass(usn, Pass));
                t.logout += T_logout;
                this.Hide();
                t.ShowDialog();
            }
            else
            {
                constans.TB_Login(kqkt);
            }
            
            //this.Show();

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
            txtPass.Text = "123@abc";
            
            
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
    }
}
