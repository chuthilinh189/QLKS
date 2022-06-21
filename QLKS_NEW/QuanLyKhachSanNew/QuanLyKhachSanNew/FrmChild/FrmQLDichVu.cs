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
    public partial class FrmQLDichVu : DevExpress.XtraEditors.XtraForm
    {
        public FrmQLDichVu()
        {
            InitializeComponent();
        }

        private void FrmQLDichVu_Load(object sender, EventArgs e)
        {
            load_GridView();
            Bindding();
        }

        private void Bindding() 
        {
            teMaDV.DataBindings.Clear();
            teMaDV.DataBindings.Add("Text", dgvDichVu.DataSource, "MaDV");
            teTenDV.DataBindings.Clear();
            teTenDV.DataBindings.Add("Text", dgvDichVu.DataSource, "TenDV");
            teGiaTien.DataBindings.Clear();
            teGiaTien.DataBindings.Add("Text", dgvDichVu.DataSource, "GiaTien");
        }

        private void load_GridView() 
        {
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.tblDichVu' table. You can move, or remove it, as needed.
            this.tblDichVuTableAdapter.Fill(this.quanLyKhachSanDataSet.tblDichVu);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String maDV = teMaDV.Text.ToString().Trim();
            String tenDv = teTenDV.Text.ToString().Trim();
            int giaTien = int.Parse(teGiaTien.Text.ToString());
            EtblDichVu dichvu = new EtblDichVu(maDV,tenDv,giaTien);
            BtblDichVu.Insert(dichvu);
            load_GridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String maDV = teMaDV.Text.ToString().Trim();
            String tenDv = teTenDV.Text.ToString().Trim();
            int giaTien = int.Parse(teGiaTien.Text.ToString());
            EtblDichVu dichvu = new EtblDichVu(maDV, tenDv, giaTien);
            BtblDichVu.Update(dichvu);
            load_GridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String maDV = teMaDV.Text.ToString().Trim();
            BtblDichVu.Delete(maDV);
            load_GridView();
        }
    }
}