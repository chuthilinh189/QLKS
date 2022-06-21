//==============================================
// Author: AutoNetCoder @ 2015
// Create date: 10/28/2015 10:06:14 AM
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
	public class BtblNhanVien
	{
//---------------------------------------------------------------------------------------------------------//

        public static List<EtblNhanVien> SelectAllByID(String MaNV)
        {
            List<EtblNhanVien> list = new List<EtblNhanVien>();
            EtblNhanVien OtblNhanVien = new EtblNhanVien();
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"MaNV", MaNV);
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblNhanVien_SelectByID", pr);
            while (idr.Read())
                list.Add(GetOnetblNhanVien(idr));
            if (idr.IsClosed == false)
            {
                idr.Close();
                idr.Dispose();
            }
            return list;
        }

		public static DataTable SelectAll()
		{
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "tblNhanVien_SelectAll", null);
			return all;
		}
		public static DataTable SelectTop(string Top ,string Where,string Order)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"Top", Top);
			pr[1] = new SqlParameter(@"Where", Where);
			pr[2] = new SqlParameter(@"Order", Order);
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "tblNhanVien_SelectTop", pr);
			return all;
		}
		public static EtblNhanVien SelectByID(string MaNV)
		{
			EtblNhanVien OtblNhanVien = new EtblNhanVien();
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"MaNV", MaNV);
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblNhanVien_SelectByID", pr);
			if (idr.Read())
				OtblNhanVien = GetOnetblNhanVien(idr);
			idr.Close();
			idr.Dispose();
			return OtblNhanVien;
		}
		public static bool TestByID(string MaNV)
		{
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"MaNV",MaNV);
			pr[0].Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"tblNhanVien_TestByID", pr);
			return Convert.ToBoolean(pr[0].Value);
		}
		public static DataTable SelectPage(int CurrentPage, int PageSize, out int RowCount)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"CurrentPage", CurrentPage);
			pr[1] = new SqlParameter(@"PageSize", PageSize);
			pr[2] = new SqlParameter(@"RowCount", SqlDbType.Int);
			pr[2].Direction = ParameterDirection.Output;
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "tblNhanVien_SelectPage", pr);
			RowCount = Convert.ToInt32(pr[2].Value);
			return all;
		}
//---------------------------------------------------------------------------------------------------------//
		public static void Insert(EtblNhanVien OtblNhanVien)
		{
			SqlParameter[] pr = new SqlParameter[8];
			pr[0] = new SqlParameter(@"MaNV", OtblNhanVien.MaNV);
			pr[1] = new SqlParameter(@"MatKhau", OtblNhanVien.MatKhau);
			pr[2] = new SqlParameter(@"MaCV", OtblNhanVien.MaCV);
			pr[3] = new SqlParameter(@"HoDem", OtblNhanVien.HoDem);
			pr[4] = new SqlParameter(@"Ten", OtblNhanVien.Ten);
			pr[5] = new SqlParameter(@"NgaySinh", OtblNhanVien.NgaySinh);
			pr[6] = new SqlParameter(@"CMND", OtblNhanVien.CMND);
			pr[7] = new SqlParameter(@"NghiChu", OtblNhanVien.NghiChu);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "tblNhanVien_Insert", pr);		}
		public static void Update(EtblNhanVien OtblNhanVien)
		{
			SqlParameter[] pr = new SqlParameter[8];
			pr[0] = new SqlParameter(@"MaNV", OtblNhanVien.MaNV);
			pr[1] = new SqlParameter(@"MatKhau", OtblNhanVien.MatKhau);
			pr[2] = new SqlParameter(@"MaCV", OtblNhanVien.MaCV);
			pr[3] = new SqlParameter(@"HoDem", OtblNhanVien.HoDem);
			pr[4] = new SqlParameter(@"Ten", OtblNhanVien.Ten);
			pr[5] = new SqlParameter(@"NgaySinh", OtblNhanVien.NgaySinh);
			pr[6] = new SqlParameter(@"CMND", OtblNhanVien.CMND);
			pr[7] = new SqlParameter(@"NghiChu", OtblNhanVien.NghiChu);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "tblNhanVien_Update", pr);		}
		public static void Delete(string MaNV)
		{
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"MaNV", MaNV);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "tblNhanVien_Delete", pr);		}
//---------------------------------------------------------------------------------------------------------//
		 private static EtblNhanVien GetOnetblNhanVien(IDataReader idr)
		{
			EtblNhanVien OtblNhanVien = new EtblNhanVien();
				if (idr["MaNV"] != DBNull.Value)
					OtblNhanVien.MaNV = (string)idr["MaNV"];
				if (idr["MatKhau"] != DBNull.Value)
					OtblNhanVien.MatKhau = (string)idr["MatKhau"];
				if (idr["MaCV"] != DBNull.Value)
					OtblNhanVien.MaCV = (string)idr["MaCV"];
				if (idr["HoDem"] != DBNull.Value)
					OtblNhanVien.HoDem = (string)idr["HoDem"];
				if (idr["Ten"] != DBNull.Value)
					OtblNhanVien.Ten = (string)idr["Ten"];
				if (idr["NgaySinh"] != DBNull.Value)
					OtblNhanVien.NgaySinh = (DateTime)idr["NgaySinh"];
				if (idr["CMND"] != DBNull.Value)
					OtblNhanVien.CMND = (string)idr["CMND"];
				if (idr["NghiChu"] != DBNull.Value)
					OtblNhanVien.NghiChu = (string)idr["NghiChu"];
			return OtblNhanVien;
		}
//---------------------------------------------------------------------------------------------------------//
		public static List<EtblNhanVien> ListAll()
		{
		List<EtblNhanVien> list = new List<EtblNhanVien>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblNhanVien_SelectAll", null);
			while (idr.Read())
				list.Add(GetOnetblNhanVien(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			return list;
		}
		public static List<EtblNhanVien> ListTop(string Top ,string Where,string Order)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"Top", Top);
			pr[1] = new SqlParameter(@"Where", Where);
			pr[2] = new SqlParameter(@"Order", Order);
			List<EtblNhanVien> list = new List<EtblNhanVien>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblNhanVien_SelectTop", pr);
			while (idr.Read())
				list.Add(GetOnetblNhanVien(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			return list;
		}
		public static List<EtblNhanVien> ListPage(int CurrentPage, int PageSize, out int RowCount)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"CurrentPage", CurrentPage);
			pr[1] = new SqlParameter(@"PageSize", PageSize);
			pr[2] = new SqlParameter(@"RowCount", SqlDbType.Int);
			pr[2].Direction = ParameterDirection.Output;
			List<EtblNhanVien> list = new List<EtblNhanVien>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "tblNhanVien_SelectPage", pr);
			while (idr.Read())
				list.Add(GetOnetblNhanVien(idr));
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