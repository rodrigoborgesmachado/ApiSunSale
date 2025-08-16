CREATE TABLE [Questoes] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Campoquestao] VARCHAR (8000) DEFAULT ('') NOT NULL,
    [Observacaoquestao] VARCHAR (8000) DEFAULT ('') NOT NULL,
    [Materia] VARCHAR (300)  DEFAULT ('') NOT NULL,
    [IdProva] [bigint]            DEFAULT ((0)) NOT NULL,
    [Numeroquestao] VARCHAR (20)   NULL,
    [Updatedby] [bigint],
    [Createdby] [bigint],
    [Assunto] VARCHAR(255) NULL,
    FOREIGN KEY ([IdProva]) REFERENCES [Prova]([Id])
);
