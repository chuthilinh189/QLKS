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
    public partial class FrmQLPhong : DevExpress.XtraEditors.XtraForm
    {
        public FrmQLPhong()
        {
            InitializeComponent();

        }

        private void FrmPhong_Load(object sender, EventArgs e)
        {
            loadGridView();
            Bindding();
        }

        private void Bindding() 
        {
            teMaPhong.DataBindings.Clear();
            teMaPhong.DataBindings.Add("Text", dgvPhong.DataSource, "MaPhong");
            teTenPhong.DataBindings.Clear();
            teTenPhong.DataBindings.Add("Text", dgvPhong.DataSource, "TenPhong");
            teLoaiPhong.DataBindings.Clear();
            teLoaiPhong.DataBindings.Add("Text", dgvPhong.DataSource, "LoaiPhong");
            teGia.DataBindings.Clear();
            teGia.DataBindings.Add("Text", dgvPhong.DataSource, "Gia");
        }

        private void loadGridView() 
        {
            this.tblPhongTableAdapter.Fill(this.quanLyKhachSanDataSet.tblPhong);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            EtblPhong phong = new EtblPhong(teMaPhong.Text.ToString().Trim(),teTenPhong.Text.ToString().Trim(),teLoaiPhong.Text.ToString().Trim(),Int32.Parse(teGia.Text.ToString().Trim()));
            BtblPhong.Insert(phong);
            loadGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            EtblPhong phong = new EtblPhong(teMaPhong.Text.ToString().Trim(), teTenPhong.Text.ToString().Trim(), teLoaiPhong.Text.ToString().Trim(), Int32.Parse(teGia.Text.ToString().Trim()));
            BtblPhong.Update(phong);
            loadGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String tblMaPhong = teMaPhong.Text.ToString();
            BtblPhong.Delete(tblMaPhong);
            loadGridView();
        }
    }
}