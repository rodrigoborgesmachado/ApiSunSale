CREATE TABLE [Biomas] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Nome] VARCHAR (200)  NULL,
    [Distribuicao] VARCHAR (200)  NULL,
    [Caracteristicas] VARCHAR (8000) NULL,
    [Fitofisionomia] VARCHAR (8000) NULL,
    [Observacao] VARCHAR (8000) NULL,
    [Idusuario] [bigint]            NOT NULL,
    
    FOREIGN KEY ([Idusuario]) REFERENCES [Usuarios] ([Id])
);
