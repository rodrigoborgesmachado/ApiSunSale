CREATE TABLE [Palavras] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Nivel] [bigint]           NOT NULL,
    [Palavra] VARCHAR (100) NOT NULL,
    
    UNIQUE NONCLUSTERED ([Palavra] ASC)
);
