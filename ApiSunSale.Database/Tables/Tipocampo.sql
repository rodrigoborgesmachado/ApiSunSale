CREATE TABLE [Tipocampo] (
    [Codigo] [bigint IDENTITY(1,1)]          DEFAULT ((0)) NOT NULL,
    [Nome] VARCHAR (50) DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC, [Nome] ASC)
);
