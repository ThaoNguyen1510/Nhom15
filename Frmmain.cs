using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom15
{
    public partial class Frmmain : Form
    {
        public Frmmain()
        {
            InitializeComponent();
        }

        private void chiTiếtToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hồSơNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHoSoNV fmnv = new FrmHoSoNV();
            fmnv.Show();

        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhongBan fmpb = new frmPhongBan();
            fmpb.Show();
        }

        private void chuyênMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChuyenMon fmcm = new frmChuyenMon();
            fmcm.Show();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChucVu fmcv = new frmChucVu();
            fmcv.Show();
        }
    }
}
