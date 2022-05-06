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
    public class Lop_BUS
    {
        Data data = new Data();
        Lop_DTO Lop = new Lop_DTO();
        public DataTable ShowLop()
        {
            string sql = "select * from Lop";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public void InsertLop(string ml, string tl, string mk, string mkh, string mct)
        {
            string sql = "insert Lop values('" + ml + "','" + tl + "','" + mk + "','" + mkh + "','" + mct + "')";
            data.ExcuteNonQuery(sql);
        }
        public void UpdateLop(string ml, string tl, string mk, string mkh, string mct)
        {
            string sql = "update Lop set TenLop='" + tl + "',MaKhoa='" + mk + "',MaKhoaHoc='" + mkh + "',MaChuongTrinh='" + mct + "' where MaLop='" + ml + "'";
            data.ExcuteNonQuery(sql);
        }
        public void DeleteLop(string ml)
        {
            string sql = "delete Lop where MaLop='" + ml + "'";
            data.ExcuteNonQuery(sql);
        }
    }
}
