CREATE TABLE [Verboconjugado] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
    [IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [IdVerbo] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Presente] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Preteritoimperfeito] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Preteritoperfeito] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Preteritomaisqueperfeito] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Futurodopresente] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Futurodopreterito] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Pronome] VARCHAR (30)  DEFAULT ('') NOT NULL
);
