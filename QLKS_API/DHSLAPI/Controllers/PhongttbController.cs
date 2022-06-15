using QLKSAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace DHSLAPI.Controllers
{
    public class PhongttbController : ApiController
    {
        private readonly Connection con = new Connection();

        [HttpGet]
        [Route("api/Phongttbs")]
        public List<Phongttb> getAllPhongttbs()
        {
            return con.getAllPhongttbs();
        }

        [HttpGet]
        [Route("api/Phongttb_by_ma")]
        public Phongttb getPhongttbByMa(string mattb)
        {
            return con.getPhongttbByMa(mattb);
        }

        [HttpGet]
        [Route("api/Phongttb_search")]
        public List<Phongttb> searchPhongttbs(string key)
        {
            return con.searchPhongttbs(key);
        }

        [HttpPost]
        [Route("api/Phongttb_insert")]
        public HttpResponseMessage insertPhongttb([FromBody] Phongttb ttb)
        {
            ttb.mattb = Helper.EnCode(DateTime.Now.ToString("yyyy-mm-dd:hh-mm-ss"));
            return con.insertPhongttb(ttb) ? Request.CreateResponse(HttpStatusCode.Created, ttb) : Request.CreateResponse(HttpStatusCode.Conflict);
        }

        [HttpPut]
        [Route("api/Phongttb_update")]
        public HttpResponseMessage updatePhongttb([FromBody] Phongttb ttb)
        {
            return con.updatePhongttb(ttb) ? Request.CreateResponse(HttpStatusCode.OK, ttb) : Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpDelete]
        [Route("api/Phongttb_delete")]
        public HttpResponseMessage deletePhongttb([FromUri] string id)
        {
            return con.deletePhongttb(id) ? Request.CreateResponse(HttpStatusCode.OK, id) : Request.CreateResponse(HttpStatusCode.NotFound);
        }
    }
}