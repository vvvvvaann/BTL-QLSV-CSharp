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
    public partial class DanhSachSinhVien : Form
    {
        public DanhSachSinhVien()
        {
            InitializeComponent();
        }
        DSSV_DTO DSSV = new DSSV_DTO();
        DSSV_BUS dssv = new DSSV_BUS();
        private void DanhSachSinhVien_Load(object sender, EventArgs e)
        {
            //Load MaLop
            Data da = new Data();
            string sql = "select * from Lop";
            cbMaLop.DataSource = da.GetTable(sql);
            cbMaLop.DisplayMember = "MaLop";
            cbMaLop.ValueMember = "MaLop";
            //Load MaKhoa
            Data da2 = new Data();
            string sql2 = "select * from Khoa";
            cbMaKhoa.DataSource = da2.GetTable(sql2);
            cbMaKhoa.DisplayMember = "MaKhoa";
            cbMaKhoa.ValueMember = "MaKhoa";
            //Load MaKhoaHoc
            Data da3 = new Data();
            string sql3 = "select * from KhoaHoc";
            cbMaKhoaHoc.DataSource = da3.GetTable(sql3);
            cbMaKhoaHoc.DisplayMember = "MaKhoaHoc";
            cbMaKhoaHoc.ValueMember = "MaKhoaHoc";
            //Load SinhVien
            dgvDSSV.DataSource = dssv.ShowDSSV();
        }

        private void cbMaLop_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvDSSV.DataSource = dssv.ShowDSSV_Lop(cbMaLop.Text);
        }

        private void cbMaKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvDSSV.DataSource = dssv.ShowDSSV_Khoa(cbMaKhoa.Text);
        }

        private void cbMaKhoaHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvDSSV.DataSource = dssv.ShowDSSV_KhoaHoc(cbMaKhoaHoc.Text);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvDSSV.DataSource = dssv.TimKiemSV(txtTimKiem.Text);
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DanhSachSinhVien_Load(sender, e);
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
