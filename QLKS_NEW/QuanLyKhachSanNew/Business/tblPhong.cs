//==============================================
// Author: AutoNetCoder @ 2015
// Create date: 10/21/2015 8:46:30 PM
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
	public class BtblPhong
	{
//------------------------------------------------------------------------------------------------
        public static List<EtblPhong> ListAll_DaDangKy()
        {
            List<EtblPhong> list = new List<EtblPhong>();
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblPhong_DaDangKy", null);
            while (idr.Read())
                list.Add(GetOnetblPhong(idr));
            if (idr.IsClosed == false)
            {
                idr.Close();
                idr.Dispose();
            }
            return list;
        }

        public static List<EtblPhong> ListAll_DaNhanPhong()
        {
            List<EtblPhong> list = new List<EtblPhong>();
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblPhong_DaNhanPhong", null);
            while (idr.Read())
                list.Add(GetOnetblPhong(idr));
            if (idr.IsClosed == false)
            {
                idr.Close();
                idr.Dispose();
            }
            return list;
        }

//---------------------------------------------------------------------------------------------------------//
		public static DataTable SelectAll()
		{
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "tblPhong_SelectAll", null);
			return all;
		}
		public static DataTable SelectTop(string Top ,string Where,string Order)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"Top", Top);
			pr[1] = new SqlParameter(@"Where", Where);
			pr[2] = new SqlParameter(@"Order", Order);
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "tblPhong_SelectTop", pr);
			return all;
		}
		public static EtblPhong SelectByID(string MaPhong)
		{
			EtblPhong OtblPhong = new EtblPhong();
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"MaPhong", MaPhong);
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblPhong_SelectByID", pr);
			if (idr.Read())
				OtblPhong = GetOnetblPhong(idr);
			idr.Close();
			idr.Dispose();
			return OtblPhong;
		}
		public static bool TestByID(string MaPhong)
		{
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"MaPhong",MaPhong);
			pr[0].Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"tblPhong_TestByID", pr);
			return Convert.ToBoolean(pr[0].Value);
		}
		public static DataTable SelectPage(int CurrentPage, int PageSize, out int RowCount)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"CurrentPage", CurrentPage);
			pr[1] = new SqlParameter(@"PageSize", PageSize);
			pr[2] = new SqlParameter(@"RowCount", SqlDbType.Int);
			pr[2].Direction = ParameterDirection.Output;
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "tblPhong_SelectPage", pr);
			RowCount = Convert.ToInt32(pr[2].Value);
			return all;
		}
//---------------------------------------------------------------------------------------------------------//
		public static void Insert(EtblPhong OtblPhong)
		{
			SqlParameter[] pr = new SqlParameter[4];
			pr[0] = new SqlParameter(@"MaPhong", OtblPhong.MaPhong);
			pr[1] = new SqlParameter(@"TenPhong", OtblPhong.TenPhong);
			pr[2] = new SqlParameter(@"LoaiPhong", OtblPhong.LoaiPhong);
			pr[3] = new SqlParameter(@"Gia", OtblPhong.Gia);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "tblPhong_Insert", pr);		}
		public static void Update(EtblPhong OtblPhong)
		{
			SqlParameter[] pr = new SqlParameter[4];
			pr[0] = new SqlParameter(@"MaPhong", OtblPhong.MaPhong);
			pr[1] = new SqlParameter(@"TenPhong", OtblPhong.TenPhong);
			pr[2] = new SqlParameter(@"LoaiPhong", OtblPhong.LoaiPhong);
			pr[3] = new SqlParameter(@"Gia", OtblPhong.Gia);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "tblPhong_Update", pr);		}
		public static void Delete(string MaPhong)
		{
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"MaPhong", MaPhong);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "tblPhong_Delete", pr);		}
//---------------------------------------------------------------------------------------------------------//
		 private static EtblPhong GetOnetblPhong(IDataReader idr)
		{
			EtblPhong OtblPhong = new EtblPhong();
				if (idr["MaPhong"] != DBNull.Value)
					OtblPhong.MaPhong = (string)idr["MaPhong"];
				if (idr["TenPhong"] != DBNull.Value)
					OtblPhong.TenPhong = (string)idr["TenPhong"];
				if (idr["LoaiPhong"] != DBNull.Value)
					OtblPhong.LoaiPhong = (string)idr["LoaiPhong"];
				if (idr["Gia"] != DBNull.Value)
					OtblPhong.Gia = (int)idr["Gia"];
			return OtblPhong;
		}
//---------------------------------------------------------------------------------------------------------//
		public static List<EtblPhong> ListAll()
		{
		List<EtblPhong> list = new List<EtblPhong>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblPhong_SelectAll", null);
			while (idr.Read())
				list.Add(GetOnetblPhong(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			return list;
		}
		public static List<EtblPhong> ListTop(string Top ,string Where,string Order)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"Top", Top);
			pr[1] = new SqlParameter(@"Where", Where);
			pr[2] = new SqlParameter(@"Order", Order);
			List<EtblPhong> list = new List<EtblPhong>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblPhong_SelectTop", pr);
			while (idr.Read())
				list.Add(GetOnetblPhong(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			return list;
		}
		public static List<EtblPhong> ListPage(int CurrentPage, int PageSize, out int RowCount)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"CurrentPage", CurrentPage);
			pr[1] = new SqlParameter(@"PageSize", PageSize);
			pr[2] = new SqlParameter(@"RowCount", SqlDbType.Int);
			pr[2].Direction = ParameterDirection.Output;
			List<EtblPhong> list = new List<EtblPhong>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblPhong_SelectPage", pr);
			while (idr.Read())
				list.Add(GetOnetblPhong(idr));
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