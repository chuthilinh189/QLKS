using QLKSAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DHSLAPI.Controllers
{
    public class TrangthietbiController : ApiController
    {
        private readonly Connection con = new Connection();

        [HttpGet]
        [Route("api/Trangthietbis")]
        public List<Trangthietbi> getAllTrangthietbis()
        {
            return con.getAllTrangthietbis();
        }

        [HttpGet]
        [Route("api/Trangthietbi_by_ma")]
        public Trangthietbi getTrangthietbiByMa(string mattb)
        {
            return con.getTrangthietbiByMa(mattb);
        }

        [HttpGet]
        [Route("api/Trangthietbi_search")]
        public List<Trangthietbi> searchTrangthietbis(string key)
        {
            return con.searchTrangthietbis(key);
        }

        [HttpPost]
        [Route("api/Trangthietbi_insert")]
        public HttpResponseMessage insertTrangthietbi([FromBody] Trangthietbi ttb)
        {
            ttb.mattb = Helper.EnCode(DateTime.Now.ToString("yyyy-mm-dd:hh-mm-ss"));
            return con.insertTrangthietbi(ttb) ? Request.CreateResponse(HttpStatusCode.Created, ttb) : Request.CreateResponse(HttpStatusCode.Conflict);
        }

        [HttpPut]
        [Route("api/Trangthietbi_update")]
        public HttpResponseMessage updateTrangthietbi([FromBody] Trangthietbi ttb)
        {
            return con.updateTrangthietbi(ttb) ? Request.CreateResponse(HttpStatusCode.OK, ttb) : Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpDelete]
        [Route("api/Trangthietbi_delete")]
        public HttpResponseMessage deleteTrangthietbi([FromUri] string id)
        {
            return con.deleteTrangthietbi(id) ? Request.CreateResponse(HttpStatusCode.OK, id) : Request.CreateResponse(HttpStatusCode.NotFound);
        }

    }
}