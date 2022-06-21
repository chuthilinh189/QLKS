using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLKSAPI.Models
{
    public class KhachHang
    {
        public string MaKhach { get; set; }
        public string HoDem { get; set; }

        public string Ten { get; set;  }
        public DateTime NgaySinh { get; set;  }
        public string CMND { get; set;  }

        public string QuocTich { get; set;  }
        public string GhiChu { get; set; }

    }
}