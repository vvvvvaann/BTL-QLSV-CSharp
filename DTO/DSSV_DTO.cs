﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DSSV_DTO
    {
        string masinhvien_, tensinhvien_, gioitinh_, dantoc_, malop_, makhoa_, makhoahoc_; int namsinh_;
        public string MaSinhVien
        { get { return masinhvien_; } set { masinhvien_ = value; } }
        public string TenSinhVien
        { get { return tensinhvien_; } set { tensinhvien_ = value; } }
        public string GioiTinh
        { get { return gioitinh_; } set { gioitinh_ = value; } }
        public string DanToc
        { get { return dantoc_; } set { dantoc_ = value; } }
        public string MaLop
        { get { return malop_; } set { malop_ = value; } }
        public string MaKhoa
        { get { return makhoa_; } set { makhoa_ = value; } }
        public string MaKhoaHoc
        { get { return makhoahoc_; } set { makhoahoc_ = value; } }
        public int NamSinh
        { get { return namsinh_; } set { namsinh_ = value; } }
    }
}
