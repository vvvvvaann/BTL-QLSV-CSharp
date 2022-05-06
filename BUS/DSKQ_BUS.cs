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
    public class DSKQ_BUS
    {
        Data data = new Data();
        DSKQ_DTO DanhSachKetQua = new DSKQ_DTO();
        public DataTable ShowDSKQ()
        {
            string sql = "select KetQua.MaSinhVien, SinhVien.TenSinhVien, KetQua.MaMonHoc, MonHoc.TenMonHoc, LanThi, DiemThi from KetQua " +
                "inner join SinhVien on SinhVien.MaSinhVien = KetQua.MaSinhVien " +
                "inner join MonHoc on MonHoc.MaMonHoc = KetQua.MaMonHoc";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public DataTable ShowDSKQ_MonHoc(string mmh)
        {
            string sql = "select KetQua.MaSinhVien, SinhVien.TenSinhVien, KetQua.MaMonHoc, MonHoc.TenMonHoc, LanThi, DiemThi from KetQua " +
                "inner join SinhVien on SinhVien.MaSinhVien = KetQua.MaSinhVien " +
                "inner join MonHoc on MonHoc.MaMonHoc = KetQua.MaMonHoc " +
                "where MonHoc.TenMonHoc='" + mmh + "'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public DataTable TimKiemKQ(string tk)
        {
            string sql = "select KetQua.MaSinhVien, SinhVien.TenSinhVien, KetQua.MaMonHoc, MonHoc.TenMonHoc, LanThi, DiemThi from KetQua " +
                "inner join SinhVien on SinhVien.MaSinhVien = KetQua.MaSinhVien " +
                "inner join MonHoc on MonHoc.MaMonHoc = KetQua.MaMonHoc " +
                "where KetQua.MaSinhVien like '%" + tk + "%' OR SinhVien.TenSinhVien like '%" + tk + "%'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
    }
}
