USE [master]
GO
/****** Object:  Database [DIENTU]    Script Date: 5/16/2023 11:12:20 AM ******/
CREATE DATABASE [DIENTU]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DIENTU', FILENAME = N'D:\DIENTUU\DIENTU.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DIENTU_log', FILENAME = N'D:\DIENTUU\DIENTU_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DIENTU] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DIENTU].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DIENTU] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DIENTU] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DIENTU] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DIENTU] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DIENTU] SET ARITHABORT OFF 
GO
ALTER DATABASE [DIENTU] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DIENTU] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DIENTU] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DIENTU] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DIENTU] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DIENTU] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DIENTU] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DIENTU] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DIENTU] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DIENTU] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DIENTU] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DIENTU] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DIENTU] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DIENTU] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DIENTU] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DIENTU] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DIENTU] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DIENTU] SET RECOVERY FULL 
GO
ALTER DATABASE [DIENTU] SET  MULTI_USER 
GO
ALTER DATABASE [DIENTU] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DIENTU] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DIENTU] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DIENTU] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DIENTU] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DIENTU] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DIENTU', N'ON'
GO
ALTER DATABASE [DIENTU] SET QUERY_STORE = OFF
GO
USE [DIENTU]
GO
/****** Object:  Table [dbo].[CungCap]    Script Date: 5/16/2023 11:12:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CungCap](
	[NhaSX] [nvarchar](50) NOT NULL,
	[QuanLy] [nvarchar](50) NOT NULL,
	[SDT] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CungCap] PRIMARY KEY CLUSTERED 
(
	[NhaSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GioHang]    Script Date: 5/16/2023 11:12:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GioHang](
	[UserName] [nvarchar](50) NOT NULL,
	[MaSP] [int] NOT NULL,
	[SL] [int] NOT NULL,
	[SumAll] [numeric](18, 0) NULL,
 CONSTRAINT [PK_GioHang] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Help]    Script Date: 5/16/2023 11:12:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Help](
	[UserName] [nvarchar](50) NOT NULL,
	[LinhVuc] [nvarchar](50) NOT NULL,
	[INFO] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 5/16/2023 11:12:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[Ho_Ten] [nvarchar](50) NOT NULL,
	[User_Name] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Dia_Chi] [nvarchar](50) NULL,
	[Admin] [bit] NOT NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[User_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/16/2023 11:12:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[SDT] [nvarchar](50) NOT NULL,
	[Roles] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 5/16/2023 11:12:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[TenPB] [nvarchar](50) NOT NULL,
	[MaNVQLY] [int] NOT NULL,
 CONSTRAINT [PK_PhongBan] PRIMARY KEY CLUSTERED 
(
	[TenPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 5/16/2023 11:12:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [int] IDENTITY(1,1) NOT NULL,
	[TenSP] [nvarchar](max) NOT NULL,
	[Loai] [nvarchar](50) NOT NULL,
	[Spec] [nvarchar](max) NULL,
	[NhaSX] [nvarchar](50) NOT NULL,
	[SLKho] [int] NOT NULL,
	[GiaTien] [numeric](18, 0) NOT NULL,
	[GiamGia] [int] NOT NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[CungCap] ([NhaSX], [QuanLy], [SDT]) VALUES (N'ACER', N'Yui Shiramine', N'357562451')
INSERT [dbo].[CungCap] ([NhaSX], [QuanLy], [SDT]) VALUES (N'Apple', N'Hartwell Whitely', N'234234234')
INSERT [dbo].[CungCap] ([NhaSX], [QuanLy], [SDT]) VALUES (N'ASUS', N'Nao Kira', N'678453765')
INSERT [dbo].[CungCap] ([NhaSX], [QuanLy], [SDT]) VALUES (N'GOOGLE', N'Keily Quayle', N'453466567')
INSERT [dbo].[CungCap] ([NhaSX], [QuanLy], [SDT]) VALUES (N'HP', N'Bob Odenkirk', N'354231312')
INSERT [dbo].[CungCap] ([NhaSX], [QuanLy], [SDT]) VALUES (N'JBL', N'Amie Massey', N'546234586')
INSERT [dbo].[CungCap] ([NhaSX], [QuanLy], [SDT]) VALUES (N'KINGSTON', N'LiLy Le', N'123679564')
INSERT [dbo].[CungCap] ([NhaSX], [QuanLy], [SDT]) VALUES (N'LENOVO', N'Kenta Nishitomo', N'356312674')
INSERT [dbo].[CungCap] ([NhaSX], [QuanLy], [SDT]) VALUES (N'LG', N'Aoi Tsukasa', N'576324123')
INSERT [dbo].[CungCap] ([NhaSX], [QuanLy], [SDT]) VALUES (N'LOGITECH', N'Cara Adams', N'123975644')
INSERT [dbo].[CungCap] ([NhaSX], [QuanLy], [SDT]) VALUES (N'MSI', N'Michael Killian', N'678324123')
INSERT [dbo].[CungCap] ([NhaSX], [QuanLy], [SDT]) VALUES (N'SAMSUNG', N'Billy Kimber', N'156235145')
INSERT [dbo].[CungCap] ([NhaSX], [QuanLy], [SDT]) VALUES (N'SONY', N'Jake Erlin', N'232342453')
GO
INSERT [dbo].[GioHang] ([UserName], [MaSP], [SL], [SumAll]) VALUES (N'HoHo', 2, 2, CAST(2558000 AS Numeric(18, 0)))
INSERT [dbo].[GioHang] ([UserName], [MaSP], [SL], [SumAll]) VALUES (N'SonTung', 1, 11, CAST(202851000 AS Numeric(18, 0)))
INSERT [dbo].[GioHang] ([UserName], [MaSP], [SL], [SumAll]) VALUES (N'SonTung', 2, 1, CAST(1279000 AS Numeric(18, 0)))
INSERT [dbo].[GioHang] ([UserName], [MaSP], [SL], [SumAll]) VALUES (N'SonTung', 4, 1, CAST(246400 AS Numeric(18, 0)))
INSERT [dbo].[GioHang] ([UserName], [MaSP], [SL], [SumAll]) VALUES (N'SonTung', 6, 1, CAST(930000 AS Numeric(18, 0)))
GO
INSERT [dbo].[NguoiDung] ([Ho_Ten], [User_Name], [Password], [Dia_Chi], [Admin]) VALUES (N'Tran Trung Phan', N'Admin', N'123', N'', 1)
INSERT [dbo].[NguoiDung] ([Ho_Ten], [User_Name], [Password], [Dia_Chi], [Admin]) VALUES (N'Tran Thanh', N'Cry', N'Cry123', N'HCM', 0)
INSERT [dbo].[NguoiDung] ([Ho_Ten], [User_Name], [Password], [Dia_Chi], [Admin]) VALUES (N'HoHo', N'HoHo', N'12', N'Quan 10', 0)
INSERT [dbo].[NguoiDung] ([Ho_Ten], [User_Name], [Password], [Dia_Chi], [Admin]) VALUES (N'Mono', N'Mono', N'123', N'Thai Binh', 0)
INSERT [dbo].[NguoiDung] ([Ho_Ten], [User_Name], [Password], [Dia_Chi], [Admin]) VALUES (N'Son Tung', N'SonTung', N'1', N'Thai Binh', 0)
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [Roles]) VALUES (1, N'Vương Đình Quý', N'3123451323', N'Nhóm Trưởng')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [Roles]) VALUES (2, N'Lê Quốc Thắng', N'3124512331', N'Thành Viên')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [Roles]) VALUES (3, N'Nguyễn Lê Quốc Trung', N'4531123423', N'Thành Viên')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [Roles]) VALUES (4, N'Hasoko Kensai', N'4523565345', N'Sales')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [Roles]) VALUES (5, N'Harry Kirt', N'4689683458', N'Sales')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [Roles]) VALUES (6, N'Skyler Silver', N'1321244345', N'CSKH')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [Roles]) VALUES (7, N'John Gerry', N'6784564577', N'Technical')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [Roles]) VALUES (8, N'Killian Foud', N'4747575775', N'CSKH')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [Roles]) VALUES (9, N'Jaheris Norman', N'7846457878', N'Technical')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [Roles]) VALUES (10, N'Derlian Yeman', N'6567656733', N'Sales')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [Roles]) VALUES (11, N'Tran Hanh Thai', N'3212354679', N'Sales')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [Roles]) VALUES (12, N'Nguyen Hao Chu', N'2136976451', N'Technical')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [Roles]) VALUES (13, N'Le Phuc Hai', N'1237645312', N'CSKH')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
INSERT [dbo].[PhongBan] ([TenPB], [MaNVQLY]) VALUES (N'CSKH', 5)
INSERT [dbo].[PhongBan] ([TenPB], [MaNVQLY]) VALUES (N'Nhóm Trưởng', 1)
INSERT [dbo].[PhongBan] ([TenPB], [MaNVQLY]) VALUES (N'Sales', 2)
INSERT [dbo].[PhongBan] ([TenPB], [MaNVQLY]) VALUES (N'Technical', 1)
INSERT [dbo].[PhongBan] ([TenPB], [MaNVQLY]) VALUES (N'Thành Viên', 2)
GO
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (1, N'Laptop ASUS TUF Gaming', N'Laptop', N'i5-11400H/RAM 8GB/RTX 3050/512GB SSD/ Windows 11', N'ASUS', 10, CAST(20490000 AS Numeric(18, 0)), 10)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (2, N'RAM desktop KINGSTON Fury Beast', N'Ram', N'16GB/DDR4/3200MHz', N'KINGSTON', 15, CAST(1279000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (3, N'Chuột không dây Logitech M650', N'Mouse', N'
Bluetooth/2.4 GHz/Wireless', N'LOGITECH', 30, CAST(649000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (4, N'Loa Logitech Z120', N'Speaker', N'Jack 3.5mm (input) / USB (power)', N'LOGITECH', 20, CAST(280000 AS Numeric(18, 0)), 12)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (6, N'Loa Bluetooth JBL GO 3', N'Speaker', N'Bluetooth 5.1/110Hz – 20kHz/IP67', N'JBL', 10, CAST(930000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (7, N'Laptop CHUWI LarkBook ', N'Laptop', N'CeleronN51001.1 Ghz', N'ACER', 20, CAST(5519000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (8, N'Laptop CHUWI CoreBook X', N'Laptop', N'i58259U2.30 GHz', N'ACER', 20, CAST(8990000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (9, N'Laptop Acer Swift 3', N'Laptop', N'i5 1240P/16GB/512GB/Win11 ', N'ACER', 20, CAST(18990000 AS Numeric(18, 0)), 20)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (10, N'Laptop Acer Aspire 5', N'Laptop', N'i5 1135G7/8GB/1TB SSD/Win11 ', N'ACER', 20, CAST(19990000 AS Numeric(18, 0)), 30)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (11, N'Laptop Asus Gaming ROG Strix G17 G713RW', N'Laptop', N'R9 6900HX/32GB/1TB/8GB RTX3070Ti/240Hz/Balo/Win11', N'ASUS', 15, CAST(67990000 AS Numeric(18, 0)), 33)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (12, N'Laptop Asus Zenbook 14X', N'Laptop', N'R5-5600H/8GB/512GB PCIE/14.0 2.8K OLED/CẢM ỨNG/WIN11/ĐEN', N'ASUS', 15, CAST(21200000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (14, N'Laptop Asus VivoBook', N'Laptop', N'
I3-1115G4/8GB/512GB PCIE/15.6 FHD/WIN11/BẠC', N'ASUS', 15, CAST(11990000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (15, N'IPhone 12 Pro Max', N'Phone', N'OLED6.7"Super Retina XDR', N'Apple', 40, CAST(33490000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (18, N'IPhone 13 pro', N'Phone', N'OLED6.1"Super Retina XDR/IOS 16', N'Apple', 40, CAST(34490000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (23, N'IPhone 14 Plus', N'Phone', N'OLED6.7"Super Retina XDR/IOS 16', N'Apple', 40, CAST(24990000 AS Numeric(18, 0)), 12)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (25, N'IPhone 14 Pro', N'Phone', N'OLED6.1"Super Retina XDR/IOS 16/Chính 48 MP & Phụ 12 MP, 12 MP', N'Apple', 45, CAST(35990000 AS Numeric(18, 0)), 6)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (26, N'IPhone 14 Pro Max', N'Phone', N'OLED6.7"Super Retina XDR/IOS 16', N'Apple', 45, CAST(32990000 AS Numeric(18, 0)), 9)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (28, N'Máy tính bảng iPad Pro M1', N'Ipad', N'12.9 inch WiFi Cellular 128GB', N'Apple', 20, CAST(34990000 AS Numeric(18, 0)), 16)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (29, N'Máy tính bảng iPad Pro M1 12.9 inch WiFi 2TB', N'Ipad', N'12.9"Liquid Retina XDR/iPadOS 15', N'Apple', 20, CAST(59990000 AS Numeric(18, 0)), 8)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (30, N'Máy tính bảng iPad Pro M2', N'Ipad', N'11"Liquid Retina/iPadOS 16', N'Apple', 20, CAST(23990000 AS Numeric(18, 0)), 12)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (32, N'Loa Bluetooth JBL Go 3', N'Speaker', N'Bluetooth 5.1/4.2 W', N'JBL', 15, CAST(1090000 AS Numeric(18, 0)), 9)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (33, N'Cặp loa karaoke JBL KI510', N'Speaker', N'Cổng kết nối với AmplyLine Level/LFE RCA Jack', N'JBL', 18, CAST(19400000 AS Numeric(18, 0)), 10)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (34, N'Tai nghe Bluetooth AirPods 3 Wireless Charge Apple MME73', N'Headphone', N'Adaptive EQChip Apple H1Custom High Dynamic Range AmplifierCustom high-excursion Apple driverSpatial Audio', N'Apple', 21, CAST(5490000 AS Numeric(18, 0)), 14)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (35, N'Tai nghe Bluetooth AirPods Pro (2nd Gen) MagSafe Charge Apple MQD83', N'Headphone', N'Active Noise CancellationAdaptive EQChip Apple H2', N'Apple', 21, CAST(6990000 AS Numeric(18, 0)), 14)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (36, N'Tai nghe Bluetooth AirPods Pro MagSafe Charge Apple MLWK3 ', N'Headphone', N'Active Noise CancellationAdaptive EQChip Apple H1Custom High Dynamic Range AmplifierCustom high-excursion Apple driverSpatial AudioTransparency Mode', N'Apple', 21, CAST(6790000 AS Numeric(18, 0)), 14)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (37, N'Laptop Apple MacBook Pro M2 2022', N'Laptop', N'Apple M2100GB/s', N'Apple', 15, CAST(35990000 AS Numeric(18, 0)), 16)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (38, N'Laptop Apple MacBook Pro 14 M1 Pro 2021', N'Laptop', N'Apple M1 Pro200GB/s', N'Apple', 15, CAST(58490000 AS Numeric(18, 0)), 16)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (39, N'Google Tivi Sony 4K 75 inch', N'Television', N'Auto ModeChuyển động mượt Motionflow XR 200Dolby VisionHDR10HLGKiểm soát đèn nền Direct LED Frame DimmingNâng cấp hình ảnh 4K X-Reality PROTăng cường màu sắc Triluminos Pro', N'Sony', 17, CAST(26860000 AS Numeric(18, 0)), 17)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (40, N'Google Tivi Sony 4K 75 inch XR-75X90K', N'Television', N'Chuyển động mượt Motionflow XR 800Hiệu chuẩn màu sắc Netflix Calibrated ModeKiểm soát đèn nền - Local DimmingLàm mượt chuyển động XR Motion ClarityTăng cường màu sắc Triluminos ProTăng cường tương phản XR Contrast Booster 10', N'Sony', 17, CAST(34560000 AS Numeric(18, 0)), 17)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (41, N'Google Tivi Sony 4K 75 inch KD-75X85K', N'Television', N'Chuyển động mượt Motionflow XR 800Tăng cường màu sắc Triluminos Pro', N'Sony', 18, CAST(30620000 AS Numeric(18, 0)), 23)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (42, N'Google Tivi OLED Sony 4K 65 inch XR-65A80K', N'Television', N'Chuyển động mượt XR OLED MotionTăng cường màu sắc XR Triluminos ProTăng độ tương phản XR OLED Contrast Pro', N'Sony', 17, CAST(41260000 AS Numeric(18, 0)), 23)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (46, N'Smart Tivi QNED LG 4K 65 inch 65QNED80SQA', N'Television', N'Active HDRChế độ game HGiGChế độ hình ảnh phù hợp nội dungFilmMaker ModeChống xé hình FreeSync PremiumColor ConsistencyDải màu rộng Nano Color ProGiảm độ trễ chơi game Auto Low Latency Mode (ALLM)HDR Dynamic Tone MappingHDR10 ProHiển thị màu rực rỡ Quantum Dot NanoCell ColorHLGKiểm soát đèn nền - Local DimmingMotion ProNâng cấp hình ảnh AI Picture Pro 4KNâng cấp độ phân giải 4K AI UpscalingTương thích bộ mã hóa Video decoder (VP9, AV1)Tương thích HEVC', N'LG', 20, CAST(22900000 AS Numeric(18, 0)), 30)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (47, N'Smart Tivi OLED LG 4K 65 inch 65A2PSA', N'Television', N'Active HDRChuyển động mượt OLED MotionChế độ game HGiGFilmMaker ModeCông nghệ điểm ảnh Pixel DimmingDolby Vision IQDải màu siêu rộng Perfect ColorGiảm độ trễ chơi game Auto Low Latency Mode (ALLM)HDRHDR Dolby VisionHDR Dynamic Tone MappingHDR10 ProHLGNâng cấp hình ảnh AI Picture Pro 4KNâng cấp độ phân giải 4K AI UpscalingTăng độ sáng 20% Brightness BoosterTương phản hoàn hảo Perfect BlackTương thích bộ mã hóa Video decoder (VP9, AV1)Tương thích HEVC', N'LG', 20, CAST(57900000 AS Numeric(18, 0)), 52)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (49, N'Smart Tivi OLED LG 4K 55 inch 55C2PSA', N'Television', N'Chuyển động mượt OLED MotionChế độ game HGiGChế độ hình ảnh phù hợp nội dungFilmMaker ModeChống xé hình FreeSyncChống xé hình G-SyncCinema HDRCông nghệ điểm ảnh Pixel DimmingDolby Vision IQDải màu siêu rộng Perfect ColorGiảm độ trễ chơi game Auto Low Latency Mode (ALLM)HDRHDR Dolby VisionHDR Dynamic Tone Mapping ProHDR10 ProHLGNâng cấp hình ảnh AI Picture Pro 4KNâng cấp độ phân giải 4K AI UpscalingTăng độ sáng 20% Brightness BoosterTương phản hoàn hảo Perfect BlackTương thích bộ mã hóa Video decoder (VP9, AV1)Tương thích HEVC', N'LG', 20, CAST(49990000 AS Numeric(18, 0)), 44)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (50, N'Smart Tivi OLED LG 4K 65 inch 65G1PTA ', N'Television', N'Chế độ game HGiGFilmMaker ModeChống xé hình FreeSyncCinema HDRCân bằng độ sáng Ultra Luminance PRODolby Vision IQDải màu siêu rộng Perfect ColorGiảm độ trễ chơi game Auto Low Latency Mode (ALLM)HDR Dynamic Tone Mapping ProHDR10 ProHLGMàn hình OLEDNâng cấp hình ảnh AI Picture Pro 4KNâng cấp hình ảnh Image Enhancing on SQMNâng cấp độ phân giải 4K AI UpscalingOLED Motion ProĐồng bộ khung hình/tần số quét chơi game VRR', N'LG', 20, CAST(84600000 AS Numeric(18, 0)), 68)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (51, N'
Chuột máy tính gaming Logitech G Pro Hero (Đen) ', N'Mouse', N'
Chuột có dây/Cảm biến hero 16K chính xác/Trọng lượng 83g/Cảm biến HERO 16K/6 nút có thể lập trình theo sở thích với Logitech HUB G /Lightsync RGB LED/5 cấu hình bộ nhớ tích hợ', N'LOGITECH', 30, CAST(1799000 AS Numeric(18, 0)), 51)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (52, N'Chuột không dây Logitech Pebble M350', N'Mouse', N'
Bluetooth, Wireless', N'LOGITECH', 30, CAST(599000 AS Numeric(18, 0)), 18)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (53, N'Chuột máy tính Asus TUF Gaming M3', N'Mouse', N'
Ergonomic / Công thái học', N'ASUS', 30, CAST(690000 AS Numeric(18, 0)), 42)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (54, N'Chuột không dây Logitech MX Master 3S', N'Mouse', N'
Bluetooth, Wireless, USB 2.0', N'LOGITECH', 30, CAST(3299000 AS Numeric(18, 0)), 31)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (55, N'Chuột công thái học Logitech Lift Vertical', N'Mouse', N'Ergonomic / Công thái học', N'LOGITECH', 30, CAST(1599000 AS Numeric(18, 0)), 12)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (56, N'Bút cảm ứng Lenovo Precision 2', N'Touchpen', N'166 x 9.93 mm ', N'LENOVO', 10, CAST(1690000 AS Numeric(18, 0)), 41)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (58, N'Liên hệ đặt hàng
Loa Bluetooth Google Nest Mini Gen 2', N'Speaker', N'
Bluetooth 5.0, Micro USB', N'GOOGLE', 10, CAST(899000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (59, N'Laptop Lenovo Ideapad 5 Pro - 16ARH7', N'Laptop', N'Ryzen 5 6600HS/RAM 16GB/512GB SSD/ Windows 11', N'LENOVO', 20, CAST(27990000 AS Numeric(18, 0)), 6)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (60, N'Laptop Lenovo Legion 5 Pro 16IAH7H', N'Laptop', N'i7-12700H/RAM 16GB/512GB SSD/ Windows 11', N'LENOVO', 20, CAST(46990000 AS Numeric(18, 0)), 21)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (62, N'Case MSI MPG VELOX 100P AIRFLOW', N'Case', N'Hỗ trợ mainboard: Mini-ITX, Micro-ATX, ATX', N'MSI', 20, CAST(3899000 AS Numeric(18, 0)), 8)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (65, N'Case MSI MAG FORGE 110R', N'Case', N'Hỗ trợ mainboard: Mini-ITX, Micro-ATX, ATX', N'MSI', 20, CAST(990000 AS Numeric(18, 0)), 7)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (66, N'
Tai nghe MSI
', N'Headphone', N'Kích thước driver 53 mm
/Trở kháng 60 ohms
/Tần số phản hồi 20Hz-20kHz
/Độ nhạy 103/3dB

Tai nghe MSI/20Hz-20Hz', N'MSI', 20, CAST(900000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (67, N'USB 32GB KINGSTON Zodiac DTCNY20/32G', N'USB', N'
32GB', N'Kingston', 20, CAST(349000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (68, N'Tai nghe Bluetooth Chụp Tai MSI K6', N'Headphone', N'Micro USB', N'MSI', 10, CAST(600000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (69, N'Tai nghe Chụp Tai Gaming Logitech G431 7.1', N'Headphone', N'Âm thanh vòm 7.1DTS Headphone X 2.0', N'LOGITECH', 10, CAST(420000 AS Numeric(18, 0)), 30)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (70, N'Tai nghe Bluetooth AirPods 3 Lightning Charge Apple MPNY3 ', N'Headphone', N'Adaptive EQSpatial AudioCustom High Dynamic Range AmplifierCustom high-excursion Apple driverChip Apple H1', N'Apple', 10, CAST(5390000 AS Numeric(18, 0)), 16)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (72, N'Tai nghe Bluetooth True Wireless JBL T225TWS ', N'Headphone', N'JBL Pure Bass', N'JBL', 10, CAST(2590000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (73, N'Tai nghe Bluetooth True Wireless JBL Tune 220', N'Headphone', N'
JBL Pure Bass', N'JBL', 10, CAST(259000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (74, N'Tai nghe Bluetooth AirPods 2 Lightning Charge Apple MV7N2', N'Headphone', N'Chip Apple H1', N'Apple', 10, CAST(4390000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (76, N'Loa Bluetooth JBL Partybox 110 ', N'Speaker', N'Chống nước IPX4Kết nối cùng lúc 2 loaĐiều khiển bằng điện thoạiCó đèn LED', N'JBL', 10, CAST(12900000 AS Numeric(18, 0)), 17)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (77, N'Loa Bluetooth JBL Charge 5', N'Speaker', N'Chống nước, chống bụi IP67Sạc được cho thiết bị khác (cổng USB)Kết nối cùng lúc 2 loa', N'JBL', 10, CAST(3990000 AS Numeric(18, 0)), 6)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (78, N'Loa Bluetooth Sony SRS-XE300 ', N'Speaker', N'Kết nối không dây nhiều loa cùng lúcChống nước, chống bụi IP67', N'Sony', 10, CAST(4690000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (79, N'Loa Bluetooth JBL Flip 6', N'Speaker', N'Chống nước, chống bụi IP67Kết nối cùng lúc 2 loaĐiều khiển bằng App', N'JBL', 10, CAST(29900000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (81, N'Điện thoại Samsung Galaxy S21 FE 5G', N'Phone', N'2 Nano SIMHỗ trợ 5G', N'Samsung', 40, CAST(12990000 AS Numeric(18, 0)), 8)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (83, N'Samsung Galaxy A24 6GB', N'Phone', N'Super AMOLED 6.5" Full HD+', N'Samsung', 40, CAST(6990000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (84, N'Điện thoại Samsung Galaxy S23 Ultra 5G 256GB', N'Phone', N'Dynamic AMOLED 2X6.8"Quad HDynamic AMOLED 2X6.8"Quad HD+ (2K+)', N'Samsung', 40, CAST(31990000 AS Numeric(18, 0)), 12)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (85, N'Điện thoại Samsung Galaxy Z Flip4 5G 256GB ', N'Phone', N'Chính: Dynamic AMOLED 2X, Phụ: Super AMOLEDChính 6.7" & Phụ 1.9"Full HD+', N'Samsung', 40, CAST(25990000 AS Numeric(18, 0)), 13)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (86, N'Điện thoại Samsung Galaxy S22 Ultra 5G 128GB', N'Phone', N'Dynamic AMOLED 2X6.8"Quad HD+ (2K+)', N'Samsung', 40, CAST(30990000 AS Numeric(18, 0)), 12)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (87, N'Điện thoại Samsung Galaxy Z Flip4 5G 512GB', N'Phone', N'Chính: Dynamic AMOLED 2X, Phụ: Super AMOLEDChính 6.7" & Phụ 1.9"Full HD+', N'Samsung', 40, CAST(46990000 AS Numeric(18, 0)), 23)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (88, N'Điện thoại Samsung Galaxy S22+ 5G 128GB', N'Phone', N'Dynamic AMOLED 2X6.6"Full HD+', N'Samsung', 30, CAST(22790000 AS Numeric(18, 0)), 12)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (91, N'Điện thoại iPhone 12 64GB', N'Phone', N'OLED6.1"Super Retina XDR', N'Apple', 40, CAST(17990000 AS Numeric(18, 0)), 12)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (92, N'Điện thoại iPhone 13 128GB ', N'Phone', N'OLED6.1"Super Retina XDR', N'Apple', 40, CAST(22990000 AS Numeric(18, 0)), 14)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (94, N'Điện thoại iPhone 11 64GB', N'Phone', N'IPS LCD6.1"Liquid Retina', N'Apple', 40, CAST(11990000 AS Numeric(18, 0)), 8)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (97, N'Laptop HP 15s fq2716TU i3 1115G4/8GB/512GB/Win11', N'Laptop', N'i31115G43GHz', N'HP', 50, CAST(13690000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (98, N'Laptop HP Pavilion 15 eg2082TU i5 1240P/8GB/512GB/Win11', N'Laptop', N'i51240P1.7GHz', N'HP', 50, CAST(19890000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (99, N'Laptop HP 240 G8 i3 1115G4/8GB/256GB/Win11', N'Laptop', N'i31115G43GHz', N'HP', 50, CAST(12990000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (100, N'Laptop HP 15s fq5147TU i7 1255U/8GB/512GB/Win11', N'Laptop', N'i71255U1.7GHz', N'HP', 50, CAST(13890000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (102, N'Laptop HP 15s fq5078TU i5 1235U/8GB/512GB/Win11', N'Laptop', N'
i51235U1.3GHz', N'HP', 50, CAST(18190000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (103, N'Laptop HP 245 G9 R5 5625U/8GB/512GB/Win11', N'Laptop', N'Ryzen 55625U2.30 GHz', N'HP', 50, CAST(13990000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (105, N'Laptop HP 240 G9 i5 1235U/8GB/512GB/Win11', N'Laptop', N'i51235U1.3GHz', N'HP', 50, CAST(18990000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (106, N'Laptop HP Omen 16 n0085AX R9 6900HX/32GB/1TB SSD/8GB RTX3070Ti/165Hz/Win11', N'Laptop', N'Ryzen 96900HX3.3GHz', N'HP', 50, CAST(62880000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (107, N'Laptop Apple MacBook Air M2 2022 16GB/512GB/10-core GPU', N'Laptop', N'
Apple M2100GB/s', N'Apple', 40, CAST(46990000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (108, N'Laptop Apple MacBook Air M1 2020 16GB/512GB/8-core GPU', N'Laptop', N'Apple M1', N'Apple', 40, CAST(36990000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (109, N'Laptop LG gram 2023 i7 1360P/16GB/512GB/Win11', N'Laptop', N'
i71360P2.2GHz', N'LG', 40, CAST(38980000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (110, N'Laptop LG gram 2023 i7 1360P/16GB/512GB/Win11', N'Laptop', N'i71360P2.2GHz', N'LG', 40, CAST(46990000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (111, N'Chuột gaming Logitech G502 HERO', N'Mouse', N'Có dây/16000 DPI/1000 Hz (1ms)', N'LOGITECH', 20, CAST(1799000 AS Numeric(18, 0)), 45)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (112, N'RAM Laptop DDR4 Kingston 8GB', N'Ram', N'8GB
/DDR4
/3200MHz', N'KINGSTON', 30, CAST(1090000 AS Numeric(18, 0)), 50)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (113, N'RAM laptop Kingston KVR16LS11/8 (1x8GB) DDR3L 1600MHz', N'Ram', N'8GB/DDR3L/1600MHz', N'KINGSTON', 20, CAST(1850000 AS Numeric(18, 0)), 15)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (114, N'RAM desktop KINGSTON Fury Beast (1 x 8GB) DDR4 3200MHz', N'Ram', N'8GB/DDR4/3200MHz', N'KINGSTON', 40, CAST(1370000 AS Numeric(18, 0)), 50)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (115, N'USB 32GB Kingston DT100G3', N'USB', N'USB 3.0/32 GB/100MB/s', N'KINGSTON', 60, CAST(129000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (116, N'USB 64GB KINGSTON DataTraveler Exodia DTX', N'USB', N'USB 3.2/64 GB', N'KINGSTON', 30, CAST(229000 AS Numeric(18, 0)), 44)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (117, N'RAM laptop KINGSTON KF548S38IB-8', N'Ram', N'8GB/DDR5/4800MHz', N'KINGSTON', 30, CAST(2149000 AS Numeric(18, 0)), 8)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (118, N'RAM desktop KINGSTON HyperX Fury Black', N'Ram', N'8GB/DDR4/3000MHz', N'KINGSTON', 20, CAST(1410000 AS Numeric(18, 0)), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (119, N'USB 64GB KINGSTON Data Traveler Exodia M', N'USB', N'USB 3.2/64GB', N'KINGSTON', 30, CAST(190000 AS Numeric(18, 0)), 27)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Loai], [Spec], [NhaSX], [SLKho], [GiaTien], [GiamGia]) VALUES (120, N'Case ASUS ROG Z11 GR101 (90DC00B0-B30020)', N'Case', N'Hỗ trợ mainboard: Mini-ITX, Mini-DTX. USB: 1 x USB 3.1 Gen 2 Type C, 1 x USB 3.2, 2 x USB 2.0', N'ASUS', 10, CAST(7200000 AS Numeric(18, 0)), 20)
SET IDENTITY_INSERT [dbo].[SanPham] OFF
GO
ALTER TABLE [dbo].[GioHang]  WITH CHECK ADD  CONSTRAINT [FK_GioHang_NguoiDung] FOREIGN KEY([UserName])
REFERENCES [dbo].[NguoiDung] ([User_Name])
GO
ALTER TABLE [dbo].[GioHang] CHECK CONSTRAINT [FK_GioHang_NguoiDung]
GO
ALTER TABLE [dbo].[GioHang]  WITH CHECK ADD  CONSTRAINT [FK_GioHang_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[GioHang] CHECK CONSTRAINT [FK_GioHang_SanPham]
GO
ALTER TABLE [dbo].[Help]  WITH CHECK ADD  CONSTRAINT [FK_Help_NguoiDung] FOREIGN KEY([UserName])
REFERENCES [dbo].[NguoiDung] ([User_Name])
GO
ALTER TABLE [dbo].[Help] CHECK CONSTRAINT [FK_Help_NguoiDung]
GO
ALTER TABLE [dbo].[Help]  WITH CHECK ADD  CONSTRAINT [FK_Help_PhongBan] FOREIGN KEY([LinhVuc])
REFERENCES [dbo].[PhongBan] ([TenPB])
GO
ALTER TABLE [dbo].[Help] CHECK CONSTRAINT [FK_Help_PhongBan]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_PhongBan] FOREIGN KEY([Roles])
REFERENCES [dbo].[PhongBan] ([TenPB])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_PhongBan]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_CungCap] FOREIGN KEY([NhaSX])
REFERENCES [dbo].[CungCap] ([NhaSX])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_CungCap]
GO
/****** Object:  Trigger [dbo].[MAXHANG]    Script Date: 5/16/2023 11:12:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   trigger [dbo].[MAXHANG]
on [dbo].[GioHang]
For INSERT, UPDATE
as
Begin
	declare @IDSP int
	declare @kho int
	declare @sumSP int

	select @IDSP = B.MaSP, @kho = A.SLKho
	from SanPham A inner join inserted B
	on A.MaSP = B.MaSP

	select @sumSP = SUM(SL)
	from GioHang
	where MaSP = @IDSP
	group by MaSP

	if(@sumSP > @kho)
	begin
		RAISERROR ('SL SP VUOT QUA SL KHO', 16, 1)
        ROLLBACK TRANSACTION
	end
END
GO
ALTER TABLE [dbo].[GioHang] ENABLE TRIGGER [MAXHANG]
GO
/****** Object:  Trigger [dbo].[SUMAUTO]    Script Date: 5/16/2023 11:12:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   trigger [dbo].[SUMAUTO]
on [dbo].[GioHang]
For INSERT, UPDATE
as
Begin
	declare @SL int
	declare @Sale int
	declare @Price numeric(18,0)
	declare @Price2 numeric(18,0)
	declare @User nvarchar(50)
	declare @IDSP int

	select @SL = B.SL, @Sale = A.GiamGia, @Price = A.GiaTien, @User = B.UserName, @IDSP = B.MaSP
	from SanPham A inner join inserted B
	on A.MaSP = B.MaSP

	set @Price2 = @SL * (@Price * (100 - @Sale)/100)
	 
	 update GioHang
	 set SumAll = @Price2
	 Where UserName = @User and MaSP = @IDSP
End

GO
ALTER TABLE [dbo].[GioHang] ENABLE TRIGGER [SUMAUTO]
GO
USE [master]
GO
ALTER DATABASE [DIENTU] SET  READ_WRITE 
GO
