namespace QuanLyKhachSanNew.FrmChild
{
    partial class FrmTrangThaiPhong
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
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            this.gcTTPhong = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.gcTTPhong)).BeginInit();
            this.gcTTPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcTTPhong
            // 
            this.gcTTPhong.Controls.Add(this.galleryControlClient1);
            this.gcTTPhong.DesignGalleryGroupIndex = 0;
            this.gcTTPhong.DesignGalleryItemIndex = 0;
            this.gcTTPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // galleryControlGallery1
            // 
            this.gcTTPhong.Gallery.AllowHoverImages = true;
            this.gcTTPhong.Gallery.AllowMarqueeSelection = true;
            galleryItemGroup1.Caption = "Quản Lý Trạng Thái Phòng";
            this.gcTTPhong.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.gcTTPhong.Gallery.HoverImageSize = new System.Drawing.Size(90, 90);
            this.gcTTPhong.Gallery.ImageSize = new System.Drawing.Size(80, 80);
            this.gcTTPhong.Gallery.ShowItemText = true;
            this.gcTTPhong.Gallery.ItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.galleryControlGallery1_ItemClick);
            this.gcTTPhong.Location = new System.Drawing.Point(0, 0);
            this.gcTTPhong.Name = "gcTTPhong";
            this.gcTTPhong.Size = new System.Drawing.Size(843, 404);
            this.gcTTPhong.TabIndex = 0;
            this.gcTTPhong.Text = "Trạng Thái";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.gcTTPhong;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(822, 400);
            // 
            // FrmTrangThaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 404);
            this.Controls.Add(this.gcTTPhong);
            this.Name = "FrmTrangThaiPhong";
            this.Text = "Trạng Thái Phòng";
            this.Load += new System.EventHandler(this.FrmTrangThaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcTTPhong)).EndInit();
            this.gcTTPhong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.GalleryControl gcTTPhong;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
    }
}