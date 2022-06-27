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
using BUS.BusinessObjectBase;
using DTO.ModelsBase;

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

        SystemPositionBase pt = new SystemPositionBase();

        SystemStaffBase ssb = new SystemStaffBase();

        SystemStaffModel nhanvien;
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
            
        }
        
        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
           cb_CV.DataSource = pt.LayDSCV();
            cb_CV.DisplayMember = "Name";
            cb_CV.ValueMember = "Id";

            dtgv_NV.DataSource = ssb.LayDSNV();
            dtgv_NV.Refresh();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int id;string lastname;string image;string email; DateTime createDate;DateTime modifielDate;
            int createUserID;int modifielUserId; bool iDeleted;int status;
            string firstname = txtHonv.Text;
            string fullname = txtTennv.Text;
            DateTime ngaysinh = dtpNgaySinh.Value;
            string diachi = txt_diachi.Text;
            string sdt = txt_sdt.Text;
            SystemStaffModel nv = new SystemStaffModel(id,);
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
            if (dtgv_NV.SelectedCells.Count > 0)
            {
                this.txtManv.Text = dtgv_NV.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txtHonv.Text = dtgv_NV.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.txtTennv.Text = dtgv_NV.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.dtpNgaySinh.Text = dtgv_NV.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.txt_diachi.Text = dtgv_NV.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.txt_sdt.Text = dtgv_NV.Rows[e.RowIndex].Cells[5].Value.ToString();
               // this.dtpNgayVao.Text = dtgv_NV.Rows[e.RowIndex].Cells[6].Value.ToString();
                this.cb_CV.Text = dtgv_NV.Rows[e.RowIndex].Cells[6].Value.ToString();

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
