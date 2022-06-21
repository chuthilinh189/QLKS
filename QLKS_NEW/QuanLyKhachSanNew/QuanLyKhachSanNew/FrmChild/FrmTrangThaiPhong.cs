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
using AppCode.Business;
using AppCode.Entities;

namespace QuanLyKhachSanNew.FrmChild
{
    public partial class FrmTrangThaiPhong : DevExpress.XtraEditors.XtraForm
    {
        public FrmTrangThaiPhong()
        {
            InitializeComponent();
        }

        private void FrmTrangThaiPhong_Load(object sender, EventArgs e)
        {
            String pathImg = @"..//..//Img/";
            String pic1 = "home-3-icon.png";
            String pic2 = "home-11-icon.png";
            String pic3 = "home-2-icon.png";
            List<EtblPhong> listPhong = new List<EtblPhong>();
            listPhong = BtblPhong.ListAll();

            int i = 0;
            foreach (EtblPhong phong in listPhong)
            {
                String pic = pic1;
                if (isDaDangKy(phong.MaPhong))
                {
                    pic = pic2;
                }
                else 
                {
                    if (isDaNhanPhong(phong.MaPhong)) 
                    {
                        pic = pic3;
                    }
                }
                gcTTPhong.Gallery.Groups[0].Items.Add(new DevExpress.XtraBars.Ribbon.GalleryItem(new Bitmap(pathImg+pic), phong.MaPhong, phong.LoaiPhong));
                gcTTPhong.Gallery.Groups[0].Items[i].HoverImage = gcTTPhong.Gallery.Groups[0].Items[i].Image;
                i++;
            }
        }
        /// <summary>
        /// Kiểm tra Phòng Đăng Ký Chưa Nhận
        /// </summary>
        /// <param name="_maP">maPhong</param>
        /// <returns>boolean</returns>
        private Boolean isDaDangKy(String _maP) 
        {
            List<EtblPhong> listPhong = new List<EtblPhong>();
            listPhong = BtblPhong.ListAll_DaDangKy();
            foreach (EtblPhong phong in listPhong) 
            {
                if (phong.MaPhong == _maP)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Kiểm tra xem Phòng Đang Ở
        /// </summary>
        /// <param name="_maP">maP</param>
        /// <returns>Boolean</returns>
        private Boolean isDaNhanPhong(String _maP) 
        {
            List<EtblPhong> listPhong = new List<EtblPhong>();
            listPhong = BtblPhong.ListAll_DaNhanPhong();
            foreach (EtblPhong phong in listPhong)
            {
                if (phong.MaPhong == _maP)
                    return true;
            }
            return false;
        }


        private void galleryControlGallery1_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            //MessageBox.Show(e.Item.Caption);
            FrmThongTinPhong ttPhong = new FrmThongTinPhong(e.Item.Caption);
            ttPhong.ShowDialog();
        }
    }
}