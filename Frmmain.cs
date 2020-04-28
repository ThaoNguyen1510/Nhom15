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
            frmChiTietBHYT fmctyt = new frmChiTietBHYT();
            fmctyt.Show();
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

        private void hợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHopDong fmhd = new frmHopDong();
            fmhd.Show();
        }

        private void loạiHợpĐôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiHD fml = new frmLoaiHD();
            fml.Show();
        }

        private void chiTiếtHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChiTietHD fmct = new frmChiTietHD();
            fmct.Show();
        }

        private void sổBHXHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSoBHXH fms = new frmSoBHXH();
            fms.Show();
        }

        private void chiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChiTietBHXH fmctbhxh = new frmChiTietBHXH();
            fmctbhxh.Show();
        }

        private void sổBHYTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSoBHYT fmyt = new frmSoBHYT();
            fmyt.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmmain_Load(object sender, EventArgs e)
        {
            Function.Connect();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Function.Disconnect();
            this.Close();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiem fmtk = new frmTimKiem();
            fmtk.Show();
        }
    }
}
