namespace Nhom15
{
    partial class frmChiTietHD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maSoHopDongLaoDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLanHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mucLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anTrua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maChucVuNguoiKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExitCTHD = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaLanHD = new System.Windows.Forms.TextBox();
            this.txtMaLoaiHD = new System.Windows.Forms.TextBox();
            this.txtNgayHD = new System.Windows.Forms.TextBox();
            this.txtNgayKT = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.txtMucLuong = new System.Windows.Forms.TextBox();
            this.txtAnTrua = new System.Windows.Forms.TextBox();
            this.txtTongLuong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNguoiKi = new System.Windows.Forms.TextBox();
            this.txtMaCVNguoiKi = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Tiết Hợp Đồng Lao Động";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã số hợp đồng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã lần HD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã loại hợp đồng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày HD";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSoHopDongLaoDong,
            this.maLanHD,
            this.maLoaiHopDong,
            this.ngayHD,
            this.ngayKT,
            this.maPhongBan,
            this.maChucVu,
            this.mucLuong,
            this.anTrua,
            this.tongLuong,
            this.nguoiKi,
            this.maChucVuNguoiKi});
            this.dataGridView1.Location = new System.Drawing.Point(27, 341);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(755, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // maSoHopDongLaoDong
            // 
            this.maSoHopDongLaoDong.DataPropertyName = "maSoHopDongLaoDong";
            this.maSoHopDongLaoDong.HeaderText = "Mã số hợp đồng";
            this.maSoHopDongLaoDong.MinimumWidth = 6;
            this.maSoHopDongLaoDong.Name = "maSoHopDongLaoDong";
            this.maSoHopDongLaoDong.Width = 125;
            // 
            // maLanHD
            // 
            this.maLanHD.DataPropertyName = "maLanHD";
            this.maLanHD.HeaderText = "Mã lần hợp đồng";
            this.maLanHD.MinimumWidth = 6;
            this.maLanHD.Name = "maLanHD";
            this.maLanHD.Width = 125;
            // 
            // maLoaiHopDong
            // 
            this.maLoaiHopDong.DataPropertyName = "maLoaiHopDong";
            this.maLoaiHopDong.HeaderText = "Mã loại hợp đồng";
            this.maLoaiHopDong.MinimumWidth = 6;
            this.maLoaiHopDong.Name = "maLoaiHopDong";
            this.maLoaiHopDong.Width = 125;
            // 
            // ngayHD
            // 
            this.ngayHD.DataPropertyName = "ngayHD";
            this.ngayHD.HeaderText = "Ngày HD";
            this.ngayHD.MinimumWidth = 6;
            this.ngayHD.Name = "ngayHD";
            this.ngayHD.Width = 125;
            // 
            // ngayKT
            // 
            this.ngayKT.DataPropertyName = "ngayKT";
            this.ngayKT.HeaderText = "Ngày KT";
            this.ngayKT.MinimumWidth = 6;
            this.ngayKT.Name = "ngayKT";
            this.ngayKT.Width = 125;
            // 
            // maPhongBan
            // 
            this.maPhongBan.DataPropertyName = "maPhongBan";
            this.maPhongBan.HeaderText = "Mã phòng ban";
            this.maPhongBan.MinimumWidth = 6;
            this.maPhongBan.Name = "maPhongBan";
            this.maPhongBan.Width = 125;
            // 
            // maChucVu
            // 
            this.maChucVu.DataPropertyName = "maChucVu";
            this.maChucVu.HeaderText = "Mã chức vụ";
            this.maChucVu.MinimumWidth = 6;
            this.maChucVu.Name = "maChucVu";
            this.maChucVu.Width = 125;
            // 
            // mucLuong
            // 
            this.mucLuong.DataPropertyName = "mucLuong";
            this.mucLuong.HeaderText = "Mức lương";
            this.mucLuong.MinimumWidth = 6;
            this.mucLuong.Name = "mucLuong";
            this.mucLuong.Width = 125;
            // 
            // anTrua
            // 
            this.anTrua.DataPropertyName = "anTrua";
            this.anTrua.HeaderText = "Ăn trưa";
            this.anTrua.MinimumWidth = 6;
            this.anTrua.Name = "anTrua";
            this.anTrua.Width = 125;
            // 
            // tongLuong
            // 
            this.tongLuong.DataPropertyName = "tongLuong";
            this.tongLuong.HeaderText = "Tổng lương";
            this.tongLuong.MinimumWidth = 6;
            this.tongLuong.Name = "tongLuong";
            this.tongLuong.Width = 125;
            // 
            // nguoiKi
            // 
            this.nguoiKi.DataPropertyName = "nguoiKi";
            this.nguoiKi.HeaderText = "Người kí";
            this.nguoiKi.MinimumWidth = 6;
            this.nguoiKi.Name = "nguoiKi";
            this.nguoiKi.Width = 125;
            // 
            // maChucVuNguoiKi
            // 
            this.maChucVuNguoiKi.DataPropertyName = "maCV";
            this.maChucVuNguoiKi.HeaderText = "Mã chức vụ (Người Kí)";
            this.maChucVuNguoiKi.MinimumWidth = 6;
            this.maChucVuNguoiKi.Name = "maChucVuNguoiKi";
            this.maChucVuNguoiKi.Width = 125;
            // 
            // btnExitCTHD
            // 
            this.btnExitCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitCTHD.Location = new System.Drawing.Point(732, 254);
            this.btnExitCTHD.Name = "btnExitCTHD";
            this.btnExitCTHD.Size = new System.Drawing.Size(61, 50);
            this.btnExitCTHD.TabIndex = 6;
            this.btnExitCTHD.Text = "Exit";
            this.btnExitCTHD.UseVisualStyleBackColor = true;
            this.btnExitCTHD.Click += new System.EventHandler(this.btnExitCTHD_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày KT";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(162, 74);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(120, 22);
            this.txtMaHD.TabIndex = 8;
            // 
            // txtMaLanHD
            // 
            this.txtMaLanHD.Location = new System.Drawing.Point(162, 116);
            this.txtMaLanHD.Name = "txtMaLanHD";
            this.txtMaLanHD.Size = new System.Drawing.Size(120, 22);
            this.txtMaLanHD.TabIndex = 9;
            // 
            // txtMaLoaiHD
            // 
            this.txtMaLoaiHD.Location = new System.Drawing.Point(162, 158);
            this.txtMaLoaiHD.Name = "txtMaLoaiHD";
            this.txtMaLoaiHD.Size = new System.Drawing.Size(120, 22);
            this.txtMaLoaiHD.TabIndex = 10;
            // 
            // txtNgayHD
            // 
            this.txtNgayHD.Location = new System.Drawing.Point(162, 198);
            this.txtNgayHD.Name = "txtNgayHD";
            this.txtNgayHD.Size = new System.Drawing.Size(120, 22);
            this.txtNgayHD.TabIndex = 11;
            // 
            // txtNgayKT
            // 
            this.txtNgayKT.Location = new System.Drawing.Point(162, 233);
            this.txtNgayKT.Name = "txtNgayKT";
            this.txtNgayKT.Size = new System.Drawing.Size(120, 22);
            this.txtNgayKT.TabIndex = 12;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(732, 59);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(61, 49);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(326, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mã phòng ban";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(326, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mã chức vụ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(326, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Mức lương";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(326, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Ăn trưa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(326, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "Tổng lương";
            // 
            // txtMaPB
            // 
            this.txtMaPB.Location = new System.Drawing.Point(443, 34);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(140, 22);
            this.txtMaPB.TabIndex = 19;
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(443, 73);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(140, 22);
            this.txtMaCV.TabIndex = 20;
            // 
            // txtMucLuong
            // 
            this.txtMucLuong.Location = new System.Drawing.Point(443, 116);
            this.txtMucLuong.Name = "txtMucLuong";
            this.txtMucLuong.Size = new System.Drawing.Size(140, 22);
            this.txtMucLuong.TabIndex = 21;
            // 
            // txtAnTrua
            // 
            this.txtAnTrua.Location = new System.Drawing.Point(443, 158);
            this.txtAnTrua.Name = "txtAnTrua";
            this.txtAnTrua.Size = new System.Drawing.Size(140, 22);
            this.txtAnTrua.TabIndex = 22;
            // 
            // txtTongLuong
            // 
            this.txtTongLuong.Location = new System.Drawing.Point(443, 198);
            this.txtTongLuong.Name = "txtTongLuong";
            this.txtTongLuong.Size = new System.Drawing.Size(140, 22);
            this.txtTongLuong.TabIndex = 23;
            this.txtTongLuong.TextChanged += new System.EventHandler(this.txtTongLuong_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(326, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "Người kí";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(326, 282);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 36);
            this.label13.TabIndex = 25;
            this.label13.Text = "Mã chức vụ\r\n(Người kí)\r\n";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtNguoiKi
            // 
            this.txtNguoiKi.Location = new System.Drawing.Point(443, 237);
            this.txtNguoiKi.Name = "txtNguoiKi";
            this.txtNguoiKi.Size = new System.Drawing.Size(140, 22);
            this.txtNguoiKi.TabIndex = 26;
            // 
            // txtMaCVNguoiKi
            // 
            this.txtMaCVNguoiKi.Location = new System.Drawing.Point(443, 282);
            this.txtMaCVNguoiKi.Name = "txtMaCVNguoiKi";
            this.txtMaCVNguoiKi.Size = new System.Drawing.Size(140, 22);
            this.txtMaCVNguoiKi.TabIndex = 27;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(732, 158);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 50);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(635, 104);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(61, 50);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(635, 209);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(61, 50);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmChiTietHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 557);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtMaCVNguoiKi);
            this.Controls.Add(this.txtNguoiKi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTongLuong);
            this.Controls.Add(this.txtAnTrua);
            this.Controls.Add(this.txtMucLuong);
            this.Controls.Add(this.txtMaCV);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtNgayKT);
            this.Controls.Add(this.txtNgayHD);
            this.Controls.Add(this.txtMaLoaiHD);
            this.Controls.Add(this.txtMaLanHD);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExitCTHD);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaPB);
            this.Name = "frmChiTietHD";
            this.Text = "frmChiTietHD";
            this.Load += new System.EventHandler(this.frmChiTietHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExitCTHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaLanHD;
        private System.Windows.Forms.TextBox txtMaLoaiHD;
        private System.Windows.Forms.TextBox txtNgayHD;
        private System.Windows.Forms.TextBox txtNgayKT;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.TextBox txtMucLuong;
        private System.Windows.Forms.TextBox txtAnTrua;
        private System.Windows.Forms.TextBox txtTongLuong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNguoiKi;
        private System.Windows.Forms.TextBox txtMaCVNguoiKi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSoHopDongLaoDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLanHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn mucLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn anTrua;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChucVuNguoiKi;
    }
}