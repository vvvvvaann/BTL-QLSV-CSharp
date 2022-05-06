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
    public class GiangKhoa_BUS
    {
        Data data = new Data();
        GiangKhoa_DTO GiangKhoa = new GiangKhoa_DTO();
        public DataTable ShowGiangKhoa()
        {
            string sql = "select * from GiangKhoa";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public void InsertGiangKhoa(string mct, string mk, string mmh, int nh, int hk, int stlt, int stth, int stc)
        {
            string sql = "insert GiangKhoa values('" + mct + "','" + mk + "','" + mmh + "','" + nh + "','" + hk + "','" + stlt + "','" + stth + "','" + stc + "')";
            data.ExcuteNonQuery(sql);
        }
        public void UpdateGiangKhoa(string mct, string mk, string mmh, int nh, int hk, int stlt, int stth, int stc)
        {
            string sql = "update GiangKhoa set SoTietLT='" + stlt + "',SoTietTH='" + stth + "',SoTinChi='" + stc +
                "' where HocKy='" + hk + "' and MaChuongTrinh='" + mct + "' and MaKhoa='" + mk + "' and MaMonHoc='" + mmh + "'and NamHoc='" + nh + "'";
            data.ExcuteNonQuery(sql);
        }
        public void DeleteGiangKhoa(string mct, string mk, string mmh, int nh, int hk)
        {
            string sql = "delete GiangKhoa where MaChuongTrinh='" + mct + "' and MaKhoa='" + mk +
                "' and MaMonHoc='" + mmh + "' and NamHoc='" + nh + "' and HocKy='" + hk + "'";
            data.ExcuteNonQuery(sql);
        }
    }
}
