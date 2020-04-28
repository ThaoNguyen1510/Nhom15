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
    public partial class frmChiTietBHYT : Form
    {
        DataTable tblCTBHYT;
        public frmChiTietBHYT()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlinsert = "insert into ChiTietDongBHYT(maSoBHYT, maLanDong, BaoHiemThang, Nam, ngaydong, sotien) values (N'" + txtMasoBHYT.Text.Trim() + "', N'" + txtmaLanDong.Text.Trim().ToString()
                + "',N'" + txtThang.Text.Trim().ToString() + "',N'" + txtNam.Text.Trim().ToString() + "',N'" + txtNgayDong.Text.Trim().ToString() + "',N'" + txtSoTien.Text.Trim() + "')";
            if (txtMasoBHYT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào mã sổ BHYT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMasoBHYT.Focus();
                return;
            }
            if (txtmaLanDong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã lần đóng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmaLanDong.Focus();
                return;
            }
            Function.Runsql(sqlinsert);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThoat.Enabled = true;
            btnLuu.Enabled = false;
            txtMasoBHYT.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnLuu.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMasoBHYT.Focus();
                return;
            }
            if (tblCTBHYT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMasoBHYT.Text = dataGridView1.CurrentRow.Cells["MaSoBHYT"].Value.ToString();
            txtmaLanDong.Text = dataGridView1.CurrentRow.Cells["maLanDong"].Value.ToString();
            txtThang.Text = dataGridView1.CurrentRow.Cells["BaoHiemThang"].Value.ToString();
            txtNam.Text = dataGridView1.CurrentRow.Cells["Nam"].Value.ToString();
            txtNgayDong.Text = dataGridView1.CurrentRow.Cells["ngaydong"].Value.ToString();
            txtSoTien.Text = dataGridView1.CurrentRow.Cells["sotien"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThoat.Enabled = true;
        }

        public void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            string a, d;
            int b, c;
            a = frmChiTietHD.LuuThongTin.TongLuong;
            b = Convert.ToInt32(a);
            c = b * 5 / 100;
            d = c.ToString();
            txtSoTien.Text = d;
        }
        SqlConnection cnn = new SqlConnection("Data Source=localhost;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
        private void ketnoidl()
        {
            cnn.Open();
            string sql = "select * from ChiTietDongBHYT";
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
            sql = "select * from ChiTietDongBHXH";

            dataGridView1.DataSource = tblCTBHYT;
            dataGridView1.Columns[0].HeaderText = "Mã sổ BHYT";
            dataGridView1.Columns[1].HeaderText = "Mã lần đóng";
            dataGridView1.Columns[2].HeaderText = "bảo hiểm tháng";
            dataGridView1.Columns[3].HeaderText = "Năm";
            dataGridView1.Columns[4].HeaderText = "Ngày đóng";
            dataGridView1.Columns[5].HeaderText = "Số tiền";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            txtMasoBHYT.Text = "";
            txtmaLanDong.Text = "";
            txtThang.Text = "";
            txtNgayDong.Text = "";
            txtNam.Text = "";
            txtSoTien.Text = "";
        }
        private void frmChiTietBHYT_Load(object sender, EventArgs e)
        {
            txtMasoBHYT.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;
            Load_DataGridView();
            ketnoidl();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            ResetValues();
            txtMasoBHYT.Enabled = true;
            txtMasoBHYT.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCTBHYT.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMasoBHYT.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmaLanDong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã lần đóng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmaLanDong.Focus();
                return;
            }
            if (txtThang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào tháng đóng bảo hiểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThang.Focus();
                return;
            }
            if (txtNam.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào năm đóng bảo hiểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNam.Focus();
                return;
            }
            if (txtNgayDong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào ngày đóng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgayDong.Focus();
                return;
            }
            if (txtSoTien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào số tiền bảo hiểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTien.Focus();
                return;
            }
            sql = "update ChiTietDongBHYT set maLanDong = N'" + txtmaLanDong.Text.ToString() + "', BaoHiemThang = N'" + txtThang.Text.Trim().ToString() +
                "', Nam = N'" + txtNam.Text.Trim().ToString() + "', ngaydong = N'" + txtNgayDong.Text.Trim().ToString() + "', sotien = N'" + txtSoTien.Text.Trim().ToString() +
                "' where maSoBHYT=N'" + txtMasoBHYT.Text + "'";
            Function.Runsql(sql);
            Load_DataGridView();
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCTBHYT.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMasoBHYT.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("bạn có muốn xóa không?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete ChiTietDongBHYT where maSoBHYT=N'" + txtMasoBHYT.Text + "'";
                Function.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }
    }
}
