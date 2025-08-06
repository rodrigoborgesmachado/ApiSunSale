CREATE TABLE [Relacao] (
    [Codigo] [bigint IDENTITY(1,1)]           DEFAULT ((0)) NOT NULL,
    [Codigoprojeto] [bigint IDENTITY(1,1)]           DEFAULT ((0)) NOT NULL,
    [Tabelaorigem] [bigint]           DEFAULT ((0)) NOT NULL,
    [Campoorigem] [bigint]           DEFAULT ((0)) NOT NULL,
    [Tabeladestino] [bigint]           DEFAULT ((0)) NOT NULL,
    [Campodestino] [bigint]           DEFAULT ((0)) NOT NULL,
    [Cardinalidadeorigem] VARCHAR (1)   DEFAULT ('') NOT NULL,
    [Cardinalidadedestino] VARCHAR (1)   DEFAULT ('') NOT NULL,
    [Foreingkey] VARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);
