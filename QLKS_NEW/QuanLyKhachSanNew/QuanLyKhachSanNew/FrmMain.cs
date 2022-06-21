using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraTabbedMdi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyKhachSanNew
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmLogin login;

        public FrmMain()
        {

            SplashScreenManager.ShowForm(this,typeof(FrmChild.FrmWaitForm),true,true,false);
            SplashScreenManager.Default.SetWaitFormCaption("Jundat95");
            for (int i = 0; i < 100; i++) 
            {
                Thread.Sleep(100);
            }
            SplashScreenManager.CloseForm();
            
            InitializeComponent();
           
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            loadFullScreen();
            login = new FrmLogin();
            login.ShowDialog();
            Login();
        }
        /// <summary>
        /// Load lại pgg khi login lại lần hai
        /// </summary>
        private void Load_Login() 
        {
            pgBaoCao.Visible = true;
            pgGiaoDich.Visible = true;
            pgQuanLy.Visible = true;
            pggBaoCao.Visible = true;
            pggDangKyPhong.Visible = true;
            pggTraPhong.Visible = true;
            pggQuanLyDichVu.Visible = true;
            pggQuanLyKhach.Visible = true;
            pggQuanLyNhanVien.Visible = true;
            pggQuanLyPhong.Visible = true;
            
        }

        //Load Su kien Login
        private void Login() 
        {
           
            nbiTenNV.Caption = "Họ Tên : " + login.nhanVien.HoDem + " " + login.nhanVien.Ten;
            nbiNgaySinh.Caption = "Năm Sinh : " + login.nhanVien.NgaySinh.Year;
            nbiChucVu.Caption = "Chức Vụ : " + login.chucVu.ChucVu;
            nbiDonVi.Caption = "Phòng : " + login.chucVu.TenDonVi;

            //Load lại Page Nvarbar
            Load_Login();

            if (login.chucVu.Khu == 1) 
            {
                nbiQuyenXem.Caption = "Quyền Xem: Amdin";
                nbiQuyenSua.Caption = "Quyền Sửa: Admin";
            }
            if (login.chucVu.Khu == 2) 
            {
                nbiQuyenXem.Caption = "Quyền Xem: Admin";
                nbiQuyenSua.Caption = "Quyền Sửa: Nhân Viên";
                //Các chức năng bị khóa
                pgGiaoDich.Visible = false;
                pggQuanLyPhong.Visible = false;
                pggQuanLyDichVu.Visible = false;
                pggQuanLyKhach.Visible = false;
            }
            if (login.chucVu.Khu == 3) 
            {
                nbiQuyenXem.Caption = "Quyền Xem: Admin";
                nbiQuyenSua.Caption = "Quyền Sửa: Đăng Ký Phòng";
                //Các chức năng bị khóa
                pgQuanLy.Visible = false;
            }
            if (login.chucVu.Khu == 4) 
            {
                nbiQuyenXem.Caption = "Quyền Xem: Admin";
                nbiQuyenSua.Caption = "Quyền Sửa: SDDV";
                //Các chức năng bị khóa
                pgGiaoDich.Visible = false;
                pggQuanLyKhach.Visible = false;
                pggQuanLyPhong.Visible = false;
                pggQuanLyNhanVien.Visible = false;
                pggChucVu.Visible = false;
                

            }
            if (login.chucVu.Khu == 5) 
            {
                nbiQuyenXem.Caption = "Quyền Xem: Nhân Viên";
                nbiQuyenSua.Caption = "Quyền Sửa: Không";
                //Các chức năng bị khóa
                pgQuanLy.Visible = false;
                pgBaoCao.Visible = false;
            }
            
        }

        // Su kien mo form
        private void OpenForm<T>()
        {
            //SMWaitForm.ShowWaitForm();
            var f = this.MdiChildren.FirstOrDefault(i => i is T);
            if (f == null)
            {
                f = Activator.CreateInstance<T>() as Form;
                f.MdiParent = this;
                f.Show();
            }
            else f.Activate();
            //SMWaitForm.CloseWaitForm();
        }

        // Su kien load Full screen 
        private void loadFullScreen() 
        {
            //FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            //TopMost = true;
        }

        // Su kien bam vao ban phim
        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                //FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                //TopMost = true;

            }
        }

        private void btnDangKyPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<FrmChild.FrmDangKy>();
        }

        private void btnQuanLyPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<FrmChild.FrmQLPhong>();
        }

        private void btnQuanLyKhach_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<FrmChild.FrmQLKhachHang>();
        }

        private void btnQuanLyNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<FrmChild.FrmQLNhanVien>();
        }

        private void btnQuanLyChucVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<FrmChild.FrmQLChucVu>();
        }

        private void btnQuanLyDichVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<FrmChild.FrmQLDichVu>();
        }

        private void rbcMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<FrmChild.FrmNhanPhong>();
        }

        private void btnDichVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<FrmChild.FrmThemDichVu>();
        }

        private void btnTraPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<FrmChild.FrmTraPhong>();
        }

        private void btnTimPhongTrong_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<FrmChild.Search.FrmPhongSearch>();
        }

        private void btnTimKiemKhach_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<FrmChild.Search.FrmPhongSearch>();
        }

        private void btnDanhSachPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<FrmChild.Report.FrmPhongReport>();
        }

        private void btnDanhSachKhach_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<FrmChild.Report.FrmKhachReport>();
        }

        private void btnDanhSachDichVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<FrmChild.Report.FrmDichVuReport>();
        }

        private void btnDanhSachNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<FrmChild.Report.FrmNhanVienReport>();
        }

        private void btnPhongChart_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<FrmChild.Charts.FrmPhongChart>();
        }

        private void btnBaoCaoDV_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<FrmChild.Charts.FrmDichVuChart>();
        }

        private void btnBaoCaoDK_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<FrmChild.Charts.FrmDangkyChart>();
        }

        private void btnBaoCaoSDDV_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<FrmChild.Charts.FrmSDDVChart>();
        }

        private void btnThongTin_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmChild.FrmThongTinPM thongtinPM = new FrmChild.FrmThongTinPM();
            thongtinPM.ShowDialog();
        }

        private void btnTrangThaiPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<FrmChild.FrmTrangThaiPhong>();
        }

        // Su kien click vao thoat
        private void nbiOff_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            login.ShowDialog();
            Login();
        }

        private void nbiDoiMK_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmChild.FrmDoiMK dMK = new FrmChild.FrmDoiMK(login.nhanVien.MaNV);
            dMK.ShowDialog();
        }

       

       
    }
}
