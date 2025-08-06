CREATE TABLE [Modulos] (
    [Codigo] [bigint] IDENTITY(1,1)            NOT NULL,
    [Nomemodulo] VARCHAR (100)  DEFAULT ('') NOT NULL,
    [Descricao] VARCHAR (1000) NULL,
    [Sequenciaabertura] VARCHAR (1000) NULL,
    [Codigoprojeto] [bigint]            DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC, [Codigoprojeto] ASC),
    FOREIGN KEY ([Codigoprojeto]) REFERENCES [Projeto]([Codigo])
);
