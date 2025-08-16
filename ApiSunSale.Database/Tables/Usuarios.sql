CREATE TABLE [Usuarios](
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	[Login] [varchar](50) NOT NULL,
	[Pass] [varchar](12) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Email] [varchar](300) NULL,
	[Datanascimento] [date] NULL,
	[Admin] [char](1) NULL,
	[Instituicao] [nvarchar](255)
);