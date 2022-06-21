//==============================================
// Author: AutoNetCoder @ 2015
// Create date: 10/21/2015 8:46:30 PM
// Project: QuanLyKhachSan
// Description: Auto code by AutoNetCoder
// Website: http://.www.softviet.net
//==============================================
using System;
using System.Text;
namespace AppCode.Entities 
{
	public class EtblPhong
	{
		public EtblPhong()
		{
		}
		public EtblPhong(string vMaPhong, string vTenPhong, string vLoaiPhong, int vGia)
		{
			this.MaPhong = vMaPhong;
			this.TenPhong = vTenPhong;
			this.LoaiPhong = vLoaiPhong;
			this.Gia = vGia;
		}
		public string MaPhong
		{ get;set; }
		public string TenPhong
		{ get;set; }
		public string LoaiPhong
		{ get;set; }
		public int Gia
		{ get;set; }
	}
}