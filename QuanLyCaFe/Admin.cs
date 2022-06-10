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

namespace QuanLySieuThiMini
{
    public partial class Admin : Form
    {        
        public void ActionReset(int req)
        {
            if(req==1)
            {
                Load_Ban();
            }
            if(req==2)
            {
                create_Source();
                Load_Data();
            }
        }

        public Admin()
        {
            InitializeComponent();
            Form_Setting();
            fAdmin_Load();
        }
        //Chuẩn bị các cài đặt trong form
        private void Form_Setting()
        {
            //dataGridViewThucUong.AutoGenerateColumns = false;
            //dtgvThucAn.AutoGenerateColumns = false;
            //dtgvtaikhoan.AutoGenerateColumns = false;
        }

        //Khởi tạo danh sách chứa dữ liệu nguồn
        List<PProductModel> listThucUong = new List<PProductModel>();
        List<PProductModel> listThucAn = new List<PProductModel>();
        List<UserModel> listTaiKhoan = new List<UserModel>();
        //List<BanDTO> dsBan = new List<BanDTO>();


        //Khởi tạo các lớp kết nối với data
        //SanPhamBUS sanPhamBUS = new SanPhamBUS();
        //AccountBUS accountBUS = new AccountBUS();
        //NhanVienBUS nvBUS = new NhanVienBUS();
        //BanBUS tablesBUS = new BanBUS(); 


        //Hàm xử lý, lấy và đổ dữ liệu
        private void fAdmin_Load()
        {
            create_Source();
            Load_Data();
        }

        private void Load_Data()
        {
            //Thức uống
            //dataGridViewThucUong.DataSource = listThucUong.ToList();
            
            ////Thức ăn
            //dtgvThucAn.DataSource = listThucAn.ToList();

            ////tài khoản
            //dtgvtaikhoan.DataSource = listTaiKhoan.ToList();

            //Bàn
            Load_Ban();
        }

        private void source_ThucAn()
        {
            //listThucAn = PProduct.LayDSThucAn();
            ////col_Nhasx.DataSource = sanPhamBUS.laydsnsx();
            //col_Nhasx.DisplayMember = "tenncc";
            //col_Nhasx.ValueMember = "mancc";
            //cmbNhaSX.DataSource = sanPhamBUS.laydsnsx();
            //cmbNhaSX.DisplayMember = "tenncc";
            //cmbNhaSX.ValueMember = "mancc";
            //txt_GiaTA.Text = 35000 + "";
        }

        private void source_ThucUong()
        {
            //listThucUong = sanPhamBUS.LayDSThucUong();
            //col_ncc.DataSource = sanPhamBUS.laydsnsx();
            //col_ncc.DisplayMember = "tenncc";
            //col_ncc.ValueMember = "mancc";
            //cmbNCCTU.DataSource = sanPhamBUS.laydsnsx();
            //cmbNCCTU.DisplayMember = "tenncc";
            //cmbNCCTU.ValueMember = "mancc";
            //txt_GiaTU.Text = "20000";
        }

        private void create_Source()
        {
            //Thức uống 
            source_ThucUong();
            

            //Thức ăn
            source_ThucAn();
            

            
            //Tài khoản
            
            listTaiKhoan = UserBus.SelectAll();
            //List<UserModel> dsq = UserBus.LayDSQuyen();
            //col_quyen.DataSource = dsq;
            //col_quyen.DisplayMember = "Quyen";
            //col_quyen.ValueMember = "Quyen";
            ////cmb_Quyen.DataSource = dsq.ToList();
            //cmb_Quyen.DisplayMember = "Quyen";
            //cmb_Quyen.ValueMember = "Quyen";            
            //cmb_Quyen.SelectedIndex = 0;

            DSNVPQ("Nhân viên bán hàng");
        }

