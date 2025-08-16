CREATE TABLE [Contabancofordev] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Contacorrente] VARCHAR (100) DEFAULT ('') NOT NULL UNIQUE,
    [Agencia] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Banco] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Cidade] VARCHAR (150) DEFAULT ('') NOT NULL,
    [Estado] CHAR (2)      DEFAULT ('') NOT NULL
);
