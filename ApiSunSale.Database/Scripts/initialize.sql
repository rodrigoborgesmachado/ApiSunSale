-- START Tipoprovaassociado.sql
create table TipoProvaAssociado(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	[IdTipo] int,
	[IdProva] int
);
GO

-- START Licencassunsalepro.sql
create table LicencasSunSalePro(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	Licenca varchar(255) not null
)
GO

-- START Usuarios.sql
CREATE TABLE [Usuarios](
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	[Login] [varchar](50) NOT NULL,
	[Pass] [varchar](12) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Email] [varchar](300) NULL,
	[Datanascimento] [date] NULL,
	[Admin] [char](1) NULL,
	[Instituicao] [nvarchar](255)
);
GO

-- START Biomas.sql
CREATE TABLE [Biomas] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Nome] VARCHAR (200)  NULL,
    [Distribuicao] VARCHAR (200)  NULL,
    [Caracteristicas] VARCHAR (8000) NULL,
    [Fitofisionomia] VARCHAR (8000) NULL,
    [Observacao] VARCHAR (8000) NULL,
    [Idusuario] [bigint]            NOT NULL,
    
    FOREIGN KEY ([Idusuario]) REFERENCES [Usuarios] ([Id])
);
GO

-- START Imagensbioma.sql
CREATE TABLE [Imagensbioma] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Idbioma] [bigint]           NOT NULL,
    [Link] VARCHAR (300) NULL,
    
    FOREIGN KEY ([Idbioma]) REFERENCES [BIOMAS] ([Id])
);
GO

-- START Whosthatpokemonresult.sql
create table WhosThatPokemonResult(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	Nome varchar(255),
	Tempo int default 0,
	Acertos int not null,
	Erros int not null,
	Kanto tinyint default 0 not null,
	Johto tinyint default 0 not null,
	Hoenn tinyint default 0 not null,
	Sinnoh tinyint default 0 not null,
	Unova tinyint default 0 not null,
	Kalos tinyint default 0 not null,
	Alola tinyint default 0 not null,
	Paldea tinyint default 0 not null
)
GO

-- START Cartaocreditodevtools.sql
CREATE TABLE [Cartaocreditodevtools] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Numerocartao] VARCHAR (100) DEFAULT ('') NOT NULL UNIQUE,
    [Datavalidade] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Brand] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Codigoseguranca] CHAR (3)      DEFAULT ('') NOT NULL
);
GO

-- START Recuperasenhacrudforms.sql
CREATE TABLE [Recuperasenhacrudforms] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Guid] VARCHAR (255)  NULL,
	[UserId] [bigint] NOT NULL
);
GO

-- START Respostasavaliacoes.sql
CREATE TABLE [dbo].[Respostasavaliacoes]
(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	[Createdby] [bigint] not null,
	[Updatedby] [bigint] not null,
	[Idavaliacao] [bigint] not null,
	[Idquestao] [bigint] not null,
	[Idresposta] [bigint] not null,
)
GO

-- START Verificacaousuario.sql
create table VerificacaoUsuario(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	[Guid] varchar(64) not null,
	[IdUsuario] int not null,
);
GO

-- START Empresafordev.sql
CREATE TABLE [Empresafordev] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Nome] VARCHAR (200) NULL,
    [Cnpj] VARCHAR (15)  DEFAULT ('') NOT NULL UNIQUE,
    [Ie] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Dataabertura] VARCHAR (12)  DEFAULT ('') NOT NULL,
    [Site] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Email] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Cep] VARCHAR (10)  DEFAULT ('') NOT NULL,
    [Endereco] VARCHAR (100) DEFAULT ('') NOT NULL,
    [Numero] VARCHAR (20)  DEFAULT ('') NOT NULL,
    [Bairro] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Cidade] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Estado] CHAR (3)      DEFAULT ('SP') NOT NULL,
    [Telefonefixo] VARCHAR (30)  DEFAULT ('') NOT NULL,
    [Celular] VARCHAR (30)  DEFAULT ('') NOT NULL
);
GO

-- START Savedresultswpp.sql
create table SavedResultsWpp(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	[Guid] varchar(255) not null,
	[Json] varchar(max) not null,
)
GO

