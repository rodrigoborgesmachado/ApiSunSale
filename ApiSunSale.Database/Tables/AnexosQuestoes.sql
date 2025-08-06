CREATE TABLE AnexosQuestoes (
    Codigo         bigint IDENTITY(1,1) NOT NULL,
    CodigoQuestao  int NOT NULL DEFAULT (0),
    DataRegistro   datetime NOT NULL DEFAULT GETDATE(),
    Anexo          varbinary(MAX) NOT NULL,
    PRIMARY KEY CLUSTERED (Codigo ASC)
);
