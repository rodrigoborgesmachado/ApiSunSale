CREATE TABLE [Tiposuporte] (
    [Codigo] [bigint] IDENTITY(1,1)            NOT NULL,
    [Descricao] VARCHAR (1000) DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);
