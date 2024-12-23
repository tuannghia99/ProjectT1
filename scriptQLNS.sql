USE [master]
GO
/****** Object:  Database [QuanLyNhanSu]    Script Date: 11/30/2024 11:49:15 PM ******/
CREATE DATABASE [QuanLyNhanSu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyNhanSu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QuanLyNhanSu.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyNhanSu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QuanLyNhanSu_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyNhanSu] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyNhanSu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyNhanSu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyNhanSu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyNhanSu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyNhanSu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyNhanSu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyNhanSu] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyNhanSu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyNhanSu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyNhanSu] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyNhanSu] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyNhanSu', N'ON'
GO
USE [QuanLyNhanSu]
GO
/****** Object:  Table [dbo].[CommonCategory]    Script Date: 11/30/2024 11:49:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CommonCategory](
	[Oid] [uniqueidentifier] NOT NULL,
	[Mscode] [nvarchar](max) NULL,
	[Msname] [nvarchar](max) NULL,
	[CategoryId] [nvarchar](max) NULL,
	[LinkGuid1] [uniqueidentifier] NULL,
	[LinkGuid2] [uniqueidentifier] NULL,
	[LinkGuid3] [uniqueidentifier] NULL,
	[LinkGuid4] [uniqueidentifier] NULL,
	[LinkGuid5] [uniqueidentifier] NULL,
	[Float1] [float] NULL,
	[Float2] [float] NULL,
	[Float3] [float] NULL,
	[Float4] [float] NULL,
	[Float5] [float] NULL,
	[Decimal1] [decimal](18, 2) NULL,
	[Decimal2] [decimal](18, 2) NULL,
	[Decimal3] [decimal](18, 2) NULL,
	[Decimal4] [decimal](18, 2) NULL,
	[Decimal5] [decimal](18, 2) NULL,
	[DateTime1] [datetime] NULL,
	[DateTime2] [datetime] NULL,
	[DateTime3] [datetime] NULL,
	[DateTime4] [datetime] NULL,
	[DateTime5] [datetime] NULL,
	[Boolean1] [bit] NULL,
	[Boolean2] [bit] NULL,
	[Boolean3] [bit] NULL,
	[Boolean4] [bit] NULL,
	[Boolean5] [bit] NULL,
	[String1] [nvarchar](max) NULL,
	[String2] [nvarchar](max) NULL,
	[String3] [nvarchar](max) NULL,
	[String4] [nvarchar](max) NULL,
	[String5] [nvarchar](max) NULL,
	[String6] [nvarchar](max) NULL,
	[String7] [nvarchar](max) NULL,
	[String8] [nvarchar](max) NULL,
	[String9] [nvarchar](max) NULL,
	[String10] [nvarchar](max) NULL,
	[VarBinary1] [varbinary](max) NULL,
	[VarBinary2] [varbinary](max) NULL,
	[VarBinary3] [varbinary](max) NULL,
	[VarBinary4] [varbinary](max) NULL,
	[VarBinary5] [varbinary](max) NULL,
 CONSTRAINT [CommonCategory_PK] PRIMARY KEY CLUSTERED 
(
	[Oid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhenThuong]    Script Date: 11/30/2024 11:49:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhenThuong](
	[Oid] [uniqueidentifier] NOT NULL,
	[MaSo] [nvarchar](max) NULL,
	[IdNhanVien] [uniqueidentifier] NULL,
	[CanCuKhenThuong] [nvarchar](max) NULL,
	[LyDoKhenThuong] [nvarchar](max) NULL,
	[HinhThucKhenThuong] [nvarchar](max) NULL,
	[MucKhenThuong] [decimal](18, 2) NULL,
	[NgayKhenThuong] [datetime] NULL,
	[CreateUser] [nvarchar](max) NULL,
	[CreateDate] [datetime] NULL,
	[ModifiedUser] [nvarchar](max) NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [KhenThuong_PK] PRIMARY KEY CLUSTERED 
(
	[Oid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KyLuat]    Script Date: 11/30/2024 11:49:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KyLuat](
	[Oid] [uniqueidentifier] NOT NULL,
	[MaSo] [nvarchar](max) NULL,
	[IdNhanVien] [uniqueidentifier] NULL,
	[ThoiGianXayRa] [datetime] NULL,
	[DiaDiemXayRa] [nvarchar](max) NULL,
	[MoTaSuViec] [nvarchar](max) NULL,
	[NhungNguoiChungKien] [nvarchar](max) NULL,
	[IsViPhamChinhSachCongTy] [bit] NULL,
	[DienGiai] [nvarchar](max) NULL,
	[HinhThucKyLuat] [nvarchar](max) NULL,
	[NgayBatDauThiHanh] [datetime] NULL,
	[NgayHetHieuLuc] [datetime] NULL,
	[CreateUser] [nvarchar](max) NULL,
	[CreateDate] [datetime] NULL,
	[ModifiedUser] [nvarchar](max) NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [KyLuat_PK] PRIMARY KEY CLUSTERED 
(
	[Oid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/30/2024 11:49:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Oid] [uniqueidentifier] NOT NULL,
	[MaSo] [nvarchar](max) NULL,
	[Ten] [nvarchar](max) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [nvarchar](max) NULL,
	[NoiSinh] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[QuocTich] [nvarchar](max) NULL,
	[DanToc] [nvarchar](max) NULL,
	[TonGiao] [nvarchar](max) NULL,
	[TinhTrangHonNhan] [nvarchar](max) NULL,
	[NgoaiNgu] [nvarchar](max) NULL,
	[TinHoc] [nvarchar](max) NULL,
	[SoCanCuoc] [nvarchar](max) NULL,
	[NgayCap] [datetime] NULL,
	[NoiCap] [nvarchar](max) NULL,
	[TinhTrangSucKhoe] [nvarchar](max) NULL,
	[ChieuCao] [decimal](18, 2) NULL,
	[CanNang] [decimal](18, 2) NULL,
	[IdChucVu] [uniqueidentifier] NULL,
	[IdPhongBan] [uniqueidentifier] NULL,
	[IdTrinhDoHocVan] [uniqueidentifier] NULL,
	[Username] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Avatar] [varbinary](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[IsAdmin] [bit] NULL,
	[CreateUser] [nvarchar](max) NULL,
	[CreateDate] [datetime] NULL,
	[ModifiedUser] [nvarchar](max) NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [NhanVien_PK] PRIMARY KEY CLUSTERED 
(
	[Oid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [QuanLyNhanSu] SET  READ_WRITE 
GO
INSERT INTO [dbo].[NhanVien] (
    [Oid],
    [MaSo],
    [Ten],
    [NgaySinh],
    [GioiTinh],
    [NoiSinh],
    [DiaChi],
    [QuocTich],
    [DanToc],
    [TonGiao],
    [TinhTrangHonNhan],
    [NgoaiNgu],
    [TinHoc],
    [SoCanCuoc],
    [NgayCap],
    [NoiCap],
    [TinhTrangSucKhoe],
    [ChieuCao],
    [CanNang],
    [IdChucVu],
    [IdPhongBan],
    [IdTrinhDoHocVan],
    [Username],
    [Password],
    [Avatar],
    [PhoneNumber],
    [Email],
    [IsAdmin],
    [CreateUser],
    [CreateDate],
    [ModifiedUser],
    [ModifiedDate]
)
VALUES (
    NEWID(),                       
    '0000',                       
    N'addmin',               
    '1990-01-01',                  
    N'Nam',                        
    N'Hà Nội',                    
    N'Hà Nội',    
    N'Việt Nam',                   
    N'Kinh',                       
    N'Không',                      
    N'Độc thân',                  
    N'Tiếng Anh',                  
    N'Trung cấp',                  
    '0123456789',                 
    '2010-01-01',                  
    N'Cục Cảnh sát Hà Nội',        
    N'Tốt',                        
    1.75,                          
    70.5,                          
    null,                       
    null,                      
   null,                       
    'admin',               
    '3e6c7d141e32189c917761138b026b74',                
    NULL,                          
    '0901234567',                 
    'admin@example.com',      
    0,                             
    N'Admin',                      
    GETDATE(),                     
    NULL,                          
    NULL                           
);
