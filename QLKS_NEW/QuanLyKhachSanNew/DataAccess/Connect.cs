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
using System.Configuration;
using System.Web;
namespace AppCode.Connection
{
	public static class ConnectionString
	{
   		// Connect string for application
		private static string strconnection = @"Data Source=.\SQLEXPRESS;Database=QuanLyKhachSan;integrated Security=SSPI";
		// Connect string for website
		//private static string strconnection =  ConfigurationManager.ConnectionStrings["AutoNetCoderConnectionString"].ToString();
		public static string Text
		{
			get { return strconnection; }
			set { strconnection = value; }
		}
	}
}