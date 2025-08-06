CREATE TABLE [Verboconjugado] (
    [Codigo] [bigint IDENTITY(1,1)]           NOT NULL,
    [Datacriacao] DATETIME      NOT NULL,
    [Verbo] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Presente] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Preteritoimperfeito] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Preteritoperfeito] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Preteritomaisqueperfeito] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Futurodopresente] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Futurodopreterito] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Pronome] VARCHAR (30)  DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);
