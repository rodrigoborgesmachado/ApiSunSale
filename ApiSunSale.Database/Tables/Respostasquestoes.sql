CREATE TABLE [Respostasquestoes] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
    [IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [IdQuestao] [bigint]            DEFAULT ((0)) NOT NULL,
    [Textoresposta] VARCHAR (8000) DEFAULT ('') NOT NULL,
    [Certa] CHAR (1)       DEFAULT ('0') NOT NULL,
    [Observacaoresposta] VARCHAR (8000) NULL,
    FOREIGN KEY ([IdQuestao]) REFERENCES Questoes(Id)
);
