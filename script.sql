USE [Test]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 08-Jul-20 10:01:09 AM ******/
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
/****** Object:  Table [dbo].[Classes]    Script Date: 08-Jul-20 10:01:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Classes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schedules]    Script Date: 08-Jul-20 10:01:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedules](
	[SubjectId] [int] NOT NULL,
	[ClassId] [int] NOT NULL,
	[DayOfWeek] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Schedules] PRIMARY KEY CLUSTERED 
(
	[ClassId] ASC,
	[SubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 08-Jul-20 10:01:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[ClassId] [int] NULL,
	[DateOfBirth] [nvarchar](max) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 08-Jul-20 10:01:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Subjects] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200708025436_initialcreate', N'3.1.5')
GO
SET IDENTITY_INSERT [dbo].[Classes] ON 

INSERT [dbo].[Classes] ([Id], [Name], [Active]) VALUES (1, N'Class1', 1)
INSERT [dbo].[Classes] ([Id], [Name], [Active]) VALUES (2, N'Class2', 1)
SET IDENTITY_INSERT [dbo].[Classes] OFF
GO
INSERT [dbo].[Schedules] ([SubjectId], [ClassId], [DayOfWeek], [Name], [Active]) VALUES (1, 1, 1, N'S1', 1)
INSERT [dbo].[Schedules] ([SubjectId], [ClassId], [DayOfWeek], [Name], [Active]) VALUES (2, 1, 1, N'S2', 1)
INSERT [dbo].[Schedules] ([SubjectId], [ClassId], [DayOfWeek], [Name], [Active]) VALUES (3, 1, 1, N'S3', 1)
INSERT [dbo].[Schedules] ([SubjectId], [ClassId], [DayOfWeek], [Name], [Active]) VALUES (6, 1, 2, N'S6', 1)
INSERT [dbo].[Schedules] ([SubjectId], [ClassId], [DayOfWeek], [Name], [Active]) VALUES (4, 2, 1, N'S4', 1)
INSERT [dbo].[Schedules] ([SubjectId], [ClassId], [DayOfWeek], [Name], [Active]) VALUES (6, 2, 1, N'S5', 1)
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [ClassId], [DateOfBirth], [Active]) VALUES (1, N'A', NULL, 1, NULL, 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [ClassId], [DateOfBirth], [Active]) VALUES (2, N'B', NULL, 1, NULL, 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [ClassId], [DateOfBirth], [Active]) VALUES (3, N'C', NULL, 1, NULL, 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [ClassId], [DateOfBirth], [Active]) VALUES (4, N'D', NULL, 2, NULL, 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [ClassId], [DateOfBirth], [Active]) VALUES (5, N'E', NULL, 2, NULL, 1)
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
SET IDENTITY_INSERT [dbo].[Subjects] ON 

INSERT [dbo].[Subjects] ([Id], [Name], [Active]) VALUES (1, N'Math', 1)
INSERT [dbo].[Subjects] ([Id], [Name], [Active]) VALUES (2, N'Literature', 1)
INSERT [dbo].[Subjects] ([Id], [Name], [Active]) VALUES (3, N'Physics', 1)
INSERT [dbo].[Subjects] ([Id], [Name], [Active]) VALUES (4, N'English', 1)
INSERT [dbo].[Subjects] ([Id], [Name], [Active]) VALUES (6, N'Japanese', 1)
SET IDENTITY_INSERT [dbo].[Subjects] OFF
GO
ALTER TABLE [dbo].[Schedules]  WITH CHECK ADD  CONSTRAINT [FK_Schedules_Classes_ClassId] FOREIGN KEY([ClassId])
REFERENCES [dbo].[Classes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Schedules] CHECK CONSTRAINT [FK_Schedules_Classes_ClassId]
GO
ALTER TABLE [dbo].[Schedules]  WITH CHECK ADD  CONSTRAINT [FK_Schedules_Subjects_SubjectId] FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subjects] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Schedules] CHECK CONSTRAINT [FK_Schedules_Subjects_SubjectId]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Classes_ClassId] FOREIGN KEY([ClassId])
REFERENCES [dbo].[Classes] ([Id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Classes_ClassId]
GO
