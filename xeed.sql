USE [master]
GO
/****** Object:  Database [AppsHyveDb_XeedConsulting]    Script Date: 3/26/2024 9:53:20 PM ******/
CREATE DATABASE [AppsHyveDb_XeedConsulting]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AppsHyveDb_XeedConsulting', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\AppsHyveDb_XeedConsulting.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AppsHyveDb_XeedConsulting_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\AppsHyveDb_XeedConsulting_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AppsHyveDb_XeedConsulting].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET ARITHABORT OFF 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET RECOVERY FULL 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET  MULTI_USER 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET QUERY_STORE = OFF
GO
USE [AppsHyveDb_XeedConsulting]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [AppsHyveDb_XeedConsulting]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 3/26/2024 9:53:20 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AboutCompany]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AboutCompany](
	[Id] [uniqueidentifier] NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Title_Ar] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Description_Ar] [nvarchar](max) NULL,
	[Mission] [nvarchar](max) NULL,
	[Mission_Ar] [nvarchar](max) NULL,
	[Vision] [nvarchar](max) NULL,
	[Vision_Ar] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
 CONSTRAINT [PK_AboutCompany] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AboutUs]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AboutUs](
	[Id] [uniqueidentifier] NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Title_Ar] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Description_Ar] [nvarchar](max) NULL,
	[Mission] [nvarchar](max) NULL,
	[Mission_Ar] [nvarchar](max) NULL,
	[Vision] [nvarchar](max) NULL,
	[Vision_Ar] [nvarchar](max) NULL,
	[Image1] [nvarchar](max) NULL,
	[Image2] [nvarchar](max) NULL,
 CONSTRAINT [PK_AboutUs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccordionFive]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccordionFive](
	[Id] [uniqueidentifier] NOT NULL,
	[Order] [int] NOT NULL,
	[TitleAccordion] [nvarchar](max) NULL,
	[TitleAccordion_Ar] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Description_Ar] [nvarchar](max) NULL,
 CONSTRAINT [PK_AccordionFive] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccordionFour]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccordionFour](
	[Id] [uniqueidentifier] NOT NULL,
	[Order] [int] NOT NULL,
	[TitleAccordion] [nvarchar](max) NULL,
	[TitleAccordion_Ar] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Description_Ar] [nvarchar](max) NULL,
 CONSTRAINT [PK_AccordionFour] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccordionThree]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccordionThree](
	[Id] [uniqueidentifier] NOT NULL,
	[Order] [int] NOT NULL,
	[TitleAccordion] [nvarchar](max) NULL,
	[TitleAccordion_Ar] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Description_Ar] [nvarchar](max) NULL,
 CONSTRAINT [PK_AccordionThree] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccordionTwo]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccordionTwo](
	[Id] [uniqueidentifier] NOT NULL,
	[Order] [int] NOT NULL,
	[TitleAccordion] [nvarchar](max) NULL,
	[TitleAccordion_Ar] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Description_Ar] [nvarchar](max) NULL,
 CONSTRAINT [PK_AccordionTwo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AddressInfo]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AddressInfo](
	[AddressInfoId] [uniqueidentifier] NOT NULL,
	[Location] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Location_Ar] [nvarchar](max) NULL,
 CONSTRAINT [PK_AddressInfo] PRIMARY KEY CLUSTERED 
(
	[AddressInfoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aspiration]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aspiration](
	[Id] [uniqueidentifier] NOT NULL,
	[Text] [nvarchar](max) NULL,
	[Text_Ar] [nvarchar](max) NULL,
	[Text1] [nvarchar](max) NULL,
	[Text1_Ar] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
 CONSTRAINT [PK_Aspiration] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[UserId] [uniqueidentifier] NOT NULL,
	[LoginProvider] [nvarchar](max) NULL,
	[ProviderKey] [nvarchar](max) NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [uniqueidentifier] NOT NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [uniqueidentifier] NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [uniqueidentifier] NOT NULL,
	[LoginProvider] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Capabilities]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Capabilities](
	[Id] [uniqueidentifier] NOT NULL,
	[Image] [nvarchar](max) NULL,
	[text] [nvarchar](max) NULL,
	[text_Ar] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Description_Ar] [nvarchar](max) NULL,
	[Order] [int] NOT NULL,
 CONSTRAINT [PK_Capabilities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Commitment]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Commitment](
	[Id] [uniqueidentifier] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Description_Ar] [nvarchar](max) NULL,
 CONSTRAINT [PK_Commitment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Footer]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Footer](
	[FooterId] [uniqueidentifier] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Description_Ar] [nvarchar](max) NULL,
 CONSTRAINT [PK_Footer] PRIMARY KEY CLUSTERED 
(
	[FooterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HowWork]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HowWork](
	[Id] [uniqueidentifier] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Description_Ar] [nvarchar](max) NULL,
 CONSTRAINT [PK_HowWork] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Industries]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Industries](
	[Id] [uniqueidentifier] NOT NULL,
	[Image] [nvarchar](max) NULL,
	[text] [nvarchar](max) NULL,
	[text_Ar] [nvarchar](max) NULL,
	[Order] [int] NOT NULL,
 CONSTRAINT [PK_Industries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Leadership]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Leadership](
	[LeadershipId] [uniqueidentifier] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Description_Ar] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
 CONSTRAINT [PK_Leadership] PRIMARY KEY CLUSTERED 
(
	[LeadershipId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Purpose]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purpose](
	[Id] [uniqueidentifier] NOT NULL,
	[Text] [nvarchar](max) NULL,
	[Text_Ar] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
 CONSTRAINT [PK_Purpose] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sliders]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sliders](
	[Id] [uniqueidentifier] NOT NULL,
	[Title_EN] [nvarchar](max) NULL,
	[Title_AR] [nvarchar](max) NULL,
	[Order] [int] NOT NULL,
	[Image] [nvarchar](max) NULL,
 CONSTRAINT [PK_Sliders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Team]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Team](
	[TeamId] [uniqueidentifier] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Description_Ar] [nvarchar](max) NULL,
	[Image1] [nvarchar](max) NULL,
	[Image2] [nvarchar](max) NULL,
 CONSTRAINT [PK_Team] PRIMARY KEY CLUSTERED 
(
	[TeamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WhyUs]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WhyUs](
	[Id] [uniqueidentifier] NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Title_Ar] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Description_Ar] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
 CONSTRAINT [PK_WhyUs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WhyUsAccordion]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WhyUsAccordion](
	[Id] [uniqueidentifier] NOT NULL,
	[AccordionId] [int] NOT NULL,
	[TitleAccordion] [nvarchar](max) NULL,
	[TitleAccordion_Ar] [nvarchar](max) NULL,
	[SubTitleAccordion] [nvarchar](max) NULL,
	[SubTitleAccordion_Ar] [nvarchar](max) NULL,
	[Order] [int] NOT NULL,
 CONSTRAINT [PK_WhyUsAccordion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WhyUsHome]    Script Date: 3/26/2024 9:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WhyUsHome](
	[Id] [uniqueidentifier] NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Title_Ar] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Description_Ar] [nvarchar](max) NULL,
	[Image1] [nvarchar](max) NULL,
	[Image2] [nvarchar](max) NULL,
	[Image4] [nvarchar](max) NULL,
 CONSTRAINT [PK_WhyUsHome] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230922135143_Create-Initial', N'6.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231030085636_Creat-Address-Footer', N'6.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231031091134_Update-footer-address', N'6.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231101090056_Create-AllFor-HomePage', N'6.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231101144749_update-AboutUs', N'6.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231102104842_Update-WhyUsAccordion', N'6.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231102113655_Add-team-and-leadership', N'6.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231102152749_Add-Commitment-And-HowWeWork', N'6.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231103142002_Creat-All-Table', N'6.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231103142616_update-all-table', N'6.0.10')
