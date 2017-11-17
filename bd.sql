CREATE DATABASE dicionario;

CREATE TABLE base (
  Id int AUTO_INCREMENT NOT NULL,
  palavra varchar(30) NOT NULL,
  subpalavra varchar(30) NULL,
  idioma char(2) NULL,
  contexto varchar(30) NULL,
  equivalente int NULL,
  palavra_catGram int NULL,
  subpalavra_catGram int NULL,
  palavra_classeGram int NULL,
  subpalavra_classeGram int NULL,
  acepcao varchar(30) NULL,
  definicao varchar(30) NULL,
  exemplos_original varchar(30) NULL,
  exemplos_traduzido varchar(30) NULL,
  traducao varchar(30) NOT NULL,
  rubrica varchar(30) NULL,
  falsos_cognatos int NULL,
  referencia_verbete int NULL,
  referencia_exemplo int NULL,
  notas_gramatica varchar(30) NULL,
  notas_cultura varchar(30) NULL,
  heterogenerico varchar(30) NULL,
  heterotonico varchar(30) NULL,
  CONSTRAINT PK_Id_base PRIMARY KEY CLUSTERED (Id ASC)
);
CREATE TABLE falso_cognato (
  Id int AUTO_INCREMENT NOT NULL,
  pai int NOT NULL,
  verbete int NOT NULL,
  CONSTRAINT PK_Id_Cognato PRIMARY KEY CLUSTERED (Id ASC)
);
CREATE TABLE referencias(
  Cod int NOT NULL,
  Descricao varchar(50) NOT NULL,
  Ano int NULL,
  Autor varchar(20) NULL,
  CONSTRAINT PK_CodReferencia PRIMARY KEY CLUSTERED (Cod ASC)
);
CREATE TABLE usr (
  usr varchar(10) NOT NULL,
  pass varchar(15) NOT NULL,
  nivel_permissao int NOT NULL,
  email varchar(50) NOT NULL,
  nome varchar(50) NULL,
  contato varchar(15) NULL,
  rede social varchar(15) NULL,
  cpf int(11) NULL,
  CONSTRAINT PK_Usr PRIMARY KEY CLUSTERED (usr ASC)
);
CREATE TABLE categoriaGram(
  Id int AUTO_INCREMENT NOT NULL,
  Descricao varchar(30) NULL,
  sigla varchar(5) NOT NULL
);
CREATE TABLE classeGram(
  Id int AUTO_INCREMENT NOT NULL,
  Descricao varchar(30) NULL,
  sigla varchar(5) NOT NULL
);
/* A tabela de palvras ignoradas vai aqui. Pensar numa estrutura interessante
CREATE TABLE ignoraBusca(

)*/
/*--Table for statistics
CREATE TABLE statistics(

)*/
