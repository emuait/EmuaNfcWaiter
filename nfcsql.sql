/******ZawXseCdr9731******/


USE [master]
GO
/****** Object:  Database [dbEmuaNfc]    Script Date: 21.10.2018 22:44:30 ******/
CREATE DATABASE [dbEmuaNfc]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbEmuaNfc', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\dbEmuaNfc.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbEmuaNfc_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\dbEmuaNfc_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [dbEmuaNfc] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbEmuaNfc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbEmuaNfc] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbEmuaNfc] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbEmuaNfc] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbEmuaNfc] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbEmuaNfc] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbEmuaNfc] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbEmuaNfc] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbEmuaNfc] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbEmuaNfc] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbEmuaNfc] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbEmuaNfc] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbEmuaNfc] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbEmuaNfc] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbEmuaNfc] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbEmuaNfc] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbEmuaNfc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbEmuaNfc] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbEmuaNfc] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbEmuaNfc] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbEmuaNfc] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbEmuaNfc] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbEmuaNfc] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbEmuaNfc] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbEmuaNfc] SET  MULTI_USER 
GO
ALTER DATABASE [dbEmuaNfc] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbEmuaNfc] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbEmuaNfc] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbEmuaNfc] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [dbEmuaNfc] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbEmuaNfc', N'ON'
GO
ALTER DATABASE [dbEmuaNfc] SET QUERY_STORE = OFF
GO
USE [dbEmuaNfc]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [dbEmuaNfc]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 21.10.2018 22:44:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 21.10.2018 22:44:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
	[User_Id] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 21.10.2018 22:44:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[UserId] [nvarchar](128) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 21.10.2018 22:44:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 21.10.2018 22:44:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[UserName] [nvarchar](max) NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Surname] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Discriminator] [nvarchar](128) NOT NULL,
	[CompanyId] [int] NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NfcCompany]    Script Date: 21.10.2018 22:44:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NfcCompany](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[LogoUrl] [nvarchar](max) NULL,
	[WebSiteUrl] [nvarchar](max) NULL,
	[Adress] [nvarchar](max) NULL,
	[Mail] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_dbo.NfcCompany] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NfcCompanyDeskAlarm]    Script Date: 21.10.2018 22:44:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NfcCompanyDeskAlarm](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AlarmTypeName] [nvarchar](150) NOT NULL,
	[CreatedDate] [datetime] NULL,
	[DeskId] [int] NOT NULL,
	[CompanyId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.NfcCompanyDeskAlarm] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NfcDesk]    Script Date: 21.10.2018 22:44:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NfcDesk](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[CreatedDate] [datetime] NULL,
	[DeskCategoryId] [int] NOT NULL,
	[CompanyId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.NfcDesk] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NfcDeskCategory]    Script Date: 21.10.2018 22:44:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NfcDeskCategory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[OrderNumber] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CompanyId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.NfcDeskCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NfcMenu]    Script Date: 21.10.2018 22:44:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NfcMenu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[Url] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[OrderNumber] [int] NULL,
	[Status] [bit] NOT NULL,
	[CreatedDate] [datetime] NULL,
	[IsAdmin] [bit] NOT NULL,
	[CompanyId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.NfcMenu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NfcTag]    Script Date: 21.10.2018 22:44:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NfcTag](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[Code] [nvarchar](150) NULL,
	[CreatedDate] [datetime] NULL,
	[CompanyId] [int] NOT NULL,
	[DeskId] [int] NOT NULL,
 CONSTRAINT [PK_NfcTag] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[NfcCompany] ON 

INSERT [dbo].[NfcCompany] ([Id], [Name], [LogoUrl], [WebSiteUrl], [Adress], [Mail], [Phone], [CreatedDate]) VALUES (1, N'EMUA', N'EMUA', N'EMUA', N'SANCAKTEPE', N'emua@emua.com', N'0545 295 29 53', CAST(N'2018-10-18T00:00:00.000' AS DateTime))
INSERT [dbo].[NfcCompany] ([Id], [Name], [LogoUrl], [WebSiteUrl], [Adress], [Mail], [Phone], [CreatedDate]) VALUES (2, N'KILIÇ CAFE', N'EMUA', N'EMUA', N'SANCAKTEPE', N'emua@emua.com', N'0545 295 29 53', CAST(N'2018-10-18T00:00:00.000' AS DateTime))
INSERT [dbo].[NfcCompany] ([Id], [Name], [LogoUrl], [WebSiteUrl], [Adress], [Mail], [Phone], [CreatedDate]) VALUES (3, N'MY KAHVECE', N'EMUA', N'EMUA', N'SANCAKTEPE', N'emua@emua.com', N'0545 295 29 53', CAST(N'2018-10-18T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[NfcCompany] OFF
SET IDENTITY_INSERT [dbo].[NfcDesk] ON 

INSERT [dbo].[NfcDesk] ([Id], [Name], [CreatedDate], [DeskCategoryId], [CompanyId]) VALUES (10, N'MASA-1', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 2, 1)
INSERT [dbo].[NfcDesk] ([Id], [Name], [CreatedDate], [DeskCategoryId], [CompanyId]) VALUES (13, N'MASA-2', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 2, 1)
INSERT [dbo].[NfcDesk] ([Id], [Name], [CreatedDate], [DeskCategoryId], [CompanyId]) VALUES (14, N'MASA-3', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 2, 1)
INSERT [dbo].[NfcDesk] ([Id], [Name], [CreatedDate], [DeskCategoryId], [CompanyId]) VALUES (15, N'MASA-4', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 2, 1)
INSERT [dbo].[NfcDesk] ([Id], [Name], [CreatedDate], [DeskCategoryId], [CompanyId]) VALUES (16, N'MASA-5', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 2, 1)
INSERT [dbo].[NfcDesk] ([Id], [Name], [CreatedDate], [DeskCategoryId], [CompanyId]) VALUES (17, N'MASA-6', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 2, 1)
INSERT [dbo].[NfcDesk] ([Id], [Name], [CreatedDate], [DeskCategoryId], [CompanyId]) VALUES (18, N'MASA-7', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 2, 1)
INSERT [dbo].[NfcDesk] ([Id], [Name], [CreatedDate], [DeskCategoryId], [CompanyId]) VALUES (19, N'MASA-1', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 4, 1)
INSERT [dbo].[NfcDesk] ([Id], [Name], [CreatedDate], [DeskCategoryId], [CompanyId]) VALUES (20, N'MASA-2', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 4, 1)
INSERT [dbo].[NfcDesk] ([Id], [Name], [CreatedDate], [DeskCategoryId], [CompanyId]) VALUES (21, N'MASA-1', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 5, 2)
INSERT [dbo].[NfcDesk] ([Id], [Name], [CreatedDate], [DeskCategoryId], [CompanyId]) VALUES (22, N'MASA-2', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 5, 2)
INSERT [dbo].[NfcDesk] ([Id], [Name], [CreatedDate], [DeskCategoryId], [CompanyId]) VALUES (23, N'MASA-3', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 5, 2)
INSERT [dbo].[NfcDesk] ([Id], [Name], [CreatedDate], [DeskCategoryId], [CompanyId]) VALUES (24, N'MASA-4', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 5, 2)
SET IDENTITY_INSERT [dbo].[NfcDesk] OFF
SET IDENTITY_INSERT [dbo].[NfcDeskCategory] ON 

INSERT [dbo].[NfcDeskCategory] ([Id], [Name], [OrderNumber], [CreatedDate], [CompanyId]) VALUES (2, N'BAHÇE', 1, CAST(N'2018-10-18T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[NfcDeskCategory] ([Id], [Name], [OrderNumber], [CreatedDate], [CompanyId]) VALUES (4, N'SALON', 2, CAST(N'2018-10-18T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[NfcDeskCategory] ([Id], [Name], [OrderNumber], [CreatedDate], [CompanyId]) VALUES (5, N'ANA SALON', 1, CAST(N'2018-10-18T00:00:00.000' AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[NfcDeskCategory] OFF
SET IDENTITY_INSERT [dbo].[NfcMenu] ON 

INSERT [dbo].[NfcMenu] ([Id], [Name], [ImageUrl], [Url], [Title], [OrderNumber], [Status], [CreatedDate], [IsAdmin], [CompanyId]) VALUES (1, N'MASA KATEGORİ', N'DeskCategory', N'DeskCategory', N'MASA KATEGORİLERİ', 1, 1, CAST(N'2018-10-18T00:00:00.000' AS DateTime), 0, 1)
INSERT [dbo].[NfcMenu] ([Id], [Name], [ImageUrl], [Url], [Title], [OrderNumber], [Status], [CreatedDate], [IsAdmin], [CompanyId]) VALUES (3, N'MASA(LAR)', N'Desk', N'Desk', N'MASA(LAR)', 1, 1, CAST(N'2018-10-18T00:00:00.000' AS DateTime), 0, 1)
SET IDENTITY_INSERT [dbo].[NfcMenu] OFF
SET IDENTITY_INSERT [dbo].[NfcTag] ON 

INSERT [dbo].[NfcTag] ([Id], [Name], [Code], [CreatedDate], [CompanyId], [DeskId]) VALUES (1, N'ETİKET-1', N'ETİKET-1', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 1, 10)
INSERT [dbo].[NfcTag] ([Id], [Name], [Code], [CreatedDate], [CompanyId], [DeskId]) VALUES (2, N'ETİKET-2', N'ETİKET-2', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 1, 13)
INSERT [dbo].[NfcTag] ([Id], [Name], [Code], [CreatedDate], [CompanyId], [DeskId]) VALUES (3, N'ETİKET-3', N'ETİKET-3', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 1, 14)
INSERT [dbo].[NfcTag] ([Id], [Name], [Code], [CreatedDate], [CompanyId], [DeskId]) VALUES (4, N'ETİKET-4', N'ETİKET-4', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 1, 15)
INSERT [dbo].[NfcTag] ([Id], [Name], [Code], [CreatedDate], [CompanyId], [DeskId]) VALUES (5, N'ETİKET-5', N'ETİKET-5', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 1, 16)
INSERT [dbo].[NfcTag] ([Id], [Name], [Code], [CreatedDate], [CompanyId], [DeskId]) VALUES (6, N'ETİKET-6', N'ETİKET-6', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 1, 17)
INSERT [dbo].[NfcTag] ([Id], [Name], [Code], [CreatedDate], [CompanyId], [DeskId]) VALUES (7, N'ETİKET-7', N'ETİKET-7', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 1, 18)
INSERT [dbo].[NfcTag] ([Id], [Name], [Code], [CreatedDate], [CompanyId], [DeskId]) VALUES (8, N'ETİKET-1', N'ETİKET-1', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 1, 19)
INSERT [dbo].[NfcTag] ([Id], [Name], [Code], [CreatedDate], [CompanyId], [DeskId]) VALUES (9, N'ETİKET-2', N'ETİKET-2', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 1, 20)
INSERT [dbo].[NfcTag] ([Id], [Name], [Code], [CreatedDate], [CompanyId], [DeskId]) VALUES (10, N'ETİKET-1', N'ETİKET-1', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 2, 21)
INSERT [dbo].[NfcTag] ([Id], [Name], [Code], [CreatedDate], [CompanyId], [DeskId]) VALUES (11, N'ETİKET-2', N'ETİKET-2', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 2, 22)
INSERT [dbo].[NfcTag] ([Id], [Name], [Code], [CreatedDate], [CompanyId], [DeskId]) VALUES (12, N'ETİKET-3', N'ETİKET-3', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 2, 23)
INSERT [dbo].[NfcTag] ([Id], [Name], [Code], [CreatedDate], [CompanyId], [DeskId]) VALUES (13, N'ETİKET-4', N'ETİKET-4', CAST(N'2018-10-18T00:00:00.000' AS DateTime), 2, 24)
SET IDENTITY_INSERT [dbo].[NfcTag] OFF
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_User_Id] FOREIGN KEY([User_Id])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_User_Id]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[NfcCompanyDeskAlarm]  WITH CHECK ADD  CONSTRAINT [FK_NfcCompanyDeskAlarm_NfcCompany] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[NfcCompany] ([Id])
GO
ALTER TABLE [dbo].[NfcCompanyDeskAlarm] CHECK CONSTRAINT [FK_NfcCompanyDeskAlarm_NfcCompany]
GO
ALTER TABLE [dbo].[NfcCompanyDeskAlarm]  WITH CHECK ADD  CONSTRAINT [FK_NfcCompanyDeskAlarm_NfcDesk] FOREIGN KEY([DeskId])
REFERENCES [dbo].[NfcDesk] ([Id])
GO
ALTER TABLE [dbo].[NfcCompanyDeskAlarm] CHECK CONSTRAINT [FK_NfcCompanyDeskAlarm_NfcDesk]
GO
ALTER TABLE [dbo].[NfcDesk]  WITH CHECK ADD  CONSTRAINT [FK_NfcDesk_NfcCompany] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[NfcCompany] ([Id])
GO
ALTER TABLE [dbo].[NfcDesk] CHECK CONSTRAINT [FK_NfcDesk_NfcCompany]
GO
ALTER TABLE [dbo].[NfcDesk]  WITH CHECK ADD  CONSTRAINT [FK_NfcDesk_NfcDeskCategory] FOREIGN KEY([DeskCategoryId])
REFERENCES [dbo].[NfcDeskCategory] ([Id])
GO
ALTER TABLE [dbo].[NfcDesk] CHECK CONSTRAINT [FK_NfcDesk_NfcDeskCategory]
GO
ALTER TABLE [dbo].[NfcDeskCategory]  WITH CHECK ADD  CONSTRAINT [FK_NfcDeskCategory_NfcCompany] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[NfcCompany] ([Id])
GO
ALTER TABLE [dbo].[NfcDeskCategory] CHECK CONSTRAINT [FK_NfcDeskCategory_NfcCompany]
GO
ALTER TABLE [dbo].[NfcMenu]  WITH CHECK ADD  CONSTRAINT [FK_NfcMenu_NfcCompany] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[NfcCompany] ([Id])
GO
ALTER TABLE [dbo].[NfcMenu] CHECK CONSTRAINT [FK_NfcMenu_NfcCompany]
GO
ALTER TABLE [dbo].[NfcTag]  WITH CHECK ADD  CONSTRAINT [FK_NfcTag_NfcCompany] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[NfcCompany] ([Id])
GO
ALTER TABLE [dbo].[NfcTag] CHECK CONSTRAINT [FK_NfcTag_NfcCompany]
GO
ALTER TABLE [dbo].[NfcTag]  WITH CHECK ADD  CONSTRAINT [FK_NfcTag_NfcDesk] FOREIGN KEY([DeskId])
REFERENCES [dbo].[NfcDesk] ([Id])
GO
ALTER TABLE [dbo].[NfcTag] CHECK CONSTRAINT [FK_NfcTag_NfcDesk]
GO
USE [master]
GO
ALTER DATABASE [dbEmuaNfc] SET  READ_WRITE 
GO
