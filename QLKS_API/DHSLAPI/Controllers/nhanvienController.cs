using QLKSAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DHSLAPI.Controllers
{
    public class nhanvienController : ApiController
    {
        private readonly Connection con = new Connection();

        ///Đăng nhập
        ///Input: mã nhân viên, mật khẩu
        ///Nếu đúng trả về thông tin nhân viên
        ///Nếu sai trả về null
        [HttpPost]
        [Route("api/nhanvien_login")]
        public nhanvien Login([FromBody] nhanvien nv)
        {
            return con.Login(new nhanvien()
            {
                manv = nv.manv,
                //matkhau = Helper.EnCode(nv.matkhau)
                matkhau = nv.matkhau
            });
        }

        [HttpGet]
        [Route("api/nhanviens")]
        public List<nhanvien> getAllNhanviens()
        {
            return con.getAllNhanviens();
        }

        [HttpPost]
        [Route("api/nhanvien_insert")]
        public HttpResponseMessage InsertUser([FromBody] nhanvien nv)
        {
            nv.manv = Helper.EnCode(DateTime.Now.ToString("yyyy-mm-dd:hh-mm-ss"));
            return con.insertNhanvien(nv) ? Request.CreateResponse(HttpStatusCode.Created, nv) : Request.CreateResponse(HttpStatusCode.Conflict);
        }

        [HttpPut]
        [Route("api/nhanvien_update")]
        public HttpResponseMessage UpdateUser([FromBody] nhanvien nv)
        {
            if (nv.matkhau != string.Empty)
                nv.matkhau = Helper.EnCode(nv.matkhau);
            return con.updateNhanvien(nv) ? Request.CreateResponse(HttpStatusCode.OK, nv) : Request.CreateResponse(HttpStatusCode.NotFound);
        }
    }
}