using QLKSAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QLKSAPI.Controllers
{
    public class DangKiController : ApiController
    {
        private readonly Connection con = new Connection();

        [HttpGet]
        [Route("api/DangKySelectAll")]
        public List<DangKy> DangKySelectAll()
        {
            return con.DangKySelectAll();
        }

        [HttpGet]
        [Route("api/DangKySelectTop")]
        public List<DangKy> DangKySelectTop(string Top, string Where, string Order)
        {
            return con.DangKySelectTop(Top, Where, Order);
        }

        [HttpGet]
        [Route("api/DangKySelectByID")]
        public DangKy DangKySelectByID(string MaDK)
        {
            return con.DangKySelectByID(MaDK);
        }

        [HttpPost]
        [Route("api/DangKyInsert")]
        public HttpResponseMessage DangKyInsert([FromBody] DangKy dk)
        {
            //nv.MaNV = Helper.EnCode(DateTime.Now.ToString("yyyy-mm-dd:hh-mm-ss"));

            dk.MaDK = Helper.EnCode(DateTime.Now.ToString("yyyy-mm-dd:hh-mm-ss"));
            return con.DangKyInsert(dk) ? Request.CreateResponse(HttpStatusCode.Created, dk) : Request.CreateResponse(HttpStatusCode.Conflict);
        }

        [HttpDelete]
        [Route("api/DangKyDelete")]
        public HttpResponseMessage DangKyDelete(string MaDK)
        {
            return con.DangKyDelete(MaDK) ? Request.CreateResponse(HttpStatusCode.Created, MaDK) : Request.CreateResponse(HttpStatusCode.Conflict);
        }

        [HttpPut]
        [Route("api/DangKyUpdate")]
        public HttpResponseMessage DangKyUpdate([FromBody] DangKy dk)
        {
            return con.DangKyUpdate(dk) ? Request.CreateResponse(HttpStatusCode.OK, dk) : Request.CreateResponse(HttpStatusCode.NotFound);
        }


    }
}