        private void DSNVPQ(string quyen)
        {
            //List<NhanVienDTO> dspq = nvBUS.DSPQ(quyen);
            //if (dspq.Count() < 1 || dspq == null)
            //{
            //    cb_nvpq.DataSource = null;
            //    cb_nvpq.Text = "";
            //}
            //else
            //{
            //    cb_nvpq.DataSource = dspq;
            //    cb_nvpq.DisplayMember = "maNV";
            //    cb_nvpq.ValueMember = "maNV";
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmChonBaoCao fRP = new frmChonBaoCao();
            //fRP.ShowDialog();
        }

        

        // Page Bàn //
        private void Load_Ban()
        {
            //dsBan = tablesBUS.layDSBan(0);

            //foreach (BanDTO b in dsBan)
            //{
            //    Button btn = new Button() { Width = 100, Height = 100 };
            //    btn.Text = b.masoban;
            //    //EventHandler btn_Click = null;
            //    btn.Click += Btn_Click;
            //    btn.Tag = b;
            //    switch (b.TrangThai)
            //    {
            //        case 1:
            //            {
            //                btn.Text += "\n Trống";
            //                btn.BackColor = Color.White;
            //                break;
            //            }
            //        default:
            //            {
            //                btn.Text += "\n Đang sử dụng";
            //                btn.BackColor = Color.Red;
            //                break;
            //            }
            //    }
            //    flp_ban.Controls.Add(btn);
            //}

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            constans.TB_Sdt_lenght();
        }

        
        

        //Page tài khoản //

        //private AccountDTO LayTTTK()
        //{
        //    AccountDTO tk = new AccountDTO();

        //    if(string.IsNullOrEmpty(txt_taikhoan.Text))
        //    {
        //        return tk;
        //    }
        //    tk = accountBUS.LayTK(txt_taikhoan.Text);

        //    return tk;
        //}
        
        private void buttonCreateTK_Click(object sender, EventArgs e)
        {
            //CreateAccount fCA = new CreateAccount();
            //fCA.actionAccounts += FCA_actionAccounts;
            //fCA.ShowDialog();
        }

        private void FCA_actionAccounts(object sender, ActionAccountsSuccessEventArgs e)
        {
            //throw new NotImplementedException();
            create_Source();
            Load_Data();
        }

        private void buttonSuaTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void buttonXoaTaiKHoan_Click(object sender, EventArgs e)
        {
            UserModel tk = UserBus.SelectByPrimaryKey(1);
            //if (tk.maTK != "")
            //{
            //    foreach (AccountDTO ac in listTaiKhoan)
            //    {
            //        if (ac.userName == tk.userName)
            //        {
            //            if (ac.TrangThai == 2)
            //            {
            //                bool kq = accountBUS.DelAccount(tk.userName);
            //                constans.TB_KQ(kq);
            //                if (kq)
            //                {

            //                }
            //            }
            //            else
            //            {
            //                constans.TB_Account_Using();
            //                return;
            //            }
            //        }
            //    }
            //}
        }

        private void dtgvtaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dtgvtaikhoan.SelectedCells.Count > 0)
            //{
            //    if (dtgvtaikhoan.SelectedCells[0].RowIndex < listTaiKhoan.Count())
            //    {
            //        string userName = dtgvtaikhoan.SelectedCells[0].OwningRow.Cells[0].Value.ToString();

