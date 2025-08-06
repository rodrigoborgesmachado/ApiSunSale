CREATE TABLE [Respostasusuarios] (
    [Codigo] [bigint IDENTITY(1,1)]      NOT NULL,
    [Codigousuario] [bigint IDENTITY(1,1)]      DEFAULT ((0)) NOT NULL,
    [Codigoresposta] [bigint IDENTITY(1,1)]      DEFAULT ((0)) NOT NULL,
    [Dataresposta] DATETIME NOT NULL,
    [Codigoquestao] [bigint IDENTITY(1,1)],
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);
