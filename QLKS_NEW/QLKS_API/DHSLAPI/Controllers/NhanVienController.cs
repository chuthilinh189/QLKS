using QLKSAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QLKSAPI.Controllers
{
    public class nhanvienController : ApiController
    {
        private readonly Connection con = new Connection();

        ///Đăng nhập
        ///Input: mã nhân viên, mật khẩu
        ///Nếu đúng trả về thông tin nhân viên
        ///Nếu sai trả về null
        ///

        [HttpGet]
        [Route("api/NhanVienById")]
        public List<NhanVien> SelectAllByID(string MaNV)
        {
            return con.SelectAllByID(MaNV);
        }
        [HttpGet]
        [Route("api/NhanVienAll")]
        public List<NhanVien> SelectAll()
        {
            return con.SelectAll();
        }

        [HttpPost]
        [Route("api/NhanVienInsert")]
        public HttpResponseMessage InsertNhanvien([FromBody] NhanVien nv)
        {
            //nv.MaNV = Helper.EnCode(DateTime.Now.ToString("yyyy-mm-dd:hh-mm-ss"));
           
            nv.MatKhau = Helper.EnCode(nv.MatKhau);
            return con.InsertNhanvien(nv) ? Request.CreateResponse(HttpStatusCode.Created, nv) : Request.CreateResponse(HttpStatusCode.Conflict);
        }

        [HttpDelete]
        [Route("api/NhanVienDelete")]
        public HttpResponseMessage DeleteNhanvien([FromUri] string id)
        {
            return con.DeleteNhanvien(id) ? Request.CreateResponse(HttpStatusCode.OK, id) : Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpPut]
        [Route("api/NhanVienUpdate")]
        public HttpResponseMessage UpdateNhanvien([FromBody] NhanVien nv)
        {
            if (nv.MatKhau != string.Empty)
                nv.MatKhau = Helper.EnCode(nv.MatKhau);
            return con.UpdateNhanvien(nv) ? Request.CreateResponse(HttpStatusCode.OK, nv) : Request.CreateResponse(HttpStatusCode.NotFound);
        }


        [HttpPost]
        [Route("api/NhanVienLogin")]
        public NhanVien Login([FromBody] NhanVien nv)
        {
            nv.MatKhau = Helper.EnCode(nv.MatKhau);
            return con.Login(nv.MaNV, nv.MatKhau);
        }

        [HttpGet]
        [Route("api/NhanVienSelectTop")]
        public List<NhanVien> NhanVienSelectTop(string Top, string Where, string Order)
        {
            return con.NhanVienSelectTop(Top, Where, Order);
        }

        [HttpGet]
        [Route("api/NhanVienTestByID")]
        public bool NhanVienTestByID(string MaNV)
        {
            return con.NhanVienTestByID(MaNV);
        }

        //[HttpGet]
        //[Route("api/nhanviens")]
        //public List<nhanvien> getAllNhanviens()
        //{
        //    return con.getAllNhanviens();
        //}

        //[HttpGet]
        //[Route("api/nhanvien_by_ma")]
        //public nhanvien getNhanvienByMa(string manv)
        //{
        //    return con.getNhanvienByMa(manv);
        //}

        //[HttpGet]
        //[Route("api/nhanvien_search")]
        //public List<nhanvien> searchNhanviens(string key)
        //{
        //    return con.searchNhanviens(key);
        //}

        //[HttpPost]
        //[Route("api/nhanvien_insert")]
        //public HttpResponseMessage insertNhanvien([FromBody] nhanvien nv)
        //{
        //    nv.manv = Helper.EnCode(DateTime.Now.ToString("yyyy-mm-dd:hh-mm-ss"));
        //    nv.matkhau = Helper.EnCode(nv.matkhau);
        //    return con.insertNhanvien(nv) ? Request.CreateResponse(HttpStatusCode.Created, nv) : Request.CreateResponse(HttpStatusCode.Conflict);
        //}

        //[HttpPut]
        //[Route("api/nhanvien_update")]
        //public HttpResponseMessage updateNhanvien([FromBody] nhanvien nv)
        //{
        //    if (nv.matkhau != string.Empty)
        //        nv.matkhau = Helper.EnCode(nv.matkhau);
        //    return con.updateNhanvien(nv) ? Request.CreateResponse(HttpStatusCode.OK, nv) : Request.CreateResponse(HttpStatusCode.NotFound);
        //}

        //[HttpDelete]
        //[Route("api/nhanvien_delete")]
        //public HttpResponseMessage deleteNhanvien([FromUri] string id)
        //{
        //    return con.deleteNhanvien(id) ? Request.CreateResponse(HttpStatusCode.OK, id) : Request.CreateResponse(HttpStatusCode.NotFound);
        //}

        //[HttpPost]
        //[Route("api/nhanvien_doimatkhau")]
        //public HttpResponseMessage changePassword([FromUri] string matkhaumoi, [FromBody] nhanvien nv)
        //{
        //    matkhaumoi = Helper.EnCode(matkhaumoi);
        //    nv.matkhau = Helper.EnCode(nv.matkhau);
        //    return con.changePassword(nv, matkhaumoi) ? Request.CreateResponse(HttpStatusCode.Created, nv) : Request.CreateResponse(HttpStatusCode.Conflict);
        //}
    }
}