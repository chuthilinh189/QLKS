USE [master]
GO
/****** Object:  Database [QLKHACHSAN]    Script Date: 5/25/2022 14:32:04 ******/
CREATE DATABASE [QLKHACHSAN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLKHACHSAN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLKHACHSAN.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLKHACHSAN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLKHACHSAN_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLKHACHSAN] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLKHACHSAN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLKHACHSAN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLKHACHSAN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLKHACHSAN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLKHACHSAN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLKHACHSAN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLKHACHSAN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLKHACHSAN] SET  MULTI_USER 
GO
ALTER DATABASE [QLKHACHSAN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLKHACHSAN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLKHACHSAN] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLKHACHSAN] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLKHACHSAN] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLKHACHSAN] SET QUERY_STORE = OFF
GO
USE [QLKHACHSAN]
GO
/****** Object:  Table [dbo].[anhphong]    Script Date: 5/25/2022 14:32:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[anhphong](
	[ap_ma] [varchar](50) NOT NULL,
	[ap_maphong] [varchar](50) NULL,
	[link] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ap_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chucvu]    Script Date: 5/25/2022 14:32:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chucvu](
	[cv_ma] [varchar](50) NOT NULL,
	[cv_ten] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cv_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ctphongdat]    Script Date: 5/25/2022 14:32:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ctphongdat](
	[ctdt_ma] [varchar](50) NOT NULL,
	[ctdp_madp] [varchar](50) NOT NULL,
	[ctdp_maphong] [varchar](50) NOT NULL,
	[ctdp_ngaynhan] [datetime] NOT NULL,
	[ctdp_ngaytra] [datetime] NOT NULL,
	[ctdp_thanhtien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ctdt_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ctthuephong]    Script Date: 5/25/2022 14:32:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ctthuephong](
	[cttp_ma] [varchar](50) NOT NULL,
	[cttp_matp] [varchar](50) NOT NULL,
	[cttp_maphong] [varchar](50) NOT NULL,
	[cttp_ngaynhan] [datetime] NOT NULL,
	[cttp_ngaytra] [datetime] NULL,
	[cttp_thanhtien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cttp_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datphong]    Script Date: 5/25/2022 14:32:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datphong](
	[dp_ma] [varchar](50) NOT NULL,
	[dp_manv] [varchar](50) NOT NULL,
	[dp_makh] [varchar](50) NOT NULL,
	[dp_ngaydat] [datetime] NOT NULL,
	[dp_ngayden] [datetime] NOT NULL,
	[dp_ngaydi] [datetime] NOT NULL,
	[dp_tiendatcoc] [int] NULL,
	[dp_soluong] [int] NULL,
	[dp_ghichu] [nvarchar](200) NULL,
	[dp_trangthaithanhtoan] [bit] NULL,
 CONSTRAINT [PK__datphong__B5B14B748DE03C7D] PRIMARY KEY CLUSTERED 
(
	[dp_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 5/25/2022 14:32:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachhang](
	[kh_ma] [varchar](50) NOT NULL,
	[kh_hoten] [nvarchar](50) NOT NULL,
	[kh_cmnd] [varchar](20) NOT NULL,
	[kh_sdt] [varchar](20) NOT NULL,
	[kh_email] [varchar](50) NULL,
	[kh_diachi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[kh_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[loaiphong]    Script Date: 5/25/2022 14:32:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaiphong](
	[lp_ma] [varchar](50) NOT NULL,
	[lp_ten] [nvarchar](50) NOT NULL,
	[lp_giaphong] [int] NOT NULL,
	[lp_soluong] [int] NULL,
	[lp_solandat] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[lp_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 5/25/2022 14:32:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[nv_ma] [varchar](50) NOT NULL,
	[nv_macv] [varchar](50) NOT NULL,
	[nv_hoten] [nvarchar](50) NOT NULL,
	[nv_ngaysinh] [nvarchar](20) NOT NULL,
	[nv_gioitinh] [bit] NOT NULL,
	[nv_sdt] [varchar](20) NOT NULL,
	[nv_cmnd] [varchar](20) NOT NULL,
	[nv_diachi] [nvarchar](50) NOT NULL,
	[nv_email] [varchar](50) NULL,
	[nv_khoa] [bit] NULL,
	[nv_xoa] [bit] NULL,
	[nv_tdn] [varchar](50) NOT NULL,
	[nv_matkhau] [varchar](50) NOT NULL,
	[nv_maquyen] [char](1) NULL,
	[nv_fileanh] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[nv_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phong]    Script Date: 5/25/2022 14:32:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phong](
	[p_ma] [varchar](50) NOT NULL,
	[p_malp] [varchar](50) NOT NULL,
	[p_tinhtrang] [smallint] NULL,
	[p_sophong] [nvarchar](50) NULL,
	[p_solandat] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[p_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phong_ttb]    Script Date: 5/25/2022 14:32:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phong_ttb](
	[ttbp_ma] [varchar](50) NOT NULL,
	[ttbp_mattb] [varchar](50) NOT NULL,
	[ttbp_maphong] [varchar](50) NOT NULL,
	[ttbp_soluong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ttbp_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[quyen]    Script Date: 5/25/2022 14:32:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[quyen](
	[q_ma] [char](1) NOT NULL,
	[q_ten] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[q_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[thuephong]    Script Date: 5/25/2022 14:32:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thuephong](
	[tp_ma] [varchar](50) NOT NULL,
	[tp_manv] [varchar](50) NOT NULL,
	[tp_makh] [varchar](50) NOT NULL,
	[tp_madp] [varchar](50) NULL,
	[tp_ngayden] [datetime] NOT NULL,
	[tp_ngaydidukien] [datetime] NOT NULL,
	[tp_ngaydi] [datetime] NULL,
	[tp_slphong] [int] NULL,
	[tp_tienthanhtoan] [int] NULL,
	[tp_tinhtrangtt] [bit] NULL,
	[tp_ghichu] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[tp_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[trangthietbi]    Script Date: 5/25/2022 14:32:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[trangthietbi](
	[ttb_ma] [varchar](50) NOT NULL,
	[ttb_ten] [nvarchar](100) NOT NULL,
	[ttb_dongia] [int] NULL,
	[ttb_donvitinh] [nvarchar](20) NULL,
	[ttb_soluong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ttb_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[chucvu] ([cv_ma], [cv_ten]) VALUES (N'78BTGB72DE459B4A211038DEF16886EF', N'Giám Đốc')
INSERT [dbo].[chucvu] ([cv_ma], [cv_ten]) VALUES (N'BT562B72DE459B4A211038DEF16886EF', N'Bảo Vệ')
INSERT [dbo].[chucvu] ([cv_ma], [cv_ten]) VALUES (N'GT452B72DE459B4A211038DEF16886EF', N'Phó Giám Đốc')
INSERT [dbo].[chucvu] ([cv_ma], [cv_ten]) VALUES (N'GTS56B72DE459B4A211038DEF16886EF', N'Thu Ngân')
INSERT [dbo].[chucvu] ([cv_ma], [cv_ten]) VALUES (N'HUNH2B72DE459B4A211038DEF16886EF', N'Lễ Tân')
GO
INSERT [dbo].[khachhang] ([kh_ma], [kh_hoten], [kh_cmnd], [kh_sdt], [kh_email], [kh_diachi]) VALUES (N'12MK2B72DE459B4A211038DEF16886EF', N'Tăng Đức Thịnh', N'183746284', N'0326363892', N'thinhlun@gmail.com', N'Đà Nẵng')
INSERT [dbo].[khachhang] ([kh_ma], [kh_hoten], [kh_cmnd], [kh_sdt], [kh_email], [kh_diachi]) VALUES (N'2BC92B72DE459B4A211038DEF16886EF', N'Hoàng Văn Bách', N'198672310', N'0385477769', N'bachct@gmail.com', N'Thanh Hóa')
INSERT [dbo].[khachhang] ([kh_ma], [kh_hoten], [kh_cmnd], [kh_sdt], [kh_email], [kh_diachi]) VALUES (N'67G92B72DE459B4A2110383EF16886EF', N'Nguyễn Hoài Thương', N'1246723743', N'0238491646', N'thuongct@gmail.com', N'Bà Rịa - Vũng Tàu')
INSERT [dbo].[khachhang] ([kh_ma], [kh_hoten], [kh_cmnd], [kh_sdt], [kh_email], [kh_diachi]) VALUES (N'78GT2B72DE459B4A211038DEF16886EF', N'Võ Thi Thục Hiền', N'134838374', N'0326265847', N'thuchien@gmail.com', N'Thừa Thiên Huế')
INSERT [dbo].[khachhang] ([kh_ma], [kh_hoten], [kh_cmnd], [kh_sdt], [kh_email], [kh_diachi]) VALUES (N'BH892B72DE459B4A211038DEF16886EF', N'Trịnh Thị Thu Thảo', N'240293528', N'0248488466', N'thaohu@gmail.com', N'Hải Phòng')
INSERT [dbo].[khachhang] ([kh_ma], [kh_hoten], [kh_cmnd], [kh_sdt], [kh_email], [kh_diachi]) VALUES (N'HI992B72DE459B4A211038DEF16886EF', N'Nguyễn Văn Lâm', N'614632571', N'0357362523', N'lamlam@gmail.com', N'Hải Dương')
GO
INSERT [dbo].[loaiphong] ([lp_ma], [lp_ten], [lp_giaphong], [lp_soluong], [lp_solandat]) VALUES (N'623G2G3298392HF289F9F4FG33G593G', N'Suite', 750000, 0, 0)
INSERT [dbo].[loaiphong] ([lp_ma], [lp_ten], [lp_giaphong], [lp_soluong], [lp_solandat]) VALUES (N'78922B72DE459B4A211038DEF16886EF', N'Luxury', 450000, 0, 0)
INSERT [dbo].[loaiphong] ([lp_ma], [lp_ten], [lp_giaphong], [lp_soluong], [lp_solandat]) VALUES (N'89432B72DE459B4A211038DEF16886EF', N'Superio', 500000, 0, 0)
INSERT [dbo].[loaiphong] ([lp_ma], [lp_ten], [lp_giaphong], [lp_soluong], [lp_solandat]) VALUES (N'89FT2B72DE459B4A211038DEF16886EF', N'Standard', 350000, 0, 0)
INSERT [dbo].[loaiphong] ([lp_ma], [lp_ten], [lp_giaphong], [lp_soluong], [lp_solandat]) VALUES (N'HUN41872DE459B4A211038DEF16886EF', N'Star5', 1000000, 0, 0)
GO
INSERT [dbo].[nhanvien] ([nv_ma], [nv_macv], [nv_hoten], [nv_ngaysinh], [nv_gioitinh], [nv_sdt], [nv_cmnd], [nv_diachi], [nv_email], [nv_khoa], [nv_xoa], [nv_tdn], [nv_matkhau], [nv_maquyen], [nv_fileanh]) VALUES (N'78237G2873G28372G2238792', N'BT562B72DE459B4A211038DEF16886EF', N'Lê Quốc Bảo', N'25/12/1978', 1, N'01223503054', N'212555669', N'Cẩm Lệ, Đà Nẵng', N'quocbao@gmail.com', 0, 0, N'baove1', N'E10ADC3949BA59ABBE56E057F20F883E', N'C', N'')
INSERT [dbo].[nhanvien] ([nv_ma], [nv_macv], [nv_hoten], [nv_ngaysinh], [nv_gioitinh], [nv_sdt], [nv_cmnd], [nv_diachi], [nv_email], [nv_khoa], [nv_xoa], [nv_tdn], [nv_matkhau], [nv_maquyen], [nv_fileanh]) VALUES (N'GF287YFF98F9H3FUDIVEIUFUIFWE0328378347543', N'GT452B72DE459B4A211038DEF16886EF', N'Nguyễn Anh Thư', N'02/06/1988', 1, N'01223503053', N'212555668', N'Thanh Khê, Đà Nẵng', N'anhthu@gmail.com', 0, 0, N'phogiamdoc1', N'E10ADC3949BA59ABBE56E057F20F883E', N'A', N'')
INSERT [dbo].[nhanvien] ([nv_ma], [nv_macv], [nv_hoten], [nv_ngaysinh], [nv_gioitinh], [nv_sdt], [nv_cmnd], [nv_diachi], [nv_email], [nv_khoa], [nv_xoa], [nv_tdn], [nv_matkhau], [nv_maquyen], [nv_fileanh]) VALUES (N'HY672B72DE459B4A211038DEF16886EF', N'78BTGB72DE459B4A211038DEF16886EF', N'Nguyễn Hoàng Anh', N'02/02/1985', 0, N'01223503052', N'212555666', N'Đà Nẵng', N'hoanganh@gmail.com', 0, 0, N'giamdoc1', N'E10ADC3949BA59ABBE56E057F20F883E', N'A', N'')
GO
INSERT [dbo].[quyen] ([q_ma], [q_ten]) VALUES (N'A', N'Quản Trị')
INSERT [dbo].[quyen] ([q_ma], [q_ten]) VALUES (N'B', N'Lễ Tân')
INSERT [dbo].[quyen] ([q_ma], [q_ten]) VALUES (N'C', N'Thu Ngân')
INSERT [dbo].[quyen] ([q_ma], [q_ten]) VALUES (N'D', N'Nhân Viên Kỹ Thuật')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__khachhan__0B8A8FEAACA96743]    Script Date: 5/25/2022 14:32:05 ******/
ALTER TABLE [dbo].[khachhang] ADD UNIQUE NONCLUSTERED 
(
	[kh_cmnd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__nhanvien__89DC6DC361D65A1D]    Script Date: 5/25/2022 14:32:05 ******/
ALTER TABLE [dbo].[nhanvien] ADD UNIQUE NONCLUSTERED 
(
	[nv_tdn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[anhphong]  WITH CHECK ADD FOREIGN KEY([ap_maphong])
REFERENCES [dbo].[phong] ([p_ma])
GO
ALTER TABLE [dbo].[ctphongdat]  WITH CHECK ADD  CONSTRAINT [FK__ctphongda__ctdp___3B75D760] FOREIGN KEY([ctdp_madp])
REFERENCES [dbo].[datphong] ([dp_ma])
GO
ALTER TABLE [dbo].[ctphongdat] CHECK CONSTRAINT [FK__ctphongda__ctdp___3B75D760]
GO
ALTER TABLE [dbo].[ctphongdat]  WITH CHECK ADD FOREIGN KEY([ctdp_maphong])
REFERENCES [dbo].[phong] ([p_ma])
GO
ALTER TABLE [dbo].[ctthuephong]  WITH CHECK ADD FOREIGN KEY([cttp_matp])
REFERENCES [dbo].[thuephong] ([tp_ma])
GO
ALTER TABLE [dbo].[ctthuephong]  WITH CHECK ADD FOREIGN KEY([cttp_maphong])
REFERENCES [dbo].[phong] ([p_ma])
GO
ALTER TABLE [dbo].[datphong]  WITH CHECK ADD  CONSTRAINT [FK__datphong__dp_mak__38996AB5] FOREIGN KEY([dp_makh])
REFERENCES [dbo].[khachhang] ([kh_ma])
GO
ALTER TABLE [dbo].[datphong] CHECK CONSTRAINT [FK__datphong__dp_mak__38996AB5]
GO
ALTER TABLE [dbo].[datphong]  WITH CHECK ADD  CONSTRAINT [FK__datphong__dp_man__37A5467C] FOREIGN KEY([dp_manv])
REFERENCES [dbo].[nhanvien] ([nv_ma])
GO
ALTER TABLE [dbo].[datphong] CHECK CONSTRAINT [FK__datphong__dp_man__37A5467C]
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD FOREIGN KEY([nv_macv])
REFERENCES [dbo].[chucvu] ([cv_ma])
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD FOREIGN KEY([nv_maquyen])
REFERENCES [dbo].[quyen] ([q_ma])
GO
ALTER TABLE [dbo].[phong]  WITH CHECK ADD FOREIGN KEY([p_malp])
REFERENCES [dbo].[loaiphong] ([lp_ma])
GO
ALTER TABLE [dbo].[phong_ttb]  WITH CHECK ADD FOREIGN KEY([ttbp_mattb])
REFERENCES [dbo].[trangthietbi] ([ttb_ma])
GO
ALTER TABLE [dbo].[phong_ttb]  WITH CHECK ADD FOREIGN KEY([ttbp_maphong])
REFERENCES [dbo].[phong] ([p_ma])
GO
ALTER TABLE [dbo].[thuephong]  WITH CHECK ADD FOREIGN KEY([tp_manv])
REFERENCES [dbo].[nhanvien] ([nv_ma])
GO
ALTER TABLE [dbo].[thuephong]  WITH CHECK ADD FOREIGN KEY([tp_makh])
REFERENCES [dbo].[khachhang] ([kh_ma])
GO
ALTER TABLE [dbo].[thuephong]  WITH CHECK ADD  CONSTRAINT [FK__thuephong__tp_ma__412EB0B6] FOREIGN KEY([tp_madp])
REFERENCES [dbo].[datphong] ([dp_ma])
GO
ALTER TABLE [dbo].[thuephong] CHECK CONSTRAINT [FK__thuephong__tp_ma__412EB0B6]
GO
/****** Object:  StoredProcedure [dbo].[getAllNhanviens]    Script Date: 5/25/2022 14:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getAllNhanviens]
as
SELECT * FROM nhanvien
LEFT JOIN chucvu ON nhanvien.nv_macv = chucvu.cv_ma
LEFT JOIN quyen ON nhanvien.nv_maquyen = quyen.q_ma
GO
/****** Object:  StoredProcedure [dbo].[insertNhanvien]    Script Date: 5/25/2022 14:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertNhanvien]
@nv_ma varchar(50),
@nv_macv varchar(50),
@nv_hoten nvarchar(50),
@nv_ngaysinh nvarchar(20),
@nv_gioitinh bit,
@nv_sdt varchar(20),
@nv_cmnd varchar(20),
@nv_diachi nvarchar(50),
@nv_email varchar(50),
@nv_khoa bit,
@nv_xoa bit,
@nv_tdn varchar(50),
@nv_matkhau varchar(50),
@nv_maquyen char(1),
@nv_fileanh nvarchar(50)
AS
INSERT INTO nhanvien(nv_ma,  nv_macv, nv_hoten, nv_ngaysinh, nv_gioitinh, nv_sdt, nv_cmnd, nv_diachi, nv_email, nv_khoa, nv_xoa, nv_tdn, nv_matkhau, nv_maquyen, nv_fileanh)
VALUES (@nv_ma, @nv_macv, @nv_hoten, @nv_ngaysinh, @nv_gioitinh, @nv_sdt, @nv_cmnd, @nv_diachi, @nv_email, @nv_khoa, @nv_xoa,@nv_tdn, @nv_matkhau, @nv_maquyen, @nv_fileanh)
GO
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 5/25/2022 14:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Login]
@tdn varchar(50),
@matkhau varchar(50)
as
SELECT * FROM nhanvien 
LEFT JOIN chucvu ON nhanvien.nv_macv = chucvu.cv_ma
LEFT JOIN quyen ON nhanvien.nv_maquyen = quyen.q_ma
WHERE LOWER(nv_tdn) = @tdn and nv_matkhau = @matkhau
and nv_khoa != 1 and nv_xoa != 1
GO
/****** Object:  StoredProcedure [dbo].[updateNhanvien]    Script Date: 5/25/2022 14:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[updateNhanvien]
@nv_ma varchar(50),
@nv_macv varchar(50),
@nv_hoten nvarchar(50),
@nv_ngaysinh nvarchar(20),
@nv_gioitinh bit,
@nv_sdt varchar(20),
@nv_cmnd varchar(20),
@nv_diachi nvarchar(50),
@nv_email varchar(50),
@nv_khoa bit,
@nv_xoa bit,
@nv_tdn varchar(50),
@nv_matkhau varchar(50),
@nv_maquyen char(1),
@nv_fileanh nvarchar(50)
AS
IF(@nv_matkhau='')
BEGIN
	UPDATE nhanvien SET nv_macv=@nv_macv, nv_hoten=@nv_hoten, nv_ngaysinh=@nv_ngaysinh, nv_gioitinh=@nv_gioitinh, nv_sdt=@nv_sdt, nv_cmnd=@nv_cmnd, nv_diachi=@nv_diachi, nv_email=@nv_email, nv_khoa=@nv_khoa, nv_xoa=@nv_xoa, nv_maquyen=@nv_maquyen, nv_fileanh=@nv_fileanh
	WHERE nv_ma=@nv_ma
END
ELSE
BEGIN
	UPDATE nhanvien SET nv_macv=@nv_macv, nv_hoten=@nv_hoten, nv_ngaysinh=@nv_ngaysinh, nv_gioitinh=@nv_gioitinh, nv_sdt=@nv_sdt, nv_cmnd=@nv_cmnd, nv_diachi=@nv_diachi, nv_email=@nv_email, nv_khoa=@nv_khoa, nv_xoa=@nv_xoa, nv_matkhau=@nv_matkhau, nv_maquyen=@nv_maquyen, nv_fileanh=@nv_fileanh
	WHERE nv_ma=@nv_ma
END
GO
USE [master]
GO
ALTER DATABASE [QLKHACHSAN] SET  READ_WRITE 
GO
