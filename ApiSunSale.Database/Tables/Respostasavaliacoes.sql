CREATE TABLE [dbo].[Respostasavaliacoes]
(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	[Createdby] [bigint] not null,
	[Updatedby] [bigint] not null,
	[Idavaliacao] [bigint] not null,
	[Idquestao] [bigint] not null,
	[Idresposta] [bigint] not null,
)