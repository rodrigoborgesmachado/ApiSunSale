CREATE TABLE [Usuarioconcursando] (
    [Codigo] [bigint] IDENTITY(1,1)           NOT NULL,
    [Datanascimento] DATE          NOT NULL,
    [Email] VARCHAR (300) NOT NULL,
    [Nome] VARCHAR (200) NOT NULL,
    [Password] VARCHAR (100) NOT NULL,
    [Admin] CHAR (1)      DEFAULT ('0') NOT NULL,
    [Created] DATETIME      DEFAULT (getdate()) NOT NULL,
    [Bot] CHAR (1)      DEFAULT ('0') NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);
