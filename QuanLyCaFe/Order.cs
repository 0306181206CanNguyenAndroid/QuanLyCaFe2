using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using BUS.BusinessObject;
using DTO;
using DTO.Models;

namespace QuanLyCaFe
{    
    public partial class Order : Form
    {
        public event FireEventForActionBillsSuccess actionBills = null;
        //private NhanVienDTO NV_LapHD = null;
        //private HoaDonDTO HD = null;

        ////Các lớp xử lí
        //SanPhamBUS sanPhamBUS = new SanPhamBUS();
        //HoaDonBUS hoaDonBUS = new HoaDonBUS();
        //BanBUS banBUS = new BanBUS();
        //KhachHangBUS khachHangBUS = new KhachHangBUS();
        //NhanVienBUS nhanVienBUS = new NhanVienBUS();
        List<PProductModel> dsChon = new List<PProductModel>();
        //NhanVienDTO nv_lap = new NhanVienDTO();

        public Order()
        {
            InitializeComponent();
            cb_LoaiSP.Text = "Trà Sữa";
            Cb_Sanpham_Load("ts");
            dataGridView1.AutoGenerateColumns = false;
            //HD = hd;
            //NV_LapHD = nv;
            //FormOther_Load(HD);
        }

        public Order(SystemStaffModel nv)
        {
            InitializeComponent();
            cb_LoaiSP.Text = "Trà Sữa";
            Cb_Sanpham_Load("ts");
            dataGridView1.AutoGenerateColumns = false;
            //NV_LapHD = nv;
            FormOther_Load();
        }

        BindingSource bs = new BindingSource();
        private void taoSource()
        {
            dsChon.Clear();
            bs.DataSource = dsChon.ToList();
            dataGridView1.DataSource = bs;
        }

        private void FormOther_Load()
        {
            btn_create.Enabled = true;
            btn_del.Enabled = false;

            //nrud_Sales.Value = HD.khachHang.point / 10;
            TongTienLoad();
            Load_Ban(1);
            Load_NV();
            Load_KH();
            tb_mahd.Text = generated_Mahd();
            taoSource();
        }

        private void FormOther_Load(PBillModel HD)
        {
            //dsChon = HD.dssp;
            //taoSource();
            //btn_create.Enabled = false;
            //btn_del.Enabled = true;
            //nrud_Sales.Value = HD.dssp[0].Sales;
            //TongTienLoad();
            //Load_Ban(0);
            //cb_Ban.Text = HD.maBan;
            //tb_mahd.Text = HD.maHD;
            //Load_NV();
            //if (!HD.maKH.StartsWith("KHV"))
            //{
            //    ckB_kh.Checked = false;
            //    ckB_kh.Enabled = false;
            //}
            //else
            //{
            //    ckB_kh.Checked = true;
            //    Load_KH();
            //    cb_sdtKHV.Text = HD.khachHang.sdt;
            //    cb_sdtKHV.Enabled = false;
            //}
        }

        private string convert_maloai(string tenloai)
        {
            switch (tenloai)
            {
                case "Trà Sữa": return "TS";
                case "Cooktail": return "ctl";
                case "Thức ăn nhanh": return "Food";
                case "Sinh Tố": return "ST";
                case "Nước Ngọt": return "NN";
                case "Cà Phê": return "CF";
                default: return "Tea";
            }
        }

        private string convert_tensp(string masp)
        {
            string[] sp = masp.Split('_');

            switch (sp[0])
            {
                case "ts": return "Trà Sữa";
                case "ctl": return "Cooktail";
                case "food": return "Thức ăn nhanh";
                case "st": return "Sinh Tố";
                case "nn": return "Nước Ngọt";
                case "cf": return "Cà Phê";
                default: return "Tea";
            }
        }

        private void cb_LoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loaisp = cb_LoaiSP.SelectedItem.ToString();
            Cb_Sanpham_Load(convert_maloai(loaisp));
        }

        private void Cb_Sanpham_Load(string masp)
        {
            //List<SanPhamDTO> lsp = sanPhamBUS.Load_SP(masp);
            //if (lsp != null)
            //{
            //    cb_Sanpham.DataSource = lsp;
            //    cb_Sanpham.DisplayMember = "tensp";
            //    cb_Sanpham.ValueMember = "masp";
            //    var sp = cb_Sanpham.SelectedValue;
            //    foreach (SanPhamDTO s in lsp)
            //    {
            //        if (s.masp == sp.ToString())
            //        {
            //            tb_Gia.Text = s.dongia + "";
            //        }
            //    }
            //}
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //string maspSelected = cb_Sanpham.SelectedValue.ToString();
            //SanPhamDTO sp = sanPhamBUS.LaySP(maspSelected);
            //sp.giaBan = sp.dongia;
            //sp.slmua = (int)nbud_solgmua.Value;
            //bool fl = false;
            //foreach (SanPhamDTO a in dsChon)
            //{
            //    if (sp.masp == a.masp)
            //    {
            //        fl = true;
            //        a.slmua = a.slmua + sp.slmua;
            //        break;
            //    }
            //}
            //if (fl == false)
            //{
            //    dsChon.Add(sp);
            //}
            taoSource();
            TongTienLoad();
        }

