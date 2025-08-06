CREATE TABLE [Configuracaoemail] (
    [Codigo] [bigint] IDENTITY(1,1)           NOT NULL,
    [Emailremetente] VARCHAR (300) DEFAULT ('') NOT NULL,
    [Smtpclient] VARCHAR (100) NULL,
    [Porta] [bigint]           DEFAULT ((587)) NOT NULL,
    [Emailcredencial] VARCHAR (300) DEFAULT ('') NOT NULL,
    [Senhacredencial] VARCHAR (200) DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);
