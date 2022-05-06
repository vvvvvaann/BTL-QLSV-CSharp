using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhoaHoc_DTO
    {
        string makhoahoc_; int nambatddau_, namketthuc_;
        public string MaKhoaHoc
        { get { return makhoahoc_; } set { makhoahoc_ = value; } }
        public int NamBatDau
        { get { return nambatddau_; } set { nambatddau_ = value; } }
        public int NamKetThuc
        { get { return namketthuc_; } set { namketthuc_ = value; } }
    }
}
