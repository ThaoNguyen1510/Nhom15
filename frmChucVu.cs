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
    
    public partial class frmChucVu : Form
    {
        DataTable tbCHVU;
        public frmChucVu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExitCV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "select * from ChucVu";
            dataGridView1.DataSource = tbCHVU;
            dataGridView1.Columns[0].HeaderText = "Mã chức vụ";
            dataGridView1.Columns[1].HeaderText = "Tên chức vụ";
            dataGridView1.Columns[2].HeaderText = "Phụ cấp chức cụ";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            txtMaChucVu.Text = "";
            txtTenChucVu.Text = "";
            txtPhuCapCV.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbCHVU.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaChucVu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                sql = "delete ChucVu where maChucVu=N'" + txtMaChucVu + "'";
                Function.Runsql(sql);
                Load_DataGridView();
                ResetValues();
            }
        }
        SqlConnection cnn = new SqlConnection("Data Source=localhost;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
        private void ketnoidl()
        {
            cnn.Open();
            string sql = "select * from ChucVu";
            SqlCommand com = new SqlCommand(sql, cnn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            dataGridView1.DataSource = dt;
        }
        private void frmChucVu_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
            ketnoidl();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnLuu.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaChucVu.Focus();
                return;
            }
            
            txtMaChucVu.Text = dataGridView1.CurrentRow.Cells["maChucVu"].Value.ToString();
            txtTenChucVu.Text = dataGridView1.CurrentRow.Cells["tenChucVu"].Value.ToString();
            txtPhuCapCV.Text = dataGridView1.CurrentRow.Cells["phuCapCV"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnExitCV.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            ResetValues();
            txtMaChucVu.Enabled = true;
            txtMaChucVu.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbCHVU.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaChucVu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenChucVu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào tên chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenChucVu.Focus();
                return;
            }
            if (txtPhuCapCV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào phụ cấp chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhuCapCV.Focus();
                return;
            }
            sql = "update ChucVu set maChucVu = N'" + txtMaChucVu.Text.ToString() + "', tenChucVu = N'" + txtTenChucVu.Text.Trim().ToString() +
                "', phuCapCV = N'" + txtPhuCapCV.Text.Trim().ToString() + "')";
            Function.Runsql(sql);
            Load_DataGridView();
            ResetValues();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sqlinsert = "insert into ChucVu values (N'" + txtMaChucVu.Text.Trim() + "', N'" + txtTenChucVu.Text.Trim().ToString()
                + "',N'" + txtPhuCapCV.Text.Trim().ToString() + "')";
            if (txtMaChucVu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào mã chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChucVu.Focus();
                return;
            }
            if (txtTenChucVu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào tên chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenChucVu.Focus();
                return;
            }
            Function.Runsql(sqlinsert);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnExitCV.Enabled = true;
            btnLuu.Enabled = false;
            txtMaChucVu.Enabled = false;
        }
        public class LuuTT
        {
            static public string PCCV;
        }
        private void txtPhuCapCV_TextChanged(object sender, EventArgs e)
        {
            LuuTT.PCCV = txtPhuCapCV.Text;
            frmChiTietHD f = new frmChiTietHD();
        }
    }
}
