CREATE DATABASE CAFE_VERSION_1
GO
USE CAFE_VERSION_1

CREATE TABLE Account(
	username VARCHAR(100) NOT NULL PRIMARY KEY,
	password VARCHAR(100) NOT NULL DEFAULT '123',
	tenHienThi	NVARCHAR(50) DEFAULT N'Tài khoản mới',
	loaiTaiKhoan INT NOT NULL-- 0: NHÂN VIÊN & 1: ADMIN
)

ALTER TABLE Account ADD anhDaiDien IMAGE NULL

INSERT INTO Account(username, password, tenHienThi, loaiTaiKhoan, anhDaiDien) 
SELECT * FROM OPENROWSET(BULK N'E:\img101.png', SINGLE_BLOB) AS img

select * from Account
GO
ALTER TABLE Account ALTER COLUMN loaiTaiKhoan NVARCHAR(50)
select * from Account
delete from Account

delete  from HoaDon

insert Account(username, password, tenHienThi, loaiTaiKhoan) values('huy', '123', N'Lê Huy', N'Admin');
insert Account(username, password, tenHienThi, loaiTaiKhoan) values('h', '123', N'Ahihi', N'Nhân viên');

CREATE TABLE Ban(
	ID INT IDENTITY PRIMARY KEY,
	tenBan NVARCHAR(100) NOT NULL DEFAULT N'chưa có tên',
	trangThai NVARCHAR(50) NOT NULL DEFAULT N'Trống'
)
GO
CREATE TABLE DanhMuc(
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	tenDanhMuc NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',	
)
GO
CREATE TABLE DoUong(
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	tenThucUong NVARCHAR(100) NOT NULL DEFAULT N'chưa đặt tên',
	IDDanhMuc INT NOT NULL,
	gia FLOAT NOT NULL DEFAULT 0,
	FOREIGN KEY (IDDanhMuc) REFERENCES DanhMuc(ID)
)
GO 

CREATE TABLE HoaDon(
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	IDBan INT NOT NULL,
	ngayVao DATE NOT NULL DEFAULT GETDATE(),
	trangThai INT NOT NULL DEFAULT 0, --CHƯA THANH TOÁN
	FOREIGN KEY (IDBan) REFERENCES Ban(ID),
)
ALTER TABLE HoaDon ADD nguoiTao VARCHAR(100);
ALTER TABLE HoaDon ADD CONSTRAINT FK_NguoiTao FOREIGN KEY (nguoiTao) REFERENCES Account(username);
ALTER TABLE HoaDon ADD tongTien FLOAT

GO
CREATE TABLE ThongTinHoaDon(
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	IDHoaDon INT NOT NULL,
	IDDoUong INT NOT NULL,
	soLuong INT NOT NULL DEFAULT 0,
	FOREIGN KEY (IDDoUong) REFERENCES DoUong(ID),
	FOREIGN KEY (IDHoaDon) REFERENCES HoaDon(ID)
)
GO
INSERT Account(username, password, tenHienThi, loaiTaiKhoan) VALUES('nhanvien', '123', N'Nhân viên mới', 0);

--Tạo danh sách bàn
DECLARE @i INT = 1
WHILE @i <= 20
BEGIN
    INSERT Ban(tenBan) VALUES(N'Bàn ' + CAST(@i AS NVARCHAR(100)))
	SET @i = @i + 1
END
GO

ALTER PROC USP_LayDanhSachBan
AS
BEGIN
	SELECT * FROM Ban
END
GO

SELECT * FROM Ban where ID = 2

SELECT * FROM DoUong WHERE IDDanhMuc = 3
select * from Account
select * from HoaDon
select * from ThongTinHoaDon
GO

SELECT C.tenThucUong, B.soLuong, C.gia, (B.soLuong*c.gia) AS N'tongTien' 
FROM HoaDon AS A, ThongTinHoaDon AS B, DoUong AS C 
WHERE A.ID = B.IDHoaDon AND B.IDDoUong = C.ID AND A.IDBan = 1 AND A.trangThai = 0

