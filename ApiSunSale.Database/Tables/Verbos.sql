CREATE TABLE [Verbos] (
    [Codigo] [bigint IDENTITY(1,1)]           NOT NULL,
    [Palavra] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Datainsercao] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);
