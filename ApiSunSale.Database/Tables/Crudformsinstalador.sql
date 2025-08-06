CREATE TABLE [Crudformsinstalador] (
    [Codigo] [bigint IDENTITY(1,1)]           NOT NULL,
    [Versao] VARCHAR (10)  DEFAULT ('') NOT NULL,
    [Created] DATETIME      DEFAULT (((2022)-(12))-(20)) NOT NULL,
    [Diretorio] VARCHAR (300) DEFAULT ('') NOT NULL,
    [Ativo] VARCHAR (1)   DEFAULT ('1') NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);