CREATE PROC USP_ThemHoaDon
@idBan INT, @nguoitao VARCHAR(100)
AS
BEGIN
	INSERT HoaDon(IDBan, ngayVao, trangThai, nguoiTao) VALUES(@idBan, GETDATE(), 0, @nguoitao);
END
GO

ALTER PROC USP_ThemChiTietHaDon
@idHoaDon INT, @idDoUong INT, @sl INT
AS
BEGIN
	DECLARE @tonTaiCTHD INT
	DECLARE @soLuongDoUong INT = 0
	SELECT @tonTaiCTHD = ID, @soLuongDoUong = soLuong FROM ThongTinHoaDon 
	WHERE IDHoaDon = @idHoaDon AND IDDoUong = @idDoUong
	IF(@tonTaiCTHD > 0)
		BEGIN
			DECLARE @dem INT = @soLuongDoUong + @sl
			IF(@dem > 0)
			BEGIN
				UPDATE ThongTinHoaDon SET soLuong = @dem 
				WHERE IDDoUOng = @idDoUong AND IDHoaDon = @idHoaDon
			END
		END
	ELSE
		BEGIN
			INSERT ThongTinHoaDon(IDHoaDon, IDDoUong, soLuong) VALUES(@idHoaDon, @idDoUong, @sl)
		END
END
GO

ALTER TRIGGER UTG_CapNhatThongTinHoaDon
ON ThongTinHoaDon FOR INSERT, UPDATE
AS 
BEGIN
	DECLARE @idHoaDon INT 

	SELECT @idHoaDon = IDHoaDon FROM INSERTED

	DECLARE @idBan INT, @soLuong  INT

	SELECT @idBan = IDBan FROM HoaDon WHERE ID = @idHoaDon AND trangThai = 0

	SELECT @soLuong = COUNT(*)  FROM ThongTinHoaDon WHERE IDHoaDon = @idHoaDon

	IF(@soLuong > 0)
		BEGIN
		  Print 'So CTHD Khong the > 10'
			UPDATE Ban SET trangThai = N'Có người' WHERE ID = @idBan
		END
END
GO

Insert HoaDon(IDBan, ngayVao, nguoiTao) values(3, GETDATE(), 'huy')
Insert ThongTinHoaDon(IDHoaDon, IDDoUong, soLuong) values(36, 2, 1)
update ThongTinHoaDon set IDDoUong = 4, soLuong = 1 where IDHoaDon = 36 

ALTER TRIGGER UTG_CapNhatHoaDon
ON HoaDon FOR UPDATE
AS
BEGIN
	DECLARE @idHoaDon INT 

	SELECT @idHoaDon = ID FROM INSERTED

	DECLARE @idBan INT, @soLuong  INT = 0

	SELECT @idBan = IDBan FROM HoaDon WHERE ID = @idHoaDon

	SELECT @soLuong = COUNT(*) FROM HoaDon WHERE IDBan = @idBan AND trangThai = 0

	IF(@soLuong = 0)
		BEGIN
		print 'Trống'
			UPDATE Ban SET trangThai = N'Trống' WHERE ID = @idBan
		END
	
	ELSE
		BEGIN
		print 'Có người HD'
			UPDATE Ban SET trangThai = N'Có người' WHERE ID = @idBan
		END
END
GO



SELECT * FROM HoaDon
select * from ThongTinHoaDon

delete from ThongTinHoaDon
delete from HoaDon

select * from Ban
select * from DanhMuc

SELECT COUNT(*)  FROM HoaDon WHERE IDBan = 3 AND trangThai = 0

SELECT ID,tenDanhMuc AS N'Tên danh mục'  FROM DanhMuc

EXEC USP_LayDanhSachBan

delete from Ban Where ID > 22

select * from Ban
UPDATE Ban SET tenBan = N'Bàn mới' WHERE ID = 50
DELETE FROM Ban WHERE ID = 54


select * from Account

SELECT C.tenBan, A.tongTien FROM HoaDon AS A, ThongTinHoaDon AS B, Ban AS C WHERE A.ID = B.IDHoaDon AND A.IDBan = C.ID

