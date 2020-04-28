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
    public partial class frmSoBHXH : Form
    {
        DataTable tbSBHXH;
        public frmSoBHXH()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection cnn = new SqlConnection("Data Source=localhost;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
        private void ketnoidl()
        {
            cnn.Open();
            string sql = "select * from SoBHXH";
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
            sql = "select * from SoBHXH";

            dataGridView1.DataSource = tbSBHXH;
            dataGridView1.Columns[0].HeaderText = "Mã sổ BHXH";
            dataGridView1.Columns[1].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[2].HeaderText = "Ngày cấp";
            dataGridView1.Columns[3].HeaderText = "Mã nơi cấp";
            dataGridView1.Columns[4].HeaderText = "Giá trị";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            txtMaSBHXH.Text = "";
            txtMaNV.Text = "";
            txtNgaycap.Text = "";
            txtMaNoiCap.Text = "";
            txtGiaTri.Text = "";
        }
        private void frmSoBHXH_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
            ketnoidl();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaSBHXH.Enabled = true;
            txtMaSBHXH.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnLuu.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSBHXH.Focus();
                return;
            }
            if (tbSBHXH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaSBHXH.Text = dataGridView1.CurrentRow.Cells["MaSBHXH"].Value.ToString();
            txtMaNV.Text = dataGridView1.CurrentRow.Cells["maNV"].Value.ToString();
            txtNgaycap.Text = dataGridView1.CurrentRow.Cells["NgayCap"].Value.ToString();
            txtMaNoiCap.Text = dataGridView1.CurrentRow.Cells["maNoicap"].Value.ToString();
            txtGiaTri.Text = dataGridView1.CurrentRow.Cells["Giatri"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnExit.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbSBHXH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSBHXH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            if (txtNgaycap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào ngày cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgaycap.Focus();
                return;
            }
            if (txtMaNoiCap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào mã nơi cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNoiCap.Focus();
                return;
            }
            if (txtGiaTri.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào giá trị của bảo hiểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaTri.Focus();
                return;
            }
            sql = "update SoBHXH set maSBHXH = N'" + txtMaSBHXH.Text.ToString() + "', maNV = N'" + maNhanVien.HeaderText.ToString() +
                "', ngayCap = N'" + txtNgaycap.Text.Trim().ToString() + "', maNoicap= N'" + txtMaNoiCap.Text.Trim().ToString() + "', Giatri = N'" + txtGiaTri.Text.Trim().ToString() + "'";
            Function.Runsql(sql);
            Load_DataGridView();
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbSBHXH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSBHXH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("bạn có muốn xóa không?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete SoBHXH where maSoBHYT=N'" + txtMaSBHXH.Text + "'";
                Function.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sqlinsert = "insert into SoBHXH values (N'" + txtMaSBHXH.Text.Trim() + "', N'" + txtMaNV.Text.Trim().ToString()
                + "',N'" + txtNgaycap.Text.Trim().ToString() + "',N'" + txtMaNoiCap.Text.Trim().ToString() + "',N'" + txtGiaTri.Text.Trim().ToString() +  "')";
            if (txtMaSBHXH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào mã sổ BHXH", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSBHXH.Focus();
                return;
            }
            if (txtMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            Function.Runsql(sqlinsert);
            Load_DataGridView();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnExit.Enabled = true;
            btnLuu.Enabled = false;
            txtMaSBHXH.Enabled = false;
        }

        private void txtGiaTri_TextChanged(object sender, EventArgs e)
        {
 
        }
    }
}
