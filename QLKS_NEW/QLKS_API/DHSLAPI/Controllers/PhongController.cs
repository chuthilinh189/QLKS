using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QLKSAPI.Models;

namespace QLKSAPI.Controllers
{
    public class PhongController : ApiController
    {

        private readonly Connection con = new Connection();



        [HttpGet]
        [Route("api/Phongs")]
        public List<Phong> SelectAllPhongs()
        {
            return con.SelectAllPhong();
        }

        [HttpGet]
        [Route("api/PhongById")]
        public Phong SelectPhongById(string MaPhong)
        {
            return con.SelectPhongById(MaPhong);
        }

        

        [HttpPost]
        [Route("api/Phong_Insert")]
        public HttpResponseMessage InsertLoaiPhong([FromBody] Phong p)
        {

            return con.insertPhong(p) ? Request.CreateResponse(HttpStatusCode.Created, p) : Request.CreateResponse(HttpStatusCode.Conflict);
        }

        [HttpPut]
        [Route("api/Phong_Update")]
        public HttpResponseMessage UpdateUser([FromBody] Phong p)
        {

            return con.updatePhong(p) ? Request.CreateResponse(HttpStatusCode.OK, p) : Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpGet]
        [Route("api/Phong_Delete")]
        public Phong deletePhong(string MaPhong)
        {
            return con.deletePhong(MaPhong) ? new Phong()
            {
                MaPhong = MaPhong
            } : null;
        }

    }
}
