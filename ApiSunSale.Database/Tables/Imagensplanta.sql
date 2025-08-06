CREATE TABLE [Imagensplanta] (
    [Id] [bigint] IDENTITY(1,1)           NOT NULL,
    [Idplanta] [bigint]           NOT NULL,
    [Caminho] VARCHAR (300) NULL,
    [Idusuario] [bigint]           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Idplanta]) REFERENCES [PLANTAS] ([Id]),
    FOREIGN KEY ([Idusuario]) REFERENCES [USUARIOS] ([Id])
);
