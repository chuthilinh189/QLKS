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

namespace QuanLyKhachSanNew.FrmChild.Charts
{
    public partial class FrmSDDVChart : DevExpress.XtraEditors.XtraForm
    {
        public FrmSDDVChart()
        {
            InitializeComponent();
        }

        private void FrmSDDVChart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.tblSDDV' table. You can move, or remove it, as needed.
            this.tblSDDVTableAdapter.Fill(this.quanLyKhachSanDataSet.tblSDDV);

        }
    }
}