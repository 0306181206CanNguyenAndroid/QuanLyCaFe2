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
using DTO;
using DTO.Models;

namespace QuanLySieuThiMini
{
    public partial class Home : Form
    {
        public UserModel TKDN;
        public event FireEventForAction_LogoutSuccess logout = null;
        //public event FireEventForAction_RequestBills requestBills = null;
        public Home(UserModel tkdn)
        {
            InitializeComponent();
            TKDN = tkdn;
            this.IsMdiContainer = true;
        }

        private bool CheckExistForm(string name)
        {
            bool f = false;
            foreach(Form fr in this.MdiChildren)
            {
                if(fr.Name == name)
                {
                    f = true; break;
                }
            }
            return f;
        }

        private void ActiveChildForm(string name)
        {
            foreach(Form fr in this.MdiChildren)
            {
                if(fr.Name==name)
                {
                    fr.Activate();break;
                }
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NhanVienBUS nvBUS = new NhanVienBUS();
            //NhanVienDTO nv = nvBUS.LayNV(TKDN.maTK);
            //ThongTinCaNhan myAccount = new ThongTinCaNhan(TKDN,nv);
            //myAccount.ShowDialog();
        }

        //Phần này sửa//
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if(TKDN.Quyen== "Administrator")
            //{
            //    if (!CheckExistForm("fAdmin"))
            //    {
            //        fAdmin ad = new fAdmin();
            //        ad.MdiParent = this;
            //        ad.Show();
            //    }
            //    else
            //        ActiveChildForm("fAdmin");
            //}
            //else
            //    constans.TB_TK_HanCheChucNang();
        }

        private void quảnLýDanhSáchBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //if (!CheckExistForm("QuanLyHoaDon"))
            //{
            //    QuanLyHoaDon qlhd = new QuanLyHoaDon(TKDN);
            //    qlhd.MdiParent = this;
            //    qlhd.Show();
            //}
            //else
            //    ActiveChildForm("QuanLyHoaDon");            
        }

        private void TrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //tkBUS.UpdateLogOutStatus(TKDN.maTK, 1);
            //if(logout!=null)
            //{
            //    logout(this, new Action_LogoutSuccessEventArgs { });
            //}
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            //if (!CheckExistForm("Customers"))
            //{
            //    Customers kh = new Customers();
            //    kh.MdiParent = this;
            //    kh.Show();
            //}
            //else
            //    ActiveChildForm("Customers");
            
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if(TKDN.Quyen.StartsWith("Nhân viên"))
            //{
            //    constans.TB_TK_HanCheChucNang();
            //    return;
            //}
            //if (!CheckExistForm("QuanLyNhanVien"))
            //{
            //    QuanLyNhanVien bill = new QuanLyNhanVien();
            //    bill.MdiParent = this;
            //    bill.Show();
            //}
            //else
            //    ActiveChildForm("QuanLyNhanVien");
        }

        private void lậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            //Order bill = new Order(nvBUS.LayNV(TKDN.maTK));
            //bill.ShowDialog();
            //foreach (Form fr in this.MdiChildren)
            //{
            //    if (fr.Name == "fAdmin" || fr.Name == "QuanLyHoaDon")
            //    {
            //        bill.actionBills += Bill_actionBills;
            //    }                
            //}
            
            
        }

        private void Bill_actionBills(object sender, ActionBillsSuccessEventArgs e)
        {
            //throw new NotImplementedException();
            foreach (Form fr in this.MdiChildren)
            {
                if (fr.Name == "fAdmin")
                {
                    Admin f = (Admin)fr;
                    f.ActionReset(1);
                }
                if (fr.Name == "QuanLyHoaDon")
                {
                    BillManager f = (BillManager)fr;
                    f.ActionReset(1);
                }
            }
        }

        //Phần mới
        //Thêm mới (Lưu ý tạo sự kiện trước rồi copy Code ở trong vào)
        private void TrangChu_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.Shift && e.KeyCode==Keys.A)
            //{
            //    if (TKDN.Quyen == "Administrator")
            //    {
            //        if (!CheckExistForm("fAdmin"))
            //        {
            //            fAdmin ad = new fAdmin();
            //            ad.MdiParent = this;
            //            ad.Show();
            //        }
            //        else
            //            ActiveChildForm("fAdmin");
            //    }
            //    else
            //    {
            //        constans.TB_TK_HanCheChucNang();
            //    }
            //}


            //if(e.Control && e.KeyCode==Keys.X)
            //{
            //    this.Close();
            //}

            //if(e.Shift && e.KeyCode==Keys.B)
            //{
            //    Order bill = new Order(nvBUS.LayNV(TKDN.maTK));
            //    bill.ShowDialog();
            //}

            //if(e.Shift && e.KeyCode==Keys.K)
            //{
            //    if (!CheckExistForm("Customers"))
            //    {
            //        Customers kh = new Customers();
            //        kh.MdiParent = this;
            //        kh.Show();
            //    }
            //    else
            //        ActiveChildForm("Customers");
            //}

            //if(e.Shift && e.KeyCode==Keys.N)
            //{
            //    if (TKDN.Quyen.StartsWith("Nhân viên"))
            //    {
            //        constans.TB_TK_HanCheChucNang();
            //        return;
            //    }
            //    if (!CheckExistForm("QuanLyNhanVien"))
            //    {
            //        QuanLyNhanVien bill = new QuanLyNhanVien();
            //        bill.MdiParent = this;
            //        bill.Show();
            //    }
            //    else
            //        ActiveChildForm("QuanLyNhanVien");
            //}

            //if (e.Shift && e.KeyCode == Keys.M)
            //{
            //    ThongTinCaNhan myAccount = new ThongTinCaNhan(TKDN,);
            //    myAccount.ShowDialog();
            //}

        }

        private void TrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (constans.TB_Close())
            {
                this.Dispose();
            }
            else
                e.Cancel = true;
        }

        
    }
}
