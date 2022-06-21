namespace QuanLyKhachSanNew.FrmChild.Charts
{
    partial class FrmDangkyChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ScatterLineSeriesView scatterLineSeriesView1 = new DevExpress.XtraCharts.ScatterLineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ScatterLineSeriesView scatterLineSeriesView2 = new DevExpress.XtraCharts.ScatterLineSeriesView();
            DevExpress.XtraCharts.ScatterLineSeriesView scatterLineSeriesView3 = new DevExpress.XtraCharts.ScatterLineSeriesView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.tblDangKyTableAdapter = new QuanLyKhachSanNew.QuanLyKhachSanDataSetTableAdapters.tblDangKyTableAdapter();
            this.tblDangKyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhachSanDataSet = new QuanLyKhachSanNew.QuanLyKhachSanDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(scatterLineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(scatterLineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(scatterLineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDangKyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.DataAdapter = this.tblDangKyTableAdapter;
            this.chartControl1.DataSource = this.tblDangKyBindingSource;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentDataMember = "MaKhach";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            series1.Name = "Số Người";
            series1.ValueDataMembersSerializable = "SoNguoi";
            series1.View = scatterLineSeriesView1;
            series2.ArgumentDataMember = "MaKhach";
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            series2.Name = "Tiền Đặt";
            series2.ValueDataMembersSerializable = "TienDat";
            series2.View = scatterLineSeriesView2;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chartControl1.SeriesTemplate.View = scatterLineSeriesView3;
            this.chartControl1.Size = new System.Drawing.Size(653, 308);
            this.chartControl1.TabIndex = 0;
            // 
            // tblDangKyTableAdapter
            // 
            this.tblDangKyTableAdapter.ClearBeforeFill = true;
            // 
            // tblDangKyBindingSource
            // 
            this.tblDangKyBindingSource.DataMember = "tblDangKy";
            this.tblDangKyBindingSource.DataSource = this.quanLyKhachSanDataSet;
            // 
            // quanLyKhachSanDataSet
            // 
            this.quanLyKhachSanDataSet.DataSetName = "QuanLyKhachSanDataSet";
            this.quanLyKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmDangkyChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 308);
            this.Controls.Add(this.chartControl1);
            this.Name = "FrmDangkyChart";
            this.Text = "Báo Cáo Đăng Ký";
            this.Load += new System.EventHandler(this.FrmDangkyChart_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(scatterLineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(scatterLineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(scatterLineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDangKyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private QuanLyKhachSanDataSetTableAdapters.tblDangKyTableAdapter tblDangKyTableAdapter;
        private QuanLyKhachSanDataSet quanLyKhachSanDataSet;
        private System.Windows.Forms.BindingSource tblDangKyBindingSource;
    }
}