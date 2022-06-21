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
	public class BtblChucVu
	{
//---------------------------------------------------------------------------------------------------------//
		public static DataTable SelectAll()
		{
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "tblChucVu_SelectAll", null);
			return all;
		}
		public static DataTable SelectTop(string Top ,string Where,string Order)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"Top", Top);
			pr[1] = new SqlParameter(@"Where", Where);
			pr[2] = new SqlParameter(@"Order", Order);
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "tblChucVu_SelectTop", pr);
			return all;
		}
		public static EtblChucVu SelectByID(string MaCV)
		{
			EtblChucVu OtblChucVu = new EtblChucVu();
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"MaCV", MaCV);
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblChucVu_SelectByID", pr);
			if (idr.Read())
				OtblChucVu = GetOnetblChucVu(idr);
			idr.Close();
			idr.Dispose();
			return OtblChucVu;
		}
		public static bool TestByID(string MaCV)
		{
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"MaCV",MaCV);
			pr[0].Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"tblChucVu_TestByID", pr);
			return Convert.ToBoolean(pr[0].Value);
		}
		public static DataTable SelectPage(int CurrentPage, int PageSize, out int RowCount)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"CurrentPage", CurrentPage);
			pr[1] = new SqlParameter(@"PageSize", PageSize);
			pr[2] = new SqlParameter(@"RowCount", SqlDbType.Int);
			pr[2].Direction = ParameterDirection.Output;
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "tblChucVu_SelectPage", pr);
			RowCount = Convert.ToInt32(pr[2].Value);
			return all;
		}
//---------------------------------------------------------------------------------------------------------//
		public static void Insert(EtblChucVu OtblChucVu)
		{
			SqlParameter[] pr = new SqlParameter[4];
			pr[0] = new SqlParameter(@"MaCV", OtblChucVu.MaCV);
			pr[1] = new SqlParameter(@"Khu", OtblChucVu.Khu);
			pr[2] = new SqlParameter(@"TenDonVi", OtblChucVu.TenDonVi);
			pr[3] = new SqlParameter(@"ChucVu", OtblChucVu.ChucVu);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "tblChucVu_Insert", pr);		}
		public static void Update(EtblChucVu OtblChucVu)
		{
			SqlParameter[] pr = new SqlParameter[4];
			pr[0] = new SqlParameter(@"MaCV", OtblChucVu.MaCV);
			pr[1] = new SqlParameter(@"Khu", OtblChucVu.Khu);
			pr[2] = new SqlParameter(@"TenDonVi", OtblChucVu.TenDonVi);
			pr[3] = new SqlParameter(@"ChucVu", OtblChucVu.ChucVu);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "tblChucVu_Update", pr);		}
		public static void Delete(string MaCV)
		{
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"MaCV", MaCV);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "tblChucVu_Delete", pr);		}
//---------------------------------------------------------------------------------------------------------//
		 private static EtblChucVu GetOnetblChucVu(IDataReader idr)
		{
			EtblChucVu OtblChucVu = new EtblChucVu();
				if (idr["MaCV"] != DBNull.Value)
					OtblChucVu.MaCV = (string)idr["MaCV"];
				if (idr["Khu"] != DBNull.Value)
					OtblChucVu.Khu = (int)idr["Khu"];
				if (idr["TenDonVi"] != DBNull.Value)
					OtblChucVu.TenDonVi = (string)idr["TenDonVi"];
				if (idr["ChucVu"] != DBNull.Value)
					OtblChucVu.ChucVu = (string)idr["ChucVu"];
			return OtblChucVu;
		}
//---------------------------------------------------------------------------------------------------------//
		public static List<EtblChucVu> ListAll()
		{
		List<EtblChucVu> list = new List<EtblChucVu>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblChucVu_SelectAll", null);
			while (idr.Read())
				list.Add(GetOnetblChucVu(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			return list;
		}
		public static List<EtblChucVu> ListTop(string Top ,string Where,string Order)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"Top", Top);
			pr[1] = new SqlParameter(@"Where", Where);
			pr[2] = new SqlParameter(@"Order", Order);
			List<EtblChucVu> list = new List<EtblChucVu>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblChucVu_SelectTop", pr);
			while (idr.Read())
				list.Add(GetOnetblChucVu(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			return list;
		}
		public static List<EtblChucVu> ListPage(int CurrentPage, int PageSize, out int RowCount)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"CurrentPage", CurrentPage);
			pr[1] = new SqlParameter(@"PageSize", PageSize);
			pr[2] = new SqlParameter(@"RowCount", SqlDbType.Int);
			pr[2].Direction = ParameterDirection.Output;
			List<EtblChucVu> list = new List<EtblChucVu>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblChucVu_SelectPage", pr);
			while (idr.Read())
				list.Add(GetOnetblChucVu(idr));
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