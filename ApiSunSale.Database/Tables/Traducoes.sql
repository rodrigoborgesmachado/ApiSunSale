CREATE TABLE [Traducoes] (
    [Codigo] [bigint] IDENTITY(1,1)           NOT NULL,
    [Dataregistro] DATETIME      NOT NULL,
    [Palavraportugues] VARCHAR (300) DEFAULT ('') NOT NULL,
    [Palavraingles] VARCHAR (300) DEFAULT ('') NOT NULL,
    [Classegramatical] VARCHAR (100) DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);
