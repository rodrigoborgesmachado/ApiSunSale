CREATE TABLE [dbo].[Resultadostabuadadivertida]
(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	Nome varchar(300) not null,
	Tempo int not null,
	NumeroAcertos int not null,
	Tipo char(1),
	NumeroQuestoes int
)