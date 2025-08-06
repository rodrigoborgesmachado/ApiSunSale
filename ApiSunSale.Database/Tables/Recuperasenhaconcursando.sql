CREATE TABLE [Recuperasenhaconcursando] (
    [Codigo] [bigint] IDENTITY(1,1)           NOT NULL,
    [Dataregistro] DATETIME      NOT NULL,
    [Guid] VARCHAR (64)  DEFAULT ('') NOT NULL,
    [Email] VARCHAR (300) DEFAULT ('') NOT NULL,
    [Recuperado] CHAR (1)      DEFAULT ('0') NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);
