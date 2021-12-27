USE [demoPractical]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 11/10/2020 10:57:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[uId] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](50) NULL,
	[math] [float] NULL,
	[literature] [float] NULL,
	[active] [tinyint] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([uId], [name], [math], [literature], [active]) VALUES (1, N'Hua Quoc Vinh                                     ', 10, 10, 1)
INSERT [dbo].[Student] ([uId], [name], [math], [literature], [active]) VALUES (2, N'Tang Minh Tin                                     ', 10, 1, 1)
INSERT [dbo].[Student] ([uId], [name], [math], [literature], [active]) VALUES (3, N'Bach Nguyen Phuc Thinh                            ', 10, 5, 1)
INSERT [dbo].[Student] ([uId], [name], [math], [literature], [active]) VALUES (4, N'Truong Nhat Nam                                   ', 8, 5, 0)
INSERT [dbo].[Student] ([uId], [name], [math], [literature], [active]) VALUES (5, N'dsfsd                                             ', 3, 2, 1)
INSERT [dbo].[Student] ([uId], [name], [math], [literature], [active]) VALUES (6, N'dsfsd                                             ', 10, 2, 1)
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
