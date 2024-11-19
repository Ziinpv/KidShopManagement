USE [KidShopManagement]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 11/20/2024 2:25:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
	[Path] [nvarchar](50) NULL,
	[Notes] [nvarchar](50) NULL
) ON [PRIMARY]
GO
