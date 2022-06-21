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
    public partial class FrmPhongSearch : DevExpress.XtraEditors.XtraForm
    {
        public FrmPhongSearch()
        {
            InitializeComponent();
        }

        private void FrmPhongSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.tblPhong' table. You can move, or remove it, as needed.
            this.tblPhongTableAdapter.Fill(this.quanLyKhachSanDataSet.tblPhong);

        }
    }
}