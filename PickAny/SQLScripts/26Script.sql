USE [master]
GO
/****** Object:  Database [PickAnyLive]    Script Date: 06/26/2018 00:35:42 ******/
CREATE DATABASE [PickAnyLive] ON  PRIMARY 
( NAME = N'PickAnyLive', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\PickAnyLive.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PickAnyLive_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\PickAnyLive_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PickAnyLive] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PickAnyLive].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PickAnyLive] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [PickAnyLive] SET ANSI_NULLS OFF
GO
ALTER DATABASE [PickAnyLive] SET ANSI_PADDING OFF
GO
ALTER DATABASE [PickAnyLive] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [PickAnyLive] SET ARITHABORT OFF
GO
ALTER DATABASE [PickAnyLive] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [PickAnyLive] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [PickAnyLive] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [PickAnyLive] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [PickAnyLive] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [PickAnyLive] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [PickAnyLive] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [PickAnyLive] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [PickAnyLive] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [PickAnyLive] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [PickAnyLive] SET  DISABLE_BROKER
GO
ALTER DATABASE [PickAnyLive] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [PickAnyLive] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [PickAnyLive] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [PickAnyLive] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [PickAnyLive] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [PickAnyLive] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [PickAnyLive] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [PickAnyLive] SET  READ_WRITE
GO
ALTER DATABASE [PickAnyLive] SET RECOVERY SIMPLE
GO
ALTER DATABASE [PickAnyLive] SET  MULTI_USER
GO
ALTER DATABASE [PickAnyLive] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [PickAnyLive] SET DB_CHAINING OFF
GO
USE [PickAnyLive]
GO
/****** Object:  Table [dbo].[webpages_Roles]    Script Date: 06/26/2018 00:35:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[webpages_Roles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](256) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[RoleName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[RoleName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[RoleName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[RoleName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[webpages_Roles] ON
INSERT [dbo].[webpages_Roles] ([RoleId], [RoleName]) VALUES (1, N'Administrator')
INSERT [dbo].[webpages_Roles] ([RoleId], [RoleName]) VALUES (2, N'User')
SET IDENTITY_INSERT [dbo].[webpages_Roles] OFF
/****** Object:  Table [dbo].[webpages_OAuthMembership]    Script Date: 06/26/2018 00:35:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[webpages_OAuthMembership](
	[Provider] [nvarchar](30) NOT NULL,
	[ProviderUserId] [nvarchar](100) NOT NULL,
	[UserId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Provider] ASC,
	[ProviderUserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[webpages_Membership]    Script Date: 06/26/2018 00:35:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[webpages_Membership](
	[UserId] [int] NOT NULL,
	[CreateDate] [datetime] NULL,
	[ConfirmationToken] [nvarchar](128) NULL,
	[IsConfirmed] [bit] NULL,
	[LastPasswordFailureDate] [datetime] NULL,
	[PasswordFailuresSinceLastSuccess] [int] NOT NULL,
	[Password] [nvarchar](128) NOT NULL,
	[PasswordChangedDate] [datetime] NULL,
	[PasswordSalt] [nvarchar](128) NOT NULL,
	[PasswordVerificationToken] [nvarchar](128) NULL,
	[PasswordVerificationTokenExpirationDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (1, CAST(0x0000A90500F1CFD7 AS DateTime), NULL, 1, CAST(0x0000A909009A7020 AS DateTime), 0, N'AJ6edcQnARKJ1TVyU4ZkJ49ze5wzXI0C7QksbMrDGc74au4BDKU7841Yc1U6APYfiA==', CAST(0x0000A90500F1CFD7 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (2, CAST(0x0000A90900B94FDD AS DateTime), NULL, 1, NULL, 0, N'AJCpshusmbU+gmtgBnrqcHcJYSMmVj8IefXMlN84+blmF9Hlz3qBzEWTUZRdO/Pv9A==', CAST(0x0000A90900B94FDD AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (3, CAST(0x0000A90900CB4EF3 AS DateTime), NULL, 1, CAST(0x0000A90900CE7C24 AS DateTime), 0, N'AJILNPLLhxfmoHkOiun91UB1V3FQHnlePJh1HclsSXTs+SDr/5cp4yvdoNLHz00+bw==', CAST(0x0000A90900CB4EF3 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (12, CAST(0x0000A90A01058AF6 AS DateTime), NULL, 1, NULL, 0, N'AKEXaj3M163t1+swre0q+DhBqmfVl73kqNPDTEm34CvD0RWBdnQnX5uBgo6app3ZAA==', CAST(0x0000A90A01058AF6 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (13, CAST(0x0000A90A01067B65 AS DateTime), NULL, 1, NULL, 0, N'AN5aa3s3huyRAa1Q9+UaTfBFB9ZkjQMTZ/DG5XPmxu8i2GFx1T2fy6YimX3uFGap/Q==', CAST(0x0000A90A01067B65 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (16, CAST(0x0000A90A0111E082 AS DateTime), NULL, 1, NULL, 0, N'AIwOWlvQk1L/OVn9JeK+v/qexJb97dZ2T6fF6w+n0UzX7j2/eK76+1I3f8QHLbD5cQ==', CAST(0x0000A90A0111E082 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (17, CAST(0x0000A90A0112338E AS DateTime), NULL, 1, NULL, 0, N'AF8G7sKxuvheX/1t6rwE+EtnhXz4EK9ubx1ibHI4GGhYYm9Af3/UIEJCH/MsmeoVpA==', CAST(0x0000A90A0112338E AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (19, CAST(0x0000A90A011E434C AS DateTime), NULL, 1, NULL, 0, N'AN3wHnBb9thaiKtmQXBZoe7daE0G+wZwOvcML8VNfJoD8bKU0zOYVdJJ8NUpxtLXxA==', CAST(0x0000A90A011E434C AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (20, CAST(0x0000A90A011EDC0F AS DateTime), NULL, 1, NULL, 0, N'AK6LUGisq9Hzp6EgVzkQjpjDuJ2L0n/S4IYaeyZXh3gLc8lWp62mm8wRF3xJgqX6JA==', CAST(0x0000A90A011EDC0F AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (21, CAST(0x0000A90A012026BF AS DateTime), NULL, 1, NULL, 0, N'AKuY51LWhA354uJhAawyxyiuTmqBgdTFR5F5FqL3PL/tmrFpFIvwUJfxUAuLl10nYA==', CAST(0x0000A90A012026BF AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (22, CAST(0x0000A90A0123ADD6 AS DateTime), NULL, 1, NULL, 0, N'ADGRXeiZBYQ0pJ7tGSACB58CCluhbPpyX5bgiQsS2UrTYO1/c+/+zrO7n4rCoUNi1Q==', CAST(0x0000A90A0123ADD6 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (23, CAST(0x0000A90A01288C74 AS DateTime), NULL, 1, NULL, 0, N'AClINP3BVv8sBPM6Mb4daX5LjAvAK4quTO8by+nQd1yrC6ZLoXYzbl/iPPbkS//+xQ==', CAST(0x0000A90A01288C74 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (24, CAST(0x0000A90A01299B62 AS DateTime), NULL, 1, NULL, 0, N'AL2s6ORuaNaMScC53K1qQyv+12Eqv4np46loi/va+8ISgiWWiJCUMH23oz1/S4Pmiw==', CAST(0x0000A90A01299B62 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (25, CAST(0x0000A90A012CEF13 AS DateTime), NULL, 1, NULL, 0, N'ANTuQLuOGjCOGRCBahiSXyCfaMVTN7feO85COhRhRixS/wBEhpHEl1pLiRJEyfp2AA==', CAST(0x0000A90A012CEF13 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (26, CAST(0x0000A90A012E18E6 AS DateTime), NULL, 1, NULL, 0, N'AIcGZ1wqwMQ6NwWiJ9Tc/aH1aoyvx86QdPm+vympHSSbA3h1aBFlND5CrqMVk/eDRA==', CAST(0x0000A90A012E18E6 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (27, CAST(0x0000A90A012F7FDE AS DateTime), NULL, 1, NULL, 0, N'APeCXDDGkWJSTWStSf2iujTC/lRQ7GtNGNTx9XWrlXTjyljFQzsvJ2VnwpIIMUFLVA==', CAST(0x0000A90A012F7FDE AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (28, CAST(0x0000A90A012FD81B AS DateTime), NULL, 1, NULL, 0, N'AAg6EaVFOt2hVrI3nQFITyD961ob5OXId4kLxkBe+Y8zRoryUkZ4ngrU2XlvkRUh0Q==', CAST(0x0000A90A012FD81B AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (29, CAST(0x0000A90A01306117 AS DateTime), NULL, 1, NULL, 0, N'AO5UP1mWZiXKs5n9vJbd2M5Wf8xvOoM1TRYBPjoZEaBzf7Fu4L1bryGFtL2vrFxx6w==', CAST(0x0000A90A01306117 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (30, CAST(0x0000A90A013147DA AS DateTime), NULL, 1, NULL, 0, N'AC8+/kIaDJZ8e+GDsDfxEy92J4Im7bO863Ahqgq08kNG0mcYuqorZPR1sUlcY92O1g==', CAST(0x0000A90A013147DA AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (31, CAST(0x0000A90A01341D9F AS DateTime), NULL, 1, NULL, 0, N'AEGAtSpOT842uLW5Yr5Iiwda0coRPB9BA/Y9Mgo2wbJDNCUzd4Sh3CezZgSRHHHqtw==', CAST(0x0000A90A01341D9F AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (32, CAST(0x0000A90A01349270 AS DateTime), NULL, 1, NULL, 0, N'AAVSlQFlrO+qMvMDWAtpmJNv0DXs+vX+OZ9iFu0UOELxJijdInu/CjB+CO1iL+NYZA==', CAST(0x0000A90A01349270 AS DateTime), N'', NULL, NULL)
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (33, CAST(0x0000A90A0134F8CD AS DateTime), NULL, 1, NULL, 0, N'ANoABpRAdzlscG+QfzLfvlMn8w4mPWPpAR4Xye2HsGZabXd/6twVzwKxoXzppkCrmg==', CAST(0x0000A90A0134F8CD AS DateTime), N'', NULL, NULL)
/****** Object:  Table [dbo].[UserProfile]    Script Date: 06/26/2018 00:35:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserProfile](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](200) NOT NULL,
	[Pass] [nvarchar](200) NULL,
	[FullName] [nvarchar](200) NULL,
	[Mobile] [nvarchar](12) NULL,
	[Address] [nvarchar](300) NULL,
	[City] [nvarchar](50) NULL,
	[PinCode] [nvarchar](6) NULL,
	[State] [nvarchar](50) NULL,
	[CreatedById] [int] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[IsDeactive] [bit] NOT NULL,
	[IndustryId] [int] NULL,
	[RoleId] [int] NULL,
	[Email] [varchar](50) NOT NULL,
	[EmailVerified] [bit] NOT NULL,
	[ActivationCode] [varchar](100) NULL,
 CONSTRAINT [PK__UserProf__1788CC4C65554372] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ__UserProf__C9F2845694DF48FA] UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[UserProfile] ON
INSERT [dbo].[UserProfile] ([UserId], [UserName], [Pass], [FullName], [Mobile], [Address], [City], [PinCode], [State], [CreatedById], [CreatedDate], [IsDeactive], [IndustryId], [RoleId], [Email], [EmailVerified], [ActivationCode]) VALUES (1, N'Administrator', NULL, N'Administrator', NULL, NULL, NULL, NULL, NULL, NULL, CAST(0x0000A905007E7489 AS DateTime), 0, NULL, NULL, N'admin@admin.com', 1, NULL)
INSERT [dbo].[UserProfile] ([UserId], [UserName], [Pass], [FullName], [Mobile], [Address], [City], [PinCode], [State], [CreatedById], [CreatedDate], [IsDeactive], [IndustryId], [RoleId], [Email], [EmailVerified], [ActivationCode]) VALUES (2, N'TEST', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(0x0000A9090113F2EB AS DateTime), 0, NULL, NULL, N'test@gmail.com', 1, NULL)
INSERT [dbo].[UserProfile] ([UserId], [UserName], [Pass], [FullName], [Mobile], [Address], [City], [PinCode], [State], [CreatedById], [CreatedDate], [IsDeactive], [IndustryId], [RoleId], [Email], [EmailVerified], [ActivationCode]) VALUES (3, N'MANOJ', N'123456', NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(0x0000A9090125F208 AS DateTime), 0, 1, 2, N'manoj@gmail.com', 1, NULL)
SET IDENTITY_INSERT [dbo].[UserProfile] OFF
/****** Object:  Table [dbo].[LineItems]    Script Date: 06/26/2018 00:35:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[LineItems](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Description] [varchar](max) NULL,
	[Rate] [float] NULL,
	[Quantity] [int] NOT NULL,
	[Tax] [float] NULL,
	[Total] [float] NOT NULL,
 CONSTRAINT [PK_LineItems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Industry]    Script Date: 06/26/2018 00:35:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Industry](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Industry] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Industry] ON
INSERT [dbo].[Industry] ([Id], [Name], [IsActive]) VALUES (1, N'IT', 0)
INSERT [dbo].[Industry] ([Id], [Name], [IsActive]) VALUES (2, N'MARKETING', 1)
SET IDENTITY_INSERT [dbo].[Industry] OFF
/****** Object:  Table [dbo].[Clients]    Script Date: 06/26/2018 00:35:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Email] [varchar](30) NOT NULL,
	[Mobile] [varchar](15) NOT NULL,
	[Phone] [varchar](20) NULL,
	[Address1] [varchar](100) NOT NULL,
	[Address2] [varchar](100) NULL,
	[City] [varchar](10) NOT NULL,
	[State] [varchar](10) NOT NULL,
	[ZipCode] [varchar](10) NULL,
	[Notes] [varchar](max) NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[webpages_UsersInRoles]    Script Date: 06/26/2018 00:35:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[webpages_UsersInRoles](
	[UserId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[webpages_UsersInRoles] ([UserId], [RoleId]) VALUES (1, 1)
/****** Object:  Default [DF__webpages___IsCon__07020F21]    Script Date: 06/26/2018 00:35:43 ******/
ALTER TABLE [dbo].[webpages_Membership] ADD  DEFAULT ((0)) FOR [IsConfirmed]
GO
/****** Object:  Default [DF__webpages___Passw__07F6335A]    Script Date: 06/26/2018 00:35:43 ******/
ALTER TABLE [dbo].[webpages_Membership] ADD  DEFAULT ((0)) FOR [PasswordFailuresSinceLastSuccess]
GO
/****** Object:  Default [DF_UserProfile_CreatedDate]    Script Date: 06/26/2018 00:35:43 ******/
ALTER TABLE [dbo].[UserProfile] ADD  CONSTRAINT [DF_UserProfile_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF_UserProfile_IsDeactive]    Script Date: 06/26/2018 00:35:43 ******/
ALTER TABLE [dbo].[UserProfile] ADD  CONSTRAINT [DF_UserProfile_IsDeactive]  DEFAULT ((0)) FOR [IsDeactive]
GO
/****** Object:  ForeignKey [FK_UserProfile_UserProfile]    Script Date: 06/26/2018 00:35:43 ******/
ALTER TABLE [dbo].[UserProfile]  WITH CHECK ADD  CONSTRAINT [FK_UserProfile_UserProfile] FOREIGN KEY([CreatedById])
REFERENCES [dbo].[UserProfile] ([UserId])
GO
ALTER TABLE [dbo].[UserProfile] CHECK CONSTRAINT [FK_UserProfile_UserProfile]
GO
/****** Object:  ForeignKey [fk_RoleId]    Script Date: 06/26/2018 00:35:43 ******/
ALTER TABLE [dbo].[webpages_UsersInRoles]  WITH CHECK ADD  CONSTRAINT [fk_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[webpages_Roles] ([RoleId])
GO
ALTER TABLE [dbo].[webpages_UsersInRoles] CHECK CONSTRAINT [fk_RoleId]
GO
