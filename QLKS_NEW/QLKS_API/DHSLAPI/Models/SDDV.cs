using QLKSAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DHSLAPI.Models
{
    public class SDDV
    {
        public string MaDK { get; set; }
        public DichVu DichVu { get; set; }
        public NhanVien NhanVien { get; set; }
        public DateTime NgaySuDung { get; set; }

        public int SoLuong { get; set; }
    }
}