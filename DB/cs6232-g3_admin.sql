USE [master]
GO
IF EXISTS (SELECT 1 FROM master.dbo.sysdatabases WHERE name = 'CS6232-g3')
BEGIN
 DROP DATABASE [CS6232-g3];
END
GO
/****** Object:  Database [CS6232-g3]    Script Date: 3/16/2024 6:12:33 PM ******/
CREATE DATABASE [CS6232-g3]
GO
USE [CS6232-g3]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 4/16/2024 9:33:53 PM ******/
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
/****** Object:  Table [dbo].[Furniture]    Script Date: 4/16/2024 9:33:53 PM ******/
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

CREATE TABLE [dbo].[Admin]( 
	[AdminID] [int] IDENTITY(1,1) NOT NULL, 
	[LoginID] [int] NOT NULL, 
	[FirstName] [varchar] (45)NOT NULL, 
	[LastName] [varchar] (45) NOT NULL, 
	[DateOfBirth] [date] NOT NULL, 
	[Address1] [varchar](150) NOT NULL, 
	[Address2] [varchar](150) NULL, 
	[City] [varchar](45) NOT NULL, 
	[State] [varchar](45) NOT NULL, 
	[Zip] [varchar](10) NOT NULL, 
	[ContactPhone] [char](10) NOT NULL, 
	CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
	(
		[AdminID] ASC 
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY] 
	) ON [PRIMARY] 

GO
/****** Object:  Table [dbo].[FurnitureCategory]    Script Date: 4/16/2024 9:33:53 PM ******/
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
/****** Object:  Table [dbo].[FurnitureStyle]    Script Date: 4/16/2024 9:33:53 PM ******/
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
/****** Object:  Table [dbo].[Login]    Script Date: 4/16/2024 9:33:53 PM ******/
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
/****** Object:  Table [dbo].[Member]    Script Date: 4/16/2024 9:33:53 PM ******/
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
/****** Object:  Table [dbo].[RentalItem]    Script Date: 4/16/2024 9:33:53 PM ******/
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
/****** Object:  Table [dbo].[RentalTransaction]    Script Date: 4/16/2024 9:33:53 PM ******/
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
/****** Object:  Table [dbo].[ReturnItem]    Script Date: 4/16/2024 9:33:53 PM ******/
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
/****** Object:  Table [dbo].[ReturnTransaction]    Script Date: 4/16/2024 9:33:53 PM ******/
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

INSERT [dbo].[Employee] ([EmployeeID], [LoginID], [FirstName], [LastName], [Gender], [DateOfBirth], [Address1], [Address2], [City], [State], [Zip], [ContactPhone]) VALUES (1, 1, N'Deeksha', N'Namani', N'F', CAST(N'1997-01-01' AS Date), N'123 Maple St', NULL, N'Carrollton', N'GA', N'30118', N'1234567890')
INSERT [dbo].[Employee] ([EmployeeID], [LoginID], [FirstName], [LastName], [Gender], [DateOfBirth], [Address1], [Address2], [City], [State], [Zip], [ContactPhone]) VALUES (2, 2, N'Benjamin', N'Lively', N'M', CAST(N'1992-03-03' AS Date), N'125 Maple St', NULL, N'Temple', N'GA', N'12345', N'1234567892')
INSERT [dbo].[Employee] ([EmployeeID], [LoginID], [FirstName], [LastName], [Gender], [DateOfBirth], [Address1], [Address2], [City], [State], [Zip], [ContactPhone]) VALUES (3, 3, N'Stan', N'Shadrix', N'M', CAST(N'1991-02-01' AS Date), N'518 Longview St', NULL, N'Carrollton', N'GA', N'30117', N'4049159023')
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Furniture] ON 

INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (1, N'Chair', N'Modern', N'Modern Chair', N'A sleek, modern chair.', CAST(10.00 AS Decimal(10, 2)), 10, 10)
INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (2, N'Table', N'Traditional', N'Traditional Table', N'A sturdy, traditional table.', CAST(15.00 AS Decimal(10, 2)), 10, 10)
INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (3, N'Sofa', N'Contemporary', N'Contemporary Sofa', N'A comfortable, contemporary sofa.', CAST(20.00 AS Decimal(10, 2)), 10, 10)
INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (4, N'Bed', N'Rustic', N'Rustic Bed', N'A cozy, rustic bed.', CAST(25.00 AS Decimal(10, 2)), 10, 10)
INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (5, N'Desk', N'Industrial', N'Industrial Desk', N'A solid, industrial desk.', CAST(30.00 AS Decimal(10, 2)), 10, 10)
INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (6, N'Chair', N'Modern', N'Sleek Office Chair', N'A modern chair perfect for any office setting.', CAST(12.00 AS Decimal(10, 2)), 6, 6)
INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (7, N'Chair', N'Traditional', N'Classic Wooden Chair', N'A traditional chair with timeless design.', CAST(8.00 AS Decimal(10, 2)), 8, 8)
INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (8, N'Chair', N'Victorian', N'Victorian Armchair', N'An elegant and ornate chair, perfect for adding a touch of class.', CAST(15.00 AS Decimal(10, 2)), 4, 4)
INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (9, N'Table', N'Modern', N'Minimalist Coffee Table', N'A minimalist table that brings a modern touch to any room.', CAST(14.00 AS Decimal(10, 2)), 10, 10)
INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (10, N'Table', N'Rustic', N'Rustic Log Table', N'A sturdy table that brings a warm, rustic feel to your home.', CAST(16.00 AS Decimal(10, 2)), 6, 6)
INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (11, N'Table', N'Industrial', N'Industrial Dining Table', N'A solid and durable table with an industrial look.', CAST(18.00 AS Decimal(10, 2)), 5, 5)
INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (12, N'Sofa', N'Contemporary', N'Contemporary Leather Sofa', N'A stylish and comfortable sofa that fits any contemporary space.', CAST(22.00 AS Decimal(10, 2)), 5, 5)
INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (13, N'Sofa', N'Modern', N'Modern Sectional Sofa', N'A modern sectional sofa that offers both style and comfort.', CAST(24.00 AS Decimal(10, 2)), 7, 7)
INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (14, N'Sofa', N'Victorian', N'Victorian Loveseat', N'An ornately designed loveseat that exudes Victorian elegance.', CAST(26.00 AS Decimal(10, 2)), 3, 3)
INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (15, N'Bed', N'Modern', N'Modern Platform Bed', N'A sleek and stylish bed with a minimalist design.', CAST(28.00 AS Decimal(10, 2)), 8, 8)
INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (16, N'Bed', N'Traditional', N'Traditional Poster Bed', N'A classic bed with elegant posters that add a touch of tradition.', CAST(30.00 AS Decimal(10, 2)), 4, 4)
INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (17, N'Bed', N'Rustic', N'Rustic Log Bed', N'A cozy bed that brings the charm of rustic living into your bedroom.', CAST(32.00 AS Decimal(10, 2)), 6, 6)
INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (18, N'Desk', N'Modern', N'Glass Top Office Desk', N'A modern desk with a sleek glass top and minimalist frame.', CAST(35.00 AS Decimal(10, 2)), 20, 20)
INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (19, N'Desk', N'Traditional', N'Mahogany Executive Desk', N'An imposing mahogany desk that commands respect and authority.', CAST(40.00 AS Decimal(10, 2)), 16, 16)
INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (20, N'Desk', N'Industrial', N'Steel Frame Workstation', N'A sturdy and durable desk with a solid steel frame and industrial design.', CAST(33.00 AS Decimal(10, 2)), 24, 24)
INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (21, N'Desk', N'Contemporary', N'Compact Computer Desk', N'A contemporary compact desk perfect for small spaces and home offices.', CAST(28.00 AS Decimal(10, 2)), 30, 30)
INSERT [dbo].[Furniture] ([FurnitureID], [CategoryName], [StyleName], [Name], [Description], [RentalRatePerDay], [InStockQuantity], [TotalQuantity]) VALUES (22, N'Desk', N'Rustic', N'Reclaimed Wood Desk', N'A rustic desk made from reclaimed wood, each piece tells its own story.', CAST(37.00 AS Decimal(10, 2)), 14, 14)
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

SET IDENTITY_INSERT [dbo].[Admin] ON
INSERT [dbo].[Admin] ([AdminID], [LoginID], [FirstName], [LastName], [DateOfBirth], [Address1], [Address2], [City], [State], [Zip], [ContactPhone]) VALUES (1, 4, N'Li', N'Yang', CAST(N'1989-05-15' AS Date), N'123 Admin St', NULL, N'Adminville', N'GA', N'12345', N'1234567890')
SET IDENTITY_INSERT [dbo].[Admin] OFF 

