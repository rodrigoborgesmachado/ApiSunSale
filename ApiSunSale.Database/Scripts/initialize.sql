-- START ../Tables/Usuarios.sql
CREATE TABLE [dbo].[Usuarios](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Login] [varchar](50) NOT NULL,
	[Pass] [varchar](12) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Email] [varchar](300) NULL,
	[Datanascimento] [date] NULL,
	[Admin] [char](1) NULL,
	[Created] [datetime] NULL,
	[Updated] [datetime] NULL,
	[Instituicao] [nvarchar](255),
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Login] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Usuarios] ADD  DEFAULT ('0') FOR [Admin]
GO

-- START ../Tables/Biomas.sql
CREATE TABLE [Biomas] (
    [Id] [bigint] IDENTITY(1,1)            NOT NULL,
    [Nome] VARCHAR (200)  NULL,
    [Distribuicao] VARCHAR (200)  NULL,
    [Caracteristicas] VARCHAR (8000) NULL,
    [Fitofisionomia] VARCHAR (8000) NULL,
    [Observacao] VARCHAR (8000) NULL,
    [Idusuario] [bigint]            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Idusuario]) REFERENCES [USUARIOS] ([Id])
);

-- START ../Tables/Plantas.sql
CREATE TABLE [Plantas] (
    [Id] [bigint] IDENTITY(1,1)            NOT NULL,
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
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Idbioma]) REFERENCES [BIOMAS] ([Id]),
    FOREIGN KEY ([Idusuario]) REFERENCES [USUARIOS] ([Id])
);

-- START ../Tables/Imagensbioma.sql
CREATE TABLE [Imagensbioma] (
    [Id] [bigint] IDENTITY(1,1)           NOT NULL,
    [Idbioma] [bigint]           NOT NULL,
    [Caminho] VARCHAR (300) NULL,
    [Idusuario] [bigint]           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Idbioma]) REFERENCES [BIOMAS] ([Id]),
    FOREIGN KEY ([Idusuario]) REFERENCES [USUARIOS] ([Id])
);

-- START ../Tables/Imagensplanta.sql
CREATE TABLE [Imagensplanta] (
    [Id] [bigint] IDENTITY(1,1)           NOT NULL,
    [Idplanta] [bigint]           NOT NULL,
    [Caminho] VARCHAR (300) NULL,
    [Idusuario] [bigint]           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Idplanta]) REFERENCES [PLANTAS] ([Id]),
    FOREIGN KEY ([Idusuario]) REFERENCES [USUARIOS] ([Id])
);

-- START ../Tables/Questoes.sql
CREATE TABLE [Questoes] (
    [Codigo] [bigint] IDENTITY(1,1)            NOT NULL,
    [Dataregistro] DATETIME       NOT NULL,
    [Campoquestao] VARCHAR (8000) DEFAULT ('') NOT NULL,
    [Observacaoquestao] VARCHAR (8000) DEFAULT ('') NOT NULL,
    [Materia] VARCHAR (300)  DEFAULT ('') NOT NULL,
    [Codigoprova] [bigint] IDENTITY(1,1)            DEFAULT ((0)) NOT NULL,
    [Numeroquestao] VARCHAR (20)   NULL,
    [Ativo] CHAR (1)       DEFAULT ('1') NOT NULL,
    [Updatedby] [bigint],
    [Updatedon] DATETIME,
    [Createdby] [bigint],
    [Assunto] VARCHAR(255) NULL, 
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

-- START ../Tables/Respostasquestoes.sql
CREATE TABLE [Respostasquestoes] (
    [Codigo] [bigint] IDENTITY(1,1)            NOT NULL,
    [Codigoquestao] [bigint] IDENTITY(1,1)            DEFAULT ((0)) NOT NULL,
    [Dataregistro] DATETIME       DEFAULT ('') NOT NULL,
    [Textoresposta] VARCHAR (8000) DEFAULT ('') NOT NULL,
    [Certa] CHAR (1)       DEFAULT ('0') NOT NULL,
    [Observacaoresposta] VARCHAR (8000) NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC),
    FOREIGN KEY (CODIGOQUESTAO) REFERENCES QUESTOES(CODIGO)
);

