CREATE TABLE [Email] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Destinatario] VARCHAR (300)   DEFAULT ('') NOT NULL,
    [Assunto] VARCHAR (300)   DEFAULT ('') NOT NULL,
    [Texto] VARCHAR (MAX) NULL,
    [Status] CHAR (1)        DEFAULT ('0') NOT NULL,
    [Observacao] VARCHAR (1000)  NULL
);
