USE [master]
GO
/****** Object:  Database [CS6232-g3]    Script Date: 3/16/2024 6:12:33 PM ******/
CREATE DATABASE [CS6232-g3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CS6232-g3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CS6232-g3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CS6232-g3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CS6232-g3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CS6232-g3] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CS6232-g3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CS6232-g3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CS6232-g3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CS6232-g3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CS6232-g3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CS6232-g3] SET ARITHABORT OFF 
GO
ALTER DATABASE [CS6232-g3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CS6232-g3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CS6232-g3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CS6232-g3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CS6232-g3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CS6232-g3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CS6232-g3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CS6232-g3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CS6232-g3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CS6232-g3] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CS6232-g3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CS6232-g3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CS6232-g3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CS6232-g3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CS6232-g3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CS6232-g3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CS6232-g3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CS6232-g3] SET RECOVERY FULL 
GO
ALTER DATABASE [CS6232-g3] SET  MULTI_USER 
GO
ALTER DATABASE [CS6232-g3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CS6232-g3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CS6232-g3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CS6232-g3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CS6232-g3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CS6232-g3] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'CS6232-g3', N'ON'
GO
ALTER DATABASE [CS6232-g3] SET QUERY_STORE = OFF
GO
USE [CS6232-g3]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 3/16/2024 6:12:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[LoginID] [int] NOT NULL,
	[FirstName] [varchar](45) NOT NULL,
	[LastName] [varchar](45) NOT NULL,
	[Gender] [char](1) NULL,
	[DateOfBirth] [date] NOT NULL,
	[Address1] [varchar](150) NOT NULL,
	[Address2] [varchar](150) NULL,
	[City] [varchar](45) NOT NULL,
	[State] [varchar](45) NOT NULL,
	[Zip] [varchar](10) NOT NULL,
	[ContactPhone] [char](10) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Furniture]    Script Date: 3/16/2024 6:12:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Furniture](
	[FurnitureID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](45) NOT NULL,
	[StyleName] [varchar](45) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[RentalRatePerDay] [decimal](10, 2) NOT NULL,
	[InStockQuantity] [int] NOT NULL,
	[TotalQuantity] [int] NOT NULL,
 CONSTRAINT [PK_Furniture] PRIMARY KEY CLUSTERED 
(
	[FurnitureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FurnitureCategory]    Script Date: 3/16/2024 6:12:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FurnitureCategory](
	[CategoryName] [varchar](45) NOT NULL,
 CONSTRAINT [PK_FurnitureCategory] PRIMARY KEY CLUSTERED 
(
	[CategoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FurnitureStyle]    Script Date: 3/16/2024 6:12:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FurnitureStyle](
	[StyleName] [varchar](45) NOT NULL,
 CONSTRAINT [PK_FurnitureStyle] PRIMARY KEY CLUSTERED 
(
	[StyleName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 3/16/2024 6:12:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[LoginID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](45) NOT NULL,
	[Password] [varchar](45) NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[LoginID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 3/16/2024 6:12:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MemberID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](200) NOT NULL,
	[LastName] [varchar](200) NOT NULL,
	[Gender] [char](1) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[Address1] [varchar](150) NOT NULL,
	[Address2] [varchar](150) NULL,
	[City] [varchar](45) NOT NULL,
	[State] [varchar](45) NOT NULL,
	[Zip] [varchar](10) NOT NULL,
	[ContactPhone] [char](10) NOT NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentalItem]    Script Date: 3/16/2024 6:12:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentalItem](
	[RentalItemID] [int] IDENTITY(1,1) NOT NULL,
	[RentalTransactionID] [int] NOT NULL,
	[FurnitureID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[DailyRate] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_RentalItem] PRIMARY KEY CLUSTERED 
(
	[RentalItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentalTransaction]    Script Date: 3/16/2024 6:12:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentalTransaction](
	[RentalTransactionID] [int] IDENTITY(1,1) NOT NULL,
	[MemberID] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[RentalDate] [date] NOT NULL,
	[DueDate] [date] NOT NULL,
	[TotalCost] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_RentalTransaction] PRIMARY KEY CLUSTERED 
(
	[RentalTransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReturnItem]    Script Date: 3/16/2024 6:12:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnItem](
	[ReturnItemID] [int] NOT NULL,
	[ReturnTransactionID] [int] NOT NULL,
	[RentalItemID] [int] NOT NULL,
	[QuantityReturned] [int] NOT NULL,
 CONSTRAINT [PK_ReturnItem] PRIMARY KEY CLUSTERED 
(
	[ReturnItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReturnTransaction]    Script Date: 3/16/2024 6:12:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnTransaction](
	[ReturnTransactionID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[MemberID] [int] NOT NULL,
	[ReturnDate] [date] NOT NULL,
	[QuantityReturned] [int] NOT NULL,
	[ReturnAmount] [decimal](10, 2) NOT NULL,
	[FineAmount] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_ReturnTransaction] PRIMARY KEY CLUSTERED 
(
	[ReturnTransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([EmployeeID], [LoginID], [FirstName], [LastName], [Gender], [DateOfBirth], [Address1], [Address2], [City], [State], [Zip], [ContactPhone]) VALUES (1, 1, N'Deeksha', N'Namani', N'M', CAST(N'1997-01-01' AS Date), N'123 Maple St', NULL, N'Carrollton', N'GA', N'30118', N'1234567890')
INSERT [dbo].[Employee] ([EmployeeID], [LoginID], [FirstName], [LastName], [Gender], [DateOfBirth], [Address1], [Address2], [City], [State], [Zip], [ContactPhone]) VALUES (2, 2, N'Benjamin', N'Lively', N'M', CAST(N'1992-03-03' AS Date), N'125 Maple St', NULL, N'Temple', N'GA', N'12345', N'1234567892')
INSERT [dbo].[Employee] ([EmployeeID], [LoginID], [FirstName], [LastName], [Gender], [DateOfBirth], [Address1], [Address2], [City], [State], [Zip], [ContactPhone]) VALUES (3, 3, N'Stane', N'Shadrix', N'F', CAST(N'1993-04-04' AS Date), N'126 Maple St', NULL, N'Atlanta', N'GA', N'34567', N'1234567893')
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Furniture] ON 

INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (1, N'Chair', N'Modern', N'Modern Chair', N'A sleek, modern chair.', CAST(10.00 AS Decimal(10, 2)), 5, 10)
INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (2, N'Table', N'Traditional', N'Traditional Table', N'A sturdy, traditional table.', CAST(15.00 AS Decimal(10, 2)), 5, 10)
INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (3, N'Sofa', N'Contemporary', N'Contemporary Sofa', N'A comfortable, contemporary sofa.', CAST(20.00 AS Decimal(10, 2)), 5, 10)
INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (4, N'Bed', N'Rustic', N'Rustic Bed', N'A cozy, rustic bed.', CAST(25.00 AS Decimal(10, 2)), 5, 10)
INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (5, N'Desk', N'Industrial', N'Industrial Desk', N'A solid, industrial desk.', CAST(30.00 AS Decimal(10, 2)), 5, 10)
SET IDENTITY_INSERT [dbo].[Furniture] OFF
GO
INSERT [dbo].[FurnitureCategory] ([CategoryName]) VALUES (N'Bed')
INSERT [dbo].[FurnitureCategory] ([CategoryName]) VALUES (N'Chair')
INSERT [dbo].[FurnitureCategory] ([CategoryName]) VALUES (N'Desk')
INSERT [dbo].[FurnitureCategory] ([CategoryName]) VALUES (N'Sofa')
INSERT [dbo].[FurnitureCategory] ([CategoryName]) VALUES (N'Table')
GO
INSERT [dbo].[FurnitureStyle] ([StyleName]) VALUES (N'Contemporary')
INSERT [dbo].[FurnitureStyle] ([StyleName]) VALUES (N'Industrial')
INSERT [dbo].[FurnitureStyle] ([StyleName]) VALUES (N'Modern')
INSERT [dbo].[FurnitureStyle] ([StyleName]) VALUES (N'Rustic')
INSERT [dbo].[FurnitureStyle] ([StyleName]) VALUES (N'Traditional')
INSERT [dbo].[FurnitureStyle] ([StyleName]) VALUES (N'Victorian')
GO
SET IDENTITY_INSERT [dbo].[Login] ON 

INSERT [dbo].[Login] ([LoginID], [Username], [Password]) VALUES (1, N'user1', N'password1')
INSERT [dbo].[Login] ([LoginID], [Username], [Password]) VALUES (2, N'user2', N'password2')
INSERT [dbo].[Login] ([LoginID], [Username], [Password]) VALUES (3, N'user3', N'password3')
SET IDENTITY_INSERT [dbo].[Login] OFF
GO
SET IDENTITY_INSERT [dbo].[Member] ON 

INSERT [dbo].[Member] ([MemberID], [FirstName], [LastName], [Gender], [DateOfBirth], [Address1], [Address2], [City], [State], [Zip], [ContactPhone]) VALUES (1, N'Pooja', N'Shetty', N'F', CAST(N'1990-01-01' AS Date), N'128 Dueberry St', N'Apt 1', N'Atlanta', N'GA', N'12345', N'1234567895')
INSERT [dbo].[Member] ([MemberID], [FirstName], [LastName], [Gender], [DateOfBirth], [Address1], [Address2], [City], [State], [Zip], [ContactPhone]) VALUES (2, N'Ian', N'Hallman', N'M', CAST(N'1991-02-02' AS Date), N'129 BlueRose St', N'Apt 2', N'Townsville', N'GA', N'30118', N'1234567896')
INSERT [dbo].[Member] ([MemberID], [FirstName], [LastName], [Gender], [DateOfBirth], [Address1], [Address2], [City], [State], [Zip], [ContactPhone]) VALUES (3, N'Rob', N'Melisso', N'M', CAST(N'1992-03-03' AS Date), N'130 King St', N'Apt 3', N'Carrollton', N'GA', N'30130', N'1234567897')
INSERT [dbo].[Member] ([MemberID], [FirstName], [LastName], [Gender], [DateOfBirth], [Address1], [Address2], [City], [State], [Zip], [ContactPhone]) VALUES (4, N'Jodarn', N'Lee', N'F', CAST(N'1993-04-04' AS Date), N'131 TimeSquare St', N'Apt 4', N'Villa Rica', N'36789', N'12345', N'1234567898')
INSERT [dbo].[Member] ([MemberID], [FirstName], [LastName], [Gender], [DateOfBirth], [Address1], [Address2], [City], [State], [Zip], [ContactPhone]) VALUES (5, N'Felix', N'Foi', N'M', CAST(N'1994-05-05' AS Date), N'132 CitySquare St', N'Apt 5', N'Hellan', N'GA', N'12890', N'1234567899')
INSERT [dbo].[Member] ([MemberID], [FirstName], [LastName], [Gender], [DateOfBirth], [Address1], [Address2], [City], [State], [Zip], [ContactPhone]) VALUES (6, N'bonnie', N'shadrix', N'M', CAST(N'2010-02-01' AS Date), N'200 Hickory Chase', N'1', N'Carrollton', N'GA', N'30117', N'1234567890')
INSERT [dbo].[Member] ([MemberID], [FirstName], [LastName], [Gender], [DateOfBirth], [Address1], [Address2], [City], [State], [Zip], [ContactPhone]) VALUES (7, N'stan', N'shadrix', N'M', CAST(N'1991-02-01' AS Date), N'518 Longview st.', N'NA', N'Carrollton', N'Georgia', N'30117', N'4049159023')
INSERT [dbo].[Member] ([MemberID], [FirstName], [LastName], [Gender], [DateOfBirth], [Address1], [Address2], [City], [State], [Zip], [ContactPhone]) VALUES (8, N'Bonnie', N'Shadrix', N'F', CAST(N'2010-02-01' AS Date), N'200 Hickory Chase', NULL, N'Carrollton', N'Georgia', N'30117', N'4049159023')
SET IDENTITY_INSERT [dbo].[Member] OFF
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Login] FOREIGN KEY([LoginID])
REFERENCES [dbo].[Login] ([LoginID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Login]
GO
ALTER TABLE [dbo].[Furniture]  WITH CHECK ADD  CONSTRAINT [FK_Furniture_FurnitureCategory] FOREIGN KEY([CategoryName])
REFERENCES [dbo].[FurnitureCategory] ([CategoryName])
GO
ALTER TABLE [dbo].[Furniture] CHECK CONSTRAINT [FK_Furniture_FurnitureCategory]
GO
ALTER TABLE [dbo].[Furniture]  WITH CHECK ADD  CONSTRAINT [FK_Furniture_FurnitureStyle] FOREIGN KEY([StyleName])
REFERENCES [dbo].[FurnitureStyle] ([StyleName])
GO
ALTER TABLE [dbo].[Furniture] CHECK CONSTRAINT [FK_Furniture_FurnitureStyle]
GO
ALTER TABLE [dbo].[RentalItem]  WITH CHECK ADD  CONSTRAINT [FK_RentalItem_Furniture] FOREIGN KEY([FurnitureID])
REFERENCES [dbo].[Furniture] ([FurnitureID])
GO
ALTER TABLE [dbo].[RentalItem] CHECK CONSTRAINT [FK_RentalItem_Furniture]
GO
ALTER TABLE [dbo].[RentalItem]  WITH CHECK ADD  CONSTRAINT [FK_RentalItem_RentalTransaction] FOREIGN KEY([RentalTransactionID])
REFERENCES [dbo].[RentalTransaction] ([RentalTransactionID])
GO
ALTER TABLE [dbo].[RentalItem] CHECK CONSTRAINT [FK_RentalItem_RentalTransaction]
GO
ALTER TABLE [dbo].[RentalTransaction]  WITH CHECK ADD  CONSTRAINT [FK_RentalTransaction_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[RentalTransaction] CHECK CONSTRAINT [FK_RentalTransaction_Employee]
GO
ALTER TABLE [dbo].[RentalTransaction]  WITH CHECK ADD  CONSTRAINT [FK_RentalTransaction_Member] FOREIGN KEY([MemberID])
REFERENCES [dbo].[Member] ([MemberID])
GO
ALTER TABLE [dbo].[RentalTransaction] CHECK CONSTRAINT [FK_RentalTransaction_Member]
GO
ALTER TABLE [dbo].[ReturnItem]  WITH CHECK ADD  CONSTRAINT [FK_ReturnItem_RentalItem] FOREIGN KEY([RentalItemID])
REFERENCES [dbo].[RentalItem] ([RentalItemID])
GO
ALTER TABLE [dbo].[ReturnItem] CHECK CONSTRAINT [FK_ReturnItem_RentalItem]
GO
ALTER TABLE [dbo].[ReturnItem]  WITH CHECK ADD  CONSTRAINT [FK_ReturnItem_ReturnTransaction] FOREIGN KEY([ReturnTransactionID])
REFERENCES [dbo].[ReturnTransaction] ([ReturnTransactionID])
GO
ALTER TABLE [dbo].[ReturnItem] CHECK CONSTRAINT [FK_ReturnItem_ReturnTransaction]
GO
ALTER TABLE [dbo].[ReturnTransaction]  WITH CHECK ADD  CONSTRAINT [FK_ReturnTransaction_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[ReturnTransaction] CHECK CONSTRAINT [FK_ReturnTransaction_Employee]
GO
ALTER TABLE [dbo].[ReturnTransaction]  WITH CHECK ADD  CONSTRAINT [FK_ReturnTransaction_Member] FOREIGN KEY([MemberID])
REFERENCES [dbo].[Member] ([MemberID])
GO
ALTER TABLE [dbo].[ReturnTransaction] CHECK CONSTRAINT [FK_ReturnTransaction_Member]
GO
USE [master]
GO
ALTER DATABASE [CS6232-g3] SET  READ_WRITE 
GO