SET IDENTITY_INSERT [dbo].[Login] ON 
INSERT [dbo].[Login] ([LoginID], [Username], [Password]) VALUES (1, N'user1', N'password1')
INSERT [dbo].[Login] ([LoginID], [Username], [Password]) VALUES (2, N'user2', N'password2')
INSERT [dbo].[Login] ([LoginID], [Username], [Password]) VALUES (3, N'user3', N'password3')
INSERT [dbo].[Login] ([LoginID], [Username], [Password]) VALUES (4, N'admin', N'password01')
SET IDENTITY_INSERT [dbo].[Login] OFF
GO
SET IDENTITY_INSERT [dbo].[Member] ON 

INSERT [dbo].[Member] ([MemberID], [FirstName], [LastName], [Gender], [DateOfBirth], [Address1], [Address2], [City], [State], [Zip], [ContactPhone]) VALUES (1, N'Pooja', N'Shetty', N'F', CAST(N'1990-01-01' AS Date), N'128 Dueberry St', N'Apt 1', N'Atlanta', N'GA', N'12345', N'1234567895')
INSERT [dbo].[Member] ([MemberID], [FirstName], [LastName], [Gender], [DateOfBirth], [Address1], [Address2], [City], [State], [Zip], [ContactPhone]) VALUES (2, N'Ian', N'Hallman', N'M', CAST(N'1991-02-02' AS Date), N'129 BlueRose St', N'Apt 2', N'Townsville', N'GA', N'30118', N'1234567896')
INSERT [dbo].[Member] ([MemberID], [FirstName], [LastName], [Gender], [DateOfBirth], [Address1], [Address2], [City], [State], [Zip], [ContactPhone]) VALUES (3, N'Rob', N'Melisso', N'M', CAST(N'1992-03-03' AS Date), N'130 King St', N'Apt 3', N'Carrollton', N'GA', N'30130', N'1234567897')
INSERT [dbo].[Member] ([MemberID], [FirstName], [LastName], [Gender], [DateOfBirth], [Address1], [Address2], [City], [State], [Zip], [ContactPhone]) VALUES (4, N'Jodarn', N'Lee', N'F', CAST(N'1993-04-04' AS Date), N'131 TimeSquare St', N'Apt 4', N'Villa Rica', N'GA', N'12345', N'1234567898')
INSERT [dbo].[Member] ([MemberID], [FirstName], [LastName], [Gender], [DateOfBirth], [Address1], [Address2], [City], [State], [Zip], [ContactPhone]) VALUES (5, N'Felix', N'Foi', N'M', CAST(N'1994-05-05' AS Date), N'132 CitySquare St', N'Apt 5', N'Hellan', N'GA', N'12890', N'1234567899')
INSERT [dbo].[Member] ([MemberID], [FirstName], [LastName], [Gender], [DateOfBirth], [Address1], [Address2], [City], [State], [Zip], [ContactPhone]) VALUES (6, N'Bonnie', N'Shadrix', N'F', CAST(N'2010-02-01' AS Date), N'200 Hickory Chase', NULL, N'Carrollton', N'GA', N'30117', N'4049159023')
INSERT [dbo].[Member] ([MemberID], [FirstName], [LastName], [Gender], [DateOfBirth], [Address1], [Address2], [City], [State], [Zip], [ContactPhone]) VALUES (7, N'Stan', N'Shadrix', N'M', CAST(N'1991-02-01' AS Date), N'518 Longview st.', NULL, N'CTown', N'GA', N'30117', N'4049159023')
SET IDENTITY_INSERT [dbo].[Member] OFF
GO
SET IDENTITY_INSERT [dbo].[RentalItem] ON 

