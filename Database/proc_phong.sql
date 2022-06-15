CREATE proc [dbo].[getAllPhongs]
as
SELECT * FROM phong
GO

CREATE proc [dbo].[getPhongByMa]
@p_ma varchar(50)
as
SELECT * FROM phong
WHERE phong.p_ma = @p_ma
GO

CREATE proc [dbo].[getPhongByLoaiPhong]
@p_malp varchar(50)
as
SELECT * FROM phong
WHERE phong.p_malp = @p_malp
GO

CREATE proc [dbo].[searchPhongs]
@key nvarchar(100)
as
SELECT * FROM phong

WHERE phong.p_ma LIKE (N'%' + @key + N'%')
	OR phong.p_malp LIKE (N'%' + @key + N'%')
	OR phong.p_tinhtrang LIKE (N'%' + @key + N'%')
	OR phong.p_sophong LIKE (N'%' + @key + N'%')
	OR phong.p_solandat LIKE (N'%' + @key + N'%')
GO

CREATE proc [dbo].[insertPhong]
@p_ma varchar(50),
@p_malp varchar(50),
@p_tinhtrang smallint,
@p_sophong nvarchar(50),
@p_solandat int
AS
INSERT INTO phong(p_ma, p_malp,p_tinhtrang,p_sophong,p_solandat)
VALUES (@p_ma, @p_malp,@p_tinhtrang,@p_sophong,@p_solandat)

GO

CREATE proc [dbo].[updatePhong]
@p_ma varchar(50),
@p_malp varchar(50),
@p_tinhtrang smallint,
@p_sophong nvarchar(50),
@p_solandat int
AS
BEGIN 
update phong SET p_malp=@p_malp, p_tinhtrang=@p_tinhtrang, p_sophong=@p_sophong, p_solandat=@p_solandat
WHERE p_ma=@p_ma
END
GO