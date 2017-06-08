-- phpMyAdmin SQL Dump
-- version 4.2.7.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Erstellungszeit: 08. Jun 2017 um 14:35
-- Server Version: 5.6.20
-- PHP-Version: 5.5.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Datenbank: `lagerverwaltung`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `lager`
--

CREATE TABLE IF NOT EXISTS `lager` (
`LagerID` int(11) NOT NULL,
  `Standort` varchar(255) NOT NULL,
  `Kapazitaet` int(11) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Daten für Tabelle `lager`
--

INSERT INTO `lager` (`LagerID`, `Standort`, `Kapazitaet`) VALUES
(1, 'Köln', 20000),
(2, 'Bonn', 10000),
(3, 'Leverkusen', 15000);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `paletten`
--

CREATE TABLE IF NOT EXISTS `paletten` (
  `PaletteID` int(11) NOT NULL,
  `LagerID` int(11) NOT NULL,
  `ProduktID` int(11) NOT NULL,
  `Einheiten` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `produkte`
--

CREATE TABLE IF NOT EXISTS `produkte` (
`ProduktID` int(11) NOT NULL,
  `Bezeichnung` varchar(255) NOT NULL,
  `MaxEinheiten` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `lager`
--
ALTER TABLE `lager`
 ADD PRIMARY KEY (`LagerID`);

--
-- Indexes for table `paletten`
--
ALTER TABLE `paletten`
 ADD PRIMARY KEY (`PaletteID`), ADD KEY `fk_bestand_lager` (`LagerID`), ADD KEY `ProduktID` (`ProduktID`);

--
-- Indexes for table `produkte`
--
ALTER TABLE `produkte`
 ADD PRIMARY KEY (`ProduktID`), ADD UNIQUE KEY `Bezeichnung` (`Bezeichnung`), ADD KEY `ProduktID` (`ProduktID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `lager`
--
ALTER TABLE `lager`
MODIFY `LagerID` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `produkte`
--
ALTER TABLE `produkte`
MODIFY `ProduktID` int(11) NOT NULL AUTO_INCREMENT;
--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `paletten`
--
ALTER TABLE `paletten`
ADD CONSTRAINT `fk_paletten_lager` FOREIGN KEY (`LagerID`) REFERENCES `lager` (`LagerID`),
ADD CONSTRAINT `fk_produkte_paletten` FOREIGN KEY (`ProduktID`) REFERENCES `produkte` (`ProduktID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
