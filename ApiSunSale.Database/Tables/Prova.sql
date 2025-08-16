CREATE TABLE [Prova] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Nomeprova] VARCHAR (500)   DEFAULT ('') NOT NULL,
    [Local] VARCHAR (500)   DEFAULT ('') NOT NULL,
    [Tipoprova] VARCHAR (100)   DEFAULT ('') NOT NULL,
    [Dataaplicacao] VARCHAR (10)    DEFAULT ('') NOT NULL,
    [Prova] VARCHAR (255) NULL,
    [Gabarito] VARCHAR (255) NULL,
    [Observacaoprova] VARCHAR (3000)  NULL,
    [Observacaogabarito] VARCHAR (2000)  DEFAULT ('') NOT NULL,
    [Dataregistro] DATETIME        NOT NULL,
    [Banca] VARCHAR (1000)  NULL,
    [Updatedby] [bigint],
    [Createdby] [bigint]
);
