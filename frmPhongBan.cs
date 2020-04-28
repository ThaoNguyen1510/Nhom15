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
    public partial class frmPhongBan : Form
    {
        DataTable tbPgBan;
        public frmPhongBan()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExitPB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection cnn = new SqlConnection("Data Source=localhost;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
        private void ketnoidl()
        {
            cnn.Open();
            string sql = "select * from PhongBan";
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
            sql = "select * from PhongBan";

            dataGridView1.DataSource = tbPgBan;
            dataGridView1.Columns[0].HeaderText = "Mã phòng ban";
            dataGridView1.Columns[1].HeaderText = "Tên phòng ban";
            dataGridView1.Columns[2].HeaderText = "Địa chỉ";
            dataGridView1.Columns[3].HeaderText = "Số điện thoại";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 500;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            txtMaPB.Text = "";
            txtTenPB.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }
        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
            ketnoidl();
        }
 
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sqlinsert = "insert into PhongBan values (N'" + txtMaPB.Text.Trim() + "', N'" + txtTenPB.Text.Trim().ToString()
                + "',N'" + txtDiaChi.Text.Trim().ToString() + "',N'" + txtSDT.Text.Trim().ToString() + "')";
            if (txtMaPB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào mã phòng ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPB.Focus();
                return;
            }
            if (txtTenPB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào tên phòng ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPB.Focus();
                return;
            }
            Function.Runsql(sqlinsert);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnExitPB.Enabled = true;
            btnLuu.Enabled = false;
            txtMaPB.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnLuu.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaPB.Focus();
                return;
            }
            if (tbPgBan.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaPB.Text = dataGridView1.CurrentRow.Cells["maPhongBan"].Value.ToString();
            txtTenPB.Text = dataGridView1.CurrentRow.Cells["tenPhongBan"].Value.ToString();
            txtDiaChi.Text = dataGridView1.CurrentRow.Cells["diachi"].Value.ToString();
            txtSDT.Text = dataGridView1.CurrentRow.Cells["dienthoai"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnExitPB.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            ResetValues();
            txtMaPB.Enabled = true;
            txtMaPB.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbPgBan.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaPB.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenPB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào tên phòng ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPB.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào địa chỉ của phòng ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào số điện thoại của phòng ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            sql = "update PhongBan set maPhongBan = N'" + txtMaPB.Text.ToString() + "', tenPhongBan = N'" + txtTenPB.Text.Trim().ToString() +
                "', diachi = N'" + txtDiaChi.Text.Trim().ToString() + "', dienthoai = N'" + txtSDT.Text.Trim().ToString() + "')";
            Function.Runsql(sql);
            Load_DataGridView();
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbPgBan.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaPB.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("bạn có muốn xóa không?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete PhongBan where maSoBHYT=N'" + txtMaPB.Text + "'";
                Function.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }
    }
}
