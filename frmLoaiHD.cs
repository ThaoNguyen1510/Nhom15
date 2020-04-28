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
    public partial class frmLoaiHD : Form
    {
        DataTable tbLHD;
        public frmLoaiHD()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection cnn = new SqlConnection("Data Source=localhost;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
        private void ketnoidl()
        {
            cnn.Open();
            string sql = "select * from LoaiHopDong";
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
            sql = "select * from HopDongLaoDong";
            tbLHD = Function.GetDataToTable(sql);
            dataGridView1.DataSource = tbLHD;
            dataGridView1.Columns[0].HeaderText = "Mã số hợp đồng";
            dataGridView1.Columns[1].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 300;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            txtMaLHD.Text = "";
            txtTenLHD.Text = "";
        }
        private void frmLoaiHD_Load(object sender, EventArgs e)
        {
            txtMaLHD.Enabled = true;
            btnLuu.Enabled = true;
            Load_DataGridView();
            ketnoidl();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLHD.Focus();
                return;
            }
            if (tbLHD.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaLHD.Text = dataGridView1.CurrentRow.Cells["maLoaiHopDong"].Value.ToString();
            txtTenLHD.Text = dataGridView1.CurrentRow.Cells["tenLHD"].Value.ToString();
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
            txtMaLHD.Enabled = true;
            txtMaLHD.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            string sql;
            if (tbLHD.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaLHD.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenLHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạnn phải nhập tên chuyên môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLHD.Focus();
                return;
            }
            sql = "update LoaiHopDong set tenLHD = N'" + txtTenLHD.Text.ToString() +
                "' where maLoaiHopDong =N'" + txtMaLHD.Text + "'";
            Function.Runsql(sql);
            Load_DataGridView();
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbLHD.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaLHD.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("bạn có muốn xóa không?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete LoaiHopDong where maLoaiHopDong=N'" + txtMaLHD.Text + "'";
                Function.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaLHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã laoị hợp đồng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLHD.Focus();
                return;
            }
            if (txtTenLHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên laoị hợp dồng", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLHD.Focus();
                return;
            }
            sql = "select maLoaiHopDong from LoaiHopDong where maLoaiHopDong = N'" + txtMaLHD.Text.Trim() + "'";
            if (Function.CheckKey(sql))
            {
                MessageBox.Show("Mã chuyên môn này đã có, bạn phải nhập mã khác", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLHD.Focus();
                txtMaLHD.Text = "";
                return;
            }
            sql = "inset into LoaiHopDong values(N'" + txtMaLHD.Text + "',N'" + txtTenLHD.Text + "')";
            Function.Runsql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaLHD.Enabled = false;
        }
    }
}
