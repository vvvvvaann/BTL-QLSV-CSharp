using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonHoc_DTO
    {
        string mamonhoc_, makhoa_, tenmonhoc_;
        public string MaMonHoc
        { get { return mamonhoc_; } set { mamonhoc_ = value; } }
        public string MaKhoa
        { get { return makhoa_; } set { makhoa_ = value; } }
        public string TenMonHoc
        { get { return tenmonhoc_; } set { tenmonhoc_ = value; } }
    }
}
