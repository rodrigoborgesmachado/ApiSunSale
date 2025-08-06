CREATE TABLE [dbo].[Questoesavaliacao]
(
	[Id] [bigint] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Createdon] DATETIME not null,
    [Createdby] [bigint] not null,
	[Idavaliacao] [bigint] not null,
	[Idquestao] [bigint] not null,
	[Notaquestao] decimal(10,2) default 1
)