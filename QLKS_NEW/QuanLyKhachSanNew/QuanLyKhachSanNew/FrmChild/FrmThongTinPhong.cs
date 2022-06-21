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
    public partial class FrmThongTinPhong : DevExpress.XtraEditors.XtraForm
    {
        private String maP;

        public FrmThongTinPhong()
        {
            InitializeComponent();
        }

        public FrmThongTinPhong(String _maP)
        {
            InitializeComponent();
            this.maP = _maP;

        }

        private void FrmThongTinPhong_Load(object sender, EventArgs e)
        {
            EtblPhong phong = new EtblPhong();
            phong = BtblPhong.SelectByID(maP);
            lblMaPhong.Text = "Mã Phòng: " + phong.MaPhong;
            lblTenPhong.Text = "Tên Phòng: " + phong.TenPhong;
            lblLoaiPhong.Text ="Loại Phòng: " + phong.LoaiPhong;

        }

        private void btnCane_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            FrmChild.FrmDangKy dangky = new FrmDangKy();
            dangky.ShowDialog();
        }
    }
}