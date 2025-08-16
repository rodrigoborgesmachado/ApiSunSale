CREATE TABLE [Cartaocreditodevtools] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Numerocartao] VARCHAR (100) DEFAULT ('') NOT NULL UNIQUE,
    [Datavalidade] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Codigoseguranca] CHAR (3)      DEFAULT ('') NOT NULL
);