        private void btn_Loaibo_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedCells.Count > 0)
            {
                string tensp = dataGridView1.SelectedCells[0].OwningRow.Cells["col_sp"].Value.ToString();
                //foreach (SanPhamDTO sp in dsChon)
                //{
                //    if (sp.tensp == tensp)
                //    {
                //        dsChon.Remove(sp); break;
                //    }
                //}
                taoSource();
                TongTienLoad();
            }
        }

        private void TongTienLoad()
        {
            int tong = 0, sales = (int)nrud_Sales.Value;
            if (dsChon.Count() > 0)
            {
                //foreach (SanPhamDTO sp in dsChon)
                //{
                //    tong += sp.giaBan * sp.slmua;
                //    sp.Sales = sales;
                //}
                //tb_TT.Text = "" + (tong - (tong * sales / 100));

            }
            else
                tb_TT.Text = "0";
        }

        private void cb_Sanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string masp = cb_Sanpham.SelectedValue.ToString();
            //SanPhamDTO sp = sanPhamBUS.LaySP(masp);
            //if (sp != null)
            //    tb_Gia.Text = sp.dongia.ToString();
            //else
            //    tb_Gia.Text = "";
        }

        private string generated_Mahd()
        {
            //int sohd = hoaDonBUS.laySoLgHD();
            //if (sohd < 10)
            //    return "hd000" + sohd;
            //if (sohd < 100)
            //    return "hd00" + sohd;
            //if (sohd < 1000)
            //    return "hd0" + sohd;
            return "hd";
        }

        private void Load_Ban(int kind)
        {
            //cb_Ban.DataSource = banBUS.layDSBan(kind);
            //cb_Ban.DisplayMember = "MaSoBan";
            //cb_Ban.ValueMember = "MaSoBan";
        }

        private void Load_NV()
        {
            //if (HD == null)
            //{
            //    tb_nv.Text = NV_LapHD.maNV;
            //    //tb_nv.Text = "nv_02";
            //}
            //else
            //{
            //    tb_nv.Text = HD.maNV;
            //}


        }

        private void cb_Ban_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgv_Load()
        {
            dataGridView1.AutoGenerateColumns = false;
        }

        private void bt_create_Click(object sender, EventArgs e)
        {
            //if (dsChon.Count() > 0)
            //{
            //    HoaDonDTO hoaDon = new HoaDonDTO();
            //    hoaDon.dssp = new List<SanPhamDTO>(dsChon);
            //    hoaDon.maHD = tb_mahd.Text;
            //    hoaDon.ngayLap = DateTime.Now;
            //    hoaDon.soban = new BanDTO();
            //    hoaDon.soban.masoban = cb_Ban.SelectedValue.ToString();
            //    hoaDon.nv_LapHD = new NhanVienDTO();
            //    hoaDon.nv_LapHD.maNV = NV_LapHD.maNV;
            //    hoaDon.tongThanhToan = Convert.ToInt32(tb_TT.Text);
            //    if (ckB_kh.Checked == false)
            //    {
            //        hoaDon.khachHang = null;
            //    }
            //    else
            //    {
            //        hoaDon.khachHang = new KhachHangDTO();
            //        KhachHangDTO khtt = khachHangBUS.layKH(cb_sdtKHV.SelectedValue.ToString());
            //        hoaDon.khachHang.maKH = khtt.maKH;
            //        hoaDon.khachHang.tenKH = khtt.tenKH;
            //        hoaDon.khachHang.sdt = khtt.sdt;
            //        hoaDon.khachHang.point = khtt.point;
            //        hoaDon.khachHang.xoaKH = 1;
            //    }
            //    bool kq = hoaDonBUS.themHD(hoaDon);
            //    constans.TB_ThanhToan(kq);
            //    if (kq == true)
            //    {
            //        if (actionBills != null)
            //        {
            //            actionBills(this, new ActionBillsSuccessEventArgs { });
            //        }
            //        dsChon.Clear();
            //        FormOther_Load();
            //    }



            //}
        }

        private void Load_KH()
        {
            //cb_sdtKHV.DataSource = khachHangBUS.LayDskh().ToList();
            //cb_sdtKHV.DisplayMember = "sdt";
            //cb_sdtKHV.ValueMember = "maKH";
        }

        private void ckB_kh_CheckedChanged(object sender, EventArgs e)
        {
            if (ckB_kh.Checked == true)
            {
                nrud_Sales.Enabled = true;
                Load_KH();
            }
            else
            {
                cb_sdtKHV.DataSource = null;
                nrud_Sales.Enabled = false;
                nrud_Sales.Value = 0;
            }
        }

        private void nrud_Sales_ValueChanged(object sender, EventArgs e)
        {
            TongTienLoad();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0
                && dataGridView1.SelectedCells[0].RowIndex < dsChon.Count())
            {
                string tensp = dataGridView1.SelectedCells[0].OwningRow.Cells["col_sp"].Value.ToString();
                if (tensp != null && tensp != "")
                {
                    //foreach (SanPhamDTO sp in dsChon)
                    //{
                    //    if (sp.tensp == tensp)
                    //    {
                    //        cb_LoaiSP.Text = convert_tensp(sp.masp);
                    //        cb_Sanpham.Text = sp.masp;
                    //        tb_Gia.Text = sp.dongia + "";
                    //        nbud_solgmua.Value = sp.slmua;
                    //        break;
                    //    }
                    //}
                    taoSource();
                    TongTienLoad();
                }

            }
        }

        private void bt_dkKHV_Click(object sender, EventArgs e)
        {
            Customers ct = new Customers();
            ct.ShowDialog();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            //if (HD != null)
            //{
            //    HD.dssp = dsChon;
            //    FormOther_Load(HD);
            //}
            //else
            //    FormOther_Load();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            //if (HD != null)
            //{
            //    string mahd = HD.maHD;
            //    bool kq = hoaDonBUS.XoaHD(mahd);
            //    constans.TB_KQ(kq);
            //    if (kq)
            //    {
            //        if (actionBills != null)
            //        {
            //            actionBills(this, new ActionBillsSuccessEventArgs { });
            //        }
            //        HD = null;
            //        FormOther_Load();
            //    }
            //}
        }
    }
}
