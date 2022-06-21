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

namespace QuanLyKhachSanNew
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public EtblNhanVien nhanVien;
        public EtblChucVu chucVu;
 

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String maNV = teMaNV.Text.ToString().Trim();
            String matKhau = Event.ConvertType.GetMD5(teMatKhau.Text.ToString().Trim());
            nhanVien = new EtblNhanVien();
            chucVu = new EtblChucVu();

            if (BtblNhanVien.SelectAllByID(maNV).Count > 0)
            {
                nhanVien = BtblNhanVien.SelectByID(maNV);

                if (nhanVien.MatKhau == matKhau)
                {
                    chucVu = BtblChucVu.SelectByID(nhanVien.MaCV);
                    Hide();
                    String strThanhCong = "Đăng nhập thành công";
                    
                   
                }
                else 
                {
                    lblCaption.Text = "Mật khẩu sai";
                }
            }
            else 
            {
                lblCaption.Text = "Tên Nhân Viên Sai";
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lblCaption.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                btnLogin.PerformClick();
            }
        }
    }
}