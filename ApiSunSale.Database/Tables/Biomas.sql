CREATE TABLE Biomas (
    Codigo           bigint IDENTITY(1,1) NOT NULL,
    Nome             varchar(200) NULL,
    Distribuicao     varchar(200) NULL,
    Caracteristicas  varchar(8000) NULL,
    Fitofisionomia   varchar(8000) NULL,
    Observacao       varchar(8000) NULL,
    CodigoUsuario    int NOT NULL,
    PRIMARY KEY CLUSTERED (Codigo ASC),
    FOREIGN KEY (CodigoUsuario) REFERENCES Usuarios (Codigo)
);
