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
    public class KetQua_BUS
    {
        Data data = new Data();
        KetQua_DTO KetQua = new KetQua_DTO();
        public DataTable ShowKetQua()
        {
            string sql = "select * from KetQua";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public void InsertKetQua(string msv, string mmh, int lt, float dt)
        {
            string sql = "insert KetQua values('" + msv + "','" + mmh + "','" + lt + "','" + dt + "')";
            data.ExcuteNonQuery(sql);
        }
        public void UpdateKetQua(string msv, string mmh, int lt, float dt)
        {
            string sql = "update KetQua set DiemThi='" + dt + "' where MaSinhVien='" + msv + "' and MaMonHoc='" + mmh + "' and LanThi='" + lt + "'";
            data.ExcuteNonQuery(sql);
        }
        public void DeleteKetQua(string msv, string mmh, int lt)
        {
            string sql = "delete KetQua where MaSinhVien='" + msv + "' and MaMonHoc='" + mmh + "' and LanThi='" + lt + "'";
            data.ExcuteNonQuery(sql);
        }
    }
}