            //        foreach (UserModel tk in listTaiKhoan)
            //        {
            //            //if (tk.userName == userName)
            //            //{
            //            //    txt_taikhoan.Text = tk.userName;
            //            //    txt_tenhienthi.Text = string.IsNullOrEmpty(tk.nickName) ? "" : tk.nickName;
            //            //    cmb_Quyen.SelectedValue = tk.Quyen;
            //            //    SystemStaffModel nv = null;
            //            //    if (nv == null)
            //            //        cb_nvpq.Text = "";
            //            //    else
            //            //    {
            //            //        DSNVPQ(tk.Quyen);
            //            //        cb_nvpq.SelectedValue = nv.maNV;
            //            //    }
            //            //    break;
            //            //}
            //        }
            //    }
            //}
        }

        private void cmb_Quyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string quyen = cmb_Quyen.SelectedText;
            //List<SystemStaffModel> dspq = null;
            //if (dspq.Count() < 1 || dspq == null)
            //{
            //    cmb_Quyen.DataSource = null;
            //    cmb_Quyen.Text = "";
            //}
            //else
            //{
            //    cmb_Quyen.DataSource = dspq;
            //    cmb_Quyen.DisplayMember = "maNV";
            //    cmb_Quyen.ValueMember = "maNV";
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        /* Sản phẩm */
        //Page Thức ăn //
        private PProductModel LayttspTA()
        {
            PProductModel sp = new PProductModel();
            //sp.masp = string.IsNullOrEmpty(txt_maspTA.Text) ? "" : txt_maspTA.Text;
            //sp.tensp = string.IsNullOrEmpty(txt_nameFood.Text) ? "" : txt_nameFood.Text;
            //sp.dongia = Convert.ToInt32(txt_GiaTA.Text);

            return sp;
        }

        private void dtgvThucAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dtgvThucAn.SelectedCells.Count > 0)
            //{
            //    if (dtgvThucAn.SelectedCells[0].RowIndex < listThucAn.Count())
            //    {
            //        string tensp = dtgvThucAn.SelectedCells[0].OwningRow.Cells[0].Value.ToString();

            //        foreach (PProductModel sp in listThucAn)
            //        {
            //            //if (sp.tensp == tensp)
            //            //{
            //            //    txt_maspTA.Text = sp.masp;
            //            //    txt_nameFood.Text = sp.tensp;
            //            //    txt_GiaTA.Text = sp.dongia + "";
            //            //    cmbNhaSX.SelectedValue = sp.NCC;
            //            //    break;
            //            //}
            //        }
            //    }
            //}
        }

        private bool KiemtraNhap_TA()
        {
            return true;
        }
        //Page Thức uống //
        private PProductModel LayttspTU()
        {
            PProductModel sp = new PProductModel();

            //sp.masp = string.IsNullOrEmpty(txt_maspTU.Text) ? "" : txt_maspTU.Text;
            //sp.loaisp = cb_PhanLoai.SelectedItem.ToString();
            //sp.tensp = string.IsNullOrEmpty(txtThucUong.Text) ? "" : txtThucUong.Text;
            //sp.dongia = Convert.ToInt32(txt_GiaTU.Text);

            return sp;
        }


        private void dataGridViewThucUong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridViewThucUong.SelectedCells.Count > 0)
            //{
            //    if (dataGridViewThucUong.SelectedCells[0].RowIndex < listThucUong.Count())
            //    {
            //        string tensp = dataGridViewThucUong.SelectedCells[0].OwningRow.Cells[0].Value.ToString();

            //        foreach (PProductModel sp in listThucUong)
            //        {
            //            //if (sp.tensp == tensp)
            //            //{
            //            //    txt_maspTU.Text = sp.masp;
            //            //    txtThucUong.Text = sp.tensp;
            //            //    txt_GiaTU.Text = sp.dongia + "";
            //            //    cmbNCCTU.SelectedValue = sp.NCC;
            //            //    cb_PhanLoai.SelectedItem = sp.loaisp;
            //            //    break;
            //            //}

            //        }
            //    }
            //}
        }

        private void btn_themspTU_Click(object sender, EventArgs e)
        {
            if (KiemtraNhap_TU())
            {
                PProductModel sp = LayttspTU();
            }
        }

        private void txt_GiaTU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_GiaTA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;//Chặn phím, vô hiệu phím
            }
            //!Char.IsDigit(e.KeyChar) : có phải ký tự số
            //!char.IsControl(e.KeyChar) : có phải kí tự điều khiển(4 nút mũi tên,backspace,delete)
        }

        private bool KiemtraNhap_TU()
        {
            //if (string.IsNullOrEmpty(txt_GiaTU.Text))
            //    return false;
            //if (string.IsNullOrEmpty(txtThucUong.Text) || txtThucUong.Text.Trim() == "")
            //    return false;
            return true;
        }


    }
}
