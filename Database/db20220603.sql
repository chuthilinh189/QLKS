CREATE PROC [dbo].[deleteNhanvien]
@nv_ma varchar(50)
AS
DELETE nhanvien WHERE nv_ma = @nv_ma
GO

CREATE proc [dbo].[changePassword]
@nv_tdn varchar(50),
@nv_matkhau varchar(50),
@matkhaumoi varchar(50)
AS
	UPDATE nhanvien SET nv_matkhau = @matkhaumoi
	WHERE LOWER(nv_tdn) = @nv_tdn AND nv_matkhau = @nv_matkhau
	AND nv_khoa != 1 AND nv_xoa != 1
GO


