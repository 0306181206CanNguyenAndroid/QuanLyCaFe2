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

namespace QuanLyCafe
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            dtgv_ttkh.AutoGenerateColumns = false;
            Load_Form();
        }
        //KhachHangBUS customerBUS = new KhachHangBUS();
        //BindingSource bs = new BindingSource();
        //List<KhachHangDTO> dskh = new List<KhachHangDTO>();

        private void Load_Form()
        {
            Load_DSKH();
        }

        private void Load_DSKH()
        {            
            //dskh = customerBUS.LayDskh();
            //bs.DataSource = dskh.ToList();
            //dtgv_ttkh.DataSource = bs;
        }

        private void dtgv_ttkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dtgv_ttkh.SelectedCells.Count > 0)
            //{
            //    if(dtgv_ttkh.SelectedCells[0].RowIndex < dskh.Count())
            //    {
            //        string sdt = dtgv_ttkh.SelectedCells[0].OwningRow.Cells["col_sdt"].Value.ToString();

            //        foreach (KhachHangDTO kh in dskh)
            //        {
            //            if (kh.sdt == sdt)
            //            {
            //                tb_makh.Text = kh.maKH;
            //                tb_tenkh.Text = kh.tenKH;
            //                tb_sdt.Text = kh.sdt;
            //                tb_point.Text = kh.point + "";
            //                break;
            //            }
            //        }
            //    }
            //}
        }

        private PCustomerModel layTTKH_moi()
        {
            PCustomerModel NewKH = new PCustomerModel();
            //NewKH.maKH = string.IsNullOrEmpty(tb_makh.Text) ? "" : tb_makh.Text;
            //NewKH.tenKH = string.IsNullOrEmpty(tb_tenkh.Text) ? "" : tb_tenkh.Text;
            //NewKH.sdt = string.IsNullOrEmpty(tb_sdt.Text) ? "" : tb_sdt.Text;
            //NewKH.xoaKH = 1;

            return NewKH;
        }

        private void btn_dk_Click(object sender, EventArgs e)
        {
            //KhachHangDTO khAdd = layTTKH_moi();
            //if (khAdd.tenKH == "" || khAdd.sdt == "")
            //{
            //    constans.TB_ThieuTT();
            //    return;
            //}

            //bool kq = customerBUS.DKKH(khAdd);

            //constans.TB_KQ(kq);
            Load_Form();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //KhachHangDTO khEdit = layTTKH_moi();
            //khEdit.point = Convert.ToInt32(tb_point.Text);

            //bool kq = customerBUS.UpdateKH(khEdit);
            //constans.TB_KQ(kq);
            Load_Form();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(tb_makh.Text))
            //{
            //    return;
            //}
            //else
            //{
            //    string MAKH = tb_makh.Text;
            //    int kq = customerBUS.DelKH(MAKH);
            //    constans.TB_XoaKH(kq);
            //    Load_Form();
            //}
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Customers_FormClosing(object sender, FormClosingEventArgs e)
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
