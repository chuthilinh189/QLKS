using QLKSAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace DHSLAPI.Controllers
{
    public class phongController : ApiController
    {
        private readonly Connection con = new Connection();



        [HttpGet]
        [Route("api/phongs")]
        public List<phong> getAllPhongs()
        {
            return con.getAllPhongs();
        }

        [HttpGet]
        [Route("api/phong_by_ma")]
        public phong getPhongByMa(string p_ma)
        {
            return con.getPhongByMa(p_ma);
        }

        [HttpGet]
        [Route("api/phong_by_loaiphong")]
        public phong getPhongByLoaiPhong(string p_malp)
        {
            return con.getPhongByLoaiPhong(p_malp);
        }

        [HttpGet]
        [Route("api/phong_search")]
        public List<phong> searchPhongs(string key)
        {
            return con.searchPhongs(key);
        }

        [HttpPost]
        [Route("api/phong_insert")]
        public HttpResponseMessage InsertLoaiPhong([FromBody] phong p)
        {

            return con.insertPhong(p) ? Request.CreateResponse(HttpStatusCode.Created, p) : Request.CreateResponse(HttpStatusCode.Conflict);
        }

        [HttpPut]
        [Route("api/phong_update")]
        public HttpResponseMessage UpdateUser([FromBody] phong p)
        {

            return con.updatePhong(p) ? Request.CreateResponse(HttpStatusCode.OK, p) : Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpGet]
        [Route("api/phong_delete")]
        public phong deletePhong(string p_ma)
        {
            return con.deletePhong(p_ma) ? new phong()
            {
                p_ma = p_ma
            } : null;
        }

    }
}