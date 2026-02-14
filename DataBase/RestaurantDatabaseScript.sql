USE [Restaurant]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 2/14/2026 7:35:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](500) NOT NULL,
	[Description] [varchar](500) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cusorder]    Script Date: 2/14/2026 7:35:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cusorder](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[CusId] [int] NOT NULL,
	[status] [varchar](500) NOT NULL,
	[TotalAmount] [int] NOT NULL,
	[OrderDate] [datetime] NULL,
	[EmpId] [int] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 2/14/2026 7:35:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[MenuID] [int] IDENTITY(1,1) NOT NULL,
	[CatagoryId] [int] NOT NULL,
	[FoodName] [nvarchar](500) NOT NULL,
	[Price] [int] NOT NULL,
	[AvailableQuantity] [int] NOT NULL,
	[ImagePath] [nvarchar](500) NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItem]    Script Date: 2/14/2026 7:35:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItem](
	[OrderItemId] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[MenuId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_OrderItem] PRIMARY KEY CLUSTERED 
(
	[OrderItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rating]    Script Date: 2/14/2026 7:35:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rating](
	[RatingID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[OrderID] [int] NOT NULL,
	[RatingStars] [int] NOT NULL,
	[Comment] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_Rating_1] PRIMARY KEY CLUSTERED 
(
	[RatingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registration]    Script Date: 2/14/2026 7:35:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registration](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](500) NOT NULL,
	[Password] [nvarchar](200) NOT NULL,
	[Phone] [nvarchar](200) NOT NULL,
	[email] [nvarchar](500) NOT NULL,
	[UserType] [nvarchar](500) NULL,
	[Salary] [int] NULL,
 CONSTRAINT [PK_Registration] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Description]) VALUES (1, N'dinner', N'asdadsfsfdfd')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Description]) VALUES (2, N'Lunch', N'vcbcvbcvb')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Description]) VALUES (3, N'drinks', N'meaa')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Description]) VALUES (4, N'apetizer', N'gggjjj')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Description]) VALUES (5, N'deserts', N'hjhgfd')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Description]) VALUES (6, N'side dish', N'hiubvvf')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Description]) VALUES (7, N'house special', N'kjhfdg')
