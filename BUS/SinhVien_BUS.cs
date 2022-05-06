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
    public class SinhVien_BUS
    {
        Data data = new Data();
        SinhVien_DTO SinhVien = new SinhVien_DTO();
        public DataTable ShowSinhVien()
        {
            string sql = "select * from SinhVien";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public void InsertSinhVien(string msv, string tsv, int ns, string gt, string dt, string ml)
        {
            string sql = "insert SinhVien values('" + msv + "','" + tsv + "','" + ns + "','" + gt + "','" + dt + "','" + ml + "')";
            data.ExcuteNonQuery(sql);
        }
        public void UpdateSinhVien(string msv, string tsv, int ns, string gt, string dt, string ml)
        {
            string sql = "update SinhVien set TenSinhVien='" + tsv + "',NamSinh='" + ns + "',GioiTinh='" + gt + "',DanToc='" + dt + "',MaLop='" + ml + "' where MaSinhVien='" + msv + "'";
            data.ExcuteNonQuery(sql);
        }
        public void DeleteSinhVien(string msv)
        {
            string sql = "delete KetQua where MaSinhVien='" + msv +
                       "' delete SinhVien where MaSinhVien='" + msv + "'";
            data.ExcuteNonQuery(sql);
        }
        public DataTable TimKiemSinhVien(string msv)
        {
            string sql = "select * from SinhVien " +
                "where MaSinhVien ='" + msv + "'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
    }
}
