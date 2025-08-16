CREATE TABLE [Acaousuario] (
    [Id] [bigint] IDENTITY(1,1)           NOT NULL,
    [IdUsuario] [bigint]           DEFAULT ((0)) NOT NULL,
    [Acao] VARCHAR (200) DEFAULT ('') NOT NULL,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    
    FOREIGN KEY ([IdUsuario]) REFERENCES [USUARIOS]([Id])
);
