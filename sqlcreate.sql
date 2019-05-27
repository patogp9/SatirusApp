-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.1.30-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win32
-- HeidiSQL Versión:             9.3.0.4984
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Volcando estructura de base de datos para satirus
CREATE DATABASE IF NOT EXISTS `satirus` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `satirus`;




-- Volcando estructura para tabla satirus.karma
CREATE TABLE IF NOT EXISTS `karma` (
  `id` int(3) unsigned NOT NULL AUTO_INCREMENT,
  `karma` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla satirus.karma: ~3 rows (aproximadamente)
DELETE FROM `karma`;
/*!40000 ALTER TABLE `karma` DISABLE KEYS */;
INSERT INTO `karma` (`id`, `karma`) VALUES
	(1, 'good'),
	(2, 'neutral'),
	(3, 'bad');
/*!40000 ALTER TABLE `karma` ENABLE KEYS */;


-- Volcando estructura para tabla satirus.order
CREATE TABLE IF NOT EXISTS `order` (
  `id` int(3) unsigned NOT NULL AUTO_INCREMENT,
  `order` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

-- Volcando datos para la tabla satirus.order: ~3 rows (aproximadamente)
DELETE FROM `order`;
/*!40000 ALTER TABLE `order` DISABLE KEYS */;
INSERT INTO `order` (`id`, `order`) VALUES
	(1, 'lawful'),
	(2, 'neutral'),
	(3, 'chaotic');
/*!40000 ALTER TABLE `order` ENABLE KEYS */;


-- Volcando estructura para tabla satirus.pj
CREATE TABLE IF NOT EXISTS `pj` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(50) DEFAULT NULL,
  `level` tinyint(3) unsigned NOT NULL DEFAULT '1',
  `race` varchar(50) DEFAULT NULL,
  `order` int(3) unsigned NOT NULL,
  `karma` int(3) unsigned NOT NULL,
  `exp` int(11) unsigned DEFAULT NULL,
  `str` int(11) DEFAULT NULL,
  `int` int(11) DEFAULT NULL,
  `res` int(11) DEFAULT NULL,
  `agi` int(11) DEFAULT NULL,
  `cha` int(11) DEFAULT NULL,
  `luc` int(11) DEFAULT NULL,
  `bstr` int(11) DEFAULT NULL,
  `bint` int(11) DEFAULT NULL,
  `bres` int(11) DEFAULT NULL,
  `bagi` int(11) DEFAULT NULL,
  `bcha` int(11) DEFAULT NULL,
  `bluc` int(11) DEFAULT NULL,
  `hp` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FKorder` (`order`),
  KEY `FKkarma` (`karma`),
  CONSTRAINT `FKkarma` FOREIGN KEY (`karma`) REFERENCES `karma` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FKorder` FOREIGN KEY (`order`) REFERENCES `order` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla satirus.pj: ~9 rows (aproximadamente)
DELETE FROM `pj`;
/*!40000 ALTER TABLE `pj` DISABLE KEYS */;
/*!40000 ALTER TABLE `pj` ENABLE KEYS */;

-- Volcando estructura para tabla satirus.inventory
CREATE TABLE IF NOT EXISTS `inventory` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `owner` int(11) unsigned NOT NULL,
  `item` varchar(50) DEFAULT NULL,
  `description` text,
  PRIMARY KEY (`id`),
  KEY `FKownerBCKPCK` (`owner`),
  CONSTRAINT `FKownerBCKPCK` FOREIGN KEY (`owner`) REFERENCES `pj` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla satirus.inventory: ~0 rows (aproximadamente)
DELETE FROM `inventory`;
/*!40000 ALTER TABLE `inventory` DISABLE KEYS */;
/*!40000 ALTER TABLE `inventory` ENABLE KEYS */;


-- Volcando estructura para tabla satirus.spellbook
CREATE TABLE IF NOT EXISTS `spellbook` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `owner` int(11) unsigned NOT NULL,
  `spell` varchar(50) DEFAULT NULL,
  `description` text,
  PRIMARY KEY (`id`),
  KEY `FKownerSPLLBK` (`owner`),
  CONSTRAINT `FKownerSPLLBK` FOREIGN KEY (`owner`) REFERENCES `pj` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

-- Volcando datos para la tabla satirus.spellbook: ~0 rows (aproximadamente)
DELETE FROM `spellbook`;
/*!40000 ALTER TABLE `spellbook` DISABLE KEYS */;
/*!40000 ALTER TABLE `spellbook` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
