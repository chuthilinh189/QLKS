ALTER TABLE ctthuephong ADD cttp_dongia int
GO

ALTER TABLE ctphongdat ADD ctdp_dongia int
GO

ALTER proc [dbo].[updateNhanvien]
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
	UPDATE nhanvien SET nv_macv=@nv_macv, nv_hoten=@nv_hoten, nv_ngaysinh=@nv_ngaysinh, nv_gioitinh=@nv_gioitinh, nv_sdt=@nv_sdt, nv_cmnd=@nv_cmnd, nv_diachi=@nv_diachi, nv_email=@nv_email, nv_khoa=@nv_khoa, nv_maquyen=@nv_maquyen, nv_fileanh=@nv_fileanh
	WHERE nv_ma=@nv_ma
END
ELSE
BEGIN
	UPDATE nhanvien SET nv_macv=@nv_macv, nv_hoten=@nv_hoten, nv_ngaysinh=@nv_ngaysinh, nv_gioitinh=@nv_gioitinh, nv_sdt=@nv_sdt, nv_cmnd=@nv_cmnd, nv_diachi=@nv_diachi, nv_email=@nv_email, nv_khoa=@nv_khoa, nv_matkhau=@nv_matkhau, nv_maquyen=@nv_maquyen, nv_fileanh=@nv_fileanh
	WHERE nv_ma=@nv_ma
END
GO

ALTER PROC [dbo].[deleteNhanvien]
@nv_ma varchar(50)
AS
	UPDATE nhanvien SET nv_xoa=1
	WHERE nv_ma=@nv_ma
GO

CREATE PROC [dbo].[getAllTrangthietbis]
as
SELECT * FROM trangthietbi
ORDER BY trangthietbi.ttb_soluong DESC
GO

CREATE PROC [dbo].[getTrangthietbiByMa]
@ttb_ma varchar(50)
as
SELECT * FROM trangthietbi
WHERE trangthietbi.ttb_ma = @ttb_ma
ORDER BY trangthietbi.ttb_soluong DESC
GO

CREATE PROC [dbo].[searchTrangthietbis]
@key nvarchar(100)
as
SELECT * FROM trangthietbi
WHERE trangthietbi.ttb_ten LIKE (N'%' + @key + N'%')
ORDER BY trangthietbi.ttb_soluong DESC
GO

ALTER TABLE trangthietbi ADD ttb_ghichu nvarchar(200)
GO

CREATE PROC [dbo].[insertTrangthietbi]
@ttb_ma varchar(50),
@ttb_ten nvarchar(100),
@ttb_dongia int,
@ttb_donvitinh nvarchar(20),
@ttb_soluong int,
@ttb_ghichu nvarchar(200)
AS
INSERT INTO trangthietbi(ttb_ma, ttb_ten, ttb_dongia, ttb_donvitinh, ttb_soluong, ttb_ghichu)
VALUES (@ttb_ma, @ttb_ten, @ttb_dongia, @ttb_donvitinh, @ttb_soluong, @ttb_ghichu)
GO

CREATE proc [dbo].[updateTrangthietbi]
@ttb_ma varchar(50),
@ttb_ten nvarchar(100),
@ttb_dongia int,
@ttb_donvitinh nvarchar(20),
@ttb_soluong int,
@ttb_ghichu nvarchar(200)
AS
UPDATE trangthietbi SET ttb_ten = @ttb_ten, ttb_dongia = @ttb_dongia, ttb_donvitinh = @ttb_donvitinh, ttb_soluong=@ttb_soluong, ttb_ghichu=@ttb_ghichu 
WHERE ttb_ma=@ttb_ma
GO

CREATE PROC [dbo].[deleteTrangthietbi]
@ttb_ma varchar(50)
AS
DELETE trangthietbi WHERE ttb_ma=@ttb_ma
GO

ALTER TABLE phong_ttb ADD ttbp_ghichu nvarchar(200)
GO

CREATE proc [dbo].[getAllPhongttbs]
as
SELECT * FROM phong_ttb 
LEFT JOIN trangthietbi ON phong_ttb.ttbp_mattb = trangthietbi.ttb_ma
WHERE phong_ttb.ttbp_maphong = @p_ma
GO

CREATE proc [dbo].[getAllPhongttb_by_phong]
@p_ma varchar(50)
as
SELECT * FROM phong_ttb 
LEFT JOIN trangthietbi ON phong_ttb.ttbp_mattb = trangthietbi.ttb_ma
WHERE phong_ttb.ttbp_maphong = @p_ma
GO

CREATE PROC [dbo].[insertPhongttb]
@ttbp_ma varchar(50),
@ttbp_mattb varchar(50),
@ttbp_maphong varchar(50),
@ttbp_soluong int,
@ttbp_ghichu nvarchar(200)
AS
INSERT INTO phong_ttb(ttbp_ma, ttbp_mattb, ttbp_maphong, ttbp_soluong, ttbp_ghichu)
VALUES (@ttbp_ma, @ttbp_mattb, @ttbp_maphong, @ttbp_soluong, @ttbp_ghichu)
GO

CREATE proc [dbo].[updatePhongttb]
@ttbp_ma varchar(50),
@ttbp_mattb varchar(50),
@ttbp_maphong varchar(50),
@ttbp_soluong int,
@ttbp_ghichu nvarchar(200)
AS
UPDATE phong_ttb SET ttbp_mattb = @ttbp_mattb, ttbp_maphong = @ttbp_maphong, ttbp_soluong=@ttbp_soluong, ttbp_ghichu=@ttbp_ghichu 
WHERE ttbp_ma=@ttbp_ma
GO

CREATE PROC [dbo].[deletePhongttb]
@ttbp_ma varchar(50)
AS
DELETE phong_ttb WHERE ttbp_ma=@ttbp_ma
GO