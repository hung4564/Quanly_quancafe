USE [master]
GO
/****** Object:  Database [QLQuanCafe]    Script Date: 05/01/2018 21:50:42 ******/
CREATE DATABASE [QLQuanCafe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLQuanCafe', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QLQuanCafe.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLQuanCafe_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QLQuanCafe_log.ldf' , SIZE = 1088KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLQuanCafe] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLQuanCafe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLQuanCafe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLQuanCafe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLQuanCafe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLQuanCafe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLQuanCafe] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLQuanCafe] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLQuanCafe] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QLQuanCafe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLQuanCafe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLQuanCafe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLQuanCafe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLQuanCafe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLQuanCafe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLQuanCafe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLQuanCafe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLQuanCafe] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLQuanCafe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLQuanCafe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLQuanCafe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLQuanCafe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLQuanCafe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLQuanCafe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLQuanCafe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLQuanCafe] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLQuanCafe] SET  MULTI_USER 
GO
ALTER DATABASE [QLQuanCafe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLQuanCafe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLQuanCafe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLQuanCafe] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QLQuanCafe]
GO
/****** Object:  StoredProcedure [dbo].[ban_sua]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ban_sua] 
(
@maban int , 
@tenban nvarchar (50))
as
begin 
UPDATE [dbo].[BAN]
   SET [TenBan] = @tenban
      
 WHERE MaBan=@maban
end 

GO
/****** Object:  StoredProcedure [dbo].[ban_them]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ban_them] 
(
@TenBan nvarchar(50)
)
as 
begin 
INSERT INTO [dbo].[BAN]
           ([TenBan]
           ) values (@tenban)
		   end 

GO
/****** Object:  StoredProcedure [dbo].[ban_xoa]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ban_xoa]
(
@maban int 
)
as
begin 

DELETE FROM [dbo].[BAN]
      WHERE MaBan=@maban
	  end 


GO
/****** Object:  StoredProcedure [dbo].[chamcong_them]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[chamcong_them] @manv int,@gioBD time,@gioKT time,@ngay date
as
begin
if exists(select * from chamcong where manv=@manv and ngay=@ngay and(giobd<=@gioKT and @gioKT<=giokt) or (giobd<=@gioBD and @gioBD<=giokt))
begin
print 'trùng giờ'
end
else
begin
	INSERT INTO [dbo].[CHAMCONG]
           ([MaNV]
           ,[GioBD]
           ,[GioKT]
           ,[Ngay])
     VALUES
           (@manv
           ,@gioBd
           ,@gioKT
           ,@ngay)
end
end


GO
/****** Object:  StoredProcedure [dbo].[chamcong_xoa]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[chamcong_xoa] @manv int,@gioBD time,@gioKT time,@ngay date
as
begin
Delete from chamcong
where manv=@manv and giobd=@giobd and gioKT=@giokt and ngay=@ngay
end


GO
/****** Object:  StoredProcedure [dbo].[chucvu_sua]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[chucvu_sua]
(
@macv int , 
@tencv nvarchar (50)
)
as
begin 
update CHUCVU 
set [TenCV]=@tencv where MaCV=@macv
end 


GO
/****** Object:  StoredProcedure [dbo].[chucvu_them]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[chucvu_them]
(
@tencv nvarchar(50)
)
as 
begin 
insert into CHUCVU ([TenCV]) values (@tencv)
end




GO
/****** Object:  StoredProcedure [dbo].[Chuyenban]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Chuyenban] @mabangoc int,@mabanchuyen int
as
begin
update ban
set trangthai=N'Trống'
where maban = @mabangoc
update phieuthu
set maban =@mabanchuyen
where maban=@mabangoc and tinhtrang=0
update ban
set trangthai=N'Có người'
where maban = @mabanchuyen
end


GO
/****** Object:  StoredProcedure [dbo].[DOANH_THU_MAX]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc  [dbo].[DOANH_THU_MAX] 
as 

select month(giovao)as'thang',sum(thanhtien) as'tongtien' from Phieuthu group by month(giovao) order by tongtien DESC


GO
/****** Object:  StoredProcedure [dbo].[hoadon_nhap]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[hoadon_nhap] @mabill int,@masp int, @soluong int
as
begin
IF EXISTS(SELECT masp FROM chitietphieuthu WHERE mapt=@mabill and masp=@masp)
BEGIN
update chitietphieuthu
set soluong=@soluong
where mapt=@mabill and masp=@masp
END
ELSE
BEGIN
Declare @dongia int
select @dongia=DonGia from sanpham where masp=@masp
INSERT INTO [dbo].[CHITIETPHIEUTHU]
           ([MaPT],[MaSP],[SoLuong],[Dongia])
     VALUES
           (@mabill,@masp,@soluong,@dongia)
END
end


GO
/****** Object:  StoredProcedure [dbo].[hoadon_tao]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[hoadon_tao] @manv int,@maban int,@giovao DateTime
as
begin
update ban
set trangthai=N'Có người'
where maban=@maban
INSERT INTO [dbo].[PHIEUTHU]([MaNv],[MaKH],[Giovao],[Maban])
     VALUES(@manv,0,@giovao,@maban)
end


GO
/****** Object:  StoredProcedure [dbo].[hoadon_thanhtoan]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[hoadon_thanhtoan] @mapt int,@giora DateTIme,@chietkhau int,@thanhtien money
as
begin
update phieuthu
set [Giora]=@giora,[Tinhtrang] = 1,[Chietkhau]=@chietkhau,[ThanhTien]=@thanhtien
where mapt=@mapt
Declare @maban int
Select @maban=maban from phieuthu where mapt=@mapt
update ban
set TrangThai=N'Trống'
where maban=@maban
end


GO
/****** Object:  StoredProcedure [dbo].[khachhang_sua]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[khachhang_sua]
(
@makh int ,
@ten nvarchar(100),
@diachi nvarchar(200), 
@sdt varchar(20),
@loaikh nvarchar(100)
)
as 
begin 
update KHACHHANG
set [TenKH]=@ten,[DiaChi]=@diachi,[SDT]=@sdt,[LoaiKH]=@loaikh
where MaKH=@makh
end



GO
/****** Object:  StoredProcedure [dbo].[khachhang_them]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[khachhang_them]
(
@ten nvarchar(100),
@diachi nvarchar(200), 
@sdt varchar(20),
@loaikh nvarchar(100)
)
as 
begin 
insert into khachhang (TenKH,DiaChi,SDT,LoaiKH) values (@ten,@diachi,@sdt,@loaikh)
end 



GO
/****** Object:  StoredProcedure [dbo].[khachhang_xoa]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[khachhang_xoa](@makh int )
as
begin
	if(@makh>0)
	begin
	update  [dbo].[phieuthu]
	Set manv=0
    where makh = @makh
	end
	Delete from khachhang where makh =@makh
end


GO
/****** Object:  StoredProcedure [dbo].[luong_sua]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[luong_sua] 
(
@manv int , 
@luongcoban money, 
@hesoluong float, 
@phuccap money
)
as
begin 
update LUONG
set [LuongCoBan]=@luongcoban,[HeSoLuong]=@hesoluong,[PhuCap]=@phuccap where MaNV=@manv
end 



GO
/****** Object:  StoredProcedure [dbo].[luong_them]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[luong_them] 
(
 
@luongcoban money , 
@hesoluong float , 
@phucap money 
)
as 
begin 
insert into LUONG ([LuongCoBan],[HeSoLuong],[PhuCap]) values (@luongcoban,@hesoluong,@phucap)
end



GO
/****** Object:  StoredProcedure [dbo].[nguyenlieu_sua]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[nguyenlieu_sua]
(
@manl int , 
@tennl nvarchar (100)
)
as
begin 
update NGUYENLIEU 
set [TenNL]=@tennl
where MaNL=@manl
end


GO
/****** Object:  StoredProcedure [dbo].[nguyenlieu_them]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[nguyenlieu_them]
(
@tennl nvarchar (100)
)
as 
begin 
insert into NGUYENLIEU (TenNL) values (@tennl)
end


GO
/****** Object:  StoredProcedure [dbo].[nguyenlieu_xoa]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[nguyenlieu_xoa]
( @manl int 
)
as
begin 
update PHACHE
set manl= 0 
DELETE FROM [dbo].[NGUYENLIEU]

      WHERE MaNL=@manl
	  end



GO
/****** Object:  StoredProcedure [dbo].[nhacc_sua]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[nhacc_sua]
(
@Mancc int , 
@TenNCC nvarchar(100),
@DiaChi nvarchar(200),
@SDT varchar(20)
)
as
begin 
UPDATE [dbo].[NHACUNGCAP]
   SET [TenNCC] = @TenNCC, 
      [DiaChi] = @DiaChi
      ,[SDT] = @SDT

 WHERE MaNCC=@Mancc
 end 


GO
/****** Object:  StoredProcedure [dbo].[nhacc_them]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[nhacc_them]
(
@TenNCC nvarchar(100),
@DiaChi nvarchar(200),
@SDT varchar(20)

)
as
begin 
INSERT INTO [dbo].[NHACUNGCAP]
           ([TenNCC]
           ,[DiaChi]
           ,[SDT])
     VALUES
           (@TenNCC,
           @DiaChi,
           @SDT)
		   end 


GO
/****** Object:  StoredProcedure [dbo].[nhacc_xoa]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[nhacc_xoa]
(@mancc int )
as
begin 
DELETE FROM [dbo].[NHACUNGCAP]
      WHERE MaNCC=@mancc
	  end


GO
/****** Object:  StoredProcedure [dbo].[nhanvien_sua]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[nhanvien_sua](@manv int , @ten nvarchar(100), @ngaysinh date, @diachi nvarchar(200), @sdt varchar(20), @chucvu int)
as
begin
	update  [dbo].[NHANVIEN]
	Set[TenNV]=@ten,[NgaySinh]=@ngaysinh,[DiaChi]=@diachi,[SDT]=@sdt,[macv]=@chucvu
    where manv = @manv
	update Taikhoan
	set [type]=@chucvu
	where manv =@manv
end

GO
/****** Object:  StoredProcedure [dbo].[nhanvien_them]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[nhanvien_them] @ten nvarchar(100), @ngaysinh date, @diachi nvarchar(200), @sdt varchar(20), @macv int
as
begin
	INSERT INTO [dbo].[NHANVIEN]
           ([TenNV],[NgaySinh],[DiaChi],[SDT],[macv])
     VALUES
           (@ten
           , @ngaysinh 
           ,@diachi
           ,@sdt
           ,@macv)
	Declare @manv int
	Select @manv=Max(Manv) from nhanvien
	print @manv	   
INSERT INTO [dbo].[LUONG]
           ([MaNV],[LuongCoBan],[HeSoLuong],[PhuCap])
     VALUES
           (@manv,3000000,1,0)
INSERT INTO [dbo].[TAIKHOAN]
           ([MaNV],[UserName],[Password],[Type])
     VALUES
           (@manv,dbo.taodk(@macv,@manv),'1',@macv)
end

GO
/****** Object:  StoredProcedure [dbo].[nhanvien_xoa]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[nhanvien_xoa](@manv int )
as
begin
if(@manv>0)
begin
	Delete from chamcong where manv =@manv
	Delete from luong where manv =@manv
	update  [dbo].[phieunhap]
	Set manv=0
    where manv = @manv
	update  [dbo].[phieuthu]
	Set manv=0
    where manv = @manv
	Delete from [taikhoan] where manv = @manv
	delete from CHAMCONG where MaNV=@manv
	delete from luong where MaNV=@manv
	Delete from nhanvien where manv =@manv	
	
	end
end


GO
/****** Object:  StoredProcedure [dbo].[phache_nhap]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[phache_nhap] @masp int,@manl int,@soluong int
as
begin
INSERT INTO [dbo].[PHACHE]
           ([MaNL]
           ,[SLl]
           ,[MaSP])
     VALUES
           (@manl
           ,@soluong
           ,@masp )
end


GO
/****** Object:  StoredProcedure [dbo].[phieunhap_nhap]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[phieunhap_nhap] @maPN int,@manl int,@dongia money,@soluong int
as
INSERT INTO [dbo].[CHITIETPHIEUNHAP]
           ([MaPN]
           ,[MaNL]
           ,[Thanhtien]
           ,[SoLuong])
     VALUES
           (@maPN
           ,@manl
           ,@dongia
           ,@soluong )


GO
/****** Object:  StoredProcedure [dbo].[phieunhap_them]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[phieunhap_them] @manv int,@mancc int,@ngay date,@thanhtien money
as
INSERT INTO [dbo].[PHIEUNHAP]
           ([MaNv]
           ,[MaNCC]
           ,[Ngay]
           ,[ThanhTien])
     VALUES
           (@manv 
           ,@mancc
           ,@ngay
           ,@thanhtien)



GO
/****** Object:  StoredProcedure [dbo].[sanpham_sua]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sanpham_sua]
(
@masp int , 
@tensp nvarchar (50),
@dongia money 
)
as 
begin 
update SANPHAM 
set [TenSP]=@tensp, [DonGia]=@dongia where MaSP= @masp
end



GO
/****** Object:  StoredProcedure [dbo].[sanpham_them]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sanpham_them] 
(
@tensp nvarchar(50),
@dongia money
)
as 
begin 
insert into SANPHAM ([TenSP],[DonGia]) values (@tensp,@dongia)
end




GO
/****** Object:  StoredProcedure [dbo].[sanpham_xoa]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sanpham_xoa]
(
@masp int 
)
as 
begin 
if(@masp>0)
begin
update CHitietphieuthu
set Masp=0 where MaSP= @masp
Delete from phache where masp=@masp
Delete from sanpham where masp=@masp
end
end


GO
/****** Object:  StoredProcedure [dbo].[USP_hoadon]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_hoadon] @ngaybatdau Date, @ngayketthuc date
as
begin
	select phieuthu.mapt,manv,ngay,phieuthu.thanhtien from phieuthu,chitietphieuthu where phieuthu.mapt=chitietphieuthu.mapt and phieuthu.ngay>@ngaybatdau and phieuthu.ngay<@ngayketthuc

end




GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Login] @username nvarchar(50),@password nvarchar(50)
AS
BEGIN
	SELECT * FROM dbo.TAIKHOAN WHERE UserName= @userName AND [Password]=@password
END




GO
/****** Object:  StoredProcedure [dbo].[USP_nhacungcap]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_nhacungcap]
AS
BEGIN
	Select top 3 Tenncc from Phieunhap,NHACungcap,ChitietPhieunhap
	where NHACungcap.MaNCC=phieunhap.MaNCC and phieunhap.mapn=chitietphieunhap.mapn
	group by tenNCC order by count(tenNcc) DESC
END




GO
/****** Object:  StoredProcedure [dbo].[USP_nhanvienchamchi]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_nhanvienchamchi]
as
begin
SELECT top 3 tennv,sum(DATEDIFF(minute,CHAMCONG.GioBD,CHAMCONG.GioKT)/60)AS 'Sogiolam'
FROM CHAMCONG,NHANVIEN WHERE chamcong.manv=nhanvien.manv group by NHANVIEN.manv,tennv order by sogiolam desc
end




GO
/****** Object:  StoredProcedure [dbo].[USP_sanpham_max]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[USP_sanpham_max]
AS
BEGIN
	Select top 5 with ties tenSP,DonGia from sanpham order by DonGia DESC
END




GO
/****** Object:  StoredProcedure [dbo].[USP_sanpham_min]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[USP_sanpham_min]
AS
BEGIN
	Select top 5 with ties tenSP,DonGia from sanpham order by DonGia
END




GO
/****** Object:  UserDefinedFunction [dbo].[fuConvertToUnsign1]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END





GO
/****** Object:  UserDefinedFunction [dbo].[taodk]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[taodk](@macv int,@manv int)
returns nvarchar
as
begin

declare @tencv nvarchar(50)
if(@macv=0)
begin
set @tencv='admin'+Convert(nvarchar(50),@manv)

end
else
begin
set @tencv='staff'+Convert(nvarchar(50),@manv)
end
return @tencv
end

GO
/****** Object:  UserDefinedFunction [dbo].[tinhluong]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[tinhluong] (@lcb float, @hsl float, @giolam float)
returns float
as
Begin
	Declare @kq float
	set @kq = @giolam*@lcb*@hsl
	return (@kq)
End



GO
/****** Object:  UserDefinedFunction [dbo].[tr]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[tr] (@a time,@b time)
returns float
as
begin
Declare @c float
set @c= convert(float,datediff(minute,@a,@b))
set @c=@c/60
return (@c)
end



GO
/****** Object:  Table [dbo].[BAN]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAN](
	[MaBan] [int] IDENTITY(0,1) NOT NULL,
	[TenBan] [nvarchar](50) NULL,
	[TrangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_BAN] PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHAMCONG]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHAMCONG](
	[MaNV] [int] NOT NULL,
	[GioBD] [time](7) NOT NULL,
	[GioKT] [time](7) NULL,
	[Ngay] [date] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETPHIEUNHAP]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUNHAP](
	[MaPN] [int] NOT NULL,
	[MaNL] [int] NOT NULL,
	[Thanhtien] [money] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_CHITIETPHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaNL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETPHIEUTHU]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUTHU](
	[MaPT] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[Dongia] [money] NULL,
 CONSTRAINT [PK_CHITIETPHIEUTHU] PRIMARY KEY CLUSTERED 
(
	[MaPT] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MaCV] [int] NOT NULL,
	[TenCV] [nvarchar](50) NULL,
 CONSTRAINT [PK_CHUCVU] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [int] IDENTITY(0,1) NOT NULL,
	[TenKH] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[SDT] [varchar](20) NULL,
	[LoaiKH] [nvarchar](100) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LUONG]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LUONG](
	[MaNV] [int] NOT NULL,
	[LuongCoBan] [money] NULL,
	[HeSoLuong] [float] NULL,
	[PhuCap] [money] NULL,
 CONSTRAINT [PK_LUONG] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NGUYENLIEU]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUYENLIEU](
	[MaNL] [int] IDENTITY(1,1) NOT NULL,
	[TenNL] [nvarchar](100) NULL,
 CONSTRAINT [PK_NGUYENLIEU_1] PRIMARY KEY CLUSTERED 
(
	[MaNL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MaNCC] [int] IDENTITY(1,1) NOT NULL,
	[TenNCC] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[SDT] [varchar](20) NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [int] IDENTITY(0,1) NOT NULL,
	[TenNV] [nvarchar](100) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](200) NULL,
	[SDT] [varchar](20) NULL,
	[MaCV] [int] NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHACHE]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHACHE](
	[MaNL] [int] NOT NULL,
	[SLl] [nchar](10) NULL,
	[MaSP] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MaNv] [int] NULL,
	[MaNCC] [int] NULL,
	[MaPN] [int] IDENTITY(1,1) NOT NULL,
	[Ngay] [date] NULL,
	[ThanhTien] [nchar](10) NULL,
 CONSTRAINT [PK_PHIEUNHAP_1] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUTHU]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTHU](
	[MaPT] [int] IDENTITY(1,1) NOT NULL,
	[MaNv] [int] NULL,
	[MaKH] [int] NULL,
	[Giovao] [datetime] NULL,
	[Giora] [datetime] NULL,
	[Maban] [int] NULL,
	[ThanhTien] [money] NULL,
	[Tinhtrang] [int] NULL,
	[Chietkhau] [int] NULL,
 CONSTRAINT [PK_PHIEUTHU] PRIMARY KEY CLUSTERED 
(
	[MaPT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MaSP] [int] IDENTITY(0,1) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[DonGia] [money] NULL,
 CONSTRAINT [PK_SAPPHAM] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[MaNV] [int] NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Type] [varchar](50) NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[BANG_LUONG]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[BANG_LUONG] AS
select nv.TenNV, dbo.tinhluong(luong.LuongCoBan, luong.HeSoLuong, dbo.tr(cc.gioBD, cc.gioKT)) AS [Lương Tháng]
from Nhanvien as NV, luong, chamcong as cc where nv.manv = luong.MaNV and luong.MaNV = cc.MaNV 
and nv.manv > 0


GO
/****** Object:  View [dbo].[HOA_DON_MAX]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[HOA_DON_MAX] AS
Select Top 3 * from Phieuthu order by Thanhtien DESC


GO
/****** Object:  View [dbo].[KHACH_HANG_TIEM_NANG ]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[KHACH_HANG_TIEM_NANG ] AS
select Khachhang.TenKH, sum(Phieuthu.Thanhtien) AS [Tổng tiền] from Khachhang, Phieuthu
where Khachhang.MaKH = Phieuthu.MaKH and Phieuthu.MaKH >0 group by Khachhang.TenKH


GO
/****** Object:  View [dbo].[NGUYENLIEUNHAPNHIEUTIENNHAT]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[NGUYENLIEUNHAPNHIEUTIENNHAT] AS
select nl.TenNL, sum(ctpn.Thanhtien) AS 'Thành tiền' from Nguyenlieu as nl, Chitietphieunhap as ctpn
where ctpn.MaNL > 0 and nl.manl = ctpn.manl group by nl.tennl


GO
/****** Object:  View [dbo].[NHA_CUNG_CAP_TIN_CAY]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[NHA_CUNG_CAP_TIN_CAY] AS
Select Top 3 ncc.TenNCC as [Tên NCC], ncc.DiaChi as [Địa chỉ], ncc.SDT as [Số điện thoại], sum(ctpn.soluong) as [Số lượng] 
from Nhacungcap as ncc, Phieunhap as pn, Chitietphieunhap ctpn 
where ncc.mancc = pn.mancc and pn.mapn = ctpn.mapn group by ncc.Tenncc, ncc.Diachi, ncc.SDT --order by sum(ctpn.Soluong) DESC


GO
/****** Object:  View [dbo].[NHAN_VIEN_CHAM_CHI_NHAT]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[NHAN_VIEN_CHAM_CHI_NHAT] AS
select NV.TenNV, sum(dbo.tr(cc.GioBD, cc.GioKT)) as [Số giờ làm] from chamcong as cc, nhanvien as nv 
where nv.manv = cc.manv and nv.manv > 0 group by nv.tennv


GO
/****** Object:  View [dbo].[SAN_PHAM_DAT_NHAT]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[SAN_PHAM_DAT_NHAT] AS
SELECT TOP 3 TenSP, DonGia FROM Sanpham where Masp > 0  order by DonGia DESC 
GO
/****** Object:  View [dbo].[SAN_PHAM_MAX]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[SAN_PHAM_MAX] AS
select top 3 Sanpham.Masp, Sanpham.Tensp, sum(soluong) as 'Số Lượng' from chitietphieuthu, sanpham 
where sanpham.masp = chitietphieuthu.masp and Sanpham.masp > 0 group by sanpham.masp, sanpham.tenSP order by sum(soluong) DESc


GO
/****** Object:  View [dbo].[SAN_PHAM_MIN]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[SAN_PHAM_MIN] AS
select top 3 Sanpham.Masp, Sanpham.Tensp, sum(soluong) as 'Số Lượng'from chitietphieuthu, sanpham 
where sanpham.masp = chitietphieuthu.masp and Sanpham.masp > 0 group by sanpham.masp, sanpham.tenSP order by sum(soluong) ASC


GO
/****** Object:  View [dbo].[SAN_PHAM_RE_NHAT]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[SAN_PHAM_RE_NHAT] AS
SELECT TOP 3 TenSP, DonGia FROM Sanpham where Masp > 0  order by DonGia ASC 
GO
/****** Object:  View [dbo].[THONG_KE_CHUC_VU]    Script Date: 05/01/2018 21:50:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[THONG_KE_CHUC_VU] AS
Select Chucvu.TenCV, Count(MaNV) AS [Số lượng] from Chucvu, nhanvien 
where chucvu.MACV = NHANVIEN.MACV group by Chucvu.tencv


GO
SET IDENTITY_INSERT [dbo].[BAN] ON 

INSERT [dbo].[BAN] ([MaBan], [TenBan], [TrangThai]) VALUES (0, N'Mang về', N'Trống')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [TrangThai]) VALUES (1, N'Bàn 1', N'Trống')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [TrangThai]) VALUES (2, N'Bàn 2', N'Có người')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [TrangThai]) VALUES (3, N'Bàn 3', N'Trống')
SET IDENTITY_INSERT [dbo].[BAN] OFF
INSERT [dbo].[CHAMCONG] ([MaNV], [GioBD], [GioKT], [Ngay]) VALUES (2, CAST(0x0700E03495640000 AS Time), CAST(0x070050CFDF960000 AS Time), CAST(0x2E3E0B00 AS Date))
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaNL], [Thanhtien], [SoLuong]) VALUES (2, 2, 4.0000, 1200000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaNL], [Thanhtien], [SoLuong]) VALUES (3, 2, 4.0000, 1000000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaNL], [Thanhtien], [SoLuong]) VALUES (3, 3, 6.0000, 100000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaNL], [Thanhtien], [SoLuong]) VALUES (4, 3, 4.0000, 10000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (1, 0, 4, 20000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (1, 1, 2, 20000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (1, 3, 3, 30000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (2, 1, 3, 20000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (4, 0, 2, 30000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (4, 1, 1, 20000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (5, 3, 4, 20000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (6, 3, 2, 20000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (7, 0, 5, 30000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (7, 1, 3, 20000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (7, 3, 4, 20000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (8, 0, 5, 30000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (8, 1, 2, 20000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (8, 3, 1, 20000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (9, 1, 1, 20000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (10, 1, 1, 20000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (10, 3, 2, 20000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (10, 4, 2, 20000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (11, 1, 3, 20000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (11, 3, 3, 20000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (11, 4, 4, 20000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (11, 5, 3, 20000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (11, 6, 2, 20000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (12, 3, 2, 20000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (12, 4, 2, 20000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (12, 5, 2, 20000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (13, 1, 2, 20000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (13, 3, 3, 20000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (13, 4, 2, 20000.0000)
INSERT [dbo].[CHITIETPHIEUTHU] ([MaPT], [MaSP], [SoLuong], [Dongia]) VALUES (13, 5, 2, 20000.0000)
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (0, N'Quản lý')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (1, N'Phục vụ')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (2, N'Pha chế')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (3, N'Bảo vệ')
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON 

INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [SDT], [LoaiKH]) VALUES (0, N'Khách lạ', NULL, NULL, NULL)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [SDT], [LoaiKH]) VALUES (1, N'Nguyễn Văn A', N'Hà nội', N'1234567890', N'')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [SDT], [LoaiKH]) VALUES (2, N'Nguyễn Văn B', N'Bắc ninh', N'123123124', N'')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [SDT], [LoaiKH]) VALUES (3, N'Nguyễn Văn C', N'Nam định', N'23234234234234', N'')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [SDT], [LoaiKH]) VALUES (4, N'Nguyễn Văn D', N'wewqe', N'123123123', N'')
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF
INSERT [dbo].[LUONG] ([MaNV], [LuongCoBan], [HeSoLuong], [PhuCap]) VALUES (2, 3000000.0000, 1, 0.0000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCoBan], [HeSoLuong], [PhuCap]) VALUES (3, 3000000.0000, 1, 0.0000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCoBan], [HeSoLuong], [PhuCap]) VALUES (4, 3000000.0000, 1, 0.0000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCoBan], [HeSoLuong], [PhuCap]) VALUES (5, 3000000.0000, 1, 0.0000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCoBan], [HeSoLuong], [PhuCap]) VALUES (6, 3000000.0000, 1, 0.0000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCoBan], [HeSoLuong], [PhuCap]) VALUES (7, 3000000.0000, 1, 0.0000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCoBan], [HeSoLuong], [PhuCap]) VALUES (8, 3000000.0000, 1, 0.0000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCoBan], [HeSoLuong], [PhuCap]) VALUES (9, 3000000.0000, 1, 0.0000)
SET IDENTITY_INSERT [dbo].[NGUYENLIEU] ON 

INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNL]) VALUES (2, N'cafe nguyên chất')
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNL]) VALUES (3, N'Sữa')
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNL]) VALUES (4, N'cafe')
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNL]) VALUES (5, N'cafe trắng ')
SET IDENTITY_INSERT [dbo].[NGUYENLIEU] OFF
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] ON 

INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (1, N'Vườn cafe', N'NNnull', N'Nnull')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (3, N'TH', N'Nf', N'f')
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] OFF
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON 

INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [DiaChi], [SDT], [MaCV]) VALUES (0, N'Đã xóa', NULL, NULL, NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [DiaChi], [SDT], [MaCV]) VALUES (2, N'Phạm Viết A', CAST(0xBA3D0B00 AS Date), N'Hà nội', N'0123456789', 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [DiaChi], [SDT], [MaCV]) VALUES (3, N'Phạm Viết B', CAST(0x2E3E0B00 AS Date), N'Hà nội', N'0123456789', 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [DiaChi], [SDT], [MaCV]) VALUES (4, N'Lương hữu A', CAST(0x2E3E0B00 AS Date), N'Hà nội', N'0123456789', 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [DiaChi], [SDT], [MaCV]) VALUES (5, N'Phạm Viết B', CAST(0x2E3E0B00 AS Date), N'Hà nội', N'0123456789', 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [DiaChi], [SDT], [MaCV]) VALUES (6, N'Nguyễn thị A', CAST(0x2E3E0B00 AS Date), N'Hà nội', N'0123456789', 2)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [DiaChi], [SDT], [MaCV]) VALUES (7, N'Nguyễn văn A', CAST(0xBA3D0B00 AS Date), N'Hà nội', N'0123456789', 2)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [DiaChi], [SDT], [MaCV]) VALUES (8, N'Nguyễn văn B', CAST(0xBA3D0B00 AS Date), N'Hà nội', N'0123456789', 3)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [DiaChi], [SDT], [MaCV]) VALUES (9, N'Nguyễn văn C', CAST(0x2E3E0B00 AS Date), N'Hà nội', N'0123456789', 3)
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
INSERT [dbo].[PHACHE] ([MaNL], [SLl], [MaSP]) VALUES (2, N'4         ', 1)
INSERT [dbo].[PHACHE] ([MaNL], [SLl], [MaSP]) VALUES (2, N'4         ', 4)
INSERT [dbo].[PHACHE] ([MaNL], [SLl], [MaSP]) VALUES (3, N'4         ', 4)
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] ON 

INSERT [dbo].[PHIEUNHAP] ([MaNv], [MaNCC], [MaPN], [Ngay], [ThanhTien]) VALUES (0, NULL, 1, NULL, NULL)
INSERT [dbo].[PHIEUNHAP] ([MaNv], [MaNCC], [MaPN], [Ngay], [ThanhTien]) VALUES (0, 1, 2, CAST(0xBA3D0B00 AS Date), N'4800000.00')
INSERT [dbo].[PHIEUNHAP] ([MaNv], [MaNCC], [MaPN], [Ngay], [ThanhTien]) VALUES (0, 1, 3, CAST(0x2E3E0B00 AS Date), N'4600000.00')
INSERT [dbo].[PHIEUNHAP] ([MaNv], [MaNCC], [MaPN], [Ngay], [ThanhTien]) VALUES (0, 3, 4, CAST(0xF13D0B00 AS Date), N'  40000.00')
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] OFF
SET IDENTITY_INSERT [dbo].[PHIEUTHU] ON 

INSERT [dbo].[PHIEUTHU] ([MaPT], [MaNv], [MaKH], [Giovao], [Giora], [Maban], [ThanhTien], [Tinhtrang], [Chietkhau]) VALUES (1, 0, 0, CAST(0x0000A85B00000000 AS DateTime), CAST(0x0000A8960130BBB8 AS DateTime), 1, 210000.0000, 1, 0)
INSERT [dbo].[PHIEUTHU] ([MaPT], [MaNv], [MaKH], [Giovao], [Giora], [Maban], [ThanhTien], [Tinhtrang], [Chietkhau]) VALUES (2, 0, 0, CAST(0x0000A85B00000000 AS DateTime), CAST(0x0000A8960130B834 AS DateTime), 2, 60000.0000, 1, 0)
INSERT [dbo].[PHIEUTHU] ([MaPT], [MaNv], [MaKH], [Giovao], [Giora], [Maban], [ThanhTien], [Tinhtrang], [Chietkhau]) VALUES (4, 0, 0, CAST(0x0000A896011D5550 AS DateTime), CAST(0x0000A89601309AE8 AS DateTime), 3, 80000.0000, 1, 0)
INSERT [dbo].[PHIEUTHU] ([MaPT], [MaNv], [MaKH], [Giovao], [Giora], [Maban], [ThanhTien], [Tinhtrang], [Chietkhau]) VALUES (5, 0, 0, CAST(0x0000A8960130C194 AS DateTime), CAST(0x0000A89601345020 AS DateTime), 3, 210000.0000, 1, 0)
INSERT [dbo].[PHIEUTHU] ([MaPT], [MaNv], [MaKH], [Giovao], [Giora], [Maban], [ThanhTien], [Tinhtrang], [Chietkhau]) VALUES (6, 0, 0, CAST(0x0000A8960130C644 AS DateTime), CAST(0x0000A896013432D4 AS DateTime), 2, 250000.0000, 1, 0)
INSERT [dbo].[PHIEUTHU] ([MaPT], [MaNv], [MaKH], [Giovao], [Giora], [Maban], [ThanhTien], [Tinhtrang], [Chietkhau]) VALUES (7, 0, 0, CAST(0x0000A89601345728 AS DateTime), CAST(0x0000A89601345E30 AS DateTime), 1, 290000.0000, 1, 0)
INSERT [dbo].[PHIEUTHU] ([MaPT], [MaNv], [MaKH], [Giovao], [Giora], [Maban], [ThanhTien], [Tinhtrang], [Chietkhau]) VALUES (8, 0, 0, CAST(0x0000A85E0110F6E8 AS DateTime), CAST(0x0000A8D3014EFB78 AS DateTime), 2, 210000.0000, 1, 0)
INSERT [dbo].[PHIEUTHU] ([MaPT], [MaNv], [MaKH], [Giovao], [Giora], [Maban], [ThanhTien], [Tinhtrang], [Chietkhau]) VALUES (9, 0, 0, CAST(0x0000A8D301339F2C AS DateTime), CAST(0x0000A8D3014F0028 AS DateTime), 1, 20000.0000, 1, 0)
INSERT [dbo].[PHIEUTHU] ([MaPT], [MaNv], [MaKH], [Giovao], [Giora], [Maban], [ThanhTien], [Tinhtrang], [Chietkhau]) VALUES (10, 0, 0, CAST(0x0000A8D3015F9E10 AS DateTime), CAST(0x0000A8D3015FA3EC AS DateTime), 1, 100000.0000, 1, 0)
INSERT [dbo].[PHIEUTHU] ([MaPT], [MaNv], [MaKH], [Giovao], [Giora], [Maban], [ThanhTien], [Tinhtrang], [Chietkhau]) VALUES (11, 0, 0, CAST(0x0000A8D3015FC4BC AS DateTime), CAST(0x0000A8D3015FC840 AS DateTime), 1, 300000.0000, 1, 0)
INSERT [dbo].[PHIEUTHU] ([MaPT], [MaNv], [MaKH], [Giovao], [Giora], [Maban], [ThanhTien], [Tinhtrang], [Chietkhau]) VALUES (12, 0, 0, CAST(0x0000A8D3015FD074 AS DateTime), CAST(0x0000A8D3015FD524 AS DateTime), 1, 200000.0000, 1, 0)
INSERT [dbo].[PHIEUTHU] ([MaPT], [MaNv], [MaKH], [Giovao], [Giora], [Maban], [ThanhTien], [Tinhtrang], [Chietkhau]) VALUES (13, 0, 0, CAST(0x0000A8D301606674 AS DateTime), NULL, 2, 0.0000, 0, 0)
SET IDENTITY_INSERT [dbo].[PHIEUTHU] OFF
SET IDENTITY_INSERT [dbo].[SANPHAM] ON 

INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonGia]) VALUES (0, N'Đã xóa', 0.0000)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonGia]) VALUES (1, N'cafe', 20000.0000)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonGia]) VALUES (3, N'7up', 20000.0000)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonGia]) VALUES (4, N'cafe cabuchino', 20000.0000)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonGia]) VALUES (5, N'cafe nâu đen', 20000.0000)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [DonGia]) VALUES (6, N'cafe sữa', 20000.0000)
SET IDENTITY_INSERT [dbo].[SANPHAM] OFF
INSERT [dbo].[TAIKHOAN] ([MaNV], [UserName], [Password], [Type]) VALUES (0, N'admin', N'1', N'0')
INSERT [dbo].[TAIKHOAN] ([MaNV], [UserName], [Password], [Type]) VALUES (2, N'a', N'1', N'0')
INSERT [dbo].[TAIKHOAN] ([MaNV], [UserName], [Password], [Type]) VALUES (3, N's', N'1', N'1')
INSERT [dbo].[TAIKHOAN] ([MaNV], [UserName], [Password], [Type]) VALUES (4, N's', N'1', N'1')
INSERT [dbo].[TAIKHOAN] ([MaNV], [UserName], [Password], [Type]) VALUES (5, N's', N'1', N'1')
INSERT [dbo].[TAIKHOAN] ([MaNV], [UserName], [Password], [Type]) VALUES (6, N's', N'1', N'2')
INSERT [dbo].[TAIKHOAN] ([MaNV], [UserName], [Password], [Type]) VALUES (7, N's', N'1', N'2')
INSERT [dbo].[TAIKHOAN] ([MaNV], [UserName], [Password], [Type]) VALUES (8, N's', N'1', N'3')
INSERT [dbo].[TAIKHOAN] ([MaNV], [UserName], [Password], [Type]) VALUES (9, N's', N'1', N'3')
ALTER TABLE [dbo].[BAN] ADD  CONSTRAINT [DF_BAN_TrangThai]  DEFAULT (N'Trống''') FOR [TrangThai]
GO
ALTER TABLE [dbo].[LUONG] ADD  CONSTRAINT [DF_LUONG_LuongCoBan]  DEFAULT ((0)) FOR [LuongCoBan]
GO
ALTER TABLE [dbo].[LUONG] ADD  CONSTRAINT [DF_LUONG_HeSoLuong]  DEFAULT ((0)) FOR [HeSoLuong]
GO
ALTER TABLE [dbo].[LUONG] ADD  CONSTRAINT [DF_LUONG_PhuCap]  DEFAULT ((0)) FOR [PhuCap]
GO
ALTER TABLE [dbo].[PHIEUTHU] ADD  CONSTRAINT [DF_PHIEUTHU_ThanhTien]  DEFAULT ((0)) FOR [ThanhTien]
GO
ALTER TABLE [dbo].[PHIEUTHU] ADD  CONSTRAINT [DF_PHIEUTHU_Tinhtrang]  DEFAULT ((0)) FOR [Tinhtrang]
GO
ALTER TABLE [dbo].[PHIEUTHU] ADD  CONSTRAINT [DF_PHIEUTHU_Chietkhau]  DEFAULT ((0)) FOR [Chietkhau]
GO
ALTER TABLE [dbo].[CHAMCONG]  WITH CHECK ADD  CONSTRAINT [FK_CHAMCONG_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[CHAMCONG] CHECK CONSTRAINT [FK_CHAMCONG_NHANVIEN]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUNHAP_NGUYENLIEU] FOREIGN KEY([MaNL])
REFERENCES [dbo].[NGUYENLIEU] ([MaNL])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [FK_CHITIETPHIEUNHAP_NGUYENLIEU]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUNHAP_PHIEUNHAP1] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PHIEUNHAP] ([MaPN])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [FK_CHITIETPHIEUNHAP_PHIEUNHAP1]
GO
ALTER TABLE [dbo].[CHITIETPHIEUTHU]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUTHU_PHIEUTHU] FOREIGN KEY([MaPT])
REFERENCES [dbo].[PHIEUTHU] ([MaPT])
GO
ALTER TABLE [dbo].[CHITIETPHIEUTHU] CHECK CONSTRAINT [FK_CHITIETPHIEUTHU_PHIEUTHU]
GO
ALTER TABLE [dbo].[CHITIETPHIEUTHU]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUTHU_SAPPHAM] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SANPHAM] ([MaSP])
GO
ALTER TABLE [dbo].[CHITIETPHIEUTHU] CHECK CONSTRAINT [FK_CHITIETPHIEUTHU_SAPPHAM]
GO
ALTER TABLE [dbo].[LUONG]  WITH CHECK ADD  CONSTRAINT [FK_LUONG_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[LUONG] CHECK CONSTRAINT [FK_LUONG_NHANVIEN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_CHUCVU] FOREIGN KEY([MaCV])
REFERENCES [dbo].[CHUCVU] ([MaCV])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_CHUCVU]
GO
ALTER TABLE [dbo].[PHACHE]  WITH CHECK ADD  CONSTRAINT [FK_PHACHE_NGUYENLIEU] FOREIGN KEY([MaNL])
REFERENCES [dbo].[NGUYENLIEU] ([MaNL])
GO
ALTER TABLE [dbo].[PHACHE] CHECK CONSTRAINT [FK_PHACHE_NGUYENLIEU]
GO
ALTER TABLE [dbo].[PHACHE]  WITH CHECK ADD  CONSTRAINT [FK_PHACHE_SAPPHAM] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SANPHAM] ([MaSP])
GO
ALTER TABLE [dbo].[PHACHE] CHECK CONSTRAINT [FK_PHACHE_SAPPHAM]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NHACUNGCAP] ([MaNCC])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHANVIEN] FOREIGN KEY([MaNv])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUTHU]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHU_BAN] FOREIGN KEY([Maban])
REFERENCES [dbo].[BAN] ([MaBan])
GO
ALTER TABLE [dbo].[PHIEUTHU] CHECK CONSTRAINT [FK_PHIEUTHU_BAN]
GO
ALTER TABLE [dbo].[PHIEUTHU]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHU_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[PHIEUTHU] CHECK CONSTRAINT [FK_PHIEUTHU_KHACHHANG]
GO
ALTER TABLE [dbo].[PHIEUTHU]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHU_NHANVIEN] FOREIGN KEY([MaNv])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUTHU] CHECK CONSTRAINT [FK_PHIEUTHU_NHANVIEN]
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [FK_TAIKHOAN_NHANVIEN]
GO
USE [master]
GO
ALTER DATABASE [QLQuanCafe] SET  READ_WRITE 
GO
