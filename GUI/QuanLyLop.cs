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
    public partial class QuanLyLop : Form
    {
        public QuanLyLop()
        {
            InitializeComponent();
        }
        Lop_DTO L = new Lop_DTO();
        Lop_BUS l = new Lop_BUS();

        private void QuanLyLop_Load(object sender, EventArgs e)
        {
            //Load MaKhoa
            Data da = new Data();
            string sql = "select * from Khoa";
            cbMaKhoa.DataSource = da.GetTable(sql);
            cbMaKhoa.DisplayMember = "TenKhoa";
            cbMaKhoa.ValueMember = "MaKhoa";
            //Load KhoaHoc
            Data da2 = new Data();
            string sql2 = "select * from KhoaHoc";
            cbMaKhoaHoc.DataSource = da2.GetTable(sql2);
            cbMaKhoaHoc.DisplayMember = "MaKhoaHoc";
            cbMaKhoaHoc.ValueMember = "MaKhoaHoc";
            //Load ChuongTrinhHoc
            Data da3 = new Data();
            string sql3 = "select * from ChuongTrinhHoc";
            cbMaChuongTrinh.DataSource = da3.GetTable(sql3);
            cbMaChuongTrinh.DisplayMember = "TenChuongTrinh";
            cbMaChuongTrinh.ValueMember = "MaChuongTrinh";
            //Load Lop
            dgvLop.DataSource = l.ShowLop();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLop.TextLength == 0)
                MessageBox.Show("Ma lop khong duoc bo trong");
            else if (txtTenLop.TextLength == 0)
                MessageBox.Show("Ten lop khong duoc bo trong");
            else
            {
                try
                {
                    L.MaLop = txtMaLop.Text;
                    L.TenLop = txtTenLop.Text;
                    L.MaKhoa = cbMaKhoa.SelectedValue.ToString();
                    L.MaKhoaHoc = cbMaKhoaHoc.SelectedValue.ToString();
                    L.MaChuongTrinh = cbMaChuongTrinh.SelectedValue.ToString();
                    l.InsertLop(L.MaLop, L.TenLop, L.MaKhoa, L.MaKhoaHoc, L.MaChuongTrinh);
                    MessageBox.Show("Da them thanh cong");
                    QuanLyLop_Load(sender, e);
                }
                catch { MessageBox.Show("Co loi!"); }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLop.TextLength == 0)
                MessageBox.Show("Ma lop khong duoc bo trong");
            else if (txtTenLop.TextLength == 0)
                MessageBox.Show("Ten lop khong duoc bo trong");
            else
            {
                try
                {
                    L.MaLop = txtMaLop.Text;
                    L.TenLop = txtTenLop.Text;
                    L.MaKhoa = cbMaKhoa.SelectedValue.ToString();
                    L.MaKhoaHoc = cbMaKhoaHoc.SelectedValue.ToString();
                    L.MaChuongTrinh = cbMaChuongTrinh.SelectedValue.ToString();
                    l.UpdateLop(L.MaLop, L.TenLop, L.MaKhoa, L.MaKhoaHoc, L.MaChuongTrinh);
                    MessageBox.Show("Da sua thanh cong");
                    QuanLyLop_Load(sender, e);
                }
                catch { MessageBox.Show("Co loi!"); }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLop.TextLength == 0)
                MessageBox.Show("Chon ma lop de xoa");
            else
            {
                DialogResult drl = MessageBox.Show("Ban co muon xoa!", "Thong bao", MessageBoxButtons.YesNo);
                if (drl == DialogResult.Yes)
                {
                    try
                    {
                        L.MaLop = txtMaLop.Text;
                        l.DeleteLop(L.MaLop);
                        MessageBox.Show("Da xoa thanh cong");
                        QuanLyLop_Load(sender, e);
                    }
                    catch { MessageBox.Show("Co loi!"); }
                }
            }
        }

        private void dgvLop_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtMaLop.Text = dgvLop.Rows[dong].Cells[0].Value.ToString();
                txtTenLop.Text = dgvLop.Rows[dong].Cells[1].Value.ToString();
                cbMaKhoa.SelectedValue = dgvLop.Rows[dong].Cells[2].Value.ToString();
                cbMaKhoaHoc.SelectedValue = dgvLop.Rows[dong].Cells[3].Value.ToString();
                cbMaChuongTrinh.SelectedValue = dgvLop.Rows[dong].Cells[4].Value.ToString();
            }
            catch { MessageBox.Show("Co loi!"); }
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
