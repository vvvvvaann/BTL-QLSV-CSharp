using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class DSSV_BUS
    {
        Data data = new Data();
        DSSV_DTO DanhSachSinhVien = new DSSV_DTO();
        public DataTable ShowDSSV()
        {
            string sql = "select MaSinhVien, TenSinhVien, NamSinh, GioiTinh, DanToc, Lop.MaLop, Khoa.MaKhoa, KhoaHoc.MaKhoaHoc from SinhVien " +
                "inner join Lop on Lop.MaLop = SinhVien.MaLop " +
                "inner join Khoa on Khoa.MaKhoa = Lop.MaKhoa " +
                "inner join KhoaHoc on KhoaHoc.MaKhoaHoc = Lop.MaKhoaHoc";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public DataTable ShowDSSV_Lop(string ml)
        {
            string sql = "select MaSinhVien, TenSinhVien, NamSinh, GioiTinh, DanToc, Lop.MaLop, Khoa.MaKhoa, KhoaHoc.MaKhoaHoc from SinhVien " +
                "inner join Lop on Lop.MaLop = SinhVien.MaLop " +
                "inner join Khoa on Khoa.MaKhoa = Lop.MaKhoa " +
                "inner join KhoaHoc on KhoaHoc.MaKhoaHoc = Lop.MaKhoaHoc " +
                "where Lop.MaLop= '" + ml + "'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public DataTable ShowDSSV_Khoa(string mk)
        {
            string sql = "select MaSinhVien, TenSinhVien, NamSinh, GioiTinh, DanToc, Lop.MaLop, Khoa.MaKhoa, KhoaHoc.MaKhoaHoc from SinhVien " +
                "inner join Lop on Lop.MaLop = SinhVien.MaLop " +
                "inner join Khoa on Khoa.MaKhoa = Lop.MaKhoa " +
                "inner join KhoaHoc on KhoaHoc.MaKhoaHoc = Lop.MaKhoaHoc " +
                "where Khoa.MaKhoa= '" + mk + "'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public DataTable ShowDSSV_KhoaHoc(string mkh)
        {
            string sql = "select MaSinhVien, TenSinhVien, NamSinh, GioiTinh, DanToc, Lop.MaLop, Khoa.MaKhoa, KhoaHoc.MaKhoaHoc from SinhVien " +
                "inner join Lop on Lop.MaLop = SinhVien.MaLop " +
                "inner join Khoa on Khoa.MaKhoa = Lop.MaKhoa " +
                "inner join KhoaHoc on KhoaHoc.MaKhoaHoc = Lop.MaKhoaHoc " +
                "where KhoaHoc.MaKhoaHoc= '" + mkh + "'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public DataTable TimKiemSV(string tk)
        {
            string sql = "select MaSinhVien, TenSinhVien, NamSinh, GioiTinh, DanToc, Lop.MaLop, Khoa.MaKhoa, KhoaHoc.MaKhoaHoc from SinhVien " +
                "inner join Lop on Lop.MaLop = SinhVien.MaLop " +
                "inner join Khoa on Khoa.MaKhoa = Lop.MaKhoa " +
                "inner join KhoaHoc on KhoaHoc.MaKhoaHoc = Lop.MaKhoaHoc " +
                "where MaSinhVien like '%" + tk + "%' OR TenSinhVien like '%" + tk + "%'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
    }
}
