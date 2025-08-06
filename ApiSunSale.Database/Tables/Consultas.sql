CREATE TABLE [Consultas] (
    [Codigo] [bigint IDENTITY(1,1)]            NOT NULL,
    [Nomeconsulta] VARCHAR (100)  DEFAULT ('') NOT NULL,
    [Consulta] VARCHAR (4000) DEFAULT ('') NOT NULL,
    [Created] VARCHAR (20)   DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);
