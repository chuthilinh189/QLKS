using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QLKSAPI.Models;

namespace QLKSAPI.Controllers
{
    public class KhachHangController : ApiController
    {
        private readonly Connection con = new Connection();
        [HttpGet]
        [Route("api/KhachHangs")]
        public List<KhachHang> SelectAllKhachHang()
        {
            return con.SelectAllKhachHang();
        }

        [HttpGet]
        [Route("api/KhachHangById")]
        public KhachHang SelectKhachHangByID(string MaKhach)
        {
            return con.SelectKhachHangById(MaKhach);
        }

        [HttpGet]
        [Route("api/KhachHangSelectTop")]
        public List<KhachHang> KhachHangSelectTop(string Top, string Where, string Order)
        {
            return con.KhachHangSelectTop(Top, Where, Order);
        }

        [HttpPost]
        [Route("api/KhachHang_Insert")]
        public HttpResponseMessage insertKhachHang([FromBody] KhachHang kh)
        {

            return con.insertKhachHang(kh) ? Request.CreateResponse(HttpStatusCode.Created, kh) : Request.CreateResponse(HttpStatusCode.Conflict);
        }

        [HttpPut]
        [Route("api/KhachHang_Update")]
        public HttpResponseMessage updateKhachHang([FromBody] KhachHang kh)
        {

            return con.updateKhachHang(kh) ? Request.CreateResponse(HttpStatusCode.OK, kh) : Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpDelete]
        [Route("api/KhachHang_Delete")]
        public HttpResponseMessage deleteKhachHang([FromUri] string id)
        {
            return con.deleteKhachHang(id) ? Request.CreateResponse(HttpStatusCode.OK, id) : Request.CreateResponse(HttpStatusCode.NotFound);
        }

    }
}
