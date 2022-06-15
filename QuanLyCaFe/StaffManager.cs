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
using DTO.Models;
using BUS.BusinessObject;

namespace QuanLyCafe
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
            //Setting();
            //Load_DSNV();
        }
       
        List<SystemStaffModel> dsnv = new List<SystemStaffModel>();
        //SystemStaff nvBUS = new NhanVienBUS();
        //BanBUS banBUS = new BanBUS();
        BindingSource bs = new BindingSource();

        private void Setting()
        {
            dtgv_NV.AutoGenerateColumns = false;
            txtManv.ReadOnly = true;
            rdbNam.Checked = true;
        }

        private void TaoSource()
        {
            //col_chucvu.DataSource = nvBUS.LayDSCV();
            //col_chucvu.ValueMember = "tenCV";
            //col_chucvu.DisplayMember = "tenCV";
            //cb_CV.DataSource = nvBUS.LayDSCV();
            //cb_CV.DisplayMember = "tenCV";
            //cb_CV.ValueMember = "tenCV";
            //dsnv = nvBUS.LayDSNV();

        }

        private void Load_DSNV()
        {
            TaoSource();
            bs.DataSource = dsnv.ToList();
            dtgv_NV.DataSource = bs;
        }

        private void Load_Form()
        {
            Load_DSNV();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            Load_Form();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SystemStaffModel nv = LayTTNV();
            //if (KTTT_NV(nv))
            //{
            //    bool kq = nvBUS.ThemNV(nv);
            //    constans.TB_KQ(kq);
            //    if (kq)
            //    {
            //        Load_DSNV();
            //    }
            //}
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtManv.Text) != true)
            //{
            //    string manv = txtManv.Text;
            //    bool kq = nvBUS.DelNV(manv);
            //    constans.TB_KQ(kq);
            //    if (kq)
            //        Load_DSNV();
            //}
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            //NhanVienDTO nv = LayTTNV();
            //if (KTTT_NV(nv))
            //{
            //    bool kq = nvBUS.UpdateNV(nv);
            //    constans.TB_KQ(kq);
            //    if (kq)
            //        Load_DSNV();
            //}
        }

        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_CV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgv_NV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_NV.SelectedCells.Count > 0 && dsnv.Count() > 0)
            {
                if (dtgv_NV.SelectedCells[0].RowIndex < dsnv.Count())
                {
                    string manv = dtgv_NV.SelectedCells[0].OwningRow.Cells["col_manv"].Value.ToString();
                    //foreach (NhanVienDTO nv in dsnv)
                    //{
                    //    if (nv.maNV == manv)
                    //    {
                    //        txtManv.Text = nv.maNV;
                    //        txtHonv.Text = string.IsNullOrEmpty(nv.hoNV) ? "" : nv.hoNV;
                    //        txtTennv.Text = string.IsNullOrEmpty(nv.tenNV) ? "" : nv.tenNV;
                    //        cb_CV.Text = nv.MaCV;
                    //        if (nv.GioiTinh == "Nữ")
                    //            rdbNu.Checked = true;
                    //        else
                    //            rdbNam.Checked = true;
                    //        txt_diachi.Text = string.IsNullOrEmpty(nv.diaChi) ? "" : nv.diaChi;
                    //        if (nv.maTK != "tk_05")
                    //            txt_sdt.Text = string.IsNullOrEmpty(nv.sdt) ? "" : nv.sdt;
                    //        dtpNgaySinh.Value = nv.ngaySinh;
                    //        dtpNgayVao.Value = nv.ngayBD;
                    //        nudSoNgayNghi.Value = nv.soNgaynghi;
                    //        break;
                    //    }
                    //}
                }

            }
        }

        private SystemStaffModel LayTTNV()
        {
            SystemStaffModel nv = new SystemStaffModel();
            //nv.maNV = string.IsNullOrEmpty(txtManv.Text) ? "" : txtManv.Text;
            //nv.hoNV = string.IsNullOrEmpty(txtHonv.Text) ? "" : txtHonv.Text;
            //nv.tenNV = string.IsNullOrEmpty(txtTennv.Text) ? "" : txtTennv.Text;
            //nv.ngaySinh = dtpNgaySinh.Value;
            //nv.ngayBD = dtpNgayVao.Value;
            //nv.diaChi = string.IsNullOrEmpty(txt_diachi.Text) ? "" : txt_diachi.Text;
            //nv.sdt = string.IsNullOrEmpty(txt_sdt.Text) ? "" : txt_sdt.Text;
            //nv.soNgaynghi = Convert.ToInt32(nudSoNgayNghi.Value);
            //if (rdbNam.Checked)
            //    nv.GioiTinh = "Nam";
            //else
            //    nv.GioiTinh = "Nữ";
            //nv.Luong = 0;
            //nv.MaCV = cb_CV.Text;

            return nv;
        }

        private bool KTTT_NV(SystemStaffModel nv)
        {
            //if (nv.hoNV == "" || nv.tenNV == "" || nv.sdt == "" || nv.diaChi == "")
            //{
            //    constans.TB_ThieuTT();
            //    return false;
            //}
            //if (nv.ngaySinh >= DateTime.Now)
            //{
            //    constans.TB_NgaySinh_Err();
            //    return false;
            //}
            //if (nv.sdt.Length > 12 || nv.sdt.Length < 9)
            //{
            //    constans.TB_Sdt_lenght();
            //    return false;
            //}

            return true;
        }

        private void QuanLyNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (constans.TB_Close())
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
