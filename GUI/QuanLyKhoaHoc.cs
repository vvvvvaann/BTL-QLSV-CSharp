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
    public partial class QuanLyKhoaHoc : Form
    {
        public QuanLyKhoaHoc()
        {
            InitializeComponent();
        }
        KhoaHoc_DTO KH = new KhoaHoc_DTO();
        KhoaHoc_BUS kh = new KhoaHoc_BUS();
        private void QuanLyKhoaHoc_Load(object sender, EventArgs e)
        {
            dgvKhoaHoc.DataSource = kh.ShowKhoaHoc();
        }

        private void dgvKhoaHoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtMaKhoaHoc.Text = dgvKhoaHoc.Rows[dong].Cells[0].Value.ToString();
                txtNamBatDau.Text = dgvKhoaHoc.Rows[dong].Cells[1].Value.ToString();
                txtNamKetThuc.Text = dgvKhoaHoc.Rows[dong].Cells[2].Value.ToString();
            }
            catch { MessageBox.Show("Co loi!"); }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKhoaHoc.TextLength == 0)
                MessageBox.Show("Ma khoa hoc khong duoc bo trong");
            else if (txtNamBatDau.TextLength == 0)
                MessageBox.Show("Nam bat dau khong duoc bo trong");
            else if (txtNamKetThuc.TextLength == 0)
                MessageBox.Show("Nam ket thuc khong duoc bo trong");
            else
            {
                try
                {
                    KH.MaKhoaHoc = txtMaKhoaHoc.Text;
                    KH.NamBatDau = Int32.Parse(txtNamBatDau.Text);
                    KH.NamKetThuc = Int32.Parse(txtNamKetThuc.Text);
                    kh.InsertKhoaHoc(KH.MaKhoaHoc, KH.NamBatDau, KH.NamKetThuc);
                    MessageBox.Show("Da them thanh cong");
                    QuanLyKhoaHoc_Load(sender, e);
                }
                catch { MessageBox.Show("Co loi!"); }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKhoaHoc.TextLength == 0)
                MessageBox.Show("Ma khoa hoc khong duoc bo trong");
            else if (txtNamBatDau.TextLength == 0)
                MessageBox.Show("Nam bat dau khong duoc bo trong");
            else if (txtNamKetThuc.TextLength == 0)
                MessageBox.Show("Nam ket thuc khong duoc bo trong");
            else
            {
                try
                {
                    KH.MaKhoaHoc = txtMaKhoaHoc.Text;
                    KH.NamBatDau = Int32.Parse(txtNamBatDau.Text);
                    KH.NamKetThuc = Int32.Parse(txtNamKetThuc.Text);
                    kh.UpdateKhoaHoc(KH.MaKhoaHoc, KH.NamBatDau, KH.NamKetThuc);
                    MessageBox.Show("Da sua thanh cong");
                    QuanLyKhoaHoc_Load(sender, e);
                }
                catch { MessageBox.Show("Co loi!"); }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhoaHoc.TextLength == 0)
                MessageBox.Show("Chon ma khoa hoc de xoa");
            else
            {
                DialogResult drl = MessageBox.Show("Ban co muon xoa!", "Thong bao", MessageBoxButtons.YesNo);
                if (drl == DialogResult.Yes)
                {
                    try
                    {
                        KH.MaKhoaHoc = txtMaKhoaHoc.Text;
                        kh.DeleteKhoaHoc(KH.MaKhoaHoc);
                        MessageBox.Show("Da xoa thanh cong");
                        QuanLyKhoaHoc_Load(sender, e);
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
