-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.0.16-nt


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema empresa
--

CREATE DATABASE IF NOT EXISTS empresa;
USE empresa;

--
-- Definition of table `cargo`
--

DROP TABLE IF EXISTS `cargo`;
CREATE TABLE `cargo` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `iddepartamento` int(10) unsigned NOT NULL,
  `nomecargo` varchar(45) NOT NULL,
  `salariomedio` double NOT NULL,
  PRIMARY KEY  (`id`),
  KEY `FK_cargo_1` (`iddepartamento`),
  CONSTRAINT `FK_cargo_1` FOREIGN KEY (`iddepartamento`) REFERENCES `departamento` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cargo`
--

/*!40000 ALTER TABLE `cargo` DISABLE KEYS */;
INSERT INTO `cargo` (`id`,`iddepartamento`,`nomecargo`,`salariomedio`) VALUES 
 (1,1,'SUPORTE NÍVEL 1',2000),
 (2,1,'SUPORTE NÍVEL 2',2500),
 (3,1,'SUPORTE NÍVEL 3',3000),
 (4,2,'ANALISTA JR',3500),
 (5,2,'ANALISTA PL',4500),
 (6,2,'ANALISTA SR',5500),
 (7,1,'GERENTE',5500),
 (8,2,'GERENTE',7500),
 (9,3,'GERENTE',6500);
/*!40000 ALTER TABLE `cargo` ENABLE KEYS */;


--
-- Definition of table `departamento`
--

DROP TABLE IF EXISTS `departamento`;
CREATE TABLE `departamento` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `nome` varchar(45) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `departamento`
--

/*!40000 ALTER TABLE `departamento` DISABLE KEYS */;
INSERT INTO `departamento` (`id`,`nome`) VALUES 
 (1,'SUPORTE AO CLIENTE'),
 (2,'DESENVOLVIMENTO'),
 (3,'COMERCIAL');
/*!40000 ALTER TABLE `departamento` ENABLE KEYS */;


--
-- Definition of table `funcionario`
--

DROP TABLE IF EXISTS `funcionario`;
CREATE TABLE `funcionario` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `idpessoa` int(10) unsigned NOT NULL,
  `idcargo` int(10) unsigned NOT NULL,
  `salario` double NOT NULL,
  `dtcontratacao` datetime NOT NULL,
  `dtrecisao` datetime NOT NULL,
  `situacao` int(10) unsigned NOT NULL default '0' COMMENT '0 contratado; 1 suspenso; 2 demitido',
  `salariotemp` double NOT NULL,
  PRIMARY KEY  (`id`),
  KEY `FK_funcionario_1` (`idpessoa`),
  KEY `FK_funcionario_2` (`idcargo`),
  CONSTRAINT `FK_funcionario_1` FOREIGN KEY (`idpessoa`) REFERENCES `pessoa` (`id`),
  CONSTRAINT `FK_funcionario_2` FOREIGN KEY (`idcargo`) REFERENCES `cargo` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `funcionario`
--

/*!40000 ALTER TABLE `funcionario` DISABLE KEYS */;
INSERT INTO `funcionario` (`id`,`idpessoa`,`idcargo`,`salario`,`dtcontratacao`,`dtrecisao`,`situacao`,`salariotemp`) VALUES 
 (1,1,8,8000,'1999-01-02 00:00:00','1900-01-01 00:00:00',0,0),
 (2,2,9,8000,'1999-01-02 00:00:00','1900-01-01 00:00:00',0,0),
 (3,3,8,6000,'1999-01-02 00:00:00','2018-01-02 00:00:00',1,0),
 (4,4,6,5500,'2019-01-02 00:00:00','1900-01-01 00:00:00',0,0),
 (5,5,6,6000,'2010-01-02 00:00:00','1900-01-01 00:00:00',0,0),
 (6,6,5,5000,'2019-01-01 00:00:00','1900-01-01 00:00:00',0,0),
 (7,7,3,3000,'2019-01-01 00:00:00','1900-01-01 00:00:00',0,0),
 (8,8,3,3000,'2019-01-01 00:00:00','1900-01-01 00:00:00',0,0),
 (9,9,3,3100,'2019-01-01 00:00:00','1900-01-01 00:00:00',0,0),
 (10,10,2,2800,'2019-01-01 00:00:00','1900-01-01 00:00:00',0,0),
 (11,11,2,2500,'2007-01-02 00:00:00','1900-01-01 00:00:00',0,0),
 (12,12,2,2500,'2007-01-02 00:00:00','2020-05-08 00:00:00',1,0),
 (13,13,1,2100,'2019-01-01 00:00:00','1900-01-01 00:00:00',0,0),
 (14,14,1,2000,'2020-10-02 00:00:00','1900-01-01 00:00:00',0,0),
 (15,15,7,6000,'2011-01-02 00:00:00','1900-01-01 00:00:00',0,0),
 (16,16,6,6000,'2007-01-02 00:00:00','2019-03-01 00:00:00',1,0),
 (17,17,5,4500,'2015-01-02 00:00:00','1900-01-01 00:00:00',0,0),
 (18,18,5,4500,'2015-01-02 00:00:00','1900-01-01 00:00:00',0,0),
 (19,19,5,4500,'2007-01-02 00:00:00','1900-01-01 00:00:00',0,0),
 (20,20,3,3200,'2019-01-02 00:00:00','1900-01-01 00:00:00',0,0),
 (21,21,1,2200,'2019-01-02 00:00:00','1900-01-01 00:00:00',0,0),
 (22,22,2,2800,'2019-01-02 00:00:00','1900-01-01 00:00:00',0,0);
/*!40000 ALTER TABLE `funcionario` ENABLE KEYS */;


--
-- Definition of table `pessoa`
--

DROP TABLE IF EXISTS `pessoa`;
CREATE TABLE `pessoa` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `nome` varchar(100) NOT NULL,
  `dtnascimento` date NOT NULL,
  `sexo` int(10) unsigned NOT NULL COMMENT '0 M 1 F',
  `cpf` varchar(14) NOT NULL COMMENT 'Gravar pontos e traços',
  `nomemae` varchar(100) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pessoa`