-- START Veiculosfordev.sql
CREATE TABLE [Veiculosfordev] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
    [IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Marca] VARCHAR (300) DEFAULT ('') NOT NULL,
    [Modelo] VARCHAR (300) DEFAULT ('') NOT NULL,
    [Ano] VARCHAR (10)  DEFAULT ('') NOT NULL,
    [Renavam] VARCHAR (30)  DEFAULT ('') NOT NULL,
    [Placaveiculo] VARCHAR (20)  DEFAULT ('') NOT NULL,
    [Cor] VARCHAR (50)  DEFAULT ('') NOT NULL
);
GO

-- START Metas.sql
create table Metas(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	Meta varchar(max) not null,
	Email varchar(255) not null,
	DataObjetivo datetime not null
)
GO

-- START Notascortesisu.sql
CREATE TABLE [dbo].[Notascortesisu]
(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	[Year] [bigint] not null,
	[Numeroedicao] char(1) not null,
	[Codigoinstituicaoensino] [bigint] not null,
	[Nomeinstituicao] varchar(500) not null,
	[Siglainstituicao] varchar(255) not null,
	[Organizacaoacademica] varchar(255) not null,
	[Categoriaorganizacao] varchar(255) not null,
	[Nomecampus] varchar(500) not null,
	[Nomemunicipiocampus] varchar(500) not null,
	[Ufcampus] varchar(2) not null,
	[Regiaocampus] varchar(50) not null,
	[Codigocurso] bigInt not null,
	[Nomecurso] varchar(500) not null,
	[Descricaograu] varchar(500) not null,
	[Turno] varchar(100) not null,
	[Modoconcorrencia] varchar(500) not null,
	[Desricaomodoconcorrencia] varchar(1000) not null,
	[Bonusacaoafirmativa] decimal not null,
	[Quantidadevagas] [bigint] not null,
	[Notacorte] decimal not null,
	[Quantidadeinscricoes] [bigint] not null,
)
GO

-- START Recuperasenha.sql
create table [Recuperasenha]
(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	[Guid] varchar(100) not null,
	[UserId] [bigint] not null,
	[Validated] char(1) default '0' not null
)
GO

-- START Verbos.sql
CREATE TABLE [Verbos] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
    [IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Palavra] VARCHAR (500) DEFAULT ('') NOT NULL
);
GO

-- START Tipoprova.sql
create table TipoProva(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	Descricao Varchar(255) not null,
	CreatedBy int,
	UpdatedBy int
);
GO

-- START Resultadossoletrando.sql
CREATE TABLE [Resultadossoletrando] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
    [IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Nome] VARCHAR (100) NOT NULL,
    [Numeroacertos] [bigint]           NOT NULL
);
GO

-- START Avaliacao.sql
CREATE TABLE [dbo].[Avaliacao]
(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Nome] NVARCHAR(255) not null,
    [Orientação] NVARCHAR(MAX),
    [Ispublic] char(1) default '1' not null,
    [Key] nvarchar(64) ,
    [Updatedby] [bigint],
    [Createdby] [bigint]
)
GO

-- START Prova.sql
CREATE TABLE [Prova] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Nomeprova] VARCHAR (500)   DEFAULT ('') NOT NULL,
    [Local] VARCHAR (500)   DEFAULT ('') NOT NULL,
    [Tipoprova] VARCHAR (100)   DEFAULT ('') NOT NULL,
    [Dataaplicacao] VARCHAR (10)    DEFAULT ('') NOT NULL,
    [Prova] VARCHAR (255) NULL,
    [Gabarito] VARCHAR (255) NULL,
    [Observacaoprova] VARCHAR (3000)  NULL,
    [Observacaogabarito] VARCHAR (2000)  DEFAULT ('') NOT NULL,
    [Dataregistro] DATETIME        NOT NULL,
    [Banca] VARCHAR (1000)  NULL,
    [Updatedby] [bigint],
    [Createdby] [bigint]
);
GO

-- START Questoes.sql
CREATE TABLE [Questoes] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Campoquestao] VARCHAR (8000) DEFAULT ('') NOT NULL,
    [Observacaoquestao] VARCHAR (8000) DEFAULT ('') NOT NULL,
    [Materia] VARCHAR (300)  DEFAULT ('') NOT NULL,
    [IdProva] [bigint]            DEFAULT ((0)) NOT NULL,
    [Numeroquestao] VARCHAR (20)   NULL,
    [Updatedby] [bigint],
    [Createdby] [bigint],
    [Assunto] VARCHAR(255) NULL,
    FOREIGN KEY ([IdProva]) REFERENCES [Prova]([Id])
);
GO

