namespace QuanLyKhachSanNew.FrmChild
{
    partial class FrmQLDichVu
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
            this.gcQuanLyDichVu = new DevExpress.XtraEditors.GroupControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.lblGiaTien = new DevExpress.XtraEditors.LabelControl();
            this.teGiaTien = new DevExpress.XtraEditors.TextEdit();
            this.lblTenDV = new DevExpress.XtraEditors.LabelControl();
            this.teTenDV = new DevExpress.XtraEditors.TextEdit();
            this.lblMaDV = new DevExpress.XtraEditors.LabelControl();
            this.teMaDV = new DevExpress.XtraEditors.TextEdit();
            this.quanLyKhachSanDataSet = new QuanLyKhachSanNew.QuanLyKhachSanDataSet();
            this.tblDichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDichVuTableAdapter = new QuanLyKhachSanNew.QuanLyKhachSanDataSetTableAdapters.tblDichVuTableAdapter();
            this.dgvDichVu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaTien = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcQuanLyDichVu)).BeginInit();
            this.gcQuanLyDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teGiaTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTenDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDichVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcQuanLyDichVu
            // 
            this.gcQuanLyDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcQuanLyDichVu.Controls.Add(this.btnXoa);
            this.gcQuanLyDichVu.Controls.Add(this.btnSua);
            this.gcQuanLyDichVu.Controls.Add(this.btnThem);
            this.gcQuanLyDichVu.Controls.Add(this.lblGiaTien);
            this.gcQuanLyDichVu.Controls.Add(this.teGiaTien);
            this.gcQuanLyDichVu.Controls.Add(this.lblTenDV);
            this.gcQuanLyDichVu.Controls.Add(this.teTenDV);
            this.gcQuanLyDichVu.Controls.Add(this.lblMaDV);
            this.gcQuanLyDichVu.Controls.Add(this.teMaDV);
            this.gcQuanLyDichVu.Location = new System.Drawing.Point(12, 12);
            this.gcQuanLyDichVu.Name = "gcQuanLyDichVu";
            this.gcQuanLyDichVu.Size = new System.Drawing.Size(693, 219);
            this.gcQuanLyDichVu.TabIndex = 0;
            this.gcQuanLyDichVu.Text = "Quản Lý Dịch Vụ";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(285, 177);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(159, 177);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(35, 177);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.Location = new System.Drawing.Point(37, 136);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(38, 13);
            this.lblGiaTien.TabIndex = 5;
            this.lblGiaTien.Text = "Giá Tiền";
            // 
            // teGiaTien
            // 
            this.teGiaTien.Location = new System.Drawing.Point(117, 133);
            this.teGiaTien.Name = "teGiaTien";
            this.teGiaTien.Size = new System.Drawing.Size(100, 20);
            this.teGiaTien.TabIndex = 4;
            // 
            // lblTenDV
            // 
            this.lblTenDV.Location = new System.Drawing.Point(37, 92);
            this.lblTenDV.Name = "lblTenDV";
            this.lblTenDV.Size = new System.Drawing.Size(56, 13);
            this.lblTenDV.TabIndex = 3;
            this.lblTenDV.Text = "Tên Dịch Vụ";
            // 
            // teTenDV
            // 
            this.teTenDV.Location = new System.Drawing.Point(117, 89);
            this.teTenDV.Name = "teTenDV";
            this.teTenDV.Size = new System.Drawing.Size(100, 20);
            this.teTenDV.TabIndex = 2;
            // 
            // lblMaDV
            // 
            this.lblMaDV.Location = new System.Drawing.Point(37, 47);
            this.lblMaDV.Name = "lblMaDV";
            this.lblMaDV.Size = new System.Drawing.Size(52, 13);
            this.lblMaDV.TabIndex = 1;
            this.lblMaDV.Text = "Mã Dịch Vụ";
            // 
            // teMaDV
            // 
            this.teMaDV.Location = new System.Drawing.Point(117, 44);
            this.teMaDV.Name = "teMaDV";
            this.teMaDV.Size = new System.Drawing.Size(100, 20);
            this.teMaDV.TabIndex = 0;
            // 
            // quanLyKhachSanDataSet
            // 
            this.quanLyKhachSanDataSet.DataSetName = "QuanLyKhachSanDataSet";
            this.quanLyKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDichVuBindingSource
            // 
            this.tblDichVuBindingSource.DataMember = "tblDichVu";
            this.tblDichVuBindingSource.DataSource = this.quanLyKhachSanDataSet;
            // 
            // tblDichVuTableAdapter
            // 
            this.tblDichVuTableAdapter.ClearBeforeFill = true;
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvDichVu.DataSource = this.tblDichVuBindingSource;
            this.dgvDichVu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDichVu.Location = new System.Drawing.Point(0, 171);
            this.dgvDichVu.MainView = this.gridView1;
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.Size = new System.Drawing.Size(717, 265);
            this.dgvDichVu.TabIndex = 1;
            this.dgvDichVu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDV,
            this.colTenDV,
            this.colGiaTien});
            this.gridView1.GridControl = this.dgvDichVu;
            this.gridView1.Name = "gridView1";
            // 
            // colMaDV
            // 
            this.colMaDV.Caption = "Mã Dịch Vụ";
            this.colMaDV.FieldName = "MaDV";
            this.colMaDV.Name = "colMaDV";
            this.colMaDV.Visible = true;
            this.colMaDV.VisibleIndex = 0;
            // 
            // colTenDV
            // 
            this.colTenDV.Caption = "Tên Dịch Vụ";
            this.colTenDV.FieldName = "TenDV";
            this.colTenDV.Name = "colTenDV";
            this.colTenDV.Visible = true;
            this.colTenDV.VisibleIndex = 1;
            // 
            // colGiaTien
            // 
            this.colGiaTien.Caption = "Giá Tiền";
            this.colGiaTien.FieldName = "GiaTien";
            this.colGiaTien.Name = "colGiaTien";
            this.colGiaTien.Visible = true;
            this.colGiaTien.VisibleIndex = 2;
            // 
            // FrmQLDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 436);
            this.Controls.Add(this.dgvDichVu);
            this.Controls.Add(this.gcQuanLyDichVu);
            this.Name = "FrmQLDichVu";
            this.Text = "Quản Lý Dịch Vụ";
            this.Load += new System.EventHandler(this.FrmQLDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcQuanLyDichVu)).EndInit();
            this.gcQuanLyDichVu.ResumeLayout(false);
            this.gcQuanLyDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teGiaTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTenDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDichVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcQuanLyDichVu;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.LabelControl lblGiaTien;
        private DevExpress.XtraEditors.TextEdit teGiaTien;
        private DevExpress.XtraEditors.LabelControl lblTenDV;
        private DevExpress.XtraEditors.TextEdit teTenDV;
        private DevExpress.XtraEditors.LabelControl lblMaDV;
        private DevExpress.XtraEditors.TextEdit teMaDV;
        private QuanLyKhachSanDataSet quanLyKhachSanDataSet;
        private System.Windows.Forms.BindingSource tblDichVuBindingSource;
        private QuanLyKhachSanDataSetTableAdapters.tblDichVuTableAdapter tblDichVuTableAdapter;
        private DevExpress.XtraGrid.GridControl dgvDichVu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDV;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDV;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaTien;
    }
}