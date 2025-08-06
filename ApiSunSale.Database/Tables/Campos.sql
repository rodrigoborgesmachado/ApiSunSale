CREATE TABLE [Campos] (
    [Codigo] [bigint] IDENTITY(1,1) NOT NULL,
    [Codigotabela] [bigint]             DEFAULT ((0)) NOT NULL,
    [Nome] VARCHAR (50)    DEFAULT ('') NOT NULL,
    [Chave] CHAR (1)        DEFAULT ('0') NOT NULL,
    [Dominio] VARCHAR (100)   DEFAULT ('') NOT NULL,
    [Codigotipo] [bigint]             DEFAULT ((0)) NOT NULL,
    [Naonulo] CHAR (1)        DEFAULT ('0') NOT NULL,
    [Unico] CHAR (1)        DEFAULT ('0') NOT NULL,
    [Checar] VARCHAR (300)   DEFAULT ('') NOT NULL,
    [Padrao] VARCHAR (300)   DEFAULT ('') NOT NULL,
    [Comentario] VARCHAR (900)   DEFAULT ('') NOT NULL,
    [Tamanho] [bigint]             DEFAULT ((0)) NOT NULL,
    [Precisao] DECIMAL (15, 4) DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC, [Codigotabela] ASC, [Nome] ASC, [Chave] ASC, [Dominio] ASC, [Codigotipo] ASC, [Naonulo] ASC, [Unico] ASC, [Checar] ASC, [Padrao] ASC, [Comentario] ASC, [Tamanho] ASC, [Precisao] ASC)
);
