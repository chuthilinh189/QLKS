//==============================================
// Author: AutoNetCoder @ 2015
// Create date: 10/18/2015 9:38:57 PM
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
	public class BtblThanhToan
	{
//---------------------------------------------------------------------------------------------------------//
		public static DataTable SelectAll()
		{
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "tblThanhToan_SelectAll", null);
			return all;
		}
		public static DataTable SelectTop(string Top ,string Where,string Order)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"Top", Top);
			pr[1] = new SqlParameter(@"Where", Where);
			pr[2] = new SqlParameter(@"Order", Order);
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "tblThanhToan_SelectTop", pr);
			return all;
		}
		public static EtblThanhToan SelectByID(string MaDK, string MaPhong)
		{
			EtblThanhToan OtblThanhToan = new EtblThanhToan();
			SqlParameter[] pr = new SqlParameter[2];
			pr[0] = new SqlParameter(@"MaDK", MaDK);
			pr[1] = new SqlParameter(@"MaPhong", MaPhong);
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblThanhToan_SelectByID", pr);
			if (idr.Read())
				OtblThanhToan = GetOnetblThanhToan(idr);
			idr.Close();
			idr.Dispose();
			return OtblThanhToan;
		}
		public static bool TestByID(string MaDK, string MaPhong)
		{
			SqlParameter[] pr = new SqlParameter[2];
			pr[0] = new SqlParameter(@"MaDK",MaDK);
			pr[1] = new SqlParameter(@"MaPhong",MaPhong);
			pr[1].Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"tblThanhToan_TestByID", pr);
			return Convert.ToBoolean(pr[1].Value);
		}
		public static DataTable SelectPage(int CurrentPage, int PageSize, out int RowCount)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"CurrentPage", CurrentPage);
			pr[1] = new SqlParameter(@"PageSize", PageSize);
			pr[2] = new SqlParameter(@"RowCount", SqlDbType.Int);
			pr[2].Direction = ParameterDirection.Output;
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "tblThanhToan_SelectPage", pr);
			RowCount = Convert.ToInt32(pr[2].Value);
			return all;
		}
//---------------------------------------------------------------------------------------------------------//
		public static void Insert(EtblThanhToan OtblThanhToan)
		{
			SqlParameter[] pr = new SqlParameter[4];
			pr[0] = new SqlParameter(@"MaDK", OtblThanhToan.MaDK);
			pr[1] = new SqlParameter(@"MaPhong", OtblThanhToan.MaPhong);
			pr[2] = new SqlParameter(@"MaNV", OtblThanhToan.MaNV);
			pr[3] = new SqlParameter(@"NgayThanhToan", OtblThanhToan.NgayThanhToan);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "tblThanhToan_Insert", pr);		}
		public static void Update(EtblThanhToan OtblThanhToan)
		{
			SqlParameter[] pr = new SqlParameter[4];
			pr[0] = new SqlParameter(@"MaDK", OtblThanhToan.MaDK);
			pr[1] = new SqlParameter(@"MaPhong", OtblThanhToan.MaPhong);
			pr[2] = new SqlParameter(@"MaNV", OtblThanhToan.MaNV);
			pr[3] = new SqlParameter(@"NgayThanhToan", OtblThanhToan.NgayThanhToan);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "tblThanhToan_Update", pr);		}
		public static void Delete(string MaDK, string MaPhong)
		{
			SqlParameter[] pr = new SqlParameter[2];
			pr[0] = new SqlParameter(@"MaDK", MaDK);
			pr[1] = new SqlParameter(@"MaPhong", MaPhong);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "tblThanhToan_Delete", pr);		}
//---------------------------------------------------------------------------------------------------------//
		 private static EtblThanhToan GetOnetblThanhToan(IDataReader idr)
		{
			EtblThanhToan OtblThanhToan = new EtblThanhToan();
				if (idr["MaDK"] != DBNull.Value)
					OtblThanhToan.MaDK = (string)idr["MaDK"];
				if (idr["MaPhong"] != DBNull.Value)
					OtblThanhToan.MaPhong = (string)idr["MaPhong"];
				if (idr["MaNV"] != DBNull.Value)
					OtblThanhToan.MaNV = (string)idr["MaNV"];
				if (idr["NgayThanhToan"] != DBNull.Value)
					OtblThanhToan.NgayThanhToan = (DateTime)idr["NgayThanhToan"];
			return OtblThanhToan;
		}
//---------------------------------------------------------------------------------------------------------//
		public static List<EtblThanhToan> ListAll()
		{
		List<EtblThanhToan> list = new List<EtblThanhToan>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblThanhToan_SelectAll", null);
			while (idr.Read())
				list.Add(GetOnetblThanhToan(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			return list;
		}
		public static List<EtblThanhToan> ListTop(string Top ,string Where,string Order)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"Top", Top);
			pr[1] = new SqlParameter(@"Where", Where);
			pr[2] = new SqlParameter(@"Order", Order);
			List<EtblThanhToan> list = new List<EtblThanhToan>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblThanhToan_SelectTop", pr);
			while (idr.Read())
				list.Add(GetOnetblThanhToan(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			return list;
		}
		public static List<EtblThanhToan> ListPage(int CurrentPage, int PageSize, out int RowCount)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"CurrentPage", CurrentPage);
			pr[1] = new SqlParameter(@"PageSize", PageSize);
			pr[2] = new SqlParameter(@"RowCount", SqlDbType.Int);
			pr[2].Direction = ParameterDirection.Output;
			List<EtblThanhToan> list = new List<EtblThanhToan>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblThanhToan_SelectPage", pr);
			while (idr.Read())
				list.Add(GetOnetblThanhToan(idr));
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