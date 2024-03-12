USE [master]
GO
/****** Object:  Database [CS6232-g3]    Script Date: 3/10/2024 6:29:42 PM ******/
CREATE DATABASE [CS6232-g3]
 GO

USE [CS6232-g3]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 3/10/2024 6:29:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[LoginID] [int] NOT NULL,
	[FirstName] [varchar](45) NOT NULL,
	[LastName] [varchar](45) NOT NULL,
	[Gender] [char](1) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[Address1] [varchar](150) NOT NULL,
	[Address2] [varchar](150) NOT NULL,
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
/****** Object:  Table [dbo].[Furniture]    Script Date: 3/10/2024 6:29:42 PM ******/
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
/****** Object:  Table [dbo].[FurnitureCategory]    Script Date: 3/10/2024 6:29:42 PM ******/
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
/****** Object:  Table [dbo].[FurnitureStyle]    Script Date: 3/10/2024 6:29:42 PM ******/
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
/****** Object:  Table [dbo].[Login]    Script Date: 3/10/2024 6:29:42 PM ******/
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
/****** Object:  Table [dbo].[Member]    Script Date: 3/10/2024 6:29:42 PM ******/
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
	[Address2] [varchar](150) NOT NULL,
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
/****** Object:  Table [dbo].[RentalItem]    Script Date: 3/10/2024 6:29:42 PM ******/
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
/****** Object:  Table [dbo].[RentalTransaction]    Script Date: 3/10/2024 6:29:42 PM ******/
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
/****** Object:  Table [dbo].[ReturnItem]    Script Date: 3/10/2024 6:29:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnItem](
	[ReturnItemID] [int] IDENTITY(1,1) NOT NULL,
	[ReturnTransactionID] [int] NOT NULL,
	[RentalItemID] [int] NOT NULL,
	[QuantityReturned] [int] NOT NULL,
 CONSTRAINT [PK_ReturnItem] PRIMARY KEY CLUSTERED 
(
	[ReturnItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReturnTransaction]    Script Date: 3/10/2024 6:29:42 PM ******/
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
