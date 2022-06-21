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
using AppCode.Entities;
using AppCode.Business;

namespace QuanLyKhachSanNew.FrmChild.Charts
{
    public partial class FrmChucVuChart : DevExpress.XtraEditors.XtraForm
    {
        public FrmChucVuChart()
        {
            InitializeComponent();
        }

        private void FrmChucVuChart_Load(object sender, EventArgs e)
        {
            DataTable tblChucVu = new DataTable();
            tblChucVu = BtblChucVu.SelectAll();
            // Create a chart.
            ChartControl chart = new ChartControl();

            // Generate a data table and bind the chart to it.
            chart.DataSource = tblChucVu;

            // Specify data members to bind the chart's series template.
            chart.SeriesDataMember = "ChucVu";
            chart.SeriesTemplate.ArgumentDataMember = "MaCV";
            chart.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "Khu" });

            // Specify the template's series view.
            chart.SeriesTemplate.View = new StackedBarSeriesView();

            // Specify the template's name prefix.
            chart.SeriesNameTemplate.BeginText = "Chức Vụ: ";

            // Dock the chart into its parent, and add it to the current form.
            chart.Dock = DockStyle.Fill;
            this.Controls.Add(chart);

        }
    }
}