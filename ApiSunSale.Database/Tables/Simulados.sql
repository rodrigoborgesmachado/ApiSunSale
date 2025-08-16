create table Simulados(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	Respostas varchar(MAX) not null,
	IdUsuario [bigint] not null,
	IdProva [bigint] not null,
	QuantidadeQuestoes int not null,
	QuantidadeCertas int not null,
	Tempo int not null,
    FOREIGN KEY ([IdUsuario]) REFERENCES [Usuarios]([Id]),
    FOREIGN KEY ([IdProva]) REFERENCES [Prova]([Id])
)