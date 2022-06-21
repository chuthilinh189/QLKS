//==============================================
// Author: AutoNetCoder @ 2015
// Create date: 10/21/2015 3:39:57 PM
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
	public class BtblSDDV
	{
//---------------------------------------------------------------------------------------------------------//
		public static DataTable SelectAll()
		{
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "tblSDDV_SelectAll", null);
			return all;
		}

        public static List<EtblSDDV> SelectAllByID(String maDK)
        {
            List<EtblSDDV> list = new List<EtblSDDV>();
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"MaDK",maDK);
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblSDDV_SelectAllByID", pr);

            while (idr.Read())
                list.Add(GetOnetblSDDV(idr));
            if (idr.IsClosed == false)
            {
                idr.Close();
                idr.Dispose();
            }
            return list;
        }

		public static DataTable SelectTop(string Top ,string Where,string Order)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"Top", Top);
			pr[1] = new SqlParameter(@"Where", Where);
			pr[2] = new SqlParameter(@"Order", Order);
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "tblSDDV_SelectTop", pr);
			return all;
		}
		public static EtblSDDV SelectByID(string MaDK, string MaDV)
		{
			EtblSDDV OtblSDDV = new EtblSDDV();
			SqlParameter[] pr = new SqlParameter[2];
			pr[0] = new SqlParameter(@"MaDK", MaDK);
			pr[1] = new SqlParameter(@"MaDV", MaDV);
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblSDDV_SelectByID", pr);
			if (idr.Read())
				OtblSDDV = GetOnetblSDDV(idr);
			idr.Close();
			idr.Dispose();
			return OtblSDDV;
		}
		public static bool TestByID(string MaDK, string MaDV)
		{
			SqlParameter[] pr = new SqlParameter[2];
			pr[0] = new SqlParameter(@"MaDK",MaDK);
			pr[1] = new SqlParameter(@"MaDV",MaDV);
			pr[1].Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"tblSDDV_TestByID", pr);
			return Convert.ToBoolean(pr[1].Value);
		}
		public static DataTable SelectPage(int CurrentPage, int PageSize, out int RowCount)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"CurrentPage", CurrentPage);
			pr[1] = new SqlParameter(@"PageSize", PageSize);
			pr[2] = new SqlParameter(@"RowCount", SqlDbType.Int);
			pr[2].Direction = ParameterDirection.Output;
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "tblSDDV_SelectPage", pr);
			RowCount = Convert.ToInt32(pr[2].Value);
			return all;
		}
//---------------------------------------------------------------------------------------------------------//
		public static void Insert(EtblSDDV OtblSDDV)
		{
			SqlParameter[] pr = new SqlParameter[5];
			pr[0] = new SqlParameter(@"MaDK", OtblSDDV.MaDK);
			pr[1] = new SqlParameter(@"MaDV", OtblSDDV.MaDV);
			pr[2] = new SqlParameter(@"MaNV", OtblSDDV.MaNV);
			pr[3] = new SqlParameter(@"NgaySuDung", OtblSDDV.NgaySuDung);
			pr[4] = new SqlParameter(@"SoLuong", OtblSDDV.SoLuong);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "tblSDDV_Insert", pr);		}

		public static void Update(EtblSDDV OtblSDDV)
		{
			SqlParameter[] pr = new SqlParameter[5];
			pr[0] = new SqlParameter(@"MaDK", OtblSDDV.MaDK);
			pr[1] = new SqlParameter(@"MaDV", OtblSDDV.MaDV);
			pr[2] = new SqlParameter(@"MaNV", OtblSDDV.MaNV);
			pr[3] = new SqlParameter(@"NgaySuDung", OtblSDDV.NgaySuDung);
			pr[4] = new SqlParameter(@"SoLuong", OtblSDDV.SoLuong);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "tblSDDV_Update", pr);		}

		public static void Delete(string MaDK, string MaDV)
		{
			SqlParameter[] pr = new SqlParameter[2];
			pr[0] = new SqlParameter(@"MaDK", MaDK);
			pr[1] = new SqlParameter(@"MaDV", MaDV);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "tblSDDV_Delete", pr);		}
//---------------------------------------------------------------------------------------------------------//
		 private static EtblSDDV GetOnetblSDDV(IDataReader idr)
		{
			EtblSDDV OtblSDDV = new EtblSDDV();
				if (idr["MaDK"] != DBNull.Value)
					OtblSDDV.MaDK = (string)idr["MaDK"];
				if (idr["MaDV"] != DBNull.Value)
					OtblSDDV.MaDV = (string)idr["MaDV"];
				if (idr["MaNV"] != DBNull.Value)
					OtblSDDV.MaNV = (string)idr["MaNV"];
				if (idr["NgaySuDung"] != DBNull.Value)
					OtblSDDV.NgaySuDung = (DateTime)idr["NgaySuDung"];
				if (idr["SoLuong"] != DBNull.Value)
					OtblSDDV.SoLuong = (int)idr["SoLuong"];
			return OtblSDDV;
		}
//---------------------------------------------------------------------------------------------------------//
		public static List<EtblSDDV> ListAll()
		{
		List<EtblSDDV> list = new List<EtblSDDV>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblSDDV_SelectAll", null);
			while (idr.Read())
				list.Add(GetOnetblSDDV(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			return list;
		}
		public static List<EtblSDDV> ListTop(string Top ,string Where,string Order)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"Top", Top);
			pr[1] = new SqlParameter(@"Where", Where);
			pr[2] = new SqlParameter(@"Order", Order);
			List<EtblSDDV> list = new List<EtblSDDV>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblSDDV_SelectTop", pr);
			while (idr.Read())
				list.Add(GetOnetblSDDV(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			return list;
		}
		public static List<EtblSDDV> ListPage(int CurrentPage, int PageSize, out int RowCount)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"CurrentPage", CurrentPage);
			pr[1] = new SqlParameter(@"PageSize", PageSize);
			pr[2] = new SqlParameter(@"RowCount", SqlDbType.Int);
			pr[2].Direction = ParameterDirection.Output;
			List<EtblSDDV> list = new List<EtblSDDV>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblSDDV_SelectPage", pr);
			while (idr.Read())
				list.Add(GetOnetblSDDV(idr));
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