CREATE TABLE [Empresafordev] (
    [Nome] VARCHAR (200) NULL,
    [Cnpj] VARCHAR (15)  DEFAULT ('') NOT NULL,
    [Ie] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Dataabertura] VARCHAR (12)  DEFAULT ('') NOT NULL,
    [Site] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Email] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Cep] VARCHAR (10)  DEFAULT ('') NOT NULL,
    [Endereco] VARCHAR (100) DEFAULT ('') NOT NULL,
    [Numero] VARCHAR (20)  DEFAULT ('') NOT NULL,
    [Bairro] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Cidade] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Estado] CHAR (3)      DEFAULT ('SP') NOT NULL,
    [Telefonefixo] VARCHAR (30)  DEFAULT ('') NOT NULL,
    [Celular] VARCHAR (30)  DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Cnpj] ASC)
);
