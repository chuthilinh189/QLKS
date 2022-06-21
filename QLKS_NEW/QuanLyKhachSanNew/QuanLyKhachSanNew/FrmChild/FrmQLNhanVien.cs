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
using AppCode.Entities;
using AppCode.Business;

namespace QuanLyKhachSanNew.FrmChild
{
    public partial class FrmQLNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public FrmQLNhanVien()
        {
            InitializeComponent();
        }

        private void FrmQLNhanVien_Load(object sender, EventArgs e)
        {
            load_GridView();
            Bindding();
           
        }

        /// <summary>
        /// Load lai vao textbox
        /// </summary>
        private void Bindding() 
        {
            teMaNV.DataBindings.Clear();
            teMaNV.DataBindings.Add("Text",dgvNhanVien.DataSource,"MaNV");
            teHoDem.DataBindings.Clear();
            teHoDem.DataBindings.Add("Text", dgvNhanVien.DataSource, "HoDem");
            teTen.DataBindings.Clear();
            teTen.DataBindings.Add("Text", dgvNhanVien.DataSource, "Ten");
            teNghiChu.DataBindings.Clear();
            teNghiChu.DataBindings.Add("Text", dgvNhanVien.DataSource, "NghiChu");
            teCMND.DataBindings.Clear();
            teCMND.DataBindings.Add("Text", dgvNhanVien.DataSource, "CMND");
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dgvNhanVien.DataSource, "NgaySinh");
            
        }

        private void load_lueMaCV() 
        {
            
        }

        private void load_GridView() 
        {
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.tblChucVu' table. You can move, or remove it, as needed.
            this.tblChucVuTableAdapter.Fill(this.quanLyKhachSanDataSet.tblChucVu);
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.tblNhanVien' table. You can move, or remove it, as needed.
            this.tblNhanVienTableAdapter.Fill(this.quanLyKhachSanDataSet.tblNhanVien);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String maNV = teMaNV.Text.ToString().Trim();
            String matKhau = Event.ConvertType.GetMD5(teMatKhau.Text.ToString().Trim());
            String maCV = lueMaCV.Text.ToString().Trim();
            String hoDem = teHoDem.Text.ToString().Trim();
            String ten = teTen.Text.ToString().Trim();
            DateTime dateTime = dtpNgaySinh.DateTime;
            String cmnd = teCMND.Text.ToString().Trim();
            String nghiChu = teNghiChu.Text.ToString().Trim();

            EtblNhanVien nhanvien = new EtblNhanVien(maNV,matKhau,maCV,hoDem,ten,dateTime,cmnd,nghiChu);
            BtblNhanVien.Insert(nhanvien);
            load_GridView();
        }

        private void tblSua_Click(object sender, EventArgs e)
        {
            String maNV = teMaNV.Text.ToString().Trim();
            String matKhau = Event.ConvertType.GetMD5(teMatKhau.Text.ToString().Trim());
            String maCV = lueMaCV.Text.ToString().Trim();
            String hoDem = teHoDem.Text.ToString().Trim();
            String ten = teTen.Text.ToString().Trim();
            DateTime dateTime = dtpNgaySinh.DateTime;
            String cmnd = teCMND.Text.ToString().Trim();
            String nghiChu = teNghiChu.Text.ToString().Trim();

            EtblNhanVien nhanvien = new EtblNhanVien(maNV, matKhau, maCV, hoDem, ten, dateTime, cmnd, nghiChu);
            BtblNhanVien.Update(nhanvien);
            load_GridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String maNV = teMaNV.Text.ToString().Trim();
            BtblNhanVien.Delete(maNV);
            load_GridView();
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {

        }

        
    }
}