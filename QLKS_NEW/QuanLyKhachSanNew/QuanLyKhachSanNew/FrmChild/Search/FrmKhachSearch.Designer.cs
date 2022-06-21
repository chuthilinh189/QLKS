namespace QuanLyKhachSanNew.FrmChild.Search
{
    partial class FrmKhachSearch
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
            this.dgvKhach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.quanLyKhachSanDataSet = new QuanLyKhachSanNew.QuanLyKhachSanDataSet();
            this.tblKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblKhachHangTableAdapter = new QuanLyKhachSanNew.QuanLyKhachSanDataSetTableAdapters.tblKhachHangTableAdapter();
            this.colMaKhach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoDem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuocTich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNghiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhach
            // 
            this.dgvKhach.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvKhach.DataSource = this.tblKhachHangBindingSource;
            this.dgvKhach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhach.Location = new System.Drawing.Point(0, 0);
            this.dgvKhach.MainView = this.gridView1;
            this.dgvKhach.Name = "dgvKhach";
            this.dgvKhach.Size = new System.Drawing.Size(756, 435);
            this.dgvKhach.TabIndex = 0;
            this.dgvKhach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKhach,
            this.colHoDem,
            this.colTen,
            this.colNgaySinh,
            this.colCMND,
            this.colQuocTich,
            this.colNghiChu});
            this.gridView1.GridControl = this.dgvKhach;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // quanLyKhachSanDataSet
            // 
            this.quanLyKhachSanDataSet.DataSetName = "QuanLyKhachSanDataSet";
            this.quanLyKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKhachHangBindingSource
            // 
            this.tblKhachHangBindingSource.DataMember = "tblKhachHang";
            this.tblKhachHangBindingSource.DataSource = this.quanLyKhachSanDataSet;
            // 
            // tblKhachHangTableAdapter
            // 
            this.tblKhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // colMaKhach
            // 
            this.colMaKhach.FieldName = "MaKhach";
            this.colMaKhach.Name = "colMaKhach";
            this.colMaKhach.Visible = true;
            this.colMaKhach.VisibleIndex = 0;
            // 
            // colHoDem
            // 
            this.colHoDem.FieldName = "HoDem";
            this.colHoDem.Name = "colHoDem";
            this.colHoDem.Visible = true;
            this.colHoDem.VisibleIndex = 1;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 2;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 3;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 4;
            // 
            // colQuocTich
            // 
            this.colQuocTich.FieldName = "QuocTich";
            this.colQuocTich.Name = "colQuocTich";
            this.colQuocTich.Visible = true;
            this.colQuocTich.VisibleIndex = 5;
            // 
            // colNghiChu
            // 
            this.colNghiChu.FieldName = "NghiChu";
            this.colNghiChu.Name = "colNghiChu";
            this.colNghiChu.Visible = true;
            this.colNghiChu.VisibleIndex = 6;
            // 
            // FrmKhachSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 435);
            this.Controls.Add(this.dgvKhach);
            this.Name = "FrmKhachSearch";
            this.Text = "Tìm Kiếm Khách";
            this.Load += new System.EventHandler(this.FrmKhachSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvKhach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QuanLyKhachSanDataSet quanLyKhachSanDataSet;
        private System.Windows.Forms.BindingSource tblKhachHangBindingSource;
        private QuanLyKhachSanDataSetTableAdapters.tblKhachHangTableAdapter tblKhachHangTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhach;
        private DevExpress.XtraGrid.Columns.GridColumn colHoDem;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colQuocTich;
        private DevExpress.XtraGrid.Columns.GridColumn colNghiChu;
    }
}