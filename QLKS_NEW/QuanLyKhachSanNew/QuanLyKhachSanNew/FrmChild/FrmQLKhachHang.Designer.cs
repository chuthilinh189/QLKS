namespace QuanLyKhachSanNew.FrmChild
{
    partial class FrmQLKhachHang
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
            this.gcKhachHang = new DevExpress.XtraEditors.GroupControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.deNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.teQuocTich = new DevExpress.XtraEditors.TextEdit();
            this.teCMND = new DevExpress.XtraEditors.TextEdit();
            this.teTen = new DevExpress.XtraEditors.TextEdit();
            this.teHoDem = new DevExpress.XtraEditors.TextEdit();
            this.lblNghiChu = new DevExpress.XtraEditors.LabelControl();
            this.lblQuocTich = new DevExpress.XtraEditors.LabelControl();
            this.lblCMND = new DevExpress.XtraEditors.LabelControl();
            this.lblNgaySinh = new DevExpress.XtraEditors.LabelControl();
            this.lblTen = new DevExpress.XtraEditors.LabelControl();
            this.lblHoDem = new DevExpress.XtraEditors.LabelControl();
            this.lblMaKhach = new DevExpress.XtraEditors.LabelControl();
            this.teMaKhach = new DevExpress.XtraEditors.TextEdit();
            this.teNghiChu = new DevExpress.XtraEditors.MemoEdit();
            this.dgvKhachHang = new DevExpress.XtraVerticalGrid.VGridControl();
            this.tblKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhachSanDataSet = new QuanLyKhachSanNew.QuanLyKhachSanDataSet();
            this.rowMaKhach = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowHoDem = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTen = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowNgaySinh = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCMND = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowQuocTich = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowNghiChu = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.tblKhachHangTableAdapter = new QuanLyKhachSanNew.QuanLyKhachSanDataSetTableAdapters.tblKhachHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhachHang)).BeginInit();
            this.gcKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teQuocTich.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHoDem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaKhach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNghiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gcKhachHang
            // 
            this.gcKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcKhachHang.Controls.Add(this.btnXoa);
            this.gcKhachHang.Controls.Add(this.btnSua);
            this.gcKhachHang.Controls.Add(this.btnThem);
            this.gcKhachHang.Controls.Add(this.deNgaySinh);
            this.gcKhachHang.Controls.Add(this.teQuocTich);
            this.gcKhachHang.Controls.Add(this.teCMND);
            this.gcKhachHang.Controls.Add(this.teTen);
            this.gcKhachHang.Controls.Add(this.teHoDem);
            this.gcKhachHang.Controls.Add(this.lblNghiChu);
            this.gcKhachHang.Controls.Add(this.lblQuocTich);
            this.gcKhachHang.Controls.Add(this.lblCMND);
            this.gcKhachHang.Controls.Add(this.lblNgaySinh);
            this.gcKhachHang.Controls.Add(this.lblTen);
            this.gcKhachHang.Controls.Add(this.lblHoDem);
            this.gcKhachHang.Controls.Add(this.lblMaKhach);
            this.gcKhachHang.Controls.Add(this.teMaKhach);
            this.gcKhachHang.Controls.Add(this.teNghiChu);
            this.gcKhachHang.Location = new System.Drawing.Point(12, 12);
            this.gcKhachHang.Name = "gcKhachHang";
            this.gcKhachHang.Size = new System.Drawing.Size(657, 280);
            this.gcKhachHang.TabIndex = 0;
            this.gcKhachHang.Text = "Quản Lý Khách Hàng";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(563, 204);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(457, 204);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(351, 204);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // deNgaySinh
            // 
            this.deNgaySinh.EditValue = null;
            this.deNgaySinh.Location = new System.Drawing.Point(418, 44);
            this.deNgaySinh.Name = "deNgaySinh";
            this.deNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgaySinh.Size = new System.Drawing.Size(147, 20);
            this.deNgaySinh.TabIndex = 15;
            // 
            // teQuocTich
            // 
            this.teQuocTich.Location = new System.Drawing.Point(418, 125);
            this.teQuocTich.Name = "teQuocTich";
            this.teQuocTich.Size = new System.Drawing.Size(147, 20);
            this.teQuocTich.TabIndex = 13;
            // 
            // teCMND
            // 
            this.teCMND.Location = new System.Drawing.Point(418, 86);
            this.teCMND.Name = "teCMND";
            this.teCMND.Size = new System.Drawing.Size(147, 20);
            this.teCMND.TabIndex = 12;
            // 
            // teTen
            // 
            this.teTen.Location = new System.Drawing.Point(111, 122);
            this.teTen.Name = "teTen";
            this.teTen.Size = new System.Drawing.Size(147, 20);
            this.teTen.TabIndex = 10;
            // 
            // teHoDem
            // 
            this.teHoDem.Location = new System.Drawing.Point(111, 87);
            this.teHoDem.Name = "teHoDem";
            this.teHoDem.Size = new System.Drawing.Size(147, 20);
            this.teHoDem.TabIndex = 9;
            // 
            // lblNghiChu
            // 
            this.lblNghiChu.Location = new System.Drawing.Point(37, 173);
            this.lblNghiChu.Name = "lblNghiChu";
            this.lblNghiChu.Size = new System.Drawing.Size(43, 13);
            this.lblNghiChu.TabIndex = 8;
            this.lblNghiChu.Text = "Nghi Chú";
            // 
            // lblQuocTich
            // 
            this.lblQuocTich.Location = new System.Drawing.Point(344, 128);
            this.lblQuocTich.Name = "lblQuocTich";
            this.lblQuocTich.Size = new System.Drawing.Size(47, 13);
            this.lblQuocTich.TabIndex = 7;
            this.lblQuocTich.Text = "Quốc Tịch";
            // 
            // lblCMND
            // 
            this.lblCMND.Location = new System.Drawing.Point(344, 89);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(44, 13);
            this.lblCMND.TabIndex = 6;
            this.lblCMND.Text = "Số CMND";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Location = new System.Drawing.Point(344, 44);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(48, 13);
            this.lblNgaySinh.TabIndex = 5;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblTen
            // 
            this.lblTen.Location = new System.Drawing.Point(37, 125);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(18, 13);
            this.lblTen.TabIndex = 4;
            this.lblTen.Text = "Tên";
            // 
            // lblHoDem
            // 
            this.lblHoDem.Location = new System.Drawing.Point(37, 90);
            this.lblHoDem.Name = "lblHoDem";
            this.lblHoDem.Size = new System.Drawing.Size(38, 13);
            this.lblHoDem.TabIndex = 3;
            this.lblHoDem.Text = "Họ Đệm";
            // 
            // lblMaKhach
            // 
            this.lblMaKhach.Location = new System.Drawing.Point(37, 53);
            this.lblMaKhach.Name = "lblMaKhach";
            this.lblMaKhach.Size = new System.Drawing.Size(46, 13);
            this.lblMaKhach.TabIndex = 1;
            this.lblMaKhach.Text = "Mã Khách";
            // 
            // teMaKhach
            // 
            this.teMaKhach.Location = new System.Drawing.Point(111, 50);
            this.teMaKhach.Name = "teMaKhach";
            this.teMaKhach.Size = new System.Drawing.Size(147, 20);
            this.teMaKhach.TabIndex = 0;
            // 
            // teNghiChu
            // 
            this.teNghiChu.Location = new System.Drawing.Point(111, 170);
            this.teNghiChu.Name = "teNghiChu";
            this.teNghiChu.Size = new System.Drawing.Size(207, 69);
            this.teNghiChu.TabIndex = 14;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.DataSource = this.tblKhachHangBindingSource;
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 298);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowMaKhach,
            this.rowHoDem,
            this.rowTen,
            this.rowNgaySinh,
            this.rowCMND,
            this.rowQuocTich,
            this.rowNghiChu});
            this.dgvKhachHang.Size = new System.Drawing.Size(681, 289);
            this.dgvKhachHang.TabIndex = 1;
            // 
            // tblKhachHangBindingSource
            // 
            this.tblKhachHangBindingSource.DataMember = "tblKhachHang";
            this.tblKhachHangBindingSource.DataSource = this.quanLyKhachSanDataSet;
            // 
            // quanLyKhachSanDataSet
            // 
            this.quanLyKhachSanDataSet.DataSetName = "QuanLyKhachSanDataSet";
            this.quanLyKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rowMaKhach
            // 
            this.rowMaKhach.Height = 25;
            this.rowMaKhach.Name = "rowMaKhach";
            this.rowMaKhach.Properties.Caption = "Mã Khách";
            this.rowMaKhach.Properties.CustomizationCaption = "Mã Khách";
            this.rowMaKhach.Properties.FieldName = "MaKhach";
            // 
            // rowHoDem
            // 
            this.rowHoDem.Height = 27;
            this.rowHoDem.Name = "rowHoDem";
            this.rowHoDem.Properties.Caption = "Họ Đệm";
            this.rowHoDem.Properties.CustomizationCaption = "Họ Đệm";
            this.rowHoDem.Properties.FieldName = "HoDem";
            // 
            // rowTen
            // 
            this.rowTen.Height = 30;
            this.rowTen.Name = "rowTen";
            this.rowTen.Properties.Caption = "Tên";
            this.rowTen.Properties.CustomizationCaption = "Tên";
            this.rowTen.Properties.FieldName = "Ten";
            // 
            // rowNgaySinh
            // 
            this.rowNgaySinh.Height = 34;
            this.rowNgaySinh.Name = "rowNgaySinh";
            this.rowNgaySinh.Properties.Caption = "Ngày Sinh";
            this.rowNgaySinh.Properties.CustomizationCaption = "Ngày Sinh";
            this.rowNgaySinh.Properties.FieldName = "NgaySinh";
            // 
            // rowCMND
            // 
            this.rowCMND.Height = 29;
            this.rowCMND.Name = "rowCMND";
            this.rowCMND.Properties.Caption = "CMND";
            this.rowCMND.Properties.CustomizationCaption = "CMND";
            this.rowCMND.Properties.FieldName = "CMND";
            // 
            // rowQuocTich
            // 
            this.rowQuocTich.Height = 32;
            this.rowQuocTich.Name = "rowQuocTich";
            this.rowQuocTich.Properties.Caption = "Quốc Tịch";
            this.rowQuocTich.Properties.CustomizationCaption = "Quốc Tịch";
            this.rowQuocTich.Properties.FieldName = "QuocTich";
            // 
            // rowNghiChu
            // 
            this.rowNghiChu.Height = 75;
            this.rowNghiChu.Name = "rowNghiChu";
            this.rowNghiChu.Properties.Caption = "Nghi Chú";
            this.rowNghiChu.Properties.CustomizationCaption = "Nghi Chú";
            this.rowNghiChu.Properties.FieldName = "NghiChu";
            // 
            // tblKhachHangTableAdapter
            // 
            this.tblKhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // FrmQLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 587);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.gcKhachHang);
            this.Name = "FrmQLKhachHang";
            this.Text = "Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.FrmQLKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcKhachHang)).EndInit();
            this.gcKhachHang.ResumeLayout(false);
            this.gcKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teQuocTich.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHoDem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaKhach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNghiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcKhachHang;
        private DevExpress.XtraEditors.TextEdit teQuocTich;
        private DevExpress.XtraEditors.TextEdit teCMND;
        private DevExpress.XtraEditors.TextEdit teTen;
        private DevExpress.XtraEditors.TextEdit teHoDem;
        private DevExpress.XtraEditors.LabelControl lblNghiChu;
        private DevExpress.XtraEditors.LabelControl lblQuocTich;
        private DevExpress.XtraEditors.LabelControl lblCMND;
        private DevExpress.XtraEditors.LabelControl lblNgaySinh;
        private DevExpress.XtraEditors.LabelControl lblTen;
        private DevExpress.XtraEditors.LabelControl lblHoDem;
        private DevExpress.XtraEditors.LabelControl lblMaKhach;
        private DevExpress.XtraEditors.TextEdit teMaKhach;
        private DevExpress.XtraEditors.DateEdit deNgaySinh;
        private DevExpress.XtraEditors.MemoEdit teNghiChu;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraVerticalGrid.VGridControl dgvKhachHang;
        private QuanLyKhachSanDataSet quanLyKhachSanDataSet;
        private System.Windows.Forms.BindingSource tblKhachHangBindingSource;
        private QuanLyKhachSanDataSetTableAdapters.tblKhachHangTableAdapter tblKhachHangTableAdapter;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowMaKhach;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowHoDem;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTen;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowNgaySinh;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCMND;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowQuocTich;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowNghiChu;
    }
}