-- START ../Tables/AcaoUsuario.sql
CREATE TABLE [Acaousuario] (
    [Codigo] [bigint] IDENTITY(1,1)           NOT NULL,
    [Codigousuario] [bigint] IDENTITY(1,1)           DEFAULT ((0)) NOT NULL,
    [Acao] VARCHAR (200) DEFAULT ('') NOT NULL,
    [Dataregistro] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

-- START ../Tables/Alimentos.sql
CREATE TABLE [dbo].[Alimentos]
(
	[Codigo] [bigint] IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Categoriacodigo] [bigint] NOT NULL,
    [Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
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
-- START ../Tables/AnexoResposta.sql
CREATE TABLE [Anexoresposta] (
    [Codigo] [bigint] IDENTITY(1,1)             NOT NULL,
    [Codigoquestao] [bigint] IDENTITY(1,1)             DEFAULT ((0)) NOT NULL,
    [Dataregistro] DATETIME        DEFAULT ('') NOT NULL,
    [Anexo] VARBINARY (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

-- START ../Tables/AnexosQuestoes.sql
CREATE TABLE [Anexosquestoes] (
    [Codigo] [bigint] IDENTITY(1,1)             NOT NULL,
    [Codigoquestao] [bigint] IDENTITY(1,1)             DEFAULT ((0)) NOT NULL,
    [Dataregistro] DATETIME        DEFAULT ('') NOT NULL,
    [Anexo] VARBINARY (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

-- START ../Tables/Apresentacao.sql
CREATE TABLE [Apresentacao] (
    [Apresentacao] CHAR (1) DEFAULT ('0') NOT NULL,
    PRIMARY KEY CLUSTERED ([Apresentacao] ASC)
);

-- START ../Tables/Automatico.sql
CREATE TABLE [Automatico] (
    [Automatico] CHAR (1) DEFAULT ('0') NOT NULL,
    PRIMARY KEY CLUSTERED ([Automatico] ASC)
);

-- START ../Tables/Avaliacao.sql
CREATE TABLE [dbo].[Avaliacao]
(
	[Id] [bigint] IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Createdon] DATETIME not null,
    [Updatedon] DATETIME not null,
    [Createdby] [bigint] not null,
	[Updatedby] [bigint] not null,
    [Nome] NVARCHAR(255) not null,
    [Orientação] NVARCHAR(MAX),
    [Isactive] char(1) default '1' not null,
    [Ispublic] char(1) default '1' not null,
    [Key] nvarchar(64) 
)
-- START ../Tables/Campos.sql
CREATE TABLE [Campos] (
    [Codigo] [bigint] IDENTITY(1,1)             DEFAULT ((0)) NOT NULL,
    [Codigotabela] [bigint] IDENTITY(1,1)             DEFAULT ((0)) NOT NULL,
    [Nome] VARCHAR (50)    DEFAULT ('') NOT NULL,
    [Chave] CHAR (1)        DEFAULT ('0') NOT NULL,
    [Dominio] VARCHAR (100)   DEFAULT ('') NOT NULL,
    [Codigotipo] [bigint] IDENTITY(1,1)             DEFAULT ((0)) NOT NULL,
    [Naonulo] CHAR (1)        DEFAULT ('0') NOT NULL,
    [Unico] CHAR (1)        DEFAULT ('0') NOT NULL,
    [Checar] VARCHAR (300)   DEFAULT ('') NOT NULL,
    [Padrao] VARCHAR (300)   DEFAULT ('') NOT NULL,
    [Comentario] VARCHAR (900)   DEFAULT ('') NOT NULL,
    [Tamanho] [bigint]             DEFAULT ((0)) NOT NULL,
    [Precisao] DECIMAL (15, 4) DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC, [Codigotabela] ASC, [Nome] ASC, [Chave] ASC, [Dominio] ASC, [Codigotipo] ASC, [Naonulo] ASC, [Unico] ASC, [Checar] ASC, [Padrao] ASC, [Comentario] ASC, [Tamanho] ASC, [Precisao] ASC)
);

-- START ../Tables/Cartaocreditodevtools.sql
CREATE TABLE [Cartaocreditodevtools] (
    [Numerocartao] VARCHAR (100) DEFAULT ('') NOT NULL,
    [Datavalidade] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Codigoseguranca] CHAR (3)      DEFAULT ('') NOT NULL,
    [Created] VARCHAR (50)  DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Numerocartao] ASC)
);

-- START ../Tables/Categoriaalimentos.sql
CREATE TABLE [dbo].[Categoriaalimentos]
(
	[Codigo] [bigint] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
    [Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[Descricao] VARCHAR(255) NOT NULL
)
-- START ../Tables/Chavesjwt.sql
CREATE TABLE [Chavesjwt] (
    [Chave] CHAR (60) NOT NULL,
    [Datainsercao] DATE      NULL,
    PRIMARY KEY CLUSTERED ([Chave] ASC)
);

-- START ../Tables/Clientes.sql
CREATE TABLE [Clientes] (
    [Codigo] [bigint] IDENTITY(1,1)            DEFAULT ((0)) NOT NULL,
    [Razaosocial] VARCHAR (1000) DEFAULT ('') NOT NULL,
    [Nomefantasia] VARCHAR (1000) DEFAULT ('') NOT NULL,
    [Cnpj] CHAR (18)      DEFAULT ('') NOT NULL,
    [Cidade] VARCHAR (500)  DEFAULT ('') NOT NULL,
    [Estado] CHAR (2)       DEFAULT ('') NOT NULL,
    [Endereco] VARCHAR (1000) DEFAULT ('') NOT NULL,
    [Cep] VARCHAR (8)    DEFAULT ('') NOT NULL,
    [Email] CHAR (500)     DEFAULT ('') NOT NULL,
    [Telefone] VARCHAR (30)   NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

-- START ../Tables/CodigosTable.sql
CREATE TABLE [CodigosTable] (
    [Tabela] VARCHAR (30) NOT NULL,
    [Codigo] [bigint] IDENTITY(1,1)          DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Tabela] ASC)
);

-- START ../Tables/Comentariosquestoes.sql
create table ComentariosQuestoes(
	Codigo int primary key,
	Comentario varchar(MAX) not null,
	CodigoUsuario int not null,
	CodigoQuestao int not null,
	IsActive char(1) default '1' not null,
	Created DateTime,
	Updated DateTime
);
-- START ../Tables/Configuracaoemail.sql
CREATE TABLE [Configuracaoemail] (
    [Codigo] [bigint] IDENTITY(1,1)           NOT NULL,
    [Emailremetente] VARCHAR (300) DEFAULT ('') NOT NULL,
    [Smtpclient] VARCHAR (100) NULL,
    [Porta] [bigint]           DEFAULT ((587)) NOT NULL,
    [Emailcredencial] VARCHAR (300) DEFAULT ('') NOT NULL,
    [Senhacredencial] VARCHAR (200) DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

-- START ../Tables/Consultas.sql
CREATE TABLE [Consultas] (
    [Codigo] [bigint] IDENTITY(1,1)            NOT NULL,
    [Nomeconsulta] VARCHAR (100)  DEFAULT ('') NOT NULL,
    [Consulta] VARCHAR (4000) DEFAULT ('') NOT NULL,
    [Created] VARCHAR (20)   DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

-- START ../Tables/Contabancofordev.sql
CREATE TABLE [Contabancofordev] (
    [Created] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Contacorrente] VARCHAR (100) DEFAULT ('') NOT NULL,
    [Agencia] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Banco] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Cidade] VARCHAR (150) DEFAULT ('') NOT NULL,
    [Estado] CHAR (2)      DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Contacorrente] ASC)
);

