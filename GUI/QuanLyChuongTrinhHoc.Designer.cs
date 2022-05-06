
namespace GUI
{
    partial class QuanLyChuongTrinhHoc
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
            this.dgvChuongTrinhHoc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaChuongTrinh = new System.Windows.Forms.TextBox();
            this.txtTenChuongTrinh = new System.Windows.Forms.TextBox();
            this.MaChuongTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChuongTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuongTrinhHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(854, 99);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(854, 140);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(854, 184);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(854, 228);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvChuongTrinhHoc
            // 
            this.dgvChuongTrinhHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuongTrinhHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChuongTrinh,
            this.TenChuongTrinh});
            this.dgvChuongTrinhHoc.Location = new System.Drawing.Point(300, 285);
            this.dgvChuongTrinhHoc.Name = "dgvChuongTrinhHoc";
            this.dgvChuongTrinhHoc.RowHeadersWidth = 51;
            this.dgvChuongTrinhHoc.RowTemplate.Height = 29;
            this.dgvChuongTrinhHoc.Size = new System.Drawing.Size(648, 278);
            this.dgvChuongTrinhHoc.TabIndex = 4;
            this.dgvChuongTrinhHoc.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuongTrinhHoc_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(466, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quan Ly Chuong Trinh Hoc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ma chuong trinh*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ten chuong trinh";
            // 
            // txtMaChuongTrinh
            // 
            this.txtMaChuongTrinh.Location = new System.Drawing.Point(466, 100);
            this.txtMaChuongTrinh.Name = "txtMaChuongTrinh";
            this.txtMaChuongTrinh.Size = new System.Drawing.Size(250, 27);
            this.txtMaChuongTrinh.TabIndex = 8;
            // 
            // txtTenChuongTrinh
            // 
            this.txtTenChuongTrinh.Location = new System.Drawing.Point(466, 141);
            this.txtTenChuongTrinh.Name = "txtTenChuongTrinh";
            this.txtTenChuongTrinh.Size = new System.Drawing.Size(250, 27);
            this.txtTenChuongTrinh.TabIndex = 9;
            // 
            // MaChuongTrinh
            // 
            this.MaChuongTrinh.DataPropertyName = "MaChuongTrinh";
            this.MaChuongTrinh.HeaderText = "Ma chuong trinh";
            this.MaChuongTrinh.MinimumWidth = 6;
            this.MaChuongTrinh.Name = "MaChuongTrinh";
            this.MaChuongTrinh.Width = 250;
            // 
            // TenChuongTrinh
            // 
            this.TenChuongTrinh.DataPropertyName = "TenChuongTrinh";
            this.TenChuongTrinh.HeaderText = "Ten chunog trinh";
            this.TenChuongTrinh.MinimumWidth = 6;
            this.TenChuongTrinh.Name = "TenChuongTrinh";
            this.TenChuongTrinh.Width = 250;
            // 
            // QuanLyChuongTrinhHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.txtTenChuongTrinh);
            this.Controls.Add(this.txtMaChuongTrinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvChuongTrinhHoc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "QuanLyChuongTrinhHoc";
            this.Text = "Quan Ly Chuong Trinh Hoc";
            this.Load += new System.EventHandler(this.QuanLyChuongTrinhHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuongTrinhHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvChuongTrinhHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaChuongTrinh;
        private System.Windows.Forms.TextBox txtTenChuongTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuongTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChuongTrinh;
    }
}