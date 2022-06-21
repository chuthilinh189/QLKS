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
    public partial class FrmQLKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public FrmQLKhachHang()
        {
            InitializeComponent();
        }

        private void FrmQLKhachHang_Load(object sender, EventArgs e)
        {
            Bindding();
            loadGridView();
        }

        private void Bindding() 
        {
            teMaKhach.DataBindings.Clear();
            teMaKhach.DataBindings.Add("Text", dgvKhachHang.DataSource, "MaKhach");
            teHoDem.DataBindings.Clear();
            teHoDem.DataBindings.Add("Text", dgvKhachHang.DataSource, "HoDem");
            teTen.DataBindings.Clear();
            teTen.DataBindings.Add("Text", dgvKhachHang.DataSource, "Ten");
            deNgaySinh.DataBindings.Clear();
            deNgaySinh.DataBindings.Add("Text", dgvKhachHang.DataSource, "NgaySinh");
            teCMND.DataBindings.Clear();
            teCMND.DataBindings.Add("Text", dgvKhachHang.DataSource, "CMND");
            teQuocTich.DataBindings.Clear();
            teQuocTich.DataBindings.Add("Text", dgvKhachHang.DataSource, "QuocTich");
            teNghiChu.DataBindings.Clear();
            teNghiChu.DataBindings.Add("Text", dgvKhachHang.DataSource, "NghiChu");
        }

        private void loadGridView() 
        {
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.tblKhachHang' table. You can move, or remove it, as needed.
            this.tblKhachHangTableAdapter.Fill(this.quanLyKhachSanDataSet.tblKhachHang);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            String maKhach = teMaKhach.Text.ToString().Trim();
            String hodem = teHoDem.Text.ToString().Trim();
            String ten = teTen.Text.ToString().Trim();
            DateTime ngaySinh = deNgaySinh.DateTime;
            String cmnd = teCMND.Text.ToString();
            String quocTich = teQuocTich.Text.ToString().Trim();
            String nghichu = teNghiChu.Text.ToString();
            EtblKhachHang khach = new EtblKhachHang(maKhach, hodem, ten, ngaySinh, cmnd, quocTich, nghichu);
            BtblKhachHang.Insert(khach);
            loadGridView();

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            String maKhach = teMaKhach.Text.ToString().Trim();
            String hodem = teHoDem.Text.ToString().Trim();
            String ten = teTen.Text.ToString().Trim();
            DateTime ngaySinh = deNgaySinh.DateTime;
            String cmnd = teCMND.Text.ToString();
            String quocTich = teQuocTich.Text.ToString().Trim();
            String nghichu = teNghiChu.Text.ToString();
            EtblKhachHang khach = new EtblKhachHang(maKhach, hodem, ten, ngaySinh, cmnd, quocTich, nghichu);
            BtblKhachHang.Update(khach);
            loadGridView();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            String maKhach = teMaKhach.Text.ToString().Trim();
            BtblKhachHang.Delete(maKhach);
            loadGridView();
        }

      
       
       
    }
}