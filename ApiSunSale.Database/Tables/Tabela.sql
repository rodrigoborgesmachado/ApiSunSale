CREATE TABLE [Tabela] (
    [Codigo] [bigint] IDENTITY(1,1)           DEFAULT ((0)) NOT NULL,
    [Projeto] [bigint]           DEFAULT ((0)) NOT NULL,
    [Nome] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Descricao] VARCHAR (400) NULL,
    [Notas] VARCHAR (400) NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC, [Projeto] ASC)
);
