USE [master]
GO
/****** Object:  Database [Assignment_PRN]    Script Date: 7/11/2022 8:12:26 PM ******/
CREATE DATABASE [Assignment_PRN]
ALTER DATABASE [Assignment_PRN] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Assignment_PRN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Assignment_PRN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Assignment_PRN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Assignment_PRN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Assignment_PRN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Assignment_PRN] SET ARITHABORT OFF 
GO
ALTER DATABASE [Assignment_PRN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Assignment_PRN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Assignment_PRN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Assignment_PRN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Assignment_PRN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Assignment_PRN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Assignment_PRN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Assignment_PRN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Assignment_PRN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Assignment_PRN] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Assignment_PRN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Assignment_PRN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Assignment_PRN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Assignment_PRN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Assignment_PRN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Assignment_PRN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Assignment_PRN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Assignment_PRN] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Assignment_PRN] SET  MULTI_USER 
GO
ALTER DATABASE [Assignment_PRN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Assignment_PRN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Assignment_PRN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Assignment_PRN] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Assignment_PRN] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Assignment_PRN] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Assignment_PRN] SET QUERY_STORE = OFF
GO
USE [Assignment_PRN]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 7/11/2022 8:12:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Answer]    Script Date: 7/11/2022 8:12:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Answer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[answerContent] [nvarchar](max) NULL,
	[questionId] [int] NULL,
 CONSTRAINT [PK_Answer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CorrectAnswers]    Script Date: 7/11/2022 8:12:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CorrectAnswers](
	[questionId] [int] NOT NULL,
	[answerId] [int] NOT NULL,
 CONSTRAINT [PK_CorrectAnswers] PRIMARY KEY CLUSTERED 
(
	[questionId] ASC,
	[answerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questions]    Script Date: 7/11/2022 8:12:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questions](
	[qid] [int] IDENTITY(1,1) NOT NULL,
	[qContent] [nvarchar](max) NULL,
	[testId] [int] NULL,
 CONSTRAINT [PK_Questions] PRIMARY KEY CLUSTERED 
(
	[qid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Results]    Script Date: 7/11/2022 8:12:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Results](
	[accountId] [int] NOT NULL,
	[testID] [int] NOT NULL,
	[score] [decimal](20, 0) NULL,
 CONSTRAINT [PK_Results] PRIMARY KEY CLUSTERED 
(
	[accountId] ASC,
	[testID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestName]    Script Date: 7/11/2022 8:12:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestName](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[testCode] [nvarchar](100) NOT NULL,
	[duration] [int] NULL,
 CONSTRAINT [PK_TestName] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 
GO
INSERT [dbo].[Account] ([id], [username], [password]) VALUES (1, N'luongnthhe151453', N'123456')
GO
INSERT [dbo].[Account] ([id], [username], [password]) VALUES (2, N'Tienvd', N'123')
GO
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[Answer] ON 
GO
INSERT [dbo].[Answer] ([id], [answerContent], [questionId]) VALUES (1, N'Yes', 1)
GO
INSERT [dbo].[Answer] ([id], [answerContent], [questionId]) VALUES (2, N'Rất xinh và tốt bụng', 1)
GO
INSERT [dbo].[Answer] ([id], [answerContent], [questionId]) VALUES (3, N'Không', 1)
GO
INSERT [dbo].[Answer] ([id], [answerContent], [questionId]) VALUES (4, N'Chả xinh tẹo nào', 1)
GO
INSERT [dbo].[Answer] ([id], [answerContent], [questionId]) VALUES (5, N'Tuyệt vời', 2)
GO
INSERT [dbo].[Answer] ([id], [answerContent], [questionId]) VALUES (6, N'Trên cả tuyệt vời', 2)
GO
INSERT [dbo].[Answer] ([id], [answerContent], [questionId]) VALUES (7, N'Không ai dạy hay bằng cô!!', 2)
GO
INSERT [dbo].[Answer] ([id], [answerContent], [questionId]) VALUES (8, N'All answers are correct.', 2)
GO
INSERT [dbo].[Answer] ([id], [answerContent], [questionId]) VALUES (9, N'Tất nhiên là không :))', 3)
GO
INSERT [dbo].[Answer] ([id], [answerContent], [questionId]) VALUES (10, N'Không', 3)
GO
INSERT [dbo].[Answer] ([id], [answerContent], [questionId]) VALUES (11, N'Yêu cô rất nhiều', 3)
GO
INSERT [dbo].[Answer] ([id], [answerContent], [questionId]) VALUES (12, N'Chả bao giờ', 3)
GO
INSERT [dbo].[Answer] ([id], [answerContent], [questionId]) VALUES (13, N'Khó', 4)
GO
INSERT [dbo].[Answer] ([id], [answerContent], [questionId]) VALUES (14, N'Cô Chi dạy sẽ không khó', 4)
GO
INSERT [dbo].[Answer] ([id], [answerContent], [questionId]) VALUES (15, N'Không khó gì cả', 4)
GO
INSERT [dbo].[Answer] ([id], [answerContent], [questionId]) VALUES (16, N'Khó với ai lười', 4)
GO
INSERT [dbo].[Answer] ([id], [answerContent], [questionId]) VALUES (17, N'Chi sensei là số 1', 5)
GO
INSERT [dbo].[Answer] ([id], [answerContent], [questionId]) VALUES (18, N'Thầy BanTQ', 5)
GO
INSERT [dbo].[Answer] ([id], [answerContent], [questionId]) VALUES (19, N'Thầy aa', 5)
GO
INSERT [dbo].[Answer] ([id], [answerContent], [questionId]) VALUES (20, N'Cô B', 5)
GO
INSERT [dbo].[Answer] ([id], [answerContent], [questionId]) VALUES (21, N'Of course yes!', 6)
GO
INSERT [dbo].[Answer] ([id], [answerContent], [questionId]) VALUES (22, N'No', 6)
GO
INSERT [dbo].[Answer] ([id], [answerContent], [questionId]) VALUES (23, N'Nerver', 6)
GO
INSERT [dbo].[Answer] ([id], [answerContent], [questionId]) VALUES (24, N'Không muốn đâu -.-', 6)
GO
INSERT [dbo].[Answer] ([id], [answerContent], [questionId]) VALUES (25, N'Ms C', 6)
GO
SET IDENTITY_INSERT [dbo].[Answer] OFF
GO
INSERT [dbo].[CorrectAnswers] ([questionId], [answerId]) VALUES (1, 2)
GO
INSERT [dbo].[CorrectAnswers] ([questionId], [answerId]) VALUES (2, 8)
GO
INSERT [dbo].[CorrectAnswers] ([questionId], [answerId]) VALUES (3, 11)
GO
INSERT [dbo].[CorrectAnswers] ([questionId], [answerId]) VALUES (4, 14)
GO
INSERT [dbo].[CorrectAnswers] ([questionId], [answerId]) VALUES (4, 16)
GO
INSERT [dbo].[CorrectAnswers] ([questionId], [answerId]) VALUES (5, 17)
GO
INSERT [dbo].[CorrectAnswers] ([questionId], [answerId]) VALUES (6, 21)
GO
SET IDENTITY_INSERT [dbo].[Questions] ON 
GO
INSERT [dbo].[Questions] ([qid], [qContent], [testId]) VALUES (1, N'Cô Chi xinh gái?', 1)
GO
INSERT [dbo].[Questions] ([qid], [qContent], [testId]) VALUES (2, N'Cô Chi dạy PRN có hay không?', 1)
GO
INSERT [dbo].[Questions] ([qid], [qContent], [testId]) VALUES (3, N'Bạn có yêu cô Chi không?', 1)
GO
INSERT [dbo].[Questions] ([qid], [qContent], [testId]) VALUES (4, N'PRN có khó không?', 1)
GO
INSERT [dbo].[Questions] ([qid], [qContent], [testId]) VALUES (5, N'Bạn thích ai dạy PRN', 1)
GO
INSERT [dbo].[Questions] ([qid], [qContent], [testId]) VALUES (6, N'SE1514 có muốn học cô Chi tiếp khôn?', 1)
GO
SET IDENTITY_INSERT [dbo].[Questions] OFF
GO
INSERT [dbo].[Results] ([accountId], [testID], [score]) VALUES (1, 1, CAST(0 AS Decimal(20, 0)))
GO
INSERT [dbo].[Results] ([accountId], [testID], [score]) VALUES (2, 1, CAST(10 AS Decimal(20, 0)))
GO
SET IDENTITY_INSERT [dbo].[TestName] ON 
GO
INSERT [dbo].[TestName] ([id], [testCode], [duration]) VALUES (1, N'PRN211', 10)
GO
SET IDENTITY_INSERT [dbo].[TestName] OFF
GO
ALTER TABLE [dbo].[CorrectAnswers]  WITH CHECK ADD  CONSTRAINT [FK_CorrectAnswers_Answer] FOREIGN KEY([answerId])
REFERENCES [dbo].[Answer] ([id])
GO
ALTER TABLE [dbo].[CorrectAnswers] CHECK CONSTRAINT [FK_CorrectAnswers_Answer]
GO
ALTER TABLE [dbo].[CorrectAnswers]  WITH CHECK ADD  CONSTRAINT [FK_CorrectAnswers_Questions] FOREIGN KEY([questionId])
REFERENCES [dbo].[Questions] ([qid])
GO
ALTER TABLE [dbo].[CorrectAnswers] CHECK CONSTRAINT [FK_CorrectAnswers_Questions]
GO
ALTER TABLE [dbo].[Questions]  WITH CHECK ADD  CONSTRAINT [FK_Questions_TestName] FOREIGN KEY([testId])
REFERENCES [dbo].[TestName] ([id])
GO
ALTER TABLE [dbo].[Questions] CHECK CONSTRAINT [FK_Questions_TestName]
GO
ALTER TABLE [dbo].[Results]  WITH CHECK ADD  CONSTRAINT [FK_Results_Account] FOREIGN KEY([accountId])
REFERENCES [dbo].[Account] ([id])
GO
ALTER TABLE [dbo].[Results] CHECK CONSTRAINT [FK_Results_Account]
GO
ALTER TABLE [dbo].[Results]  WITH CHECK ADD  CONSTRAINT [FK_Results_TestName] FOREIGN KEY([testID])
REFERENCES [dbo].[TestName] ([id])
GO
ALTER TABLE [dbo].[Results] CHECK CONSTRAINT [FK_Results_TestName]
GO
USE [master]
GO
ALTER DATABASE [Assignment_PRN] SET  READ_WRITE 
GO
