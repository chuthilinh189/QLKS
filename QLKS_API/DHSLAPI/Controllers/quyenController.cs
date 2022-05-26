using QLKSAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DHSLAPI.Controllers
{
    public class quyenController : ApiController
    {
        private readonly Connection con = new Connection();

        [HttpGet]
        [Route("api/quyens")]
        public List<quyen> getAllQuyens()
        {
            return con.getAllQuyens();
        }

    }
}