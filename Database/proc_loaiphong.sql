CREATE proc [dbo].[getAllLoaiPhongs]
as
SELECT * FROM loaiphong
GO
CREATE proc [dbo].[getLoaiPhongByMa]
@lp_ma varchar(50)
as
SELECT * FROM loaiphong
WHERE loaiphong.lp_ma = @lp_ma
GO

CREATE proc [dbo].[searchLoaiPhongs]
@key nvarchar(100)
as
SELECT * FROM loaiphong

WHERE loaiphong.lp_ma LIKE (N'%' + @key + N'%')
	OR loaiphong.lp_ten LIKE (N'%' + @key + N'%')
	OR loaiphong.lp_giaphong LIKE (N'%' + @key + N'%')
	OR loaiphong.lp_soluong LIKE (N'%' + @key + N'%')

GO

CREATE proc [dbo].[insertLoaiPhong]
@lp_ma varchar(50),
@lp_ten varchar(50),
@lp_giaphong int,
@lp_soluong int,
@lp_solandat int
AS
INSERT INTO loaiphong(lp_ma, lp_ten,lp_giaphong,lp_soluong,lp_solandat)
VALUES (@lp_ma,@lp_ten,@lp_giaphong,@lp_soluong,@lp_solandat)

GO