CREATE TABLE [Projeto] (
    [Codigo] [bigint] IDENTITY(1,1)           DEFAULT ((0)) NOT NULL,
    [Nome] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Descricao] VARCHAR (400) NULL,
    [Status] CHAR (1)      NULL,
    [Git] VARCHAR (200) DEFAULT ('-') NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);
