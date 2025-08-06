CREATE TABLE [dbo].[Usuarios](
	[Id] [bigint IDENTITY(1,1)] NOT NULL,
	[Login] [varchar](50) NOT NULL,
	[Pass] [varchar](12) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Email] [varchar](300) NULL,
	[Datanascimento] [date] NULL,
	[Admin] [char](1) NULL,
	[Created] [datetime] NULL,
	[Updated] [datetime] NULL,
	[Instituicao] [nvarchar](255),
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Login] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Usuarios] ADD  DEFAULT ('0') FOR [Admin]
GO
