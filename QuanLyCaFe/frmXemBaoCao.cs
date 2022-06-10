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
using Microsoft.Reporting.WinForms;


namespace QuanLyCaFe
{
    public partial class frmXemBaoCao : Form
    {
        public frmXemBaoCao()
        {
            InitializeComponent();
        }

        private void frmXemBaoCao_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        public void TatcaSP()
        {
            SanPhamBUS product = new SanPhamBUS();
            List<SanPhamDTO> lstSanPham = product.LayDSThucUong();

            //chọn report cho ReportViewer
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Report.rptAllSanPhamc.rdlc";

            //đổ dữ liệu 
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetProduct", lstSanPham));

            //hiện báo cáo 
            this.reportViewer1.RefreshReport();
        }
        public void TheoLoaiSanPham(BanDTO loai)
        {
            //lấy danh sách sản phẩm theo mã loại
            BanBUS ban = new BanBUS();
            List<BanDTO> lstSanPham = ban.layDSBan(0);

            //chọn report cho ReportViewer
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Report.rptAllSanPham.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();

            //đổ dữ liệu 
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetProduct", lstSanPham));

            //truyền giá trị cho parameter
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("paTenLoaiSanPham", loai.masoban));

            //hiện báo cáo 
            this.reportViewer1.RefreshReport();
        }
        public void HoaDon()
        {
            //lấy danh sách sản phẩm 
            SanPhamBUS product = new SanPhamBUS();
            List<SanPhamDTO> lstSanPham = product.LayDSThucUong();

            //chọn report cho ReportViewer
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Report.rptHoaDon.rdlc";

            //đổ dữ liệu 
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetProduct", lstSanPham));

            //truyền giá trị cho parameter
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("paNguoiLap", "<Tên người lập>"));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("paNgayLap", DateTime.Today.AddDays(-7).ToString()));//dl giả => lấy ngày tạo theo ngày hiện tại, thực tế lấy ngày từ csdl

            //hiện báo cáo 
            this.reportViewer1.RefreshReport();
        }
        public void NhomTheoLoai()
        {
            //lấy danh sách sản phẩm theo từng loại
            HoaDonBUS category = new HoaDonBUS();
            List<HoaDonDTO> lstLoaiSanPham = category.LayDSHD(DateTime.Now,1);

            //chọn report cho ReportViewer
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Report.rptSPhamGroup.rdlc";

            //gán phương thức xử lí sự kiện SubreportProcessing
            this.reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing);

            //đổ dữ liệu 
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetCategory", lstLoaiSanPham));

            //hiện báo cáo 
            this.reportViewer1.RefreshReport();
        }
        private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            //lấy mã loại từ parameter
            int maLoai = int.Parse(e.Parameters["@sanphamS"].Values[0]);

            //đổ dữ liệu
            SanPhamBUS product = new SanPhamBUS();
            e.DataSources.Add(new ReportDataSource("DataSetProduct", product.LaySP_Masp("")));
        }

    }
}
