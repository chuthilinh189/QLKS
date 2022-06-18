using QLKSAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DHSLAPI.Controllers
{
    public class anhphongController : ApiController
    {
        private readonly Connection con = new Connection();

        [HttpGet]
        [Route("api/anhphong_by_phong")]
        public List<anhphong> getAnhPhongbyPhong(string ap_maphong)
        {
            return con.getAnhPhongbyPhong(ap_maphong);
        }
        [HttpPost]
        [Route("api/anhphong_insert")]
        public HttpResponseMessage InsertAnhPhong([FromBody] anhphong ap)
        {

            return con.insertAnhPhong(ap) ? Request.CreateResponse(HttpStatusCode.Created, ap) : Request.CreateResponse(HttpStatusCode.Conflict);
        }

     
        [HttpGet]
        [Route("api/anhphong_delete")]
        public anhphong deleteAnhPhong(string ap_ma)
        {
            return con.deleteAnhPhong(ap_ma) ? new anhphong()
            {
                ap_ma = ap_ma
            } : null;
        }
    }
}