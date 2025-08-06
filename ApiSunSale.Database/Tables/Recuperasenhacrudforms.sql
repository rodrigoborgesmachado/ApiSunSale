CREATE TABLE [Recuperasenhacrudforms] (
    [Codigo] [bigint IDENTITY(1,1)]           NOT NULL,
    [Created] DATETIME      NOT NULL,
    [Guid] VARCHAR (64)  NULL,
    [Email] VARCHAR (300) NULL,
    [Recuperado] CHAR (1)      DEFAULT ('0') NOT NULL,
    [Updated] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);
