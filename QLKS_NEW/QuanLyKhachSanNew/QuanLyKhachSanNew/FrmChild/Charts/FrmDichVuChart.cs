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
    public partial class FrmDichVuChart : DevExpress.XtraEditors.XtraForm
    {
        public FrmDichVuChart()
        {
            InitializeComponent();
        }

        private void FrmDichVuChart_Load(object sender, EventArgs e)
        {
            DataTable tblDichVu = new DataTable();
            tblDichVu = BtblDichVu.SelectAll();
            // Create a chart.
            ChartControl chart = new ChartControl();

            // Generate a data table and bind the chart to it.
            chart.DataSource = tblDichVu;

            // Specify data members to bind the chart's series template.
            
            chart.SeriesDataMember = "TenDV";
            chart.SeriesTemplate.ArgumentDataMember = "MaDV";
            chart.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "GiaTien" });

            // Specify the template's series view.
            chart.SeriesTemplate.View = new StackedBarSeriesView();

            // Specify the template's name prefix.
            chart.SeriesNameTemplate.BeginText = "Tên Dịch Vụ:: ";

            // Dock the chart into its parent, and add it to the current form.
            chart.Dock = DockStyle.Fill;
            this.Controls.Add(chart);

        }
    }
}