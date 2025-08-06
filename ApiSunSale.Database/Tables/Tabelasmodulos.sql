CREATE TABLE [Tabelasmodulos] (
    [Codigotabela] [bigint] IDENTITY(1,1) DEFAULT ((0)) NOT NULL,
    [Codigocampo] [bigint] IDENTITY(1,1) DEFAULT ((0)) NOT NULL,
    [Codigomodulo] [bigint] IDENTITY(1,1) DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigotabela] ASC, [Codigocampo] ASC, [Codigomodulo] ASC)
);
