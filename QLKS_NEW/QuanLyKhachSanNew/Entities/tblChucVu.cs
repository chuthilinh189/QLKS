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
	public class EtblChucVu
	{
		public EtblChucVu()
		{
		}
		public EtblChucVu(string vMaCV, int vKhu, string vTenDonVi, string vChucVu)
		{
			this.MaCV = vMaCV;
			this.Khu = vKhu;
			this.TenDonVi = vTenDonVi;
			this.ChucVu = vChucVu;
		}
		public string MaCV
		{ get;set; }
		public int Khu
		{ get;set; }
		public string TenDonVi
		{ get;set; }
		public string ChucVu
		{ get;set; }
	}
}