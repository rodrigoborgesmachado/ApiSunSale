CREATE TABLE [Biomas] (
    [Id] [bigint] IDENTITY(1,1)            NOT NULL,
    [Nome] VARCHAR (200)  NULL,
    [Distribuicao] VARCHAR (200)  NULL,
    [Caracteristicas] VARCHAR (8000) NULL,
    [Fitofisionomia] VARCHAR (8000) NULL,
    [Observacao] VARCHAR (8000) NULL,
    [Idusuario] [bigint]            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Idusuario]) REFERENCES [USUARIOS] ([Id])
);