GO
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Cusorder] ON 
GO
INSERT [dbo].[Cusorder] ([OrderId], [CusId], [status], [TotalAmount], [OrderDate], [EmpId]) VALUES (1, 1, N'Pending', 50000, CAST(N'2026-01-05T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[Cusorder] ([OrderId], [CusId], [status], [TotalAmount], [OrderDate], [EmpId]) VALUES (4, 1, N'Pending', 1000, CAST(N'2026-01-17T00:47:51.000' AS DateTime), 2)
GO
INSERT [dbo].[Cusorder] ([OrderId], [CusId], [status], [TotalAmount], [OrderDate], [EmpId]) VALUES (6, 1, N'Pending', 2000, CAST(N'2026-01-17T09:02:15.000' AS DateTime), 1)
GO
INSERT [dbo].[Cusorder] ([OrderId], [CusId], [status], [TotalAmount], [OrderDate], [EmpId]) VALUES (8, 1, N'Pending', 700, CAST(N'2025-09-09T00:00:00.000' AS DateTime), NULL)
GO
INSERT [dbo].[Cusorder] ([OrderId], [CusId], [status], [TotalAmount], [OrderDate], [EmpId]) VALUES (9, 7, N'Pending', 898, CAST(N'2025-09-09T00:00:00.000' AS DateTime), NULL)
GO
INSERT [dbo].[Cusorder] ([OrderId], [CusId], [status], [TotalAmount], [OrderDate], [EmpId]) VALUES (11, 11, N'Pending', 17000, CAST(N'2026-01-18T17:59:00.000' AS DateTime), NULL)
GO
INSERT [dbo].[Cusorder] ([OrderId], [CusId], [status], [TotalAmount], [OrderDate], [EmpId]) VALUES (12, 12, N'Pending', 6000, CAST(N'2026-01-18T23:36:16.680' AS DateTime), NULL)
GO
INSERT [dbo].[Cusorder] ([OrderId], [CusId], [status], [TotalAmount], [OrderDate], [EmpId]) VALUES (13, 12, N'Pending', 7888, CAST(N'2026-01-18T23:37:03.893' AS DateTime), NULL)
GO
INSERT [dbo].[Cusorder] ([OrderId], [CusId], [status], [TotalAmount], [OrderDate], [EmpId]) VALUES (14, 11, N'Pending', 7888, CAST(N'2026-01-19T00:00:05.947' AS DateTime), NULL)
GO
INSERT [dbo].[Cusorder] ([OrderId], [CusId], [status], [TotalAmount], [OrderDate], [EmpId]) VALUES (15, 11, N'Pending', 7888, CAST(N'2026-01-19T00:31:46.043' AS DateTime), NULL)
GO
INSERT [dbo].[Cusorder] ([OrderId], [CusId], [status], [TotalAmount], [OrderDate], [EmpId]) VALUES (16, 11, N'Pending', 6000, CAST(N'2026-01-19T00:48:55.410' AS DateTime), NULL)
GO
INSERT [dbo].[Cusorder] ([OrderId], [CusId], [status], [TotalAmount], [OrderDate], [EmpId]) VALUES (17, 11, N'Pending', 100, CAST(N'2026-01-19T01:14:45.327' AS DateTime), NULL)
GO
INSERT [dbo].[Cusorder] ([OrderId], [CusId], [status], [TotalAmount], [OrderDate], [EmpId]) VALUES (18, 11, N'Pending', 678, CAST(N'2026-01-20T00:18:47.997' AS DateTime), NULL)
GO
INSERT [dbo].[Cusorder] ([OrderId], [CusId], [status], [TotalAmount], [OrderDate], [EmpId]) VALUES (19, 11, N'Completed', 7888, CAST(N'2026-01-20T00:56:01.000' AS DateTime), NULL)
GO
INSERT [dbo].[Cusorder] ([OrderId], [CusId], [status], [TotalAmount], [OrderDate], [EmpId]) VALUES (20, 11, N'Completed', 678, CAST(N'2026-01-20T01:29:27.000' AS DateTime), NULL)
GO
INSERT [dbo].[Cusorder] ([OrderId], [CusId], [status], [TotalAmount], [OrderDate], [EmpId]) VALUES (21, 11, N'Completed', 6780, CAST(N'2026-01-22T01:43:41.000' AS DateTime), NULL)
GO
SET IDENTITY_INSERT [dbo].[Cusorder] OFF
GO
SET IDENTITY_INSERT [dbo].[Menu] ON 
GO
INSERT [dbo].[Menu] ([MenuID], [CatagoryId], [FoodName], [Price], [AvailableQuantity], [ImagePath]) VALUES (1, 1, N'alu', 2000, 4, NULL)
GO
INSERT [dbo].[Menu] ([MenuID], [CatagoryId], [FoodName], [Price], [AvailableQuantity], [ImagePath]) VALUES (3, 2, N'apple', 100, 5, NULL)
GO
INSERT [dbo].[Menu] ([MenuID], [CatagoryId], [FoodName], [Price], [AvailableQuantity], [ImagePath]) VALUES (4, 3, N'banana', 89, 9, NULL)
GO
INSERT [dbo].[Menu] ([MenuID], [CatagoryId], [FoodName], [Price], [AvailableQuantity], [ImagePath]) VALUES (5, 1, N'jush', 90, 7, NULL)
GO
INSERT [dbo].[Menu] ([MenuID], [CatagoryId], [FoodName], [Price], [AvailableQuantity], [ImagePath]) VALUES (6, 6, N'cake', 100, 100, NULL)
GO
INSERT [dbo].[Menu] ([MenuID], [CatagoryId], [FoodName], [Price], [AvailableQuantity], [ImagePath]) VALUES (9, 3, N'YO YO Potol', 7000, 200, NULL)
GO
INSERT [dbo].[Menu] ([MenuID], [CatagoryId], [FoodName], [Price], [AvailableQuantity], [ImagePath]) VALUES (10, 4, N'angur', 100, 2112, NULL)
GO
SET IDENTITY_INSERT [dbo].[Menu] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderItem] ON 
GO
INSERT [dbo].[OrderItem] ([OrderItemId], [OrderId], [MenuId], [Quantity], [Price]) VALUES (1, 1, 1, 2, 5000)
GO
INSERT [dbo].[OrderItem] ([OrderItemId], [OrderId], [MenuId], [Quantity], [Price]) VALUES (5, 20, 4, 6, 5000)
GO
INSERT [dbo].[OrderItem] ([OrderItemId], [OrderId], [MenuId], [Quantity], [Price]) VALUES (6, 14, 3, 50, 6000)
GO
INSERT [dbo].[OrderItem] ([OrderItemId], [OrderId], [MenuId], [Quantity], [Price]) VALUES (7, 17, 5, 10, 7888)
GO
INSERT [dbo].[OrderItem] ([OrderItemId], [OrderId], [MenuId], [Quantity], [Price]) VALUES (10, 15, 6, 1, 678)
GO
INSERT [dbo].[OrderItem] ([OrderItemId], [OrderId], [MenuId], [Quantity], [Price]) VALUES (11, 1, 3, 6, 100)
GO
INSERT [dbo].[OrderItem] ([OrderItemId], [OrderId], [MenuId], [Quantity], [Price]) VALUES (13, 1, 4, 80, 89)
GO
INSERT [dbo].[OrderItem] ([OrderItemId], [OrderId], [MenuId], [Quantity], [Price]) VALUES (15, 11, 4, 9, 89)
GO
INSERT [dbo].[OrderItem] ([OrderItemId], [OrderId], [MenuId], [Quantity], [Price]) VALUES (16, 12, 1, 9, 89)
GO
INSERT [dbo].[OrderItem] ([OrderItemId], [OrderId], [MenuId], [Quantity], [Price]) VALUES (17, 9, 3, 8, 100)
GO
INSERT [dbo].[OrderItem] ([OrderItemId], [OrderId], [MenuId], [Quantity], [Price]) VALUES (20, 14, 1, 90, 100)
GO
INSERT [dbo].[OrderItem] ([OrderItemId], [OrderId], [MenuId], [Quantity], [Price]) VALUES (21, 17, 1, 9, 100)
GO
INSERT [dbo].[OrderItem] ([OrderItemId], [OrderId], [MenuId], [Quantity], [Price]) VALUES (22, 20, 1, 42, 89)
GO
INSERT [dbo].[OrderItem] ([OrderItemId], [OrderId], [MenuId], [Quantity], [Price]) VALUES (23, 1, 1, 8, 89)
GO
INSERT [dbo].[OrderItem] ([OrderItemId], [OrderId], [MenuId], [Quantity], [Price]) VALUES (27, 16, 1, 8, 90)
GO
INSERT [dbo].[OrderItem] ([OrderItemId], [OrderId], [MenuId], [Quantity], [Price]) VALUES (28, 17, 1, 8, 100)
GO
INSERT [dbo].[OrderItem] ([OrderItemId], [OrderId], [MenuId], [Quantity], [Price]) VALUES (29, 1, 1, 8, 89)
GO
INSERT [dbo].[OrderItem] ([OrderItemId], [OrderId], [MenuId], [Quantity], [Price]) VALUES (30, 21, 1, 5, 89)
GO
INSERT [dbo].[OrderItem] ([OrderItemId], [OrderId], [MenuId], [Quantity], [Price]) VALUES (31, 19, 1, 8, 100)
GO
INSERT [dbo].[OrderItem] ([OrderItemId], [OrderId], [MenuId], [Quantity], [Price]) VALUES (33, 1, 1, 8, 90)
GO
SET IDENTITY_INSERT [dbo].[OrderItem] OFF
GO
SET IDENTITY_INSERT [dbo].[Rating] ON 
GO
INSERT [dbo].[Rating] ([RatingID], [CustomerID], [OrderID], [RatingStars], [Comment]) VALUES (1, 12, 13, 4, N'Meow')
GO
INSERT [dbo].[Rating] ([RatingID], [CustomerID], [OrderID], [RatingStars], [Comment]) VALUES (4, 11, 17, 3, N'Chata')
GO
INSERT [dbo].[Rating] ([RatingID], [CustomerID], [OrderID], [RatingStars], [Comment]) VALUES (5, 12, 12, 1, N'Shit')
GO
INSERT [dbo].[Rating] ([RatingID], [CustomerID], [OrderID], [RatingStars], [Comment]) VALUES (6, 11, 19, 5, N'YO YO')
GO
INSERT [dbo].[Rating] ([RatingID], [CustomerID], [OrderID], [RatingStars], [Comment]) VALUES (8, 11, 15, 2, N'Mmmmm')
GO
SET IDENTITY_INSERT [dbo].[Rating] OFF
GO
SET IDENTITY_INSERT [dbo].[Registration] ON 
GO
INSERT [dbo].[Registration] ([ID], [Name], [Password], [Phone], [email], [UserType], [Salary]) VALUES (1, N'Farhan HAsin', N'1234', N'01922221', N'hasin@mail.com', N'Admin', NULL)
GO
INSERT [dbo].[Registration] ([ID], [Name], [Password], [Phone], [email], [UserType], [Salary]) VALUES (2, N'ahmed hjan ', N'43356', N'017112332', N'farhan@gmail.com', N'Emp', NULL)
GO
INSERT [dbo].[Registration] ([ID], [Name], [Password], [Phone], [email], [UserType], [Salary]) VALUES (4, N'{Name}', N'{Password}', N'{Phone}', N'{Email}', N'NULL', NULL)
GO
INSERT [dbo].[Registration] ([ID], [Name], [Password], [Phone], [email], [UserType], [Salary]) VALUES (5, N'Registration', N'1234', N'01922312', N'sijan@gmail.com', N'NULL', NULL)
GO
INSERT [dbo].[Registration] ([ID], [Name], [Password], [Phone], [email], [UserType], [Salary]) VALUES (6, N'sadasdas', N'asd', N'asdasdas', N'asd', N'NULL', NULL)
GO
INSERT [dbo].[Registration] ([ID], [Name], [Password], [Phone], [email], [UserType], [Salary]) VALUES (7, N'sijan', N'12', N'sadasd', N'sadasdsdas', N'Emp', NULL)
GO
INSERT [dbo].[Registration] ([ID], [Name], [Password], [Phone], [email], [UserType], [Salary]) VALUES (9, N'farhan12345', N'asdf', N'019234234234', N'farhan12345@gmail.com', N'NULL', NULL)
GO
INSERT [dbo].[Registration] ([ID], [Name], [Password], [Phone], [email], [UserType], [Salary]) VALUES (10, N'abcsd', N'1234', N'123312423423', N'abcd@.com', N'Emp', NULL)
GO
INSERT [dbo].[Registration] ([ID], [Name], [Password], [Phone], [email], [UserType], [Salary]) VALUES (11, N'vcxz', N'1234', N'12334234', N'asd@.com', N'Customer', NULL)
GO
INSERT [dbo].[Registration] ([ID], [Name], [Password], [Phone], [email], [UserType], [Salary]) VALUES (12, N'anisha ', N'1234', N'21214333453', N'anisha@.com', N'Customer', NULL)
GO
INSERT [dbo].[Registration] ([ID], [Name], [Password], [Phone], [email], [UserType], [Salary]) VALUES (14, N'asd', N'asd', N'12321321', N'asd@gmail.com', N'Customer', 0)
GO
INSERT [dbo].[Registration] ([ID], [Name], [Password], [Phone], [email], [UserType], [Salary]) VALUES (18, N'hhjghjghj', N'677', N'01234567890', N'986756@.com', N'Emp', 900)
GO
INSERT [dbo].[Registration] ([ID], [Name], [Password], [Phone], [email], [UserType], [Salary]) VALUES (19, N'tyfghfjv', N'88', N'8867456789', N'jhgfv@.com', N'Emp', NULL)
GO
INSERT [dbo].[Registration] ([ID], [Name], [Password], [Phone], [email], [UserType], [Salary]) VALUES (21, N'{name}', N'123', N'{contact}', N'{email}', N'{role}', NULL)
GO
INSERT [dbo].[Registration] ([ID], [Name], [Password], [Phone], [email], [UserType], [Salary]) VALUES (22, N'{name}', N'123', N'O12345', N'mmmmm@.com', N'Emp', 233)
GO
INSERT [dbo].[Registration] ([ID], [Name], [Password], [Phone], [email], [UserType], [Salary]) VALUES (26, N'Mahmudul', N'000', N'01234567981', N'mahmudul@gmail.com', N'Emp', 90000)
GO
INSERT [dbo].[Registration] ([ID], [Name], [Password], [Phone], [email], [UserType], [Salary]) VALUES (27, N'Mahmudul', N'212121', N'01234567891', N'mahmudul123@gmail.com', N'Customer', NULL)
GO
INSERT [dbo].[Registration] ([ID], [Name], [Password], [Phone], [email], [UserType], [Salary]) VALUES (28, N'YO YO POTOLA', N'1234', N'01234567899', N'yoyo@gmail.com', N'Customer', 0)
GO
INSERT [dbo].[Registration] ([ID], [Name], [Password], [Phone], [email], [UserType], [Salary]) VALUES (29, N'Sijan', N'000', N'09123456789', N'hftgnnbg@.com', N'Emp', 5600)
GO
INSERT [dbo].[Registration] ([ID], [Name], [Password], [Phone], [email], [UserType], [Salary]) VALUES (30, N'Simin', N'1234', N'01234565678', N'simin@gmail.com', N'Customer', NULL)
GO
SET IDENTITY_INSERT [dbo].[Registration] OFF
GO
ALTER TABLE [dbo].[Cusorder]  WITH CHECK ADD  CONSTRAINT [FK_Order_Registration] FOREIGN KEY([CusId])
REFERENCES [dbo].[Registration] ([ID])
GO
ALTER TABLE [dbo].[Cusorder] CHECK CONSTRAINT [FK_Order_Registration]
GO
ALTER TABLE [dbo].[Cusorder]  WITH CHECK ADD  CONSTRAINT [FK_Order_Registration1] FOREIGN KEY([EmpId])
REFERENCES [dbo].[Registration] ([ID])
GO
ALTER TABLE [dbo].[Cusorder] CHECK CONSTRAINT [FK_Order_Registration1]
GO
ALTER TABLE [dbo].[Menu]  WITH CHECK ADD  CONSTRAINT [FK_Menu_Category] FOREIGN KEY([CatagoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
ALTER TABLE [dbo].[Menu] CHECK CONSTRAINT [FK_Menu_Category]
GO
ALTER TABLE [dbo].[OrderItem]  WITH CHECK ADD  CONSTRAINT [FK_OrderItem_Menu] FOREIGN KEY([MenuId])
REFERENCES [dbo].[Menu] ([MenuID])
GO
ALTER TABLE [dbo].[OrderItem] CHECK CONSTRAINT [FK_OrderItem_Menu]
GO
ALTER TABLE [dbo].[OrderItem]  WITH CHECK ADD  CONSTRAINT [FK_OrderItem_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Cusorder] ([OrderId])
GO
ALTER TABLE [dbo].[OrderItem] CHECK CONSTRAINT [FK_OrderItem_Order]
GO
ALTER TABLE [dbo].[Rating]  WITH CHECK ADD  CONSTRAINT [FK_Rating_Cusorder] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Cusorder] ([OrderId])
GO
ALTER TABLE [dbo].[Rating] CHECK CONSTRAINT [FK_Rating_Cusorder]
GO
ALTER TABLE [dbo].[Rating]  WITH CHECK ADD  CONSTRAINT [FK_Rating_Registration] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Registration] ([ID])
GO
ALTER TABLE [dbo].[Rating] CHECK CONSTRAINT [FK_Rating_Registration]
GO
