USE [dbDemo]
GO
/****** Object:  Table [dbo].[tbDemo]    Script Date: 10/26/2020 7:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbDemo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[uName] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDienThoai] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbDemo] ON 

INSERT [dbo].[tbDemo] ([ID], [uName], [DiaChi], [SoDienThoai]) VALUES (1, N'Bao', N'Vinh Long', N'097635303')
INSERT [dbo].[tbDemo] ([ID], [uName], [DiaChi], [SoDienThoai]) VALUES (2, N'Dang', N'Ca Mau', N'0909789789')
INSERT [dbo].[tbDemo] ([ID], [uName], [DiaChi], [SoDienThoai]) VALUES (3, N'Hao', N'Ca Mau', N'0523456789')
INSERT [dbo].[tbDemo] ([ID], [uName], [DiaChi], [SoDienThoai]) VALUES (4, N'Ngan', N'Vinh Long', N'093928935')
INSERT [dbo].[tbDemo] ([ID], [uName], [DiaChi], [SoDienThoai]) VALUES (5, N'mmmmm', N'Vinh Long', N'')
INSERT [dbo].[tbDemo] ([ID], [uName], [DiaChi], [SoDienThoai]) VALUES (6, N'mmmmm', N'Vinh Long', N'')
INSERT [dbo].[tbDemo] ([ID], [uName], [DiaChi], [SoDienThoai]) VALUES (7, N'mmmmm', N'Vinh Long', N'')
INSERT [dbo].[tbDemo] ([ID], [uName], [DiaChi], [SoDienThoai]) VALUES (8, N'mmmmm', N'Vinh Long', N'')
INSERT [dbo].[tbDemo] ([ID], [uName], [DiaChi], [SoDienThoai]) VALUES (9, N'mmmmm', N'Vinh Long', N'')
INSERT [dbo].[tbDemo] ([ID], [uName], [DiaChi], [SoDienThoai]) VALUES (10, N'mmmmm', N'Vinh Long', N'')
INSERT [dbo].[tbDemo] ([ID], [uName], [DiaChi], [SoDienThoai]) VALUES (11, N'mmmmm', N'Vinh Long', N'')
INSERT [dbo].[tbDemo] ([ID], [uName], [DiaChi], [SoDienThoai]) VALUES (12, N'mmmmm', N'Vinh Long', N'')
SET IDENTITY_INSERT [dbo].[tbDemo] OFF
GO
