namespace QuanLyKhachSanNew.FrmChild
{
    partial class FrmDoiMK
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
            this.lblMKCu = new DevExpress.XtraEditors.LabelControl();
            this.teMKCu = new DevExpress.XtraEditors.TextEdit();
            this.teMKMoi = new DevExpress.XtraEditors.TextEdit();
            this.lblMKMoi = new DevExpress.XtraEditors.LabelControl();
            this.teMKMoiLai = new DevExpress.XtraEditors.TextEdit();
            this.lblMKMoiLai = new DevExpress.XtraEditors.LabelControl();
            this.btnDoiMK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCane = new DevExpress.XtraEditors.SimpleButton();
            this.lblCaption = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.teMKCu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMKMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMKMoiLai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMKCu
            // 
            this.lblMKCu.Location = new System.Drawing.Point(42, 30);
            this.lblMKCu.Name = "lblMKCu";
            this.lblMKCu.Size = new System.Drawing.Size(61, 13);
            this.lblMKCu.TabIndex = 0;
            this.lblMKCu.Text = "Mật Khẩu Cũ";
            // 
            // teMKCu
            // 
            this.teMKCu.Location = new System.Drawing.Point(175, 27);
            this.teMKCu.Name = "teMKCu";
            this.teMKCu.Properties.UseSystemPasswordChar = true;
            this.teMKCu.Size = new System.Drawing.Size(156, 20);
            this.teMKCu.TabIndex = 1;
            // 
            // teMKMoi
            // 
            this.teMKMoi.Location = new System.Drawing.Point(175, 78);
            this.teMKMoi.Name = "teMKMoi";
            this.teMKMoi.Properties.UseSystemPasswordChar = true;
            this.teMKMoi.Size = new System.Drawing.Size(156, 20);
            this.teMKMoi.TabIndex = 3;
            // 
            // lblMKMoi
            // 
            this.lblMKMoi.Location = new System.Drawing.Point(42, 81);
            this.lblMKMoi.Name = "lblMKMoi";
            this.lblMKMoi.Size = new System.Drawing.Size(64, 13);
            this.lblMKMoi.TabIndex = 2;
            this.lblMKMoi.Text = "Mật Khẩu Mới";
            // 
            // teMKMoiLai
            // 
            this.teMKMoiLai.Location = new System.Drawing.Point(175, 128);
            this.teMKMoiLai.Name = "teMKMoiLai";
            this.teMKMoiLai.Properties.UseSystemPasswordChar = true;
            this.teMKMoiLai.Size = new System.Drawing.Size(156, 20);
            this.teMKMoiLai.TabIndex = 5;
            // 
            // lblMKMoiLai
            // 
            this.lblMKMoiLai.Location = new System.Drawing.Point(42, 131);
            this.lblMKMoiLai.Name = "lblMKMoiLai";
            this.lblMKMoiLai.Size = new System.Drawing.Size(108, 13);
            this.lblMKMoiLai.TabIndex = 4;
            this.lblMKMoiLai.Text = "Nhập Lại Mật Khẩu Mới";
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Location = new System.Drawing.Point(103, 190);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(75, 23);
            this.btnDoiMK.TabIndex = 6;
            this.btnDoiMK.Text = "Thực Hiện";
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // btnCane
            // 
            this.btnCane.Location = new System.Drawing.Point(217, 190);
            this.btnCane.Name = "btnCane";
            this.btnCane.Size = new System.Drawing.Size(75, 23);
            this.btnCane.TabIndex = 7;
            this.btnCane.Text = "Thoát";
            this.btnCane.Click += new System.EventHandler(this.btnCane_Click);
            // 
            // lblCaption
            // 
            this.lblCaption.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(103, 245);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(50, 14);
            this.lblCaption.TabIndex = 8;
            this.lblCaption.Text = "Sucsset";
            // 
            // FrmDoiMK
            // 
            this.AcceptButton = this.btnDoiMK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 271);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.btnCane);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.teMKMoiLai);
            this.Controls.Add(this.lblMKMoiLai);
            this.Controls.Add(this.teMKMoi);
            this.Controls.Add(this.lblMKMoi);
            this.Controls.Add(this.teMKCu);
            this.Controls.Add(this.lblMKCu);
            this.Name = "FrmDoiMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDoiMK_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.teMKCu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMKMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMKMoiLai.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblMKCu;
        private DevExpress.XtraEditors.TextEdit teMKCu;
        private DevExpress.XtraEditors.TextEdit teMKMoi;
        private DevExpress.XtraEditors.LabelControl lblMKMoi;
        private DevExpress.XtraEditors.TextEdit teMKMoiLai;
        private DevExpress.XtraEditors.LabelControl lblMKMoiLai;
        private DevExpress.XtraEditors.SimpleButton btnDoiMK;
        private DevExpress.XtraEditors.SimpleButton btnCane;
        private DevExpress.XtraEditors.LabelControl lblCaption;
    }
}