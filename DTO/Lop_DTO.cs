using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Lop_DTO
    {
        string malop_, tenlop_, makhoa_, makhoahoc_, machuongtrinh_;
        public string MaLop
        { get { return malop_; } set { malop_ = value; } }
        public string TenLop
        { get { return tenlop_; } set { tenlop_ = value; } }
        public string MaKhoa
        { get { return makhoa_; } set { makhoa_ = value; } }
        public string MaKhoaHoc
        { get { return makhoahoc_; } set { makhoahoc_ = value; } }
        public string MaChuongTrinh
        { get { return machuongtrinh_; } set { machuongtrinh_ = value; } }
    }
}
