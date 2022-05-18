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
        [HttpGet]
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
    }
}