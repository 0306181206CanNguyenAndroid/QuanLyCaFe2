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

namespace QuanLyCafe
{    
    public partial class Order : Form
    {
        public event FireEventForActionBillsSuccess actionBills = null;

        public UserModel user { get; set; }
        PBillModel bill = new PBillModel();
        SystemStaffModel staff = null;
        List<PProductModel> listOrder = new List<PProductModel>();
        BindingSource bs = new BindingSource();

        public Order()
        {
            InitializeComponent();
            Cb_Product_Load(1);
            dtgv_listOrder.AutoGenerateColumns = false;
        }

        public Order(UserModel user)
        {
            InitializeComponent();
            this.user = user;
            staff = SystemStaff.SelectByUserId(user.Id);
            tb_Staff.Text = staff == null ? user.Name : staff.FullName;
            Cb_ProductType_Load();
            var productTypeId =((PProducttypeModel)cb_ProductType.SelectedItem).Id;
            Cb_Product_Load(productTypeId);
            dtgv_listOrder.AutoGenerateColumns = false;
            this.user = user;
            FormOther_Load();
        }

        #region Load

        private void Cb_Product_Load(int productTypeId)
        {
            List<PProductModel> lsp = PProduct.SelectAllDynamicWhere(null, null, null, null, productTypeId, null, null, null, null, null, null, null, null, null);
            if (lsp != null)
            {
                cb_product.DataSource = lsp.ToList();
                cb_product.DisplayMember = "Name";
                cb_product.ValueMember = "Id";
                cb_product.SelectedValue = lsp[0].Id;
                ReadProductPrice(lsp[0].Price, lsp[0].Discount);
            }
            else 
            { 
                cb_product.DataSource = new List<PProductModel>();
                tb_Price.Text = "0.0";
            }
        }

        private void Cb_ProductType_Load()
        {
            List<PProducttypeModel> lsp = PProducttype.SelectPProducttypeDropDownListData();
            if (lsp != null)
            {
                cb_ProductType.DataSource = lsp.ToList();
                cb_ProductType.DisplayMember = "Name";
                cb_ProductType.ValueMember = "Id";
                cb_ProductType.SelectedValue = lsp[0].Id;
            }
            else cb_ProductType.DataSource = new List<PProducttypeModel>();
        }

        private void taoSource()
        {
            //listOrder.Clear();
            bs.DataSource = listOrder.ToList();
            dtgv_listOrder.DataSource = bs;
        }

        private void FormOther_Load()
        {
            btn_create.Enabled = true;
            btn_del.Enabled = false;

            //nrud_Sales.Value = HD.khachHang.point / 10;
            SetTotalPrice();
            Load_Ban(1);
            Load_NV();
            Load_KH();
            //tb_BillCode.Text = generated_B();
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

        private void dtgv_Load()
        {
            dtgv_listOrder.AutoGenerateColumns = false;
        }

        private void Load_Ban(int kind)
        {
            //cb_Ban.DataSource = banBUS.layDSBan(kind);
            //cb_Ban.DisplayMember = "MaSoBan";
            //cb_Ban.ValueMember = "MaSoBan";
        }

        private void Load_NV()
        {
        }

        private void Load_KH()
        {
            //cb_sdtKHV.DataSource = khachHangBUS.LayDskh().ToList();
            //cb_sdtKHV.DisplayMember = "sdt";
            //cb_sdtKHV.ValueMember = "maKH";
        }

        #endregion

        #region Event

        #region Admin
        #endregion

        #region Manage
        #endregion

        #region Staff

        

        

        private void cb_LoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            var productTypeId = ((PProducttypeModel)cb_ProductType.SelectedItem).Id;
            Cb_Product_Load(productTypeId);
        }



        private void btn_Them_Click(object sender, EventArgs e)
        {
            
            PProductModel productSelect = (PProductModel)cb_product.SelectedItem;
            if (productSelect == null)
                return;
            decimal realPrice = Convert.ToDecimal(tb_Price.Text);
            int quantity = (int)nbud_quantity.Value;
            bool fl = false;
            foreach (PProductModel a in listOrder)
            {
                if (productSelect.Id == a.Id)
                {
                    fl = true;
                    a.Quantity = a.Quantity + quantity;
                    break;
                }
            }
            if (fl == false)
            {
                PProductModel sp = new PProductModel();
                sp.Id = productSelect.Id;
                sp.Name = productSelect.Name;
                sp.ProductTypeId = productSelect.ProductTypeId;
                sp.RealPrice = realPrice;
                sp.Quantity = quantity;
                sp.Price = productSelect.Price;
                sp.Discount = productSelect.Discount;
                listOrder.Add(sp);
            }
            taoSource();
            SetTotalPrice();
        }

