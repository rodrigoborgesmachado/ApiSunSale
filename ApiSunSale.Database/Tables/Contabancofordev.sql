CREATE TABLE [Contabancofordev] (
    [Created] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Contacorrente] VARCHAR (100) DEFAULT ('') NOT NULL,
    [Agencia] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Banco] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Cidade] VARCHAR (150) DEFAULT ('') NOT NULL,
    [Estado] CHAR (2)      DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Contacorrente] ASC)
);
