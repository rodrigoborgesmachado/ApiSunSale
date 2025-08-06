CREATE TABLE [Questoes] (
    [Codigo] [bigint IDENTITY(1,1)]            NOT NULL,
    [Dataregistro] DATETIME       NOT NULL,
    [Campoquestao] VARCHAR (8000) DEFAULT ('') NOT NULL,
    [Observacaoquestao] VARCHAR (8000) DEFAULT ('') NOT NULL,
    [Materia] VARCHAR (300)  DEFAULT ('') NOT NULL,
    [Codigoprova] [bigint IDENTITY(1,1)]            DEFAULT ((0)) NOT NULL,
    [Numeroquestao] VARCHAR (20)   NULL,
    [Ativo] CHAR (1)       DEFAULT ('1') NOT NULL,
    [Updatedby] [bigint],
    [Updatedon] DATETIME,
    [Createdby] [bigint],
    [Assunto] VARCHAR(255) NULL, 
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);
