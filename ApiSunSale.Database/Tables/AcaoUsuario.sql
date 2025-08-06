CREATE TABLE [Acaousuario] (
    [Codigo] [bigint IDENTITY(1,1)]           NOT NULL,
    [Codigousuario] [bigint IDENTITY(1,1)]           DEFAULT ((0)) NOT NULL,
    [Acao] VARCHAR (200) DEFAULT ('') NOT NULL,
    [Dataregistro] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);
