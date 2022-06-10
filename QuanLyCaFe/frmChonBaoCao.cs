using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCaFe
{
    public partial class frmChonBaoCao : Form
    {
        public frmChonBaoCao()
        {
            InitializeComponent();
        }

        private void Setting()
        {
            rdbAllSP.Checked = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmXemBaoCao fSRP = new frmXemBaoCao();
            if(rdbAllSP.Checked==true)
            {
                fSRP.TatcaSP();
                fSRP.ShowDialog();
                
            }
            else if(rdbHoaDon.Checked==true)
            {
                fSRP.ShowDialog();
                fSRP.TatcaSP();
            }
            else if(rdbNhomSP.Checked==true)
            {
                fSRP.ShowDialog();
                fSRP.TatcaSP();
            }
            else
            {
                fSRP.ShowDialog();
                fSRP.TatcaSP();
            }
        }
    }
}
