using QLKSAPI.Models;
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

        public nhanvien Login(string tdn, string matkhau)
        {
            nhanvien nv = null;
            SqlCommand cmd = new SqlCommand("Login");
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tdn", tdn);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                nv = new nhanvien()
                {
                    manv = ds.Tables[0].Rows[0]["nv_ma"].ToString(),
                    tdn = ds.Tables[0].Rows[0]["nv_tdn"].ToString(),
                    matkhau = ds.Tables[0].Rows[0]["nv_matkhau"].ToString(),
                    hoten = ds.Tables[0].Rows[0]["nv_hoten"].ToString(),
                    ngaysinh = ds.Tables[0].Rows[0]["nv_ngaysinh"].ToString(),
                    gioitinh = (bool)ds.Tables[0].Rows[0]["nv_gioitinh"],
                    sdt = ds.Tables[0].Rows[0]["nv_sdt"].ToString(),
                    cmnd = ds.Tables[0].Rows[0]["nv_cmnd"].ToString(),
                    diachi = ds.Tables[0].Rows[0]["nv_diachi"].ToString(),
                    email = ds.Tables[0].Rows[0]["nv_email"].ToString(),
                    khoa = (bool)ds.Tables[0].Rows[0]["nv_khoa"],
                    xoa = (bool)ds.Tables[0].Rows[0]["nv_xoa"],
                    fileanh = ds.Tables[0].Rows[0]["nv_fileanh"].ToString(),
                    chucVu = new chucvu()
                    {
                        macv = ds.Tables[0].Rows[0]["cv_ma"].ToString(),
                        tencv = ds.Tables[0].Rows[0]["cv_ten"].ToString()
                    },
                    quyennv = new quyen()
                    {
                        maquyen = ds.Tables[0].Rows[0]["q_ma"].ToString(),
                        tenquyen = ds.Tables[0].Rows[0]["q_ten"].ToString(),
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
                            manv = ds.Tables[0].Rows[i]["nv_ma"].ToString(),
                            tdn = ds.Tables[0].Rows[i]["nv_tdn"].ToString(),
                            matkhau = ds.Tables[0].Rows[i]["nv_matkhau"].ToString(),
                            hoten = ds.Tables[0].Rows[i]["nv_hoten"].ToString(),
                            ngaysinh = ds.Tables[0].Rows[i]["nv_ngaysinh"].ToString(),
                            gioitinh = (bool)ds.Tables[0].Rows[i]["nv_gioitinh"],
                            sdt = ds.Tables[0].Rows[i]["nv_sdt"].ToString(),
                            cmnd = ds.Tables[0].Rows[i]["nv_cmnd"].ToString(),
                            diachi = ds.Tables[0].Rows[i]["nv_diachi"].ToString(),
                            email = ds.Tables[0].Rows[i]["nv_email"].ToString(),
                            khoa = (bool)ds.Tables[0].Rows[i]["nv_khoa"],
                            xoa = (bool)ds.Tables[0].Rows[i]["nv_xoa"],
                            fileanh = ds.Tables[0].Rows[i]["nv_fileanh"].ToString(),
                            chucVu = new chucvu()
                            {
                                macv = ds.Tables[0].Rows[i]["cv_ma"].ToString(),
                                tencv = ds.Tables[0].Rows[i]["cv_ten"].ToString()
                            },
                            quyennv = new quyen()
                            {
                                maquyen = ds.Tables[0].Rows[i]["q_ma"].ToString(),
                                tenquyen = ds.Tables[0].Rows[i]["q_ten"].ToString(),
                            }
                        });
                    }
                }
            }
            return nhanviens;
        }

        public nhanvien getNhanvienByMa(string manv)
        {
            nhanvien nv = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("getNhanvienByMa");
                cmd.Parameters.AddWithValue("@manv", manv);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    nv = new nhanvien()
                    {
                        manv = ds.Tables[0].Rows[0]["nv_ma"].ToString(),
                        tdn = ds.Tables[0].Rows[0]["nv_tdn"].ToString(),
                        matkhau = ds.Tables[0].Rows[0]["nv_matkhau"].ToString(),
                        hoten = ds.Tables[0].Rows[0]["nv_hoten"].ToString(),
                        ngaysinh = ds.Tables[0].Rows[0]["nv_ngaysinh"].ToString(),
                        gioitinh = (bool)ds.Tables[0].Rows[0]["nv_gioitinh"],
                        sdt = ds.Tables[0].Rows[0]["nv_sdt"].ToString(),
                        cmnd = ds.Tables[0].Rows[0]["nv_cmnd"].ToString(),
                        diachi = ds.Tables[0].Rows[0]["nv_diachi"].ToString(),
                        email = ds.Tables[0].Rows[0]["nv_email"].ToString(),
                        khoa = (bool)ds.Tables[0].Rows[0]["nv_khoa"],
                        xoa = (bool)ds.Tables[0].Rows[0]["nv_xoa"],
                        fileanh = ds.Tables[0].Rows[0]["nv_fileanh"].ToString(),
                        chucVu = new chucvu()
                        {
                            macv = ds.Tables[0].Rows[0]["cv_ma"].ToString(),
                            tencv = ds.Tables[0].Rows[0]["cv_ten"].ToString()
                        },
                        quyennv = new quyen()
                        {
                            maquyen = ds.Tables[0].Rows[0]["q_ma"].ToString(),
                            tenquyen = ds.Tables[0].Rows[0]["q_ten"].ToString(),
                        }
                    };
                }
            }
            return nv;
        }

        public List<nhanvien> searchNhanviens(string key)
        {
            if(key == "" || key == null)
            {
                return getAllNhanviens();
            }
            List<nhanvien> nhanviens = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("searchNhanviens");
                cmd.Parameters.AddWithValue("@key", key);
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
                        nhanviens.Add(new nhanvien
                        {
                            manv = ds.Tables[0].Rows[i]["nv_ma"].ToString(),
                            tdn = ds.Tables[0].Rows[i]["nv_tdn"].ToString(),
                            matkhau = ds.Tables[0].Rows[i]["nv_matkhau"].ToString(),
                            hoten = ds.Tables[0].Rows[i]["nv_hoten"].ToString(),
                            ngaysinh = ds.Tables[0].Rows[i]["nv_ngaysinh"].ToString(),
                            gioitinh = (bool)ds.Tables[0].Rows[i]["nv_gioitinh"],
                            sdt = ds.Tables[0].Rows[i]["nv_sdt"].ToString(),
                            cmnd = ds.Tables[0].Rows[i]["nv_cmnd"].ToString(),
                            diachi = ds.Tables[0].Rows[i]["nv_diachi"].ToString(),
                            email = ds.Tables[0].Rows[i]["nv_email"].ToString(),
                            khoa = (bool)ds.Tables[0].Rows[i]["nv_khoa"],
                            xoa = (bool)ds.Tables[0].Rows[i]["nv_xoa"],
                            fileanh = ds.Tables[0].Rows[i]["nv_fileanh"].ToString(),
                            chucVu = new chucvu()
                            {
                                macv = ds.Tables[0].Rows[i]["cv_ma"].ToString(),
                                tencv = ds.Tables[0].Rows[i]["cv_ten"].ToString()
                            },
                            quyennv = new quyen()
                            {
                                maquyen = ds.Tables[0].Rows[i]["q_ma"].ToString(),
                                tenquyen = ds.Tables[0].Rows[i]["q_ten"].ToString(),
                            }
                        });
                    }
                }
            }
            return nhanviens;
        }

        public bool insertNhanvien(nhanvien nv)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("insertNhanvien");
                command.Parameters.AddWithValue("@nv_ma", nv.manv);
                command.Parameters.AddWithValue("@nv_macv", nv.chucVu.macv);
                command.Parameters.AddWithValue("@nv_hoten", nv.hoten);
                command.Parameters.AddWithValue("@nv_ngaysinh", nv.ngaysinh);
                command.Parameters.AddWithValue("@nv_gioitinh", nv.gioitinh);
                command.Parameters.AddWithValue("@nv_sdt", nv.sdt);
                command.Parameters.AddWithValue("@nv_cmnd", nv.cmnd);
                command.Parameters.AddWithValue("@nv_diachi", nv.diachi);
                command.Parameters.AddWithValue("@nv_email", nv.email);
                command.Parameters.AddWithValue("@nv_khoa", false);
                command.Parameters.AddWithValue("@nv_xoa", false);
                command.Parameters.AddWithValue("@nv_tdn", nv.tdn);
                command.Parameters.AddWithValue("@nv_matkhau", nv.matkhau);
                command.Parameters.AddWithValue("@nv_maquyen", nv.quyennv.maquyen);
                command.Parameters.AddWithValue("@nv_fileanh", nv.fileanh);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public bool updateNhanvien(nhanvien nv)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("updateNhanVien");
                command.Parameters.AddWithValue("@nv_ma", nv.manv);
                command.Parameters.AddWithValue("@nv_macv", nv.chucVu.macv);
                command.Parameters.AddWithValue("@nv_hoten", nv.hoten);
                command.Parameters.AddWithValue("@nv_ngaysinh", nv.ngaysinh);
                command.Parameters.AddWithValue("@nv_gioitinh", nv.gioitinh);
                command.Parameters.AddWithValue("@nv_sdt", nv.sdt);
                command.Parameters.AddWithValue("@nv_cmnd", nv.cmnd);
                command.Parameters.AddWithValue("@nv_diachi", nv.diachi);
                command.Parameters.AddWithValue("@nv_email", nv.email);
                command.Parameters.AddWithValue("@nv_khoa", nv.khoa);
                command.Parameters.AddWithValue("@nv_xoa", nv.xoa);
                command.Parameters.AddWithValue("@nv_tdn", nv.tdn);
                command.Parameters.AddWithValue("@nv_matkhau", nv.matkhau);
                command.Parameters.AddWithValue("@nv_maquyen", nv.quyennv.maquyen);
                command.Parameters.AddWithValue("@nv_fileanh", nv.fileanh);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public bool deleteNhanvien(string manv)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("deleteNhanvien");
                command.Parameters.AddWithValue("@nv_ma", manv);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public bool changePassword(nhanvien nv, string matkhaumoi)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("changePassword");
                command.Parameters.AddWithValue("@nv_tdn", nv.tdn);
                command.Parameters.AddWithValue("@nv_matkhau", nv.matkhau);
                command.Parameters.AddWithValue("@matkhaumoi", matkhaumoi);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public List<chucvu> getAllChucvus()
        {
            List<chucvu> chucvus = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("getAllChucvus");
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    chucvus = new List<chucvu>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        chucvus.Add(new chucvu
                        {
                            macv = ds.Tables[0].Rows[i]["cv_ma"].ToString(),
                            tencv = ds.Tables[0].Rows[i]["cv_ten"].ToString()
                        });
                    }
                }
            }
            return chucvus;
        }

        public List<quyen> getAllQuyens()
        {
            List<quyen> quyens = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("getAllQuyens");
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    quyens = new List<quyen>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        quyens.Add(new quyen
                        {
                            maquyen = ds.Tables[0].Rows[i]["q_ma"].ToString(),
                            tenquyen = ds.Tables[0].Rows[i]["q_ten"].ToString()
                        });
                    }
                }
            }
            return quyens;
        }
        public List<loaiphong> getAllLoaiPhongs()
        {
            List<loaiphong> loaiphongs = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("getAllLoaiPhongs");
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    loaiphongs = new List<loaiphong>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        loaiphongs.Add(new loaiphong
                        {
                            lp_ma = ds.Tables[0].Rows[i]["lp_ma"].ToString(),
                            lp_ten = ds.Tables[0].Rows[i]["lp_ten"].ToString(),
                            lp_giaphong = (int)ds.Tables[0].Rows[i]["lp_giaphong"],
                            lp_soluong = (int)ds.Tables[0].Rows[i]["lp_soluong"],
                            lp_solandat = (int)ds.Tables[0].Rows[i]["lp_solandat"],
                            
                        });
                    }
                }
            }
            return loaiphongs;
        }
        public loaiphong getLoaiPhongByMa(string lp_ma)
        {
            loaiphong lp = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("getLoaiPhongByMa");
                cmd.Parameters.AddWithValue("@lp_ma", lp_ma);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    lp = new loaiphong()
                    {
                        lp_ma = ds.Tables[0].Rows[0]["lp_ma"].ToString(),
                        lp_ten = ds.Tables[0].Rows[0]["lp_ten"].ToString(),
                        lp_giaphong = (int)ds.Tables[0].Rows[0]["lp_giaphong"],
                        lp_soluong = (int)ds.Tables[0].Rows[0]["lp_soluong"],
                        lp_solandat = (int)ds.Tables[0].Rows[0]["lp_solandat"],
                    };
                }
            }
            return lp;
        }

        public List<loaiphong> searchLoaiPhongs(string key)
        {
            List<loaiphong> loaiphongs = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("searchLoaiPhongs");
                cmd.Parameters.AddWithValue("@key", key);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    loaiphongs = new List<loaiphong>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        loaiphongs.Add(new loaiphong
                        {
                            lp_ma = ds.Tables[0].Rows[i]["lp_ma"].ToString(),
                            lp_ten = ds.Tables[0].Rows[i]["lp_ten"].ToString(),
                            lp_giaphong = (int)ds.Tables[0].Rows[i]["lp_giaphong"],
                            lp_soluong = (int)ds.Tables[0].Rows[i]["lp_soluong"],
                            lp_solandat = (int)ds.Tables[0].Rows[i]["lp_solandat"],
                        });
                    }
                }
            }
            return loaiphongs;
        }

        public bool insertLoaiPhong(loaiphong lp)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("insertLoaiPhong");
                command.Parameters.AddWithValue("@lp_ma", lp.lp_ma);
                command.Parameters.AddWithValue("@lp_ten", lp.lp_ten);
                command.Parameters.AddWithValue("@lp_giaphong", lp.lp_giaphong);
                command.Parameters.AddWithValue("@lp_soluong", lp.lp_soluong);
                command.Parameters.AddWithValue("@lp_solandat", lp.lp_solandat);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public bool updateLoaiPhong(loaiphong lp)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("updateLoaiPhong");
                command.Parameters.AddWithValue("@lp_ma", lp.lp_ma);
                command.Parameters.AddWithValue("@lp_ten", lp.lp_ten);
                command.Parameters.AddWithValue("@lp_giaphong", lp.lp_giaphong);
                command.Parameters.AddWithValue("@lp_soluong", lp.lp_soluong);
                command.Parameters.AddWithValue("@lp_solandat", lp.lp_solandat);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }
        public List<phong> getAllPhongs()
        {
            List<phong> phongs = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("getAllPhongs");
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    phongs = new List<phong>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        phongs.Add(new phong
                        {
                            p_ma = ds.Tables[0].Rows[i]["p_ma"].ToString(),
                            p_malp = ds.Tables[0].Rows[i]["p_malp"].ToString(),
                            p_tinhtrang = ds.Tables[0].Rows[i]["p_tinhtrang"].ToString(),
                            p_sophong = ds.Tables[0].Rows[i]["p_sophong"].ToString(),
                            p_solandat = (int)ds.Tables[0].Rows[i]["p_solandat"],

                        });
                    }
                }
            }
            return phongs;
        }
        public phong getPhongByMa(string p_ma)
        {
            phong p = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("getPhongByMa");
                cmd.Parameters.AddWithValue("@p_ma", p_ma);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    p = new phong()
                    {
                        p_ma = ds.Tables[0].Rows[0]["p_ma"].ToString(),
                        p_malp = ds.Tables[0].Rows[0]["p_malp"].ToString(),
                        p_tinhtrang = ds.Tables[0].Rows[0]["p_tinhtrang"].ToString(),
                        p_sophong = ds.Tables[0].Rows[0]["p_sophong"].ToString(),
                        p_solandat = (int)ds.Tables[0].Rows[0]["p_solandat"],
                    };
                }
            }
            return p;
        }

        public phong getPhongByLoaiPhong(string p_malp)
        {
            phong p = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("getPhongByLoaiPhong");
                cmd.Parameters.AddWithValue("@p_malp", p_malp);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    p = new phong()
                    {
                        p_ma = ds.Tables[0].Rows[0]["p_ma"].ToString(),
                        p_malp = ds.Tables[0].Rows[0]["p_malp"].ToString(),
                        p_tinhtrang = ds.Tables[0].Rows[0]["p_tinhtrang"].ToString(),
                        p_sophong = ds.Tables[0].Rows[0]["p_sophong"].ToString(),
                        p_solandat = (int)ds.Tables[0].Rows[0]["p_solandat"],
                    };
                }
            }
            return p;
        }
        public List<phong> searchPhongs(string key)
        {
            List<phong> phongs = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("searchPhongs");
                cmd.Parameters.AddWithValue("@key", key);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                   phongs = new List<phong>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        phongs.Add(new phong
                        {
                            p_ma = ds.Tables[0].Rows[i]["p_ma"].ToString(),
                            p_malp = ds.Tables[0].Rows[i]["p_malp"].ToString(),
                            p_tinhtrang = ds.Tables[0].Rows[i]["p_tinhtrang"].ToString(),
                            p_sophong = ds.Tables[0].Rows[i]["p_sophong"].ToString(),
                            p_solandat = (int)ds.Tables[0].Rows[i]["p_solandat"],

                        });
                    }
                }
            }
            return phongs;
        }
        public bool insertPhong(phong p)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("insertPhong");
                command.Parameters.AddWithValue("@p_ma", p.p_ma);
                command.Parameters.AddWithValue("@p_malp", p.p_malp);
                command.Parameters.AddWithValue("@p_tinhtrang", p.p_tinhtrang);
                command.Parameters.AddWithValue("@p_sophong", p.p_sophong);
                command.Parameters.AddWithValue("@p_solandat", p.p_solandat);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public bool updatePhong(phong p)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("updatePhong");
                command.Parameters.AddWithValue("@p_ma", p.p_ma);
                command.Parameters.AddWithValue("@p_malp", p.p_malp);
                command.Parameters.AddWithValue("@p_tinhtrang", p.p_tinhtrang);
                command.Parameters.AddWithValue("@p_sophong", p.p_sophong);
                command.Parameters.AddWithValue("@p_solandat", p.p_solandat);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public bool deletePhong (string p_ma)
        {
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("delete from phong where p_ma=@p_ma");
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@p_ma", p_ma);
                return command.ExecuteNonQuery() > 0 ? true : false;
            }
            return false;
        }
        // Trang thiết bị
        public List<Trangthietbi> getAllTrangthietbis()
        {
            List<Trangthietbi> Trangthietbis = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("getAllTrangthietbis");
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Trangthietbis = new List<Trangthietbi>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        Trangthietbis.Add(new Trangthietbi
                        {
                            mattb = ds.Tables[0].Rows[i]["ttb_ma"].ToString(),
                            tenttb = ds.Tables[0].Rows[i]["ttb_ten"].ToString(),
                            dongia = (ds.Tables[0].Rows[i]["ttb_dongia"] == null) ? 0 : int.Parse(ds.Tables[0].Rows[i]["ttb_dongia"].ToString()),
                            donvitinh = ds.Tables[0].Rows[i]["ttb_donvitinh"].ToString(),
                            soluong = (ds.Tables[0].Rows[i]["ttb_soluong"] == null) ? 0 : int.Parse(ds.Tables[0].Rows[i]["ttb_soluong"].ToString()),
                            ghichu = ds.Tables[0].Rows[i]["ttb_ghichu"].ToString()
                        });
                    }
                }
            }
            return Trangthietbis;
        }
        public Trangthietbi getTrangthietbiByMa(string mattb)
        {
            Trangthietbi ttb = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("getTrangthietbiByMa");
                cmd.Parameters.AddWithValue("@mattb", mattb);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ttb = new Trangthietbi()
                    {
                        mattb = ds.Tables[0].Rows[0]["ttb_ma"].ToString(),
                        tenttb = ds.Tables[0].Rows[0]["ttb_ten"].ToString(),
                        dongia = (ds.Tables[0].Rows[0]["ttb_dongia"] == null) ? 0 : int.Parse(ds.Tables[0].Rows[0]["ttb_dongia"].ToString()),
                        donvitinh = ds.Tables[0].Rows[0]["ttb_donvitinh"].ToString(),
                        soluong = (ds.Tables[0].Rows[0]["ttb_soluong"] == null) ? 0 : int.Parse(ds.Tables[0].Rows[0]["ttb_soluong"].ToString()),
                        ghichu = ds.Tables[0].Rows[0]["ttb_ghichu"].ToString()
                    };
                }
            }
            return ttb;
        }
        public List<Trangthietbi> searchTrangthietbis(string key)
        {
            if (key == "" || key == null)
            {
                return getAllTrangthietbis();
            }
            List<Trangthietbi> Trangthietbis = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("searchTrangthietbis");
                cmd.Parameters.AddWithValue("@key", key);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Trangthietbis = new List<Trangthietbi>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        Trangthietbis.Add(new Trangthietbi
                        {
                            mattb = ds.Tables[0].Rows[i]["ttb_ma"].ToString(),
                            tenttb = ds.Tables[0].Rows[i]["ttb_ten"].ToString(),
                            dongia = (ds.Tables[0].Rows[i]["ttb_dongia"] == null) ? 0 : int.Parse(ds.Tables[0].Rows[i]["ttb_dongia"].ToString()),
                            donvitinh = ds.Tables[0].Rows[i]["ttb_donvitinh"].ToString(),
                            soluong = (ds.Tables[0].Rows[i]["ttb_soluong"] == null) ? 0 : int.Parse(ds.Tables[0].Rows[i]["ttb_soluong"].ToString()),
                            ghichu = ds.Tables[0].Rows[i]["ttb_ghichu"].ToString()
                        });
                    }
                }
            }
            return Trangthietbis;
        }
        public bool insertTrangthietbi(Trangthietbi ttb)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("insertTrangthietbi");
                command.Parameters.AddWithValue("@ttb_ma", ttb.mattb);
                command.Parameters.AddWithValue("@ttb_ten", ttb.tenttb);
                command.Parameters.AddWithValue("@ttb_dongia", ttb.dongia);
                command.Parameters.AddWithValue("@ttb_donvitinh", ttb.donvitinh);
                command.Parameters.AddWithValue("@ttb_soluong", ttb.soluong);
                command.Parameters.AddWithValue("@ttb_ghichu", ttb.ghichu);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }
        public bool updateTrangthietbi(Trangthietbi ttb)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("updateTrangthietbi");
                command.Parameters.AddWithValue("@ttb_ma", ttb.mattb);
                command.Parameters.AddWithValue("@ttb_ten", ttb.tenttb);
                command.Parameters.AddWithValue("@ttb_dongia", ttb.dongia);
                command.Parameters.AddWithValue("@ttb_donvitinh", ttb.donvitinh);
                command.Parameters.AddWithValue("@ttb_soluong", ttb.soluong);
                command.Parameters.AddWithValue("@ttb_ghichu", ttb.ghichu);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }
        public bool deleteTrangthietbi(string mattb)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("deleteTrangthietbi");
                command.Parameters.AddWithValue("@ttb_ma", mattb);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }
    }
}