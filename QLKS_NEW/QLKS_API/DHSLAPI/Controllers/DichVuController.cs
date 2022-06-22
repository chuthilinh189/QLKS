using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QLKSAPI.Models;

namespace QLKSAPI.Controllers
{
    public class DichVuController : ApiController
    {
        private readonly Connection con = new Connection();



        [HttpGet]
        [Route("api/DichVus")]
        public List<DichVu> SelectAllDichVus()
        {
            return con.SelectAllDichVu();
        }

        [HttpGet]
        [Route("api/DichVuById")]
        public DichVu SelectDichVuById(string MaDV)
        {
            return con.SelectDichVuById(MaDV);
        }

        [HttpGet]
        [Route("api/DichVuSelectTop")]
        public List<DichVu> DichVuSelectTop(string Top, string Where, string Order)
        {
            return con.DichVuSelectTop(Top, Where, Order);
        }

        [HttpPost]
        [Route("api/DichVu_Insert")]
        public HttpResponseMessage InsertLoaiPhong([FromBody] DichVu dv)
        {

            return con.insertDichVu(dv) ? Request.CreateResponse(HttpStatusCode.Created, dv) : Request.CreateResponse(HttpStatusCode.Conflict);
        }

        [HttpPut]
        [Route("api/DichVu_Update")]
        public HttpResponseMessage UpdateUser([FromBody] DichVu dv)
        {

            return con.updateDichVu(dv) ? Request.CreateResponse(HttpStatusCode.OK, dv) : Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpDelete]
        [Route("api/DichVu_Delete")]
        public DichVu deleteDichVu(string MaDV)
        {
            return con.deleteDichVu(MaDV) ? new DichVu()
            {
                MaDV = MaDV
            } : null;
        }

    }
}
