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

namespace QuanLyKhachSanNew.FrmChild.Search
{
    public partial class FrmKhachSearch : DevExpress.XtraEditors.XtraForm
    {
        public FrmKhachSearch()
        {
            InitializeComponent();
        }

        private void FrmKhachSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.tblKhachHang' table. You can move, or remove it, as needed.
            this.tblKhachHangTableAdapter.Fill(this.quanLyKhachSanDataSet.tblKhachHang);

        }
    }
}