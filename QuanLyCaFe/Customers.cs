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
    public partial class Customers : Form
    {
        public UserModel user;
        public PCustomerModel customerFocus;

        List<PCustomerModel> listCustomer = null;
        BindingSource bs = new BindingSource();

        public Customers()
        {
            InitializeComponent();
            dtgv_listCustomer.AutoGenerateColumns = false;
            Load_Form();
        }
        public Customers(UserModel user)
        {
            InitializeComponent();
            this.user = user;
            dtgv_listCustomer.AutoGenerateColumns = false;
            Load_Form();

        }

        #region Load

        private void Load_Form()
        {
            
            Load_DSKH();
        }

        private void Load_DSKH()
        {
            customerFocus = null;
            listCustomer = PCustomer.SelectSkipAndTakeDynamicWhere(null, null,null, null, null, null, null, null, null, null, null, null, false, null, 10, 0, "Id desc");
            if (listCustomer != null)
            {

            }
            else
                listCustomer = new List<PCustomerModel>();

            bs.DataSource = listCustomer.ToList();
            dtgv_listCustomer.DataSource = bs;
            dtgv_listCustomer.Refresh();

        }

        #endregion

        #region Event

        #region Get data from object
        private PCustomerModel layTTKH_moi()
        {
            PCustomerModel NewKH = new PCustomerModel();
            NewKH.Code = "";
            NewKH.Name = string.IsNullOrEmpty(tb_tenkh.Text) ? "" : tb_tenkh.Text;
            NewKH.Birth = date_birth.Value.Date;
            NewKH.Phone = string.IsNullOrEmpty(tb_sdt.Text) ? "" : tb_sdt.Text;
            NewKH.Address = string.IsNullOrEmpty(txt_diachi.Text) ? "" : txt_diachi.Text;

            NewKH.Point = 0;
            NewKH.CreatedDate = DateTime.Now;
            NewKH.ModifiedDate = DateTime.Now;
            NewKH.CreatedUserId = user.Id;
            NewKH.ModifiedUserId = user.Id;
            NewKH.Status = 0;
            NewKH.IsDeleted = false;

            return NewKH;
        }

        private PCustomerModel layTTKH_change()
        {
            PCustomerModel NewKH = new PCustomerModel();
            NewKH.Id = customerFocus.Id;
            NewKH.Code = customerFocus.Code;
            NewKH.Name = string.IsNullOrEmpty(tb_tenkh.Text) ? "" : tb_tenkh.Text;
            NewKH.Birth = date_birth.Value.Date;
            NewKH.Phone = string.IsNullOrEmpty(tb_sdt.Text) ? "" : tb_sdt.Text;
            NewKH.Address = string.IsNullOrEmpty(txt_diachi.Text) ? "" : txt_diachi.Text;

            NewKH.Point = (int) point.Value;
            NewKH.CreatedDate = customerFocus.CreatedDate;
            NewKH.ModifiedDate = DateTime.Now;
            NewKH.CreatedUserId = customerFocus.CreatedUserId;
            NewKH.ModifiedUserId = user.Id;
            NewKH.Status = customerFocus.Status;
            NewKH.IsDeleted = customerFocus.IsDeleted;

            return NewKH;
        }

        private bool checkedData()
        {
            if (string.IsNullOrEmpty(tb_tenkh.Text))
                return false;
            if (string.IsNullOrEmpty(tb_sdt.Text))
                return false;
            
            return true;
        }
        #endregion

        private void btn_dk_Click(object sender, EventArgs e)
        {
            if(checkedData())
            {
                PCustomerModel kh = layTTKH_moi();
                int a = PCustomer.Insert(kh);
                Load_Form();
            }
            
        }

        private void dtgv_ttkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_listCustomer.SelectedCells.Count > 0)
            {
                if (dtgv_listCustomer.SelectedCells[0].RowIndex < listCustomer.Count())
                {
                    int Id = (int) dtgv_listCustomer.SelectedCells[0].OwningRow.Cells["Id"].Value;
                    foreach (PCustomerModel kh in listCustomer)
                    {
                        if (kh.Id == Id)
                        {
                            customerFocus = kh;
                            tb_tenkh.Text = kh.Name;
                            tb_sdt.Text = kh.Phone;
                            txt_diachi.Text = kh.Address;
                            date_birth.Value = kh.Birth == null ? DateTime.Now : kh.Birth.Value.Date;
                            point.Value = kh.Point == null ? 0 : kh.Point.Value;
                            
                            break;
                        }
                    }
                }
            }
        }

        


        private void btn_update_Click(object sender, EventArgs e)
        {
            if (checkedData())
            {
                PCustomerModel kh = layTTKH_change();
                PCustomer.Update(kh);
                Load_Form();
            }
        }

        private bool checkDelete(int Id)
        {
            return PBill.checkExistCustomer(Id) ? false : true;
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            if (customerFocus == null)
            {
                return;
            }
            else
            {
                if(!checkDelete(customerFocus.Id))
                {
                    return;
                }
                customerFocus.IsDeleted = true;
                PCustomer.Update(customerFocus);
                Load_Form();
            }
        }
        #endregion


        #region Event system

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

        #endregion

       
    }
}
