CREATE TABLE [Cartaocreditodevtools] (
    [Numerocartao] VARCHAR (100) DEFAULT ('') NOT NULL,
    [Datavalidade] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Codigoseguranca] CHAR (3)      DEFAULT ('') NOT NULL,
    [Created] VARCHAR (50)  DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Numerocartao] ASC)
);
