USE [Sicee]
GO

/****** Object:  Table [dbo].[cat_aulas]    Script Date: 02/01/2019 12:40:52 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[cat_aulas](
	[clave] [nvarchar](10) NOT NULL,
	[nombre] [nvarchar](25) NOT NULL,
	[capacidad] [smallint] NOT NULL,
	[descripcion] [nvarchar](100) NULL,
 CONSTRAINT [PK_cat_aulas] PRIMARY KEY CLUSTERED 
(
	[clave] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

