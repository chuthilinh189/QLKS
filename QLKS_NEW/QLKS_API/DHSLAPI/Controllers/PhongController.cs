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

        [HttpGet]
        [Route("api/PhongSelectTop")]
        public List<Phong> PhongSelectTop(string Top, string Where, string Order)
        {
            return con.PhongSelectTop(Top, Where, Order);
        }

        [HttpPost]
        [Route("api/Phong_Insert")]
        public HttpResponseMessage InsertLoaiPhong([FromBody] Phong p)
        {
            p.MaPhong = Helper.EnCode(DateTime.Now.ToString("yyyy-mm-dd:hh-mm-ss"));
            return con.insertPhong(p) ? Request.CreateResponse(HttpStatusCode.Created, p) : Request.CreateResponse(HttpStatusCode.Conflict);
        }

        [HttpPut]
        [Route("api/Phong_Update")]
        public HttpResponseMessage UpdateUser([FromBody] Phong p)
        {

            return con.updatePhong(p) ? Request.CreateResponse(HttpStatusCode.OK, p) : Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpDelete]
        [Route("api/Phong_Delete")]
        public Phong deletePhong(string MaPhong)
        {
            return con.deletePhong(MaPhong) ? new Phong()
            {
                MaPhong = MaPhong
            } : null;
        }


        [HttpGet]
        [Route("api/PhongDaDKs")]
        public List<Phong> SelectPhongDaDK()
        {
            return con.SelectPhongDaDK();
        }

        [HttpGet]
        [Route("api/PhongDaNhans")]
        public List<Phong> SelectPhongDaNhan()
        {
            return con.SelectPhongDaNhan();
        }

    }
}
