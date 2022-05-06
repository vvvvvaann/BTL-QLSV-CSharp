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
    public class ChuongTrinhHoc_BUS
    {
        Data data = new Data();
        ChuongTrinhHoc_DTO ChuongTrinhHoc = new ChuongTrinhHoc_DTO();
        public DataTable ShowChuongTrinhHoc()
        {
            string sql = "select * from ChuongTrinhHoc";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public void InsertChuongTrinhHoc(string mct, string tct)
        {
            string sql = "insert ChuongTrinhHoc values('" + mct + "','" + tct + "')";
            data.ExcuteNonQuery(sql);
        }
        public void UpdateChuongTrinhHoc(string mct, string tct)
        {
            string sql = "update ChuongTrinhHoc set TenChuongTrinh='" + tct + "' where MaChuongTrinh='" + mct + "'";
            data.ExcuteNonQuery(sql);
        }
        public void DeleteChuongTrinhHoc(string mct)
        {
            string sql = "delete ChuongTrinhHoc where MaChuongTrinh='" + mct + "'";
            data.ExcuteNonQuery(sql);
        }
    }
}
