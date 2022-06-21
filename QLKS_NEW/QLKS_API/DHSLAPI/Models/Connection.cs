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
}