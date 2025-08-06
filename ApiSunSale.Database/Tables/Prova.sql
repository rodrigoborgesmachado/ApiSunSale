CREATE TABLE [Prova] (
    [Codigo] [bigint IDENTITY(1,1)]             NOT NULL,
    [Nomeprova] VARCHAR (500)   DEFAULT ('') NOT NULL,
    [Local] VARCHAR (500)   DEFAULT ('') NOT NULL,
    [Tipoprova] VARCHAR (100)   DEFAULT ('') NOT NULL,
    [Dataaplicacao] VARCHAR (10)    DEFAULT ('') NOT NULL,
    [Prova] VARBINARY (MAX) NULL,
    [Gabarito] VARBINARY (MAX) NULL,
    [Observacaoprova] VARCHAR (3000)  NULL,
    [Observacaogabarito] VARCHAR (2000)  DEFAULT ('') NOT NULL,
    [Dataregistro] DATETIME        NOT NULL,
    [Banca] VARCHAR (1000)  NULL,
    [Updatedby] [bigint],
    [Updatedon] DATETIME,
    [Createdby] [bigint],
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);
