using QLKSAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DHSLAPI.Controllers
{
    public class loaiphongController : ApiController
    {
        private readonly Connection con = new Connection();

       

        [HttpGet]
        [Route("api/loaiphongs")]
        public List<loaiphong> getAllLoaiPhongs()
        {
            return con.getAllLoaiPhongs();
        }

        [HttpGet]
        [Route("api/loaiphong_by_ma")]
        public loaiphong getLoaiPhongByMa(string lp_ma)
        {
            return con.getLoaiPhongByMa(lp_ma);
        }

        [HttpGet]
        [Route("api/loaiphong_search")]
        public List<loaiphong> searchLoaiPhongs(string key)
        {
            return con.searchLoaiPhongs(key);
        }

        [HttpPost]
        [Route("api/loaiphong_insert")]
        public HttpResponseMessage InsertLoaiPhong([FromBody] loaiphong lp)
        {
           
            return con.insertLoaiPhong(lp) ? Request.CreateResponse(HttpStatusCode.Created, lp) : Request.CreateResponse(HttpStatusCode.Conflict);
        }

        [HttpPut]
        [Route("api/loaiphong_update")]
        public HttpResponseMessage UpdateUser([FromBody] loaiphong lp)
        {
            
            return con.updateLoaiPhong(lp) ? Request.CreateResponse(HttpStatusCode.OK, lp) : Request.CreateResponse(HttpStatusCode.NotFound);
        }
    }

}