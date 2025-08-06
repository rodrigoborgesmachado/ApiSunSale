CREATE TABLE [Plantas] (
    [Id] [bigint IDENTITY(1,1)]            NOT NULL,
    [Idbioma] [bigint]            NOT NULL,
    [Nomecientifico] VARCHAR (200)  NULL,
    [Nomepopular] VARCHAR (200)  NULL,
    [Habitate] VARCHAR (1000) NULL,
    [Folha] VARCHAR (8000) NULL,
    [Flor] VARCHAR (8000) NULL,
    [Fruto] VARCHAR (8000) NULL,
    [Familia] VARCHAR (200)  NULL,
    [Tribo] VARCHAR (200)  NULL,
    [Idusuario] [bigint]            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Idbioma]) REFERENCES [BIOMAS] ([Id]),
    FOREIGN KEY ([Idusuario]) REFERENCES [USUARIOS] ([Id])
);
