USE [QLKHACHSAN]
GO
/****** Object:  Table [dbo].[anhphong]    Script Date: 5/18/2022 14:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[anhphong](
	[maanh] [int] NOT NULL,
	[maphong] [char](4) NULL,
	[link] [nchar](10) NULL,
 CONSTRAINT [PK_anhphong] PRIMARY KEY CLUSTERED 
(
	[maanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chucvu]    Script Date: 5/18/2022 14:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chucvu](
	[cv_macv] [char](2) NOT NULL,
	[cv_tencv] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cv_macv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ctphongdat]    Script Date: 5/18/2022 14:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ctphongdat](
	[madp] [char](5) NOT NULL,
	[maphong] [char](4) NOT NULL,
	[ngaynhan] [datetime] NULL,
	[ngaytra] [datetime] NULL,
	[thanhtien] [int] NULL,
	[manv] [char](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[madp] ASC,
	[maphong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datphong]    Script Date: 5/18/2022 14:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datphong](
	[madp] [char](5) NOT NULL,
	[manv] [char](5) NOT NULL,
	[makh] [char](5) NOT NULL,
	[tenlp] [varchar](10) NOT NULL,
	[ngaydat] [datetime] NOT NULL,
	[ngayden] [datetime] NOT NULL,
	[ngaydi] [datetime] NOT NULL,
	[tiendatcoc] [int] NULL,
	[soluong] [int] NOT NULL,
	[trangthai] [bit] NULL,
 CONSTRAINT [PK__datphong__7A21E02FE8DC368E] PRIMARY KEY CLUSTERED 
(
	[madp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hoadon]    Script Date: 5/18/2022 14:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoadon](
	[mahd] [char](5) NOT NULL,
	[madp] [char](5) NOT NULL,
	[ngaylap] [date] NOT NULL,
	[tongtien] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[mahd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 5/18/2022 14:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachhang](
	[makh] [char](5) NOT NULL,
	[hoten] [nvarchar](30) NOT NULL,
	[cmnd] [char](9) NOT NULL,
	[sdt] [varchar](12) NOT NULL,
	[email] [varchar](30) NULL,
	[diachi] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[makh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[loaiphong]    Script Date: 5/18/2022 14:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaiphong](
	[tenlp] [varchar](10) NOT NULL,
	[soluong] [int] NOT NULL,
	[giaphong] [int] NOT NULL,
	[solandat] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[tenlp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 5/18/2022 14:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[nv_manv] [char](5) NOT NULL,
	[nv_macv] [char](2) NOT NULL,
	[nv_hoten] [nvarchar](30) NOT NULL,
	[nv_ngaysinh] [nchar](20) NOT NULL,
	[nv_gioitinh] [bit] NOT NULL,
	[nv_sdt] [varchar](12) NOT NULL,
	[nv_cmnd] [char](9) NOT NULL,
	[nv_diachi] [nvarchar](50) NOT NULL,
	[nv_email] [varchar](30) NULL,
	[nv_khoa] [bit] NULL,
	[nv_matkhau] [nvarchar](max) NULL,
	[nv_id] [char](1) NOT NULL,
	[nv_fileanh] [nvarchar](max) NULL,
 CONSTRAINT [PK__nhanvien__7A21B37D706EA71B] PRIMARY KEY CLUSTERED 
(
	[nv_manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phong]    Script Date: 5/18/2022 14:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phong](
	[maphong] [char](4) NOT NULL,
	[tenlp] [varchar](10) NULL,
	[tinhtrang] [smallint] NULL,
	[sophong] [char](4) NULL,
	[solandat] [int] NULL,
 CONSTRAINT [PK__phong__BBA2548082D449AC] PRIMARY KEY CLUSTERED 
(
	[maphong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[quyen]    Script Date: 5/18/2022 14:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[quyen](
	[q_id] [char](1) NOT NULL,
	[q_quyen] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[q_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[chucvu] ([cv_macv], [cv_tencv]) VALUES (N'BV', N'Bảo vệ')
INSERT [dbo].[chucvu] ([cv_macv], [cv_tencv]) VALUES (N'GD', N'Giám đốc')
INSERT [dbo].[chucvu] ([cv_macv], [cv_tencv]) VALUES (N'KT', N'Kế toán')
INSERT [dbo].[chucvu] ([cv_macv], [cv_tencv]) VALUES (N'LT', N'Lễ tân')
INSERT [dbo].[chucvu] ([cv_macv], [cv_tencv]) VALUES (N'PD', N'Phó Giám đốc')
INSERT [dbo].[chucvu] ([cv_macv], [cv_tencv]) VALUES (N'PV', N'Phục vụ')
INSERT [dbo].[chucvu] ([cv_macv], [cv_tencv]) VALUES (N'TK', N'Thư ký')
GO
INSERT [dbo].[ctphongdat] ([madp], [maphong], [ngaynhan], [ngaytra], [thanhtien], [manv]) VALUES (N'DP001', N'V001', NULL, NULL, NULL, NULL)
INSERT [dbo].[ctphongdat] ([madp], [maphong], [ngaynhan], [ngaytra], [thanhtien], [manv]) VALUES (N'DP001', N'V002', NULL, NULL, NULL, NULL)
INSERT [dbo].[ctphongdat] ([madp], [maphong], [ngaynhan], [ngaytra], [thanhtien], [manv]) VALUES (N'DP002', N'S503', NULL, NULL, NULL, NULL)
INSERT [dbo].[ctphongdat] ([madp], [maphong], [ngaynhan], [ngaytra], [thanhtien], [manv]) VALUES (N'DP002', N'S504', NULL, NULL, NULL, NULL)
INSERT [dbo].[ctphongdat] ([madp], [maphong], [ngaynhan], [ngaytra], [thanhtien], [manv]) VALUES (N'DP002', N'S505', NULL, NULL, NULL, NULL)
INSERT [dbo].[ctphongdat] ([madp], [maphong], [ngaynhan], [ngaytra], [thanhtien], [manv]) VALUES (N'DP003', N'D501', NULL, NULL, NULL, NULL)
INSERT [dbo].[ctphongdat] ([madp], [maphong], [ngaynhan], [ngaytra], [thanhtien], [manv]) VALUES (N'DP003', N'D502', NULL, NULL, NULL, NULL)
INSERT [dbo].[ctphongdat] ([madp], [maphong], [ngaynhan], [ngaytra], [thanhtien], [manv]) VALUES (N'DP004', N'D401', NULL, NULL, NULL, NULL)
INSERT [dbo].[ctphongdat] ([madp], [maphong], [ngaynhan], [ngaytra], [thanhtien], [manv]) VALUES (N'DP004', N'D402', NULL, NULL, NULL, NULL)
INSERT [dbo].[ctphongdat] ([madp], [maphong], [ngaynhan], [ngaytra], [thanhtien], [manv]) VALUES (N'DP005', N'E201', NULL, NULL, NULL, NULL)
INSERT [dbo].[ctphongdat] ([madp], [maphong], [ngaynhan], [ngaytra], [thanhtien], [manv]) VALUES (N'DP005', N'E202', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[datphong] ([madp], [manv], [makh], [tenlp], [ngaydat], [ngayden], [ngaydi], [tiendatcoc], [soluong], [trangthai]) VALUES (N'DP001', N'NV002', N'KH001', N'Superio', CAST(N'2022-05-17T00:00:00.000' AS DateTime), CAST(N'2015-01-08T00:00:00.000' AS DateTime), CAST(N'2015-02-08T00:00:00.000' AS DateTime), 100000, 2, 0)
INSERT [dbo].[datphong] ([madp], [manv], [makh], [tenlp], [ngaydat], [ngayden], [ngaydi], [tiendatcoc], [soluong], [trangthai]) VALUES (N'DP002', N'NV002', N'KH002', N'Standard', CAST(N'2022-05-17T00:00:00.000' AS DateTime), CAST(N'2015-03-01T00:00:00.000' AS DateTime), CAST(N'2015-03-10T00:00:00.000' AS DateTime), 60000, 3, 0)
INSERT [dbo].[datphong] ([madp], [manv], [makh], [tenlp], [ngaydat], [ngayden], [ngaydi], [tiendatcoc], [soluong], [trangthai]) VALUES (N'DP003', N'NV003', N'KH003', N'Deluxe', CAST(N'2022-05-17T00:00:00.000' AS DateTime), CAST(N'2015-05-04T00:00:00.000' AS DateTime), CAST(N'2015-05-12T00:00:00.000' AS DateTime), 60000, 2, 0)
INSERT [dbo].[datphong] ([madp], [manv], [makh], [tenlp], [ngaydat], [ngayden], [ngaydi], [tiendatcoc], [soluong], [trangthai]) VALUES (N'DP004', N'NV003', N'KH004', N'Deluxe', CAST(N'2022-05-17T00:00:00.000' AS DateTime), CAST(N'2015-01-08T00:00:00.000' AS DateTime), CAST(N'2015-02-08T00:00:00.000' AS DateTime), 60000, 2, 0)
INSERT [dbo].[datphong] ([madp], [manv], [makh], [tenlp], [ngaydat], [ngayden], [ngaydi], [tiendatcoc], [soluong], [trangthai]) VALUES (N'DP005', N'NV002', N'KH005', N'Suite', CAST(N'2022-05-17T00:00:00.000' AS DateTime), CAST(N'2014-12-25T00:00:00.000' AS DateTime), CAST(N'2014-12-28T00:00:00.000' AS DateTime), 80000, 2, 1)
GO
INSERT [dbo].[hoadon] ([mahd], [madp], [ngaylap], [tongtien]) VALUES (N'HD001', N'DP005', CAST(N'2022-05-17' AS Date), 2400000)
GO
INSERT [dbo].[khachhang] ([makh], [hoten], [cmnd], [sdt], [email], [diachi]) VALUES (N'KH001', N'Võ Hoài Linh', N'222555888', N'0909050505', N'hoailinh@yahoo.com', N'Hồ Chí Minh')
INSERT [dbo].[khachhang] ([makh], [hoten], [cmnd], [sdt], [email], [diachi]) VALUES (N'KH002', N'Hồ Ngọc Hà', N'222777511', N'01668135131', N'haho@yahoo.com', N'Hồ Chí Minh')
INSERT [dbo].[khachhang] ([makh], [hoten], [cmnd], [sdt], [email], [diachi]) VALUES (N'KH003', N'Đàm Vĩnh Hưng', N'222555782', N'0909050805', N'dvh@yahoo.com', N'Hồ Chí Minh')
INSERT [dbo].[khachhang] ([makh], [hoten], [cmnd], [sdt], [email], [diachi]) VALUES (N'KH004', N'Hồ Quang Hiếu', N'222444456', N'01668135181', N'hqh@yahoo.com', N'Hồ Chí Minh')
INSERT [dbo].[khachhang] ([makh], [hoten], [cmnd], [sdt], [email], [diachi]) VALUES (N'KH005', N'Cao Thái Sơn', N'229995753', N'0913050505', N'thaison@yahoo.com', N'Hồ Chí Minh')
GO
INSERT [dbo].[loaiphong] ([tenlp], [soluong], [giaphong], [solandat]) VALUES (N'Deluxe', 6, 300000, NULL)
INSERT [dbo].[loaiphong] ([tenlp], [soluong], [giaphong], [solandat]) VALUES (N'Standard', 7, 200000, NULL)
INSERT [dbo].[loaiphong] ([tenlp], [soluong], [giaphong], [solandat]) VALUES (N'Suite', 5, 400000, NULL)
INSERT [dbo].[loaiphong] ([tenlp], [soluong], [giaphong], [solandat]) VALUES (N'Superio', 3, 500000, NULL)
GO
INSERT [dbo].[nhanvien] ([nv_manv], [nv_macv], [nv_hoten], [nv_ngaysinh], [nv_gioitinh], [nv_sdt], [nv_cmnd], [nv_diachi], [nv_email], [nv_khoa], [nv_matkhau], [nv_id], [nv_fileanh]) VALUES (N'NV001', N'GD', N'Nguyễn Hùng', N'05/06/1985          ', 1, N'01223503050', N'212555667', N'Hải Châu, Đà Nẵng', N'hungnguyen@gmail.com', 0, N'123', N'A', NULL)
INSERT [dbo].[nhanvien] ([nv_manv], [nv_macv], [nv_hoten], [nv_ngaysinh], [nv_gioitinh], [nv_sdt], [nv_cmnd], [nv_diachi], [nv_email], [nv_khoa], [nv_matkhau], [nv_id], [nv_fileanh]) VALUES (N'NV002', N'LT', N'Nguyễn Hoàng Anh', N'02/02/1983          ', 0, N'01223503052', N'212555666', N'Hải Châu, Đà Nẵng', N'hoanganh@gmail.com', 0, N'123', N'B', NULL)
INSERT [dbo].[nhanvien] ([nv_manv], [nv_macv], [nv_hoten], [nv_ngaysinh], [nv_gioitinh], [nv_sdt], [nv_cmnd], [nv_diachi], [nv_email], [nv_khoa], [nv_matkhau], [nv_id], [nv_fileanh]) VALUES (N'NV003', N'LT', N'Nguyễn Anh Thư', N'02/06/1998          ', 0, N'01223503053', N'212555668', N'Thanh Khê, Đà Nẵng', N'anhthu@gmail.com', 0, N'123', N'B', NULL)
INSERT [dbo].[nhanvien] ([nv_manv], [nv_macv], [nv_hoten], [nv_ngaysinh], [nv_gioitinh], [nv_sdt], [nv_cmnd], [nv_diachi], [nv_email], [nv_khoa], [nv_matkhau], [nv_id], [nv_fileanh]) VALUES (N'NV004', N'BV', N'Lê Quốc Bảo', N'25/12/1979          ', 1, N'01223503054', N'212555669', N'Cẩm Lệ, Đà Nẵng', N'quocbao@gmail.com', 0, N'123', N'C', NULL)
INSERT [dbo].[nhanvien] ([nv_manv], [nv_macv], [nv_hoten], [nv_ngaysinh], [nv_gioitinh], [nv_sdt], [nv_cmnd], [nv_diachi], [nv_email], [nv_khoa], [nv_matkhau], [nv_id], [nv_fileanh]) VALUES (N'NV005', N'PV', N'Nguyễn Hồng Hoa', N'01/02/1992          ', 0, N'01223503055', N'212555676', N'Hải Châu, Đà Nẵng', N'honghoa@gmail.com', 0, N'123', N'C', NULL)
INSERT [dbo].[nhanvien] ([nv_manv], [nv_macv], [nv_hoten], [nv_ngaysinh], [nv_gioitinh], [nv_sdt], [nv_cmnd], [nv_diachi], [nv_email], [nv_khoa], [nv_matkhau], [nv_id], [nv_fileanh]) VALUES (N'NV006', N'PD', N'Trần Hoàng Minh', N'02/02/1978          ', 1, N'01223503056', N'212555686', N'Hòa Khánh, Đà Nẵng', N'hoangminh@gmail.com', 0, N'123', N'A', NULL)
INSERT [dbo].[nhanvien] ([nv_manv], [nv_macv], [nv_hoten], [nv_ngaysinh], [nv_gioitinh], [nv_sdt], [nv_cmnd], [nv_diachi], [nv_email], [nv_khoa], [nv_matkhau], [nv_id], [nv_fileanh]) VALUES (N'NV007', N'KT', N'Nguyễn Ngọc My', N'02/07/1983          ', 0, N'01223503057', N'212555696', N'Hải Châu, Đà Nẵng', N'ngocmy@gmail.com', 0, N'123', N'B', NULL)
INSERT [dbo].[nhanvien] ([nv_manv], [nv_macv], [nv_hoten], [nv_ngaysinh], [nv_gioitinh], [nv_sdt], [nv_cmnd], [nv_diachi], [nv_email], [nv_khoa], [nv_matkhau], [nv_id], [nv_fileanh]) VALUES (N'NV008', N'PV', N'Nguyễn Thị Ngọc', N'12/12/1985          ', 0, N'01223503058', N'212555766', N'Hải Châu, Đà Nẵng', N'ngocngoc@gmail.com', 0, N'123', N'C', NULL)
INSERT [dbo].[nhanvien] ([nv_manv], [nv_macv], [nv_hoten], [nv_ngaysinh], [nv_gioitinh], [nv_sdt], [nv_cmnd], [nv_diachi], [nv_email], [nv_khoa], [nv_matkhau], [nv_id], [nv_fileanh]) VALUES (N'NV009', N'TK', N'Lê Bảo Trâm', N'22/12/1998          ', 0, N'01223503059', N'212555866', N'Hải Châu, Đà Nẵng', N'baotram@gmail.com', 0, N'123', N'A', NULL)
INSERT [dbo].[nhanvien] ([nv_manv], [nv_macv], [nv_hoten], [nv_ngaysinh], [nv_gioitinh], [nv_sdt], [nv_cmnd], [nv_diachi], [nv_email], [nv_khoa], [nv_matkhau], [nv_id], [nv_fileanh]) VALUES (N'NV010', N'PV', N'Nguyễn Ngọc Anh', N'15/06/1987          ', 1, N'01223503060', N'212555966', N'Hải Châu, Đà Nẵng', N'ngocanh@gmail.com', 0, N'123', N'C', NULL)
GO
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'D104', N'Deluxe', 0, N'104 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'D105', N'Deluxe', 0, N'105 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'D203', N'Deluxe', 0, N'203 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'D204', N'Deluxe', 0, N'204 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'D301', N'Deluxe', 0, N'301 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'D302', N'Deluxe', 0, N'302 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'D401', N'Deluxe', 1, N'401 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'D402', N'Deluxe', 1, N'402 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'D501', N'Deluxe', 1, N'501 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'D502', N'Deluxe', 1, N'502 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'E101', N'Suite', 0, N'101 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'E102', N'Suite', 0, N'102 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'E103', N'Suite', 0, N'103 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'E201', N'Suite', 0, N'201 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'E202', N'Suite', 0, N'202 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'S205', N'Standard', 0, N'205 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'S303', N'Standard', 0, N'303 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'S304', N'Standard', 0, N'304 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'S305', N'Standard', 0, N'305 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'S403', N'Standard', 0, N'403 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'S404', N'Standard', 0, N'404 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'S405', N'Standard', 0, N'405 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'S503', N'Standard', 1, N'503 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'S504', N'Standard', 1, N'504 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'S505', N'Standard', 1, N'505 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'V001', N'Superio', 1, N'601 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'V002', N'Superio', 1, N'602 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'V003', N'Superio', 0, N'603 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'V004', N'Superio', 0, N'604 ', NULL)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [sophong], [solandat]) VALUES (N'V005', N'Superio', 0, N'605 ', NULL)
GO
INSERT [dbo].[quyen] ([q_id], [q_quyen]) VALUES (N'A', N'Quản trị')
INSERT [dbo].[quyen] ([q_id], [q_quyen]) VALUES (N'B', N'Nhân viên')
INSERT [dbo].[quyen] ([q_id], [q_quyen]) VALUES (N'C', N'Khách')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__khachhan__22BEB80D0B915205]    Script Date: 5/18/2022 14:53:48 ******/
ALTER TABLE [dbo].[khachhang] ADD UNIQUE NONCLUSTERED 
(
	[cmnd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__khachhan__AB6E616403B7755F]    Script Date: 5/18/2022 14:53:48 ******/
ALTER TABLE [dbo].[khachhang] ADD UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__nhanvien__22BEB80D222AF18F]    Script Date: 5/18/2022 14:53:48 ******/
ALTER TABLE [dbo].[nhanvien] ADD  CONSTRAINT [UQ__nhanvien__22BEB80D222AF18F] UNIQUE NONCLUSTERED 
(
	[nv_cmnd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__nhanvien__AB6E6164AC0A97F1]    Script Date: 5/18/2022 14:53:48 ******/
ALTER TABLE [dbo].[nhanvien] ADD  CONSTRAINT [UQ__nhanvien__AB6E6164AC0A97F1] UNIQUE NONCLUSTERED 
(
	[nv_email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[datphong] ADD  CONSTRAINT [DF__datphong__ngayda__3E52440B]  DEFAULT (getdate()) FOR [ngaydat]
GO
ALTER TABLE [dbo].[datphong] ADD  CONSTRAINT [DF__datphong__ngayde__3F466844]  DEFAULT (getdate()) FOR [ngayden]
GO
ALTER TABLE [dbo].[datphong] ADD  CONSTRAINT [DF__datphong__ngaydi__403A8C7D]  DEFAULT (getdate()) FOR [ngaydi]
GO
ALTER TABLE [dbo].[hoadon] ADD  DEFAULT (getdate()) FOR [ngaylap]
GO
ALTER TABLE [dbo].[anhphong]  WITH CHECK ADD  CONSTRAINT [FK_anhphong_phong] FOREIGN KEY([maphong])
REFERENCES [dbo].[phong] ([maphong])
GO
ALTER TABLE [dbo].[anhphong] CHECK CONSTRAINT [FK_anhphong_phong]
GO
ALTER TABLE [dbo].[ctphongdat]  WITH CHECK ADD  CONSTRAINT [FK__ctphongda__mapho__440B1D61] FOREIGN KEY([maphong])
REFERENCES [dbo].[phong] ([maphong])
GO
ALTER TABLE [dbo].[ctphongdat] CHECK CONSTRAINT [FK__ctphongda__mapho__440B1D61]
GO
ALTER TABLE [dbo].[ctphongdat]  WITH CHECK ADD  CONSTRAINT [FK__ctphongdat__madp__4316F928] FOREIGN KEY([madp])
REFERENCES [dbo].[datphong] ([madp])
GO
ALTER TABLE [dbo].[ctphongdat] CHECK CONSTRAINT [FK__ctphongdat__madp__4316F928]
GO
ALTER TABLE [dbo].[datphong]  WITH CHECK ADD  CONSTRAINT [FK__datphong__makh__3C69FB99] FOREIGN KEY([makh])
REFERENCES [dbo].[khachhang] ([makh])
GO
ALTER TABLE [dbo].[datphong] CHECK CONSTRAINT [FK__datphong__makh__3C69FB99]
GO
ALTER TABLE [dbo].[datphong]  WITH CHECK ADD  CONSTRAINT [FK__datphong__manv__3B75D760] FOREIGN KEY([manv])
REFERENCES [dbo].[nhanvien] ([nv_manv])
GO
ALTER TABLE [dbo].[datphong] CHECK CONSTRAINT [FK__datphong__manv__3B75D760]
GO
ALTER TABLE [dbo].[datphong]  WITH CHECK ADD  CONSTRAINT [FK__datphong__tenlp__3D5E1FD2] FOREIGN KEY([tenlp])
REFERENCES [dbo].[loaiphong] ([tenlp])
GO
ALTER TABLE [dbo].[datphong] CHECK CONSTRAINT [FK__datphong__tenlp__3D5E1FD2]
GO
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK__hoadon__madp__46E78A0C] FOREIGN KEY([madp])
REFERENCES [dbo].[datphong] ([madp])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK__hoadon__madp__46E78A0C]
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD  CONSTRAINT [FK__nhanvien__macv__286302EC] FOREIGN KEY([nv_macv])
REFERENCES [dbo].[chucvu] ([cv_macv])
GO
ALTER TABLE [dbo].[nhanvien] CHECK CONSTRAINT [FK__nhanvien__macv__286302EC]
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_nhanvien_phanquyen] FOREIGN KEY([nv_id])
REFERENCES [dbo].[quyen] ([q_id])
GO
ALTER TABLE [dbo].[nhanvien] CHECK CONSTRAINT [FK_nhanvien_phanquyen]
GO
ALTER TABLE [dbo].[phong]  WITH CHECK ADD  CONSTRAINT [FK__phong__tenlp__31EC6D26] FOREIGN KEY([tenlp])
REFERENCES [dbo].[loaiphong] ([tenlp])
GO
ALTER TABLE [dbo].[phong] CHECK CONSTRAINT [FK__phong__tenlp__31EC6D26]
GO
ALTER TABLE [dbo].[khachhang]  WITH CHECK ADD CHECK  (([cmnd] like '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[khachhang]  WITH CHECK ADD CHECK  (([email] like '[a-z]%@[a-z]%.[a-z]%'))
GO
ALTER TABLE [dbo].[khachhang]  WITH CHECK ADD CHECK  (([sdt] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' OR [sdt] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
/****** Object:  StoredProcedure [dbo].[getAllNhanviens]    Script Date: 5/18/2022 14:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getAllNhanviens]
as
SELECT * FROM nhanvien
LEFT JOIN chucvu ON nhanvien.nv_macv = chucvu.cv_macv
LEFT JOIN quyen ON nhanvien.nv_id = quyen.q_id
GO
/****** Object:  StoredProcedure [dbo].[getdskh]    Script Date: 5/18/2022 14:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[getdskh]
as
begin
	select * from khachhang
end
GO
/****** Object:  StoredProcedure [dbo].[getdsnv]    Script Date: 5/18/2022 14:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[getdsnv]
as
begin
	select manv,tencv,hoten,ngaysinh,gioitinh,sdt,cmnd,diachi,email
	from nhanvien,chucvu
	where nhanvien.macv = chucvu.macv
end

GO
/****** Object:  StoredProcedure [dbo].[gethoadon]    Script Date: 5/18/2022 14:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[gethoadon]
	@madp char(5)
as
begin
	select hd.mahd,hd.ngaylap,dp.madp,dp.makh,kh.hoten,dp.tenlp,dp.soluong,dp.ngayden,dp.ngaydi,hd.tongtien
	from hoadon as hd,datphong as dp,khachhang as kh
	where hd.madp=dp.madp and dp.makh = kh.makh and hd.madp = @madp
end

GO
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 5/18/2022 14:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Login]
@manv varchar(50),
@matkhau varchar(50)
as
SELECT * FROM nhanvien 
LEFT JOIN chucvu ON nhanvien.nv_macv = chucvu.cv_macv
LEFT JOIN quyen ON nhanvien.nv_id = quyen.q_id
WHERE LOWER(nv_manv) = @manv and nv_matkhau = @matkhau
and nv_khoa != 1

exec [dbo].[Login] 'NV001','123'
GO
