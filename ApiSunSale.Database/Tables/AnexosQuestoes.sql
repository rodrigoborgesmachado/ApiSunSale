CREATE TABLE [Anexosquestoes] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [IdQuestao] [bigint]             DEFAULT ((0)) NOT NULL,
    [Link] VARCHAR (255) NOT NULL,
    FOREIGN KEY ([IdQuestao]) REFERENCES [Questoes]([Id])
);
