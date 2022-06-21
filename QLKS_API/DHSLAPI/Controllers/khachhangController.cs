using QLKSAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DHSLAPI.Controllers
{
    public class khachhangController : ApiController
    {
        private readonly Connection con = new Connection();

        [HttpGet]
        [Route("api/khachhangs")]
        public List<khachhang> getAllKhachhangs()
        {
            return con.getAllKhachhangs();
        }

        [HttpGet]
        [Route("api/khachhang_by_ma")]
        public khachhang getKhachHangByMa(string kh_ma)
        {
            return con.getKhachHangByMa(kh_ma);
        }

       
        [HttpPost]
        [Route("api/khachhang_insert")]
        public HttpResponseMessage insertKhachHang([FromBody] khachhang kh)
        {
          
            return con.insertKhachHang(kh) ? Request.CreateResponse(HttpStatusCode.Created, kh) : Request.CreateResponse(HttpStatusCode.Conflict);
        }

        [HttpPut]
        [Route("api/khachhang_update")]
        public HttpResponseMessage updateKhachHang([FromBody] khachhang kh)
        {
            
            return con.updateKhachHang(kh) ? Request.CreateResponse(HttpStatusCode.OK, kh) : Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpDelete]
        [Route("api/khachhang_delete")]
        public HttpResponseMessage deleteKhachHang([FromUri] string id)
        {
            return con.deleteKhachHang(id) ? Request.CreateResponse(HttpStatusCode.OK, id) : Request.CreateResponse(HttpStatusCode.NotFound);
        }

    }
}