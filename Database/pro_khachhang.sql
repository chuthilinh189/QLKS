
CREATE proc [dbo].[getAllKhachhangs]
@manv varchar(50)
as
SELECT * FROM khachhang
GO


CREATE proc [dbo].[getKhachHangByMa]
@kh_ma varchar(50)
as
SELECT * FROM khachhang
WHERE khachhang.kh_ma = @kh_ma
GO

CREATE PROC insertKhachHang
@kh_ma varchar(50),
@kh_hoten nvarchar(50),
@kh_cmnd varchar(20),
@kh_sdt varchar(20),
@kh_email varchar(50),
@kh_diachi nvarchar(50)
AS
BEGIN
INSERT into khachhang (kh_ma, kh_hoten, kh_cmnd, kh_sdt, kh_email, kh_diachi)
VALUES (@kh_ma, @kh_hoten, @kh_cmnd, @kh_sdt, @kh_email, @kh_diachi)
END

GO

CREATE PROC updateKhachHang
@kh_ma varchar(50),
@kh_hoten nvarchar(50),
@kh_cmnd varchar(20),
@kh_sdt varchar(20),
@kh_email varchar(50),
@kh_diachi nvarchar(50)
AS
BEGIN
update khachhang set kh_hoten=@kh_hoten, kh_cmnd=@kh_cmnd, kh_sdt=@kh_sdt, kh_email=@kh_email, kh_diachi=@kh_diachi
where kh_ma=@kh_ma
END

GO

CREATE PROC deleteKhachHang
@kh_ma varchar(50)
AS
BEGIN
delete khachhang
Where kh_ma=@kh_ma
END



