CREATE TABLE [Clientes] (
    [Codigo] [bigint IDENTITY(1,1)]            DEFAULT ((0)) NOT NULL,
    [Razaosocial] VARCHAR (1000) DEFAULT ('') NOT NULL,
    [Nomefantasia] VARCHAR (1000) DEFAULT ('') NOT NULL,
    [Cnpj] CHAR (18)      DEFAULT ('') NOT NULL,
    [Cidade] VARCHAR (500)  DEFAULT ('') NOT NULL,
    [Estado] CHAR (2)       DEFAULT ('') NOT NULL,
    [Endereco] VARCHAR (1000) DEFAULT ('') NOT NULL,
    [Cep] VARCHAR (8)    DEFAULT ('') NOT NULL,
    [Email] CHAR (500)     DEFAULT ('') NOT NULL,
    [Telefone] VARCHAR (30)   NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);
