namespace QuanLyKhachSanNew.FrmChild.Search
{
    partial class FrmPhongSearch
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
            this.dgvPhong = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.quanLyKhachSanDataSet = new QuanLyKhachSanNew.QuanLyKhachSanDataSet();
            this.tblPhongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPhongTableAdapter = new QuanLyKhachSanNew.QuanLyKhachSanDataSetTableAdapters.tblPhongTableAdapter();
            this.colMaPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGia = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhong
            // 
            this.dgvPhong.DataSource = this.tblPhongBindingSource;
            this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhong.Location = new System.Drawing.Point(0, 0);
            this.dgvPhong.MainView = this.gridView1;
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.Size = new System.Drawing.Size(748, 459);
            this.dgvPhong.TabIndex = 0;
            this.dgvPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPhong,
            this.colTenPhong,
            this.colLoaiPhong,
            this.colGia});
            this.gridView1.GridControl = this.dgvPhong;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            // 
            // quanLyKhachSanDataSet
            // 
            this.quanLyKhachSanDataSet.DataSetName = "QuanLyKhachSanDataSet";
            this.quanLyKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPhongBindingSource
            // 
            this.tblPhongBindingSource.DataMember = "tblPhong";
            this.tblPhongBindingSource.DataSource = this.quanLyKhachSanDataSet;
            // 
            // tblPhongTableAdapter
            // 
            this.tblPhongTableAdapter.ClearBeforeFill = true;
            // 
            // colMaPhong
            // 
            this.colMaPhong.FieldName = "MaPhong";
            this.colMaPhong.Name = "colMaPhong";
            this.colMaPhong.Visible = true;
            this.colMaPhong.VisibleIndex = 0;
            // 
            // colTenPhong
            // 
            this.colTenPhong.FieldName = "TenPhong";
            this.colTenPhong.Name = "colTenPhong";
            this.colTenPhong.Visible = true;
            this.colTenPhong.VisibleIndex = 1;
            // 
            // colLoaiPhong
            // 
            this.colLoaiPhong.FieldName = "LoaiPhong";
            this.colLoaiPhong.Name = "colLoaiPhong";
            this.colLoaiPhong.Visible = true;
            this.colLoaiPhong.VisibleIndex = 2;
            // 
            // colGia
            // 
            this.colGia.FieldName = "Gia";
            this.colGia.Name = "colGia";
            this.colGia.Visible = true;
            this.colGia.VisibleIndex = 3;
            // 
            // FrmPhongSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 459);
            this.Controls.Add(this.dgvPhong);
            this.Name = "FrmPhongSearch";
            this.Text = "Tìm Kiếm Phòng";
            this.Load += new System.EventHandler(this.FrmPhongSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QuanLyKhachSanDataSet quanLyKhachSanDataSet;
        private System.Windows.Forms.BindingSource tblPhongBindingSource;
        private QuanLyKhachSanDataSetTableAdapters.tblPhongTableAdapter tblPhongTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colTenPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colGia;
    }
}