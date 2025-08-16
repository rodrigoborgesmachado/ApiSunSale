CREATE TABLE [dbo].[Questoesavaliacao]
(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	[IdAvaliacao] [bigint] not null,
	[IdQuestao] [bigint] not null,
	[Notaquestao] decimal(10,2) default 1
)