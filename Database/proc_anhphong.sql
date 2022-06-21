CREATE PROC getAnhPhongs
@ap_maphong varchar(50)
AS 
BEGIN

select *
from anhphong ap
where ap.ap_maphong=@ap_maphong

END
GO

CREATE PROC insertAnhPhong
@ap_ma varchar(50),
@ap_maphong varchar(50),
@link varchar(50)
AS
BEGIN
insert into anhphong (ap_ma, ap_maphong, link)
values (@ap_ma, @ap_maphong, @link)
END

GO

CREATE PROC deleteAnhPhong
@ap_ma varchar(50)
AS
BEGIN
delete anhphong
where anhphong.ap_ma=@ap_ma
END