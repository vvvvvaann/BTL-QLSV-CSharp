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
using DTO;
using DAL;
using BUS;

namespace GUI
{
    public partial class QuanLySinhVien : Form
    {
        public QuanLySinhVien()
        {
            InitializeComponent();
        }
        SinhVien_DTO SV = new SinhVien_DTO();
        SinhVien_BUS sv = new SinhVien_BUS();

        private void QuanLySinhVien_Load(object sender, EventArgs e)
        {
            //Load MaLop
            Data da = new Data();
            string sql = "select * from Lop";
            cbMaLop.DataSource = da.GetTable(sql);
            cbMaLop.DisplayMember = "TenLop";
            cbMaLop.ValueMember = "MaLop";
            //Load GioiTinh
            Data da2 = new Data();
            string sql2 = "select * from GioiTinh";
            cbGioiTinh.DataSource = da2.GetTable(sql2);
            cbGioiTinh.DisplayMember = "GioiTinh";
            cbGioiTinh.ValueMember = "GioiTinh";
            //Load SinhVien
            dgvSinhVien.DataSource = sv.ShowSinhVien();
        }

        private void dgvSinhVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtMaSinhVien.Text = dgvSinhVien.Rows[dong].Cells[0].Value.ToString();
                txtTenSinhVien.Text = dgvSinhVien.Rows[dong].Cells[1].Value.ToString();
                txtNamSinh.Text = dgvSinhVien.Rows[dong].Cells[2].Value.ToString();
                cbGioiTinh.SelectedValue = dgvSinhVien.Rows[dong].Cells[3].Value.ToString();
                txtDanToc.Text = dgvSinhVien.Rows[dong].Cells[4].Value.ToString();
                cbMaLop.SelectedValue = dgvSinhVien.Rows[dong].Cells[5].Value.ToString();
            }
            catch { MessageBox.Show("Co loi!"); }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSinhVien.TextLength == 0)
                MessageBox.Show("Ma sinh vien khong duoc bo trong");
            else if (txtTenSinhVien.TextLength == 0)
                MessageBox.Show("Ten sinh vien khong duoc bo trong");
            else if (txtNamSinh.TextLength == 0)
                MessageBox.Show("Nam sinh khong duoc bo trong");
            else if (txtDanToc.TextLength == 0)
                MessageBox.Show("Dan toc khong duoc bo trong");
            else
            {
                try
                {
                    SV.MaSinhVien = txtMaSinhVien.Text;
                    SV.TenSinhVien = txtTenSinhVien.Text;
                    SV.NamSinh = Int32.Parse(txtNamSinh.Text);
                    SV.GioiTinh = cbGioiTinh.SelectedValue.ToString();
                    SV.DanToc = txtDanToc.Text;
                    SV.MaLop = cbMaLop.SelectedValue.ToString();
                    sv.InsertSinhVien(SV.MaSinhVien, SV.TenSinhVien, SV.NamSinh, SV.GioiTinh, SV.DanToc, SV.MaLop);
                    MessageBox.Show("Da them thanh cong");
                    QuanLySinhVien_Load(sender, e);
                }
                catch { MessageBox.Show("Co loi!"); }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSinhVien.TextLength == 0)
                MessageBox.Show("Ma sinh vien khong duoc bo trong");
            else if (txtTenSinhVien.TextLength == 0)
                MessageBox.Show("Ten sinh vien khong duoc bo trong");
            else if (txtNamSinh.TextLength == 0)
                MessageBox.Show("Nam sinh khong duoc bo trong");
            else if (txtDanToc.TextLength == 0)
                MessageBox.Show("Dan toc khong duoc bo trong");
            else
            {
                try
                {
                    SV.MaSinhVien = txtMaSinhVien.Text;
                    SV.TenSinhVien = txtTenSinhVien.Text;
                    SV.NamSinh = Int32.Parse(txtNamSinh.Text);
                    SV.GioiTinh = cbGioiTinh.SelectedValue.ToString();
                    SV.DanToc = txtDanToc.Text;
                    SV.MaLop = cbMaLop.SelectedValue.ToString();
                    sv.UpdateSinhVien(SV.MaSinhVien, SV.TenSinhVien, SV.NamSinh, SV.GioiTinh, SV.DanToc, SV.MaLop);
                    MessageBox.Show("Da sua thanh cong");
                    QuanLySinhVien_Load(sender, e);
                }
                catch { MessageBox.Show("Co loi!"); }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSinhVien.TextLength == 0)
                MessageBox.Show("Chon ma sinh vien de xoa");
            else
            {
                DialogResult drl = MessageBox.Show("Ban co muon xoa! " + System.Environment.NewLine + "Ket qua cua sinh vien do cung se bi xoa", "Thong bao", MessageBoxButtons.YesNo);
                if (drl == DialogResult.Yes)
                {
                    try
                    {
                        SV.MaSinhVien = txtMaSinhVien.Text;
                        sv.DeleteSinhVien(SV.MaSinhVien);
                        MessageBox.Show("Da xoa thanh cong");
                        QuanLySinhVien_Load(sender, e);
                    }
                    catch { MessageBox.Show("Co loi!"); }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult drl2 = MessageBox.Show("Ban co muon thoat!", "Thong bao", MessageBoxButtons.YesNo);
            if (drl2 == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
