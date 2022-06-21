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
using DevExpress.XtraCharts;
using AppCode.Business;
using AppCode.Entities;
namespace QuanLyKhachSanNew.FrmChild.Charts
{
    public partial class FrmDangkyChart : DevExpress.XtraEditors.XtraForm
    {
        public FrmDangkyChart()
        {
            InitializeComponent();
        }

        private void FrmDangkyChart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.tblDangKy' table. You can move, or remove it, as needed.
            this.tblDangKyTableAdapter.Fill(this.quanLyKhachSanDataSet.tblDangKy);
            //DataTable tblDangKy = new DataTable();
            //tblDangKy = BtblDangKy.SelectAll();
            //chartControl1.DataSource = tblDangKy;
        }
    }
}