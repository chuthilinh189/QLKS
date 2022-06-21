using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLKSAPI.Models
{
    public class DangKy
    {
        public string MaDK { get; set; }
        public KhachHang KhachHangDK { get; set; }
        public Phong PhongDK { get; set; }
        public DateTime NgayDangKy { get; set; }
        public DateTime? NgayDen { get; set; }
        public DateTime? NgayDi { get; set; }
        public int TienDat { get; set; }
        public int SoNguoi { get; set; }
        public string GhiChu { get; set; }

    }
}