GO
CREATE PROC USP_LayDanhHoaDonTheoNgay
@ngayVao DATE
AS
BEGIN
SELECT B.tenBan, A.tongTien, A.ngayVao, A.nguoiTao FROM HoaDon AS A, Ban AS B WHERE A.trangThai = 1 AND A.IDBan = B.ID AND A.ngayVao = @ngayVao
END

ALTER PROC USP_LayDanhHoaDonTheoThang
@thang INT
AS
BEGIN
	SELECT B.tenBan, A.tongTien, A.ngayVao, A.nguoiTao 
	FROM HoaDon AS A, Ban AS B WHERE A.trangThai = 1 AND A.IDBan = B.ID AND MONTH(A.ngayVao) = @thang
END
GO
Select * from HoaDon

Delete From ThongTinHoaDon
Delete From HoaDon Where trangThai = 0

SELECT B.tenBan, A.tongTien, A.ngayVao, A.nguoiTao FROM HoaDon AS A, Ban AS B WHERE A.trangThai = 1 AND A.IDBan = B.ID 

Select * from HoaDon


Select SUM(tongTien) from HoaDon WHERE MONTH(ngayVao) = '6'

Select SUM(tongTien) from HoaDon WHERE ngayVao = '2018/04/10'

SELECT SUM(tongTien) FROM HoaDon WHERE ngayVao = '24-04-2018'


SELECT COUNT(*) FROM HoaDon WHERE trangThai = 1

SELECT B.tenBan, A.tongTien, A.ngayVao, A.nguoiTao 
	FROM HoaDon AS A, Ban AS B WHERE A.trangThai = 1 AND A.IDBan = B.ID AND MONTH(A.ngayVao) = '14'


select * from Ban

UPDATE Account SET tenHienThi = N'wewe' , password = '111' WHERE username = 'hhh'



GO
ALter PROC USP_ChuyenBan
@idBan1 INT, @idBan2 INT, @nguoiTao Varchar(50)
AS 
BEGIN
	Declare @idHoaDonBan1 int 
	DECLARE @idHoaDonBan2 int

	declare @hoaDonTam1 int = 1
	declare @hoaDonTam2 int = 1

	select @idHoaDonBan2 = ID from dbo.HoaDon where IDBan = @idBan2 AND trangThai = 0
	select @idHoaDonBan1 = ID from dbo.HoaDon where IDBan = @idBan1 AND trangThai = 0

	IF(@idHoaDonBan1 is null)
		BEGIN
			INSERT dbo.HoaDon(IDBan, ngayVao, trangThai, nguoiTao) VALUES(@idBan1, GETDATE(), 0, @nguoiTao)
			select @idHoaDonBan1= MAX(ID) from dbo.HoaDon Where IDBan = @idBan1 And trangThai = 0
		END
	IF(@idHoaDonBan2 is null)
		BEGIN
			INSERT dbo.HoaDon(IDBan, ngayVao, trangThai, nguoiTao) VALUES(@idBan2, GETDATE(), 0, @nguoiTao)
			select @idHoaDonBan2= MAX(ID) from dbo.HoaDon Where IDBan = @idBan2 And trangThai = 0
		END

	select @hoaDonTam2 = COUNT(*) from dbo.ThongTinHoaDon WHERE IDHoaDon = @idHoaDonBan2

	Select ID INTO BangChuaIDTTHD from dbo.ThongTinHoaDon Where IDHoaDon = @idHoaDonBan2

	UPDATE dbo.ThongTinHoaDon SET IDHoaDon = @idHoaDonBan2 WHERE IDHoaDon = @idHoaDonBan1
	UPDATE dbo.ThongTinHoaDon SET IDHoaDon = @idHoaDonBan1 WHERE ID IN (Select * from BangChuaIDTTHD)

	DROP TABLE BangChuaIDTTHD

	DELETE FROM ThongTinHoaDon WHERE IDHoaDon = @idHoaDonBan1
	DELETE FROM HoaDon WHERE ID = @idHoaDonBan1

	IF(@hoaDonTam1 = 0)
		BEGIN
			UPDATE dbo.Ban SET trangThai = N'Trống' WHERE ID = @idBan2
		END

	IF(@hoaDonTam2 = 0)
	BEGIN
		UPDATE dbo.Ban SET trangThai = N'Trống' WHERE ID = @idBan1
	END

