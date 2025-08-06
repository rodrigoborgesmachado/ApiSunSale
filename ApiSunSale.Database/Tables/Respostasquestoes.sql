CREATE TABLE [Respostasquestoes] (
    [Codigo] [bigint IDENTITY(1,1)]            NOT NULL,
    [Codigoquestao] [bigint IDENTITY(1,1)]            DEFAULT ((0)) NOT NULL,
    [Dataregistro] DATETIME       DEFAULT ('') NOT NULL,
    [Textoresposta] VARCHAR (8000) DEFAULT ('') NOT NULL,
    [Certa] CHAR (1)       DEFAULT ('0') NOT NULL,
    [Observacaoresposta] VARCHAR (8000) NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC),
    FOREIGN KEY (CODIGOQUESTAO) REFERENCES QUESTOES(CODIGO)
);
