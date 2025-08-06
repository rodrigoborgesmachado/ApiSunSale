CREATE TABLE [dbo].[Avaliacao]
(
	[Id] [bigint] IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Createdon] DATETIME not null,
    [Updatedon] DATETIME not null,
    [Createdby] [bigint] not null,
	[Updatedby] [bigint] not null,
    [Nome] NVARCHAR(255) not null,
    [Orientação] NVARCHAR(MAX),
    [Isactive] char(1) default '1' not null,
    [Ispublic] char(1) default '1' not null,
    [Key] nvarchar(64) 
)