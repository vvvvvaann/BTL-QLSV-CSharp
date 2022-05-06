using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiangKhoa_DTO
    {
        string machuongtrinh_, makhoa_, mamonhoc_;
        int namhoc_, hocky_, sotietlt_, sotietth_, sotinchi_;
        public string MaCHuongTrinh
        { get { return machuongtrinh_; } set { machuongtrinh_ = value; } }
        public string MaKhoa
        { get { return makhoa_; } set { makhoa_ = value; } }
        public string MaMonHoc
        { get { return mamonhoc_; } set { mamonhoc_ = value; } }
        public int NamHoc
        { get { return namhoc_; } set { namhoc_ = value; } }
        public int HocKy
        { get { return hocky_; } set { hocky_ = value; } }
        public int SoTietLT
        { get { return sotietlt_; } set { sotietlt_ = value; } }
        public int SoTietTH
        { get { return sotietth_; } set { sotietth_ = value; } }
        public int SoTinChi
        { get { return sotinchi_; } set { sotinchi_ = value; } }
    }
}
