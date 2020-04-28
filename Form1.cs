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

namespace  Nhom15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        txtTaiKhoan.Focus();
        txtMatKhau.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Length == 0 && txtMatKhau.Text.Length == 0)
                MessageBox.Show("Thông tin đăng nhập sai");
            if (txtTaiKhoan.Text.Length == 0)
                MessageBox.Show("Bạn chưa điền thông tin tài khoản");
            if (txtMatKhau.Text.Length == 0)
                MessageBox.Show("Mật khẩu sai");
        Form1 f1 = new Form1();
        Frmmain fm = new Frmmain();
            if (this.txtTaiKhoan.Text == "nhom15" && this.txtMatKhau.Text == "1")
            {
                fm.Show();
                f1.Close();
            }
            else
                MessageBox.Show("Thông tin đăng nhập sai");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