END
GO

ALTER PROC USP_GopBan
@idBan1 INT, @idBan2 INT
AS
BEGIN
	Declare @idHoaDonBan1 int 
	DECLARE @idHoaDonBan2 int
	Declare @idDoUongBan1 int
	Declare @idDoUongBan2 int
	Declare @soLuong1 int  = 0
	Declare @soLuong2 int = 0

	select @idHoaDonBan2 = ID from dbo.HoaDon where IDBan = @idBan2 AND trangThai = 0
	select @idHoaDonBan1 = ID from dbo.HoaDon where IDBan = @idBan1 AND trangThai = 0

	Select @idDoUongBan1 = IDDoUong from ThongTinHoaDon WHere IDHoaDon = @idHoaDonBan1
	Select @idDoUongBan2 = IDDoUong from ThongTinHoaDon WHere IDHoaDon = @idHoaDonBan2

	SELECT @soLuong1 = soLuong FROM ThongTinHoaDon WHERE IDHoaDon = @idHoaDonBan1 AND IDDoUong = @idDoUongBan1
	SELECT @soLuong2 = soLuong FROM ThongTinHoaDon WHERE IDHoaDon = @idHoaDonBan2 AND IDDoUong = @idDoUongBan2

	IF(@idHoaDonBan1 IS NOT NULL)
		BEGIN
			UPDATE dbo.ThongTinHoaDon Set soLuong = @soLuong1 + @soLuong2 WHERE IDHoaDon = @idHoaDonBan1 AND IDDoUong = @idDoUongBan1
			UPDATE dbo.HoaDon Set trangThai = 1 WHERE IDBan = @idBan2
			DELETE FROM ThongTinHoaDon WHERE IDHoaDon = @idHoaDonBan2
			DELETE FROM HoaDon WHERE ID = @idHoaDonBan2
		END
	IF(@idHoaDonBan2 IS NOT NULL)
		BEGIN

			UPDATE dbo.ThongTinHoaDon Set soLuong = @soLuong1 + @soLuong2 WHERE IDHoaDon = @idHoaDonBan2 AND IDDoUong = @idDoUongBan2
			UPDATE dbo.HoaDon Set trangThai = 1 WHERE IDBan = @idBan1

			DELETE FROM ThongTinHoaDon WHERE IDHoaDon = @idHoaDonBan1
			DELETE FROM HoaDon WHERE ID = @idHoaDonBan1
		END	
END
GO


Select IDDoUong from ThongTinHoaDon WHere IDHoaDon = 167
Select IDDoUong from ThongTinHoaDon WHere IDHoaDon = 173

select * from ThongTinHoaDon WHERE IDHoaDon  = 173

SELECT C.tenThucUong, B.soLuong, C.gia, B.soLuong*C.gia FROM HoaDon AS A, ThongTinHoaDon AS B, DoUong AS C 
WHERE A.ID = B.IDHoaDon AND B.IDDoUong = C.ID AND A.IDBan = 12

CREATE PROC USP_InHoaDon 
@idBan INT
AS
BEGIN
	SELECT C.tenThucUong, B.soLuong, C.gia, (B.soLuong*c.gia) AS N'tongTien' 
	FROM HoaDon AS A, ThongTinHoaDon AS B, DoUong AS C 
	WHERE A.ID = B.IDHoaDon AND B.IDDoUong = C.ID AND A.trangThai = 0 AND A.IDBan = @idBan
END

EXEC USP_InHoaDon @idBan = 3

--
select * from HoaDon Where trangThai = 0
select * from ThongTinHoaDon

Delete from ThongTinHoaDon where IDHoaDon  = 184 AND 
--Lấy IDDoUong

SELECT * FROM ThongTinHoaDon WHERE IDHoaDon = 185

SELECT * FROM HoaDon WHERE IDBan = 2 and trangThai = 0

UPDATE Account SET tenHienThi = N'Huy Lê Thái' , anhDaiDien = 'C:\Users\HUY\Desktop\pic1.jpg' WHERE username = 'huy'  AND password = '456' 