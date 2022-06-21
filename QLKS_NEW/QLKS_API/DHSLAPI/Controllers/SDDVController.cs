using DHSLAPI.Models;
using QLKSAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DHSLAPI.Controllers
{
    public class SDDVController : ApiController
    {
        // GET: SDDV
        private readonly Connection con = new Connection();

        [HttpGet]
        [Route("api/SddvAll")]
        public List<SDDV> SDDVSelectAll()
        {
            return con.SDDVSelectAll();
        }

        [HttpGet]
        [Route("api/SddvAllByID")]
        public List<SDDV> SDDVSelectAllByID(string MaDK)
        {
            return con.SDDVSelectAllByID(MaDK);
        }

        [HttpGet]
        [Route("api/SddvByID")]
        public List<SDDV> SDDVSelectByID(string MaDK, string MaDV)
        {
            return con.SDDVSelectByID(MaDK, MaDV);
        }

        [HttpGet]
        [Route("api/SDDVSelectTop")]
        public List<SDDV> SDDVSelectTop(string Top, string Where, string Order)
        {
            return con.SDDVSelectTop(Top, Where, Order);
        }

        [HttpGet]
        [Route("api/SddvTestByID")]
        public bool SDDVTestByID(string MaDK, string MaDV)
        {
            return con.SDDVTestByID(MaDK, MaDV);
        }

        [HttpPost]
        [Route("api/SddvInsert")]
        public bool SDDVInsert(SDDV sddv)
        {
            return con.SDDVInsert(sddv);
        }

        [HttpDelete]
        [Route("api/SddvDelete")]
        public bool SDDVDelete(string MaDK, string MaDV)
        {
            return con.SDDVDelete(MaDK, MaDV);
        }

        [HttpPut]
        [Route("api/SddvUpdate")]
        public bool SDDVUpdate(SDDV cv)
        {
            return con.SDDVUpdate(cv);
        }
    }
}