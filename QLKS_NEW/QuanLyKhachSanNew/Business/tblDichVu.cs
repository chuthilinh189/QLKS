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
	public class BtblDichVu
	{
//---------------------------------------------------------------------------------------------------------//
		public static DataTable SelectAll()
		{
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "tblDichVu_SelectAll", null);
			return all;
		}
		public static DataTable SelectTop(string Top ,string Where,string Order)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"Top", Top);
			pr[1] = new SqlParameter(@"Where", Where);
			pr[2] = new SqlParameter(@"Order", Order);
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "tblDichVu_SelectTop", pr);
			return all;
		}
		public static EtblDichVu SelectByID(string MaDV)
		{
			EtblDichVu OtblDichVu = new EtblDichVu();
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"MaDV", MaDV);
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblDichVu_SelectByID", pr);
			if (idr.Read())
				OtblDichVu = GetOnetblDichVu(idr);
			idr.Close();
			idr.Dispose();
			return OtblDichVu;
		}
		public static bool TestByID(string MaDV)
		{
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"MaDV",MaDV);
			pr[0].Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"tblDichVu_TestByID", pr);
			return Convert.ToBoolean(pr[0].Value);
		}
		public static DataTable SelectPage(int CurrentPage, int PageSize, out int RowCount)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"CurrentPage", CurrentPage);
			pr[1] = new SqlParameter(@"PageSize", PageSize);
			pr[2] = new SqlParameter(@"RowCount", SqlDbType.Int);
			pr[2].Direction = ParameterDirection.Output;
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "tblDichVu_SelectPage", pr);
			RowCount = Convert.ToInt32(pr[2].Value);
			return all;
		}
//---------------------------------------------------------------------------------------------------------//
		public static void Insert(EtblDichVu OtblDichVu)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"MaDV", OtblDichVu.MaDV);
			pr[1] = new SqlParameter(@"TenDV", OtblDichVu.TenDV);
			pr[2] = new SqlParameter(@"GiaTien", OtblDichVu.GiaTien);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "tblDichVu_Insert", pr);		}
		public static void Update(EtblDichVu OtblDichVu)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"MaDV", OtblDichVu.MaDV);
			pr[1] = new SqlParameter(@"TenDV", OtblDichVu.TenDV);
			pr[2] = new SqlParameter(@"GiaTien", OtblDichVu.GiaTien);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "tblDichVu_Update", pr);		}
		public static void Delete(string MaDV)
		{
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"MaDV", MaDV);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "tblDichVu_Delete", pr);		}
//---------------------------------------------------------------------------------------------------------//
		 private static EtblDichVu GetOnetblDichVu(IDataReader idr)
		{
			EtblDichVu OtblDichVu = new EtblDichVu();
				if (idr["MaDV"] != DBNull.Value)
					OtblDichVu.MaDV = (string)idr["MaDV"];
				if (idr["TenDV"] != DBNull.Value)
					OtblDichVu.TenDV = (string)idr["TenDV"];
				if (idr["GiaTien"] != DBNull.Value)
					OtblDichVu.GiaTien = (int)idr["GiaTien"];
			return OtblDichVu;
		}
//---------------------------------------------------------------------------------------------------------//
		public static List<EtblDichVu> ListAll()
		{
		List<EtblDichVu> list = new List<EtblDichVu>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblDichVu_SelectAll", null);
			while (idr.Read())
				list.Add(GetOnetblDichVu(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			return list;
		}
		public static List<EtblDichVu> ListTop(string Top ,string Where,string Order)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"Top", Top);
			pr[1] = new SqlParameter(@"Where", Where);
			pr[2] = new SqlParameter(@"Order", Order);
			List<EtblDichVu> list = new List<EtblDichVu>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblDichVu_SelectTop", pr);
			while (idr.Read())
				list.Add(GetOnetblDichVu(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			return list;
		}
		public static List<EtblDichVu> ListPage(int CurrentPage, int PageSize, out int RowCount)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"CurrentPage", CurrentPage);
			pr[1] = new SqlParameter(@"PageSize", PageSize);
			pr[2] = new SqlParameter(@"RowCount", SqlDbType.Int);
			pr[2].Direction = ParameterDirection.Output;
			List<EtblDichVu> list = new List<EtblDichVu>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblDichVu_SelectPage", pr);
			while (idr.Read())
				list.Add(GetOnetblDichVu(idr));
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