-- START ../Tables/Crudformsinstalador.sql
CREATE TABLE [Crudformsinstalador] (
    [Codigo] [bigint] IDENTITY(1,1)           NOT NULL,
    [Versao] VARCHAR (10)  DEFAULT ('') NOT NULL,
    [Created] DATETIME      DEFAULT (((2022)-(12))-(20)) NOT NULL,
    [Diretorio] VARCHAR (300) DEFAULT ('') NOT NULL,
    [Ativo] VARCHAR (1)   DEFAULT ('1') NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

-- START ../Tables/Despesas.sql
CREATE TABLE [Despesas] (
    [Codigo] [bigint] IDENTITY(1,1)           NOT NULL,
    [Datainsercao] DATETIME      NOT NULL,
    [Datadespesa] VARCHAR (30)  DEFAULT ('') NOT NULL,
    [Descricao] VARCHAR (300) DEFAULT ('') NOT NULL,
    [Categoria] VARCHAR (30)  DEFAULT ('') NOT NULL,
    [Valor] VARCHAR (30)  DEFAULT ('') NOT NULL,
    [Conta] VARCHAR (300) DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

-- START ../Tables/Email.sql
CREATE TABLE [Email] (
    [Codigo] [bigint] IDENTITY(1,1)             NOT NULL,
    [Destinatario] VARCHAR (300)   DEFAULT ('') NOT NULL,
    [Assunto] VARCHAR (300)   DEFAULT ('') NOT NULL,
    [Texto] VARBINARY (MAX) NULL,
    [Dataenvio] DATETIME        NOT NULL,
    [Status] CHAR (1)        DEFAULT ('0') NOT NULL,
    [Observacao] VARCHAR (1000)  NULL
);

-- START ../Tables/Emailanexos.sql
CREATE TABLE [Emailanexos] (
    [Codigo] [bigint] IDENTITY(1,1)           NOT NULL,
    [Codigoemail] [bigint] IDENTITY(1,1)           DEFAULT ((0)) NOT NULL,
    [Arquivo] VARBINARY (1) NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

-- START ../Tables/Emailbackup.sql
CREATE TABLE [Emailbackup] (
    [Codigo] [bigint] IDENTITY(1,1)            NOT NULL,
    [Destinatario] VARCHAR (300)  NOT NULL,
    [Assunto] VARCHAR (300)  NOT NULL,
    [Texto] VARCHAR (8000) NOT NULL,
    [Dataenvio] DATETIME       NOT NULL,
    [Status] CHAR (1)       NOT NULL,
    [Observacao] VARCHAR (1000) NULL
);

-- START ../Tables/Empresafordev.sql
CREATE TABLE [Empresafordev] (
    [Nome] VARCHAR (200) NULL,
    [Cnpj] VARCHAR (15)  DEFAULT ('') NOT NULL,
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
    [Celular] VARCHAR (30)  DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Cnpj] ASC)
);

-- START ../Tables/Licencassunsalepro.sql
create table LicencasSunSalePro(
	Codigo int primary key,
	Licenca varchar(100) not null,
	IsActive char(1) default '1' not null,
	Created DateTime,
	Updated DateTime)
-- START ../Tables/Logg.sql
CREATE TABLE [Logg] (
    [TipoLog] CHAR (1) DEFAULT ('0') NOT NULL,
    PRIMARY KEY CLUSTERED ([TipoLog] ASC)
);

-- START ../Tables/Logger.sql
create table Logger(
	Id int primary key,
	Descricao varchar(MAX) not null,
	Tipo int not null,
	StackTrace varchar(MAX),
	Created DateTime,
	Updated DateTime,
)
-- START ../Tables/Metas.sql
create table Metas(
	Id int identity(1000, 1) primary key,
	Created datetime not null,
	Updated datetime not null,
	IsActive char(1) default '1' not null,
	Meta varchar(max) not null,
	Email varchar(255) not null,
	DataObjetivo datetime not null
)
-- START ../Tables/Modulos.sql
CREATE TABLE [Modulos] (
    [Codigo] [bigint] IDENTITY(1,1)            DEFAULT ((0)) NOT NULL,
    [Nomemodulo] VARCHAR (100)  DEFAULT ('') NOT NULL,
    [Descricao] VARCHAR (1000) NULL,
    [Sequenciaabertura] VARCHAR (1000) NULL,
    [Codigoprojeto] [bigint] IDENTITY(1,1)            DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC, [Codigoprojeto] ASC)
);

