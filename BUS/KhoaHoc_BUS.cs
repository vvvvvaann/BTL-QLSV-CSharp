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
    public class KhoaHoc_BUS
    {
        Data data = new Data();
        KhoaHoc_DTO KhoaHoc = new KhoaHoc_DTO();
        public DataTable ShowKhoaHoc()
        {
            string sql = "select * from KhoaHoc";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public void InsertKhoaHoc(string mkh, int nbd, int nkt)
        {
            string sql = "insert KhoaHoc values('" + mkh + "','" + nbd + "','" + nkt + "')";
            data.ExcuteNonQuery(sql);
        }
        public void UpdateKhoaHoc(string mkh, int nbd, int nkt)
        {
            string sql = "update KhoaHoc set NamBatDau='" + nbd + "',NamKetThuc='" + nkt + "' where MaKhoaHoc='" + mkh + "'";
            data.ExcuteNonQuery(sql);
        }
        public void DeleteKhoaHoc(string mkh)
        {
            string sql = "delete KhoaHoc where MaKhoaHoc='" + mkh + "'";
            data.ExcuteNonQuery(sql);
        }
    }
}
