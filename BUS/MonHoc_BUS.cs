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
    public class MonHoc_BUS
    {
        Data data = new Data();
        MonHoc_DTO MonHoc = new MonHoc_DTO();
        public DataTable ShowMonHoc()
        {
            string sql = "select * from MonHoc";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public void InsertMonHoc(string mmh, string mk, string tmh)
        {
            string sql = "insert MonHoc values('" + mmh + "','" + mk + "','" + tmh + "')";
            data.ExcuteNonQuery(sql);
        }
        public void UpdateMonHoc(string mmh, string mk, string tmh)
        {
            string sql = "update MonHoc set MaKhoa='" + mk + "',TenMonHoc='" + tmh + "' where MaMonHoc='" + mmh + "'";
            data.ExcuteNonQuery(sql);
        }
        public void DeleteMonHoc(string mmh)
        {
            string sql = "delete MonHoc where MaMonHoc='" + mmh + "'";
            data.ExcuteNonQuery(sql);
        }
    }
}
