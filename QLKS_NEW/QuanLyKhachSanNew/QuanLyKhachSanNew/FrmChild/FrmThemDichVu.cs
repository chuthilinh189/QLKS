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
    public partial class FrmThemDichVu : DevExpress.XtraEditors.XtraForm
    {
        public FrmThemDichVu()
        {
            InitializeComponent();
        }

        private void FrmThemDichVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.tblNhanVien' table. You can move, or remove it, as needed.
            this.tblNhanVienTableAdapter.Fill(this.quanLyKhachSanDataSet.tblNhanVien);
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.tblDichVu' table. You can move, or remove it, as needed.
            this.tblDichVuTableAdapter.Fill(this.quanLyKhachSanDataSet.tblDichVu);
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.tblDangKy' table. You can move, or remove it, as needed.
            this.tblDangKyTableAdapter.Fill(this.quanLyKhachSanDataSet.tblDangKy);

        }

        private void lueMaDV_EditValueChanged(object sender, EventArgs e)
        {
            EtblDichVu dv = new EtblDichVu();
            dv = BtblDichVu.SelectByID(lueMaDV.Text.ToString());
            lueTenDichVu.Text = dv.TenDV.ToString();
        }

        private void btnDangKy_CheckedChanged(object sender, EventArgs e)
        {
            String maDK = lueMaDK.Text.ToString();
            String maDV = lueMaDV.Text.ToString();
            int soLuong = Int32.Parse(teSoLuong.Text.ToString());
            String maNV = lueMaNV.Text.ToString();
            DateTime ngaySD = dtpNgaySD.DateTime;

            EtblSDDV sddv = new EtblSDDV(maDK, maDV, maNV, ngaySD, soLuong);
            BtblSDDV.Insert(sddv);
            MessageBox.Show("Thêm Dịch Vụ Thành Công.");
        }
    }
}