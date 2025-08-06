CREATE TABLE [Usuarioscrudforms] (
    [Codigo] [bigint IDENTITY(1,1)]           NOT NULL,
    [Login] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Senha] VARCHAR (20)  DEFAULT ('') NOT NULL,
    [Administrador] CHAR (1)      DEFAULT ('0') NOT NULL,
    [Desenvolvedor] CHAR (1)      DEFAULT ('0') NOT NULL,
    [Email] VARCHAR (200) DEFAULT ('') NOT NULL,
    [Usuariopai] [bigint]           DEFAULT ((-1)) NOT NULL,
    Nome            varchar(100),
    Created         DateTime      Default Getdate() not null,
    Updated         DateTime      Default Getdate() not null,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);