-- START ../Tables/Notascortesisu.sql
CREATE TABLE [dbo].[Notascortesisu]
(
	[Id] BIGINT NOT NULL PRIMARY KEY,
	[Year] [bigint] not null,
	[Numeroedicao] char(1) not null,
	[Codigoinstituicaoensino] [bigint] IDENTITY(1,1) not null,
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
-- START ../Tables/Oleosessenciais.sql
CREATE TABLE [Oleosessenciais] (
    [Codigo] [bigint] IDENTITY(1,1)            NOT NULL,
    [Codigoproduto] VARCHAR (20)   NULL,
    [Nome] VARCHAR (300)  DEFAULT ('') NOT NULL,
    [Tamanho] VARCHAR (50)   NULL,
    [Precoregular] VARCHAR (50)   NULL,
    [Precomembros] VARCHAR (50)   NULL,
    [Pv] VARCHAR (20)   DEFAULT ('') NOT NULL,
    [Modousar] VARCHAR (4000) NULL,
    [Descricao] VARCHAR (4000) NULL,
    [Palavraschaves] VARCHAR (4000) DEFAULT ('') NOT NULL,
    [Cor] VARCHAR (300)  NULL,
    [Beneficiosprimarios] VARCHAR (4000) DEFAULT ('') NOT NULL,
    [Descricaoaromatica] VARCHAR (4000) DEFAULT ('') NOT NULL,
    [Metodoextracao] VARCHAR (4000) NULL,
    [Parteplanta] VARCHAR (1000) NULL,
    [Componentesquimicos] VARCHAR (1000) NULL,
    [Usos] VARCHAR (4000) NULL,
    [Precaucoes] VARCHAR (4000) NULL,
    [Tipoproduto] VARCHAR (100)  DEFAULT ('OLEO') NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

-- START ../Tables/Palavras.sql
CREATE TABLE [Palavras] (
    [Id] [bigint] IDENTITY(1,1)           NOT NULL,
    [Nivel] [bigint]           NOT NULL,
    [Palavra] VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Palavra] ASC)
);

