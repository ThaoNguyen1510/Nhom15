namespace Nhom15
{
    partial class frmChuyenMon
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
            this.txtMaChuyenMon = new System.Windows.Forms.TextBox();
            this.txtTenChuyenMon = new System.Windows.Forms.TextBox();
            this.btnExitCM = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuyên Môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã chuyên môn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên chuyên môn";
            // 
            // txtMaChuyenMon
            // 
            this.txtMaChuyenMon.Location = new System.Drawing.Point(205, 85);
            this.txtMaChuyenMon.Name = "txtMaChuyenMon";
            this.txtMaChuyenMon.Size = new System.Drawing.Size(196, 22);
            this.txtMaChuyenMon.TabIndex = 3;
            // 
            // txtTenChuyenMon
            // 
            this.txtTenChuyenMon.Location = new System.Drawing.Point(205, 145);
            this.txtTenChuyenMon.Name = "txtTenChuyenMon";
            this.txtTenChuyenMon.Size = new System.Drawing.Size(196, 22);
            this.txtTenChuyenMon.TabIndex = 4;
            // 
            // btnExitCM
            // 
            this.btnExitCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitCM.Location = new System.Drawing.Point(655, 369);
            this.btnExitCM.Name = "btnExitCM";
            this.btnExitCM.Size = new System.Drawing.Size(70, 44);
            this.btnExitCM.TabIndex = 5;
            this.btnExitCM.Text = "Exit";
            this.btnExitCM.UseVisualStyleBackColor = true;
            this.btnExitCM.Click += new System.EventHandler(this.btnExitCM_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(522, 166);
            this.dataGridView1.TabIndex = 6;
            // 
            // frmChuyenMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExitCM);
            this.Controls.Add(this.txtTenChuyenMon);
            this.Controls.Add(this.txtMaChuyenMon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmChuyenMon";
            this.Text = "frmChuyenMon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaChuyenMon;
        private System.Windows.Forms.TextBox txtTenChuyenMon;
        private System.Windows.Forms.Button btnExitCM;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}