-- START Comentariosquestoes.sql
create table ComentariosQuestoes(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	[Comentario] varchar(MAX) not null,
	[IdUsuario] [bigint] not null,
	[IdQuestao] [bigint] not null,
    FOREIGN KEY ([IdUsuario]) REFERENCES [Usuarios]([Id]),
    FOREIGN KEY ([IdQuestao]) REFERENCES [Questoes]([Id])
);
GO

-- START Simulados.sql
create table Simulados(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	Respostas varchar(MAX) not null,
	IdUsuario [bigint] not null,
	IdProva [bigint] not null,
	QuantidadeQuestoes int not null,
	QuantidadeCertas int not null,
	Tempo int not null,
    FOREIGN KEY ([IdUsuario]) REFERENCES [Usuarios]([Id]),
    FOREIGN KEY ([IdProva]) REFERENCES [Prova]([Id])
)
GO

-- START Postagem.sql
create table Postagem(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	Descricao varchar(max) not null,
	DescricaoEn varchar(max) not null,
	TipoPostagem int,
	Capa varchar(255) not null,
	Curtidas int default 0 not null
)
GO

-- START Categoriaalimentos.sql
CREATE TABLE [dbo].[Categoriaalimentos]
(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	[Descricao] VARCHAR(255) NOT NULL
)
GO

-- START Pesos.sql
CREATE TABLE [Pesos]
(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	Faculdade varchar(500) not null,
	Curso varchar(500) not null,
	Turno varchar(250) not null,
	Materia varchar(250) not null,
	Peso decimal(10,2) not null
)
GO

-- START Verboconjugado.sql
CREATE TABLE [Verboconjugado] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
    [IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [IdVerbo] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Presente] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Preteritoimperfeito] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Preteritoperfeito] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Preteritomaisqueperfeito] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Futurodopresente] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Futurodopreterito] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Pronome] VARCHAR (30)  DEFAULT ('') NOT NULL
);
GO

-- START AnexosQuestoes.sql
CREATE TABLE [Anexosquestoes] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [IdQuestao] [bigint]             DEFAULT ((0)) NOT NULL,
    [Link] VARCHAR (255) NOT NULL,
    FOREIGN KEY ([IdQuestao]) REFERENCES [Questoes]([Id])
);
GO

-- START Tipoperfil.sql
CREATE TABLE [dbo].[Tipoperfil]
(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	[Descricao] [nvarchar](255) not null
)
GO

-- START Usuarioscrudforms.sql
CREATE TABLE [Usuarioscrudforms] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
    [IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Login] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Senha] VARCHAR (20)  DEFAULT ('') NOT NULL,
    [Administrador] CHAR (1)      DEFAULT ('0') NOT NULL,
    [Desenvolvedor] CHAR (1)      DEFAULT ('0') NOT NULL,
    [Email] VARCHAR (200) DEFAULT ('') NOT NULL,
    [Usuariopai] [bigint]           DEFAULT ((-1)) NOT NULL,
    Nome            varchar(100)
);
GO

-- START Logger.sql
CREATE TABLE [Logger](
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	[Message] [nvarchar](max) NOT NULL,
	[AdminId] [bigint] NULL,	
	[ClassName] [nvarchar](255) NULL,
	[MethodName] [nvarchar](255) NULL,
	[MethodSignature] [nvarchar](255) NULL,
	[MethodParameters] [nvarchar](255) NULL,
	[StackTrace] [nvarchar](max) NULL
	)
GO


-- START Respostasquestoes.sql
CREATE TABLE [Respostasquestoes] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
    [IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [IdQuestao] [bigint]            DEFAULT ((0)) NOT NULL,
    [Textoresposta] VARCHAR (8000) DEFAULT ('') NOT NULL,
    [Certa] CHAR (1)       DEFAULT ('0') NOT NULL,
    [Observacaoresposta] VARCHAR (8000) NULL,
    FOREIGN KEY ([IdQuestao]) REFERENCES Questoes(Id)
);
GO

-- START AnexoResposta.sql
CREATE TABLE [Anexoresposta] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [IdResposta] [bigint]             DEFAULT ((0)) NOT NULL,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Link] VARCHAR (255) NOT NULL,
    FOREIGN KEY ([IdResposta]) REFERENCES [Respostasquestoes]([Id])
);
GO

