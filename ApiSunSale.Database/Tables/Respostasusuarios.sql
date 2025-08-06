CREATE TABLE [Respostasusuarios] (
    [Codigo] [bigint] IDENTITY(1,1)      NOT NULL,
    [Codigousuario] [bigint]      DEFAULT ((0)) NOT NULL,
    [Codigoresposta] [bigint]      DEFAULT ((0)) NOT NULL,
    [Dataresposta] DATETIME NOT NULL,
    [Codigoquestao] [bigint],
    PRIMARY KEY CLUSTERED ([Codigo] ASC),
    FOREIGN KEY ([Codigousuario]) REFERENCES [Usuarios]([Id]),
    FOREIGN KEY ([Codigoresposta]) REFERENCES [Respostasquestoes]([Codigo]),
    FOREIGN KEY ([Codigoquestao]) REFERENCES [Questoes]([Codigo])
);
