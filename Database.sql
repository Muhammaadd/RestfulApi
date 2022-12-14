USE [master]
GO
/****** Object:  Database [WepApiMonofiaDotNetQ3]    Script Date: 8/16/2022 3:28:08 PM ******/
CREATE DATABASE [WepApiMonofiaDotNetQ3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WepApiMonofiaDotNetQ3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\WepApiMonofiaDotNetQ3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WepApiMonofiaDotNetQ3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\WepApiMonofiaDotNetQ3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WepApiMonofiaDotNetQ3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET ARITHABORT OFF 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET  ENABLE_BROKER 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET RECOVERY FULL 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET  MULTI_USER 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'WepApiMonofiaDotNetQ3', N'ON'
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET QUERY_STORE = OFF
GO
USE [WepApiMonofiaDotNetQ3]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 8/16/2022 3:28:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 8/16/2022 3:28:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product]    Script Date: 8/16/2022 3:28:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Price] [real] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Cat_id] [int] NULL,
 CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220726095358_v1', N'6.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220726101006_v2', N'6.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220726122227_v3', N'6.0.7')
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name]) VALUES (1, N'Mobiles')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (2, N'Tablets')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (3, N'TVs')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[product] ON 

INSERT [dbo].[product] ([Id], [Name], [Price], [Description], [Cat_id]) VALUES (2, N'Product One', 8500, N'This is product number one', 1)
INSERT [dbo].[product] ([Id], [Name], [Price], [Description], [Cat_id]) VALUES (3, N'Product Two', 7500, N'This is product number two', 1)
INSERT [dbo].[product] ([Id], [Name], [Price], [Description], [Cat_id]) VALUES (4, N'Product Three', 4000, N'This is product number three', 2)
INSERT [dbo].[product] ([Id], [Name], [Price], [Description], [Cat_id]) VALUES (5, N'Product Four', 10000, N'This is product number four', 2)
INSERT [dbo].[product] ([Id], [Name], [Price], [Description], [Cat_id]) VALUES (6, N'Product Five', 12622, N'This is product number five', 3)
INSERT [dbo].[product] ([Id], [Name], [Price], [Description], [Cat_id]) VALUES (7, N'Product Six', 74529, N'This is product number six', 3)
SET IDENTITY_INSERT [dbo].[product] OFF
GO
/****** Object:  Index [IX_product_Cat_id]    Script Date: 8/16/2022 3:28:08 PM ******/
CREATE NONCLUSTERED INDEX [IX_product_Cat_id] ON [dbo].[product]
(
	[Cat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[product]  WITH CHECK ADD  CONSTRAINT [FK_product_Category_Cat_id] FOREIGN KEY([Cat_id])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[product] CHECK CONSTRAINT [FK_product_Category_Cat_id]
GO
USE [master]
GO
ALTER DATABASE [WepApiMonofiaDotNetQ3] SET  READ_WRITE 
GO
