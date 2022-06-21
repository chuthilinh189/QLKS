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
    public partial class FrmQLChucVu : DevExpress.XtraEditors.XtraForm
    {
        public FrmQLChucVu()
        {
            InitializeComponent();
        }

        private void FrmQLChucVu_Load(object sender, EventArgs e)
        {
            load_GridView();
            Bindding();

        }

        private void Bindding() 
        {
            teMaCV.DataBindings.Clear();
            teMaCV.DataBindings.Add("Text",dgvChucVu.DataSource,"MaCV");
            teTenDonVi.DataBindings.Clear();
            teTenDonVi.DataBindings.Add("Text", dgvChucVu.DataSource, "TenDonVi");
            teChucVu.DataBindings.Clear();
            teChucVu.DataBindings.Add("Text", dgvChucVu.DataSource, "ChucVu");
            teKhu.DataBindings.Clear();
            teKhu.DataBindings.Add("Text", dgvChucVu.DataSource, "Khu");
           
        }

        private void load_GridView() 
        {
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.tblChucVu' table. You can move, or remove it, as needed.
            this.tblChucVuTableAdapter.Fill(this.quanLyKhachSanDataSet.tblChucVu);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String maCV = teMaCV.Text.ToString().Trim();
            int khu = int.Parse(teKhu.Text.ToString());
            String tenDonVi = teTenDonVi.Text.ToString().Trim();
            String chucVu = teChucVu.Text.ToString().Trim();
            EtblChucVu chucvu = new EtblChucVu(maCV,khu,tenDonVi,chucVu);
            BtblChucVu.Insert(chucvu);
            load_GridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            String maCV = teMaCV.Text.ToString().Trim();
            int khu = int.Parse(teKhu.Text.ToString());
            String tenDonVi = teTenDonVi.Text.ToString().Trim();
            String chucVu = teChucVu.Text.ToString().Trim();
            EtblChucVu chucvu = new EtblChucVu(maCV, khu, tenDonVi, chucVu);
            BtblChucVu.Update(chucvu);
            load_GridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String maCV = teMaCV.Text.ToString().Trim();
            BtblChucVu.Delete(maCV);
            load_GridView();
        }
    }
}