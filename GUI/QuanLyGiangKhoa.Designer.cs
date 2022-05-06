
namespace GUI
{
    partial class QuanLyGiangKhoa
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvGiangKhoa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoTietLT = new System.Windows.Forms.TextBox();
            this.txtSoTietTH = new System.Windows.Forms.TextBox();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.cbMaChuongTrinh = new System.Windows.Forms.ComboBox();
            this.cbMaKhoa = new System.Windows.Forms.ComboBox();
            this.cbMaMonHoc = new System.Windows.Forms.ComboBox();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.MaChuongTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTietLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTietTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(959, 88);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(959, 126);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(959, 164);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(959, 203);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvGiangKhoa
            // 
            this.dgvGiangKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiangKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChuongTrinh,
            this.MaKhoa,
            this.MaMonHoc,
            this.NamHoc,
            this.HocKy,
            this.SoTietLT,
            this.SoTietTH,
            this.SoTinChi});
            this.dgvGiangKhoa.Location = new System.Drawing.Point(151, 275);
            this.dgvGiangKhoa.Name = "dgvGiangKhoa";
            this.dgvGiangKhoa.RowHeadersWidth = 51;
            this.dgvGiangKhoa.RowTemplate.Height = 29;
            this.dgvGiangKhoa.Size = new System.Drawing.Size(902, 349);
            this.dgvGiangKhoa.TabIndex = 4;
            this.dgvGiangKhoa.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiangKhoa_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(485, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quan Ly Giang Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ma chuong trinh*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ma khoa*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ma mon hoc*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hoc ky*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nam hoc*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(555, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "So tiet LT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(555, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "So tiet TH";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(555, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "So tin chi";
            // 
            // txtSoTietLT
            // 
            this.txtSoTietLT.Location = new System.Drawing.Point(681, 127);
            this.txtSoTietLT.Name = "txtSoTietLT";
            this.txtSoTietLT.Size = new System.Drawing.Size(210, 27);
            this.txtSoTietLT.TabIndex = 15;
            // 
            // txtSoTietTH
            // 
            this.txtSoTietTH.Location = new System.Drawing.Point(681, 165);
            this.txtSoTietTH.Name = "txtSoTietTH";
            this.txtSoTietTH.Size = new System.Drawing.Size(210, 27);
            this.txtSoTietTH.TabIndex = 16;
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Location = new System.Drawing.Point(681, 203);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.Size = new System.Drawing.Size(210, 27);
            this.txtSoTinChi.TabIndex = 17;
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Location = new System.Drawing.Point(295, 204);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(213, 27);
            this.txtNamHoc.TabIndex = 18;
            // 
            // cbMaChuongTrinh
            // 
            this.cbMaChuongTrinh.FormattingEnabled = true;
            this.cbMaChuongTrinh.Location = new System.Drawing.Point(295, 89);
            this.cbMaChuongTrinh.Name = "cbMaChuongTrinh";
            this.cbMaChuongTrinh.Size = new System.Drawing.Size(213, 28);
            this.cbMaChuongTrinh.TabIndex = 19;
            // 
            // cbMaKhoa
            // 
            this.cbMaKhoa.FormattingEnabled = true;
            this.cbMaKhoa.Location = new System.Drawing.Point(295, 127);
            this.cbMaKhoa.Name = "cbMaKhoa";
            this.cbMaKhoa.Size = new System.Drawing.Size(213, 28);
            this.cbMaKhoa.TabIndex = 20;
            // 
            // cbMaMonHoc
            // 
            this.cbMaMonHoc.FormattingEnabled = true;
            this.cbMaMonHoc.Location = new System.Drawing.Point(295, 165);
            this.cbMaMonHoc.Name = "cbMaMonHoc";
            this.cbMaMonHoc.Size = new System.Drawing.Size(213, 28);
            this.cbMaMonHoc.TabIndex = 21;
            // 
            // cbHocKy
            // 
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(681, 89);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(210, 28);
            this.cbHocKy.TabIndex = 22;
            // 
            // MaChuongTrinh
            // 
            this.MaChuongTrinh.DataPropertyName = "MaChuongTrinh";
            this.MaChuongTrinh.HeaderText = "Ma CT";
            this.MaChuongTrinh.MinimumWidth = 6;
            this.MaChuongTrinh.Name = "MaChuongTrinh";
            this.MaChuongTrinh.Width = 80;
            // 
            // MaKhoa
            // 
            this.MaKhoa.DataPropertyName = "MaKhoa";
            this.MaKhoa.HeaderText = "Ma khoa";
            this.MaKhoa.MinimumWidth = 6;
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.Width = 120;
            // 
            // MaMonHoc
            // 
            this.MaMonHoc.DataPropertyName = "MaMonHoc";
            this.MaMonHoc.HeaderText = "Ma mon hoc";
            this.MaMonHoc.MinimumWidth = 6;
            this.MaMonHoc.Name = "MaMonHoc";
            this.MaMonHoc.Width = 120;
            // 
            // NamHoc
            // 
            this.NamHoc.DataPropertyName = "NamHoc";
            this.NamHoc.HeaderText = "Nam hoc";
            this.NamHoc.MinimumWidth = 6;
            this.NamHoc.Name = "NamHoc";
            this.NamHoc.Width = 120;
            // 
            // HocKy
            // 
            this.HocKy.DataPropertyName = "HocKy";
            this.HocKy.HeaderText = "Hoc ky";
            this.HocKy.MinimumWidth = 6;
            this.HocKy.Name = "HocKy";
            this.HocKy.Width = 80;
            // 
            // SoTietLT
            // 
            this.SoTietLT.DataPropertyName = "SoTietLT";
            this.SoTietLT.HeaderText = "So tiet LT";
            this.SoTietLT.MinimumWidth = 6;
            this.SoTietLT.Name = "SoTietLT";
            // 
            // SoTietTH
            // 
            this.SoTietTH.DataPropertyName = "SoTietTH";
            this.SoTietTH.HeaderText = "So tiet TH";
            this.SoTietTH.MinimumWidth = 6;
            this.SoTietTH.Name = "SoTietTH";
            // 
            // SoTinChi
            // 
            this.SoTinChi.DataPropertyName = "SoTinChi";
            this.SoTinChi.HeaderText = "So tin chi";
            this.SoTinChi.MinimumWidth = 6;
            this.SoTinChi.Name = "SoTinChi";
            this.SoTinChi.Width = 110;
            // 
            // QuanLyGiangKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.cbHocKy);
            this.Controls.Add(this.cbMaMonHoc);
            this.Controls.Add(this.cbMaKhoa);
            this.Controls.Add(this.cbMaChuongTrinh);
            this.Controls.Add(this.txtNamHoc);
            this.Controls.Add(this.txtSoTinChi);
            this.Controls.Add(this.txtSoTietTH);
            this.Controls.Add(this.txtSoTietLT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGiangKhoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "QuanLyGiangKhoa";
            this.Text = "Quan Ly Giang Khoa";
            this.Load += new System.EventHandler(this.QuanLyGiangKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvGiangKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoTietLT;
        private System.Windows.Forms.TextBox txtSoTietTH;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.ComboBox cbMaChuongTrinh;
        private System.Windows.Forms.ComboBox cbMaKhoa;
        private System.Windows.Forms.ComboBox cbMaMonHoc;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuongTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTietLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTietTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTinChi;
    }
}