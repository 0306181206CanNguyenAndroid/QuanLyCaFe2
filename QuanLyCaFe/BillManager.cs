using DTO;
using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DTO.Models;
using BUS.BusinessObject;

namespace QuanLySieuThiMini
{
    public partial class BillManager : Form
    {
        private UserModel tkql;

        public void ActionReset(int req)
        {
            if (req == 1)
            {
                Load_Source();
                rd_year.Checked = true;
            }
            if (req == 2)
            {
                
            }
        }

        public BillManager(UserModel tkdn)
        {
            InitializeComponent();
            tkql = tkdn;
            Setting();
            Load_Source();
            Load_Form();
             
        }

        //Các cài đặt mặt định của form
        private void Setting()
        {
            datgv_HD.AutoGenerateColumns = false;
            tb_mahd.ReadOnly = true;
            tb_ngayLap.ReadOnly = true;
            tb_sdt.ReadOnly = true;
            tb_tenkh.ReadOnly = true;
            tb_TT.ReadOnly = true;
            rd_today.Checked = true;
        }

        //Khai báo các class lấy dl cho form
        PBill OrderBUS = new PBill();
        //AccountBUS tkBUS = new AccountBUS();        
        //NhanVienBUS nvBUS = new NhanVienBUS();
        //BanBUS banBUS = new BanBUS();

        ////Khai báo biến lưu trữ tạm cho form
        //List<HoaDonDTO> dshd = new List<HoaDonDTO>();
        //NhanVienDTO NV = new NhanVienDTO();
        BindingSource bs = new BindingSource();

        //Xử lý trong form - tab Quản lý danh sách hóa đơn 
        private void Load_Form()
        {
            //tkql = tkBUS.LayTK("tk_03");
            //NV = nvBUS.LayNV(tkql.maTK);
            //Load_DSHD(DateTime.Now,3);            
        }
        
        private void Load_Source()
        {
            //col_nv.DataSource = nvBUS.LayDSNV();
            //col_nv.DisplayMember = "maNV";
            //col_nv.ValueMember = "maNV";
            //col_ban.DataSource = banBUS.layDSBan(0);
            //col_ban.DisplayMember = "masoban";
            //col_ban.ValueMember = "masoban";
        }

        private void Load_DSHD(DateTime date,int loai)
        {
            //dshd = OrderBUS.LayDSHD(date,loai);            
            //bs.DataSource = dshd.ToList();
            //datgv_HD.DataSource = bs;
            //if (dshd.Count() < 1)
            //{
            //    Reset();
            //}
        }

            /*string path = "../../TRASUA";
            private void LoadImgList()
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                FileInfo[] fileInfo = dirInfo.GetFiles("*.jpg");

                foreach (FileInfo fInFo in fileInfo)
                {
                    //Đọc tập tin hình -> byte
                    byte[] bytes = File.ReadAllBytes(fInFo.FullName);
                    MemoryStream mms = new MemoryStream(bytes);

                    imgLargeIcon.Images.Add(fInFo.Name, Image.FromStream(mms));
                    imgSmallIcon.Images.Add(fInFo.Name, Image.FromStream(mms));

                }
            }
            private void loadList1()
            {


                    ListViewItem li = new ListViewItem(imgLargeIcon.Images.ToString());
                    //listView1.Items.Add(li);

            }*/

        private void ResetDS()
        {
            int loai = 0;
            if (rd_day.Checked || rd_today.Checked)
                loai = 3;
            else if (rd_month.Checked)
                loai = 2;
            else if (rd_year.Checked)
                loai = 1;
            
            Load_DSHD(DateTime.Now, loai);
        }

        private void Reset()
        {
            tb_mahd.Text = "";
            tb_ngayLap.Text = DateTime.Now+"";
            tb_sdt.Text = "";
            tb_tenkh.Text = "";
            tb_nvl.Text = "";
            tb_TT.Text = "";
            ckb_khv.Checked = true;
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            //Order od = new Order(nvBUS.LayNV(tkql.maTK));
            //od.actionBills += Od_actionBills;
            //od.ShowDialog();
        }

        private void Od_actionBills(object sender, ActionBillsSuccessEventArgs e)
        {
            //throw new NotImplementedException();
            Load_Source();
            Load_Form();
        }

        //Xử lý trong form - tab Quản lý bàn
        //BanBUS tables = new BanBUS();
        //List<BanDTO> dsBan = new List<BanDTO>();
        

        

        

        private void QuanLyHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(constans.TB_Close())
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Reset_Click_1(object sender, EventArgs e)
        {
            ResetDS();
            Reset();
        }

        private void btn_Xem_Click_1(object sender, EventArgs e)
        {
            //foreach (HoaDonDTO hd in dshd)
            //{
            //    if (hd.maHD == tb_mahd.Text)
            //    {
            //        Order od = new Order(hd, hd.nv_LapHD);
            //        od.ShowDialog();
            //    }
            //}
        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn có chắc chắn xóa hóa đơn này?", "Thông Báo", MessageBoxButtons.OKCancel)
            //    == System.Windows.Forms.DialogResult.OK)
            //{
            //    if (OrderBUS.XoaHD(tb_mahd.Text))
            //    {
            //        MessageBox.Show("Đã xóa!");
            //        Reset();
            //        ResetDS();
            //    }
            //    else
            //        MessageBox.Show("Thất bại!");
            //}
        }

        private void datgv_HD_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //if (datgv_HD.SelectedCells.Count > 0 && dshd.Count() > 0)
            //{
            //    if (datgv_HD.SelectedCells[0].RowIndex < dshd.Count())
            //    {
            //        string mahd = datgv_HD.SelectedCells[0].OwningRow.Cells["col_mahd"].Value.ToString();
            //        foreach (HoaDonDTO hdD in dshd)
            //        {
            //            if (hdD.maHD == mahd)
            //            {
            //                tb_mahd.Text = hdD.maHD;
            //                tb_tenkh.Text = hdD.khachHang.tenKH;
            //                if (hdD.maKH.StartsWith("KHV"))
            //                    ckb_khv.Checked = true;
            //                else
            //                    ckb_khv.Checked = false;
            //                tb_sdt.Text = hdD.khachHang.sdt;
            //                tb_ngayLap.Text = hdD.ngayLap + "";
            //                tb_nvl.Text = NV.hoNV + " " + NV.tenNV;
            //                tb_TT.Text = hdD.tongThanhToan + "";
            //                break;
            //            }
            //        }
            //    }

            //}
        }

        private void rd_year_CheckedChanged_1(object sender, EventArgs e)
        {
            //if (rd_year.Checked == true)
            //{
            //    dshd.Clear();
            //    Load_DSHD(Dtpk_Find_nglap.Value, 1);
            //}
        }

        private void rd_month_CheckedChanged_1(object sender, EventArgs e)
        {
            //if (rd_month.Checked == true)
            //{
            //    dshd.Clear();
            //    Load_DSHD(Dtpk_Find_nglap.Value, 2);
            //}
        }

        private void rd_day_CheckedChanged_1(object sender, EventArgs e)
        {
            //if (rd_day.Checked == true)
            //{
            //    dshd.Clear();
            //    Load_DSHD(Dtpk_Find_nglap.Value, 3);
            //}
        }

        private void rd_today_CheckedChanged_1(object sender, EventArgs e)
        {
            //if (rd_day.Checked == true)
            //{
            //    dshd.Clear();
            //    Load_DSHD(DateTime.Now, 3);
            //}
        }        
    }
}