-- START ../Tables/Parametros.sql
CREATE TABLE [Parametros] (
    [Chave] VARCHAR (50)  DEFAULT ('0') NOT NULL,
    [Valor] VARCHAR (100) DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Chave] ASC)
);

-- START ../Tables/Pesos.sql
CREATE TABLE [Pesos]
(
	Id int identity(1000, 1) primary key,
	Faculdade varchar(500) not null,
	Curso varchar(500) not null,
	Turno varchar(250) not null,
	Materia varchar(250) not null,
	Peso decimal(10,2) not null
)
-- START ../Tables/Pessoasfordev.sql
CREATE TABLE [Pessoasfordev] (
    [Nome] VARCHAR (2000) DEFAULT ('') NOT NULL,
    [Idade] [bigint]            DEFAULT ((0)) NOT NULL,
    [Cpf] VARCHAR (12)   DEFAULT ('') NOT NULL,
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
    [Corfavorita] VARCHAR (30)   DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Cpf] ASC)
);

-- START ../Tables/Postagem.sql
create table Postagem(
	Id int identity(1000, 1) primary key,
	Created datetime not null,
	Updated datetime not null,
	IsActive char(1) default '1' not null,
	Descricao varchar(max) not null,
	DescricaoEn varchar(max) not null,
	TipoPostagem int,
	Capa varchar(255) not null,
	Curtidas int default 0 not null
)
-- START ../Tables/Projeto.sql
CREATE TABLE [Projeto] (
    [Codigo] [bigint] IDENTITY(1,1)           DEFAULT ((0)) NOT NULL,
    [Nome] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Descricao] VARCHAR (400) NULL,
    [Status] CHAR (1)      NULL,
    [Git] VARCHAR (200) DEFAULT ('-') NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

