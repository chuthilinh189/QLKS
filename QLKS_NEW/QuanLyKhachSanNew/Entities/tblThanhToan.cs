//==============================================
// Author: AutoNetCoder @ 2015
// Create date: 10/18/2015 9:38:57 PM
// Project: QuanLyKhachSan
// Description: Auto code by AutoNetCoder
// Website: http://.www.softviet.net
//==============================================
using System;
using System.Text;
namespace AppCode.Entities 
{
	public class EtblThanhToan
	{
		public EtblThanhToan()
		{
		}
		public EtblThanhToan(string vMaDK, string vMaPhong, string vMaNV, DateTime vNgayThanhToan)
		{
			this.MaDK = vMaDK;
			this.MaPhong = vMaPhong;
			this.MaNV = vMaNV;
			this.NgayThanhToan = vNgayThanhToan;
		}
		public string MaDK
		{ get;set; }
		public string MaPhong
		{ get;set; }
		public string MaNV
		{ get;set; }
		public DateTime NgayThanhToan
		{ get;set; }
	}
}