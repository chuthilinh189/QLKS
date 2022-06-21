using QLKSAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DHSLAPI.Controllers
{
    public class ChucVuController : ApiController
    {
        private readonly Connection con = new Connection();

        [HttpGet]
        [Route("api/ChucVuAll")]
        public List<ChucVu> ChucVuSelectAll()
        {
            return con.ChucVuSelectAll();
        }

        [HttpGet]
        [Route("api/ChucVuSelectTop")]
        public List<ChucVu> ChucVuSelectTop(string Top, string Where, string Order)
        {
            return con.ChucVuSelectTop(Top, Where, Order);
        }

        [HttpGet]
        [Route("api/ChucVuSelectByID")]
        public ChucVu ChucVuSelectByID(string MaCV)
        {
            return con.ChucVuSelectByID(MaCV);
        }

        [HttpGet]
        [Route("api/ChucVuTestByID")]
        public bool ChucVuTestByID(string MaCV)
        {
            return con.ChucVuTestByID(MaCV);
        }

        [HttpPost]
        [Route("api/ChucVuInsert")]
        public bool ChucVuInsert(ChucVu cv)
        {
            cv.MaCV = Helper.EnCode(DateTime.Now.ToString("yyyy-mm-dd:hh-mm-ss"));
            return con.ChucVuInsert(cv);
        }

        [HttpPut]
        [Route("api/ChucVuUpdate")]
        public bool ChucVuUpdate(ChucVu cv)
        {
            return con.ChucVuInsert(cv);
        }

        [HttpDelete]
        [Route("api/ChucVuDelete")]
        public bool ChucVuDelete(string MaCV)
        {
            return con.ChucVuDelete(MaCV);
        }
    }
}