USE [master]
GO
/****** Object:  Database [db_contatos]    Script Date: 3/22/2022 4:30:35 PM ******/
CREATE DATABASE [db_contatos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_contatos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\db_contatos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_contatos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\db_contatos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [db_contatos] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_contatos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_contatos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_contatos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_contatos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_contatos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_contatos] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_contatos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_contatos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_contatos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_contatos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_contatos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_contatos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_contatos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_contatos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_contatos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_contatos] SET  ENABLE_BROKER 
GO
ALTER DATABASE [db_contatos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_contatos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_contatos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_contatos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_contatos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_contatos] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [db_contatos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_contatos] SET RECOVERY FULL 
GO
ALTER DATABASE [db_contatos] SET  MULTI_USER 
GO
ALTER DATABASE [db_contatos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_contatos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_contatos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_contatos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_contatos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_contatos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'db_contatos', N'ON'
GO
ALTER DATABASE [db_contatos] SET QUERY_STORE = OFF
GO
USE [db_contatos]
GO
/****** Object:  User [Teste]    Script Date: 3/22/2022 4:30:35 PM ******/
CREATE USER [Teste] FOR LOGIN [Teste] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 3/22/2022 4:30:35 PM ******/
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
/****** Object:  Table [dbo].[Contatos]    Script Date: 3/22/2022 4:30:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contatos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](max) NULL,
	[sobrenome] [nvarchar](max) NULL,
	[email] [nvarchar](max) NULL,
	[telefone] [varchar](max) NOT NULL,
	[observacao] [nvarchar](max) NULL,
 CONSTRAINT [PK_Contatos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [db_contatos] SET  READ_WRITE 
GO
