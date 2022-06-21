//==============================================
// Author: AutoNetCoder @ 2015
// Create date: 10/28/2015 10:06:14 AM
// Project: QuanLyKhachSan
// Description: Auto code by AutoNetCoder
// Website: http://.www.softviet.net
//==============================================
using System;
using System.Text;
namespace AppCode.Entities 
{
	public class EtblNhanVien
	{
		public EtblNhanVien()
		{
		}
		
		public EtblNhanVien(string vMaNV, string vMatKhau, string vMaCV, string vHoDem, string vTen, DateTime vNgaySinh, string vCMND, string vNghiChu)
		{
			this.MaNV = vMaNV;
			this.MatKhau = vMatKhau;
			this.MaCV = vMaCV;
			this.HoDem = vHoDem;
			this.Ten = vTen;
			this.NgaySinh = vNgaySinh;
			this.CMND = vCMND;
			this.NghiChu = vNghiChu;
		}
		public string MaNV
		{ get;set; }
		public string MatKhau
		{ get;set; }
		public string MaCV
		{ get;set; }
		public string HoDem
		{ get;set; }
		public string Ten
		{ get;set; }
		public DateTime NgaySinh
		{ get;set; }
		public string CMND
		{ get;set; }
		public string NghiChu
		{ get;set; }
	}
}