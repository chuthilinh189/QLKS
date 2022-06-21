namespace QuanLyKhachSanNew.Report
{
    partial class TraPhongReport
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lblTongTien = new DevExpress.XtraReports.UI.XRLabel();
            this.rpTongTien = new DevExpress.XtraReports.UI.XRLabel();
            this.TongTien = new DevExpress.XtraReports.Parameters.Parameter();
            this.rpTienDatCoc = new DevExpress.XtraReports.UI.XRLabel();
            this.TienDatCoc = new DevExpress.XtraReports.Parameters.Parameter();
            this.lblTienDatCoc = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTienDichVu = new DevExpress.XtraReports.UI.XRLabel();
            this.rpTienDichVu = new DevExpress.XtraReports.UI.XRLabel();
            this.TienDichVu = new DevExpress.XtraReports.Parameters.Parameter();
            this.rpTienThuePhong = new DevExpress.XtraReports.UI.XRLabel();
            this.TienThuePhong = new DevExpress.XtraReports.Parameters.Parameter();
            this.lblTienPhong = new DevExpress.XtraReports.UI.XRLabel();
            this.rpTenPhong = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTTTP = new DevExpress.XtraReports.UI.XRLabel();
            this.rpNgayDi = new DevExpress.XtraReports.UI.XRLabel();
            this.NgayDi = new DevExpress.XtraReports.Parameters.Parameter();
            this.rpNgayDen = new DevExpress.XtraReports.UI.XRLabel();
            this.NgayDen = new DevExpress.XtraReports.Parameters.Parameter();
            this.lblNgayDi = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNgayDen = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.rpMaDK = new DevExpress.XtraReports.UI.XRLabel();
            this.MaDK = new DevExpress.XtraReports.Parameters.Parameter();
            this.lblHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.lblChuc = new DevExpress.XtraReports.UI.XRLabel();
            this.lblCamOn = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblTongTien,
            this.rpTongTien,
            this.rpTienDatCoc,
            this.lblTienDatCoc,
            this.lblTienDichVu,
            this.rpTienDichVu,
            this.rpTienThuePhong,
            this.lblTienPhong,
            this.rpTenPhong,
            this.lblTTTP,
            this.rpNgayDi,
            this.rpNgayDen,
            this.lblNgayDi,
            this.lblNgayDen});
            this.Detail.HeightF = 359.4697F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.LocationFloat = new DevExpress.Utils.PointFloat(0F, 329.3041F);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTongTien.SizeF = new System.Drawing.SizeF(152.5478F, 30.1656F);
            this.lblTongTien.StylePriority.UseFont = false;
            this.lblTongTien.Text = "Tổng Tiền:";
            // 
            // rpTongTien
            // 
            this.rpTongTien.AutoWidth = true;
            this.rpTongTien.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.TongTien, "Text", "")});
            this.rpTongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpTongTien.LocationFloat = new DevExpress.Utils.PointFloat(431.7674F, 329.3041F);
            this.rpTongTien.Name = "rpTongTien";
            this.rpTongTien.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.rpTongTien.SizeF = new System.Drawing.SizeF(218.2326F, 30.1656F);
            this.rpTongTien.StylePriority.UseFont = false;
            // 
            // TongTien
            // 
            this.TongTien.Description = "TongTien";
            this.TongTien.Name = "TongTien";
            this.TongTien.Type = typeof(int);
            this.TongTien.ValueInfo = "0";
            // 
            // rpTienDatCoc
            // 
            this.rpTienDatCoc.AutoWidth = true;
            this.rpTienDatCoc.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.TienDatCoc, "Text", "")});
            this.rpTienDatCoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpTienDatCoc.LocationFloat = new DevExpress.Utils.PointFloat(431.7674F, 252.5828F);
            this.rpTienDatCoc.Name = "rpTienDatCoc";
            this.rpTienDatCoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.rpTienDatCoc.SizeF = new System.Drawing.SizeF(218.2326F, 30.1656F);
            this.rpTienDatCoc.StylePriority.UseFont = false;
            // 
            // TienDatCoc
            // 
            this.TienDatCoc.Description = "TienDatCoc";
            this.TienDatCoc.Name = "TienDatCoc";
            this.TienDatCoc.Type = typeof(int);
            this.TienDatCoc.ValueInfo = "0";
            // 
            // lblTienDatCoc
            // 
            this.lblTienDatCoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienDatCoc.LocationFloat = new DevExpress.Utils.PointFloat(0F, 252.5828F);
            this.lblTienDatCoc.Name = "lblTienDatCoc";
            this.lblTienDatCoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTienDatCoc.SizeF = new System.Drawing.SizeF(152.5478F, 30.1656F);
            this.lblTienDatCoc.StylePriority.UseFont = false;
            this.lblTienDatCoc.Text = "Tiền Đặt Cọc:";
            // 
            // lblTienDichVu
            // 
            this.lblTienDichVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienDichVu.LocationFloat = new DevExpress.Utils.PointFloat(0F, 205.6974F);
            this.lblTienDichVu.Name = "lblTienDichVu";
            this.lblTienDichVu.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTienDichVu.SizeF = new System.Drawing.SizeF(152.5478F, 30.1656F);
            this.lblTienDichVu.StylePriority.UseFont = false;
            this.lblTienDichVu.Text = "Tiền Dịch Vụ:";
            // 
            // rpTienDichVu
            // 
            this.rpTienDichVu.AutoWidth = true;
            this.rpTienDichVu.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.TienDichVu, "Text", "")});
            this.rpTienDichVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpTienDichVu.LocationFloat = new DevExpress.Utils.PointFloat(431.7674F, 205.6974F);
            this.rpTienDichVu.Name = "rpTienDichVu";
            this.rpTienDichVu.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.rpTienDichVu.SizeF = new System.Drawing.SizeF(218.2326F, 30.1656F);
            this.rpTienDichVu.StylePriority.UseFont = false;
            // 
            // TienDichVu
            // 
            this.TienDichVu.Description = "TienDichVu";
            this.TienDichVu.Name = "TienDichVu";
            this.TienDichVu.Type = typeof(int);
            this.TienDichVu.ValueInfo = "0";
            // 
            // rpTienThuePhong
            // 
            this.rpTienThuePhong.AutoWidth = true;
            this.rpTienThuePhong.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.TienThuePhong, "Text", "")});
            this.rpTienThuePhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpTienThuePhong.LocationFloat = new DevExpress.Utils.PointFloat(431.7674F, 161.6688F);
            this.rpTienThuePhong.Name = "rpTienThuePhong";
            this.rpTienThuePhong.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.rpTienThuePhong.SizeF = new System.Drawing.SizeF(218.2326F, 30.1656F);
            this.rpTienThuePhong.StylePriority.UseFont = false;
            // 
            // TienThuePhong
            // 
            this.TienThuePhong.Description = "TienThuePhong";
            this.TienThuePhong.Name = "TienThuePhong";
            this.TienThuePhong.Type = typeof(int);
            this.TienThuePhong.ValueInfo = "0";
            // 
            // lblTienPhong
            // 
            this.lblTienPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienPhong.LocationFloat = new DevExpress.Utils.PointFloat(0F, 161.6688F);
            this.lblTienPhong.Name = "lblTienPhong";
            this.lblTienPhong.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTienPhong.SizeF = new System.Drawing.SizeF(152.5478F, 30.1656F);
            this.lblTienPhong.StylePriority.UseFont = false;
            this.lblTienPhong.Text = "Tiền Thuê Phòng:";
            // 
            // rpTenPhong
            // 
            this.rpTenPhong.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpTenPhong.LocationFloat = new DevExpress.Utils.PointFloat(182.8503F, 0F);
            this.rpTenPhong.Name = "rpTenPhong";
            this.rpTenPhong.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.rpTenPhong.SizeF = new System.Drawing.SizeF(171.8471F, 43.30255F);
            this.rpTenPhong.StylePriority.UseFont = false;
            this.rpTenPhong.Text = "rpTenPhong";
            // 
            // lblTTTP
            // 
            this.lblTTTP.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTTP.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.lblTTTP.Name = "lblTTTP";
            this.lblTTTP.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTTTP.SizeF = new System.Drawing.SizeF(182.8503F, 43.30255F);
            this.lblTTTP.StylePriority.UseFont = false;
            this.lblTTTP.Text = "Hóa Đơn Phòng";
            // 
            // rpNgayDi
            // 
            this.rpNgayDi.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.NgayDi, "Text", "")});
            this.rpNgayDi.LocationFloat = new DevExpress.Utils.PointFloat(114.9682F, 107.793F);
            this.rpNgayDi.Name = "rpNgayDi";
            this.rpNgayDi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.rpNgayDi.SizeF = new System.Drawing.SizeF(187.1815F, 23F);
            // 
            // NgayDi
            // 
            this.NgayDi.Description = "NgayDi";
            this.NgayDi.Name = "NgayDi";
            this.NgayDi.ValueInfo = "NgayDi";
            // 
            // rpNgayDen
            // 
            this.rpNgayDen.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.NgayDen, "Text", "")});
            this.rpNgayDen.LocationFloat = new DevExpress.Utils.PointFloat(114.9681F, 75.23885F);
            this.rpNgayDen.Name = "rpNgayDen";
            this.rpNgayDen.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.rpNgayDen.SizeF = new System.Drawing.SizeF(187.1815F, 23F);
            // 
            // NgayDen
            // 
            this.NgayDen.Description = "NgayDen";
            this.NgayDen.Name = "NgayDen";
            this.NgayDen.ValueInfo = "NgayDen";
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDi.LocationFloat = new DevExpress.Utils.PointFloat(0F, 110.1815F);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNgayDi.SizeF = new System.Drawing.SizeF(114.9682F, 20.61146F);
            this.lblNgayDi.StylePriority.UseFont = false;
            this.lblNgayDi.Text = "Ngày Đi  :";
            // 
            // lblNgayDen
            // 
            this.lblNgayDen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDen.LocationFloat = new DevExpress.Utils.PointFloat(0F, 75.23885F);
            this.lblNgayDen.Name = "lblNgayDen";
            this.lblNgayDen.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNgayDen.SizeF = new System.Drawing.SizeF(114.9681F, 23F);
            this.lblNgayDen.StylePriority.UseFont = false;
            this.lblNgayDen.Text = "Ngày Đến :";
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.rpMaDK,
            this.lblHeader});
            this.TopMargin.HeightF = 119.7357F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // rpMaDK
            // 
            this.rpMaDK.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.MaDK, "Text", "")});
            this.rpMaDK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpMaDK.LocationFloat = new DevExpress.Utils.PointFloat(473.4091F, 75.23889F);
            this.rpMaDK.Name = "rpMaDK";
            this.rpMaDK.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.rpMaDK.SizeF = new System.Drawing.SizeF(176.5909F, 44.49681F);
            this.rpMaDK.StylePriority.UseFont = false;
            // 
            // MaDK
            // 
            this.MaDK.Description = "MaDK";
            this.MaDK.Name = "MaDK";
            this.MaDK.ValueInfo = "MaDK";
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.LocationFloat = new DevExpress.Utils.PointFloat(95.5414F, 0F);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblHeader.SizeF = new System.Drawing.SizeF(425.4777F, 49.27388F);
            this.lblHeader.StylePriority.UseFont = false;
            this.lblHeader.Text = "Hóa Đơn Thanh Toán Tiền Phòng";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblChuc,
            this.lblCamOn});
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblChuc
            // 
            this.lblChuc.AutoWidth = true;
            this.lblChuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuc.LocationFloat = new DevExpress.Utils.PointFloat(0F, 57.75483F);
            this.lblChuc.Name = "lblChuc";
            this.lblChuc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblChuc.SizeF = new System.Drawing.SizeF(650F, 23.86942F);
            this.lblChuc.StylePriority.UseFont = false;
            this.lblChuc.Text = "Chúc bạn một một ngày làm việc vui vẻ !";
            // 
            // lblCamOn
            // 
            this.lblCamOn.AutoWidth = true;
            this.lblCamOn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamOn.LocationFloat = new DevExpress.Utils.PointFloat(3.644615E-05F, 33.88537F);
            this.lblCamOn.Name = "lblCamOn";
            this.lblCamOn.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblCamOn.SizeF = new System.Drawing.SizeF(650F, 23.86942F);
            this.lblCamOn.StylePriority.UseFont = false;
            this.lblCamOn.Text = "Cảm ơn bạn đã sử dụng dịch vụ của khách sạn";
            // 
            // TraPhongReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 120, 100);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.MaDK,
            this.NgayDen,
            this.NgayDi,
            this.TienThuePhong,
            this.TienDichVu,
            this.TienDatCoc,
            this.TongTien});
            this.Version = "14.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel lblHeader;
        private DevExpress.XtraReports.UI.XRLabel lblTongTien;
        private DevExpress.XtraReports.UI.XRLabel rpTongTien;
        private DevExpress.XtraReports.UI.XRLabel rpTienDatCoc;
        private DevExpress.XtraReports.UI.XRLabel lblTienDatCoc;
        private DevExpress.XtraReports.UI.XRLabel lblTienDichVu;
        private DevExpress.XtraReports.UI.XRLabel rpTienDichVu;
        private DevExpress.XtraReports.UI.XRLabel rpTienThuePhong;
        private DevExpress.XtraReports.UI.XRLabel lblTienPhong;
        private DevExpress.XtraReports.UI.XRLabel rpTenPhong;
        private DevExpress.XtraReports.UI.XRLabel lblTTTP;
        private DevExpress.XtraReports.UI.XRLabel rpNgayDi;
        private DevExpress.XtraReports.UI.XRLabel rpNgayDen;
        private DevExpress.XtraReports.UI.XRLabel lblNgayDi;
        private DevExpress.XtraReports.UI.XRLabel lblNgayDen;
        private DevExpress.XtraReports.UI.XRLabel rpMaDK;
        private DevExpress.XtraReports.UI.XRLabel lblChuc;
        private DevExpress.XtraReports.UI.XRLabel lblCamOn;
        private DevExpress.XtraReports.Parameters.Parameter TongTien;
        private DevExpress.XtraReports.Parameters.Parameter TienDatCoc;
        private DevExpress.XtraReports.Parameters.Parameter TienDichVu;
        private DevExpress.XtraReports.Parameters.Parameter TienThuePhong;
        private DevExpress.XtraReports.Parameters.Parameter NgayDi;
        private DevExpress.XtraReports.Parameters.Parameter NgayDen;
        private DevExpress.XtraReports.Parameters.Parameter MaDK;
    }
}
