using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Khoa_DTO
    {
        string makhoa_, tenkhoa_; int namthanhlap_;
        public string MaKhoa
        { get { return makhoa_; } set { makhoa_ = value; } }
        public string TenKhoa
        { get { return tenkhoa_; } set { tenkhoa_ = value; } }
        public int NamThanhLap
        { get { return namthanhlap_; } set { namthanhlap_ = value; } }
    }
}
