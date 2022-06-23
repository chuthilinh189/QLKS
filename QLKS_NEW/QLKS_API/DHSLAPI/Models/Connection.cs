using DHSLAPI.Models;
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

        public List<NhanVien> SelectAllByID(string MaNV)
        {
            List<NhanVien> nhanViens = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblNhanVien_SelectByID");
                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    nhanViens = new List<NhanVien>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        nhanViens.Add(new NhanVien
                        {
                            MaNV = ds.Tables[0].Rows[0]["MaNV"].ToString(),
                            HoDem = ds.Tables[0].Rows[0]["HoDem"].ToString(),
                            Ten = ds.Tables[0].Rows[0]["Ten"].ToString(),
                            NgaySinh = DateTime.Parse(ds.Tables[0].Rows[0]["NgaySinh"].ToString()),
                            CMND = ds.Tables[0].Rows[0]["CMND"].ToString(),
                            GhiChu = ds.Tables[0].Rows[0]["NghiChu"].ToString(),
                            MatKhau = ds.Tables[0].Rows[0]["MatKhau"].ToString(),
                            ChucVuNV = new ChucVu()
                            {
                                MaCV = ds.Tables[0].Rows[0]["MaCV"].ToString(),
                                Khu = int.Parse(ds.Tables[0].Rows[0]["Khu"].ToString()),
                                TenDonVi = ds.Tables[0].Rows[0]["TenDonVi"].ToString(),
                                TenChucVu = ds.Tables[0].Rows[0]["ChucVu"].ToString()
                            }
                        });
                    }
                }
            }
            return nhanViens;
        }
        public List<NhanVien> SelectAll()
        {
            List<NhanVien> nhanViens = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblNhanVien_SelectAll");
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    nhanViens = new List<NhanVien>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        nhanViens.Add(new NhanVien
                        {
                            MaNV = ds.Tables[0].Rows[i]["MaNV"].ToString(),
                            HoDem = ds.Tables[0].Rows[i]["HoDem"].ToString(),
                            Ten = ds.Tables[0].Rows[i]["Ten"].ToString(),
                            NgaySinh = DateTime.Parse(ds.Tables[0].Rows[i]["NgaySinh"].ToString()),
                            CMND = ds.Tables[0].Rows[i]["CMND"].ToString(),
                            GhiChu = ds.Tables[0].Rows[i]["NghiChu"].ToString(),
                            MatKhau = ds.Tables[0].Rows[i]["MatKhau"].ToString(),
                            ChucVuNV = new ChucVu()
                            {
                                MaCV = ds.Tables[0].Rows[i]["MaCV"].ToString(),
                                Khu = int.Parse(ds.Tables[0].Rows[i]["Khu"].ToString()),
                                TenDonVi = ds.Tables[0].Rows[i]["TenDonVi"].ToString(),
                                TenChucVu = ds.Tables[0].Rows[i]["ChucVu"].ToString()
                            }
                        });
                    }
                }
            }
            return nhanViens;
        }

        public bool InsertNhanvien(NhanVien nv)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("tblNhanVien_Insert");
                command.Parameters.AddWithValue("@MaNV", nv.MaNV);
                command.Parameters.AddWithValue("@MaCV", nv.ChucVuNV.MaCV);
                command.Parameters.AddWithValue("@HoDem", nv.HoDem);
                command.Parameters.AddWithValue("@Ten", nv.Ten);
                command.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                command.Parameters.AddWithValue("@CMND", nv.CMND);
                command.Parameters.AddWithValue("@NghiChu", nv.GhiChu);
                command.Parameters.AddWithValue("@MatKhau", nv.MatKhau);
                
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public bool DeleteNhanvien(string manv)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("tblNhanVien_Delete");
                command.Parameters.AddWithValue("@MaNV", manv);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public bool UpdateNhanvien(NhanVien nv)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("tblNhanVien_Update");
                command.Parameters.AddWithValue("@MaNV", nv.MaNV);
                command.Parameters.AddWithValue("@MaCV", nv.ChucVuNV.MaCV);
                command.Parameters.AddWithValue("@HoDem", nv.HoDem);
                command.Parameters.AddWithValue("@Ten", nv.Ten);
                command.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                command.Parameters.AddWithValue("@CMND ", nv.CMND);
                command.Parameters.AddWithValue("@NghiChu", nv.GhiChu);
                command.Parameters.AddWithValue("@MatKhau", nv.MatKhau);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public List<NhanVien> NhanVienSelectTop(string Top, string Where, string Order)
        {
            List<NhanVien> nhanViens = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblNhanVien_SelectTop");
                cmd.Parameters.AddWithValue("@Top", Top);
                cmd.Parameters.AddWithValue("@Where", Where);
                cmd.Parameters.AddWithValue("@Order", Order);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    nhanViens = new List<NhanVien>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        nhanViens.Add(new NhanVien
                        {
                            MaNV = ds.Tables[0].Rows[i]["MaNV"].ToString(),
                            HoDem = ds.Tables[0].Rows[i]["HoDem"].ToString(),
                            Ten = ds.Tables[0].Rows[i]["Ten"].ToString(),
                            NgaySinh = DateTime.Parse(ds.Tables[0].Rows[i]["NgaySinh"].ToString()),
                            CMND = ds.Tables[0].Rows[i]["CMND"].ToString(),
                            GhiChu = ds.Tables[0].Rows[i]["NghiChu"].ToString(),
                            MatKhau = ds.Tables[0].Rows[i]["MatKhau"].ToString(),
                            ChucVuNV = new ChucVu()
                            {
                                MaCV = ds.Tables[0].Rows[i]["MaCV"].ToString(),
                                Khu = int.Parse(ds.Tables[0].Rows[i]["Khu"].ToString()),
                                TenDonVi = ds.Tables[0].Rows[i]["TenDonVi"].ToString(),
                                TenChucVu = ds.Tables[0].Rows[i]["ChucVu"].ToString()
                            }
                        });
                    }
                }
            }
            return nhanViens;
        }

        public bool NhanVienTestByID(string MaNV)
        {
            bool b = false;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblNhanVien_TestByID");
                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    b = Convert.ToBoolean(ds.Tables[1].Rows[0]["TestID"].ToString());
                }
            }
            return b;
        }


        public NhanVien Login(string tdn, string matkhau)
        {
            NhanVien nv = null;
            SqlCommand cmd = new SqlCommand("tblNhanVien_Login");
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNV", tdn);
            cmd.Parameters.AddWithValue("@MatKhau", matkhau);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                nv = new NhanVien()
                {
                    MaNV = ds.Tables[0].Rows[0]["MaNV"].ToString(),
                    HoDem = ds.Tables[0].Rows[0]["HoDem"].ToString(),
                    Ten = ds.Tables[0].Rows[0]["Ten"].ToString(),
                    NgaySinh = DateTime.Parse(ds.Tables[0].Rows[0]["NgaySinh"].ToString()),
                    CMND = ds.Tables[0].Rows[0]["CMND"].ToString(),
                    GhiChu = ds.Tables[0].Rows[0]["NghiChu"].ToString(),
                    MatKhau = ds.Tables[0].Rows[0]["MatKhau"].ToString(),
                    ChucVuNV = new ChucVu()
                    {
                        MaCV = ds.Tables[0].Rows[0]["MaCV"].ToString(),
                        Khu = int.Parse(ds.Tables[0].Rows[0]["Khu"].ToString()),
                        TenDonVi = ds.Tables[0].Rows[0]["TenDonVi"].ToString(),
                        TenChucVu = ds.Tables[0].Rows[0]["ChucVu"].ToString()
                    }
                };
            }
            return nv;
        }

        // Chức vụ
        public List<ChucVu> ChucVuSelectAll()
        {
            List<ChucVu> chucVus = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblChucVu_SelectAll");
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    chucVus = new List<ChucVu>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        chucVus.Add(new ChucVu
                        {
                            MaCV = ds.Tables[0].Rows[i]["MaCV"].ToString(),
                            Khu = int.Parse(ds.Tables[0].Rows[i]["Khu"].ToString()),
                            TenDonVi = ds.Tables[0].Rows[i]["TenDonVi"].ToString(),
                            TenChucVu = ds.Tables[0].Rows[i]["ChucVu"].ToString()
                        });
                    }
                }
            }
            return chucVus;
        }

        public List<ChucVu> ChucVuSelectTop(string Top, string Where, string Order)
        {
            List<ChucVu> chucVus = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblChucVu_SelectTop");
                cmd.Parameters.AddWithValue("@Top", Top);
                cmd.Parameters.AddWithValue("@Where", Where);
                cmd.Parameters.AddWithValue("@Order", Order);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    chucVus = new List<ChucVu>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        chucVus.Add(new ChucVu
                        {
                            MaCV = ds.Tables[0].Rows[i]["MaCV"].ToString(),
                            Khu = int.Parse(ds.Tables[0].Rows[i]["Khu"].ToString()),
                            TenDonVi = ds.Tables[0].Rows[i]["TenDonVi"].ToString(),
                            TenChucVu = ds.Tables[0].Rows[i]["ChucVu"].ToString()
                        });
                    }
                }
            }
            return chucVus;
        }

        public ChucVu ChucVuSelectByID(string MaCV)
        {
            ChucVu chucVus = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblChucVu_SelectByID");
                cmd.Parameters.AddWithValue("@MaCV", MaCV);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    chucVus = new ChucVu();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        chucVus = new ChucVu()
                        {
                            MaCV = ds.Tables[0].Rows[i]["MaCV"].ToString(),
                            Khu = int.Parse(ds.Tables[0].Rows[i]["Khu"].ToString()),
                            TenDonVi = ds.Tables[0].Rows[i]["TenDonVi"].ToString(),
                            TenChucVu = ds.Tables[0].Rows[i]["ChucVu"].ToString()
                        };
                    }
                }
            }
            return chucVus;
        }

        public bool ChucVuTestByID(string MaCV)
        {
            bool b = false;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblChucVu_TestByID");
                cmd.Parameters.AddWithValue("@MaCV", MaCV);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    b = Convert.ToBoolean(ds.Tables[1].Rows[0]["TestID"].ToString());
                }
            }
            return b;
        }

        public bool ChucVuInsert(ChucVu cv)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("tblChucVu_Insert");
                command.Parameters.AddWithValue("@MaCV", cv.MaCV);
                command.Parameters.AddWithValue("@Khu", cv.Khu);
                command.Parameters.AddWithValue("@TenDonVi", cv.TenDonVi);
                command.Parameters.AddWithValue("@ChucVu", cv.TenChucVu);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public bool ChucVuUpdate(ChucVu cv)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("tblChucVu_Update");
                command.Parameters.AddWithValue("@MaCV", cv.MaCV);
                command.Parameters.AddWithValue("@Khu", cv.Khu);
                command.Parameters.AddWithValue("@TenDonVi", cv.TenDonVi);
                command.Parameters.AddWithValue("@ChucVu", cv.TenChucVu);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public bool ChucVuDelete(string MaCV)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("tblChucVu_Delete");
                command.Parameters.AddWithValue("@MaCV", MaCV);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }
        public List<Phong> SelectAllPhong()
        {
            List<Phong> phongs = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblPhong_SelectAll");

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    phongs = new List<Phong>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        phongs.Add(new Phong
                        {
                            MaPhong = ds.Tables[0].Rows[i]["MaPhong"].ToString(),
                            TenPhong = ds.Tables[0].Rows[i]["TenPhong"].ToString(),
                            LoaiPhong = ds.Tables[0].Rows[i]["LoaiPhong"].ToString(),
                            Gia = (int)ds.Tables[0].Rows[i]["Gia"],
                        });
                    }
                }
            }
            return phongs;
        }

        public List<Phong> SelectPhongDaDK()
        {
            List<Phong> phongs = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblPhong_DaDangKy");

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    phongs = new List<Phong>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        phongs.Add(new Phong
                        {
                            MaPhong = ds.Tables[0].Rows[i]["MaPhong"].ToString(),
                            TenPhong = ds.Tables[0].Rows[i]["TenPhong"].ToString(),
                            LoaiPhong = ds.Tables[0].Rows[i]["LoaiPhong"].ToString(),
                            Gia = (int)ds.Tables[0].Rows[i]["Gia"],
                        });
                    }
                }
            }
            return phongs;
        }
        public List<Phong> SelectPhongDaNhan()
        {
            List<Phong> phongs = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblPhong_DaNhanPhong");

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    phongs = new List<Phong>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        phongs.Add(new Phong
                        {
                            MaPhong = ds.Tables[0].Rows[i]["MaPhong"].ToString(),
                            TenPhong = ds.Tables[0].Rows[i]["TenPhong"].ToString(),
                            LoaiPhong = ds.Tables[0].Rows[i]["LoaiPhong"].ToString(),
                            Gia = (int)ds.Tables[0].Rows[i]["Gia"],
                        });
                    }
                }
            }
            return phongs;
        }
        public Phong SelectPhongById(string MaPhong)
        {
            Phong p = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblPhong_SelectByID");
                cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    p = new Phong()

                    {
                        MaPhong = ds.Tables[0].Rows[0]["MaPhong"].ToString(),
                        TenPhong = ds.Tables[0].Rows[0]["TenPhong"].ToString(),
                        LoaiPhong = ds.Tables[0].Rows[0]["LoaiPhong"].ToString(),
                        Gia = (int)ds.Tables[0].Rows[0]["Gia"],
                    };

                }
            }
            return p;
        }

        public List<Phong> PhongSelectTop(string Top, string Where, string Order)
        {
            List<Phong> phongs = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblPhong_SelectTop");
                cmd.Parameters.AddWithValue("@Top", Top);
                cmd.Parameters.AddWithValue("@Where", Where);
                cmd.Parameters.AddWithValue("@Order", Order);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    phongs = new List<Phong>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        phongs.Add(new Phong
                        {
                            MaPhong = ds.Tables[0].Rows[i]["MaPhong"].ToString(),
                            TenPhong = ds.Tables[0].Rows[i]["TenPhong"].ToString(),
                            LoaiPhong = ds.Tables[0].Rows[i]["LoaiPhong"].ToString(),
                            Gia = (int)ds.Tables[0].Rows[i]["Gia"],
                        });
                    }
                }
            }
            return phongs;
        }
        public bool insertPhong(Phong p)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("tblPhong_Insert");
                command.Parameters.AddWithValue("@MaPhong", p.MaPhong);
                command.Parameters.AddWithValue("@TenPhong", p.TenPhong);
                command.Parameters.AddWithValue("@LoaiPhong", p.LoaiPhong);
                command.Parameters.AddWithValue("@Gia", p.Gia);


                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public bool updatePhong(Phong p)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("tblPhong_Update");
                command.Parameters.AddWithValue("@MaPhong", p.MaPhong);
                command.Parameters.AddWithValue("@TenPhong", p.TenPhong);
                command.Parameters.AddWithValue("@LoaiPhong", p.LoaiPhong);
                command.Parameters.AddWithValue("@Gia", p.Gia);


                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public bool deletePhong(string MaPhong)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("tblPhong_Delete");
                command.Parameters.AddWithValue("@MaPhong", MaPhong);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public List<KhachHang> SelectAllKhachHang()
        {
            List<KhachHang> khachHangs = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblKhachHang_SelectAll");

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    khachHangs = new List<KhachHang>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        khachHangs.Add(new KhachHang
                        {
                            MaKhach = ds.Tables[0].Rows[i]["MaKhach"].ToString(),
                            HoDem = ds.Tables[0].Rows[i]["HoDem"].ToString(),
                            Ten = ds.Tables[0].Rows[i]["Ten"].ToString(),
                            NgaySinh = (DateTime)ds.Tables[0].Rows[i]["NgaySinh"],
                            CMND = ds.Tables[0].Rows[i]["CMND"].ToString(),
                            QuocTich = ds.Tables[0].Rows[i]["QuocTich"].ToString(),
                            GhiChu = ds.Tables[0].Rows[i]["GhiChu"].ToString(),
                        });
                    }
                }
            }
            return khachHangs;
        }

        public KhachHang SelectKhachHangById(string MaKhach)
        {
            KhachHang kh = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblKhachHang_SelectByID");
                cmd.Parameters.AddWithValue("@MaKhach", MaKhach);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    kh = new KhachHang()

                    {
                        MaKhach = ds.Tables[0].Rows[0]["MaKhach"].ToString(),
                        HoDem = ds.Tables[0].Rows[0]["HoDem"].ToString(),
                        Ten = ds.Tables[0].Rows[0]["Ten"].ToString(),
                        NgaySinh = (DateTime)ds.Tables[0].Rows[0]["NgaySinh"],
                        CMND = ds.Tables[0].Rows[0]["CMND"].ToString(),
                        QuocTich = ds.Tables[0].Rows[0]["QuocTich"].ToString(),
                        GhiChu = ds.Tables[0].Rows[0]["GhiChu"].ToString(),
                    };

                }
            }
            return kh;
        }

        public List<KhachHang> KhachHangSelectTop(string Top, string Where, string Order)
        {
            List<KhachHang> khachHangs = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblThanhToan_SelectTop");
                cmd.Parameters.AddWithValue("@Top", Top);
                cmd.Parameters.AddWithValue("@Where", Where);
                cmd.Parameters.AddWithValue("@Order", Order);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    khachHangs = new List<KhachHang>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        khachHangs.Add(new KhachHang
                        {
                            MaKhach = ds.Tables[0].Rows[i]["MaKhach"].ToString(),
                            HoDem = ds.Tables[0].Rows[i]["HoDem"].ToString(),
                            Ten = ds.Tables[0].Rows[i]["Ten"].ToString(),
                            NgaySinh = (DateTime)ds.Tables[0].Rows[i]["NgaySinh"],
                            CMND = ds.Tables[0].Rows[i]["CMND"].ToString(),
                            QuocTich = ds.Tables[0].Rows[i]["QuocTich"].ToString(),
                            GhiChu = ds.Tables[0].Rows[i]["GhiChu"].ToString(),
                        });
                    }
                }
            }
            return khachHangs;
        }
        public bool insertKhachHang(KhachHang kh)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("tblKhachHang_Insert");
                command.Parameters.AddWithValue("@MaKhach", kh.MaKhach);
                command.Parameters.AddWithValue("@HoDem", kh.HoDem);
                command.Parameters.AddWithValue("@Ten", kh.Ten);
                command.Parameters.AddWithValue("@NgaySinh", kh.NgaySinh);
                command.Parameters.AddWithValue("@CMND", kh.CMND);
                command.Parameters.AddWithValue("@QuocTich", kh.QuocTich);
                command.Parameters.AddWithValue("@GhiChu", kh.GhiChu);


                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public bool updateKhachHang(KhachHang kh)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("tblKhachHang_Update");
                command.Parameters.AddWithValue("@MaKhach", kh.MaKhach);
                command.Parameters.AddWithValue("@HoDem", kh.HoDem);
                command.Parameters.AddWithValue("@Ten", kh.Ten);
                command.Parameters.AddWithValue("@NgaySinh", kh.NgaySinh);
                command.Parameters.AddWithValue("@CMND", kh.CMND);
                command.Parameters.AddWithValue("@QuocTich", kh.QuocTich);
                command.Parameters.AddWithValue("@GhiChu", kh.GhiChu);


                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public bool deleteKhachHang(string MaKhach)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("tblKhachHang_Delete");
                command.Parameters.AddWithValue("@MaKhach", MaKhach);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public List<DichVu> SelectAllDichVu()
        {
            List<DichVu> dichVus = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblDichVu_SelectAll");

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dichVus = new List<DichVu>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        dichVus.Add(new DichVu
                        {
                            MaDV = ds.Tables[0].Rows[i]["MaDV"].ToString(),
                            TenDV = ds.Tables[0].Rows[i]["TenDV"].ToString(),
                            GiaTien = (int)ds.Tables[0].Rows[i]["GiaTien"],
                        });
                    }
                }
            }
            return dichVus;
        }

        public DichVu SelectDichVuById(string MaDV)
        {
            DichVu dv = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblDichVu_SelectByID");
                cmd.Parameters.AddWithValue("@MaDV", MaDV);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dv = new DichVu()

                    {
                        MaDV = ds.Tables[0].Rows[0]["MaDV"].ToString(),
                        TenDV = ds.Tables[0].Rows[0]["TenDV"].ToString(),
                        GiaTien = (int)ds.Tables[0].Rows[0]["GiaTien"],
                    };

                }
            }
            return dv;
        }

        public List<DichVu> DichVuSelectTop(string Top, string Where, string Order)
        {
            List<DichVu> dichVus = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblDichVu_SelectTop");
                cmd.Parameters.AddWithValue("@Top", Top);
                cmd.Parameters.AddWithValue("@Where", Where);
                cmd.Parameters.AddWithValue("@Order", Order);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dichVus = new List<DichVu>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        dichVus.Add(new DichVu
                        {
                            MaDV = ds.Tables[0].Rows[i]["MaDV"].ToString(),
                            TenDV = ds.Tables[0].Rows[i]["TenDV"].ToString(),
                            GiaTien = (int)ds.Tables[0].Rows[i]["GiaTien"],
                        });
                    }
                }
            }
            return dichVus;
        }
        public bool insertDichVu(DichVu dv)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("tblDichVu_Insert");
                command.Parameters.AddWithValue("@MaDV", dv.MaDV);
                command.Parameters.AddWithValue("@TenDV", dv.TenDV);
                command.Parameters.AddWithValue("@GiaTien", dv.GiaTien);


                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public bool updateDichVu(DichVu dv)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("tblDichVu_Update");
                command.Parameters.AddWithValue("@MaDV", dv.MaDV);
                command.Parameters.AddWithValue("@TenDV", dv.TenDV);
                command.Parameters.AddWithValue("@GiaTien", dv.GiaTien);


                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public bool deleteDichVu(string MaDV)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("tblDichVu_Delete");
                command.Parameters.AddWithValue("@MaDV", MaDV);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        // Đăng ký
        public List<DangKy> DangKySelectAll()
        {
            List<DangKy> dangKys = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblDangKy_SelectAll");
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dangKys = new List<DangKy>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        DangKy dk = new DangKy();
                        dk.MaDK = ds.Tables[0].Rows[i]["MaDK"].ToString();
                        dk.KhachHangDK = new KhachHang();
                        dk.KhachHangDK.MaKhach = ds.Tables[0].Rows[i]["MaKhach"].ToString();
                        dk.KhachHangDK.HoDem = ds.Tables[0].Rows[i]["HoDem"].ToString();
                        dk.KhachHangDK.Ten = ds.Tables[0].Rows[i]["Ten"].ToString();
                        dk.KhachHangDK.NgaySinh = (DateTime)ds.Tables[0].Rows[i]["NgaySinh"];
                        dk.KhachHangDK.CMND = ds.Tables[0].Rows[i]["CMND"].ToString();
                        dk.KhachHangDK.QuocTich = ds.Tables[0].Rows[i]["QuocTich"].ToString();
                        dk.KhachHangDK.GhiChu = ds.Tables[0].Rows[i]["GhiChu"].ToString();
                        dk.NgayDangKy = (DateTime)ds.Tables[0].Rows[i]["NgayDangKy"];
                        dk.NgayDen = null;
                        dk.NgayDi = null;
                        if(ds.Tables[0].Rows[i]["NgayDen"] != null)
                        {
                            dk.NgayDen = (DateTime)ds.Tables[0].Rows[i]["NgayDen"];
                        }
                        if (ds.Tables[0].Rows[i]["NgayDi"] != null)
                        {
                            dk.NgayDi = (DateTime)ds.Tables[0].Rows[i]["NgayDi"];
                        }
                        dk.TienDat = (int)ds.Tables[0].Rows[i]["TienDat"];
                        dk.SoNguoi = (int)ds.Tables[0].Rows[i]["SoNguoi"];
                        dk.GhiChu = ds.Tables[0].Rows[i]["NgiChu"].ToString();
                        dk.PhongDK = new Phong();
                        dk.PhongDK.MaPhong = ds.Tables[0].Rows[i]["MaPhong"].ToString();
                        dk.PhongDK.TenPhong = ds.Tables[0].Rows[i]["TenPhong"].ToString();
                        dk.PhongDK.LoaiPhong = ds.Tables[0].Rows[i]["LoaiPhong"].ToString();
                        dk.PhongDK.Gia = (int)ds.Tables[0].Rows[i]["Gia"];
                        dangKys.Add(dk);
                    }
                }
            }
            return dangKys;
        }
        public List<DangKy> DangKySelectTop(string Top, string Where, string Order)
        {
            List<DangKy> dangKys = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblDangKy_SelectTop");
                cmd.Parameters.AddWithValue("@Top", Top);
                cmd.Parameters.AddWithValue("@Where", Where);
                cmd.Parameters.AddWithValue("@Order", Order);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dangKys = new List<DangKy>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        DangKy dk = new DangKy();
                        dk.MaDK = ds.Tables[0].Rows[i]["MaDK"].ToString();
                        dk.KhachHangDK = new KhachHang();
                        dk.KhachHangDK.MaKhach = ds.Tables[0].Rows[i]["MaKhach"].ToString();
                        dk.KhachHangDK.HoDem = ds.Tables[0].Rows[i]["HoDem"].ToString();
                        dk.KhachHangDK.Ten = ds.Tables[0].Rows[i]["Ten"].ToString();
                        dk.KhachHangDK.NgaySinh = (DateTime)ds.Tables[0].Rows[i]["NgaySinh"];
                        dk.KhachHangDK.CMND = ds.Tables[0].Rows[i]["CMND"].ToString();
                        dk.KhachHangDK.QuocTich = ds.Tables[0].Rows[i]["QuocTich"].ToString();
                        dk.KhachHangDK.GhiChu = ds.Tables[0].Rows[i]["GhiChu"].ToString();
                        dk.NgayDangKy = (DateTime)ds.Tables[0].Rows[i]["NgayDangKy"];
                        dk.NgayDen = null;
                        dk.NgayDi = null;
                        if (ds.Tables[0].Rows[i]["NgayDen"] != null)
                        {
                            dk.NgayDen = (DateTime)ds.Tables[0].Rows[i]["NgayDen"];
                        }
                        if (ds.Tables[0].Rows[i]["NgayDi"] != null)
                        {
                            dk.NgayDi = (DateTime)ds.Tables[0].Rows[i]["NgayDi"];
                        }
                        dk.TienDat = (int)ds.Tables[0].Rows[i]["TienDat"];
                        dk.SoNguoi = (int)ds.Tables[0].Rows[i]["SoNguoi"];
                        dk.GhiChu = ds.Tables[0].Rows[i]["NgiChu"].ToString();
                        dk.PhongDK = new Phong();
                        dk.PhongDK.MaPhong = ds.Tables[0].Rows[i]["MaPhong"].ToString();
                        dk.PhongDK.TenPhong = ds.Tables[0].Rows[i]["TenPhong"].ToString();
                        dk.PhongDK.LoaiPhong = ds.Tables[0].Rows[i]["LoaiPhong"].ToString();
                        dk.PhongDK.Gia = (int)ds.Tables[0].Rows[i]["Gia"];
                        dangKys.Add(dk);
                    }
                }
            }
            return dangKys;
        }

        public DangKy DangKySelectByID(string MaDK)
        {
            DangKy dangKys = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblDangKy_SelectByID");
                cmd.Parameters.AddWithValue("@MaDK", MaDK);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dangKys = new DangKy();
                    dangKys.MaDK = ds.Tables[0].Rows[0]["MaDK"].ToString();
                    dangKys.KhachHangDK = new KhachHang();
                    dangKys.KhachHangDK.MaKhach = ds.Tables[0].Rows[0]["MaKhach"].ToString();
                    dangKys.KhachHangDK.HoDem = ds.Tables[0].Rows[0]["HoDem"].ToString();
                    dangKys.KhachHangDK.Ten = ds.Tables[0].Rows[0]["Ten"].ToString();
                    dangKys.KhachHangDK.NgaySinh = (DateTime)ds.Tables[0].Rows[0]["NgaySinh"];
                    dangKys.KhachHangDK.CMND = ds.Tables[0].Rows[0]["CMND"].ToString();
                    dangKys.KhachHangDK.QuocTich = ds.Tables[0].Rows[0]["QuocTich"].ToString();
                    dangKys.KhachHangDK.GhiChu = ds.Tables[0].Rows[0]["GhiChu"].ToString();
                    dangKys.NgayDangKy = (DateTime)ds.Tables[0].Rows[0]["NgayDangKy"];
                    dangKys.NgayDen = null;
                    dangKys.NgayDi = null;
                    if (ds.Tables[0].Rows[0]["NgayDen"] != null)
                    {
                        dangKys.NgayDen = (DateTime)ds.Tables[0].Rows[0]["NgayDen"];
                    }
                    if (ds.Tables[0].Rows[0]["NgayDi"] != null)
                    {
                        dangKys.NgayDi = (DateTime)ds.Tables[0].Rows[0]["NgayDi"];
                    }
                    dangKys.TienDat = (int)ds.Tables[0].Rows[0]["TienDat"];
                    dangKys.SoNguoi = (int)ds.Tables[0].Rows[0]["SoNguoi"];
                    dangKys.GhiChu = ds.Tables[0].Rows[0]["NgiChu"].ToString();
                    dangKys.PhongDK = new Phong();
                    dangKys.PhongDK.MaPhong = ds.Tables[0].Rows[0]["MaPhong"].ToString();
                    dangKys.PhongDK.TenPhong = ds.Tables[0].Rows[0]["TenPhong"].ToString();
                    dangKys.PhongDK.LoaiPhong = ds.Tables[0].Rows[0]["LoaiPhong"].ToString();
                    dangKys.PhongDK.Gia = (int)ds.Tables[0].Rows[0]["Gia"];
                }
            }
            return dangKys;
        }

        public bool DangKyInsert(DangKy dk)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("tblDangKy_Insert");
                command.Parameters.AddWithValue("@MaDK", dk.MaDK);
                command.Parameters.AddWithValue("@MaKhach", dk.KhachHangDK.MaKhach);
                command.Parameters.AddWithValue("@MaPhong", dk.PhongDK.MaPhong);
                command.Parameters.AddWithValue("@NgayDangKy", dk.NgayDangKy);
                command.Parameters.AddWithValue("@NgayDen", dk.NgayDen);
                command.Parameters.AddWithValue("@NgayDi", dk.NgayDi);
                command.Parameters.AddWithValue("@TienDat", dk.TienDat);
                command.Parameters.AddWithValue("@SoNguoi", dk.SoNguoi);
                command.Parameters.AddWithValue("@NgiChu", dk.GhiChu);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public bool DangKyUpdate(DangKy dk)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("tblDangKy_Update");
                command.Parameters.AddWithValue("@MaDK", dk.MaDK);
                command.Parameters.AddWithValue("@MaKhach", dk.KhachHangDK.MaKhach);
                command.Parameters.AddWithValue("@MaPhong", dk.PhongDK.MaPhong);
                command.Parameters.AddWithValue("@NgayDangKy", dk.NgayDangKy);
                command.Parameters.AddWithValue("@NgayDen", dk.NgayDen);
                command.Parameters.AddWithValue("@NgayDi", dk.NgayDi);
                command.Parameters.AddWithValue("@TienDat", dk.TienDat);
                command.Parameters.AddWithValue("@SoNguoi", dk.SoNguoi);
                command.Parameters.AddWithValue("@NgiChu", dk.GhiChu);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public bool DangKyDelete(string MaDK)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("tblDangKy_Delete");
                command.Parameters.AddWithValue("@MaDK", MaDK);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public List<SDDV> SDDVSelectAll()
        {
            List<SDDV> sddvs = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblSDDV_SelectAll");
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    sddvs = new List<SDDV>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        sddvs.Add(new SDDV
                        {
                            MaDK = ds.Tables[0].Rows[i]["MaDK"].ToString(),
                            DichVu = new DichVu()
                            {
                                MaDV = ds.Tables[0].Rows[i]["MaDV"].ToString(),
                                TenDV = ds.Tables[0].Rows[i]["TenDV"].ToString(),
                                GiaTien = int.Parse(ds.Tables[0].Rows[i]["GiaTien"].ToString())
                            },
                            NhanVien = new NhanVien()
                            {

                                MaNV = ds.Tables[0].Rows[i]["MaNV"].ToString(),
                                HoDem = ds.Tables[0].Rows[i]["HoDem"].ToString(),
                                Ten = ds.Tables[0].Rows[i]["Ten"].ToString(),
                                NgaySinh = DateTime.Parse(ds.Tables[0].Rows[i]["NgaySinh"].ToString()),
                                CMND = ds.Tables[0].Rows[i]["CMND"].ToString()

                            },
                            NgaySuDung = DateTime.Parse(ds.Tables[0].Rows[i]["NgaySuDung"].ToString()),
                            SoLuong = int.Parse(ds.Tables[0].Rows[i]["SoLuong"].ToString())

                        });
                    }
                }
            }
            return sddvs;
        }

        public List<SDDV> SDDVSelectAllByID(string MaDK)
        {
            List<SDDV> sddvs = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblSDDV_SelectAllByID");
                cmd.Parameters.AddWithValue("@MaDK", MaDK);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    sddvs = new List<SDDV>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        sddvs.Add(new SDDV
                        {
                            MaDK = ds.Tables[0].Rows[0]["MaDK"].ToString(),
                            DichVu = new DichVu()
                            {
                                MaDV = ds.Tables[0].Rows[0]["MaDV"].ToString(),
                                TenDV = ds.Tables[0].Rows[0]["TenDV"].ToString(),
                                GiaTien = int.Parse(ds.Tables[0].Rows[0]["GiaTien"].ToString())
                            },
                            NhanVien = new NhanVien()
                            {

                                MaNV = ds.Tables[0].Rows[0]["MaNV"].ToString(),
                                HoDem = ds.Tables[0].Rows[i]["HoDem"].ToString(),
                                Ten = ds.Tables[0].Rows[0]["Ten"].ToString(),
                                NgaySinh = DateTime.Parse(ds.Tables[0].Rows[0]["NgaySinh"].ToString()),
                                CMND = ds.Tables[0].Rows[0]["CMND"].ToString()

                            },
                            NgaySuDung = DateTime.Parse(ds.Tables[0].Rows[0]["NgaySuDung"].ToString()),
                            SoLuong = int.Parse(ds.Tables[0].Rows[0]["SoLuong"].ToString())
                        });
                    }
                }
            }
            return sddvs;
        }

        public List<SDDV> SDDVSelectByID(string MaDK, string MaDV)
        {
            List<SDDV> sddvs = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblSDDV_SelectByID");
                cmd.Parameters.AddWithValue("@MaDK", MaDK);
                cmd.Parameters.AddWithValue("@MaDV", MaDV);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    sddvs = new List<SDDV>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        sddvs.Add(new SDDV
                        {
                            MaDK = ds.Tables[0].Rows[0]["MaDK"].ToString(),
                            DichVu = new DichVu()
                            {
                                MaDV = ds.Tables[0].Rows[0]["MaDV"].ToString(),
                                TenDV = ds.Tables[0].Rows[0]["TenDV"].ToString(),
                                GiaTien = int.Parse(ds.Tables[0].Rows[0]["GiaTien"].ToString())
                            },
                            NhanVien = new NhanVien()
                            {

                                MaNV = ds.Tables[0].Rows[0]["MaNV"].ToString(),
                                HoDem = ds.Tables[0].Rows[i]["HoDem"].ToString(),
                                Ten = ds.Tables[0].Rows[0]["Ten"].ToString(),
                                NgaySinh = DateTime.Parse(ds.Tables[0].Rows[0]["NgaySinh"].ToString()),
                                CMND = ds.Tables[0].Rows[0]["CMND"].ToString()

                            },
                            NgaySuDung = DateTime.Parse(ds.Tables[0].Rows[0]["NgaySuDung"].ToString()),
                            SoLuong = int.Parse(ds.Tables[0].Rows[0]["SoLuong"].ToString())
                        });
                    }
                }
            }
            return sddvs;
        }

        public List<SDDV> SDDVSelectTop(string Top, string Where, string Order)
        {
            List<SDDV> sddvs = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblSDDV_SelectTop");
                cmd.Parameters.AddWithValue("@Top", Top);
                cmd.Parameters.AddWithValue("@Where", Where);
                cmd.Parameters.AddWithValue("@Order", Order);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    sddvs = new List<SDDV>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        sddvs.Add(new SDDV
                        {
                            MaDK = ds.Tables[0].Rows[0]["MaDK"].ToString(),
                            DichVu = new DichVu()
                            {
                                MaDV = ds.Tables[0].Rows[0]["MaDV"].ToString(),
                                TenDV = ds.Tables[0].Rows[0]["TenDV"].ToString(),
                                GiaTien = int.Parse(ds.Tables[0].Rows[0]["GiaTien"].ToString())
                            },
                            NhanVien = new NhanVien()
                            {

                                MaNV = ds.Tables[0].Rows[0]["MaNV"].ToString(),
                                HoDem = ds.Tables[0].Rows[0]["HoDem"].ToString(),
                                Ten = ds.Tables[0].Rows[0]["Ten"].ToString(),
                                NgaySinh = DateTime.Parse(ds.Tables[0].Rows[0]["NgaySinh"].ToString()),
                                CMND = ds.Tables[0].Rows[0]["CMND"].ToString()

                            },
                            NgaySuDung = DateTime.Parse(ds.Tables[0].Rows[0]["NgaySuDung"].ToString()),
                            SoLuong = int.Parse(ds.Tables[0].Rows[0]["SoLuong"].ToString())
                        });
                    }
                }
            }
            return sddvs;
        }


        public bool SDDVTestByID(string MaDK, string MaDV)
        {
            bool b = false;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblSDDV_TestByID");
                cmd.Parameters.AddWithValue("@MaDK", MaDK);
                cmd.Parameters.AddWithValue("@MaDV", MaDV);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    b = Convert.ToBoolean(ds.Tables[1].Rows[0]["TestID"].ToString());
                }
            }
            return b;
        }


        public bool SDDVInsert(SDDV nv)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("tblSDDV_Insert");
                command.Parameters.AddWithValue("@MaDK", nv.MaDK);
                command.Parameters.AddWithValue("@MaDV", nv.DichVu.MaDV);
                command.Parameters.AddWithValue("@MaNV", nv.NhanVien.MaNV);
                command.Parameters.AddWithValue("@NgaySD", nv.NgaySuDung);
                command.Parameters.AddWithValue("@SoLuong", nv.SoLuong);

                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }


        public bool SDDVDelete(string MaDK, string MaDV)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("tblSDDV_Delete");
                command.Parameters.AddWithValue("@MaDK", MaDK);
                command.Parameters.AddWithValue("@MaDV", MaDV);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public bool SDDVUpdate(SDDV cv)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("tblSDDV_Update");
                command.Parameters.AddWithValue("@MaDK", cv.MaDK);
                command.Parameters.AddWithValue("@MaDV", cv.DichVu.MaDV);
                command.Parameters.AddWithValue("@MaNV", cv.NhanVien.MaNV);
                command.Parameters.AddWithValue("@NgaySuDung", cv.NgaySuDung);
                command.Parameters.AddWithValue("@SoLuong", cv.SoLuong);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public List<ThanhToan> ThanhToanSelectAll()
        {
            List<ThanhToan> thanhToans = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblThanhToan_SelectAll");
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    thanhToans = new List<ThanhToan>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        thanhToans.Add(new ThanhToan
                        {
                            MaDK = ds.Tables[0].Rows[i]["MaDK"].ToString(),
                            MaPhong = ds.Tables[0].Rows[i]["MaPhong"].ToString(),
                            MaNV = ds.Tables[0].Rows[i]["MaNV"].ToString(),
                            NgayThanhToan = DateTime.Parse(ds.Tables[0].Rows[i]["NgayThanhToan"].ToString())

                        });
                    }
                }
            }
            return thanhToans;
        }

        public List<ThanhToan> ThanhToanSelectAllByID(string MaDK, string MaPhong)
        {
            List<ThanhToan> thanToans = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblThanhToan_SelectByID");
                cmd.Parameters.AddWithValue("@MaDK", MaDK);
                cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    thanToans = new List<ThanhToan>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        thanToans.Add(new ThanhToan
                        {
                            MaDK = ds.Tables[0].Rows[0]["MaDK"].ToString(),
                            MaPhong = ds.Tables[0].Rows[0]["MaPhong"].ToString(),
                            MaNV = ds.Tables[0].Rows[0]["MaNV"].ToString(),
                            NgayThanhToan = DateTime.Parse(ds.Tables[0].Rows[0]["NgayThanhToan"].ToString())
                        });
                    }
                }
            }
            return thanToans;
        }



        public List<ThanhToan> ThanhToanSelectTop(string Top, string Where, string Order)
        {
            List<ThanhToan> thanhToans = null;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblThanhToan_SelectTop");
                cmd.Parameters.AddWithValue("@Top", Top);
                cmd.Parameters.AddWithValue("@Where", Where);
                cmd.Parameters.AddWithValue("@Order", Order);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    thanhToans = new List<ThanhToan>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        thanhToans.Add(new ThanhToan
                        {
                            MaDK = ds.Tables[0].Rows[0]["MaDK"].ToString(),
                            MaPhong = ds.Tables[0].Rows[0]["MaPhong"].ToString(),
                            MaNV = ds.Tables[0].Rows[0]["MaNV"].ToString(),
                            NgayThanhToan = DateTime.Parse(ds.Tables[0].Rows[0]["NgayThanhToan"].ToString())
                        });
                    }
                }
            }
            return thanhToans;
        }

        public bool ThanhToanTestByID(string MaDK, string MaPhong)
        {
            bool b = false;
            if (IsConnect())
            {
                SqlCommand cmd = new SqlCommand("tblThanhToan_TestByID");
                cmd.Parameters.AddWithValue("@MaDK", MaDK);
                cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    b = Convert.ToBoolean(ds.Tables[1].Rows[0]["TestID"].ToString());
                }
            }
            return b;
        }


        public bool ThanhToanInsert(ThanhToan tt)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("tblThanhToan_Insert");
                command.Parameters.AddWithValue("@MaDK", tt.MaDK);
                command.Parameters.AddWithValue("@MaPhong", tt.MaPhong);
                command.Parameters.AddWithValue("@MaNV", tt.MaNV);
                command.Parameters.AddWithValue("@NgayThanhToan", tt.NgayThanhToan);

                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }


        public bool ThanhToanDelete(string MaDK, string MaPhong)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("tblThanhToan_Delete");
                command.Parameters.AddWithValue("@MaDK", MaDK);
                command.Parameters.AddWithValue("@MaPhong", MaPhong);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }

        public bool ThanhToanUpdate(ThanhToan tt)
        {
            bool isSuccess = false;
            if (IsConnect())
            {
                SqlCommand command = new SqlCommand("tblThanhToan_Update");
                command.Parameters.AddWithValue("@MaDK", tt.MaDK);
                command.Parameters.AddWithValue("@MaPhong", tt.MaPhong);
                command.Parameters.AddWithValue("@MaNV", tt.MaNV);
                command.Parameters.AddWithValue("@NgayThanhToan", tt.NgayThanhToan);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
            }
            return isSuccess;
        }
    }



    



    //public nhanvien Login(string tdn, string matkhau)
    //{
    //    nhanvien nv = null;
    //    SqlCommand cmd = new SqlCommand("Login");
    //    cmd.Connection = con;
    //    cmd.CommandType = CommandType.StoredProcedure;
    //    cmd.Parameters.AddWithValue("@tdn", tdn);
    //    cmd.Parameters.AddWithValue("@matkhau", matkhau);
    //    DataSet ds = new DataSet();
    //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
    //    adapter.Fill(ds);
    //    if (ds.Tables[0].Rows.Count > 0)
    //    {
    //        nv = new nhanvien()
    //        {
    //            manv = ds.Tables[0].Rows[0]["nv_ma"].ToString(),
    //            tdn = ds.Tables[0].Rows[0]["nv_tdn"].ToString(),
    //            matkhau = ds.Tables[0].Rows[0]["nv_matkhau"].ToString(),
    //            hoten = ds.Tables[0].Rows[0]["nv_hoten"].ToString(),
    //            ngaysinh = ds.Tables[0].Rows[0]["nv_ngaysinh"].ToString(),
    //            gioitinh = (bool)ds.Tables[0].Rows[0]["nv_gioitinh"],
    //            sdt = ds.Tables[0].Rows[0]["nv_sdt"].ToString(),
    //            cmnd = ds.Tables[0].Rows[0]["nv_cmnd"].ToString(),
    //            diachi = ds.Tables[0].Rows[0]["nv_diachi"].ToString(),
    //            email = ds.Tables[0].Rows[0]["nv_email"].ToString(),
    //            khoa = (bool)ds.Tables[0].Rows[0]["nv_khoa"],
    //            xoa = (bool)ds.Tables[0].Rows[0]["nv_xoa"],
    //            fileanh = ds.Tables[0].Rows[0]["nv_fileanh"].ToString(),
    //            chucVu = new chucvu()
    //            {
    //                macv = ds.Tables[0].Rows[0]["cv_ma"].ToString(),
    //                tencv = ds.Tables[0].Rows[0]["cv_ten"].ToString()
    //            },
    //            quyennv = new quyen()
    //            {
    //                maquyen = ds.Tables[0].Rows[0]["q_ma"].ToString(),
    //                tenquyen = ds.Tables[0].Rows[0]["q_ten"].ToString(),
    //            }
    //        };
    //    }
    //    return nv;
    //}

    //public List<nhanvien> getAllNhanviens()
    //{
    //    List<nhanvien> nhanviens = null;
    //    if (IsConnect())
    //    {
    //        SqlCommand cmd = new SqlCommand("getAllNhanviens");
    //        cmd.Connection = con;
    //        cmd.CommandType = CommandType.StoredProcedure;
    //        DataSet ds = new DataSet();
    //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
    //        adapter.Fill(ds);
    //        if (ds.Tables[0].Rows.Count > 0)
    //        {
    //            nhanviens = new List<nhanvien>();
    //            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
    //            {
    //                nhanviens.Add(new nhanvien {
    //                    manv = ds.Tables[0].Rows[i]["nv_ma"].ToString(),
    //                    tdn = ds.Tables[0].Rows[i]["nv_tdn"].ToString(),
    //                    matkhau = ds.Tables[0].Rows[i]["nv_matkhau"].ToString(),
    //                    hoten = ds.Tables[0].Rows[i]["nv_hoten"].ToString(),
    //                    ngaysinh = ds.Tables[0].Rows[i]["nv_ngaysinh"].ToString(),
    //                    gioitinh = (bool)ds.Tables[0].Rows[i]["nv_gioitinh"],
    //                    sdt = ds.Tables[0].Rows[i]["nv_sdt"].ToString(),
    //                    cmnd = ds.Tables[0].Rows[i]["nv_cmnd"].ToString(),
    //                    diachi = ds.Tables[0].Rows[i]["nv_diachi"].ToString(),
    //                    email = ds.Tables[0].Rows[i]["nv_email"].ToString(),
    //                    khoa = (bool)ds.Tables[0].Rows[i]["nv_khoa"],
    //                    xoa = (bool)ds.Tables[0].Rows[i]["nv_xoa"],
    //                    fileanh = ds.Tables[0].Rows[i]["nv_fileanh"].ToString(),
    //                    chucVu = new chucvu()
    //                    {
    //                        macv = ds.Tables[0].Rows[i]["cv_ma"].ToString(),
    //                        tencv = ds.Tables[0].Rows[i]["cv_ten"].ToString()
    //                    },
    //                    quyennv = new quyen()
    //                    {
    //                        maquyen = ds.Tables[0].Rows[i]["q_ma"].ToString(),
    //                        tenquyen = ds.Tables[0].Rows[i]["q_ten"].ToString(),
    //                    }
    //                });
    //            }
    //        }
    //    }
    //    return nhanviens;
    //}

    //public nhanvien getNhanvienByMa(string manv)
    //{
    //    nhanvien nv = null;
    //    if (IsConnect())
    //    {
    //        SqlCommand cmd = new SqlCommand("getNhanvienByMa");
    //        cmd.Parameters.AddWithValue("@manv", manv);
    //        cmd.Connection = con;
    //        cmd.CommandType = CommandType.StoredProcedure;
    //        DataSet ds = new DataSet();
    //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
    //        adapter.Fill(ds);
    //        if (ds.Tables[0].Rows.Count > 0)
    //        {
    //            nv = new nhanvien()
    //            {
    //                manv = ds.Tables[0].Rows[0]["nv_ma"].ToString(),
    //                tdn = ds.Tables[0].Rows[0]["nv_tdn"].ToString(),
    //                matkhau = ds.Tables[0].Rows[0]["nv_matkhau"].ToString(),
    //                hoten = ds.Tables[0].Rows[0]["nv_hoten"].ToString(),
    //                ngaysinh = ds.Tables[0].Rows[0]["nv_ngaysinh"].ToString(),
    //                gioitinh = (bool)ds.Tables[0].Rows[0]["nv_gioitinh"],
    //                sdt = ds.Tables[0].Rows[0]["nv_sdt"].ToString(),
    //                cmnd = ds.Tables[0].Rows[0]["nv_cmnd"].ToString(),
    //                diachi = ds.Tables[0].Rows[0]["nv_diachi"].ToString(),
    //                email = ds.Tables[0].Rows[0]["nv_email"].ToString(),
    //                khoa = (bool)ds.Tables[0].Rows[0]["nv_khoa"],
    //                xoa = (bool)ds.Tables[0].Rows[0]["nv_xoa"],
    //                fileanh = ds.Tables[0].Rows[0]["nv_fileanh"].ToString(),
    //                chucVu = new chucvu()
    //                {
    //                    macv = ds.Tables[0].Rows[0]["cv_ma"].ToString(),
    //                    tencv = ds.Tables[0].Rows[0]["cv_ten"].ToString()
    //                },
    //                quyennv = new quyen()
    //                {
    //                    maquyen = ds.Tables[0].Rows[0]["q_ma"].ToString(),
    //                    tenquyen = ds.Tables[0].Rows[0]["q_ten"].ToString(),
    //                }
    //            };
    //        }
    //    }
    //    return nv;
    //}

    //public List<nhanvien> searchNhanviens(string key)
    //{
    //    if(key == "" || key == null)
    //    {
    //        return getAllNhanviens();
    //    }
    //    List<nhanvien> nhanviens = null;
    //    if (IsConnect())
    //    {
    //        SqlCommand cmd = new SqlCommand("searchNhanviens");
    //        cmd.Parameters.AddWithValue("@key", key);
    //        cmd.Connection = con;
    //        cmd.CommandType = CommandType.StoredProcedure;
    //        DataSet ds = new DataSet();
    //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
    //        adapter.Fill(ds);
    //        if (ds.Tables[0].Rows.Count > 0)
    //        {
    //            nhanviens = new List<nhanvien>();
    //            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
    //            {
    //                nhanviens.Add(new nhanvien
    //                {
    //                    manv = ds.Tables[0].Rows[i]["nv_ma"].ToString(),
    //                    tdn = ds.Tables[0].Rows[i]["nv_tdn"].ToString(),
    //                    matkhau = ds.Tables[0].Rows[i]["nv_matkhau"].ToString(),
    //                    hoten = ds.Tables[0].Rows[i]["nv_hoten"].ToString(),
    //                    ngaysinh = ds.Tables[0].Rows[i]["nv_ngaysinh"].ToString(),
    //                    gioitinh = (bool)ds.Tables[0].Rows[i]["nv_gioitinh"],
    //                    sdt = ds.Tables[0].Rows[i]["nv_sdt"].ToString(),
    //                    cmnd = ds.Tables[0].Rows[i]["nv_cmnd"].ToString(),
    //                    diachi = ds.Tables[0].Rows[i]["nv_diachi"].ToString(),
    //                    email = ds.Tables[0].Rows[i]["nv_email"].ToString(),
    //                    khoa = (bool)ds.Tables[0].Rows[i]["nv_khoa"],
    //                    xoa = (bool)ds.Tables[0].Rows[i]["nv_xoa"],
    //                    fileanh = ds.Tables[0].Rows[i]["nv_fileanh"].ToString(),
    //                    chucVu = new chucvu()
    //                    {
    //                        macv = ds.Tables[0].Rows[i]["cv_ma"].ToString(),
    //                        tencv = ds.Tables[0].Rows[i]["cv_ten"].ToString()
    //                    },
    //                    quyennv = new quyen()
    //                    {
    //                        maquyen = ds.Tables[0].Rows[i]["q_ma"].ToString(),
    //                        tenquyen = ds.Tables[0].Rows[i]["q_ten"].ToString(),
    //                    }
    //                });
    //            }
    //        }
    //    }
    //    return nhanviens;
    //}

    //public bool insertNhanvien(nhanvien nv)
    //{
    //    bool isSuccess = false;
    //    if (IsConnect())
    //    {
    //        SqlCommand command = new SqlCommand("insertNhanvien");
    //        command.Parameters.AddWithValue("@nv_ma", nv.manv);
    //        command.Parameters.AddWithValue("@nv_macv", nv.chucVu.macv);
    //        command.Parameters.AddWithValue("@nv_hoten", nv.hoten);
    //        command.Parameters.AddWithValue("@nv_ngaysinh", nv.ngaysinh);
    //        command.Parameters.AddWithValue("@nv_gioitinh", nv.gioitinh);
    //        command.Parameters.AddWithValue("@nv_sdt", nv.sdt);
    //        command.Parameters.AddWithValue("@nv_cmnd", nv.cmnd);
    //        command.Parameters.AddWithValue("@nv_diachi", nv.diachi);
    //        command.Parameters.AddWithValue("@nv_email", nv.email);
    //        command.Parameters.AddWithValue("@nv_khoa", false);
    //        command.Parameters.AddWithValue("@nv_xoa", false);
    //        command.Parameters.AddWithValue("@nv_tdn", nv.tdn);
    //        command.Parameters.AddWithValue("@nv_matkhau", nv.matkhau);
    //        command.Parameters.AddWithValue("@nv_maquyen", nv.quyennv.maquyen);
    //        command.Parameters.AddWithValue("@nv_fileanh", nv.fileanh);
    //        command.CommandType = CommandType.StoredProcedure;
    //        command.Connection = con;
    //        isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
    //    }
    //    return isSuccess;
    //}

    //public bool updateNhanvien(nhanvien nv)
    //{
    //    bool isSuccess = false;
    //    if (IsConnect())
    //    {
    //        SqlCommand command = new SqlCommand("updateNhanVien");
    //        command.Parameters.AddWithValue("@nv_ma", nv.manv);
    //        command.Parameters.AddWithValue("@nv_macv", nv.chucVu.macv);
    //        command.Parameters.AddWithValue("@nv_hoten", nv.hoten);
    //        command.Parameters.AddWithValue("@nv_ngaysinh", nv.ngaysinh);
    //        command.Parameters.AddWithValue("@nv_gioitinh", nv.gioitinh);
    //        command.Parameters.AddWithValue("@nv_sdt", nv.sdt);
    //        command.Parameters.AddWithValue("@nv_cmnd", nv.cmnd);
    //        command.Parameters.AddWithValue("@nv_diachi", nv.diachi);
    //        command.Parameters.AddWithValue("@nv_email", nv.email);
    //        command.Parameters.AddWithValue("@nv_khoa", nv.khoa);
    //        command.Parameters.AddWithValue("@nv_xoa", nv.xoa);
    //        command.Parameters.AddWithValue("@nv_tdn", nv.tdn);
    //        command.Parameters.AddWithValue("@nv_matkhau", nv.matkhau);
    //        command.Parameters.AddWithValue("@nv_maquyen", nv.quyennv.maquyen);
    //        command.Parameters.AddWithValue("@nv_fileanh", nv.fileanh);
    //        command.CommandType = CommandType.StoredProcedure;
    //        command.Connection = con;
    //        isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
    //    }
    //    return isSuccess;
    //}

    //public bool deleteNhanvien(string manv)
    //{
    //    bool isSuccess = false;
    //    if (IsConnect())
    //    {
    //        SqlCommand command = new SqlCommand("deleteNhanvien");
    //        command.Parameters.AddWithValue("@nv_ma", manv);
    //        command.CommandType = CommandType.StoredProcedure;
    //        command.Connection = con;
    //        isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
    //    }
    //    return isSuccess;
    //}

    //public bool changePassword(nhanvien nv, string matkhaumoi)
    //{
    //    bool isSuccess = false;
    //    if (IsConnect())
    //    {
    //        SqlCommand command = new SqlCommand("changePassword");
    //        command.Parameters.AddWithValue("@nv_tdn", nv.tdn);
    //        command.Parameters.AddWithValue("@nv_matkhau", nv.matkhau);
    //        command.Parameters.AddWithValue("@matkhaumoi", matkhaumoi);
    //        command.CommandType = CommandType.StoredProcedure;
    //        command.Connection = con;
    //        isSuccess = command.ExecuteNonQuery() > 0 ? true : false;
    //    }
    //    return isSuccess;
    //}


}