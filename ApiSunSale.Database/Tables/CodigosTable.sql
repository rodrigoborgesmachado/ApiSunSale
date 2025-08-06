CREATE TABLE [CodigosTable] (
    [Tabela] VARCHAR (30) NOT NULL,
    [Codigo] [bigint] IDENTITY(1,1)          DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Tabela] ASC)
);
