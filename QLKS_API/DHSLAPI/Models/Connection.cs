using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QLKSAPI.Models
{
    public class Connection
    {
        private static string connectionstring;
        private SqlConnection con;

        public Connection()
        {
            //Application.StartupPath
            //connectionstring = string.Format(@"Server = (localdb)\v11.0; Integrated Security = true;AttachDbFileName = {0}\data\Shipyard.mdf;", Application.StartupPath);
            // connectionstring = "Server=.\\SQLEXPRESS;Database=Shipyard;User Id=sa;Password=1;";
            //connectionstring = @"Data Source=.\sqlexpress;Initial Catalog=E:\INDIVIDUAL\SHIPYARDINFO\SHIPYARDINFO\BIN\DEBUG\DATA\SHIPYARD.MDF;Integrated Security=True";
            connectionstring = ConfigurationManager.ConnectionStrings["QLKS_ConnectionString"].ConnectionString;
            con = new SqlConnection(connectionstring);
        }

        public SqlConnection Con
        {
            get
            {
                return con;
            }
        }

        public bool IsConnect()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public nhanvien Login(nhanvien nhanvienLogin)
        {
            nhanvien nv = null;
            SqlCommand cmd = new SqlCommand("Login");
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manv", nhanvienLogin.manv);
            cmd.Parameters.AddWithValue("@matkhau", nhanvienLogin.matkhau);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                nv = new nhanvien()
                {
                    manv = ds.Tables[0].Rows[0]["nv_manv"].ToString(),
                    matkhau = ds.Tables[0].Rows[0]["nv_matkhau"].ToString(),
                    hoten = ds.Tables[0].Rows[0]["nv_hoten"].ToString(),
                    ngaysinh = ds.Tables[0].Rows[0]["nv_ngaysinh"].ToString(),
                    gioitinh = (bool)ds.Tables[0].Rows[0]["nv_gioitinh"] ? "Nam" : "Nữ",
                    sdt = ds.Tables[0].Rows[0]["nv_sdt"].ToString(),
                    cmnd = ds.Tables[0].Rows[0]["nv_cmnd"].ToString(),
                    diachi = ds.Tables[0].Rows[0]["nv_diachi"].ToString(),
                    email = ds.Tables[0].Rows[0]["nv_email"].ToString(),
                    khoa = (bool)ds.Tables[0].Rows[0]["nv_khoa"],
                    fileanh = ds.Tables[0].Rows[0]["nv_fileanh"].ToString(),
                    chucVu = new chucvu()
                    {
                        macv = ds.Tables[0].Rows[0]["cv_macv"].ToString(),
                        tencv = ds.Tables[0].Rows[0]["cv_tencv"].ToString()
                    },
                    quyennv = new quyen()
                    {
                        id = ds.Tables[0].Rows[0]["q_id"].ToString(),
                        tenquyen = ds.Tables[0].Rows[0]["q_quyen"].ToString(),
                    }
                };
            }
            return nv;
        }

        public List<nhanvien> getAllNhanviens()
        {
            List<nhanvien> nhanviens = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("getAllNhanviens");
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    nhanviens = new List<nhanvien>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        nhanviens.Add(new nhanvien {
                            manv = ds.Tables[0].Rows[0]["nv_manv"].ToString(),
                            matkhau = ds.Tables[0].Rows[0]["nv_matkhau"].ToString(),
                            hoten = ds.Tables[0].Rows[0]["nv_hoten"].ToString(),
                            ngaysinh = ds.Tables[0].Rows[0]["nv_ngaysinh"].ToString(),
                            gioitinh = (bool)ds.Tables[0].Rows[0]["nv_gioitinh"] ? "Nam" : "Nữ",
                            sdt = ds.Tables[0].Rows[0]["nv_sdt"].ToString(),
                            cmnd = ds.Tables[0].Rows[0]["nv_cmnd"].ToString(),
                            diachi = ds.Tables[0].Rows[0]["nv_diachi"].ToString(),
                            email = ds.Tables[0].Rows[0]["nv_email"].ToString(),
                            khoa = (bool)ds.Tables[0].Rows[0]["nv_khoa"],
                            fileanh = ds.Tables[0].Rows[0]["nv_fileanh"].ToString(),
                            chucVu = new chucvu()
                            {
                                macv = ds.Tables[0].Rows[0]["cv_macv"].ToString(),
                                tencv = ds.Tables[0].Rows[0]["cv_tencv"].ToString()
                            },
                            quyennv = new quyen()
                            {
                                id = ds.Tables[0].Rows[0]["q_id"].ToString(),
                                tenquyen = ds.Tables[0].Rows[0]["q_quyen"].ToString(),
                            }
                        });
                    }
                }
            }
            return nhanviens;
        }
    }
}