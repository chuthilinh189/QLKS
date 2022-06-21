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
    public partial class FrmDoiMK : DevExpress.XtraEditors.XtraForm
    {
        public String maNV;

        public FrmDoiMK()
        {
            InitializeComponent();
        }
        public FrmDoiMK(String _maNV)
        {
            InitializeComponent();
            maNV = _maNV;
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            
            String mkCu = Event.ConvertType.GetMD5(teMKCu.Text.ToString().Trim());
            EtblNhanVien nhanvien = new EtblNhanVien();
            nhanvien = BtblNhanVien.SelectByID(maNV);

            if (nhanvien.MatKhau == mkCu)
            {
                if (teMKMoi.Text.ToString().Trim() == teMKMoiLai.Text.ToString().Trim())
                {
                    if (teMKMoi.Text.ToString() != "")
                    {
                        nhanvien.MatKhau = Event.ConvertType.GetMD5(teMKMoi.Text.ToString().Trim());
                        BtblNhanVien.Update(nhanvien);
                        lblCaption.Text = "Thay đổi mật khẩu thành công";
                    }
                    else
                    {
                        lblCaption.Text = "Mật khẩu không được để trống";
                    }
                }
                else 
                {
                    lblCaption.Text = "Mật khẩu mới vừa nhập vào không khớp";
                }
            }
            else 
            {
                lblCaption.Text = "Mật khẩu cũ nhập vào không đúng";
            }
        }

        private void btnCane_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void FrmDoiMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDoiMK.PerformClick();
            }
        }
    }
}