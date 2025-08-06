CREATE TABLE [Imagensbioma] (
    [Id] [bigint] IDENTITY(1,1)           NOT NULL,
    [Idbioma] [bigint]           NOT NULL,
    [Caminho] VARCHAR (300) NULL,
    [Idusuario] [bigint]           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Idbioma]) REFERENCES [BIOMAS] ([Id]),
    FOREIGN KEY ([Idusuario]) REFERENCES [USUARIOS] ([Id])
);
