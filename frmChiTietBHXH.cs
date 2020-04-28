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
using System.Configuration;
using Nhom15;

namespace Nhom15
{
    public partial class frmChiTietBHXH : Form
    {
        DataTable tbCTBHXH;
        public frmChiTietBHXH()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        SqlConnection cnn = new SqlConnection("Data Source=localhost;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
        public void ketnoidl()
        {
            cnn.Open();
            string sql = "select * from ChiTietDongBHXH";
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
       
            dataGridView1.DataSource = tbCTBHXH;
            dataGridView1.Columns[0].HeaderText = "Mã sổ BHXH";
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
        private void frmChiTietBHXH_Load(object sender, EventArgs e)
        {
            txtMaSoBHXH.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            Load_DataGridView();
            ketnoidl();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
      
        private void ResetValues()
        {
            txtMaSoBHXH.Text = "";
            txtMaLanDong.Text = "";
            txtThang.Text = "";
            txtNgayDong.Text = "";
            txtNam.Text = "";
            txtSoTien.Text = "";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sqlinsert = "insert into ChiTietDongBHXH(maSOBHXH, maLanDong, baoHiemThang, nam, ngayDong, soTien) values (N'" + txtMaSoBHXH.Text.Trim() + "', N'" + txtMaLanDong.Text.Trim().ToString() 
                +"',N'" + txtThang.Text.Trim().ToString() +"',N'" + txtNam.Text.Trim().ToString() + "',N'" + txtNgayDong.Text.Trim().ToString() +"',N'" + txtSoTien.Text.Trim() + "')";
            if (txtMaSoBHXH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào mã sổ BHXH", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSoBHXH.Focus();
                return;
            }
            if (txtMaLanDong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã lần đóng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLanDong.Focus();
                return;
            }
            Function.Runsql(sqlinsert);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnExit.Enabled = true;
            btnLuu.Enabled = false;
            txtMaSoBHXH.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          if (btnLuu.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSoBHXH.Focus();
                return;
            }
          if (tbCTBHXH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaSoBHXH.Text = dataGridView1.CurrentRow.Cells["MaSOBHXH"].Value.ToString();
            txtMaLanDong.Text = dataGridView1.CurrentRow.Cells["maLanDong"].Value.ToString();
            txtThang.Text = dataGridView1.CurrentRow.Cells["baoHiemThang"].Value.ToString();
            txtNam.Text = dataGridView1.CurrentRow.Cells["nam"].Value.ToString();
            txtNgayDong.Text = dataGridView1.CurrentRow.Cells["ngayDong"].Value.ToString();
            txtSoTien.Text = dataGridView1.CurrentRow.Cells["soTien"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnExit.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            ResetValues();
            txtMaSoBHXH.Enabled = true;
            txtMaSoBHXH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbCTBHXH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSoBHXH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaLanDong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã lần đóng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLanDong.Focus();
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
            sql = "update ChiTietDongBHXH set maLanDong = N'" + txtMaLanDong.Text.ToString() + "', baoHiemThang = N'" + txtThang.Text.Trim().ToString() +
                "', nam = N'" + txtNam.Text.Trim().ToString() + "', ngayDong = N'" + txtNgayDong.Text.Trim().ToString() + "', soTien = N'" + txtSoTien.Text.Trim().ToString() +
                "' where maSOBHXH=N'" + txtMaSoBHXH.Text + "'";
            Function.Runsql(sql);
            Load_DataGridView();
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbCTBHXH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSoBHXH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("bạn có muốn xóa không?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete ChiTietDongBHXH where maSOBHXH=N'" + txtMaSoBHXH.Text + "'";
                Function.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }
   
        public void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            string a, d;
            int b, c;
            a = frmChiTietHD.LuuThongTin.TongLuong;
            b = Convert.ToInt32(a);
            c = b * 10 / 100;
            d = c.ToString();
            txtSoTien.Text = d;
        }
    }
}
