CREATE TABLE [Usuarioscrudforms] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
    [IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Login] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Senha] VARCHAR (20)  DEFAULT ('') NOT NULL,
    [Administrador] CHAR (1)      DEFAULT ('0') NOT NULL,
    [Desenvolvedor] CHAR (1)      DEFAULT ('0') NOT NULL,
    [Email] VARCHAR (200) DEFAULT ('') NOT NULL,
    [Usuariopai] [bigint]           DEFAULT ((-1)) NOT NULL,
    Nome            varchar(100)
);
