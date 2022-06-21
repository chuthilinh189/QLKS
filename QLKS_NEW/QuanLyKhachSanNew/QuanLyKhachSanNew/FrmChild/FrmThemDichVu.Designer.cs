namespace QuanLyKhachSanNew.FrmChild
{
    partial class FrmThemDichVu
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
            this.gcThemDichVu = new DevExpress.XtraEditors.GroupControl();
            this.lblTenDV = new DevExpress.XtraEditors.LabelControl();
            this.lblMaNV = new DevExpress.XtraEditors.LabelControl();
            this.lblNgaySD = new DevExpress.XtraEditors.LabelControl();
            this.lblSoLuong = new DevExpress.XtraEditors.LabelControl();
            this.btnDangKy = new DevExpress.XtraEditors.CheckButton();
            this.lblMaDV = new DevExpress.XtraEditors.LabelControl();
            this.lueMaDV = new DevExpress.XtraEditors.LookUpEdit();
            this.teSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.dtpNgaySD = new DevExpress.XtraEditors.DateEdit();
            this.lueMaNV = new DevExpress.XtraEditors.LookUpEdit();
            this.lueTenDichVu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblMaDK = new DevExpress.XtraEditors.LabelControl();
            this.lueMaDK = new DevExpress.XtraEditors.LookUpEdit();
            this.quanLyKhachSanDataSet = new QuanLyKhachSanNew.QuanLyKhachSanDataSet();
            this.tblDangKyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDangKyTableAdapter = new QuanLyKhachSanNew.QuanLyKhachSanDataSetTableAdapters.tblDangKyTableAdapter();
            this.tblDichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDichVuTableAdapter = new QuanLyKhachSanNew.QuanLyKhachSanDataSetTableAdapters.tblDichVuTableAdapter();
            this.tblNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblNhanVienTableAdapter = new QuanLyKhachSanNew.QuanLyKhachSanDataSetTableAdapters.tblNhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcThemDichVu)).BeginInit();
            this.gcThemDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueMaDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTenDichVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMaDK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDangKyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDichVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gcThemDichVu
            // 
            this.gcThemDichVu.Controls.Add(this.lblMaDK);
            this.gcThemDichVu.Controls.Add(this.lueMaDK);
            this.gcThemDichVu.Controls.Add(this.lblTenDV);
            this.gcThemDichVu.Controls.Add(this.lblMaNV);
            this.gcThemDichVu.Controls.Add(this.lblNgaySD);
            this.gcThemDichVu.Controls.Add(this.lblSoLuong);
            this.gcThemDichVu.Controls.Add(this.btnDangKy);
            this.gcThemDichVu.Controls.Add(this.lblMaDV);
            this.gcThemDichVu.Controls.Add(this.lueMaDV);
            this.gcThemDichVu.Controls.Add(this.teSoLuong);
            this.gcThemDichVu.Controls.Add(this.dtpNgaySD);
            this.gcThemDichVu.Controls.Add(this.lueMaNV);
            this.gcThemDichVu.Controls.Add(this.lueTenDichVu);
            this.gcThemDichVu.Location = new System.Drawing.Point(12, 12);
            this.gcThemDichVu.Name = "gcThemDichVu";
            this.gcThemDichVu.Size = new System.Drawing.Size(682, 228);
            this.gcThemDichVu.TabIndex = 0;
            this.gcThemDichVu.Text = "Thêm Dịch Vụ";
            // 
            // lblTenDV
            // 
            this.lblTenDV.Location = new System.Drawing.Point(272, 146);
            this.lblTenDV.Name = "lblTenDV";
            this.lblTenDV.Size = new System.Drawing.Size(56, 13);
            this.lblTenDV.TabIndex = 48;
            this.lblTenDV.Text = "Tên Dịch Vụ";
            // 
            // lblMaNV
            // 
            this.lblMaNV.Location = new System.Drawing.Point(257, 104);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(65, 13);
            this.lblMaNV.TabIndex = 46;
            this.lblMaNV.Text = "Mã Nhân Viên";
            // 
            // lblNgaySD
            // 
            this.lblNgaySD.Location = new System.Drawing.Point(257, 61);
            this.lblNgaySD.Name = "lblNgaySD";
            this.lblNgaySD.Size = new System.Drawing.Size(69, 13);
            this.lblNgaySD.TabIndex = 44;
            this.lblNgaySD.Text = "Ngày Sử Dụng";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Location = new System.Drawing.Point(34, 142);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(45, 13);
            this.lblSoLuong.TabIndex = 42;
            this.lblSoLuong.Text = "Số Lượng";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(396, 184);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 23);
            this.btnDangKy.TabIndex = 40;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.CheckedChanged += new System.EventHandler(this.btnDangKy_CheckedChanged);
            // 
            // lblMaDV
            // 
            this.lblMaDV.Location = new System.Drawing.Point(34, 99);
            this.lblMaDV.Name = "lblMaDV";
            this.lblMaDV.Size = new System.Drawing.Size(52, 13);
            this.lblMaDV.TabIndex = 39;
            this.lblMaDV.Text = "Mã Dịch Vụ";
            // 
            // lueMaDV
            // 
            this.lueMaDV.Location = new System.Drawing.Point(104, 96);
            this.lueMaDV.Name = "lueMaDV";
            this.lueMaDV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMaDV.Properties.DataSource = this.tblDichVuBindingSource;
            this.lueMaDV.Properties.DisplayMember = "MaDV";
            this.lueMaDV.Properties.NullText = "";
            this.lueMaDV.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueMaDV.Properties.ValueMember = "MaDV";
            this.lueMaDV.Size = new System.Drawing.Size(129, 20);
            this.lueMaDV.TabIndex = 38;
            this.lueMaDV.EditValueChanged += new System.EventHandler(this.lueMaDV_EditValueChanged);
            // 
            // teSoLuong
            // 
            this.teSoLuong.EditValue = "Nhập SL";
            this.teSoLuong.Location = new System.Drawing.Point(104, 139);
            this.teSoLuong.Name = "teSoLuong";
            this.teSoLuong.Size = new System.Drawing.Size(129, 20);
            this.teSoLuong.TabIndex = 41;
            // 
            // dtpNgaySD
            // 
            this.dtpNgaySD.EditValue = null;
            this.dtpNgaySD.Location = new System.Drawing.Point(342, 58);
            this.dtpNgaySD.Name = "dtpNgaySD";
            this.dtpNgaySD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgaySD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgaySD.Properties.Mask.EditMask = "";
            this.dtpNgaySD.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtpNgaySD.Size = new System.Drawing.Size(129, 20);
            this.dtpNgaySD.TabIndex = 43;
            // 
            // lueMaNV
            // 
            this.lueMaNV.Location = new System.Drawing.Point(342, 101);
            this.lueMaNV.Name = "lueMaNV";
            this.lueMaNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMaNV.Properties.DataSource = this.tblNhanVienBindingSource;
            this.lueMaNV.Properties.DisplayMember = "MaNV";
            this.lueMaNV.Properties.NullText = "";
            this.lueMaNV.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueMaNV.Properties.ValueMember = "MaNV";
            this.lueMaNV.Size = new System.Drawing.Size(129, 20);
            this.lueMaNV.TabIndex = 45;
            // 
            // lueTenDichVu
            // 
            this.lueTenDichVu.Location = new System.Drawing.Point(342, 143);
            this.lueTenDichVu.Name = "lueTenDichVu";
            this.lueTenDichVu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTenDichVu.Properties.PopupSizeable = true;
            this.lueTenDichVu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.lueTenDichVu.Size = new System.Drawing.Size(129, 20);
            this.lueTenDichVu.TabIndex = 47;
            // 
            // lblMaDK
            // 
            this.lblMaDK.Location = new System.Drawing.Point(34, 61);
            this.lblMaDK.Name = "lblMaDK";
            this.lblMaDK.Size = new System.Drawing.Size(58, 13);
            this.lblMaDK.TabIndex = 50;
            this.lblMaDK.Text = "Mã Đăng Ký";
            // 
            // lueMaDK
            // 
            this.lueMaDK.Location = new System.Drawing.Point(104, 58);
            this.lueMaDK.Name = "lueMaDK";
            this.lueMaDK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMaDK.Properties.DataSource = this.tblDangKyBindingSource;
            this.lueMaDK.Properties.DisplayMember = "MaDK";
            this.lueMaDK.Properties.NullText = "";
            this.lueMaDK.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueMaDK.Properties.ValueMember = "MaDK";
            this.lueMaDK.Size = new System.Drawing.Size(129, 20);
            this.lueMaDK.TabIndex = 49;
            // 
            // quanLyKhachSanDataSet
            // 
            this.quanLyKhachSanDataSet.DataSetName = "QuanLyKhachSanDataSet";
            this.quanLyKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDangKyBindingSource
            // 
            this.tblDangKyBindingSource.DataMember = "tblDangKy";
            this.tblDangKyBindingSource.DataSource = this.quanLyKhachSanDataSet;
            // 
            // tblDangKyTableAdapter
            // 
            this.tblDangKyTableAdapter.ClearBeforeFill = true;
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
            // tblNhanVienBindingSource
            // 
            this.tblNhanVienBindingSource.DataMember = "tblNhanVien";
            this.tblNhanVienBindingSource.DataSource = this.quanLyKhachSanDataSet;
            // 
            // tblNhanVienTableAdapter
            // 
            this.tblNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // FrmThemDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 269);
            this.Controls.Add(this.gcThemDichVu);
            this.Name = "FrmThemDichVu";
            this.Text = "Thêm Dịch Vụ";
            this.Load += new System.EventHandler(this.FrmThemDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcThemDichVu)).EndInit();
            this.gcThemDichVu.ResumeLayout(false);
            this.gcThemDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueMaDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTenDichVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMaDK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDangKyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDichVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcThemDichVu;
        private DevExpress.XtraEditors.LabelControl lblTenDV;
        private DevExpress.XtraEditors.LabelControl lblMaNV;
        private DevExpress.XtraEditors.LabelControl lblNgaySD;
        private DevExpress.XtraEditors.LabelControl lblSoLuong;
        private DevExpress.XtraEditors.CheckButton btnDangKy;
        private DevExpress.XtraEditors.LabelControl lblMaDV;
        private DevExpress.XtraEditors.LookUpEdit lueMaDV;
        private DevExpress.XtraEditors.TextEdit teSoLuong;
        private DevExpress.XtraEditors.DateEdit dtpNgaySD;
        private DevExpress.XtraEditors.LookUpEdit lueMaNV;
        private DevExpress.XtraEditors.ComboBoxEdit lueTenDichVu;
        private DevExpress.XtraEditors.LabelControl lblMaDK;
        private DevExpress.XtraEditors.LookUpEdit lueMaDK;
        private QuanLyKhachSanDataSet quanLyKhachSanDataSet;
        private System.Windows.Forms.BindingSource tblDangKyBindingSource;
        private QuanLyKhachSanDataSetTableAdapters.tblDangKyTableAdapter tblDangKyTableAdapter;
        private System.Windows.Forms.BindingSource tblDichVuBindingSource;
        private QuanLyKhachSanDataSetTableAdapters.tblDichVuTableAdapter tblDichVuTableAdapter;
        private System.Windows.Forms.BindingSource tblNhanVienBindingSource;
        private QuanLyKhachSanDataSetTableAdapters.tblNhanVienTableAdapter tblNhanVienTableAdapter;
    }
}