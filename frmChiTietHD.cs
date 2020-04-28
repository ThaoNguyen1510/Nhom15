using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Nhom15;

namespace Nhom15
{
    public partial class frmChiTietHD : Form
    {
        DataTable tbCTHD;
        public frmChiTietHD()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnExitCTHD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        SqlConnection cnn = new SqlConnection("Data Source=localhost;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
        private void ketnoidl()
        {
            cnn.Open();
            string sql = "select * from ChiTietHopDongLaoDong";
            SqlCommand com = new SqlCommand(sql, cnn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            dataGridView1.DataSource = dt;
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "select * from ChiTietHopDongLaoDong";
            tbCTHD = Function.GetDataToTable(sql);
            dataGridView1.DataSource = tbCTHD;
            dataGridView1.Columns[0].HeaderText = "Mã số hợp đồng ";
            dataGridView1.Columns[1].HeaderText = "Mã lần hợp đồng";
            dataGridView1.Columns[2].HeaderText = "Mã loại họp đồng";
            dataGridView1.Columns[3].HeaderText = "Ngày HD";
            dataGridView1.Columns[4].HeaderText = "Ngày KT";
            dataGridView1.Columns[5].HeaderText = "Mã phòng ban";
            dataGridView1.Columns[6].HeaderText = "Mã chức vụ";
            dataGridView1.Columns[7].HeaderText = "Mức lương";
            dataGridView1.Columns[8].HeaderText = "Ăn trưa";
            dataGridView1.Columns[9].HeaderText = "Tổng lương";
            dataGridView1.Columns[10].HeaderText = "Người kí";
            dataGridView1.Columns[11].HeaderText = "Mã chức vụ (Người kí)";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            txtMaHD.Text = "";
            txtMaLoaiHD.Text = "";
            txtMaLanHD.Text = "";
            txtNgayHD.Text = "";
            txtNgayKT.Text = "";
            txtMaPB.Text = "";
            txtMaCV.Text = "";
            txtMucLuong.Text = "";
            txtAnTrua.Text = "";
            txtTongLuong.Text = "";
            txtNguoiKi.Text = "";
            txtMaCVNguoiKi.Text = "";
        }
  
        private void frmChiTietHD_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
            ketnoidl();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã số hợp đồng lao động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHD.Focus();
                return;
            }
            if (txtMaLanHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào mã lần hợp đồng", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLanHD.Focus();
                return;
            }
            if (txtMaLoaiHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào mã loại hợp đồng", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLoaiHD.Focus();
                return;
            }
            if (txtMaPB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào mã phòng ban", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPB.Focus();
                return;
            }
            if (txtMaCV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào mã chức vụ", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaCV.Focus();
                return;
            }
            if (txtMaCVNguoiKi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào mã chức vụ của người kí", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaCVNguoiKi.Focus();
                return;
            }
            sql = "select maSoHopDongLaoDong from ChiTietHopDonglaoDong where maNV = N'" + txtMaHD.Text.Trim() + "'";
            if (Function.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHD.Focus();
                txtMaHD.Text = "";
                return;
            }
            sql = "inset into ChiTietHopDongLaoDong values(N'" + txtMaHD.Text + "',N'" + txtMaLanHD.Text + "',N'" + txtMaLoaiHD.Text + "',N'" +
                txtNgayHD.Text + "',N'" + txtNgayKT.Text + "',N'" + txtMaPB.Text + "',N'" + txtMaCV.Text + "',N'" + txtMucLuong.Text + "',N'" +
                txtAnTrua.Text + "',N'" + txtTongLuong.Text + "',N'" + txtNguoiKi.Text + "',N'" + txtMaCVNguoiKi.Text + "')";
            Function.Runsql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaHD.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHD.Focus();
                return;
            }
            if (tbCTHD.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaHD.Text = dataGridView1.CurrentRow.Cells["maSoHopDongLaoDong"].Value.ToString();
            txtMaLanHD.Text = dataGridView1.CurrentRow.Cells["maLanHD"].Value.ToString();
            txtMaLoaiHD.Text = dataGridView1.CurrentRow.Cells["maLHD"].Value.ToString();
            txtNgayHD.Text = dataGridView1.CurrentRow.Cells["ngayHD"].Value.ToString();
            txtNgayKT.Text = dataGridView1.CurrentRow.Cells["ngayKT"].Value.ToString();
            txtMaPB.Text = dataGridView1.CurrentRow.Cells["maPhongBan"].Value.ToString();
            txtMaCV.Text = dataGridView1.CurrentRow.Cells["maChucVu"].Value.ToString();
            txtMucLuong.Text = dataGridView1.CurrentRow.Cells["mucLuong"].Value.ToString();
            txtAnTrua.Text = dataGridView1.CurrentRow.Cells["anTrua"].Value.ToString();
            txtTongLuong.Text = dataGridView1.CurrentRow.Cells["tongLuong"].Value.ToString();
            txtNguoiKi.Text = dataGridView1.CurrentRow.Cells["nguoiKi"].Value.ToString();
            txtMaCVNguoiKi.Text = dataGridView1.CurrentRow.Cells["maChucVuNguoiKi"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            ResetValues();
            txtMaHD.Enabled = true;
            txtMaHD.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbCTHD.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaLanHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạnn phải nhập vào mã lần hợp đồng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLanHD.Focus();
                return;
            }
            if (txtMaLoaiHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạnn phải nhập vào mã loại hợp đồng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLoaiHD.Focus();
                return;
            }
            if (txtNgayHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạnn phải nhập ngày bắt đầu hợp đồng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgayHD.Focus();
                return;
            }
            if (txtNgayKT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạnn phải nhập vào ngày kết toán hợp đồng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgayKT.Focus();
                return;
            }
            if (txtMaPB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạnn phải nhập họ vào mã phòng ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPB.Focus();
                return;
            }
            if (txtMaCV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạnn phải nhập mã chức vụ của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaCV.Focus();
                return;
            }
            if (txtMucLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạnn phải nhập vào mức lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMucLuong.Focus();
                return;
            }
            if (txtAnTrua.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập họ tiền ăn trưa của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnTrua.Focus();
                return;
            }
            if (txtMaCVNguoiKi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào mã chức vụ của người kí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaCVNguoiKi.Focus();
                return;
            }
            if (txtNguoiKi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạnn phải nhập vào họ tên người kí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNguoiKi.Focus();
                return;
            }
            sql = "update ChiTietHopDongLaoDong set nguoiKi=N'" + txtNguoiKi.Text.Trim().ToString() +
                    "',maLanHD=N'" + txtMaLanHD.Text.Trim().ToString() +
                    "',maLoaiHD='" + txtMaLoaiHD.Text.ToString() + "',ngayHD=N'" + txtNgayHD.Text.Trim().ToString() +
                    "',ngayKT='" + txtNgayKT.Text + "',maPhongBan=N'" + txtMaPB.Text.Trim().ToString() +
                     "',maChucVu=N'" + txtMaCV.Text.Trim().ToString() + "',mucLuong=N'" + txtMucLuong.Text.Trim().ToString() +
                      "',anTrua=N'" + txtAnTrua.Text.Trim().ToString() + "',tongLuong=N'" + txtTongLuong.Text.Trim().ToString() +
                       "',maChucVuNguoiKi=N'" + txtMaCVNguoiKi.Text.Trim().ToString() +
                    "' WHERE maSoHopDongLaoDong=N'" + txtMaHD.Text + "'";
            Function.Runsql(sql);
            Load_DataGridView();
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbCTHD.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("bạn có muốn xóa không?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete ChiTietHopDongLaoDong where maSoHopDongLaoDong=N'" + txtMaHD.Text + "'";
                Function.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }
        public class LuuThongTin
        {
            static public string TongLuong;
        }
        private void txtTongLuong_TextChanged(object sender, EventArgs e)
        {
            string a, b, h;
            int c, d, g, f;
            a = frmChucVu.LuuTT.PCCV;
            c = Convert.ToInt32(a);
            d = Convert.ToInt32(txtAnTrua.Text);
            g = Convert.ToInt32(txtMucLuong.Text);
            f = c + g + d;
            h = f.ToString();
            txtTongLuong.Text = h;
            LuuThongTin.TongLuong = txtTongLuong.Text;
            frmChiTietBHXH f1 = new frmChiTietBHXH();
            frmChiTietBHYT f2 = new frmChiTietBHYT();
        }
    }
}
