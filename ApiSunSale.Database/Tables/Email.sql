CREATE TABLE [Email] (
    [Codigo] [bigint IDENTITY(1,1)]             NOT NULL,
    [Destinatario] VARCHAR (300)   DEFAULT ('') NOT NULL,
    [Assunto] VARCHAR (300)   DEFAULT ('') NOT NULL,
    [Texto] VARBINARY (MAX) NULL,
    [Dataenvio] DATETIME        NOT NULL,
    [Status] CHAR (1)        DEFAULT ('0') NOT NULL,
    [Observacao] VARCHAR (1000)  NULL
);
