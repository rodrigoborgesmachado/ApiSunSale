create table WhosThatPokemonResult(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	Nome varchar(255),
	Tempo int default 0,
	Acertos int not null,
	Erros int not null,
	Kanto tinyint default 0 not null,
	Johto tinyint default 0 not null,
	Hoenn tinyint default 0 not null,
	Sinnoh tinyint default 0 not null,
	Unova tinyint default 0 not null,
	Kalos tinyint default 0 not null,
	Alola tinyint default 0 not null,
	Paldea tinyint default 0 not null
)