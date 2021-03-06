USE [master]
GO
/****** Object:  Database [QuanLyKhachSan]    Script Date: 6/21/2022 08:16:40 ******/
CREATE DATABASE [QuanLyKhachSan]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyKhachSan', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyKhachSan_Mdf.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyKhachSan_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyKhachSan_Log.ldf' , SIZE = 5120KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyKhachSan] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyKhachSan].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyKhachSan] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyKhachSan] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyKhachSan] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyKhachSan] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyKhachSan] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyKhachSan] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyKhachSan] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyKhachSan] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyKhachSan] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyKhachSan] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyKhachSan] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyKhachSan] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyKhachSan] SET QUERY_STORE = OFF
GO
USE [QuanLyKhachSan]
GO
/****** Object:  Table [dbo].[tblChucVu]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChucVu](
	[MaCV] [nvarchar](50) NOT NULL,
	[Khu] [int] NOT NULL,
	[TenDonVi] [nvarchar](50) NULL,
	[ChucVu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblChucVu] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDangKy]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDangKy](
	[MaDK] [nvarchar](50) NOT NULL,
	[MaKhach] [nvarchar](50) NULL,
	[MaPhong] [nvarchar](50) NULL,
	[NgayDangKy] [smalldatetime] NULL,
	[NgayDen] [smalldatetime] NULL,
	[NgayDi] [smalldatetime] NULL,
	[TienDat] [int] NULL,
	[SoNguoi] [int] NULL,
	[NgiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblDangKy] PRIMARY KEY CLUSTERED 
(
	[MaDK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDichVu]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDichVu](
	[MaDV] [nvarchar](50) NOT NULL,
	[TenDV] [nvarchar](50) NOT NULL,
	[GiaTien] [int] NOT NULL,
 CONSTRAINT [PK_tblDichVu] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhachHang](
	[MaKhach] [nvarchar](50) NOT NULL,
	[HoDem] [nvarchar](50) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[NgaySinh] [smalldatetime] NOT NULL,
	[CMND] [nvarchar](50) NOT NULL,
	[QuocTich] [nvarchar](50) NOT NULL,
	[NghiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblKhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[MaNV] [nvarchar](50) NOT NULL,
	[MaCV] [nvarchar](50) NOT NULL,
	[HoDem] [nvarchar](50) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[NgaySinh] [smalldatetime] NOT NULL,
	[CMND] [nvarchar](50) NOT NULL,
	[NghiChu] [nvarchar](50) NULL,
	[MatKhau] [varchar](50) NULL,
 CONSTRAINT [PK_tblNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhong]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhong](
	[MaPhong] [nvarchar](50) NOT NULL,
	[TenPhong] [nvarchar](50) NOT NULL,
	[LoaiPhong] [nvarchar](50) NOT NULL,
	[Gia] [int] NOT NULL,
 CONSTRAINT [PK_tblPhong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSDDV]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSDDV](
	[MaDK] [nvarchar](50) NOT NULL,
	[MaDV] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NULL,
	[NgaySuDung] [smalldatetime] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_tblSDDV_1] PRIMARY KEY CLUSTERED 
(
	[MaDK] ASC,
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblThanhToan]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblThanhToan](
	[MaDK] [nvarchar](50) NOT NULL,
	[MaPhong] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NOT NULL,
	[NgayThanhToan] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_tblThanhToan] PRIMARY KEY CLUSTERED 
(
	[MaDK] ASC,
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblChucVu] ([MaCV], [Khu], [TenDonVi], [ChucVu]) VALUES (N'MCV01', 1, N'Phòng Nhân Sự', N'Phó Phòng')
INSERT [dbo].[tblChucVu] ([MaCV], [Khu], [TenDonVi], [ChucVu]) VALUES (N'MCV02', 2, N'Phòng Dịch Vụ', N'Trưởng Phòng')
INSERT [dbo].[tblChucVu] ([MaCV], [Khu], [TenDonVi], [ChucVu]) VALUES (N'MCV03', 3, N'Phòng Lễ Tân', N'Trưởng Phòng')
INSERT [dbo].[tblChucVu] ([MaCV], [Khu], [TenDonVi], [ChucVu]) VALUES (N'MCV04', 5, N'Phòng Vệ Sinh', N'Trưởng Phòng')
INSERT [dbo].[tblChucVu] ([MaCV], [Khu], [TenDonVi], [ChucVu]) VALUES (N'MCV05', 5, N'Phòng Vệ Sinh', N'Nhân Viên')
INSERT [dbo].[tblChucVu] ([MaCV], [Khu], [TenDonVi], [ChucVu]) VALUES (N'MCV06', 5, N'Phòng Vệ Sinh', N'Nhân Viên')
INSERT [dbo].[tblChucVu] ([MaCV], [Khu], [TenDonVi], [ChucVu]) VALUES (N'MCV07', 5, N'Phòng Vệ Sinh', N'Nhân Viên')
INSERT [dbo].[tblChucVu] ([MaCV], [Khu], [TenDonVi], [ChucVu]) VALUES (N'MCV08', 5, N'Phòng Vệ Sinh', N'Nhân Viên')
INSERT [dbo].[tblChucVu] ([MaCV], [Khu], [TenDonVi], [ChucVu]) VALUES (N'MCV09', 5, N'Phòng Vệ Sinh', N'Nhân Viên')
INSERT [dbo].[tblChucVu] ([MaCV], [Khu], [TenDonVi], [ChucVu]) VALUES (N'MCV10', 5, N'Phòng Vệ Sinh', N'Nhân Viên')
INSERT [dbo].[tblChucVu] ([MaCV], [Khu], [TenDonVi], [ChucVu]) VALUES (N'MCV11', 5, N'Phòng Vệ Sinh', N'Nhân Viên')
INSERT [dbo].[tblChucVu] ([MaCV], [Khu], [TenDonVi], [ChucVu]) VALUES (N'MCV12', 6, N'Phòng Hậu Cần', N'Đầu Bếp')
GO
INSERT [dbo].[tblDangKy] ([MaDK], [MaKhach], [MaPhong], [NgayDangKy], [NgayDen], [NgayDi], [TienDat], [SoNguoi], [NgiChu]) VALUES (N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblDangKy] ([MaDK], [MaKhach], [MaPhong], [NgayDangKy], [NgayDen], [NgayDi], [TienDat], [SoNguoi], [NgiChu]) VALUES (N'MDK01', N'MK01', N'MP04', CAST(N'2005-02-02T00:00:00' AS SmallDateTime), CAST(N'2015-10-14T00:00:00' AS SmallDateTime), CAST(N'2015-10-05T00:00:00' AS SmallDateTime), 50000, 1, N'Tình Tang')
INSERT [dbo].[tblDangKy] ([MaDK], [MaKhach], [MaPhong], [NgayDangKy], [NgayDen], [NgayDi], [TienDat], [SoNguoi], [NgiChu]) VALUES (N'MDK02', N'MK02', N'MP03', CAST(N'2015-10-15T00:00:00' AS SmallDateTime), CAST(N'2015-10-17T00:00:00' AS SmallDateTime), CAST(N'2015-10-04T00:00:00' AS SmallDateTime), 600000, 2, N'Hạnh Tồ')
INSERT [dbo].[tblDangKy] ([MaDK], [MaKhach], [MaPhong], [NgayDangKy], [NgayDen], [NgayDi], [TienDat], [SoNguoi], [NgiChu]) VALUES (N'MDK03', N'MK03', N'MP05', CAST(N'2015-10-13T00:00:00' AS SmallDateTime), CAST(N'2015-11-14T00:00:00' AS SmallDateTime), CAST(N'2015-10-04T00:00:00' AS SmallDateTime), 50000, 1, N'Linh Gà')
INSERT [dbo].[tblDangKy] ([MaDK], [MaKhach], [MaPhong], [NgayDangKy], [NgayDen], [NgayDi], [TienDat], [SoNguoi], [NgiChu]) VALUES (N'MDK04', N'MK04', NULL, CAST(N'2015-10-02T00:00:00' AS SmallDateTime), CAST(N'2015-10-14T00:00:00' AS SmallDateTime), CAST(N'2015-10-04T00:00:00' AS SmallDateTime), 500000, 2, N'Phòng Cùi')
INSERT [dbo].[tblDangKy] ([MaDK], [MaKhach], [MaPhong], [NgayDangKy], [NgayDen], [NgayDi], [TienDat], [SoNguoi], [NgiChu]) VALUES (N'MDK08', N'MK03', N'MP07', CAST(N'2015-10-22T00:00:00' AS SmallDateTime), CAST(N'2015-10-21T00:00:00' AS SmallDateTime), CAST(N'2015-10-04T00:00:00' AS SmallDateTime), 125, 3, N'Hii')
INSERT [dbo].[tblDangKy] ([MaDK], [MaKhach], [MaPhong], [NgayDangKy], [NgayDen], [NgayDi], [TienDat], [SoNguoi], [NgiChu]) VALUES (N'MDK09', N'MK04', N'MP10', CAST(N'2015-10-23T00:00:00' AS SmallDateTime), CAST(N'2015-10-18T00:00:00' AS SmallDateTime), CAST(N'2015-10-22T00:00:00' AS SmallDateTime), 0, 2, N'Cương Đại Gia')
INSERT [dbo].[tblDangKy] ([MaDK], [MaKhach], [MaPhong], [NgayDangKy], [NgayDen], [NgayDi], [TienDat], [SoNguoi], [NgiChu]) VALUES (N'MDK10', N'MK06', N'MP03', CAST(N'2015-10-11T00:00:00' AS SmallDateTime), CAST(N'2015-11-12T00:00:00' AS SmallDateTime), CAST(N'2015-10-22T00:00:00' AS SmallDateTime), 100000, 2, N'Đồng lát ăn bát vàng')
INSERT [dbo].[tblDangKy] ([MaDK], [MaKhach], [MaPhong], [NgayDangKy], [NgayDen], [NgayDi], [TienDat], [SoNguoi], [NgiChu]) VALUES (N'MDK11', N'MK06', N'MP10', CAST(N'2015-10-13T00:00:00' AS SmallDateTime), CAST(N'2015-09-10T00:00:00' AS SmallDateTime), CAST(N'2015-10-04T00:00:00' AS SmallDateTime), 900000, 2, N'Đồng Lát Ăn Bát Vàng')
INSERT [dbo].[tblDangKy] ([MaDK], [MaKhach], [MaPhong], [NgayDangKy], [NgayDen], [NgayDi], [TienDat], [SoNguoi], [NgiChu]) VALUES (N'MDK12', N'MK12', N'MP05', CAST(N'2015-10-23T00:00:00' AS SmallDateTime), CAST(N'2015-10-03T00:00:00' AS SmallDateTime), NULL, 5000, 1, N'Trần Ca Ca')
INSERT [dbo].[tblDangKy] ([MaDK], [MaKhach], [MaPhong], [NgayDangKy], [NgayDen], [NgayDi], [TienDat], [SoNguoi], [NgiChu]) VALUES (N'MDK13', N'MK13', N'MP08', CAST(N'2015-10-23T00:00:00' AS SmallDateTime), NULL, CAST(N'2015-10-15T00:00:00' AS SmallDateTime), 1, 1, N'Không Có')
INSERT [dbo].[tblDangKy] ([MaDK], [MaKhach], [MaPhong], [NgayDangKy], [NgayDen], [NgayDi], [TienDat], [SoNguoi], [NgiChu]) VALUES (N'MDK14', N'MK08', N'MP02', CAST(N'2015-10-23T00:00:00' AS SmallDateTime), NULL, CAST(N'2015-10-15T00:00:00' AS SmallDateTime), 1, 3, N'Không Có')
INSERT [dbo].[tblDangKy] ([MaDK], [MaKhach], [MaPhong], [NgayDangKy], [NgayDen], [NgayDi], [TienDat], [SoNguoi], [NgiChu]) VALUES (N'MDK15', N'MK07', N'MP10', CAST(N'2015-10-23T00:00:00' AS SmallDateTime), CAST(N'2015-10-21T00:00:00' AS SmallDateTime), CAST(N'2015-10-04T00:00:00' AS SmallDateTime), 50000, 6, N'Tiền Đại Ca')
INSERT [dbo].[tblDangKy] ([MaDK], [MaKhach], [MaPhong], [NgayDangKy], [NgayDen], [NgayDi], [TienDat], [SoNguoi], [NgiChu]) VALUES (N'MDK16', N'MK05', N'MP05', CAST(N'2015-10-14T00:00:00' AS SmallDateTime), NULL, CAST(N'2015-10-23T00:00:00' AS SmallDateTime), 0, 3, N'Không Có')
GO
INSERT [dbo].[tblDichVu] ([MaDV], [TenDV], [GiaTien]) VALUES (N'MDV01', N'Ăn Sáng', 20000)
INSERT [dbo].[tblDichVu] ([MaDV], [TenDV], [GiaTien]) VALUES (N'MDV02', N'Ăn Trưa', 100000)
INSERT [dbo].[tblDichVu] ([MaDV], [TenDV], [GiaTien]) VALUES (N'MDV03', N'Ăn Tối', 70000)
INSERT [dbo].[tblDichVu] ([MaDV], [TenDV], [GiaTien]) VALUES (N'MDV04', N'Xem Tivi K+', 10000)
INSERT [dbo].[tblDichVu] ([MaDV], [TenDV], [GiaTien]) VALUES (N'MDV05', N'Báo Thức', 5000)
INSERT [dbo].[tblDichVu] ([MaDV], [TenDV], [GiaTien]) VALUES (N'MDV06', N'Giặt Là', 50000)
INSERT [dbo].[tblDichVu] ([MaDV], [TenDV], [GiaTien]) VALUES (N'MDV07', N'Tặng Hoa', 10000)
GO
INSERT [dbo].[tblKhachHang] ([MaKhach], [HoDem], [Ten], [NgaySinh], [CMND], [QuocTich], [NghiChu]) VALUES (N'MK01', N'Ngô Doãn', N'Tình', CAST(N'2015-11-15T00:00:00' AS SmallDateTime), N'123456789', N'Việt Nam', N'Hello Khách Vip')
INSERT [dbo].[tblKhachHang] ([MaKhach], [HoDem], [Ten], [NgaySinh], [CMND], [QuocTich], [NghiChu]) VALUES (N'MK02', N'Nguyễn Mỹ', N'Hạnh', CAST(N'2015-10-20T00:00:00' AS SmallDateTime), N'123978654', N'Việt Nam', N'Khách Vip Đó')
INSERT [dbo].[tblKhachHang] ([MaKhach], [HoDem], [Ten], [NgaySinh], [CMND], [QuocTich], [NghiChu]) VALUES (N'MK03', N'Chu Xuân Linh', N'Linh', CAST(N'2015-10-29T00:00:00' AS SmallDateTime), N'123456789', N'Việt Nam', N'Ngu Người')
INSERT [dbo].[tblKhachHang] ([MaKhach], [HoDem], [Ten], [NgaySinh], [CMND], [QuocTich], [NghiChu]) VALUES (N'MK04', N'Trần Văn', N'Cương', CAST(N'2015-10-13T00:00:00' AS SmallDateTime), N'987654321', N'Việt Nam', N'Tý nữa là vip')
INSERT [dbo].[tblKhachHang] ([MaKhach], [HoDem], [Ten], [NgaySinh], [CMND], [QuocTich], [NghiChu]) VALUES (N'MK05', N'Dương Xuân', N'Tùng', CAST(N'2015-10-18T00:00:00' AS SmallDateTime), N'987654321', N'Việt Nam', N'Tý nữa là vip')
INSERT [dbo].[tblKhachHang] ([MaKhach], [HoDem], [Ten], [NgaySinh], [CMND], [QuocTich], [NghiChu]) VALUES (N'MK06', N'Tô Thành', N'Đồng', CAST(N'1995-07-20T00:00:00' AS SmallDateTime), N'569874321', N'Trung Quốc', N'Vip Nhà Quê')
INSERT [dbo].[tblKhachHang] ([MaKhach], [HoDem], [Ten], [NgaySinh], [CMND], [QuocTich], [NghiChu]) VALUES (N'MK07', N'Tô Thành', N'Tiền', CAST(N'1995-07-21T00:00:00' AS SmallDateTime), N'569874321', N'Trung Quốc', N'Vip Nhà Quê')
INSERT [dbo].[tblKhachHang] ([MaKhach], [HoDem], [Ten], [NgaySinh], [CMND], [QuocTich], [NghiChu]) VALUES (N'MK08', N'Dương Xuân', N'Tèo', CAST(N'1995-12-15T00:00:00' AS SmallDateTime), N'987654321', N'Cà Mau', N'Tèo Dại Gia Phố Núi')
INSERT [dbo].[tblKhachHang] ([MaKhach], [HoDem], [Ten], [NgaySinh], [CMND], [QuocTich], [NghiChu]) VALUES (N'MK09', N'Thất Văn', N'Tình', CAST(N'1995-12-15T00:00:00' AS SmallDateTime), N'987654321', N'Cà Mau', N'Tình Dại Gia Phố Núi')
INSERT [dbo].[tblKhachHang] ([MaKhach], [HoDem], [Ten], [NgaySinh], [CMND], [QuocTich], [NghiChu]) VALUES (N'MK10', N'Thất Văn', N'Tý', CAST(N'1995-12-15T00:00:00' AS SmallDateTime), N'987654321', N'Cà Mau', N'Tình Dại Gia Phố Núi')
INSERT [dbo].[tblKhachHang] ([MaKhach], [HoDem], [Ten], [NgaySinh], [CMND], [QuocTich], [NghiChu]) VALUES (N'MK11', N'Trần Trùng', N'Trục', CAST(N'2015-10-22T00:00:00' AS SmallDateTime), N'987123456', N'USA', N'Đại Ca Xóm Trọ')
INSERT [dbo].[tblKhachHang] ([MaKhach], [HoDem], [Ten], [NgaySinh], [CMND], [QuocTich], [NghiChu]) VALUES (N'MK12', N'Trần', N'Đệt', CAST(N'2015-10-22T00:00:00' AS SmallDateTime), N'987123456', N'USA', N'Đại Ca Xóm Trọ')
INSERT [dbo].[tblKhachHang] ([MaKhach], [HoDem], [Ten], [NgaySinh], [CMND], [QuocTich], [NghiChu]) VALUES (N'MK13', N'Phan Van Tài', N'Em', CAST(N'2015-10-24T00:00:00' AS SmallDateTime), N'2654789', N'Việt Nam', N'Thánh Đá Ball')
GO
INSERT [dbo].[tblNhanVien] ([MaNV], [MaCV], [HoDem], [Ten], [NgaySinh], [CMND], [NghiChu], [MatKhau]) VALUES (N'MNV01', N'MCV01', N'Ngô Doãn', N'Tình', CAST(N'1995-02-20T00:00:00' AS SmallDateTime), N'1234569741', N'Đại ca phố núi', NULL)
INSERT [dbo].[tblNhanVien] ([MaNV], [MaCV], [HoDem], [Ten], [NgaySinh], [CMND], [NghiChu], [MatKhau]) VALUES (N'MNV02', N'MCV01', N'Doãn', N'Tình', CAST(N'1995-02-20T00:00:00' AS SmallDateTime), N'1234569741', N'Đại ca phố núi', NULL)
INSERT [dbo].[tblNhanVien] ([MaNV], [MaCV], [HoDem], [Ten], [NgaySinh], [CMND], [NghiChu], [MatKhau]) VALUES (N'MNV03', N'MCV03', N'Nguyễn Mỹ', N'Hạnh', CAST(N'1995-03-30T00:00:00' AS SmallDateTime), N'1234569741', N'Đại ca phố núi', NULL)
INSERT [dbo].[tblNhanVien] ([MaNV], [MaCV], [HoDem], [Ten], [NgaySinh], [CMND], [NghiChu], [MatKhau]) VALUES (N'MNV04', N'MCV06', N'Chu Xuân', N'Linh', CAST(N'1995-03-30T00:00:00' AS SmallDateTime), N'1234569741', N'Cao thủ Đầu đầy mủ', NULL)
INSERT [dbo].[tblNhanVien] ([MaNV], [MaCV], [HoDem], [Ten], [NgaySinh], [CMND], [NghiChu], [MatKhau]) VALUES (N'MNV05', N'MCV06', N'Chu Xuân', N'Linh', CAST(N'1995-03-30T00:00:00' AS SmallDateTime), N'1234569741', N'Cao thủ Đầu đầy mủ', NULL)
INSERT [dbo].[tblNhanVien] ([MaNV], [MaCV], [HoDem], [Ten], [NgaySinh], [CMND], [NghiChu], [MatKhau]) VALUES (N'MNV06', N'MCV04', N'Trần Văn', N'Cương', CAST(N'1995-03-30T00:00:00' AS SmallDateTime), N'1234569741', N'Cao thủ Đầu đầy mủ', NULL)
INSERT [dbo].[tblNhanVien] ([MaNV], [MaCV], [HoDem], [Ten], [NgaySinh], [CMND], [NghiChu], [MatKhau]) VALUES (N'MNV07', N'MCV10', N'Dương Xuân', N'Tèo', CAST(N'1995-03-30T00:00:00' AS SmallDateTime), N'1234569741', N'Tùng Teng', NULL)
INSERT [dbo].[tblNhanVien] ([MaNV], [MaCV], [HoDem], [Ten], [NgaySinh], [CMND], [NghiChu], [MatKhau]) VALUES (N'MNV08', N'MCV10', N'Dương Xuân', N'Tùng', CAST(N'1995-03-30T00:00:00' AS SmallDateTime), N'1234569741', N'Tùng Teng', NULL)
INSERT [dbo].[tblNhanVien] ([MaNV], [MaCV], [HoDem], [Ten], [NgaySinh], [CMND], [NghiChu], [MatKhau]) VALUES (N'MNV09', N'MCV10', N'Dương Xuân', N'X', CAST(N'1995-03-30T00:00:00' AS SmallDateTime), N'1234569741', N'Tùng Teng', NULL)
INSERT [dbo].[tblNhanVien] ([MaNV], [MaCV], [HoDem], [Ten], [NgaySinh], [CMND], [NghiChu], [MatKhau]) VALUES (N'MNV10', N'MCV10', N'Dương Xuân', N'Y', CAST(N'1995-03-30T00:00:00' AS SmallDateTime), N'1234569741', N'Tùng Teng', NULL)
INSERT [dbo].[tblNhanVien] ([MaNV], [MaCV], [HoDem], [Ten], [NgaySinh], [CMND], [NghiChu], [MatKhau]) VALUES (N'MNV11', N'MCV10', N'Dương Xuân', N'Z', CAST(N'1995-03-30T00:00:00' AS SmallDateTime), N'1234569741', N'Tùng Teng', NULL)
GO
INSERT [dbo].[tblPhong] ([MaPhong], [TenPhong], [LoaiPhong], [Gia]) VALUES (N'MP01', N'TP01', N'VIP', 200000)
INSERT [dbo].[tblPhong] ([MaPhong], [TenPhong], [LoaiPhong], [Gia]) VALUES (N'MP02', N'TP01', N'VIP', 200000)
INSERT [dbo].[tblPhong] ([MaPhong], [TenPhong], [LoaiPhong], [Gia]) VALUES (N'MP03', N'TP01', N'VIP', 200000)
INSERT [dbo].[tblPhong] ([MaPhong], [TenPhong], [LoaiPhong], [Gia]) VALUES (N'MP04', N'TP01', N'VIP', 200000)
INSERT [dbo].[tblPhong] ([MaPhong], [TenPhong], [LoaiPhong], [Gia]) VALUES (N'MP05', N'TP01', N'VIP', 200000)
INSERT [dbo].[tblPhong] ([MaPhong], [TenPhong], [LoaiPhong], [Gia]) VALUES (N'MP06', N'TP01', N'Thường', 100000)
INSERT [dbo].[tblPhong] ([MaPhong], [TenPhong], [LoaiPhong], [Gia]) VALUES (N'MP07', N'TP01', N'Thường', 100000)
INSERT [dbo].[tblPhong] ([MaPhong], [TenPhong], [LoaiPhong], [Gia]) VALUES (N'MP08', N'TP01', N'Thường', 100000)
INSERT [dbo].[tblPhong] ([MaPhong], [TenPhong], [LoaiPhong], [Gia]) VALUES (N'MP09', N'TP09', N'Sinh Viên', 50000)
INSERT [dbo].[tblPhong] ([MaPhong], [TenPhong], [LoaiPhong], [Gia]) VALUES (N'MP10', N'TP10', N'Sinh Viên', 50000)
GO
INSERT [dbo].[tblSDDV] ([MaDK], [MaDV], [MaNV], [NgaySuDung], [SoLuong]) VALUES (N'MDK01', N'MDV02', N'MNV06', CAST(N'2015-10-23T00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[tblSDDV] ([MaDK], [MaDV], [MaNV], [NgaySuDung], [SoLuong]) VALUES (N'MDK01', N'MDV03', N'MNV04', CAST(N'2015-10-14T00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[tblSDDV] ([MaDK], [MaDV], [MaNV], [NgaySuDung], [SoLuong]) VALUES (N'MDK03', N'MDV02', N'MNV07', CAST(N'2015-10-21T00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[tblSDDV] ([MaDK], [MaDV], [MaNV], [NgaySuDung], [SoLuong]) VALUES (N'MDK08', N'MDV02', N'MNV05', CAST(N'2015-10-06T00:00:00' AS SmallDateTime), 3)
INSERT [dbo].[tblSDDV] ([MaDK], [MaDV], [MaNV], [NgaySuDung], [SoLuong]) VALUES (N'MDK09', N'MDV03', N'MNV04', CAST(N'2015-10-15T00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[tblSDDV] ([MaDK], [MaDV], [MaNV], [NgaySuDung], [SoLuong]) VALUES (N'MDK10', N'MDV06', N'MNV02', CAST(N'2015-10-23T00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[tblSDDV] ([MaDK], [MaDV], [MaNV], [NgaySuDung], [SoLuong]) VALUES (N'MDK11', N'MDV05', N'MNV01', CAST(N'2015-10-23T00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[tblSDDV] ([MaDK], [MaDV], [MaNV], [NgaySuDung], [SoLuong]) VALUES (N'MDK12', N'MDV02', N'MNV05', CAST(N'2015-10-23T00:00:00' AS SmallDateTime), 2)
INSERT [dbo].[tblSDDV] ([MaDK], [MaDV], [MaNV], [NgaySuDung], [SoLuong]) VALUES (N'MDK13', N'MDV02', N'MNV05', CAST(N'2015-10-19T00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[tblSDDV] ([MaDK], [MaDV], [MaNV], [NgaySuDung], [SoLuong]) VALUES (N'MDK15', N'MDV03', N'MNV07', CAST(N'2015-10-14T00:00:00' AS SmallDateTime), 2)
INSERT [dbo].[tblSDDV] ([MaDK], [MaDV], [MaNV], [NgaySuDung], [SoLuong]) VALUES (N'MDK16', N'MDV03', N'MNV06', CAST(N'2015-10-28T00:00:00' AS SmallDateTime), 3)
INSERT [dbo].[tblSDDV] ([MaDK], [MaDV], [MaNV], [NgaySuDung], [SoLuong]) VALUES (N'MDK16', N'MDV04', N'MNV05', CAST(N'2015-10-06T00:00:00' AS SmallDateTime), 2)
GO
ALTER TABLE [dbo].[tblDangKy]  WITH CHECK ADD  CONSTRAINT [FK_tblDangKy_tblKhachHang] FOREIGN KEY([MaKhach])
REFERENCES [dbo].[tblKhachHang] ([MaKhach])
GO
ALTER TABLE [dbo].[tblDangKy] CHECK CONSTRAINT [FK_tblDangKy_tblKhachHang]
GO
ALTER TABLE [dbo].[tblDangKy]  WITH CHECK ADD  CONSTRAINT [FK_tblDangKy_tblPhong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[tblPhong] ([MaPhong])
GO
ALTER TABLE [dbo].[tblDangKy] CHECK CONSTRAINT [FK_tblDangKy_tblPhong]
GO
ALTER TABLE [dbo].[tblNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanVien_tblChucVu] FOREIGN KEY([MaCV])
REFERENCES [dbo].[tblChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[tblNhanVien] CHECK CONSTRAINT [FK_tblNhanVien_tblChucVu]
GO
ALTER TABLE [dbo].[tblSDDV]  WITH CHECK ADD  CONSTRAINT [FK_tblSDDV_tblDangKy] FOREIGN KEY([MaDK])
REFERENCES [dbo].[tblDangKy] ([MaDK])
GO
ALTER TABLE [dbo].[tblSDDV] CHECK CONSTRAINT [FK_tblSDDV_tblDangKy]
GO
ALTER TABLE [dbo].[tblSDDV]  WITH CHECK ADD  CONSTRAINT [FK_tblSDDV_tblDichVu] FOREIGN KEY([MaDV])
REFERENCES [dbo].[tblDichVu] ([MaDV])
GO
ALTER TABLE [dbo].[tblSDDV] CHECK CONSTRAINT [FK_tblSDDV_tblDichVu]
GO
ALTER TABLE [dbo].[tblSDDV]  WITH CHECK ADD  CONSTRAINT [FK_tblSDDV_tblNhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tblSDDV] CHECK CONSTRAINT [FK_tblSDDV_tblNhanVien]
GO
ALTER TABLE [dbo].[tblThanhToan]  WITH CHECK ADD  CONSTRAINT [FK_tblThanhToan_tblDangKy] FOREIGN KEY([MaDK])
REFERENCES [dbo].[tblDangKy] ([MaDK])
GO
ALTER TABLE [dbo].[tblThanhToan] CHECK CONSTRAINT [FK_tblThanhToan_tblDangKy]
GO
/****** Object:  StoredProcedure [dbo].[tblChucVu_Delete]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblChucVu_Delete]
	@MaCV nvarchar(100)
As
	Delete [tblChucVu] 
	Where  ([MaCV]= @MaCV)
GO
/****** Object:  StoredProcedure [dbo].[tblChucVu_Insert]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblChucVu_Insert]
	@MaCV nvarchar(100),
	@Khu int,
	@TenDonVi nvarchar(100),
	@ChucVu nvarchar(100)
As
	Insert Into [tblChucVu]
	(
		[MaCV],
		[Khu],
		[TenDonVi],
		[ChucVu]
	)
	Values
	(
		@MaCV,
		@Khu,
		@TenDonVi,
		@ChucVu
	)

GO
/****** Object:  StoredProcedure [dbo].[tblChucVu_SelectAll]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================
CREATE PROCEDURE [dbo].[tblChucVu_SelectAll]
As
	Select * From [tblChucVu]
GO
/****** Object:  StoredProcedure [dbo].[tblChucVu_SelectByID]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblChucVu_SelectByID]
	@MaCV nvarchar(100)
As
	Select *  From [tblChucVu]
 	Where  ([MaCV] = @MaCV)
GO
/****** Object:  StoredProcedure [dbo].[tblChucVu_SelectPage]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblChucVu_SelectPage]
	@CurrentPage int,
	@PageSize int,
	@RowCount int output
As
	With TablePaging As
	(
		 Select ROW_NUMBER()
		Over(Order By [MaCV]) As RowNum,*
		From [tblChucVu]
	)
	Select @RowCount = Count(RowNum) from  TablePaging
	Select * From TablePaging
	Where RowNum Between (@CurrentPage - 1) * @PageSize + 1 And @CurrentPage * @PageSize
	Order By RowNum
GO
/****** Object:  StoredProcedure [dbo].[tblChucVu_SelectTop]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblChucVu_SelectTop]
	@Top	Nvarchar(10),
	@Where	Nvarchar(200),
	@Order	Nvarchar(200)
AS
	Declare @SQL Nvarchar(500)
	Set @SQL = 'Select Top (' + @Top + ') * From [tblChucVu]'
	if Len(@Top) = 0
		Begin
			Set @SQL = 'Select * From [tblChucVu]'
		End
	If len(@Where) >0 
		Begin
			Set @SQL = @SQL + ' Where ' + @Where
		End
	If Len(@Order) >0
		Begin
			Set @SQL = @SQL + ' Order By ' + @Order
		End
Execute sp_executesql @SQL
GO
/****** Object:  StoredProcedure [dbo].[tblChucVu_TestByID]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblChucVu_TestByID]
	@MaCV nvarchar(100),
	@TestID Bit Output
As
	Select [MaCV] From [tblChucVu]
 	Where  ([MaCV] = @MaCV)
	If(@@rowcount =0) Set @TestID = 0
	Else Set @TestID = 1
GO
/****** Object:  StoredProcedure [dbo].[tblChucVu_Update]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblChucVu_Update]
	@MaCV nvarchar(100),
	@Khu int,
	@TenDonVi nvarchar(100),
	@ChucVu nvarchar(100)
As
	Update [tblChucVu]  Set
		[Khu] = @Khu,
		[TenDonVi] = @TenDonVi,
		[ChucVu] = @ChucVu
	Where ([MaCV] = @MaCV)
GO
/****** Object:  StoredProcedure [dbo].[tblDangKy_Delete]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/21/2015 7:02:42 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblDangKy_Delete]
	@MaDK nvarchar(100)
As
	Delete [tblDangKy] 
	Where  ([MaDK]= @MaDK)
GO
/****** Object:  StoredProcedure [dbo].[tblDangKy_Insert]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/21/2015 7:02:42 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblDangKy_Insert]
	@MaDK nvarchar(100),
	@MaKhach nvarchar(100),
	@MaPhong nvarchar(100) = null,
	@NgayDangKy smalldatetime = null,
	@NgayDen smalldatetime = null,
	@NgayDi smalldatetime = null,
	@TienDat bigint,
	@SoNguoi bigint,
	@NgiChu nvarchar(100)
As
	Insert Into [tblDangKy]
	(
		[MaDK],
		[MaKhach],
		[MaPhong],
		[NgayDangKy],
		[NgayDen],
		[NgayDi],
		[TienDat],
		[SoNguoi],
		[NgiChu]
	)
	Values
	(
		@MaDK,
		@MaKhach,
		@MaPhong,
		@NgayDangKy,
		@NgayDen,
		@NgayDi,
		@TienDat,
		@SoNguoi,
		@NgiChu
	)

GO
/****** Object:  StoredProcedure [dbo].[tblDangKy_SelectAll]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/21/2015 7:02:42 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================
CREATE PROCEDURE [dbo].[tblDangKy_SelectAll]
As
	Select * From [tblDangKy]
GO
/****** Object:  StoredProcedure [dbo].[tblDangKy_SelectByID]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/21/2015 7:02:42 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblDangKy_SelectByID]
	@MaDK nvarchar(100)
As
	Select *  From [tblDangKy]
 	Where  ([MaDK] = @MaDK)
GO
/****** Object:  StoredProcedure [dbo].[tblDangKy_SelectPage]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/21/2015 7:02:42 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblDangKy_SelectPage]
	@CurrentPage int,
	@PageSize int,
	@RowCount int output
As
	With TablePaging As
	(
		 Select ROW_NUMBER()
		Over(Order By [MaDK]) As RowNum,*
		From [tblDangKy]
	)
	Select @RowCount = Count(RowNum) from  TablePaging
	Select * From TablePaging
	Where RowNum Between (@CurrentPage - 1) * @PageSize + 1 And @CurrentPage * @PageSize
	Order By RowNum
GO
/****** Object:  StoredProcedure [dbo].[tblDangKy_SelectTop]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/21/2015 7:02:42 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblDangKy_SelectTop]
	@Top	Nvarchar(10),
	@Where	Nvarchar(200),
	@Order	Nvarchar(200)
AS
	Declare @SQL Nvarchar(500)
	Set @SQL = 'Select Top (' + @Top + ') * From [tblDangKy]'
	if Len(@Top) = 0
		Begin
			Set @SQL = 'Select * From [tblDangKy]'
		End
	If len(@Where) >0 
		Begin
			Set @SQL = @SQL + ' Where ' + @Where
		End
	If Len(@Order) >0
		Begin
			Set @SQL = @SQL + ' Order By ' + @Order
		End
Execute sp_executesql @SQL
GO
/****** Object:  StoredProcedure [dbo].[tblDangKy_TestByID]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/21/2015 7:02:42 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblDangKy_TestByID]
	@MaDK nvarchar(100),
	@TestID Bit Output
As
	Select [MaDK] From [tblDangKy]
 	Where  ([MaDK] = @MaDK)
	If(@@rowcount =0) Set @TestID = 0
	Else Set @TestID = 1
GO
/****** Object:  StoredProcedure [dbo].[tblDangKy_Update]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/21/2015 7:02:42 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblDangKy_Update]
	@MaDK nvarchar(100),
	@MaKhach nvarchar(100),
	@MaPhong nvarchar(100) = null,
	@NgayDangKy smalldatetime = null,
	@NgayDen smalldatetime = null,
	@NgayDi smalldatetime = null,
	@TienDat bigint,
	@SoNguoi bigint,
	@NgiChu nvarchar(100) = null
As
	Update [tblDangKy]  Set
		[MaKhach] = @MaKhach,
		[MaPhong] = @MaPhong,
		[NgayDangKy] = @NgayDangKy,
		[NgayDen] = @NgayDen,
		[NgayDi] = @NgayDi,
		[TienDat] = @TienDat,
		[SoNguoi] = @SoNguoi,
		[NgiChu] = @NgiChu
	Where ([MaDK] = @MaDK)
GO
/****** Object:  StoredProcedure [dbo].[tblDichVu_Delete]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblDichVu_Delete]
	@MaDV nvarchar(100)
As
	Delete [tblDichVu] 
	Where  ([MaDV]= @MaDV)
GO
/****** Object:  StoredProcedure [dbo].[tblDichVu_Insert]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblDichVu_Insert]
	@MaDV nvarchar(100),
	@TenDV nvarchar(100),
	@GiaTien bigint
As
	Insert Into [tblDichVu]
	(
		[MaDV],
		[TenDV],
		[GiaTien]
	)
	Values
	(
		@MaDV,
		@TenDV,
		@GiaTien
	)

GO
/****** Object:  StoredProcedure [dbo].[tblDichVu_SelectAll]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================
CREATE PROCEDURE [dbo].[tblDichVu_SelectAll]
As
	Select * From [tblDichVu]
GO
/****** Object:  StoredProcedure [dbo].[tblDichVu_SelectByID]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblDichVu_SelectByID]
	@MaDV nvarchar(100)
As
	Select *  From [tblDichVu]
 	Where  ([MaDV] = @MaDV)
GO
/****** Object:  StoredProcedure [dbo].[tblDichVu_SelectPage]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblDichVu_SelectPage]
	@CurrentPage int,
	@PageSize int,
	@RowCount int output
As
	With TablePaging As
	(
		 Select ROW_NUMBER()
		Over(Order By [MaDV]) As RowNum,*
		From [tblDichVu]
	)
	Select @RowCount = Count(RowNum) from  TablePaging
	Select * From TablePaging
	Where RowNum Between (@CurrentPage - 1) * @PageSize + 1 And @CurrentPage * @PageSize
	Order By RowNum
GO
/****** Object:  StoredProcedure [dbo].[tblDichVu_SelectTop]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblDichVu_SelectTop]
	@Top	Nvarchar(10),
	@Where	Nvarchar(200),
	@Order	Nvarchar(200)
AS
	Declare @SQL Nvarchar(500)
	Set @SQL = 'Select Top (' + @Top + ') * From [tblDichVu]'
	if Len(@Top) = 0
		Begin
			Set @SQL = 'Select * From [tblDichVu]'
		End
	If len(@Where) >0 
		Begin
			Set @SQL = @SQL + ' Where ' + @Where
		End
	If Len(@Order) >0
		Begin
			Set @SQL = @SQL + ' Order By ' + @Order
		End
Execute sp_executesql @SQL
GO
/****** Object:  StoredProcedure [dbo].[tblDichVu_TestByID]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblDichVu_TestByID]
	@MaDV nvarchar(100),
	@TestID Bit Output
As
	Select [MaDV] From [tblDichVu]
 	Where  ([MaDV] = @MaDV)
	If(@@rowcount =0) Set @TestID = 0
	Else Set @TestID = 1
GO
/****** Object:  StoredProcedure [dbo].[tblDichVu_Update]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblDichVu_Update]
	@MaDV nvarchar(100),
	@TenDV nvarchar(100),
	@GiaTien bigint
As
	Update [tblDichVu]  Set
		[TenDV] = @TenDV,
		[GiaTien] = @GiaTien
	Where ([MaDV] = @MaDV)
GO
/****** Object:  StoredProcedure [dbo].[tblKhachHang_Delete]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblKhachHang_Delete]
	@MaKhach nvarchar(100)
As
	Delete [tblKhachHang] 
	Where  ([MaKhach]= @MaKhach)
GO
/****** Object:  StoredProcedure [dbo].[tblKhachHang_GetByID]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[tblKhachHang_GetByID](
	@MaKhach nvarchar(50))
AS
BEGIN
	SELECT * FROM tblKhachHang WHERE MaKhach = @MaKhach
END
GO
/****** Object:  StoredProcedure [dbo].[tblKhachHang_Insert]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblKhachHang_Insert]
	@MaKhach nvarchar(100),
	@HoDem nvarchar(100),
	@Ten nvarchar(100),
	@NgaySinh smalldatetime,
	@CMND nvarchar(100),
	@QuocTich nvarchar(100),
	@NghiChu nvarchar(100)
As
	Insert Into [tblKhachHang]
	(
		[MaKhach],
		[HoDem],
		[Ten],
		[NgaySinh],
		[CMND],
		[QuocTich],
		[NghiChu]
	)
	Values
	(
		@MaKhach,
		@HoDem,
		@Ten,
		@NgaySinh,
		@CMND,
		@QuocTich,
		@NghiChu
	)

GO
/****** Object:  StoredProcedure [dbo].[tblKhachHang_SelectAll]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================
CREATE PROCEDURE [dbo].[tblKhachHang_SelectAll]
As
	Select * From [tblKhachHang]
GO
/****** Object:  StoredProcedure [dbo].[tblKhachHang_SelectByID]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblKhachHang_SelectByID]
	@MaKhach nvarchar(100)
As
	Select *  From [tblKhachHang]
 	Where  ([MaKhach] = @MaKhach)
GO
/****** Object:  StoredProcedure [dbo].[tblKhachHang_SelectPage]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblKhachHang_SelectPage]
	@CurrentPage int,
	@PageSize int,
	@RowCount int output
As
	With TablePaging As
	(
		 Select ROW_NUMBER()
		Over(Order By [MaKhach]) As RowNum,*
		From [tblKhachHang]
	)
	Select @RowCount = Count(RowNum) from  TablePaging
	Select * From TablePaging
	Where RowNum Between (@CurrentPage - 1) * @PageSize + 1 And @CurrentPage * @PageSize
	Order By RowNum
GO
/****** Object:  StoredProcedure [dbo].[tblKhachHang_SelectTop]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblKhachHang_SelectTop]
	@Top	Nvarchar(10),
	@Where	Nvarchar(200),
	@Order	Nvarchar(200)
AS
	Declare @SQL Nvarchar(500)
	Set @SQL = 'Select Top (' + @Top + ') * From [tblKhachHang]'
	if Len(@Top) = 0
		Begin
			Set @SQL = 'Select * From [tblKhachHang]'
		End
	If len(@Where) >0 
		Begin
			Set @SQL = @SQL + ' Where ' + @Where
		End
	If Len(@Order) >0
		Begin
			Set @SQL = @SQL + ' Order By ' + @Order
		End
Execute sp_executesql @SQL
GO
/****** Object:  StoredProcedure [dbo].[tblKhachHang_TestByID]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblKhachHang_TestByID]
	@MaKhach nvarchar(100),
	@TestID Bit Output
As
	Select [MaKhach] From [tblKhachHang]
 	Where  ([MaKhach] = @MaKhach)
	If(@@rowcount =0) Set @TestID = 0
	Else Set @TestID = 1
GO
/****** Object:  StoredProcedure [dbo].[tblKhachHang_Update]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblKhachHang_Update]
	@MaKhach nvarchar(100),
	@HoDem nvarchar(100),
	@Ten nvarchar(100),
	@NgaySinh smalldatetime,
	@CMND nvarchar(100),
	@QuocTich nvarchar(100),
	@NghiChu nvarchar(100)
As
	Update [tblKhachHang]  Set
		[HoDem] = @HoDem,
		[Ten] = @Ten,
		[NgaySinh] = @NgaySinh,
		[CMND] = @CMND,
		[QuocTich] = @QuocTich,
		[NghiChu] = @NghiChu
	Where ([MaKhach] = @MaKhach)
GO
/****** Object:  StoredProcedure [dbo].[tblNhanVien_Delete]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblNhanVien_Delete]
	@MaNV nvarchar(100)
As
	Delete [tblNhanVien] 
	Where  ([MaNV]= @MaNV)
GO
/****** Object:  StoredProcedure [dbo].[tblNhanVien_Insert]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[tblNhanVien_Insert]
	@MaNV nvarchar(100),
	@MaCV nvarchar(100),
	@HoDem nvarchar(100),
	@Ten nvarchar(100),
	@NgaySinh smalldatetime,
	@CMND nvarchar(100),
	@NghiChu nvarchar(100),
	@MatKhau varchar(50)
As
	Insert Into [tblNhanVien]
	(
		[MaNV],
		[MaCV],
		[HoDem],
		[Ten],
		[NgaySinh],
		[CMND],
		[NghiChu],
		[MatKhau]
	)
	Values
	(
		@MaNV,
		@MaCV,
		@HoDem,
		@Ten,
		@NgaySinh,
		@CMND,
		@NghiChu,
		@MatKhau
	)
GO
/****** Object:  StoredProcedure [dbo].[tblNhanVien_SelectAll]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[tblNhanVien_SelectAll]
As
	Select * From [tblNhanVien]
	LEFT JOIN [tblChucVu] ON tblNhanVien.MaCV = tblChucVu.MaCV
GO
/****** Object:  StoredProcedure [dbo].[tblNhanVien_SelectByID]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[tblNhanVien_SelectByID]
	@MaNV nvarchar(100)
As
	Select *  From [tblNhanVien]
	LEFT JOIN [tblChucVu] ON tblNhanVien.MaCV = tblChucVu.MaCV
 	Where  ([MaNV] = @MaNV)
GO
/****** Object:  StoredProcedure [dbo].[tblNhanVien_SelectPage]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblNhanVien_SelectPage]
	@CurrentPage int,
	@PageSize int,
	@RowCount int output
As
	With TablePaging As
	(
		 Select ROW_NUMBER()
		Over(Order By [MaNV]) As RowNum,*
		From [tblNhanVien]
	)
	Select @RowCount = Count(RowNum) from  TablePaging
	Select * From TablePaging
	Where RowNum Between (@CurrentPage - 1) * @PageSize + 1 And @CurrentPage * @PageSize
	Order By RowNum
GO
/****** Object:  StoredProcedure [dbo].[tblNhanVien_SelectTop]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblNhanVien_SelectTop]
	@Top	Nvarchar(10),
	@Where	Nvarchar(200),
	@Order	Nvarchar(200)
AS
	Declare @SQL Nvarchar(500)
	Set @SQL = 'Select Top (' + @Top + ') * From [tblNhanVien]'
	if Len(@Top) = 0
		Begin
			Set @SQL = 'Select * From [tblNhanVien]'
		End
	If len(@Where) >0 
		Begin
			Set @SQL = @SQL + ' Where ' + @Where
		End
	If Len(@Order) >0
		Begin
			Set @SQL = @SQL + ' Order By ' + @Order
		End
Execute sp_executesql @SQL
GO
/****** Object:  StoredProcedure [dbo].[tblNhanVien_TestByID]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblNhanVien_TestByID]
	@MaNV nvarchar(100),
	@TestID Bit Output
As
	Select [MaNV] From [tblNhanVien]
 	Where  ([MaNV] = @MaNV)
	If(@@rowcount =0) Set @TestID = 0
	Else Set @TestID = 1
GO
/****** Object:  StoredProcedure [dbo].[tblNhanVien_Update]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[tblNhanVien_Update]
	@MaNV nvarchar(100),
	@MaCV nvarchar(100),
	@HoDem nvarchar(100),
	@Ten nvarchar(100),
	@NgaySinh smalldatetime,
	@CMND nvarchar(100),
	@NghiChu nvarchar(100),
	@MatKhau varchar(50)
As
	Update [tblNhanVien]  Set
		[MaCV] = @MaCV,
		[HoDem] = @HoDem,
		[Ten] = @Ten,
		[NgaySinh] = @NgaySinh,
		[CMND] = @CMND,
		[NghiChu] = @NghiChu,
		[MatKhau] = @MatKhau
	Where ([MaNV] = @MaNV)
GO
/****** Object:  StoredProcedure [dbo].[tblPhong_Delete]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/21/2015 8:46:05 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblPhong_Delete]
	@MaPhong nvarchar(100)
As
	Delete [tblPhong] 
	Where  ([MaPhong]= @MaPhong)
GO
/****** Object:  StoredProcedure [dbo].[tblPhong_Insert]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/21/2015 8:46:05 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblPhong_Insert]
	@MaPhong nvarchar(100),
	@TenPhong nvarchar(100),
	@LoaiPhong nvarchar(100),
	@Gia bigint
As
	Insert Into [tblPhong]
	(
		[MaPhong],
		[TenPhong],
		[LoaiPhong],
		[Gia]
	)
	Values
	(
		@MaPhong,
		@TenPhong,
		@LoaiPhong,
		@Gia
	)

GO
/****** Object:  StoredProcedure [dbo].[tblPhong_SelectAll]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/21/2015 8:46:05 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================
CREATE PROCEDURE [dbo].[tblPhong_SelectAll]
As
	Select * From [tblPhong]
GO
/****** Object:  StoredProcedure [dbo].[tblPhong_SelectByID]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/21/2015 8:46:05 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblPhong_SelectByID]
	@MaPhong nvarchar(100)
As
	Select *  From [tblPhong]
 	Where  ([MaPhong] = @MaPhong)
GO
/****** Object:  StoredProcedure [dbo].[tblPhong_SelectPage]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/21/2015 8:46:05 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblPhong_SelectPage]
	@CurrentPage int,
	@PageSize int,
	@RowCount int output
As
	With TablePaging As
	(
		 Select ROW_NUMBER()
		Over(Order By [MaPhong]) As RowNum,*
		From [tblPhong]
	)
	Select @RowCount = Count(RowNum) from  TablePaging
	Select * From TablePaging
	Where RowNum Between (@CurrentPage - 1) * @PageSize + 1 And @CurrentPage * @PageSize
	Order By RowNum
GO
/****** Object:  StoredProcedure [dbo].[tblPhong_SelectTop]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/21/2015 8:46:05 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblPhong_SelectTop]
	@Top	Nvarchar(10),
	@Where	Nvarchar(200),
	@Order	Nvarchar(200)
AS
	Declare @SQL Nvarchar(500)
	Set @SQL = 'Select Top (' + @Top + ') * From [tblPhong]'
	if Len(@Top) = 0
		Begin
			Set @SQL = 'Select * From [tblPhong]'
		End
	If len(@Where) >0 
		Begin
			Set @SQL = @SQL + ' Where ' + @Where
		End
	If Len(@Order) >0
		Begin
			Set @SQL = @SQL + ' Order By ' + @Order
		End
Execute sp_executesql @SQL
GO
/****** Object:  StoredProcedure [dbo].[tblPhong_TestByID]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/21/2015 8:46:05 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblPhong_TestByID]
	@MaPhong nvarchar(100),
	@TestID Bit Output
As
	Select [MaPhong] From [tblPhong]
 	Where  ([MaPhong] = @MaPhong)
	If(@@rowcount =0) Set @TestID = 0
	Else Set @TestID = 1
GO
/****** Object:  StoredProcedure [dbo].[tblPhong_Update]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/21/2015 8:46:05 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblPhong_Update]
	@MaPhong nvarchar(100),
	@TenPhong nvarchar(100),
	@LoaiPhong nvarchar(100),
	@Gia bigint
As
	Update [tblPhong]  Set
		[TenPhong] = @TenPhong,
		[LoaiPhong] = @LoaiPhong,
		[Gia] = @Gia
	Where ([MaPhong] = @MaPhong)
GO
/****** Object:  StoredProcedure [dbo].[tblSDDV_Delete]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblSDDV_Delete]
	@MaDK nvarchar(100),
	@MaDV nvarchar(100)
As
	Delete [tblSDDV] 
	Where  ([MaDK]= @MaDK and [MaDV]= @MaDV)
GO
/****** Object:  StoredProcedure [dbo].[tblSDDV_Insert]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblSDDV_Insert]
	@MaDK nvarchar(100),
	@MaDV nvarchar(100),
	@MaNV nvarchar(100) = null,
	@NgaySuDung smalldatetime = null,
	@SoLuong int = null
As
	Insert Into [tblSDDV]
	(
		[MaDK],
		[MaDV],
		[MaNV],
		[NgaySuDung],
		[SoLuong]
	)
	Values
	(
		@MaDK,
		@MaDV,
		@MaNV,
		@NgaySuDung,
		@SoLuong
	)

GO
/****** Object:  StoredProcedure [dbo].[tblSDDV_SelectAll]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================
CREATE PROCEDURE [dbo].[tblSDDV_SelectAll]
As
	Select * From [tblSDDV]
GO
/****** Object:  StoredProcedure [dbo].[tblSDDV_SelectAllByID]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[tblSDDV_SelectAllByID]
@MaDK nvarchar(50)
AS
	Select *From tblSDDV
	Where MaDK = @MaDK
GO
/****** Object:  StoredProcedure [dbo].[tblSDDV_SelectByID]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblSDDV_SelectByID]
	@MaDK nvarchar(100),
	@MaDV nvarchar(100)
As
	Select *  From [tblSDDV]
 	Where  ([MaDK] = @MaDK and [MaDV] = @MaDV)
GO
/****** Object:  StoredProcedure [dbo].[tblSDDV_SelectPage]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblSDDV_SelectPage]
	@CurrentPage int,
	@PageSize int,
	@RowCount int output
As
	With TablePaging As
	(
		 Select ROW_NUMBER()
		Over(Order By [MaDK],[MaDV]) As RowNum,*
		From [tblSDDV]
	)
	Select @RowCount = Count(RowNum) from  TablePaging
	Select * From TablePaging
	Where RowNum Between (@CurrentPage - 1) * @PageSize + 1 And @CurrentPage * @PageSize
	Order By RowNum
GO
/****** Object:  StoredProcedure [dbo].[tblSDDV_SelectTop]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblSDDV_SelectTop]
	@Top	Nvarchar(10),
	@Where	Nvarchar(200),
	@Order	Nvarchar(200)
AS
	Declare @SQL Nvarchar(500)
	Set @SQL = 'Select Top (' + @Top + ') * From [tblSDDV]'
	if Len(@Top) = 0
		Begin
			Set @SQL = 'Select * From [tblSDDV]'
		End
	If len(@Where) >0 
		Begin
			Set @SQL = @SQL + ' Where ' + @Where
		End
	If Len(@Order) >0
		Begin
			Set @SQL = @SQL + ' Order By ' + @Order
		End
Execute sp_executesql @SQL
GO
/****** Object:  StoredProcedure [dbo].[tblSDDV_TestByID]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblSDDV_TestByID]
	@MaDK nvarchar(100),
	@MaDV nvarchar(100),
	@TestID Bit Output
As
	Select [MaDK],[MaDV] From [tblSDDV]
 	Where  ([MaDK] = @MaDK and [MaDV] = @MaDV)
	If(@@rowcount =0) Set @TestID = 0
	Else Set @TestID = 1
GO
/****** Object:  StoredProcedure [dbo].[tblSDDV_Update]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblSDDV_Update]
	@MaDK nvarchar(100),
	@MaDV nvarchar(100),
	@MaNV nvarchar(100),
	@NgaySuDung smalldatetime,
	@SoLuong int
As
	Update [tblSDDV]  Set
		[MaNV] = @MaNV,
		[NgaySuDung] = @NgaySuDung,
		[SoLuong] = @SoLuong
	Where ([MaDK] = @MaDK and [MaDV] = @MaDV)
GO
/****** Object:  StoredProcedure [dbo].[tblThanhToan_Delete]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:57 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblThanhToan_Delete]
	@MaDK nvarchar(100),
	@MaPhong nvarchar(100)
As
	Delete [tblThanhToan] 
	Where  ([MaDK]= @MaDK and [MaPhong]= @MaPhong)
GO
/****** Object:  StoredProcedure [dbo].[tblThanhToan_Insert]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:56 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblThanhToan_Insert]
	@MaDK nvarchar(100),
	@MaPhong nvarchar(100),
	@MaNV nvarchar(100),
	@NgayThanhToan smalldatetime
As
	Insert Into [tblThanhToan]
	(
		[MaDK],
		[MaPhong],
		[MaNV],
		[NgayThanhToan]
	)
	Values
	(
		@MaDK,
		@MaPhong,
		@MaNV,
		@NgayThanhToan
	)

GO
/****** Object:  StoredProcedure [dbo].[tblThanhToan_SelectAll]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:57 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================
CREATE PROCEDURE [dbo].[tblThanhToan_SelectAll]
As
	Select * From [tblThanhToan]
GO
/****** Object:  StoredProcedure [dbo].[tblThanhToan_SelectByID]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:57 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblThanhToan_SelectByID]
	@MaDK nvarchar(100),
	@MaPhong nvarchar(100)
As
	Select *  From [tblThanhToan]
 	Where  ([MaDK] = @MaDK and [MaPhong] = @MaPhong)
GO
/****** Object:  StoredProcedure [dbo].[tblThanhToan_SelectPage]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:57 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblThanhToan_SelectPage]
	@CurrentPage int,
	@PageSize int,
	@RowCount int output
As
	With TablePaging As
	(
		 Select ROW_NUMBER()
		Over(Order By [MaDK],[MaPhong]) As RowNum,*
		From [tblThanhToan]
	)
	Select @RowCount = Count(RowNum) from  TablePaging
	Select * From TablePaging
	Where RowNum Between (@CurrentPage - 1) * @PageSize + 1 And @CurrentPage * @PageSize
	Order By RowNum
GO
/****** Object:  StoredProcedure [dbo].[tblThanhToan_SelectTop]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:57 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblThanhToan_SelectTop]
	@Top	Nvarchar(10),
	@Where	Nvarchar(200),
	@Order	Nvarchar(200)
AS
	Declare @SQL Nvarchar(500)
	Set @SQL = 'Select Top (' + @Top + ') * From [tblThanhToan]'
	if Len(@Top) = 0
		Begin
			Set @SQL = 'Select * From [tblThanhToan]'
		End
	If len(@Where) >0 
		Begin
			Set @SQL = @SQL + ' Where ' + @Where
		End
	If Len(@Order) >0
		Begin
			Set @SQL = @SQL + ' Order By ' + @Order
		End
Execute sp_executesql @SQL
GO
/****** Object:  StoredProcedure [dbo].[tblThanhToan_TestByID]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:57 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblThanhToan_TestByID]
	@MaDK nvarchar(100),
	@MaPhong nvarchar(100),
	@TestID Bit Output
As
	Select [MaDK],[MaPhong] From [tblThanhToan]
 	Where  ([MaDK] = @MaDK and [MaPhong] = @MaPhong)
	If(@@rowcount =0) Set @TestID = 0
	Else Set @TestID = 1
GO
/****** Object:  StoredProcedure [dbo].[tblThanhToan_Update]    Script Date: 6/21/2022 08:16:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 10/18/2015 9:38:57 PM
-- Project: QuanLyKhachSan
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[tblThanhToan_Update]
	@MaDK nvarchar(100),
	@MaPhong nvarchar(100),
	@MaNV nvarchar(100),
	@NgayThanhToan smalldatetime
As
	Update [tblThanhToan]  Set
		[MaNV] = @MaNV,
		[NgayThanhToan] = @NgayThanhToan
	Where ([MaDK] = @MaDK and [MaPhong] = @MaPhong)
GO
USE [master]
GO
ALTER DATABASE [QuanLyKhachSan] SET  READ_WRITE 
GO