GO
INSERT [dbo].[AboutCompany] ([Id], [Title], [Title_Ar], [Description], [Description_Ar], [Mission], [Mission_Ar], [Vision], [Vision_Ar], [Image]) VALUES (N'15d0def6-10d3-4d98-aaaf-993f3416159f', N'Professional And Dedicated </br>Consulting Services', N'المهنية و الاتقان </br>الخدمات الاستشارية', N' We are a leading business and technology consultancy dedicated to helping businesses thrive in today''s dynamic and digital landscape. Our mission is to deliver innovative solutions and strategic guidance to drive your company''s growth and success. With our team of seasoned experts and deep industry knowledge, we are committed to providing you with unparalleled consultancy services.
   ', N'نحن شركة استشارية رائدة في مجال الأعمال والتكنولوجيا تختص في مساعدة الشركات على الازدهار في القطاع التجاري، الصحي، التكنولوجيا و الاعمال. مهمتنا هي تقديم حلول مبتكرة وتوجيه استراتيجي متكامل للدفع نحو تطوير شركتك ونجاحها. مع فريقنا من الخبراء المتمرسين والمتميزين بالمعرفة العميقة في مختلف المجالات، نحن ملتزمون بتزويدك بخدمات استشارية لا مثيل لها.

', N'"To empower businesses through innovative strategies and technology-driven solutions, fostering growth and sustainable success in a dynamic and digital world."





', N'"مساعدة الشركات من خلال استراتيجيات مبتكرة وحلول تعتمد على التكنولوجيا، وتعزيز النمو والنجاح المستدام في عالم ديناميكي ورقمي."', N'"To be a leading global partner for businesses, revolutionizing industries through innovative business strategies and technology solutions, empowering our clients to achieve unparalleled growth and success."', N'"أن نكون شريكا عالميا رائدا للشركات، ونحدث ثورة في الصناعات و الاعمال التجارية، الطبية و الصناعية من خلال استراتيجيات الأعمال المبتكرة والحلول الرقمية، مما يمكن عملاؤنا من تحقيق نمو ونجاح لا مثيل لهما."
', N'b81bdc26-57d1-46d9-9a12-dd9c31a74c9c_01.png')
GO
INSERT [dbo].[AboutUs] ([Id], [Title], [Title_Ar], [Description], [Description_Ar], [Mission], [Mission_Ar], [Vision], [Vision_Ar], [Image1], [Image2]) VALUES (N'c8e2251b-aa23-4e7a-8064-a10c3319e1e5', N'About Xeed Consulting', N'About Xeed Consulting', N'Xeed Consulting was founded with the purpose of empowering businesses through innovating business and technology-driven strategies. Since our inception, we have partnered with numerous organizations across various industries, delivering tangible results and transformative outcomes.</br></br>We are dedicated to helping organizations thrive through our strategic expertise and innovative solutions, we empower businesses to navigate complex challenges, seize growth opportunities, and achieve sustainable success.</br></br>Xeed Consulting emerged from a shared vision of a team of seasoned consultants who recognized the transformative potential of combining business acumen with cutting-edge technology. Over the years, we have built a solid reputation for delivering tangible results and driving positive change for our clients. Our commitment to excellence, continuous learning, and client-centric approach has been the cornerstone of our success.', N'أسست شركة Xeed Consulting بهدف المساعدة في نمو الشركات من خلال الأعمال المبتكرة والاستراتيجيات القائمة على التكنولوجيا. منذ نشأتنا، دخلنا في شراكة مع العديد من المنظمات عبر مختلف مجالات الاعمال، وتقديم نتائج ملموسة و مميزة.</br></br>نحن ملتزمون بمساعدة المؤسسات على الازدهار من خلال خبرتنا الاستراتيجية وحلولنا المبتكرة، كما نمكن الشركات من التغلب على التحديات المعقدة، واغتنام فرص النمو، وتحقيق النجاح المستدام.</br></br>انبثقت شركة Xeed Consulting من رؤية مشتركة لفريق من الاستشاريين المتمرسين الذين أدركوا مدى اهمية الجمع بين الخبرة التجارية والتكنولوجيا المتطورة. على مر السنين، قمنا ببناء سمعة راسخة لتقديم نتائج ملموسة وقيادة التغيير الإيجابي لعملائنا. كان التزامنا بالتميز والتعلم المستمر والنهج الذي يركز على العميل الركيزة الاساسية في نجاحنا', N'"To empower businesses through innovative strategies and technology-driven solutions, fostering growth and sustainable success in a dynamic and digital world."', N'"لتمكين الشركات من خلال استراتيجيات مبتكرة وحلول تعتمد على التكنولوجيا، وتعزيز النمو والنجاح المستدام في عالم ديناميكي ورقمي."', N'"To be a leading global partner for businesses, revolutionizing industries through innovative business strategies and technology solutions, empowering our clients to achieve unparalleled growth and success."', N'"أن نكون شريكًا عالميًا رائدًا للشركات، ونحدث ثورة في الصناعات من خلال استراتيجيات الأعمال المبتكرة والحلول التكنولوجية، وتمكين عملائنا من تحقيق نمو ونجاح لا مثيل لهما."', N'a70fee03-26c2-4a6e-9513-b27e50c8cc4e_about-03.jpg', N'ece9ce6f-9db2-461a-8913-f091cfe2d296_about-04.jpg')
GO
INSERT [dbo].[AccordionFive] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'131f0cbe-8cb0-4be9-86b8-08dbdebadd5a', 1, N' Integrity', N'النزاهة', N'We hold ourselves to the highest standards of honesty and integrity. We believe in doing what''s right, even when it''s challenging. Integrity is the foundation of our client relationships and the trust that underpins our consultancy.', N'نضع أنفسنا على أعلى مستويات الصدق والنزاهة. نؤمن بفعل الصواب حتى عندما يكون ذلك صعبًا. النزاهة هي أساس علاقاتنا مع العملاء والثقة التي تشكل أساس استشاراتنا.')
INSERT [dbo].[AccordionFive] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'0b4c43de-b310-421c-df76-08dbdebb287f', 2, N'Transparency', N'الشفافية', N'Open and clear communication is at the heart of our approach. We believe in transparent partnerships, where you are informed and engaged at every step of the journey. Transparency builds trust, and trust is the bedrock of our consultancy.', N'التواصل المفتوح والواضح هو في قلب منهجنا. نؤمن بالشراكات الشفافة، حيث تكون مطلعًا ومشاركًا في كل خطوة في الرحلة. الشفافية تبني الثقة، والثقة هي أساس استشاراتنا.')
INSERT [dbo].[AccordionFive] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'7043b350-c591-4f4c-df77-08dbdebb287f', 3, N'Client-Centricity', N' التوجه نحو العميل', N'Your success is our primary focus. We are dedicated to understanding your unique challenges, goals, and aspirations. Our solutions are tailored to your specific needs, ensuring that we align our strategies with your objectives.', N'نجاحك هو تركيزنا الرئيسي. نحن ملتزمون بفهم تحدياتك وأهدافك وآمالك الفريدة. حلولنا مصممة حسب احتياجاتك الخاصة، مضمونة أننا نواجه استراتيجياتنا مع أهدافك.')
INSERT [dbo].[AccordionFive] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'99dd2197-5c4d-4c0e-df78-08dbdebb287f', 4, N' Innovation', N'الابتكار', N'Innovation is the driving force behind progress. We constantly seek new and creative solutions to the challenges our clients face. We encourage fresh perspectives and out-of-the-box thinking to drive continuous improvement.', N'الابتكار هو القوة الدافعة وراء التقدم. نبحث باستمرار عن حلول جديدة ومبتكرة للتحديات التي تواجه عملائنا. نشجع على آراء جديدة وتفكير خارج الصندوق لدفع التحسين المستمر.')
INSERT [dbo].[AccordionFive] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'44720f9e-33af-4538-df79-08dbdebb287f', 5, N' Collaboration', N' التعاون', N'We believe in the power of collaboration, both within our team and with our clients. By working together, we harness the collective intelligence and creativity that fuels transformative change.', N'نؤمن بقوة التعاون، سواء داخل فريقنا أو مع عملائنا. من خلال العمل المشترك، نستغل الذكاء والإبداع الجماعي الذي يدفع التغيير النوعي.')
INSERT [dbo].[AccordionFive] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'a0970afe-d1ae-4c47-df7a-08dbdebb287f', 6, N'Continuous Learning', N' التعلم المستمر', N'In a rapidly changing world, the pursuit of knowledge is paramount. We are committed to continuous learning and staying at the forefront of industry trends and best practices.', N'في عالم يتغير بسرعة، السعي لاكتساب المعرفة أمر بارز. نحن ملتزمون بالتعلم المستمر والبقاء في مقدمة الصناعة فيما يتعلق بالاتجاهات وأفضل الممارسات.')
INSERT [dbo].[AccordionFive] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'd31e5111-43a1-4b30-df7b-08dbdebb287f', 7, N' Diversity and Inclusion', N'التنوع والشمولية', N'We celebrate diversity and believe in creating an inclusive work environment. Different perspectives enrich our consultancy and lead to more robust, innovative solutions. At Xeed Consulting, our leadership, purpose, and values are more than just words on a page; they are the principles that guide us every day. When you choose to partner with us, you are choosing a consultancy firm that is not only dedicated to your success but is also driven by a higher purpose and unwavering values. Together, we will navigate the complex business landscape and achieve remarkable results.', N'نحتفل بالتنوع ونؤمن بخلق بيئة عمل شمولية. وجهات النظر المتنوعة تثري استشارتنا وتؤدي إلى حلاول أكثر قوة واستدامة.')
GO
INSERT [dbo].[AccordionFour] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'187be498-94df-4949-3825-08dbdead35a7', 1, N'  Nurturing Growth                                          ', N'  تغذية النمو                                          ', N'We aspire to nurture growth in every sense of the word. We don''t just aim for short-term gains; we''re in it for the long haul. Our consultancy solutions are designed to foster sustainable growth that transcends market fluctuations and economic challenges.', N'نطمح لتغذية النمو بكل معنى الكلمة. نحن لا نهدف فقط إلى الربح في الأمد القريب؛ نحن في هذا للأمد البعيد. حلول استشارتنا مصممة لتعزيز النمو المستدام الذي يتجاوز التقلبات السوقية والتحديات الاقتصادية.')
INSERT [dbo].[AccordionFour] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'e67aadea-3cd9-4804-3826-08dbdead35a7', 2, N' Driving Innovation', N'دفع الابتكار                                          ', N'nnovation is at the heart of progress, and we aspire to drive innovation within your organization. We encourage creative thinking, fresh perspectives, and the adoption of cutting-edge technologies. Our aim is to help you stay ahead of the curve and be a leader in your industry. ', N'الابتكار هو في قلب التقدم، ونحن نطمح لدفع الابتكار داخل منظمتك. نحن نشجع على التفكير الإبداعي، ووجهات النظر الجديدة، واعتماد التقنيات المتطورة. هدفنا هو مساعدتك في البقاء في مقدمة السباق وأن تصبح قائدًا في صناعتك.')
INSERT [dbo].[AccordionFour] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'1cab4557-b395-469d-3827-08dbdead35a7', 3, N'Building Resilience                                          ', N' بناء المرونة', N'The business landscape is ever-changing, and we aspire to build resilience within your organization. We want you to not only survive in times of uncertainty but to thrive in them. Our strategies are crafted to make your organization agile, adaptable, and ready to overcome any challenge.', N'منظر الأعمال متغير دائمًا، ونحن نطمح لبناء المرونة داخل منظمتك. نريدك أن لا تنجو فقط في أوقات عدم اليقين، ولكن أن تزدهر فيها. تمت صياغة استراتيجياتنا لجعل منظمتك متناسقة وقابلة للتكيف وجاهزة للتغلب على أي تحدي.')
INSERT [dbo].[AccordionFour] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'366f6c26-c87c-4adb-3828-08dbdead35a7', 4, N'Creating Positive Impact', N'خلق تأثير إيجابي                                          ', N'We aspire to create a positive impact not only on your bottom line but also on society and the environment. Our commitment to sustainability and corporate social responsibility ensures that your success aligns with ethical practices and contributes positively to the world.', N'نطمح لخلق تأثير إيجابي ليس فقط على رصيدك المالي، ولكن أيضًا على المجتمع والبيئة. التزامنا بالاستدامة والمسؤولية الاجتماعية للشركات يضمن أن نجاحك يتوافق مع الممارسات الأخلاقية ويسهم إيجابيًا في العالم.')
INSERT [dbo].[AccordionFour] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'2b2f9708-30ee-40b1-3829-08dbdead35a7', 5, N' Fostering Collaborative Partnerships', N'تعزيز الشراكات التعاونية', N'We aspire to build more than just client-consultant relationships; we aim to foster collaborative partnerships. When you choose Xeed Consulting, you gain a team of dedicated individuals who are deeply invested in your success. Together, we''ll achieve milestones that were once thought to be out of reach.', N'نطمح لبناء أكثر من مجرد علاقات عميل - مستشار؛ نهدف لتعزيز الشراكات التعاونية. عندما تختار Exceed Consultancy، تحصل على فريق من الأفراد الملتزمين عميقًا بنجاحك. سنحقق معًا أهداف كان يعتقد البعض في السابق أنها خارجة عن الوصول.')
INSERT [dbo].[AccordionFour] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'8a4c0471-d3ec-4786-382a-08dbdead35a7', 6, N'Unleashing Potential', N'إطلاق الإمكانات', N'Our ultimate aspiration is to help you unleash your organization''s full potential. We believe that there are no limits to what a dedicated team, armed with the right strategies, can achieve. Your success is our measure of accomplishment.', N'تطلعتنا النهائي هو مساعدتك في إطلاق الإمكانات الكاملة لمنظمتك. نحن نؤمن أنه لا يوجد حدود لما يمكن لفريق مخصص، مسلح بالاستراتيجيات الصحيحة، أن يحققه. نجاحك هو مقياس إنجازنا.')
GO
INSERT [dbo].[AccordionThree] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'8cea9733-e1d2-4b38-331d-08dbdea7beb9', 1, N'Your Success is Our Business', N'نجاحك هو عملنا', N'Our foremost commitment is to your success. When you choose Xeed Consulting, you''re not just hiring a consultancy firm; you''re gaining a partner dedicated to helping you achieve your goals. Your objectives become our mission, and we work tirelessly to ensure they are met.', N'في “xceed Consulting”، التزامنا تجاه عملائنا هو ركيزة ممارسات استشارتنا. نحن ندرك أن الثقة بنا بتحدثكم تحديات وآمال أعمالكم هي قرار هام، ونحن نأخذ هذه المسؤولية على محمل الجد. التزامنا الثابت بكم هو ما يميزنا.
')
INSERT [dbo].[AccordionThree] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'e606e66c-ebfc-4414-331e-08dbdea7beb9', 2, N'Understanding Your Unique Needs', N'فهم احتياجاتكم الفريدة', N'We are committed to understanding your unique challenges and needs. No two businesses are alike, and cookie-cutter solutions rarely yield meaningful results. We take the time to listen and learn about your organization, industry, and goals. This commitment to understanding forms the foundation of our consultancy approach.', N'نحن ملتزمون بفهم تحدياتكم واحتياجاتكم الفريدة. لا تتشابه الشركات الاثنتان، والحلول القائمة على نمط واحد نادرًا ما تسفر عن نتائج ذات مغزى. نأخذ الوقت للاستماع والتعرف على منظمتكم، وصناعتكم، وأهدافكم. هذا التزامنا بالفهم يشكل أساس منهجنا في الاستشارة.')
INSERT [dbo].[AccordionThree] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'236caf17-9022-48f1-331f-08dbdea7beb9', 3, N'Crafting Tailored Solutions', N'صياغة حلول', N'One size does not fit all. Our commitment extends to crafting tailored solutions that align with your objectives. We draw upon our extensive expertise to create strategies that are not only effective but also sustainable in the long term. Our solutions are as unique as your business.', N'مُصممة خصيصًا حلاً واحد ال يلائم الجميع. التزامنا يمتد أيضًا لصياغة حلول مُصممة خصيصًا تتماشى مع أهدافكم. نستفيد من خبرتنا الواسعة لإنشاء استراتيجيات فعّالة ومستدامة على المدى الطويل. حلولنا تكون فريدة مثل أعمالكم.')
INSERT [dbo].[AccordionThree] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'377f356c-5483-4dce-3320-08dbdea7beb9', 4, N'Transparency and Collaboration', N'الشفافية والتعاون', N'We believe in open and transparent partnerships. Throughout our engagement, we are committed to keeping you informed and involved. Our collaborative approach ensures that you are an active participant in the decision-making process. We value your insights and feedback and incorporate them into our strategies.', N'نؤمن بالشراكات المفتوحة والشفافة. طوال مشاركتنا، نلتزم بإبقائكم على علم ومشاركتكم. نهجنا التعاوني يضمن أنكم شركاء فاعلين في عملية اتخاذ القرار. نقدر آراءكم وملاحظاتكم وندمجها في استراتيجياتنا.')
INSERT [dbo].[AccordionThree] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'fc65dfed-0a99-4859-3321-08dbdea7beb9', 5, N'Measuring Progress and Adaptation', N'قياس التقدم والتكيف', N'Our commitment doesn''t end with the implementation of solutions. We continuously measure progress against predefined goals and Key Performance Indicators (KPIs). If adjustments are needed, we are agile and adaptable, ready to refine our strategies to ensure success.', N'التزامنا لا ينتهي مع تنفيذ الحلول. نقيس التقدم باستمرار مقابل الأهداف المحددة مسبقًا ومؤشرات الأداء الرئيسية. إذا كانت هناك حاجة لتعديلات، نحن متماينون وقابلون للتكيف، جاهزون لتحسين استراتيجياتنا لضمان النجاح.')
INSERT [dbo].[AccordionThree] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'1d028e13-5b93-4c5d-3322-08dbdea7beb9', 6, N'A Dedicated Team of Experts', N'فريق مكرس من الخبراء', N'Our team of consultants is deeply committed to your success. They bring a wealth of experience, fresh perspectives, and a shared dedication to your growth. When you work with us, you''re not just getting a consultancy firm; you''re gaining a team of passionate individuals invested in your success.', N'فريق استشارينا ملتزم بعمق بنجاحكم. إنهم يجلبون ثروة من الخبرة، وآراء جديدة، واهتمام مشترك بنموكم. عندما تعملون معنا، لا تحصلون على مجرد شركة استشارية؛ بل تحصلون على فريق من الأفراد الشغوفين مستثمرين بعمق في نجاحكم')
INSERT [dbo].[AccordionThree] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'60d5e649-6f8f-4189-3323-08dbdea7beb9', 7, N'Ethical Business Practices', N'ممارسات أخلاقية في الأعمال', N'We uphold the highest standards of ethical business practices. Our commitment to integrity and honesty is unwavering. We believe that trust is the foundation of successful partnerships, and we earn your trust through our actions and results.', N'نحن نلتزم بأعلى معايير الممارسات الأخلاقية في الأعمال. التزامنا بالنزاهة والصدق ليس قابلاً للتزكية. نعتقد أن الثقة هي أساس الشراكات الناجحة، ونكسب ثقتكم من خلال أفعالنا ونتائجنا')
INSERT [dbo].[AccordionThree] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'3fc2b80b-4098-4861-3324-08dbdea7beb9', 8, N'Long-term Partnership', N'شراكة طويلة الأمد', N'Our commitment extends beyond the immediate project. We aim to build long-term partnerships with our clients. As your business evolves, we will be there to support you, offering guidance and solutions to address new challenges and seize new opportunities.', N'التزامنا يمتد بعيدًا عن المشروع الفوري. هدفنا هو بناء شراكات طويلة الأمد مع عملائنا. بينما تتطور أعمالكم، سنكون هنا لدعمكم، نقدم الإرشاد والحلول لمواجهة التحديات الجديدة واستغلال الفرص الجديدة.')
INSERT [dbo].[AccordionThree] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'6fd76544-c522-425c-3325-08dbdea7beb9', 9, N'Your Goals, Our Mission', N'أهدافكم هي مهمتنا', N'At Xeed Consulting, your goals become our mission. We are not just consultants; we are partners in your journey to success. Our commitment is to be with you every step of the way, helping you navigate the complexities of the business landscape. When you choose Xeed Consulting, you''re choosing a consultancy firm that is deeply committed to your success. Your objectives are not just goals; they are our commitment.', N'في “xceed Consulting”، أهدافكم تصبح مهمتنا. نحن لسنا مجرد مستشارين؛ نحن شركاء في رحلتكم نحو النجاح. التزامنا هو أن نكون معكم في كل خطوة على طول الطريق، نساعدكم على التنقل في تعقيدات منظر الأعمال.')
GO
INSERT [dbo].[AccordionTwo] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'0dcfa2e2-2eb5-41c3-d423-08dbdea540d9', 1, N' 1. Initial Consultation                                              ', N'1.	استشارة أولية                                              ', N'Our journey together begins with an in-depth consultation. During this phase, we take the time to understand your organization''s goals, challenges, and aspirations. We believe that a thorough understanding of your unique circumstances is essential for crafting effective strategies.', N'رحلتنا معًا تبدأ بجلسة استشارية مفصلة. خلال هذه المرحلة، نأخذ الوقت لفهم أهداف منظمتكم، والتحديات، والآمال. نعتقد أن الفهم الجيد لظروفكم الفريدة ضروري لصياغة استراتيجيات فعّالة.')
INSERT [dbo].[AccordionTwo] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'83e48482-064d-493d-d424-08dbdea540d9', 2, N'                                               2. Needs Assessment                                               ', N'                                               2.	تقييم الاحتياجات                                               ', N'Once we have a clear picture of your organization, we conduct a comprehensive needs assessment. This involves a deep dive into your current processes, performance metrics, and industry dynamics. We identify areas of improvement and opportunities for growth.', N'بمجرد أن نحصل على صورة واضحة عن منظمتكم، نقوم بإجراء تقييم شامل للاحتياجات. يتضمن ذلك استقصاءًا عميقًا في العمليات الحالية ومؤشرات الأداء وديناميات الصناعة. نحدد المجالات التي يمكن تحسينها والفرص للنمو.')
INSERT [dbo].[AccordionTwo] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'8f7a483d-3c1d-4548-d425-08dbdea540d9', 3, N'3. Strategy Development                                             ', N'                                               3.	تطوير الاستراتيجية                                             ', N'With the information gathered from the needs assessment, we develop a customized strategy tailored to your objectives. Our strategy is not a one-size-fits-all solution; it''s a roadmap designed specifically for your organization''s success. We involve you in the strategy development process, ensuring alignment with your vision.', N'باستخدام المعلومات التي تم جمعها من تقييم الاحتياجات، نقوم بتطوير استراتيجية مخصصة مصممة خصيصًا لأهدافكم. استراتيجيتنا ليست حلاً عامًا؛ إنها خريطة طريق مصممة بشكل خاص لنجاح منظمتكم. نشملكم في عملية تطوير الاستراتيجية لضمان التوافق مع رؤيتكم.')
INSERT [dbo].[AccordionTwo] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'36f99645-d53a-4864-007c-08dbdea6eefa', 5, N'                                              5. Continuous Measurement and Evaluation                                              ', N'                                              5.	القياس والتقييم المستمر                                              ', N'We believe in continuous improvement. Throughout our engagement, we monitor progress against predefined Key Performance Indicators (KPIs). If we see that adjustments are needed to achieve your goals, we adapt and refine our strategies accordingly.', N'نحن نؤمن بالتحسين المستمر. طوال مشاركتنا، نقوم بمراقبة التقدم مقابل مؤشرات الأداء الرئيسية المحددة مسبقًا. إذا رأينا أن هناك حاجة لتعديلات لتحقيق أهدافكم، نتكيف ونعدل استراتيجياتنا وفقًا لذلك.')
INSERT [dbo].[AccordionTwo] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'1aea616c-f2dc-449a-007d-08dbdea6eefa', 6, N'                                                6. Transparency                                              ', N'6. الشفافية', N'Transparency is a core value in our approach. We maintain open lines of communication throughout our partnership. You''ll receive regular updates on progress, challenges, and opportunities. We encourage questions and feedback to ensure that you are fully informed and engaged in the process.', N'الشفافية هي قيمة أساسية في نهجنا. نحن نحتفظ بخطوط اتصال مفتوحة طوال شراكتنا. ستتلقون تحديثات منتظمة حول التقدم والتحديات والفرص. نشجع على الأسئلة والملاحظات لضمان أنكم مطلعين تمامًا ومشاركين في العملية.')
INSERT [dbo].[AccordionTwo] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'394c0a69-548c-4c8e-007e-08dbdea6eefa', 7, N'7. Collaboration', N'7. التعاون', N'We don''t work in isolation; we work collaboratively with your team. We believe in leveraging your organization''s internal expertise and insights. By working together, we create a synergy that enhances the effectiveness of our strategies', N'نحن لا نعمل على عزلة؛ نعمل بتعاون مع فريقكم. نحن نؤمن بالاستفادة من خبرتكم وأفكاركم الداخلية. من خلال العمل المشترك، نخلق تأثيرًا إيجابيًا يعزز من فعالية استراتيجياتنا.')
INSERT [dbo].[AccordionTwo] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'3b14d6c4-c73b-4023-007f-08dbdea6eefa', 8, N'8. Flexibility', N'8. المرونة', N'We understand that the business landscape is ever-changing. Our approach is agile and adaptable. If unexpected challenges arise or market dynamics shift, we are ready to pivot and adjust our strategies to keep you on the path to success. ', N'نحن نفهم أن منظر الأعمال يتغير باستمرار. نهجنا مرن وقابل للتكيف. إذا ظهرت تحديات غير متوقعة أو تغيرت ديناميات السوق، فنحن مستعدون للانتقال وضبط استراتيجياتنا للحفاظ على النجاح.')
INSERT [dbo].[AccordionTwo] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'64cc11a5-fabc-447c-0080-08dbdea6eefa', 9, N'9. Knowledge Sharing', N'9. مشاركة المعرفة', N'We believe in empowering our clients with knowledge. Throughout our engagement, we provide training and knowledge transfer to ensure that your team has the skills and understanding to sustain the improvements we''ve implemented', N'نحن نؤمن بتمكين عملائنا بالمعرفة. طوال مشاركتنا، نقدم تدريبًا ونقل معرفة لضمان أن فريقكم يمتلك المهارات والفهم للحفاظ على التحسينات التي قمنا بتنفيذها.')
INSERT [dbo].[AccordionTwo] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'fc81ce14-2992-428b-0081-08dbdea6eefa', 10, N'10. Long-Term Partnership', N'10. شراكة طويلة الأمد', N'Our commitment doesn''t end with the completion of a project. We aim to build long-term partnerships with our clients. As your organization evolves, we will be there to support you, offering guidance and solutions to address new challenges and seize new opportunities. At Xeed Consulting, we are not just consultants; we are your dedicated partners in achieving your business objectives. Our approach is founded on collaboration, transparency, and a shared commitment to your success.', N'التزامنا لا ينتهي مع انتهاء مشروع. نهدف إلى بناء شراكات طويلة الأمد مع عملائنا. مع تطور منظمتكم، سنكون هنا لدعمكم، ونقدم الإرشاد والحلول لمعالجة التحديات الجديدة واستغلال الفرص الجديدة.')
INSERT [dbo].[AccordionTwo] ([Id], [Order], [TitleAccordion], [TitleAccordion_Ar], [Description], [Description_Ar]) VALUES (N'254a03ff-9a1d-49ee-b1e0-08dbdeaf3eb7', 4, N'4.Implementation                                              ', N'التنفيذ', N'Strategy without action is just a plan. We roll up our sleeves and get to work alongside your team to implement the strategies we''ve developed. Our consultants provide guidance, support, and hands-on assistance to ensure the smooth execution of the plan.', N'الاستراتيجية بدون عمل هي مجرد خطة. نلف الأكمام ونعمل جنبًا إلى جنب مع فريقكم لتنفيذ الاستراتيجيات التي قمنا بتطويرها. يقدم مستشارونا الإرشاد والدعم والمساعدة العملية لضمان تنفيذ الخطة بسلاسة.')
GO
INSERT [dbo].[AddressInfo] ([AddressInfoId], [Location], [Email], [Location_Ar]) VALUES (N'8b031489-237c-4da2-9b5d-6fd21d5f3b20', N'Baghdad, Iraq', N'contact@xeed-consulting.com', N'بغداد , العراق')
GO
INSERT [dbo].[Aspiration] ([Id], [Text], [Text_Ar], [Text1], [Text1_Ar], [Image]) VALUES (N'd3ae0be9-d829-4c96-b3bf-413d482513de', N'<p class="disc">
          At Xeed Consulting, we aspire to be more than just a consultancy firm; we aspire to be your strategic partner on the journey to success. Our aspirations are rooted in a vision of a thriving business world, where every organization has the tools, knowledge, and support to not just adapt to change, but to excel in it.           
                    </p>
                    <p class="disc">
                       <span style="font-size:20px; color: #104e7e;"> Empowering Your Success</span></br>
Our primary aspiration is simple yet profound: <span style="font-size:20px; color: #104e7e;"> to empower organizations to reach their full potential.</span>We believe that every business, regardless of its size or industry, has untapped potential waiting to be discovered. Our role is to unlock that potential and help you achieve remarkable results.
                        <br>
                    </p>', N'<p class="disc">
في “xceed Consulting”، نطمح لأن نكون أكثر من مجرد شركة استشارية؛ نحن نطمح لأن نكون شريكك الاستراتيجي في رحلتك نحو النجاح. تتجذر تطلعاتنا في رؤية عالم أعمال مزدهر، حيث تمتلك كل منظمة الأدوات والمعرفة والدعم ليس فقط للتكيف مع التغيير، ولكن للتفوق فيه.  
                    </p>
                    <p class="disc">
                       <span style="font-size:20px; color: #104e7e;">تمكين نجاحك</span></br>
في “xceed Consulting”، نطمح لأن نكون أكثر من مجرد شركة استشارية<span style="font-size:20px; color: #104e7e;">  نحن نطمح لأن نكون شريكك الاستراتيجي في رحلتك نحو النجاح</span>تتجذر تطلعاتنا في رؤية عالم أعمال مزدهر، حيث تمتلك كل منظمة الأدوات والمعرفة والدعم ليس فقط للتكيف مع التغيير، ولكن للتفوق فيه.
                        <br>
                    </p>', N'
At Xeed Consulting, our aspiration isn''t just about business; it''s about the journey we embark on with you. It''s about the transformative impact we can create together. We invite you to join us in realizing this aspiration by contacting us today. Your success is not just our aspiration; it''s our commitment. Together, we''ll turn aspirations into achievements.', N'
في “xceed Consulting”، تطلعاتنا ليست مجرد شأن عمل؛ إنها عن الرحلة التي نبدأها معك. إنها عن التأثير الذي يمكن أن نخلقه معًا. ندعوك للانضمام إلينا في تحقيق هذه التطلعات من خلال الاتصال بنا اليوم. نجاحك ليس مجرد تطلع لدينا؛ إنه التزامنا. معًا، سنحول التطلعات إلى إنجازات.
', N'4ef39c9d-0b4f-45a1-a43e-00a3e6256274_aspiration.jpg')
GO
SET IDENTITY_INSERT [dbo].[AspNetRoleClaims] ON 

INSERT [dbo].[AspNetRoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue]) VALUES (1, N'bb07e6f6-00ac-4285-b140-596990f21fac', N'CanEdit', N'CanEdit')
SET IDENTITY_INSERT [dbo].[AspNetRoleClaims] OFF
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'bb07e6f6-00ac-4285-b140-596990f21fac', N'Admin', N'ADMIN', N'8994c500-57d0-49ce-aad1-50cb30898f52')
GO
SET IDENTITY_INSERT [dbo].[AspNetUserClaims] ON 

INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (1, N'16e49460-b088-46be-a83c-4a1f6bf4571d', N'CanEdit', N'CanEdit')
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (2, N'66611fb2-609f-4c92-80cb-640de4b2f724', N'CanEdit', N'CanEdit')
SET IDENTITY_INSERT [dbo].[AspNetUserClaims] OFF
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'66611fb2-609f-4c92-80cb-640de4b2f724', N'bb07e6f6-00ac-4285-b140-596990f21fac')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'16e49460-b088-46be-a83c-4a1f6bf4571d', N'jihadsamad', N'JIHADSAMAD', N'jihad@login.com', N'JIHAD@LOGIN.COM', 0, N'AQAAAAEAACcQAAAAEIosL6zZpfYuQT/PwSw0wFP7N6nRT280gC5/Qd5lw/9v1k7bs4vjH5v+vlRNmyYWLw==', N'XYLDVXEFNNO757APJ32PZJSTVZNZNMBI', N'c3d62350-33ef-44b2-aa2c-9428503a83b0', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'66611fb2-609f-4c92-80cb-640de4b2f724', N'xeed', N'XEED', N'ahmadghadder@gmail.com', N'AHMADGHADDER@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEGigqlXmANKZwMohTsjw0doWVdqZYg+OJKHv7uaQA9BWoC8PxWbq2UvpsE8DGY7p6g==', N'R5PXKNXPF5G3YB2JMBYNNVEMTRO7LFWU', N'04703ac8-9532-4756-891a-7c4ee397d14c', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[Capabilities] ([Id], [Image], [text], [text_Ar], [Description], [Description_Ar], [Order]) VALUES (N'e9c74264-25ef-4761-d506-08dbbb79f568', N'9c81acbb-91ae-4c83-9785-56aaae7a67f2_Organizational-Purpose-1.jpg', N'Business and Organizational Purpose', N'الغرض من الأعمال والمؤسسات', N'At Xeed Consulting, we believe that every business should have a clear and compelling purpose. We work closely with our clients to define their business and organizational purpose, helping them align their values and objectives to create a meaningful and impactful mission statement. Our consultancy services empower businesses to articulate their purpose and integrate it into their daily operations, fostering a sense of direction and inspiration for employees and stakeholders alike', N'في “xceed Consulting”، نعتقد أن كل شركة يجب أن تمتلك هدفًا واضحًا وجاذبًا. نعمل عن كثب مع عملائنا لتحديد هدف أعمالهم ومؤسساتهم، مساعدينهم في مواءمة قيمهم وأهدافهم لإنشاء بيان مهمة ذو معنى وأثر. خدمات الاستشارة لدينا تمكن الشركات من صياغة هدفها ودمجه في عملياتها اليومية، ما يشجع على شعور بالاتجاه والإلهام لدى الموظفين وأصحاب المصلحة على حد سواء.', 1)
INSERT [dbo].[Capabilities] ([Id], [Image], [text], [text_Ar], [Description], [Description_Ar], [Order]) VALUES (N'75508b5e-393a-4e6d-d507-08dbbb79f568', N'ee9ad2b7-008a-459e-b526-6e02c0fcc59f_Strategy-.jpg', N'Corporate Finance and Strategy ', N'التمويل والاستراتيجية الشركية ', N'Our team of financial experts specializes in crafting comprehensive corporate finance and strategy solutions. We assist businesses in optimizing their financial performance, capital allocation, and risk management. Whether you''re looking to expand, streamline operations, or navigate complex financial challenges, we provide strategic guidance to help you achieve your long-term financial goals.', N'يتخصص فريقنا من الخبراء الماليين في صياغة حلول شاملة للتمويل الشركي واستراتيجية الشركات. نساعد الشركات في تحسين أدائها المالي وتوجيه رأس المال وإدارة المخاطر. سواء كنتم تبحثون عن التوسع، أو تبسيط العمليات، أو التنقل في تحديات مالية معقدة، نقدم إرشادًا استراتيجيًا لمساعدتكم في تحقيق أهدافكم المالية على المدى الطويل', 2)
INSERT [dbo].[Capabilities] ([Id], [Image], [text], [text_Ar], [Description], [Description_Ar], [Order]) VALUES (N'47fabe31-00a7-4932-ab3a-08dbbd968855', N'b986698c-19af-47ef-be85-7a1edc7f6e87_Technology.jpg', N'Digital, Technology and Data', N'التكنولوجيا الرقمية والبيانات', N'In today''s digital age, staying competitive requires leveraging cutting-edge technology and harnessing the power of data. We help businesses adapt and thrive in the digital landscape by providing expert guidance on digital transformation, technology adoption, and data-driven decision-making. Our tailored solutions enable organizations to maximize efficiency and stay ahead of the curve.', N'في عصر اليوم الرقمي، التنافسية يتطلب استغلال التكنولوجيا الحديثة واستغلال قوة البيانات. نحن نساعد الشركات في التكيف والازدهار في المناظر الرقمية من خلال تقديم إرشادات خبراء حول التحول الرقمي واعتماد التكنولوجيا واتخاذ القرارات استنادًا إلى البيانات. حلولنا المخصصة تمكّن المؤسسات من تحقيق أقصى كفاءة والبقاء في مقدمة التطور.', 3)
INSERT [dbo].[Capabilities] ([Id], [Image], [text], [text_Ar], [Description], [Description_Ar], [Order]) VALUES (N'fb61f820-7c92-4c39-ab3b-08dbbd968855', N'55bdd92e-9192-4a69-8d69-379b81b141c3_AI.jpg', N'Artificial Intelligence', N'الذكاء الاصطناعي', N'Discover the potential of AI with our consultancy services. We assist businesses in harnessing the power of artificial intelligence to optimize processes, automate tasks, and gain deeper insights from data. Our AI solutions are designed to enhance productivity, reduce costs, and drive innovation across various industries.', N'اكتشفوا إمكانيات الذكاء الاصطناعي مع خدمات الاستشارة لدينا. نساعد الشركات في استغلال قوة الذكاء الاصطناعي لتحسين العمليات وتلقين المهام واكتساب رؤى أعمق من البيانات. تم تصميم حلولنا لزيادة الإنتاجية وتقليل التكاليف ودفع الابتكار في مجموعة متنوعة من الصناعات.', 4)
INSERT [dbo].[Capabilities] ([Id], [Image], [text], [text_Ar], [Description], [Description_Ar], [Order]) VALUES (N'447e3afb-a3dd-4d1d-ab3c-08dbbd968855', N'776c5a03-f2fb-4660-83a3-aff73afc9ddf_Monitoring-Evaluation .jpg', N'Monitoring and Evaluation', N'مراقبة وتقييم', N'Effective monitoring and evaluation are crucial for measuring the impact of your initiatives. We offer customized monitoring and evaluation frameworks to track progress, assess performance, and make data-driven adjustments. Our approach ensures that your organization remains agile and responsive to changing circumstances.', N'المراقبة والتقييم الفعّالين ضروريان لقياس تأثير مبادراتكم. نقدم أطُر مراقبة وتقييم مخصصة لتتبع التقدم وتقييم الأداء واتخاذ التعديلات استنادًا إلى البيانات. نهجنا يضمن أن منظمتكم تبقى ذكية ومستجيبة للتغيرات.', 5)
INSERT [dbo].[Capabilities] ([Id], [Image], [text], [text_Ar], [Description], [Description_Ar], [Order]) VALUES (N'3a77ff6f-6591-4a29-ab3d-08dbbd968855', N'054b5010-f24a-4c5d-8663-9813a2210c0d_Manufacturing-.jpg', N'Manufacturing', N'التصنيع', N'Achieve operational excellence in manufacturing with our consultancy services. We help businesses streamline their manufacturing processes, enhance quality control, and reduce waste. Our expertise ensures that your manufacturing operations are efficient, cost-effective, and capable of meeting the highest industry standards.', N'حققوا التميز التشغيلي في مجال التصنيع مع خدمات الاستشارة لدينا. نساعد الشركات في تبسيط عمليات التصنيع وتحسين مراقبة الجودة وتقليل الفاقد. خبرتنا تضمن أن عمليات التصنيع لديكم فعّالة وكفؤة من الناحية التكلفة وقادرة على تلبية أعلى معايير الصناعة.', 6)
INSERT [dbo].[Capabilities] ([Id], [Image], [text], [text_Ar], [Description], [Description_Ar], [Order]) VALUES (N'4bfdac00-c98b-4cca-ab3e-08dbbd968855', N'f1c1e42a-e283-4392-9d85-d9787c206e8c_Marketing.jpg', N'Growth, Marketing and Sales', N'النمو والتسويق والمبيعات', N'Unlock your business''s growth potential with our strategic marketing and sales solutions. We work closely with clients to identify market opportunities, develop marketing strategies, and optimize sales processes. Our proven methods drive revenue growth and help businesses thrive in competitive markets.', N'اطلقوا سراح إمكانيات نمو أعمالكم مع حلول التسويق والمبيعات الاستراتيجية لدينا. نعمل عن كثب مع العملاء لتحديد فرص السوق وتطوير استراتيجيات التسويق وتحسين عمليات البيع. طرقنا المجربة تدفع بنمو الإيرادات وتساعد الشركات على الازدهار في الأسواق التنافسية.', 7)
INSERT [dbo].[Capabilities] ([Id], [Image], [text], [text_Ar], [Description], [Description_Ar], [Order]) VALUES (N'b1cd92bd-909b-4899-f025-08dbbd98f85d', N'84ced0cb-2444-4194-a3fc-5feacfa80612_Operations.jpg', N'Operations', N'العمليات', N'Efficient operations are the backbone of a successful business. We specialize in optimizing operational processes, enhancing supply chain management, and reducing operational costs. Our consultancy services are designed to ensure that your operations run smoothly and deliver consistent value.', N'العمليات الفعّالة هي العمود الفقري لنجاح الأعمال. نحن متخصصون في تحسين العمليات التشغيلية وتعزيز إدارة سلسلة التوريد وتقليل تكاليف التشغيل. خدمات الاستشارة لدينا مصممة لضمان أن عملياتكم تسير بسلاسة وتقدم قيمة مستدامة.', 8)
INSERT [dbo].[Capabilities] ([Id], [Image], [text], [text_Ar], [Description], [Description_Ar], [Order]) VALUES (N'2da2e5d9-ae35-4845-f026-08dbbd98f85d', N'dd9bb229-8f34-4b69-bb21-17c6778f628b_Implementation.jpg', N'Implementation', N'التنفيذ', N'Implementing strategic plans effectively is critical for achieving desired outcomes. We provide hands-on support in implementing business strategies, technology solutions, and process improvements. Our experienced consultants guide you through each step, from planning to execution, to ensure successful implementation.', N'تنفيذ الخطط الاستراتيجية بفعالية أمر حاسم لتحقيق النتائج المرغوبة. نحن نقدم دعمًا عمليًا في تنفيذ استراتيجيات الأعمال وحلول التكنولوجيا وتحسين العمليات. مستشارونا ذوي الخبرة يرشدونكم خلال كل خطوة، من التخطيط إلى التنفيذ، لضمان تنفيذ ناجح.', 9)
INSERT [dbo].[Capabilities] ([Id], [Image], [text], [text_Ar], [Description], [Description_Ar], [Order]) VALUES (N'2272c392-9eb5-417a-f027-08dbbd98f85d', N'2567148b-4808-4559-b5e5-0f0d9db89c27_Organization-Strategy.jpg', N'Organization Strategy', N'استراتيجية المؤسسة', N'Craft a winning organization strategy with our consultancy services. We help businesses define their organizational structure, roles, and responsibilities to align with their strategic goals. Our solutions promote agility and enable organizations to adapt to changing market dynamics.', N'صاغوا استراتيجية المؤسسة الفائزة مع خدمات الاستشارة لدينا. نحن نساعد الشركات في تحديد هيكلها التنظيمي والأدوار والمسؤوليات للمواءمة مع أهدافها الاستراتيجية. حلولنا تعزز من القدرة على التكيف وتتيح للمنظمات التكيف مع تغيرات ديناميات السوق.', 10)
INSERT [dbo].[Capabilities] ([Id], [Image], [text], [text_Ar], [Description], [Description_Ar], [Order]) VALUES (N'35d7f135-6dfe-4c08-f028-08dbbd98f85d', N'04712586-5c77-4abe-9dde-29d86a32088c_People-Strategy.jpg', N'People Strategy', N'استراتيجية الموارد البشرية', N'Your people are your most valuable asset. We assist businesses in developing comprehensive people strategies, including talent acquisition, development, and retention. Our approach ensures that your workforce is aligned with your business objectives, fostering a culture of engagement and growth.', N'فريقكم هو أثمن ما تمتلكونه. نساعد الشركات في تطوير استراتيجيات شاملة للموارد البشرية، بما في ذلك اكتساب المواهب وتطويرها والاحتفاظ بها. نهجنا يضمن أن قوت العمل لديكم متوافقة مع أهداف أعمالكم، مما يشجع على ثقافة الارتباط والنمو.', 11)
INSERT [dbo].[Capabilities] ([Id], [Image], [text], [text_Ar], [Description], [Description_Ar], [Order]) VALUES (N'b3afe408-36cc-4ec9-f029-08dbbd98f85d', N'db339eaf-ceee-4eb0-a73c-159c75f56bd6_Pricing.jpg', N'Pricing and Revenue Management', N'تسعير وإدارة الإيرادات', N'Maximize your profitability with our pricing and revenue management expertise. We help businesses optimize pricing strategies, revenue models, and demand forecasting. Our solutions enable you to capture market value and enhance your bottom line.', N'زيّنوا ربحيتكم مع خبرتنا في تسعير وإدارة الإيرادات. نساعد الشركات في تحسين استراتيجيات التسعير، ونماذج الإيرادات، وتوقعات الطلب. حلولنا تمكنكم من الاستفادة من قيمة السوق وتعزيز الأرباح الصافية الخاصة بكم.', 12)
INSERT [dbo].[Capabilities] ([Id], [Image], [text], [text_Ar], [Description], [Description_Ar], [Order]) VALUES (N'76a0fcc2-7c46-44df-f02a-08dbbd98f85d', N'ca698fdf-4976-4b7c-91a2-44be83679426_Zero-Based.jpg', N'Zero-Based Budgeting', N'الميزانية من الصفر', N'Achieve cost efficiency and financial transparency through zero-based budgeting. We guide businesses in implementing this innovative budgeting approach, helping them reallocate resources to areas that generate the most value and eliminate unnecessary costs.', N'حققوا كفاءة التكلفة والشفافية المالية من خلال الميزانية من الصفر. نرشد الشركات في تنفيذ هذا النهج المبتكر للميزانية، مساعدينهم في إعادة تخصيص الموارد إلى المجالات التي تولد أكبر قيمة والتخلص من التكاليف غير الضرورية.', 13)
INSERT [dbo].[Capabilities] ([Id], [Image], [text], [text_Ar], [Description], [Description_Ar], [Order]) VALUES (N'3968d36e-a029-427e-f02b-08dbbd98f85d', N'554d8514-c1c9-4f76-bd80-6583da15cc91_Risk-Management.JPG', N'Risk Management and Compliance', N'إدارة المخاطر والامتثال', N'Mitigating risks and ensuring compliance are paramount in today''s business environment. Our consultancy services provide a holistic approach to risk management and compliance, safeguarding your business against potential threats and regulatory challenges.', N'تقليل المخاطر وضمان الامتثال أمور حيوية في بيئة الأعمال الحالية. تقدم خدمات الاستشارة لدينا نهجاً شاملاً لإدارة المخاطر والامتثال، حماية أعمالكم من التهديدات المحتملة والتحديات التنظيمية.', 14)
INSERT [dbo].[Capabilities] ([Id], [Image], [text], [text_Ar], [Description], [Description_Ar], [Order]) VALUES (N'd58029de-0905-4753-f02c-08dbbd98f85d', N'd96e434b-3745-4b9c-918d-4b607f127815_Innovation-Strategy-.jpg', N'Innovation Strategy and Delivery', N'استراتيجية وتنفيذ الابتكار', N'Innovation drives sustainable growth. We assist businesses in developing innovation strategies and delivering on their innovative initiatives. Our solutions foster a culture of creativity and entrepreneurship, ensuring that your organization remains at the forefront of innovation in your industry.', N'الابتكار يدفع النمو المستدام. نساعد الشركات في وضع استراتيجيات الابتكار وتنفيذ مبادراتها الابتكارية. حلولنا تعزز من ثقافة الإبداع وريادة الأعمال، مما يضمن أن منظمتكم تظل في مقدمة الابتكار في صناعتكم.', 15)
GO
INSERT [dbo].[Commitment] ([Id], [Description], [Description_Ar]) VALUES (N'830fba9b-bde8-42dd-a02c-6906d342fa6e', N'At Xeed Consulting, our commitment to our clients is the cornerstone of our consultancy practice. We understand that entrusting us with your business challenges and aspirations is a significant decision, and we take this responsibility seriously. Our unwavering commitment to you is what sets us apart.', N'في “xceed Consulting”، التزامنا تجاه عملائنا هو ركيزة ممارسات استشارتنا. نحن ندرك أن الثقة بنا بتحدثكم تحديات وآمال أعمالكم هي قرار هام، ونحن نأخذ هذه المسؤولية على محمل الجد. التزامنا الثابت بكم هو ما يميزنا.')
GO
INSERT [dbo].[Footer] ([FooterId], [Description], [Description_Ar]) VALUES (N'5dc14325-3ca1-4f03-ba1f-4a0be848bf1f', N'We are a leading business and technology consultancy dedicated to helping businesses thrive in today''s dynamic and digital landscape.', N'نحن شركة استشارية رائدة في مجال الأعمال والتكنولوجيا مكرسة لمساعدة الشركات على الازدهار في المشهد الديناميكي والرقمي اليوم.')
GO
INSERT [dbo].[HowWork] ([Id], [Description], [Description_Ar]) VALUES (N'e75eeb0a-d7cc-4a59-94ec-000bbb67f004', N'At Xeed Consulting, our approach to consultancy is rooted in collaboration, transparency, and delivering measurable results. We understand that each organization is unique, and we tailor our methodology to suit your specific needs. Here''s a closer look at how we work:', N'في “xceed Consulting”، يرتكز نهجنا للاستشارة على التعاون والشفافية وتحقيق نتائج قابلة للقياس. نحن ندرك أن كل منظمة فريدة، ونقوم بتصميم منهجيتنا لتناسب احتياجاتكم الخاصة. إليك نظرة أقرب على كيفية عملنا:')
GO
INSERT [dbo].[Industries] ([Id], [Image], [text], [text_Ar], [Order]) VALUES (N'1ecc10d1-cc84-400d-1faa-08dbbb779006', N'43d39bb4-90ac-4e80-9f0c-7830ec19d205_04.jpg', N' Health Care Industry                                           ', N'الرعاية الصحية', 1)
INSERT [dbo].[Industries] ([Id], [Image], [text], [text_Ar], [Order]) VALUES (N'793f2b58-4a1c-461a-1fab-08dbbb779006', N'b7422ce4-dc07-4742-b41a-129a93dc212d_09.jpg', N'Financial Services', N'الخدمات المالية', 2)
INSERT [dbo].[Industries] ([Id], [Image], [text], [text_Ar], [Order]) VALUES (N'c0317409-2c97-4438-1fac-08dbbb779006', N'4a2859d7-4489-4592-9e6c-05ce2e219440_07.jpg', N'Engineering, Construction and Building', N' الهندسة والبناء ', 3)
INSERT [dbo].[Industries] ([Id], [Image], [text], [text_Ar], [Order]) VALUES (N'2a1b1190-8e58-464c-1fad-08dbbb779006', N'7a7b68f8-c467-4884-a3c6-ccb82ae172fb_Travel.jpg', N'  Travel, Transportation and Tourism', N' الهندسة والبناء', 4)
INSERT [dbo].[Industries] ([Id], [Image], [text], [text_Ar], [Order]) VALUES (N'cfcf7615-0539-4674-1fae-08dbbb779006', N'55499077-cf7a-49de-95ba-28b933e37845_Media.jpg', N'Technology and Media ', N'التكنولوجيا والإعلام والاتصالات                                            ', 5)
INSERT [dbo].[Industries] ([Id], [Image], [text], [text_Ar], [Order]) VALUES (N'e06ec9a8-b324-4867-1faf-08dbbb779006', N'9b85ff3b-f2ab-40a3-b8f2-7b298a533f8e_Real-Estate.jpg', N'Real Estate  ', N' العقارات', 6)
INSERT [dbo].[Industries] ([Id], [Image], [text], [text_Ar], [Order]) VALUES (N'43d6a10e-0a7d-4680-1fb0-08dbbb779006', N'5125f367-90b6-4ce7-9fb0-eee874f70012_Insurance.jpg', N'                                             Insurance Industry                                             ', N'                                             التأمين                                             ', 7)
INSERT [dbo].[Industries] ([Id], [Image], [text], [text_Ar], [Order]) VALUES (N'9c744150-4923-40dd-1fb1-08dbbb779006', N'2b101dbf-3cc6-41c3-bfc4-5e1eaf515adc_05.jpg', N'                                           Industrial Goods                                              ', N'                                           السلع الصناعية                                              ', 8)
GO
INSERT [dbo].[Leadership] ([LeadershipId], [Description], [Description_Ar], [Image]) VALUES (N'9792c5c6-2fae-460e-802f-763b60a6e894', N' At Xeed Consulting, our success story is written by the dynamic individuals who lead, the unwavering purpose that drives us, and the core values that guide our every action.<br />Our leadership team comprises seasoned professionals with a track record of excellence in various industries. Their extensive experience and deep insights into business intricacies make them the driving force behind our consultancy. They lead by example, infusing the organization with a culture of innovation, collaboration, and client-centricity.
                            <br />Our leaders are not just experts; they are your partners in achieving success. Their commitment to transformation and dedication to your growth are the cornerstones of our consultancy.', N'في “xceed Consulting”، تُكتب قصة نجاحنا بواسطة الأفراد الديناميين الذين يقودون، والهدف الثابت الذي يدفعنا، والقيم الأساسية التي توجه كل تصرف لدينا.<br />القيادة فريق القيادة لدينا يتألف من محترفين ذوي خبرة واسعة لديهم سجل حافل من التميز في مختلف الصناعات. خبرتهم الواسعة ورؤاهم العميقة في تفاصيل الأعمال تجعلهم القوة الدافعة وراء استشاراتنا. إنهم يقدمون القدوة، ويعززون المنظمة بثقافة الابتكار والتعاون والتوجه نحو العميل.
                            <br />قادتنا ليسوا مجرد خبراء؛ بل هم شركاءك في تحقيق النجاح. التفاني لديهم في التحول والتفرغ لنموك هما أركان استشاراتنا.', N'3a172031-af6a-4161-a081-c776e41590d2_Leadership.jpg')
GO
INSERT [dbo].[Purpose] ([Id], [Text], [Text_Ar], [Image]) VALUES (N'5a912921-ebe8-4f94-b92a-eb0649bb6262', N'   <h2 class="title feature-title">Purpose</h2>
                    <p>At Xeed Consulting, our purpose is clear and unwavering: to empower organizations to thrive in an ever-evolving business landscape. We understand that today''s business environment is dynamic, challenging, and highly competitive. Our purpose is to be the guiding light, helping businesses not just survive but excel in this landscape.</p>
                    <p class="disc">
                    <span style="font-size:20px; color: #104e7e;">Value</span>
                    <br />
                Our values are the compass that directs our actions and decisions. They reflect our commitment to ethical business practices, transparency, and a client-centric approach. Our core values define who we are and how we operate:
                    </p>', N'   <h2 class="title feature-title">قيمتنا</h2>
                    <p>الهدف في “xceed Consulting”، هدفنا واضح وثابت: تمكين المؤسسات للازدهار في مناظر الأعمال المتطورة باستمرار. نحن نفهم أن بيئة الأعمال اليومية دينامية وتحدية ومنافسة بشدة. هدفنا هو أن نكون الضوء القائم، مساعدين الشركات ليس فقط على البقاء ولكن على التفوق في هذه المناظر. القيم قيمنا هي البوصلة التي توجه أفعالنا وقراراتنا. إنها تعكس التزامنا بممارسات الأعمال الأخلاقية والشفافية والتوجه نحو العميل. تحدد قيمنا الأساسية من نحن وكيف نتعامل:</p>
                    <p class="disc">
                    <span style="font-size:20px; color: #104e7e;">قيمتنا</span>
                    <br />
      الهدف في “xceed Consulting”، هدفنا واضح وثابت: تمكين المؤسسات للازدهار في مناظر الأعمال المتطورة باستمرار. نحن نفهم أن بيئة الأعمال اليومية دينامية وتحدية ومنافسة بشدة. هدفنا هو أن نكون الضوء القائم، مساعدين الشركات ليس فقط على البقاء ولكن على التفوق في هذه المناظر. القيم قيمنا هي البوصلة التي توجه أفعالنا وقراراتنا. إنها تعكس التزامنا بممارسات الأعمال الأخلاقية والشفافية والتوجه نحو العميل. تحدد قيمنا الأساسية من نحن وكيف نتعامل
                    </p>', N'bd1f5fab-49aa-4b35-bfa1-1fbb6a148a05_purpose.jpg')
GO
INSERT [dbo].[Sliders] ([Id], [Title_EN], [Title_AR], [Order], [Image]) VALUES (N'5f6de064-2837-49b6-e9d1-08dbbb770045', N'Business and Organizational Purpose', N' التكنولوجيا الرقمية والبيانات ', 2, N'd9568d85-0798-4cc0-ab9b-8e3a11507e90_banner-06.jpg')
INSERT [dbo].[Sliders] ([Id], [Title_EN], [Title_AR], [Order], [Image]) VALUES (N'c8cf8956-2187-47f7-e9d2-08dbbb770045', N'Business and Organizational Purpose', N'الغرض من الأعمال والمؤسسات', 3, N'9eb36ef1-735d-4261-bd5a-c1e7513230c3_banner-05.jpg')
INSERT [dbo].[Sliders] ([Id], [Title_EN], [Title_AR], [Order], [Image]) VALUES (N'64989d7f-4d70-41fb-6e60-08dbded68926', N' Pricing and Revenue Management  ', N' تسعير وإدارة الإيرادات  ', 3, N'429a4f15-2be1-4946-b79f-a4ec9fbdde4e_banner-07.jpg')
GO
INSERT [dbo].[Team] ([TeamId], [Description], [Description_Ar], [Image1], [Image2]) VALUES (N'ed2108a7-a78c-40d0-89cd-1dacb045eb72', N'At Xeed Consulting, our team is the driving force behind our success. We take pride in our diverse and talented group of professionals who are committed to helping your organization thrive. Get to know the individuals who will be by your side on the journey to success: Our team''s strength lies in their diversity, expertise, and shared commitment to your success. We are more than just consultants; we are your dedicated partners in achieving your business objectives. When you choose Xeed Consulting, you''re not just getting a consultancy firm; you''re gaining a team of passionate individuals who are deeply invested in your growth. Contact Us today to meet our team and learn how we can work together to transform your business. Your success is our team''s mission!', N'في xceed Consulting”، فريقنا هو القوة الدافعة وراء نجاحنا. نحن نفتخر بفريقنا المتنوع والموهوب الذين ملتزمون بمساعدة منظمتكم على الازدهار. تعرفوا على الأفراد الذين سيكونون إلى جانبكم في رحلة النجاح: قوة فريقنا تكمن في تنوعهم وخبرتهم والالتزام المشترك بنجاحكم. نحن أكثر من مجرد مستشارين؛ نحن شركاءكم المخصصين في تحقيق أهداف أعمالكم. عندما تختارون “Exceed Consultancy”، فإنكم لا تحصلون فقط على شركة استشارية؛ بل تحصلون على فريق من الأفراد المشتاقين الذين مستثمرون بعمق في نموكم. اتصلوا بنا اليوم لمقابلة فريقنا ومعرفة كيف يمكننا العمل معًا لتحويل أعمالكم. نجاحكم هو مهمة فريقنا!', N'cba82b74-0b96-41a2-8392-53a7f1325b6e_team.jpg', N'e8076210-3490-4f46-ab74-8482b30675a4_team1.jpg')
GO
INSERT [dbo].[WhyUs] ([Id], [Title], [Title_Ar], [Description], [Description_Ar], [Image]) VALUES (N'76de605a-ebdb-441d-51b0-08dbdb7ee315', N'WE UNDERSTAND THAT EACH<span class="sm-title"> business <span>is unique</span></span>', N'نحن نعلم أن كل <span class="sm-title"> شركة<span>لديها عوامل و ظروف خاصة</span></span>', N'We understand that each business is unique, and there is no one-size-fits-all solution. Our tailored approach ensures that we delve deep into your organization''s specific needs, challenges, and goals to craft strategies that yield meaningful outcomes.', N'نحن نفهم أن كل شركة لديها مجال فريد من نوعه، كما تمر بظروف و عوامل خاصة فكل عمل لديه خاصية معينة ولا يوجد حل واحد يناسب الجميع. يتضمن اسلوبنا أن نتعمق في الاحتياجات والتحديات والأهداف المحددة لمؤسستك لصياغة حلول مخصصة لك و تنسجم مع العوامل الخاصة بك.', N'c5dbc3f0-1ca0-4038-ac8a-efdcdb07a37b_Faq.png')
GO
INSERT [dbo].[WhyUsAccordion] ([Id], [AccordionId], [TitleAccordion], [TitleAccordion_Ar], [SubTitleAccordion], [SubTitleAccordion_Ar], [Order]) VALUES (N'5769b4ef-ccfd-4739-bbbc-08dbdea4196f', 1, N'   Expert Team                                                                 ', N'   فريق الخبراء    ', N'Our consultancy boasts a team of highly skilled professionals, each bringing a wealth of experience and expertise to the table. From business analysts to technology architects, project managers, and industry specialists, our diverse talent pool ensures that we can address a wide spectrum of challenges across various sectors.', N'
                                                            تتميز استشارتنا بفريق من المهنيين ذوي المهارات العالية، كل منهم يجلب ثروة من الخبرة والمعرفة إلى المشروع. من محللي الأعمال إلى مهندسي التكنولوجيا ومديري المشاريع والمتخصصين في مجالات الاعمال و الخدمات الطبية، يضمن تجمع المواهب المتنوع لدينا أنه يمكننا معالجة مجموعة واسعة من التحديات عبر مختلف القطاعات باسلوب مميز و متكامل.', 1)
INSERT [dbo].[WhyUsAccordion] ([Id], [AccordionId], [TitleAccordion], [TitleAccordion_Ar], [SubTitleAccordion], [SubTitleAccordion_Ar], [Order]) VALUES (N'1f44b6de-8a62-4e41-bbbd-08dbdea4196f', 2, N' Client-Centric Focus                                                              ', N' التركيز على العميل                                                              ', N'We prioritize our clients'' success above all else. Our collaborative approach involves working closely with your team, understanding your vision, and aligning our strategies with your business objectives. Your success is our success, and we take pride in being a reliable partner throughout your growth journey.', N'نحن نعطي الأولوية لنجاح عملائنا قبل كل شيء. يعتمد اسلوبنا على العمل عن كثب مع فريقك، وفهم رؤيتك، و انسجام استراتيجياتنا مع أهداف عملك. نجاحك هو نجاحنا، ونحن نفخر بكوننا شريكا موثوقا به طوال رحلة النمو و التطور الخاصة بك.', 2)
INSERT [dbo].[WhyUsAccordion] ([Id], [AccordionId], [TitleAccordion], [TitleAccordion_Ar], [SubTitleAccordion], [SubTitleAccordion_Ar], [Order]) VALUES (N'84fb9f0b-6d19-439c-bbbe-08dbdea4196f', 3, N' Innovative Solutions                                                              ', N' حلول مبتكرة                                                              ', N'In today''s fast-paced world, staying ahead of the curve is crucial. We constantly stay updated with the latest industry trends and emerging technologies to offer innovative solutions that give you a competitive edge. Whether it''s harnessing the power of data analytics or integrating AI, our solutions are future-proof and designed to drive sustainable growth.', N'في عالم سريع الخطى، يعد البقاء في الطليعة أمرا صعباً و بالغ الأهمية. نبقى على اطلاع دائم بأحدث اتجاهات الصناعة والتقنيات الناشئة لتقديم حلول مبتكرة تمنحك ميزة تنافسية. سواء كان ذلك من خلال تسخير قوة تحليلات البيانات أو دمج الذكاء الاصطناعي، فإن حلولنا واقية من المستقبل ومصممة لدفع شركتك باتجاه النمو المستدام.', 3)
INSERT [dbo].[WhyUsAccordion] ([Id], [AccordionId], [TitleAccordion], [TitleAccordion_Ar], [SubTitleAccordion], [SubTitleAccordion_Ar], [Order]) VALUES (N'1515d442-da33-4e86-bbbf-08dbdea4196f', 4, N' Ethical Practices                                                             ', N' الممارسات الأخلاقية                                                             ', N'Integrity and ethical practices are at the heart of everything we do. We uphold the highest standards of professionalism, ensuring transparency, confidentiality, and compliance in all our interactions and engagements.', N'
النزاهة والممارسات الأخلاقية هي في صميم كل ما نقوم به. نحن نتمسك بأعلى معايير الاحتراف، ضمان الشفافية و السرية في جميع تفاعلاتنا وارتباطاتنا.', 4)
GO
INSERT [dbo].[WhyUsHome] ([Id], [Title], [Title_Ar], [Description], [Description_Ar], [Image1], [Image2], [Image4]) VALUES (N'7cdd033b-a590-4be4-b024-a34d28af8f7d', N'We focus to get excellent performance', N'نحن نركز على الحصول على أداء مميز', N'We understand that each business is unique, and there is no one-size-fits-all solution. Our tailored approach ensures that we delve deep into your organization''s specific needs, challenges, and goals to craft strategies that yield meaningful outcomes.', N'نحن نتفهم أن كل عمل فريد من نوعه، ولا يوجد حل واحد يناسب الجميع. تتضمن خطتنا أن نتعمق في الاحتياجات والتحديات والأهداف المحددة لمؤسستك لصياغة استراتيجيات تحقق نتائج ذات مغزى مما يتناسب مع الاحتياجات و الخصائص المحددة للشركة.', N'27803027-b51b-443b-8e6d-e676d8e1b494_03.jpg', N'55423767-27b8-4d49-a83f-365456b3b64e_02.jpg', N'df9a9001-241a-4bd4-931d-d76db5f6fd42_01.jpg')
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 3/26/2024 9:53:20 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 3/26/2024 9:53:20 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 3/26/2024 9:53:20 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AspNetUserRoles_UserId]    Script Date: 3/26/2024 9:53:20 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_UserId] ON [dbo].[AspNetUserRoles]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 3/26/2024 9:53:20 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 3/26/2024 9:53:20 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[WhyUsAccordion] ADD  DEFAULT ((0)) FOR [Order]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
USE [master]
GO
ALTER DATABASE [AppsHyveDb_XeedConsulting] SET  READ_WRITE 
GO
