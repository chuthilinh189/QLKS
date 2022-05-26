using QLKSAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DHSLAPI.Controllers
{
    public class chucvuController : ApiController
    {
        private readonly Connection con = new Connection();

        [HttpGet]
        [Route("api/chucvus")]
        public List<chucvu> getAllNhanviens()
        {
            return con.getAllChucvus();
        }
    }
}