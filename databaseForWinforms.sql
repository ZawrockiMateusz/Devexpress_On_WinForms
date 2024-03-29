USE [master]
GO
/****** Object:  Database [GridViewOnWinForms]    Script Date: 14.07.2022 18:44:02 ******/
CREATE DATABASE [GridViewOnWinForms]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GridViewOnWinForms', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GridViewOnWinForms.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GridViewOnWinForms_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GridViewOnWinForms_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GridViewOnWinForms] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GridViewOnWinForms].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GridViewOnWinForms] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GridViewOnWinForms] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GridViewOnWinForms] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GridViewOnWinForms] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GridViewOnWinForms] SET ARITHABORT OFF 
GO
ALTER DATABASE [GridViewOnWinForms] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GridViewOnWinForms] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GridViewOnWinForms] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GridViewOnWinForms] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GridViewOnWinForms] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GridViewOnWinForms] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GridViewOnWinForms] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GridViewOnWinForms] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GridViewOnWinForms] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GridViewOnWinForms] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GridViewOnWinForms] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GridViewOnWinForms] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GridViewOnWinForms] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GridViewOnWinForms] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GridViewOnWinForms] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GridViewOnWinForms] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GridViewOnWinForms] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GridViewOnWinForms] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GridViewOnWinForms] SET  MULTI_USER 
GO
ALTER DATABASE [GridViewOnWinForms] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GridViewOnWinForms] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GridViewOnWinForms] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GridViewOnWinForms] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GridViewOnWinForms] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GridViewOnWinForms] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GridViewOnWinForms] SET QUERY_STORE = OFF
GO
USE [GridViewOnWinForms]
GO
/****** Object:  Table [dbo].[zamowienia]    Script Date: 14.07.2022 18:44:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[zamowienia](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[numer_zamowienia] [int] NULL,
	[opis] [nchar](100) NULL,
	[nazwa_klienta] [nchar](50) NULL,
 CONSTRAINT [PK_zamowienia] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[zamowienia] ON 

INSERT [dbo].[zamowienia] ([id], [numer_zamowienia], [opis], [nazwa_klienta]) VALUES (1, 1244, N'opis1', N'Marek')
INSERT [dbo].[zamowienia] ([id], [numer_zamowienia], [opis], [nazwa_klienta]) VALUES (2, 9128, N'opis2', N'Darek')
INSERT [dbo].[zamowienia] ([id], [numer_zamowienia], [opis], [nazwa_klienta]) VALUES (3, 5135, N'opis3', N'Dominika')
INSERT [dbo].[zamowienia] ([id], [numer_zamowienia], [opis], [nazwa_klienta]) VALUES (4, 5831, N'opis4', N'Antek')
INSERT [dbo].[zamowienia] ([id], [numer_zamowienia], [opis], [nazwa_klienta]) VALUES (5, 2222, N'opis5', N'Darek')
SET IDENTITY_INSERT [dbo].[zamowienia] OFF
GO
USE [master]
GO
ALTER DATABASE [GridViewOnWinForms] SET  READ_WRITE 
GO
