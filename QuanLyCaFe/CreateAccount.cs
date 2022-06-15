using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using BUS.BusinessObject;
using DTO.Models;

namespace QuanLyCafe
{
    public partial class CreateAccount : Form
    {
        public event FireEventForActionAccountsSuccess actionAccounts = null;
        public CreateAccount()
        {
            InitializeComponent();
            Source();
            Load_form();
        }

        //Khai báo lớp lấy dữ liệu
        //UserBus tkBUS = new AccountBUS();

        private void Load_form()
        {
            cb_quyen.Text = "Nhân viên bán hàng";
            txt_userName.Text = "";
            txt_passAC.Text = "";
            txt_nickName.Text = "";
            txt_Checkin.Text = "";
        }

        private void Source()
        {
            //List<AccountDTO> listQuyen = tkBUS.LayDSQuyen();
            //cb_quyen.DataSource = listQuyen;
            //cb_quyen.DisplayMember = "Quyen";
            //cb_quyen.ValueMember = "Quyen";
        }

        private bool Kt_duLieuNhap(UserModel tk)
        {
            if(tk.UserName==""||tk.Pass==""|| string.IsNullOrEmpty(txt_Checkin.Text)==true)
            {
                constans.TB_ThieuTT(); return false;
            }
            if (tk.Pass.Length > 15 || tk.Pass.Length < 6)
            {
                constans.TB_Pass_lenght();return false;
            }
            if(tk.Pass !=txt_Checkin.Text)
            {
                constans.TB_ThieuTT_pass(); return false;
            }
            //if(UserBus.KTTK_Username_exist(tk.UserName))
            //{
            //    constans.TB_userName_Exist();
            //    return false;
            //}

            return true;
        }

        private UserModel LayTTTK_form()
        {
            UserModel tk_moi = new UserModel();

            //tk_moi.userName = string.IsNullOrEmpty(txt_userName.Text) ? "" : txt_userName.Text;
            //tk_moi.pass = string.IsNullOrEmpty(txt_passAC.Text) ? "" : txt_passAC.Text;
            //tk_moi.Quyen = cb_quyen.Text;
            //tk_moi.nickName = string.IsNullOrEmpty(txt_nickName.Text) ? "" : txt_nickName.Text;

            return tk_moi;
        }

        private void btn_TaoTK_Click(object sender, EventArgs e)
        {
            UserModel tk_moi = LayTTTK_form();
            //if(Kt_duLieuNhap(tk_moi))
            //{
            //    bool kq = UserBus.CreateAccount(tk_moi);
            //    constans.TB_KQ(kq);
            //    if(kq)
            //    {
            //        if(actionAccounts!=null)
            //        {
            //            actionAccounts(this, new ActionAccountsSuccessEventArgs { });
            //        }
            //        Load_form();
            //    }
            //}
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
