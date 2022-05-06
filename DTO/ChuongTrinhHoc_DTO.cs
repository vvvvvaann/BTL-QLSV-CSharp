using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChuongTrinhHoc_DTO
    {
        string machuongtrinh_, tenchuongtrinh_;
        public string MaChuongTrinh
        { get { return machuongtrinh_; } set { machuongtrinh_ = value; } }
        public string TenChuongTrinh
        { get { return tenchuongtrinh_; } set { tenchuongtrinh_ = value; } }
    }
}
