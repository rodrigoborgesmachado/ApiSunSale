CREATE TABLE [Veiculosfordev] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
    [IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Marca] VARCHAR (300) DEFAULT ('') NOT NULL,
    [Modelo] VARCHAR (300) DEFAULT ('') NOT NULL,
    [Ano] VARCHAR (10)  DEFAULT ('') NOT NULL,
    [Renavam] VARCHAR (30)  DEFAULT ('') NOT NULL,
    [Placaveiculo] VARCHAR (20)  DEFAULT ('') NOT NULL,
    [Cor] VARCHAR (50)  DEFAULT ('') NOT NULL
);
