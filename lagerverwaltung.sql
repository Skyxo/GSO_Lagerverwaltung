-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 07. Jun 2017 um 19:54
-- Server-Version: 10.1.21-MariaDB
-- PHP-Version: 7.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `lagerverwaltung`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `bestand`
--

CREATE TABLE `bestand` (
  `PaletteID` int(11) NOT NULL,
  `LagerID` int(11) NOT NULL,
  `Bezeichnung` varchar(255) NOT NULL,
  `Einheiten` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `bestand`
--

INSERT INTO `bestand` (`PaletteID`, `LagerID`, `Bezeichnung`, `Einheiten`) VALUES
(0, 1, 'Gaffel Kölsch', 24);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `lager`
--

CREATE TABLE `lager` (
  `LagerID` int(11) NOT NULL,
  `Standort` varchar(255) NOT NULL,
  `Kapazitaet` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `lager`
--

INSERT INTO `lager` (`LagerID`, `Standort`, `Kapazitaet`) VALUES
(1, 'Köln', 20000),
(2, 'Bonn', 10000),
(3, 'Leverkusen', 15000);

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `bestand`
--
ALTER TABLE `bestand`
  ADD PRIMARY KEY (`PaletteID`),
  ADD KEY `fk_bestand_lager` (`LagerID`);

--
-- Indizes für die Tabelle `lager`
--
ALTER TABLE `lager`
  ADD PRIMARY KEY (`LagerID`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `lager`
--
ALTER TABLE `lager`
  MODIFY `LagerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `bestand`
--
ALTER TABLE `bestand`
  ADD CONSTRAINT `fk_bestand_lager` FOREIGN KEY (`LagerID`) REFERENCES `lager` (`LagerID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
