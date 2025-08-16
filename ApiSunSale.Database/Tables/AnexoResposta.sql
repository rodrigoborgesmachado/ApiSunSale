CREATE TABLE [Anexoresposta] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [IdQuestao] [bigint]             DEFAULT ((0)) NOT NULL,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Anexo] VARBINARY (MAX) NOT NULL,
    FOREIGN KEY ([IdQuestao]) REFERENCES [Questoes]([Id])
);
