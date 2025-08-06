CREATE TABLE [Palavras] (
    [Id] [bigint] IDENTITY(1,1)           NOT NULL,
    [Nivel] [bigint]           NOT NULL,
    [Palavra] VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Palavra] ASC)
);
