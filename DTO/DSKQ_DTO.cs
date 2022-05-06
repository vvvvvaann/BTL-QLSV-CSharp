using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DSKQ_DTO
    {
        string masinhvien_, tensinhvien_, mamonhoc_, tenmonhoc_; int lanthi_; float dienthi_;
        public string MaSinhVien
        { get { return masinhvien_; } set { masinhvien_ = value; } }
        public string TenSinhVien
        { get { return tensinhvien_; } set { tensinhvien_ = value; } }
        public string MaMonHoc
        { get { return mamonhoc_; } set { mamonhoc_ = value; } }
        public string TenMonHoc
        { get { return tenmonhoc_; } set { tenmonhoc_ = value; } }
        public int LanThi
        { get { return lanthi_; } set { lanthi_ = value; } }
        public float DiemThi
        { get { return dienthi_; } set { dienthi_ = value; } }
    }
}