-- START ../Tables/Prova.sql
CREATE TABLE [Prova] (
    [Codigo] [bigint] IDENTITY(1,1)             NOT NULL,
    [Nomeprova] VARCHAR (500)   DEFAULT ('') NOT NULL,
    [Local] VARCHAR (500)   DEFAULT ('') NOT NULL,
    [Tipoprova] VARCHAR (100)   DEFAULT ('') NOT NULL,
    [Dataaplicacao] VARCHAR (10)    DEFAULT ('') NOT NULL,
    [Prova] VARBINARY (MAX) NULL,
    [Gabarito] VARBINARY (MAX) NULL,
    [Observacaoprova] VARCHAR (3000)  NULL,
    [Observacaogabarito] VARCHAR (2000)  DEFAULT ('') NOT NULL,
    [Dataregistro] DATETIME        NOT NULL,
    [Banca] VARCHAR (1000)  NULL,
    [Updatedby] [bigint],
    [Updatedon] DATETIME,
    [Createdby] [bigint],
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

-- START ../Tables/Questoesavaliacao.sql
CREATE TABLE [dbo].[Questoesavaliacao]
(
	[Id] [bigint] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Createdon] DATETIME not null,
    [Createdby] [bigint] not null,
	[Idavaliacao] [bigint] not null,
	[Idquestao] [bigint] not null,
	[Notaquestao] decimal(10,2) default 1
)
-- START ../Tables/Receitas.sql
CREATE TABLE [Receitas] (
    [Codigo] [bigint] IDENTITY(1,1)           NOT NULL,
    [Dataregistro] DATETIME      NOT NULL,
    [Datatransacao] VARCHAR (30)  DEFAULT ('') NOT NULL,
    [Descricao] VARCHAR (300) DEFAULT ('') NOT NULL,
    [Categoria] VARCHAR (300) DEFAULT ('') NOT NULL,
    [Valor] VARCHAR (30)  DEFAULT ('') NOT NULL,
    [Conta] VARCHAR (300) DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

-- START ../Tables/Recuperasenha.sql
create table [Recuperasenha]
(
	Code int primary key,
	Created datetime,
	Updated datetime,
	Guid varchar(100) not null,
	EmailUser varchar(300) not null,
	Validated char(1) default '0' not null
)
-- START ../Tables/Recuperasenhaconcursando.sql
CREATE TABLE [Recuperasenhaconcursando] (
    [Codigo] [bigint] IDENTITY(1,1)           NOT NULL,
    [Dataregistro] DATETIME      NOT NULL,
    [Guid] VARCHAR (64)  DEFAULT ('') NOT NULL,
    [Email] VARCHAR (300) DEFAULT ('') NOT NULL,
    [Recuperado] CHAR (1)      DEFAULT ('0') NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

-- START ../Tables/Recuperasenhacrudforms.sql
CREATE TABLE [Recuperasenhacrudforms] (
    [Codigo] [bigint] IDENTITY(1,1)           NOT NULL,
    [Created] DATETIME      NOT NULL,
    [Guid] VARCHAR (64)  NULL,
    [Email] VARCHAR (300) NULL,
    [Recuperado] CHAR (1)      DEFAULT ('0') NOT NULL,
    [Updated] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

-- START ../Tables/Relacao.sql
CREATE TABLE [Relacao] (
    [Codigo] [bigint] IDENTITY(1,1)           DEFAULT ((0)) NOT NULL,
    [Codigoprojeto] [bigint] IDENTITY(1,1)           DEFAULT ((0)) NOT NULL,
    [Tabelaorigem] [bigint]           DEFAULT ((0)) NOT NULL,
    [Campoorigem] [bigint]           DEFAULT ((0)) NOT NULL,
    [Tabeladestino] [bigint]           DEFAULT ((0)) NOT NULL,
    [Campodestino] [bigint]           DEFAULT ((0)) NOT NULL,
    [Cardinalidadeorigem] VARCHAR (1)   DEFAULT ('') NOT NULL,
    [Cardinalidadedestino] VARCHAR (1)   DEFAULT ('') NOT NULL,
    [Foreingkey] VARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

-- START ../Tables/Respostasavaliacoes.sql
CREATE TABLE [dbo].[Respostasavaliacoes]
(
	[Id] [bigint] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Createdon] DATETIME not null,
	[Updatedon] DATETIME not null,
	[Createdby] [bigint] not null,
	[Updatedby] [bigint] not null,
	[Idavaliacao] [bigint] not null,
	[Idquestao] [bigint] not null,
	[Idresposta] [bigint] not null,
)
-- START ../Tables/Respostasusuarios.sql
CREATE TABLE [Respostasusuarios] (
    [Codigo] [bigint] IDENTITY(1,1)      NOT NULL,
    [Codigousuario] [bigint] IDENTITY(1,1)      DEFAULT ((0)) NOT NULL,
    [Codigoresposta] [bigint] IDENTITY(1,1)      DEFAULT ((0)) NOT NULL,
    [Dataresposta] DATETIME NOT NULL,
    [Codigoquestao] [bigint] IDENTITY(1,1),
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

-- START ../Tables/Resultadossoletrando.sql
CREATE TABLE [Resultadossoletrando] (
    [Id] [bigint] IDENTITY(1,1)           NOT NULL,
    [Nome] VARCHAR (100) NOT NULL,
    [Numeroacertos] [bigint]           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

-- START ../Tables/Resultadostabuadadivertida.sql
CREATE TABLE [dbo].[Resultadostabuadadivertida]
(
	Codigo int primary key,
	Nome varchar(300) not null,
	Tempo int not null,
	NumeroAcertos int not null,
	Created DateTime,
	Tipo char(1),
	NumeroQuestoes int
)
-- START ../Tables/Savedresultswpp.sql
create table SavedResultsWpp(
	Id int identity(1000, 1) primary key,
	Created datetime not null,
	Updated datetime not null,
	IsActive char(1) default '1' not null,
	[Json] varchar(max) not null,
)
-- START ../Tables/Simulados.sql
create table Simulados(
	Codigo int primary key,
	Respostas varchar(MAX) not null,
	Created DateTime,
	CodigoUsuario int not null,
	CodigoProva int not null,
	QuantidadeQuestoes int not null,
	QuantidadeCertas int not null,
	Tempo int not null
)
-- START ../Tables/Tabela.sql
CREATE TABLE [Tabela] (
    [Codigo] [bigint] IDENTITY(1,1)           DEFAULT ((0)) NOT NULL,
    [Projeto] [bigint]           DEFAULT ((0)) NOT NULL,
    [Nome] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Descricao] VARCHAR (400) NULL,
    [Notas] VARCHAR (400) NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC, [Projeto] ASC)
);

-- START ../Tables/Tabelas.sql
CREATE TABLE [Tabelas] (
    [Tab] VARCHAR (40) DEFAULT ('') NOT NULL,
    [Field] VARCHAR (25) DEFAULT ('') NOT NULL,
    [Type] CHAR (1)     DEFAULT ('') NOT NULL,
    [Size] [bigint]          DEFAULT ((0)) NOT NULL,
    [Prec] [bigint]          DEFAULT ((0)) NOT NULL,
    [Flag] [bigint]          DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Tab] ASC, [Field] ASC, [Type] ASC, [Size] ASC, [Prec] ASC, [Flag] ASC)
);

-- START ../Tables/Tabelasmodulos.sql
CREATE TABLE [Tabelasmodulos] (
    [Codigotabela] [bigint] IDENTITY(1,1) DEFAULT ((0)) NOT NULL,
    [Codigocampo] [bigint] IDENTITY(1,1) DEFAULT ((0)) NOT NULL,
    [Codigomodulo] [bigint] IDENTITY(1,1) DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigotabela] ASC, [Codigocampo] ASC, [Codigomodulo] ASC)
);