-- START Plantas.sql
CREATE TABLE [Plantas] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Idbioma] [bigint]            NOT NULL,
    [Nomecientifico] VARCHAR (200)  NULL,
    [Nomepopular] VARCHAR (200)  NULL,
    [Habitate] VARCHAR (1000) NULL,
    [Folha] VARCHAR (8000) NULL,
    [Flor] VARCHAR (8000) NULL,
    [Fruto] VARCHAR (8000) NULL,
    [Familia] VARCHAR (200)  NULL,
    [Tribo] VARCHAR (200)  NULL,
    [Idusuario] [bigint]            NOT NULL,
    
    FOREIGN KEY ([Idbioma]) REFERENCES [BIOMAS] ([Id]),
    FOREIGN KEY ([Idusuario]) REFERENCES [USUARIOS] ([Id])
);
GO

-- START Alimentos.sql
CREATE TABLE [dbo].[Alimentos]
(
	[Id] [bigint] IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Categoriacodigo] [bigint] NOT NULL,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	[Numeroalimento] [bigint] NOT NULL,
	[Descricao] VARCHAR(255) NOT NULL,
	[Umidade] NUMERIC(18, 10), 
    [Energiakcal] NUMERIC(18, 10) NULL, 
    [Energiakg] NUMERIC(18, 10) NULL, 
    [Proteina] NUMERIC(18, 10) NULL, 
    [Lipidios] VARCHAR(50) NULL, 
    [Colesterol] VARCHAR(50) NULL, 
    [Carboidrato] NUMERIC(18, 10) NULL, 
    [Fibraalimentar] NUMERIC(18, 10) NULL, 
    [Cinzas] NUMERIC(18, 10) NULL, 
    [Calcio] NUMERIC(18, 10) NULL, 
    [Magnesio] VARCHAR(50) NULL, 
    [Manganes] VARCHAR(50) NULL, 
    [Fosforo] VARCHAR(50) NULL, 
    [Ferro] VARCHAR(50) NULL, 
    [Sodio] VARCHAR(50) NULL, 
    [Potassio] VARCHAR(50) NULL, 
    [Cobre] VARCHAR(50) NULL, 
    [Zinco] VARCHAR(50) NULL, 
    [Retinol] VARCHAR(50) NULL, 
    [Re] VARCHAR(50) NULL, 
    [Rae] VARCHAR(50) NULL, 
    [Tiamina] VARCHAR(50) NULL, 
    [Piridozina] VARCHAR(50) NULL, 
    [Riboflavina] VARCHAR(50) NULL, 
    [Niacina] VARCHAR(50) NULL, 
    [Vitaminac] VARCHAR(50) NULL

)
GO

-- START Crudformsinstalador.sql
CREATE TABLE [Crudformsinstalador] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Versao] VARCHAR (10)  DEFAULT ('') NOT NULL,
    [Diretorio] VARCHAR (300) DEFAULT ('') NOT NULL
);
GO

-- START Contabancofordev.sql
CREATE TABLE [Contabancofordev] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Contacorrente] VARCHAR (100) DEFAULT ('') NOT NULL UNIQUE,
    [Agencia] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Banco] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Cidade] VARCHAR (150) DEFAULT ('') NOT NULL,
    [Estado] CHAR (2)      DEFAULT ('') NOT NULL
);
GO

-- START Pessoasfordev.sql
CREATE TABLE [Pessoasfordev] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Nome] VARCHAR (2000) DEFAULT ('') NOT NULL,
    [Idade] [bigint]            DEFAULT ((0)) NOT NULL,
    [Cpf] VARCHAR (12)   DEFAULT ('') NOT NULL UNIQUE,
    [Rg] VARCHAR (12)   DEFAULT ('') NOT NULL,
    [Datanascimento] VARCHAR (10)   DEFAULT ('') NOT NULL,
    [Sexo] VARCHAR (20)   DEFAULT ('Masculino') NOT NULL,
    [Signo] VARCHAR (30)   DEFAULT ('') NOT NULL,
    [Mae] VARCHAR (2000) DEFAULT ('') NOT NULL,
    [Pai] VARCHAR (2000) DEFAULT ('') NOT NULL,
    [Email] VARCHAR (500)  DEFAULT ('') NOT NULL,
    [Senha] VARCHAR (50)   DEFAULT ('') NOT NULL,
    [Cep] VARCHAR (8)    DEFAULT ('') NOT NULL,
    [Endereco] VARCHAR (1000) DEFAULT ('') NOT NULL,
    [Numero] [bigint]            DEFAULT ((0)) NOT NULL,
    [Bairro] VARCHAR (500)  DEFAULT ('') NOT NULL,
    [Cidade] VARCHAR (1000) DEFAULT ('') NOT NULL,
    [Estado] CHAR (2)       DEFAULT ('MG') NOT NULL,
    [Telefonefixo] VARCHAR (50)   DEFAULT ('') NOT NULL,
    [Celular] VARCHAR (50)   DEFAULT ('') NOT NULL,
    [Altura] VARCHAR (10)   DEFAULT ('') NOT NULL,
    [Peso] [bigint]            DEFAULT ((0)) NOT NULL,
    [Tiposanguineo] VARCHAR (3)    DEFAULT ('') NOT NULL,
    [Corfavorita] VARCHAR (30)   DEFAULT ('') NOT NULL
);
GO

