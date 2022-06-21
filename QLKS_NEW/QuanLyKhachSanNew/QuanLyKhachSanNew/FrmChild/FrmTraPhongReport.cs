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
using DevExpress.XtraReports.UI;
using Microsoft.Reporting.WinForms;

namespace QuanLyKhachSanNew.FrmChild
{
    public partial class FrmTraPhongReport : DevExpress.XtraEditors.XtraForm
    {
        public FrmTraPhongReport()
        {
            InitializeComponent();
        }

        private void FrmTraPhongReport_Load(object sender, EventArgs e)
        {


            ReportParameter[] parameter = new ReportParameter[6];
            parameter[0] = new ReportParameter("MaDK"); //đay là tham số đầu tiên.
            parameter[0].Values.Add("MaDK01"); // Giá trị của tham số đầu tiền mình truyền vào.

            
        }
    }
}