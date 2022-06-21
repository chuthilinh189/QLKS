//==============================================
// Author: AutoNetCoder @ 2015
// Create date: 10/18/2015 9:38:56 PM
// Project: QuanLyKhachSan
// Description: Auto code by AutoNetCoder
// Website: http://.www.softviet.net
//==============================================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using AppCode.Entities;
using AppCode.DataAccess;
namespace AppCode.Business
{
	public class BtblKhachHang
	{
//---------------------------------------------------------------------------------------------------------//
		public static DataTable SelectAll()
		{
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "tblKhachHang_SelectAll", null);
			return all;
		}
		public static DataTable SelectTop(string Top ,string Where,string Order)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"Top", Top);
			pr[1] = new SqlParameter(@"Where", Where);
			pr[2] = new SqlParameter(@"Order", Order);
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "tblKhachHang_SelectTop", pr);
			return all;
		}
		public static EtblKhachHang SelectByID(string MaKhach)
		{
			EtblKhachHang OtblKhachHang = new EtblKhachHang();
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"MaKhach", MaKhach);
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblKhachHang_SelectByID", pr);
			if (idr.Read())
				OtblKhachHang = GetOnetblKhachHang(idr);
			idr.Close();
			idr.Dispose();
			return OtblKhachHang;
		}
		public static bool TestByID(string MaKhach)
		{
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"MaKhach",MaKhach);
			pr[0].Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"tblKhachHang_TestByID", pr);
			return Convert.ToBoolean(pr[0].Value);
		}
		public static DataTable SelectPage(int CurrentPage, int PageSize, out int RowCount)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"CurrentPage", CurrentPage);
			pr[1] = new SqlParameter(@"PageSize", PageSize);
			pr[2] = new SqlParameter(@"RowCount", SqlDbType.Int);
			pr[2].Direction = ParameterDirection.Output;
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "tblKhachHang_SelectPage", pr);
			RowCount = Convert.ToInt32(pr[2].Value);
			return all;
		}
//---------------------------------------------------------------------------------------------------------//
		public static void Insert(EtblKhachHang OtblKhachHang)
		{
			SqlParameter[] pr = new SqlParameter[7];
			pr[0] = new SqlParameter(@"MaKhach", OtblKhachHang.MaKhach);
			pr[1] = new SqlParameter(@"HoDem", OtblKhachHang.HoDem);
			pr[2] = new SqlParameter(@"Ten", OtblKhachHang.Ten);
			pr[3] = new SqlParameter(@"NgaySinh", OtblKhachHang.NgaySinh);
			pr[4] = new SqlParameter(@"CMND", OtblKhachHang.CMND);
			pr[5] = new SqlParameter(@"QuocTich", OtblKhachHang.QuocTich);
			pr[6] = new SqlParameter(@"NghiChu", OtblKhachHang.NghiChu);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "tblKhachHang_Insert", pr);		}
		public static void Update(EtblKhachHang OtblKhachHang)
		{
			SqlParameter[] pr = new SqlParameter[7];
			pr[0] = new SqlParameter(@"MaKhach", OtblKhachHang.MaKhach);
			pr[1] = new SqlParameter(@"HoDem", OtblKhachHang.HoDem);
			pr[2] = new SqlParameter(@"Ten", OtblKhachHang.Ten);
			pr[3] = new SqlParameter(@"NgaySinh", OtblKhachHang.NgaySinh);
			pr[4] = new SqlParameter(@"CMND", OtblKhachHang.CMND);
			pr[5] = new SqlParameter(@"QuocTich", OtblKhachHang.QuocTich);
			pr[6] = new SqlParameter(@"NghiChu", OtblKhachHang.NghiChu);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "tblKhachHang_Update", pr);		}
		public static void Delete(string MaKhach)
		{
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"MaKhach", MaKhach);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "tblKhachHang_Delete", pr);		}
//---------------------------------------------------------------------------------------------------------//
		 private static EtblKhachHang GetOnetblKhachHang(IDataReader idr)
		{
			EtblKhachHang OtblKhachHang = new EtblKhachHang();
				if (idr["MaKhach"] != DBNull.Value)
					OtblKhachHang.MaKhach = (string)idr["MaKhach"];
				if (idr["HoDem"] != DBNull.Value)
					OtblKhachHang.HoDem = (string)idr["HoDem"];
				if (idr["Ten"] != DBNull.Value)
					OtblKhachHang.Ten = (string)idr["Ten"];
				if (idr["NgaySinh"] != DBNull.Value)
					OtblKhachHang.NgaySinh = (DateTime)idr["NgaySinh"];
				if (idr["CMND"] != DBNull.Value)
					OtblKhachHang.CMND = (string)idr["CMND"];
				if (idr["QuocTich"] != DBNull.Value)
					OtblKhachHang.QuocTich = (string)idr["QuocTich"];
				if (idr["NghiChu"] != DBNull.Value)
					OtblKhachHang.NghiChu = (string)idr["NghiChu"];
			return OtblKhachHang;
		}
//---------------------------------------------------------------------------------------------------------//
		public static List<EtblKhachHang> ListAll()
		{
		List<EtblKhachHang> list = new List<EtblKhachHang>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblKhachHang_SelectAll", null);
			while (idr.Read())
				list.Add(GetOnetblKhachHang(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			return list;
		}
		public static List<EtblKhachHang> ListTop(string Top ,string Where,string Order)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"Top", Top);
			pr[1] = new SqlParameter(@"Where", Where);
			pr[2] = new SqlParameter(@"Order", Order);
			List<EtblKhachHang> list = new List<EtblKhachHang>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblKhachHang_SelectTop", pr);
			while (idr.Read())
				list.Add(GetOnetblKhachHang(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			return list;
		}
		public static List<EtblKhachHang> ListPage(int CurrentPage, int PageSize, out int RowCount)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"CurrentPage", CurrentPage);
			pr[1] = new SqlParameter(@"PageSize", PageSize);
			pr[2] = new SqlParameter(@"RowCount", SqlDbType.Int);
			pr[2].Direction = ParameterDirection.Output;
			List<EtblKhachHang> list = new List<EtblKhachHang>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblKhachHang_SelectPage", pr);
			while (idr.Read())
				list.Add(GetOnetblKhachHang(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			RowCount = Convert.ToInt32(pr[2].Value);
			return list;
		}
	}
}