using DHSLAPI.Models;
using QLKSAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DHSLAPI.Controllers
{
    public class ThanhToanController : ApiController
    {
        // GET: SDDV
        private readonly Connection con = new Connection();

        [HttpGet]
        [Route("api/ThanhToanAll")]
        public List<ThanhToan> SDDVSelectAll()
        {
            return con.ThanhToanSelectAll();
        }

        [HttpGet]
        [Route("api/ThanhToanAllByID")]
        public List<ThanhToan> ThanhToanAllByID(string MaDK, string MaPhong)
        {
            return con.ThanhToanSelectAllByID(MaDK, MaPhong);
        }

        

        [HttpGet]
        [Route("api/ThanhToanSelectTop")]
        public List<ThanhToan> ThanhToanSelectTop(string Top, string Where, string Order)
        {
            return con.ThanhToanSelectTop(Top, Where, Order);
        }

        [HttpGet]
        [Route("api/ThanhToanTestByID")]
        public bool ThanhToanTestByID(string MaDK, string MaPhong)
        {
            return con.ThanhToanTestByID(MaDK, MaPhong);
        }

        [HttpPost]
        [Route("api/ThanhToanInsert")]
        public bool ThanhToanInsert(ThanhToan tt)
        {
            return con.ThanhToanInsert(tt);
        }

        [HttpDelete]
        [Route("api/ThanhToanDelete")]
        public bool ThanhToanDelete(string MaDK, string MaPhong)
        {
            return con.ThanhToanDelete(MaDK, MaPhong);
        }

        [HttpPut]
        [Route("api/ThanhToanUpdate")]
        public bool ThanhToanUpdate(ThanhToan tt)
        {
            return con.ThanhToanUpdate(tt);
        }
    }
}