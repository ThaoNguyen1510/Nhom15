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
   
    public partial class frmChuyenMon : Form
    {
        DataTable tbCM;
        public frmChuyenMon()
        {
            InitializeComponent();
        }

        private void btnExitCM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbCM.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaChuyenMon.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("bạn có muốn xóa không?", "Thông báo",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete ChuyenMon where maChuyenMon=N'" + txtMaChuyenMon.Text + "'";
                Function.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }
        SqlConnection cnn = new SqlConnection("Data Source=localhost;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
        private void ketnoidl()
        {
            cnn.Open();
            string sql = "select * from ChuyenMon";
            SqlCommand com = new SqlCommand(sql, cnn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            dataGridView1.DataSource = dt;
        }
        private void ResetValues()
        {
            txtMaChuyenMon.Text = "";
            txtTenChuyenMon.Text = "";
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "select * from ChuyenMon";
            tbCM = Function.GetDataToTable(sql);
            dataGridView1.DataSource = tbCM;
            dataGridView1.Columns[0].HeaderText = "Mã chuyên môn";
            dataGridView1.Columns[1].HeaderText = "Tên chuyên môn";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 300;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        
        private void frmChuyenMon_Load(object sender, EventArgs e)
        {
            cnn.Open();
            txtMaChuyenMon.Enabled = true;
            btnLuu.Enabled = true;
            Load_DataGridView();
            ketnoidl();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaChuyenMon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chuyên môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChuyenMon.Focus();
                return;
            }
            if (txtTenChuyenMon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chuyên môn", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenChuyenMon.Focus();
                return;
            }
            sql = "select maChuyenMon from ChuyenMon where maChuyenMon = N'" + txtMaChuyenMon.Text.Trim() + "'";
            if (Function.CheckKey(sql))
            {
                MessageBox.Show("Mã chuyên môn này đã có, bạn phải nhập mã khác", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChuyenMon.Focus();
                txtMaChuyenMon.Text = "";
                return;
            }
            sql = "inset into ChuyenMon(maChuyenMon, tenChuyenMon) values(N'" + txtMaChuyenMon.Text + "',N'" + txtTenChuyenMon.Text +"')";
            Function.Runsql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaChuyenMon.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbCM.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaChuyenMon.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenChuyenMon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạnn phải nhập tên chuyên môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenChuyenMon.Focus();
                return;
            }
            sql = "update ChuyenMon set tenChuyenMon = N'" + txtTenChuyenMon.Text.ToString() +
                "' where maChuyenMon=N'" + txtMaChuyenMon.Text + "'";
            Function.Runsql(sql);
            Load_DataGridView();
            ResetValues();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaChuyenMon.Focus();
                return;
            }
            if (tbCM.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaChuyenMon.Text = dataGridView1.CurrentRow.Cells["maChuyenMon"].Value.ToString();
            txtTenChuyenMon.Text = dataGridView1.CurrentRow.Cells["tenChuyenMon"].Value.ToString();
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
            txtMaChuyenMon.Enabled = true;
            txtMaChuyenMon.Focus();
        }
         
    }
}
