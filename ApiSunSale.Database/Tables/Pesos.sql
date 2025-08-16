CREATE TABLE [Pesos]
(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	Faculdade varchar(500) not null,
	Curso varchar(500) not null,
	Turno varchar(250) not null,
	Materia varchar(250) not null,
	Peso decimal(10,2) not null
)