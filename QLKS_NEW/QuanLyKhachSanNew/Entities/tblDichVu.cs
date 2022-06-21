//==============================================
// Author: AutoNetCoder @ 2015
// Create date: 10/18/2015 9:38:56 PM
// Project: QuanLyKhachSan
// Description: Auto code by AutoNetCoder
// Website: http://.www.softviet.net
//==============================================
using System;
using System.Text;
namespace AppCode.Entities 
{
	public class EtblDichVu
	{
		public EtblDichVu()
		{
		}
		public EtblDichVu(string vMaDV, string vTenDV, int vGiaTien)
		{
			this.MaDV = vMaDV;
			this.TenDV = vTenDV;
			this.GiaTien = vGiaTien;
		}
		public string MaDV
		{ get;set; }
		public string TenDV
		{ get;set; }
		public int GiaTien
		{ get;set; }
	}
}