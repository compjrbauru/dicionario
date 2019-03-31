-- MySQL dump 10.13  Distrib 5.6.23, for Win32 (x86)
--
-- Host: localhost    Database: dicionario
-- ------------------------------------------------------
-- Server version	5.7.22-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `categoriagram`
--

DROP TABLE IF EXISTS `categoriagram`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categoriagram` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `sigla` varchar(4) COLLATE utf8_unicode_ci NOT NULL COMMENT '	',
  `definicao` text COLLATE utf8_unicode_ci,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `classegram`
--

DROP TABLE IF EXISTS `classegram`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `classegram` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `sigla` varchar(4) COLLATE utf8_unicode_ci NOT NULL COMMENT '	',
  `Definicao` text COLLATE utf8_unicode_ci,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `conjugacao`
--

DROP TABLE IF EXISTS `conjugacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `conjugacao` (
  `idconjugacao` int(11) NOT NULL AUTO_INCREMENT,
  `Preterito` text COLLATE utf8_unicode_ci,
  `Presente` text COLLATE utf8_unicode_ci,
  `Futuro` text COLLATE utf8_unicode_ci,
  PRIMARY KEY (`idconjugacao`),
  UNIQUE KEY `idconjugacao_UNIQUE` (`idconjugacao`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `equivalencias`
--

DROP TABLE IF EXISTS `equivalencias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `equivalencias` (
  `Origem` int(11) NOT NULL,
  `equivalente` int(11) NOT NULL COMMENT '	',
  `heterogenerico` tinyint(1) NOT NULL DEFAULT '0',
  `heterotonico` tinyint(1) NOT NULL DEFAULT '0',
  `heterossemantico` tinyint(1) NOT NULL DEFAULT '0',
  `Exemplo` tinytext,
  `Exemplo_Traduzido` tinytext,
  `Referencia` int(11) DEFAULT NULL,
  `Rubrica` int(11) DEFAULT NULL,
  `nApresentacao` int(4) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Origem`,`equivalente`,`nApresentacao`),
  KEY `fk_Equivalencias_2_idx` (`equivalente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Equivalente também vale como *Tradução*';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `gramatverbo`
--

DROP TABLE IF EXISTS `gramatverbo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gramatverbo` (
  `Id` int(11) NOT NULL,
  `Descricao` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `sigla` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='Para uso nos complementos';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `palavra`
--

DROP TABLE IF EXISTS `palavra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `palavra` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Lema` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `Id_classeGram` int(11) DEFAULT NULL,
  `Idioma` char(2) COLLATE utf8_unicode_ci NOT NULL,
  `notas_gramatica` tinytext COLLATE utf8_unicode_ci,
  `notas_cultura` text COLLATE utf8_unicode_ci,
  `Id_conjuga` int(11) DEFAULT NULL,
  `Genero` enum('M','F','N') COLLATE utf8_unicode_ci DEFAULT 'N',
  `Definicao` text COLLATE utf8_unicode_ci,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`),
  UNIQUE KEY `IDX_EntradaUnica` (`Lema`,`Idioma`,`Id_classeGram`),
  KEY `FK_Classe_idx` (`Id_classeGram`),
  CONSTRAINT `FK_Classe` FOREIGN KEY (`Id_classeGram`) REFERENCES `classegram` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `referencias`
--

DROP TABLE IF EXISTS `referencias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `referencias` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Cod` char(6) COLLATE utf8_unicode_ci NOT NULL,
  `Descricao` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `Ano` int(4) DEFAULT NULL,
  `Autor` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `rubrica`
--

DROP TABLE IF EXISTS `rubrica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rubrica` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `sigla` varchar(4) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=77 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `usr`
--

DROP TABLE IF EXISTS `usr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usr` (
  `usr` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `pass` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `nivel_permissao` enum('ADM','EDT','USR') COLLATE utf8_unicode_ci NOT NULL,
  `email` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `nome` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `contato` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `rede_social` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `cpf` char(11) COLLATE utf8_unicode_ci NOT NULL,
  `telefone` char(13) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`usr`),
  UNIQUE KEY `usr_UNIQUE` (`usr`),
  UNIQUE KEY `cpf_UNIQUE` (`cpf`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-03-31  0:44:39
