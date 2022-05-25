using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLKSAPI.Models
{
    public class nhanvien
    {
        public string manv { get; set; }
        public chucvu chucVu { get; set; }
        public string hoten { get; set; }
        public string ngaysinh { get; set; }
        public bool gioitinh { get; set; }
        public string sdt { get; set; }
        public string cmnd { get; set; }
        public string diachi { get; set; }
        public string email { get; set; }
        public bool khoa { get; set; }
        public bool xoa { get; set; }
        public string tdn { get; set; }
        public string matkhau { get; set; }
        public quyen quyennv { get; set; }
        public string fileanh { get; set; }

    }
}