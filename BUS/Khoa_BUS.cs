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
    public class Khoa_BUS
    {
        Data data = new Data();
        Khoa_DTO Khoa = new Khoa_DTO();
        public DataTable ShowKhoa()
        {
            string sql = "select * from Khoa";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public void InsertKhoa(string mk, string tk, int ntl)
        {
            string sql = "insert Khoa values('" + mk + "','" + tk + "','" + ntl + "')";
            data.ExcuteNonQuery(sql);
        }
        public void UpdateKhoa(string mk, string tk, int ntl)
        {
            string sql = "update Khoa set TenKhoa='" + tk + "',NamThanhLap='" + ntl + "' where MaKhoa='" + mk + "'";
            data.ExcuteNonQuery(sql);
        }
        public void DeleteKhoa(string mk)
        {
            string sql = "delete Khoa where MaKhoa='" + mk + "'";
            data.ExcuteNonQuery(sql);
        }
    }
}
