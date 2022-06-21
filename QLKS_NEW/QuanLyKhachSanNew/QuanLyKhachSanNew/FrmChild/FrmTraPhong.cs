using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AppCode.Business;
using AppCode.Entities;

namespace QuanLyKhachSanNew.FrmChild
{
    public partial class FrmTraPhong : DevExpress.XtraEditors.XtraForm
    {
        private EtblDangKy dangky;
        private EtblPhong phong;
        private List<EtblDichVu> listDV;
        private List<EtblSDDV> listSDDV;
        private int tongTien;

        public FrmTraPhong()
        {
            InitializeComponent();
        }

        private void FrmTraPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.tblSDDV' table. You can move, or remove it, as needed.
            this.tblSDDVTableAdapter.Fill(this.quanLyKhachSanDataSet.tblSDDV);
            load_GridView();
        }
        /// <summary>
        /// Load thông tin từ dataset vào View
        /// </summary>
        private void load_GridView() 
        {

            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.tblDichVu' table. You can move, or remove it, as needed.
            this.tblDichVuTableAdapter.Fill(this.quanLyKhachSanDataSet.tblDichVu);
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.tblPhong' table. You can move, or remove it, as needed.
            this.tblPhongTableAdapter.Fill(this.quanLyKhachSanDataSet.tblPhong);
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.tblDangKy' table. You can move, or remove it, as needed.
            this.tblDangKyTableAdapter.Fill(this.quanLyKhachSanDataSet.tblDangKy);
            

        }

        private void lueMaDK_EditValueChanged(object sender, EventArgs e)
        {
            dangky = new EtblDangKy();
            dangky = BtblDangKy.SelectByID(lueMaDK.Text.ToString());
            EtblKhachHang khach = new EtblKhachHang();
            khach = BtblKhachHang.SelectByID(dangky.MaKhach);

            lueTenKhach.Text = khach.HoDem + " " + khach.Ten;
            lueCMND.Text = khach.CMND;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            CapNhatTTDK();
            ThongTinPhieuDK();
            ThongTinPhong();
            ThongTinDichVu();
            TongTienTra();
        }

        /// <summary>
        /// Tính tổng số tiền phải trả
        /// </summary>
        private void TongTienTra() 
        {
          
            int ngaySD = -dangky.NgayDen.Value.DayOfYear + dangky.NgayDi.Value.DayOfYear;
            tongTien = phong.Gia - dangky.TienDat + TienDichVu();
            lueTongTienTra.Text = tongTien.ToString() + " VND";
        }
        /// <summary>
        /// Tiền dịch vụ
        /// </summary>
        /// <returns> Trả về kiểu int</returns>
        private int TienDichVu()
        {
            int tien = 0;
            int i = 0;
            foreach (EtblDichVu dv in listDV) 
            {
                tien += dv.GiaTien *listSDDV[i].SoLuong ;
                i++;
            }

            return tien;
        }

        /// <summary>
        /// Cập nhật thông tin sau khi thanh toán
        /// </summary>
        private void CapNhatTTDK() 
        {
            dangky.NgayDi = dtpNgayDi.DateTime;
            BtblDangKy.Update(dangky);
            MessageBox.Show("Thanh toán thành công.");
        }

        /// <summary>
        /// Load thông tin của phiếu đăng ký
        /// </summary>
        private void ThongTinPhieuDK() 
        {
            // Load phiểu đăng ký vào datatable
            List<EtblDangKy> listDangKy = new List<EtblDangKy>();
            listDangKy.Add(dangky);
            DataTable tblDangKy = Event.ConvertType.ListToDataTable<EtblDangKy>(listDangKy);
            dgvThongTinChiTiet.DataSource = tblDangKy;
        }
        /// <summary>
        /// Load thông tin của phòng đã thuê
        /// </summary>
        private void ThongTinPhong() 
        {
            // Load phòng vào DataTable 
            phong = new EtblPhong();
            phong = BtblPhong.SelectByID(dangky.MaPhong);
            List<EtblPhong> listPhong = new List<EtblPhong>();
            listPhong.Add(phong);
            DataTable tblPhong = Event.ConvertType.ListToDataTable<EtblPhong>(listPhong);
            dgvThongTinP.DataSource = tblPhong;
        }
        /// <summary>
        /// Thông tin dịch vụ của phiếu đăng ký
        /// </summary>
        private void ThongTinDichVu() 
        {
           
            listSDDV = new List<EtblSDDV>();
            listDV = new List<EtblDichVu>();
            listSDDV = BtblSDDV.SelectAllByID(dangky.MaDK);
            // Load vào list dịch vụ
            foreach (EtblSDDV sddv in listSDDV) 
            {
                EtblDichVu dv = new EtblDichVu();
                dv = BtblDichVu.SelectByID(sddv.MaDV);
                listDV.Add(dv);
            }
            // Chuyển từ list sang DataTable
            DataTable tblDV = Event.ConvertType.ListToDataTable<EtblDichVu>(listDV);
            DataTable tblSDDV = Event.ConvertType.ListToDataTable<EtblSDDV>(listSDDV);

            //Load table vào datagridview
            dgvThongTinDV.DataSource = tblDV;
            dgvSDDV.DataSource = tblSDDV;
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int tienDu = -tongTien + int.Parse(teTienTra.Text.ToString().Trim());
            teTienDu.Text = tienDu.ToString() + " VND" ;
        }

       
    }
}