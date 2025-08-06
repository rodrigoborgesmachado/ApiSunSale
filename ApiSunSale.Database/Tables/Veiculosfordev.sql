CREATE TABLE [Veiculosfordev] (
    [Marca] VARCHAR (300) DEFAULT ('') NOT NULL,
    [Modelo] VARCHAR (300) DEFAULT ('') NOT NULL,
    [Ano] VARCHAR (10)  DEFAULT ('') NOT NULL,
    [Renavam] VARCHAR (30)  DEFAULT ('') NOT NULL,
    [Placaveiculo] VARCHAR (20)  DEFAULT ('') NOT NULL,
    [Cor] VARCHAR (50)  DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Renavam] ASC)
);