INSERT [dbo].[RentalItem] ([RentalItemID], [RentalTransactionID], [FurnitureID], [Quantity], [DailyRate]) VALUES (1, 1, 4, 2, CAST(50.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalItem] ([RentalItemID], [RentalTransactionID], [FurnitureID], [Quantity], [DailyRate]) VALUES (2, 1, 1, 1, CAST(10.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalItem] ([RentalItemID], [RentalTransactionID], [FurnitureID], [Quantity], [DailyRate]) VALUES (3, 2, 2, 2, CAST(30.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalItem] ([RentalItemID], [RentalTransactionID], [FurnitureID], [Quantity], [DailyRate]) VALUES (4, 3, 2, 2, CAST(30.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalItem] ([RentalItemID], [RentalTransactionID], [FurnitureID], [Quantity], [DailyRate]) VALUES (5, 4, 3, 2, CAST(40.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalItem] ([RentalItemID], [RentalTransactionID], [FurnitureID], [Quantity], [DailyRate]) VALUES (6, 5, 3, 1, CAST(20.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalItem] ([RentalItemID], [RentalTransactionID], [FurnitureID], [Quantity], [DailyRate]) VALUES (7, 5, 5, 2, CAST(60.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalItem] ([RentalItemID], [RentalTransactionID], [FurnitureID], [Quantity], [DailyRate]) VALUES (8, 6, 1, 1, CAST(10.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalItem] ([RentalItemID], [RentalTransactionID], [FurnitureID], [Quantity], [DailyRate]) VALUES (9, 7, 5, 1, CAST(30.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalItem] ([RentalItemID], [RentalTransactionID], [FurnitureID], [Quantity], [DailyRate]) VALUES (10, 7, 1, 2, CAST(20.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalItem] ([RentalItemID], [RentalTransactionID], [FurnitureID], [Quantity], [DailyRate]) VALUES (11, 8, 4, 1, CAST(25.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalItem] ([RentalItemID], [RentalTransactionID], [FurnitureID], [Quantity], [DailyRate]) VALUES (12, 9, 4, 1, CAST(25.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalItem] ([RentalItemID], [RentalTransactionID], [FurnitureID], [Quantity], [DailyRate]) VALUES (13, 10, 5, 2, CAST(60.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalItem] ([RentalItemID], [RentalTransactionID], [FurnitureID], [Quantity], [DailyRate]) VALUES (14, 10, 3, 1, CAST(20.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalItem] ([RentalItemID], [RentalTransactionID], [FurnitureID], [Quantity], [DailyRate]) VALUES (15, 11, 2, 1, CAST(15.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[RentalItem] OFF
GO
SET IDENTITY_INSERT [dbo].[RentalTransaction] ON 

INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [MemberID], [EmployeeID], [RentalDate], [DueDate], [TotalCost]) VALUES (1, 6, 3, CAST(N'2024-04-05' AS Date), CAST(N'2024-04-06' AS Date), CAST(128.40 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [MemberID], [EmployeeID], [RentalDate], [DueDate], [TotalCost]) VALUES (2, 6, 3, CAST(N'2024-04-06' AS Date), CAST(N'2024-04-25' AS Date), CAST(642.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [MemberID], [EmployeeID], [RentalDate], [DueDate], [TotalCost]) VALUES (3, 6, 3, CAST(N'2024-04-06' AS Date), CAST(N'2024-04-25' AS Date), CAST(642.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [MemberID], [EmployeeID], [RentalDate], [DueDate], [TotalCost]) VALUES (4, 6, 3, CAST(N'2024-05-06' AS Date), CAST(N'2024-08-01' AS Date), CAST(3766.40 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [MemberID], [EmployeeID], [RentalDate], [DueDate], [TotalCost]) VALUES (5, 6, 3, CAST(N'2024-06-14' AS Date), CAST(N'2025-02-01' AS Date), CAST(19944.80 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [MemberID], [EmployeeID], [RentalDate], [DueDate], [TotalCost]) VALUES (6, 6, 3, CAST(N'2024-07-04' AS Date), CAST(N'2024-08-04' AS Date), CAST(342.40 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [MemberID], [EmployeeID], [RentalDate], [DueDate], [TotalCost]) VALUES (7, 7, 3, CAST(N'2024-05-01' AS Date), CAST(N'2024-06-01' AS Date), CAST(1712.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [MemberID], [EmployeeID], [RentalDate], [DueDate], [TotalCost]) VALUES (8, 7, 3, CAST(N'2024-06-10' AS Date), CAST(N'2024-08-01' AS Date), CAST(1417.75 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [MemberID], [EmployeeID], [RentalDate], [DueDate], [TotalCost]) VALUES (9, 7, 3, CAST(N'2024-04-20' AS Date), CAST(N'2027-03-03' AS Date), CAST(28034.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [MemberID], [EmployeeID], [RentalDate], [DueDate], [TotalCost]) VALUES (10, 6, 3, CAST(N'2024-04-07' AS Date), CAST(N'2026-02-01' AS Date), CAST(57009.60 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [MemberID], [EmployeeID], [RentalDate], [DueDate], [TotalCost]) VALUES (11, 6, 3, CAST(N'2024-04-08' AS Date), CAST(N'2024-04-18' AS Date), CAST(176.55 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[RentalTransaction] OFF
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