        private void btn_Loaibo_Click(object sender, EventArgs e)
        {

            if (dtgv_listOrder.SelectedCells.Count > 0)
            {
                string id = dtgv_listOrder.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString();
                var Id = Convert.ToInt32(id);
                foreach (PProductModel sp in listOrder)
                {
                    if (sp.Id == Id)
                    {
                        listOrder.Remove(sp);
                        break;
                    }
                }
                taoSource();
                SetTotalPrice();
            }
        }

        private void SetTotalPrice()
        {
            decimal total = 0, sales = (int)nrud_Sales.Value;
            if (listOrder.Count() > 0)
            {
                foreach (PProductModel sp in listOrder)
                {
                    total += sp.RealPrice * sp.Quantity;
                }
                tb_TotalPrice.Text = "" + (total / 100 * (100 - sales));

            }
            else
                tb_TotalPrice.Text = "0";
        }

        private void cb_Sanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sp = (PProductModel)cb_product.SelectedItem;
            ReadProductPrice(sp.Price, sp.Discount);
        }

        private void cb_Ban_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void bt_create_Click(object sender, EventArgs e)
        {
            if (listOrder.Count() > 0)
            {
                PBillModel hoaDon = new PBillModel();
                hoaDon.listBillDetail = GetBillDetailFromListProduct(listOrder);
                hoaDon.CreatedDate = DateTime.Now;
                //hoaDon.soban = new BanDTO();
                hoaDon.CustomerId = null;
                hoaDon.CreatedUserId = user.Id;
                hoaDon.IsDeleted = false;
                hoaDon.TotalPrice = Convert.ToDecimal(tb_TotalPrice.Text);
                hoaDon.Status = 0;
                //hoaDon.TableCode;
                //hoaDon.DiscountVip
                hoaDon.DeliveryAddress = "";

                int kq = PBill.InsertBill(hoaDon);
                //if (ckb_OrderFrom.Checked == false)
                //{
                    
                //}
                //else
                //{
                    
                //}
                //bool kq = hoaDonBUS.themHD(hoaDon);
                //constans.TB_ThanhToan(kq);
                if (kq == 1)
                {
                    if (actionBills != null)
                    {
                        actionBills(this, new ActionBillsSuccessEventArgs { });
                    }
                    listOrder.Clear();
                    FormOther_Load();
                }



            }
        }

        private List<PBilldetailModel> GetBillDetailFromListProduct(List<PProductModel> l)
        {
            List<PBilldetailModel> listBillDetail = new List<PBilldetailModel>();
            if(l != null && l.Count > 0)
            {
                foreach(PProductModel sp in l)
                {
                    PBilldetailModel billDetail = new PBilldetailModel();
                    billDetail.IsDeleted = false;
                    billDetail.ProductId = sp.Id;
                    billDetail.Quantity = sp.Quantity;
                    billDetail.DiscountProduct = sp.Discount;
                    billDetail.DiscountPrice = sp.RealPrice * sp.Quantity;
                    billDetail.CreatedDate = DateTime.Now;
                    billDetail.ModifiedDate = DateTime.Now;
                    billDetail.CreatedUserId = user.Id;
                    billDetail.UnitPrice = sp.Price;
                    billDetail.Status = 0;
                    listBillDetail.Add(billDetail);
                }
            }

            return listBillDetail;
        }

        private void ckB_kh_CheckedChanged(object sender, EventArgs e)
        {
            //if (ckB_kh.Checked == true)
            //{
            //    nrud_Sales.Enabled = true;
            //    Load_KH();
            //}
            //else
            //{
            //    cb_sdtKHV.DataSource = null;
            //    nrud_Sales.Enabled = false;
            //    nrud_Sales.Value = 0;
            //}
        }

        private void nrud_Sales_ValueChanged(object sender, EventArgs e)
        {
            SetTotalPrice();
        }


        private void dtgv_listOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_listOrder.SelectedCells.Count > 0
                && dtgv_listOrder.SelectedCells[0].RowIndex < listOrder.Count())
            {
                string id = dtgv_listOrder.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString();
                if (id != null && id != "")
                {
                    var Id = Convert.ToInt32(id);
                    foreach (PProductModel sp in listOrder)
                    {
                        if (sp.Id == Id)
                        {
                            cb_ProductType.SelectedValue = sp.ProductTypeId.Value;
                            cb_product.SelectedValue = sp.Id;
                            tb_Price.Text = sp.Price + "";
                            nbud_quantity.Value = sp.Quantity;
                            break;
                        }
                    }
                    taoSource();
                    //SetTotalPrice();
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

        #endregion

        #endregion
        private void ReadProductPrice(decimal? price, int? discount)
        {
            decimal realprice = price == null ? 0 : (price.Value - (price.Value * (discount == null ? 0 : discount.Value)) / 100);
            tb_Price.Text = realprice + "";
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

        private void Order_Load(object sender, EventArgs e)
        {

        }
    }
}
