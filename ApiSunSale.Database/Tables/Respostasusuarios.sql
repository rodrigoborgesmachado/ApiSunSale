CREATE TABLE [Respostasusuarios] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
    [IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [IdUsuario] [bigint]      DEFAULT ((0)) NOT NULL,
    [IdResposta] [bigint]      DEFAULT ((0)) NOT NULL,
    [IdQuestao] [bigint],
    FOREIGN KEY ([IdUsuario]) REFERENCES [Usuarios]([Id]),
    FOREIGN KEY ([IdResposta]) REFERENCES [Respostasquestoes]([Id]),
    FOREIGN KEY ([IdQuestao]) REFERENCES [Questoes]([Id])
);
