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
    public partial class QuanLyGiangKhoa : Form
    {
        public QuanLyGiangKhoa()
        {
            InitializeComponent();
        }
        GiangKhoa_DTO GK = new GiangKhoa_DTO();
        GiangKhoa_BUS gk = new GiangKhoa_BUS();
        private void QuanLyGiangKhoa_Load(object sender, EventArgs e)
        {
            //Load MaChuongTrinh
            Data da = new Data();
            string sql = "select * from ChuongTrinhHoc";
            cbMaChuongTrinh.DataSource = da.GetTable(sql);
            cbMaChuongTrinh.DisplayMember = "TenChuongTrinh";
            cbMaChuongTrinh.ValueMember = "MaChuongTrinh";
            //Load MaKhoa
            Data da2 = new Data();
            string sql2 = "select * from Khoa";
            cbMaKhoa.DataSource = da2.GetTable(sql2);
            cbMaKhoa.DisplayMember = "TenKhoa";
            cbMaKhoa.ValueMember = "MaKhoa";
            //Load MaMonHoc
            Data da3 = new Data();
            string sql3 = "select * from MonHoc";
            cbMaMonHoc.DataSource = da3.GetTable(sql3);
            cbMaMonHoc.DisplayMember = "TenMonHoc";
            cbMaMonHoc.ValueMember = "MaMonHoc";
            //Load HocKy
            Data da4 = new Data();
            string sql4 = "select * from HocKy";
            cbHocKy.DataSource = da4.GetTable(sql4);
            cbHocKy.DisplayMember = "HocKy";
            cbHocKy.ValueMember = "HocKy";
            //Load GiangKhoa
            dgvGiangKhoa.DataSource = gk.ShowGiangKhoa();
        }

        private void dgvGiangKhoa_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                cbMaChuongTrinh.SelectedValue = dgvGiangKhoa.Rows[dong].Cells[0].Value.ToString();
                cbMaKhoa.SelectedValue = dgvGiangKhoa.Rows[dong].Cells[1].Value.ToString();
                cbMaMonHoc.SelectedValue = dgvGiangKhoa.Rows[dong].Cells[2].Value.ToString();
                txtNamHoc.Text = dgvGiangKhoa.Rows[dong].Cells[3].Value.ToString();
                cbHocKy.SelectedValue = dgvGiangKhoa.Rows[dong].Cells[4].Value.ToString();
                txtSoTietLT.Text = dgvGiangKhoa.Rows[dong].Cells[5].Value.ToString();
                txtSoTietTH.Text = dgvGiangKhoa.Rows[dong].Cells[6].Value.ToString();
                txtSoTinChi.Text = dgvGiangKhoa.Rows[dong].Cells[7].Value.ToString();
            }
            catch { MessageBox.Show("Co loi!"); }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtNamHoc.TextLength == 0)
                MessageBox.Show("Nam hoc khong duoc bo trong");
            else if (txtSoTietLT.TextLength == 0)
                MessageBox.Show("So tiet LT khong duoc bo trong");
            else if (txtSoTietTH.TextLength == 0)
                MessageBox.Show("So tiet TH khong duoc bo trong");
            else if (txtSoTinChi.TextLength == 0)
                MessageBox.Show("So tin chi khong duoc bo trong");
            else
            {
                try
                {
                    GK.MaCHuongTrinh = cbMaChuongTrinh.SelectedValue.ToString();
                    GK.MaKhoa = cbMaKhoa.SelectedValue.ToString();
                    GK.MaMonHoc = cbMaMonHoc.SelectedValue.ToString();
                    GK.HocKy = Int32.Parse(cbHocKy.SelectedValue.ToString());
                    GK.NamHoc = Int32.Parse(txtNamHoc.Text);
                    GK.SoTietLT = Int32.Parse(txtSoTietLT.Text);
                    GK.SoTietTH = Int32.Parse(txtSoTietTH.Text);
                    GK.SoTinChi = Int32.Parse(txtSoTinChi.Text);
                    gk.InsertGiangKhoa(GK.MaCHuongTrinh, GK.MaKhoa, GK.MaMonHoc, GK.NamHoc, GK.HocKy, GK.SoTietLT, GK.SoTietTH, GK.SoTinChi);
                    MessageBox.Show("Da them thanh cong");
                    QuanLyGiangKhoa_Load(sender, e);
                }
                catch { MessageBox.Show("Co loi!"); }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtNamHoc.TextLength == 0)
                MessageBox.Show("Nam hoc khong duoc bo trong");
            else if (txtSoTietLT.TextLength == 0)
                MessageBox.Show("So tiet LT khong duoc bo trong");
            else if (txtSoTietTH.TextLength == 0)
                MessageBox.Show("So tiet TH khong duoc bo trong");
            else if (txtSoTinChi.TextLength == 0)
                MessageBox.Show("So tin chi khong duoc bo trong");
            else
            {
                try
                {
                    GK.MaCHuongTrinh = cbMaChuongTrinh.SelectedValue.ToString();
                    GK.MaKhoa = cbMaKhoa.SelectedValue.ToString();
                    GK.MaMonHoc = cbMaMonHoc.SelectedValue.ToString();
                    GK.HocKy = Int32.Parse(cbHocKy.SelectedValue.ToString());
                    GK.NamHoc = Int32.Parse(txtNamHoc.Text);
                    GK.SoTietLT = Int32.Parse(txtSoTietLT.Text);
                    GK.SoTietTH = Int32.Parse(txtSoTietTH.Text);
                    GK.SoTinChi = Int32.Parse(txtSoTinChi.Text);
                    gk.UpdateGiangKhoa(GK.MaCHuongTrinh, GK.MaKhoa, GK.MaMonHoc, GK.NamHoc, GK.HocKy, GK.SoTietLT, GK.SoTietTH, GK.SoTinChi);
                    MessageBox.Show("Da sua thanh cong");
                    QuanLyGiangKhoa_Load(sender, e);
                }
                catch { MessageBox.Show("Co loi!"); }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtNamHoc.TextLength == 0)
                MessageBox.Show("Chon nam hoc de xoa");
            else
            {
                DialogResult drl = MessageBox.Show("Ban co muon xoa!", "Thong bao", MessageBoxButtons.YesNo);
                if (drl == DialogResult.Yes)
                {
                    try
                    {
                        GK.MaCHuongTrinh = cbMaChuongTrinh.SelectedValue.ToString();
                        GK.MaKhoa = cbMaKhoa.SelectedValue.ToString();
                        GK.MaMonHoc = cbMaMonHoc.SelectedValue.ToString();
                        GK.NamHoc = Int32.Parse(txtNamHoc.Text);
                        GK.HocKy = Int32.Parse(cbHocKy.SelectedValue.ToString());
                        gk.DeleteGiangKhoa(GK.MaCHuongTrinh, GK.MaKhoa, GK.MaMonHoc, GK.NamHoc, GK.HocKy);
                        MessageBox.Show("Da xoa thanh cong");
                        QuanLyGiangKhoa_Load(sender, e);
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
