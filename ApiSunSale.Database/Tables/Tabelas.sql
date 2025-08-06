CREATE TABLE [Tabelas] (
    [Tab] VARCHAR (40) DEFAULT ('') NOT NULL,
    [Field] VARCHAR (25) DEFAULT ('') NOT NULL,
    [Type] CHAR (1)     DEFAULT ('') NOT NULL,
    [Size] [bigint]          DEFAULT ((0)) NOT NULL,
    [Prec] [bigint]          DEFAULT ((0)) NOT NULL,
    [Flag] [bigint]          DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Tab] ASC, [Field] ASC, [Type] ASC, [Size] ASC, [Prec] ASC, [Flag] ASC)
);