-- START Imagensplanta.sql
CREATE TABLE [Imagensplanta] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [IdPlanta] [bigint]           NOT NULL,
    [Link] VARCHAR (300) NULL,
    
    FOREIGN KEY ([Idplanta]) REFERENCES [PLANTAS] ([Id])
);
GO

-- START Palavras.sql
CREATE TABLE [Palavras] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Nivel] [bigint]           NOT NULL,
    [Palavra] VARCHAR (100) NOT NULL,
    
    UNIQUE NONCLUSTERED ([Palavra] ASC)
);
GO

-- START AcaoUsuario.sql
CREATE TABLE [Acaousuario] (
    [Id] [bigint] IDENTITY(1,1)           NOT NULL,
    [IdUsuario] [bigint]           DEFAULT ((0)) NOT NULL,
    [Acao] VARCHAR (200) DEFAULT ('') NOT NULL,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    
    FOREIGN KEY ([IdUsuario]) REFERENCES [USUARIOS]([Id])
);
GO

-- START Resultadostabuadadivertida.sql
CREATE TABLE [dbo].[Resultadostabuadadivertida]
(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	Nome varchar(300) not null,
	Tempo int not null,
	NumeroAcertos int not null,
	Tipo char(1),
	NumeroQuestoes int
)
GO

-- START Tipopostagem.sql
create table TipoPostagem(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	descricao varchar(255)
)
GO

-- START Email.sql
CREATE TABLE [Email] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [Destinatario] VARCHAR (300)   DEFAULT ('') NOT NULL,
    [Assunto] VARCHAR (300)   DEFAULT ('') NOT NULL,
    [Texto] VARCHAR (MAX) NULL,
    [Status] CHAR (1)        DEFAULT ('0') NOT NULL,
    [Observacao] VARCHAR (1000)  NULL
);
GO

-- START Questoesavaliacao.sql
CREATE TABLE [dbo].[Questoesavaliacao]
(
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	[IdAvaliacao] [bigint] not null,
	[IdQuestao] [bigint] not null,
	[Notaquestao] decimal(10,2) default 1
)
GO

-- START Respostasusuarios.sql
CREATE TABLE [Respostasusuarios] (
    [Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
    [IsActive] [tinyint] NOT NULL DEFAULT 1,
    [IsDeleted] [tinyint] NOT NULL DEFAULT 0,
    [IdUsuario] [bigint]      DEFAULT ((0)) NOT NULL,
    [IdResposta] [bigint]      DEFAULT ((0)) NOT NULL,
    [IdQuestao] [bigint],
    FOREIGN KEY ([IdUsuario]) REFERENCES [Usuarios]([Id]),
    FOREIGN KEY ([IdResposta]) REFERENCES [Respostasquestoes]([Id]),
    FOREIGN KEY ([IdQuestao]) REFERENCES [Questoes]([Id])
);
GO

INSERT INTO [dbo].[Usuarios]
           ([Created]
           ,[Updated]
           ,[IsActive]
           ,[IsDeleted]
           ,[Login]
           ,[Pass]
           ,[Nome]
           ,[Email]
           ,[Datanascimento]
           ,[Admin]
           ,[Instituicao])
     VALUES
           (getdate()
           ,getdate()
           ,1
           ,0
           ,'admin@admin.com'
           ,'12345'
           ,'Admin'
           ,'admin@admin.com'
           ,GETDATE()
           ,'1'
           ,'')
GO
