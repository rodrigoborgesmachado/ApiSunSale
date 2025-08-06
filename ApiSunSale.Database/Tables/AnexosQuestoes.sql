CREATE TABLE [Anexosquestoes] (
    [Codigo] [bigint] IDENTITY(1,1)             NOT NULL,
    [Codigoquestao] [bigint]             DEFAULT ((0)) NOT NULL,
    [Dataregistro] DATETIME        DEFAULT ('') NOT NULL,
    [Anexo] VARBINARY (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC),
    FOREIGN KEY ([Codigoquestao]) REFERENCES [Questoes]([Codigo])
);
