CREATE TABLE AcaoUsuario (
    Codigo          bigint IDENTITY(1,1) NOT NULL, 
    CodigoUsuario   int NOT NULL DEFAULT (0), 
    Acao            varchar(200) NOT NULL DEFAULT (''), 
    DataRegistro    datetime NOT NULL, 
    PRIMARY KEY CLUSTERED (Codigo ASC)
);
