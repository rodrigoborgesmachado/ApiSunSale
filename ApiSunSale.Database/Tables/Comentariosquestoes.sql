create table ComentariosQuestoes(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	[Comentario] varchar(MAX) not null,
	[IdUsuario] int not null,
	[IdQuestao] int not null,
    FOREIGN KEY ([IdUsuario]) REFERENCES [Usuarios]([Id]),
    FOREIGN KEY ([IdQuestao]) REFERENCES [Questoes]([Id])
);