CREATE TABLE [Despesas] (
    [Codigo] [bigint IDENTITY(1,1)]           NOT NULL,
    [Datainsercao] DATETIME      NOT NULL,
    [Datadespesa] VARCHAR (30)  DEFAULT ('') NOT NULL,
    [Descricao] VARCHAR (300) DEFAULT ('') NOT NULL,
    [Categoria] VARCHAR (30)  DEFAULT ('') NOT NULL,
    [Valor] VARCHAR (30)  DEFAULT ('') NOT NULL,
    [Conta] VARCHAR (300) DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);