--

/*!40000 ALTER TABLE `pessoa` DISABLE KEYS */;
INSERT INTO `pessoa` (`id`,`nome`,`dtnascimento`,`sexo`,`cpf`,`nomemae`) VALUES 
 (1,'JOÃO','1980-09-10',0,'711.521.740-88','MÃE JOÃO'),
 (2,'MARIA','1981-01-22',1,'508.255.330-58','MÃE MARIA'),
 (3,'PAULO','1970-10-10',0,'743.958.590-97','MÃE PAULO'),
 (4,'ZÉ','1990-08-08',0,'893.912.630-03','MÃE ZÉ'),
 (5,'JERRY','1983-07-08',0,'553.004.330-51','MÃE JERRY'),
 (6,'JOSE VICTOR','1988-03-22',0,'006.921.090-05','MÃE JOSE VICTOR'),
 (7,'LUIZ CARLOS','1991-01-03',0,'527.535.710-90','MÃE LUIZ CARLOS'),
 (8,'ANGELA','1985-11-19',1,'089.725.860-64','MÃE ANGELA'),
 (9,'ADOLFO','1990-01-02',0,'490.130.880-74','MÃE ADOLFO'),
 (10,'MAURO','1990-01-03',0,'003.263.500-12','MÃE MAURO'),
 (11,'DECIO','1990-01-04',0,'737.037.340-12','MÃE DECIO'),
 (12,'FLAVIO','1990-01-05',0,'020.957.850-53','MÃE FLAVIO'),
 (13,'WANDERLEY','1990-01-06',0,'586.196.320-78','MÃE WANDERLEY'),
 (14,'LEDA','1990-01-07',1,'431.359.870-78','MÃE LEDA'),
 (15,'MARIA APARECIDA','1990-01-08',1,'857.949.620-97','MÃE MARIA APARECIDA'),
 (16,'JOAO ALBERTO','1984-01-02',0,'006.343.350-81','MÃE JOAO ALBERTO'),
 (17,'RITA','1984-01-04',1,'800.488.580-21','MÃE RITA'),
 (18,'ALFREDO','1984-04-02',0,'897.889.400-30','MÃE ALFREDO'),
 (19,'RITA DE CASSIA','1984-12-02',1,'944.078.890-98','MÃE RITA DE CASSIA'),
 (20,'CELIA','1987-01-02',1,'906.550.320-02','MÃE CELIA'),
 (21,'SALIN','1991-07-11',0,'055.546.780-50','MÃE SALIN'),
 (22,'WILSON','1989-06-10',0,'144.636.690-11','MÃE WILSON');
/*!40000 ALTER TABLE `pessoa` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
