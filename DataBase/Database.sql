USE [master]
GO
/****** Object:  Database [Gestionclient]    Script Date: 12/01/2021 11:39:35 ******/
CREATE DATABASE [Gestionclient]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Gestionclient', FILENAME = N'C:\Users\Youcode\Gestionclient.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Gestionclient_log', FILENAME = N'C:\Users\Youcode\Gestionclient_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Gestionclient] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Gestionclient].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Gestionclient] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Gestionclient] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Gestionclient] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Gestionclient] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Gestionclient] SET ARITHABORT OFF 
GO
ALTER DATABASE [Gestionclient] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Gestionclient] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Gestionclient] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Gestionclient] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Gestionclient] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Gestionclient] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Gestionclient] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Gestionclient] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Gestionclient] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Gestionclient] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Gestionclient] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Gestionclient] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Gestionclient] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Gestionclient] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Gestionclient] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Gestionclient] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Gestionclient] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Gestionclient] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Gestionclient] SET  MULTI_USER 
GO
ALTER DATABASE [Gestionclient] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Gestionclient] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Gestionclient] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Gestionclient] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Gestionclient] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Gestionclient] SET QUERY_STORE = OFF
GO
USE [Gestionclient]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Gestionclient]
GO
/****** Object:  Table [dbo].[client]    Script Date: 12/01/2021 11:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[client](
	[id] [int] NULL,
	[nom] [varchar](50) NULL,
	[adresse] [varchar](50) NULL,
	[ville] [varchar](50) NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Gestionclient] SET  READ_WRITE 
GO
