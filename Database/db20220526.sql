USE QLKHACHSAN
GO

CREATE proc [dbo].[getAllChucvus]
as
SELECT * FROM chucvu
GO

CREATE proc [dbo].[getAllQuyens]
as
SELECT * FROM quyen
GO

CREATE proc [dbo].[getNhanvienByMa]
@manv varchar(50)
as
SELECT * FROM nhanvien
LEFT JOIN chucvu ON nhanvien.nv_macv = chucvu.cv_ma
LEFT JOIN quyen ON nhanvien.nv_maquyen = quyen.q_ma
WHERE nhanvien.nv_ma = @manv
GO

CREATE proc [dbo].[searchNhanviens]
@key nvarchar(100)
as
SELECT * FROM nhanvien
LEFT JOIN chucvu ON nhanvien.nv_macv = chucvu.cv_ma
LEFT JOIN quyen ON nhanvien.nv_maquyen = quyen.q_ma
WHERE nhanvien.nv_ma LIKE (N'%' + @key + N'%')
	OR nhanvien.nv_hoten LIKE (N'%' + @key + N'%')
	OR nhanvien.nv_sdt LIKE (N'%' + @key + N'%')
	OR nhanvien.nv_cmnd LIKE (N'%' + @key + N'%')
	OR nhanvien.nv_tdn LIKE (N'%' + @key + N'%')
	OR nhanvien.nv_diachi LIKE (N'%' + @key + N'%')
GO

