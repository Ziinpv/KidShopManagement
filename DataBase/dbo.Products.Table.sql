USE [KidShopManagement]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 11/20/2024 2:25:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Size] [nvarchar](50) NOT NULL,
	[ProductsCategory] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Prices] [nvarchar](50) NOT NULL,
	[Image] [image] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
