CREATE TABLE [Emailanexos] (
    [Codigo] [bigint] IDENTITY(1,1)           NOT NULL,
    [Codigoemail] [bigint]           DEFAULT ((0)) NOT NULL,
    [Arquivo] VARBINARY (1) NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC),
    FOREIGN KEY ([Codigoemail]) REFERENCES [Email]([Codigo])
);
