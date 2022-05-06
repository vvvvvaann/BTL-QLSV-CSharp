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

namespace CrystalReport
{
    public partial class CrystalReport : Form
    {
        public CrystalReport()
        {
            InitializeComponent();
        }

        string str = @"Data Source=NITRO\DIHVO;Initial Catalog=Nhom4QLSV;Integrated Security=True";
        SqlConnection con = null;
        SqlDataAdapter da = null;
        DataTable dt = null;

        private void btnInDSSV_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            string sql = "select MaSinhVien, TenSinhVien, NamSinh, GioiTinh, DanToc, Lop.MaLop, Khoa.MaKhoa, KhoaHoc.MaKhoaHoc from SinhVien " +
                "inner join Lop on Lop.MaLop = SinhVien.MaLop " +
                "inner join Khoa on Khoa.MaKhoa = Lop.MaKhoa " +
                "inner join KhoaHoc on KhoaHoc.MaKhoaHoc = Lop.MaKhoaHoc";
            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt);
            rptDSSV ds = new rptDSSV();
            ds.SetDataSource(dt);
            InDSSV dssv = new InDSSV();
            dssv.crystalReportDSSV.ReportSource = ds;
            dssv.ShowDialog();
        }

        private void btnInDSKQ_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            string sql = "select KetQua.MaSinhVien, SinhVien.TenSinhVien, KetQua.MaMonHoc, MonHoc.TenMonHoc, LanThi, DiemThi from KetQua " +
                "inner join SinhVien on SinhVien.MaSinhVien = KetQua.MaSinhVien " +
                "inner join MonHoc on MonHoc.MaMonHoc = KetQua.MaMonHoc";
            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt);
            rptDSKQ ds = new rptDSKQ();
            ds.SetDataSource(dt);
            InDSKQ dssv = new InDSKQ();
            dssv.crystalReportDSKQ.ReportSource = ds;
            dssv.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
