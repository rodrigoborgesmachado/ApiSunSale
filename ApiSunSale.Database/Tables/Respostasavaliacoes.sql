CREATE TABLE [dbo].[Respostasavaliacoes]
(
	[Id] [bigint] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Createdon] DATETIME not null,
	[Updatedon] DATETIME not null,
	[Createdby] [bigint] not null,
	[Updatedby] [bigint] not null,
	[Idavaliacao] [bigint] not null,
	[Idquestao] [bigint] not null,
	[Idresposta] [bigint] not null,
)