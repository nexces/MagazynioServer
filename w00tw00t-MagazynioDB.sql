USE [Magazynio]
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ProductsSaledProducedAvailable'

GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ProductsSaledProducedAvailable'

GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Product'

GO
ALTER TABLE [dbo].[Sale] DROP CONSTRAINT [FK_Sale_Salesman]
GO
ALTER TABLE [dbo].[Sale] DROP CONSTRAINT [FK_Sale_Product]
GO
ALTER TABLE [dbo].[Production] DROP CONSTRAINT [FK_Production_Product]
GO
/****** Object:  View [dbo].[ProductsSaledProducedAvailable]    Script Date: 2013-01-17 15:11:57 ******/
DROP VIEW [dbo].[ProductsSaledProducedAvailable]
GO
/****** Object:  Table [dbo].[Salesman]    Script Date: 2013-01-17 15:11:57 ******/
DROP TABLE [dbo].[Salesman]
GO
/****** Object:  Table [dbo].[Sale]    Script Date: 2013-01-17 15:11:57 ******/
DROP TABLE [dbo].[Sale]
GO
/****** Object:  Table [dbo].[Production]    Script Date: 2013-01-17 15:11:57 ******/
DROP TABLE [dbo].[Production]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2013-01-17 15:11:57 ******/
DROP TABLE [dbo].[Product]
GO
USE [master]
GO
/****** Object:  Database [Magazynio]    Script Date: 2013-01-17 15:11:57 ******/
DROP DATABASE [Magazynio]
GO
/****** Object:  Database [Magazynio]    Script Date: 2013-01-17 15:11:57 ******/
CREATE DATABASE [Magazynio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Magazynio', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Magazynio.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Magazynio_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Magazynio_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Magazynio] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Magazynio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Magazynio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Magazynio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Magazynio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Magazynio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Magazynio] SET ARITHABORT OFF 
GO
ALTER DATABASE [Magazynio] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Magazynio] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Magazynio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Magazynio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Magazynio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Magazynio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Magazynio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Magazynio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Magazynio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Magazynio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Magazynio] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Magazynio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Magazynio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Magazynio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Magazynio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Magazynio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Magazynio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Magazynio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Magazynio] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Magazynio] SET  MULTI_USER 
GO
ALTER DATABASE [Magazynio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Magazynio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Magazynio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Magazynio] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Magazynio]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2013-01-17 15:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Price] [float] NULL,
	[Description] [text] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Production]    Script Date: 2013-01-17 15:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Production](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Product_id] [int] NULL,
	[Date] [date] NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_Production] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sale]    Script Date: 2013-01-17 15:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Product_id] [int] NULL,
	[Salesman_id] [int] NULL,
	[Date] [date] NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_Sale] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Salesman]    Script Date: 2013-01-17 15:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Salesman](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Login] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_Salesman] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[ProductsSaledProducedAvailable]    Script Date: 2013-01-17 15:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ProductsSaledProducedAvailable]
AS
SELECT        Id, Name, Price, Description,
                             (SELECT        SUM(Quantity) AS Expr1
                               FROM            dbo.Production
                               WHERE        (Product_id = dbo.Product.Id)) AS QProduced,
                             (SELECT        SUM(Quantity) AS Expr1
                               FROM            dbo.Sale
                               WHERE        (Product_id = dbo.Product.Id)) AS QSaled,
                             (SELECT        SUM(Quantity) AS Expr1
                               FROM            dbo.Production AS Production_1
                               WHERE        (Product_id = dbo.Product.Id)) -
                             (SELECT        SUM(Quantity) AS Expr1
                               FROM            dbo.Sale AS Sale_1
                               WHERE        (Product_id = dbo.Product.Id)) AS QAvailable
FROM            dbo.Product

GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [Name], [Price], [Description]) VALUES (1, N'Kropka', 0.03, N'Kropka kończąca konwersację')
INSERT [dbo].[Product] ([Id], [Name], [Price], [Description]) VALUES (2, N'Przecinek', 1, N'Ten przecinek doda więcej dziwnych myśli')
INSERT [dbo].[Product] ([Id], [Name], [Price], [Description]) VALUES (3, N'Wykrzaknik', 0.5, N'Mistrz wykrzaczania')
SET IDENTITY_INSERT [dbo].[Product] OFF
SET IDENTITY_INSERT [dbo].[Production] ON 

INSERT [dbo].[Production] ([Id], [Product_id], [Date], [Quantity]) VALUES (1, 1, CAST(0x94360B00 AS Date), 100)
INSERT [dbo].[Production] ([Id], [Product_id], [Date], [Quantity]) VALUES (2, 2, CAST(0x94360B00 AS Date), 100)
INSERT [dbo].[Production] ([Id], [Product_id], [Date], [Quantity]) VALUES (3, 3, CAST(0x94360B00 AS Date), 100)
INSERT [dbo].[Production] ([Id], [Product_id], [Date], [Quantity]) VALUES (4, 1, CAST(0x98360B00 AS Date), 100)
SET IDENTITY_INSERT [dbo].[Production] OFF
SET IDENTITY_INSERT [dbo].[Sale] ON 

INSERT [dbo].[Sale] ([Id], [Product_id], [Salesman_id], [Date], [Quantity]) VALUES (1, 1, 1, CAST(0x94360B00 AS Date), 30)
INSERT [dbo].[Sale] ([Id], [Product_id], [Salesman_id], [Date], [Quantity]) VALUES (2, 1, 2, CAST(0x94360B00 AS Date), 45)
INSERT [dbo].[Sale] ([Id], [Product_id], [Salesman_id], [Date], [Quantity]) VALUES (3, 2, 1, CAST(0x94360B00 AS Date), 5)
INSERT [dbo].[Sale] ([Id], [Product_id], [Salesman_id], [Date], [Quantity]) VALUES (4, 3, 2, CAST(0x98360B00 AS Date), 1)
SET IDENTITY_INSERT [dbo].[Sale] OFF
SET IDENTITY_INSERT [dbo].[Salesman] ON 

INSERT [dbo].[Salesman] ([Id], [Name], [Login], [Password]) VALUES (1, N'Nexces', N'Nexces', N'password')
INSERT [dbo].[Salesman] ([Id], [Name], [Login], [Password]) VALUES (2, N'Kazuya', N'Kazuya', N'password')
SET IDENTITY_INSERT [dbo].[Salesman] OFF
ALTER TABLE [dbo].[Production]  WITH CHECK ADD  CONSTRAINT [FK_Production_Product] FOREIGN KEY([Product_id])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[Production] CHECK CONSTRAINT [FK_Production_Product]
GO
ALTER TABLE [dbo].[Sale]  WITH CHECK ADD  CONSTRAINT [FK_Sale_Product] FOREIGN KEY([Product_id])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[Sale] CHECK CONSTRAINT [FK_Sale_Product]
GO
ALTER TABLE [dbo].[Sale]  WITH CHECK ADD  CONSTRAINT [FK_Sale_Salesman] FOREIGN KEY([Salesman_id])
REFERENCES [dbo].[Salesman] ([Id])
GO
ALTER TABLE [dbo].[Sale] CHECK CONSTRAINT [FK_Sale_Salesman]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Zawiera informacje o produktach' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Product'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Product"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 2025
         Table = 1170
         Output = 1065
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 2580
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ProductsSaledProducedAvailable'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ProductsSaledProducedAvailable'
GO
USE [master]
GO
ALTER DATABASE [Magazynio] SET  READ_WRITE 
GO
