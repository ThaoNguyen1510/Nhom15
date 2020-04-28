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
    public partial class FrmHoSoNV : Form
    {
        DataTable tbHSNV;
        public FrmHoSoNV()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        SqlConnection cnn = new SqlConnection("Data Source=localhost;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
        private void ketnoidl()
        {
            cnn.Open();
            string sql = "select * from HoSoNhanVien";
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
            sql = "select * from HoSoNhanVien";
            tbHSNV = Function.GetDataToTable(sql);
            dataGridView1.DataSource = tbHSNV;
            dataGridView1.Columns[0].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[1].HeaderText = "Họ tên";
            dataGridView1.Columns[2].HeaderText = "Ngày sinh";
            dataGridView1.Columns[3].HeaderText = "Số điện thoại";
            dataGridView1.Columns[4].HeaderText = "Địa chỉ";
            dataGridView1.Columns[5].HeaderText = "Giới tính";
            dataGridView1.Columns[6].HeaderText = "Mã chuyên môn";
            dataGridView1.Columns[7].HeaderText = "Mã tỉnh";
            dataGridView1.Columns[8].HeaderText = "Mã TĐVH";
            dataGridView1.Columns[9].HeaderText = "Mã dân tộc";
            dataGridView1.Columns[10].HeaderText = "Mã tôn giáo";
            dataGridView1.Columns[11].HeaderText = "Mã hôn nhân";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 300;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[0].Width = 500;
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
        private void FrmHoSoNV_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
            ketnoidl();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmaNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chuyên môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmaNhanVien.Focus();
                return;
            }
            if (txthoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập họ tên nhân viên", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txthoTen.Focus();
                return;
            }
            sql = "select maNV from HoSoNhanVien where maNV = N'" + txtmaNhanVien.Text.Trim() + "'";
            if (Function.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmaNhanVien.Focus();
                txtmaNhanVien.Text = "";
                return;
            }
            sql = "inset into HoSoNhanVien values(N'" + txtmaNhanVien.Text + "',N'" + txthoTen.Text + "',N'" + txtSdt.Text + "',N'" +
                txtngaySinh.Text + "',N'" + txtDiaChi.Text + "',N'" + txtGioiTinh.Text + "',N'" + txtMaChuyenMon.Text + "',N'" + txtMaTinh.Text + "',N'" +
                txtMaTDVH.Text + "',N'" + txtMaTonGiao.Text + "',N'" + txtMaDanToc.Text + "',N'" + txtMaHonNhan.Text + "')";
            Function.Runsql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtmaNhanVien.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbHSNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmaNhanVien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txthoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạnn phải nhập họ tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txthoTen.Focus();
                return;
            }
            if (txtSdt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạnn phải nhập số điện thoại của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSdt.Focus();
                return;
            }
            if (txtngaySinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạnn phải nhập ngày sinh của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtngaySinh.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạnn phải nhập vào địa chỉ của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (txtGioiTinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạnn phải nhập họ vào giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGioiTinh.Focus();
                return;
            }
            if (txtMaChuyenMon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạnn phải nhập mã chuyên môn của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChuyenMon.Focus();
                return;
            }
            if (txtMaDanToc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạnn phải nhập mã dân tộc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDanToc.Focus();
                return;
            }
            if (txtMaTDVH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập họ mã trình độ văn hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaTDVH.Focus();
                return;
            }
            if (txtMaTinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạnn phải nhập vào mã tỉnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaTinh.Focus();
                return;
            }
            if (txtMaTonGiao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào mã tôn giáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmaNhanVien.Focus();
                return;
            }
            if (txtMaHonNhan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạnn phải nhập vào mã hôn nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHonNhan.Focus();
                return;
            }
            sql = "update HoSoNhanVien set hoTen=N'" + txthoTen.Text.Trim().ToString() +
                    "',diaChi=N'" + txtDiaChi.Text.Trim().ToString() +
                    "',dienThoai='" + txtSdt.Text.ToString() + "',gioiTinh=N'" + txtGioiTinh.Text.Trim().ToString() +
                    "',ngaySinh='" + txtngaySinh.Text + "',maChuyenMon=N'" + txtMaChuyenMon.Text.Trim().ToString()+
                     "',maTinh=N'" + txtMaTinh.Text.Trim().ToString() + "',maTDVH=N'" + txtMaTDVH.Text.Trim().ToString() +
                      "',maDanToc=N'" + txtMaDanToc.Text.Trim().ToString() + "',maTonGiao=N'" + txtMaTonGiao.Text.Trim().ToString() +
                       "',maHonNhan=N'" + txtMaHonNhan.Text.Trim().ToString() +
                    "' WHERE maNV=N'" + txtmaNhanVien.Text + "'";
            Function.Runsql(sql);
            Load_DataGridView();
            ResetValues();
        }

        private void txthoTen_TextChanged(object sender, EventArgs e)
        {

        }
        private void ResetValues()
        {
            txtmaNhanVien.Text = "";
            txtMaChuyenMon.Text = "";
            txthoTen.Text = "";
            txtGioiTinh.Text = "";
            txtngaySinh.Text = "";
            txtSdt.Text = "";
            txtDiaChi.Text = "";
            txtMaTinh.Text = "";
            txtMaTDVH.Text = "";
            txtMaDanToc.Text = "";
            txtMaTonGiao.Text = "";
            txtMaHonNhan.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmaNhanVien.Focus();
                return;
            }
            if (tbHSNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmaNhanVien.Text = dataGridView1.CurrentRow.Cells["maNV"].Value.ToString();
            txthoTen.Text = dataGridView1.CurrentRow.Cells["hoTen"].Value.ToString();
            txtngaySinh.Text = dataGridView1.CurrentRow.Cells["ngaySinh"].Value.ToString();
            txtSdt.Text = dataGridView1.CurrentRow.Cells["dienThoai"].Value.ToString();
            txtDiaChi.Text = dataGridView1.CurrentRow.Cells["diaChi"].Value.ToString();
            txtGioiTinh.Text = dataGridView1.CurrentRow.Cells["gioiTinh"].Value.ToString();
            txtMaChuyenMon.Text = dataGridView1.CurrentRow.Cells["maChuyenMon"].Value.ToString();
            txtMaTinh.Text = dataGridView1.CurrentRow.Cells["maTinh"].Value.ToString();
            txtMaTDVH.Text = dataGridView1.CurrentRow.Cells["maTDVH"].Value.ToString();
            txtMaDanToc.Text = dataGridView1.CurrentRow.Cells["maDanToc"].Value.ToString();
            txtMaHonNhan.Text = dataGridView1.CurrentRow.Cells["maHonNhan"].Value.ToString();
            txtMaTonGiao.Text = dataGridView1.CurrentRow.Cells["maTonGiao"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbHSNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmaNhanVien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("bạn có muốn xóa không?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete HoSoNhanVien where maNhanVien=N'" + txtmaNhanVien.Text + "'";
                Function.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            ResetValues();
            txtmaNhanVien.Enabled = true;
            txtmaNhanVien.Focus();
        }
    }
}
