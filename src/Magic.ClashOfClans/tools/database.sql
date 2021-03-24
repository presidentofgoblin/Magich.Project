SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

CREATE DATABASE IF NOT EXISTS `ucsdb` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `ucsdb`;

CREATE TABLE IF NOT EXISTS `clan` (
  `ClanId` bigint(20) NOT NULL COMMENT 'The ID of the Clan',
  `LastUpdateTime` datetime NOT NULL COMMENT 'The last time when this clan has been loaded',
  `Data` text CHARACTER SET utf8mb4 NOT NULL COMMENT 'The infos and members data of the clan',
  PRIMARY KEY (`ClanId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE IF NOT EXISTS `player` (
  `PlayerId` bigint(20) NOT NULL,
  `AccountStatus` tinyint(4) NOT NULL,
  `AccountPrivileges` tinyint(4) NOT NULL,
  `LastUpdateTime` datetime NOT NULL,
  `IPAddress` varchar(255) DEFAULT NULL,
  `Avatar` mediumtext CHARACTER SET utf8mb4 NOT NULL,
  `GameObjects` mediumtext CHARACTER SET utf8mb4 NOT NULL,
  PRIMARY KEY (`PlayerId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
