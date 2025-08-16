CREATE TABLE [dbo].[Avaliacao]
(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Nome] NVARCHAR(255) not null,
    [Orientação] NVARCHAR(MAX),
    [Ispublic] char(1) default '1' not null,
    [Key] nvarchar(64) 
)