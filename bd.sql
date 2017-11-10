CREATE TABLE base (
  [Id] [int] AUTO_INCREMENT NOT NULL,
  [palavra] [varchar](30) NOT NULL,
  [subpalavra] [varchar](30) NULL,
  [idioma] [char](2) NULL,
  [contexto] [varchar](30) NULL,
  [equivalente] [int] NULL,
  [palavra_catGram] [int] NULL,
  [subpalavra_catGram] [int] NULL,
  [acepcao] [varchar] NULL,
  [definicao] [varchar] NULL,
  [exemplos_original] [varchar] NULL,
  [exemplos_traduzido] [varchar] NULL,
  [traducao] [varchar] NOT NULL,
  [rubrica] [varchar] NULL,
  [falsos_cognatos] [int] NULL,
  [referencia_verbete] [int] NULL,
  [referencia_exemplo] [int] NULL,
  [notas_gramatica] [varchar] NULL,
  [notas_cultura] [varchar] NULL,
  [heterogenerico] [varchar] NULL,
  [heterotonico] [varchar] NULL,
  CONSTRAINT [PK_Id_base] PRIMARY KEY CLUSTERED ([Id] ASC)
)
CREATE TABLE falso_cognato (
  [Id] [int] AUTO_INCREMENT NOT NULL,
  [pai] [int] NOT NULL,
  [verbete] [int] NOT NULL,
  CONSTRAINT [PK_Id_Cognato] PRIMARY KEY CLUSTERED ([Id] ASC)
)
CREATE TABLE referencias(
  [Cod] [int] NOT NULL,
  [Descricao] [varchar](50) NOT NULL,
  [Ano] [int] NULL,
  [Autor] [varchar](20) NULL,
  CONSTRAINT [PK_CodReferencia] PRIMARY KEY
)
CREATE TABLE usr (
  [usr] [varchar](10) NOT NULL,
  [pass] [varchar](15) NOT NULL,
  [nivel_permissao] [int] NOT NULL,
  CONSTRAINT [PK_Usr] PRIMARY KEY
)
CREATE TABLE categoriaGram(
  [Id] [int] AUTO_INCREMENT NOT NULL,
  [Descricao] [varchar](30) NULL,
  [sigla] [varchar](5) NOT NULL
)