-- START ../Tables/Temp1.sql
CREATE TABLE [Temp1] (
    [Teste] VARBINARY (MAX) NULL
);

-- START ../Tables/Teste.sql
CREATE TABLE [Teste] (
    [Testecampo] VARCHAR (MAX) NULL
);

-- START ../Tables/Tipocampo.sql
CREATE TABLE [Tipocampo] (
    [Codigo] [bigint] IDENTITY(1,1)          DEFAULT ((0)) NOT NULL,
    [Nome] VARCHAR (50) DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC, [Nome] ASC)
);

-- START ../Tables/Tipoperfil.sql
CREATE TABLE [dbo].[Tipoperfil]
(
	[Id] [char](1) NOT NULL PRIMARY KEY,
	[Descricao] [nvarchar](255) not null,
	[Created] [DateTime] not null,
	[Updated] [DateTime] not null
)
-- START ../Tables/Tipopostagem.sql
create table TipoPostagem(
	id int primary key,
	descricao varchar(255),
	created datetime,
	updated datetime
)
-- START ../Tables/Tipoprova.sql
create table TipoProva(
	Codigo int primary key,
	Descricao Varchar(255) not null,
	Created DateTime,
	Updated DateTime,
	CreatedBy int,
	UpdatedBy int,
	IsActive char(1) default '1'
);
-- START ../Tables/Tipoprovaassociado.sql
create table TipoProvaAssociado(
	Codigo int primary key,
	CodigoTipo int,
	CodigoProva int
);
-- START ../Tables/Tiposuporte.sql
CREATE TABLE [Tiposuporte] (
    [Codigo] [bigint] IDENTITY(1,1)            NOT NULL,
    [Descricao] VARCHAR (1000) DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

-- START ../Tables/Traducoes.sql
CREATE TABLE [Traducoes] (
    [Codigo] [bigint] IDENTITY(1,1)           NOT NULL,
    [Dataregistro] DATETIME      NOT NULL,
    [Palavraportugues] VARCHAR (300) DEFAULT ('') NOT NULL,
    [Palavraingles] VARCHAR (300) DEFAULT ('') NOT NULL,
    [Classegramatical] VARCHAR (100) DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

-- START ../Tables/Usuarioconcursando.sql
CREATE TABLE [Usuarioconcursando] (
    [Codigo] [bigint] IDENTITY(1,1)           NOT NULL,
    [Datanascimento] DATE          NOT NULL,
    [Email] VARCHAR (300) NOT NULL,
    [Nome] VARCHAR (200) NOT NULL,
    [Password] VARCHAR (100) NOT NULL,
    [Admin] CHAR (1)      DEFAULT ('0') NOT NULL,
    [Created] DATETIME      DEFAULT (getdate()) NOT NULL,
    [Bot] CHAR (1)      DEFAULT ('0') NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

-- START ../Tables/Usuarioscrudforms.sql
CREATE TABLE [Usuarioscrudforms] (
    [Codigo] [bigint] IDENTITY(1,1)           NOT NULL,
    [Login] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Senha] VARCHAR (20)  DEFAULT ('') NOT NULL,
    [Administrador] CHAR (1)      DEFAULT ('0') NOT NULL,
    [Desenvolvedor] CHAR (1)      DEFAULT ('0') NOT NULL,
    [Email] VARCHAR (200) DEFAULT ('') NOT NULL,
    [Usuariopai] [bigint]           DEFAULT ((-1)) NOT NULL,
    Nome            varchar(100),
    Created         DateTime      Default Getdate() not null,
    Updated         DateTime      Default Getdate() not null,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

-- START ../Tables/Veiculosfordev.sql
CREATE TABLE [Veiculosfordev] (
    [Marca] VARCHAR (300) DEFAULT ('') NOT NULL,
    [Modelo] VARCHAR (300) DEFAULT ('') NOT NULL,
    [Ano] VARCHAR (10)  DEFAULT ('') NOT NULL,
    [Renavam] VARCHAR (30)  DEFAULT ('') NOT NULL,
    [Placaveiculo] VARCHAR (20)  DEFAULT ('') NOT NULL,
    [Cor] VARCHAR (50)  DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Renavam] ASC)
);

-- START ../Tables/Verboconjugado.sql
CREATE TABLE [Verboconjugado] (
    [Codigo] [bigint] IDENTITY(1,1)           NOT NULL,
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

-- START ../Tables/Verbos.sql
CREATE TABLE [Verbos] (
    [Codigo] [bigint] IDENTITY(1,1)           NOT NULL,
    [Palavra] VARCHAR (500) DEFAULT ('') NOT NULL,
    [Datainsercao] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

-- START ../Tables/Verificacaousuario.sql
create table VerificacaoUsuario(
	codigo int primary key,
	GuidText varchar(64) not null,
	CodigoUsuario int not null,
	IsActive char(1) default '1',
	Created DateTime,
	Updated DateTime
);
-- START ../Tables/Versao.sql
CREATE TABLE [Versao] (
    [Dercreator] VARCHAR (10) NULL
);

-- START ../Tables/Whosthatpokemonresult.sql
create table WhosThatPokemonResult(
	Id int identity(1000, 1) primary key,
	Nome varchar(255),
	Created Datetime not null,
	Updated DateTime not null,
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
