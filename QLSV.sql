USE [master]
GO
/****** Object:  Database [QLSV]    Script Date: 9/4/2024 16:37:43 ******/
CREATE DATABASE [QLSV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLSV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLSV.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLSV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLSV_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLSV] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLSV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLSV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLSV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLSV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLSV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLSV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLSV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLSV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLSV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLSV] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLSV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLSV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLSV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLSV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLSV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLSV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLSV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLSV] SET RECOVERY FULL 
GO
ALTER DATABASE [QLSV] SET  MULTI_USER 
GO
ALTER DATABASE [QLSV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLSV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLSV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLSV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLSV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLSV] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLSV', N'ON'
GO
ALTER DATABASE [QLSV] SET QUERY_STORE = OFF
GO
USE [QLSV]
GO
/****** Object:  Table [dbo].[ChuongTrinh]    Script Date: 9/4/2024 16:37:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuongTrinh](
	[Ma] [varchar](10) NOT NULL,
	[tenChuongTrinh] [nvarchar](100) NULL,
 CONSTRAINT [PK_CT] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiangKhoa]    Script Date: 9/4/2024 16:37:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangKhoa](
	[maChuongTrinh] [varchar](10) NOT NULL,
	[maKhoa] [varchar](10) NOT NULL,
	[maMonHoc] [varchar](10) NOT NULL,
	[namHoc] [int] NULL,
	[hocKy] [int] NULL,
	[soTietLyThuyet] [int] NULL,
	[soTietThucHanh] [int] NULL,
	[soTinChi] [int] NULL,
 CONSTRAINT [PK_GK] PRIMARY KEY CLUSTERED 
(
	[maChuongTrinh] ASC,
	[maKhoa] ASC,
	[maMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KetQua]    Script Date: 9/4/2024 16:37:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KetQua](
	[maSinhVien] [varchar](10) NOT NULL,
	[maMonHoc] [varchar](10) NOT NULL,
	[lanThi] [int] NOT NULL,
	[diem] [float] NULL,
 CONSTRAINT [PK_KQ] PRIMARY KEY CLUSTERED 
(
	[maSinhVien] ASC,
	[maMonHoc] ASC,
	[lanThi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 9/4/2024 16:37:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[ma] [varchar](10) NOT NULL,
	[tenKhoa] [nvarchar](100) NOT NULL,
	[namThanhLap] [int] NULL,
	[Tong_so_sv] [int] NULL,
 CONSTRAINT [PK_KH] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhoaHoc]    Script Date: 9/4/2024 16:37:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoaHoc](
	[Ma] [varchar](10) NOT NULL,
	[namBatDau] [int] NULL,
	[namKetThuc] [int] NULL,
 CONSTRAINT [PK_KHOA] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 9/4/2024 16:37:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[Ma] [varchar](10) NOT NULL,
	[maKhoaHoc] [varchar](10) NOT NULL,
	[maKhoa] [varchar](10) NOT NULL,
	[maChuongTrinh] [varchar](10) NOT NULL,
	[soThuTu] [int] NOT NULL,
 CONSTRAINT [PK_LOP] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 9/4/2024 16:37:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[Ma] [varchar](10) NOT NULL,
	[tenMonHoc] [nvarchar](100) NOT NULL,
	[maKhoa] [varchar](10) NULL,
 CONSTRAINT [PK_MH] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 9/4/2024 16:37:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[Ma] [varchar](10) NOT NULL,
	[hoTen] [nvarchar](100) NOT NULL,
	[namSinh] [int] NULL,
	[danToc] [nvarchar](20) NULL,
	[maLop] [varchar](10) NULL,
 CONSTRAINT [PK_SV] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[GiangKhoa]  WITH CHECK ADD  CONSTRAINT [FK_GIANGKHOA_CHUONGTRINH] FOREIGN KEY([maChuongTrinh])
REFERENCES [dbo].[ChuongTrinh] ([Ma])
GO
ALTER TABLE [dbo].[GiangKhoa] CHECK CONSTRAINT [FK_GIANGKHOA_CHUONGTRINH]
GO
ALTER TABLE [dbo].[GiangKhoa]  WITH CHECK ADD  CONSTRAINT [FK_GIANGKHOA_KHOA_KHOA] FOREIGN KEY([maKhoa])
REFERENCES [dbo].[Khoa] ([ma])
GO
ALTER TABLE [dbo].[GiangKhoa] CHECK CONSTRAINT [FK_GIANGKHOA_KHOA_KHOA]
GO
ALTER TABLE [dbo].[GiangKhoa]  WITH CHECK ADD  CONSTRAINT [FK_GIANGKHOA_MAMH_MONHOC] FOREIGN KEY([maMonHoc])
REFERENCES [dbo].[MonHoc] ([Ma])
GO
ALTER TABLE [dbo].[GiangKhoa] CHECK CONSTRAINT [FK_GIANGKHOA_MAMH_MONHOC]
GO
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD  CONSTRAINT [FK_KETQUA_MAMH_MONHOC] FOREIGN KEY([maMonHoc])
REFERENCES [dbo].[MonHoc] ([Ma])
GO
ALTER TABLE [dbo].[KetQua] CHECK CONSTRAINT [FK_KETQUA_MAMH_MONHOC]
GO
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD  CONSTRAINT [FK_KETQUA_MASV_SINHVIEN] FOREIGN KEY([maSinhVien])
REFERENCES [dbo].[SinhVien] ([Ma])
GO
ALTER TABLE [dbo].[KetQua] CHECK CONSTRAINT [FK_KETQUA_MASV_SINHVIEN]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_LOP_CHUONGTRINH_CHUONGTRINH] FOREIGN KEY([maChuongTrinh])
REFERENCES [dbo].[ChuongTrinh] ([Ma])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_LOP_CHUONGTRINH_CHUONGTRINH]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_LOP_KHOA_KHOA] FOREIGN KEY([maKhoa])
REFERENCES [dbo].[Khoa] ([ma])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_LOP_KHOA_KHOA]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_LOP_KHOAHOC_KHOAHOC] FOREIGN KEY([maKhoaHoc])
REFERENCES [dbo].[KhoaHoc] ([Ma])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_LOP_KHOAHOC_KHOAHOC]
GO
ALTER TABLE [dbo].[MonHoc]  WITH CHECK ADD  CONSTRAINT [FK_MONHOC_KHOA_KHOA] FOREIGN KEY([maKhoa])
REFERENCES [dbo].[Khoa] ([ma])
GO
ALTER TABLE [dbo].[MonHoc] CHECK CONSTRAINT [FK_MONHOC_KHOA_KHOA]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_MALOP_LOP] FOREIGN KEY([maLop])
REFERENCES [dbo].[Lop] ([Ma])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SINHVIEN_MALOP_LOP]
GO
USE [master]
GO
ALTER DATABASE [QLSV] SET  READ_WRITE 
GO
