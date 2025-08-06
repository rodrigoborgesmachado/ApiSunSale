CREATE TABLE [Emailbackup] (
    [Codigo] [bigint] IDENTITY(1,1)            NOT NULL,
    [Destinatario] VARCHAR (300)  NOT NULL,
    [Assunto] VARCHAR (300)  NOT NULL,
    [Texto] VARCHAR (8000) NOT NULL,
    [Dataenvio] DATETIME       NOT NULL,
    [Status] CHAR (1)       NOT NULL,
    [Observacao] VARCHAR (1000) NULL
);
