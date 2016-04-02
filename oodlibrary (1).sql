-- phpMyAdmin SQL Dump
-- version 4.2.7.1
-- http://www.phpmyadmin.net
--
-- Machine: 127.0.0.1
-- Gegenereerd op: 02 apr 2016 om 13:17
-- Serverversie: 5.6.20
-- PHP-versie: 5.5.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Databank: `oodlibrary`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `books`
--

CREATE TABLE IF NOT EXISTS `books` (
  `IDBook` int(11) NOT NULL,
  `BookName` varchar(255) NOT NULL,
  `ISBN` varchar(20) NOT NULL,
  `Type` enum('Novel','Study Book') NOT NULL,
  `Availability` enum('Yes','No') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `books`
--

INSERT INTO `books` (`IDBook`, `BookName`, `ISBN`, `Type`, `Availability`) VALUES
(0, 'The Jungle Book', 'CHD9283474', 'Novel', 'Yes'),
(1, 'The Jungle Book', 'CHD9283474', 'Novel', 'Yes'),
(2, 'OOD', 'VN2928373', 'Study Book', 'No'),
(3, 'Cinderella', 'CB283284y23', 'Novel', 'No'),
(4, 'English', 'FHF2838373', 'Study Book', 'Yes');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `borrow`
--

CREATE TABLE IF NOT EXISTS `borrow` (
  `BorrowID` int(11) NOT NULL,
  `IDMember` int(11) NOT NULL,
  `IDBook` int(11) DEFAULT NULL,
  `IDCD` int(11) DEFAULT NULL,
  `IDTape` int(11) DEFAULT NULL,
  `StartDate` date NOT NULL,
  `EndDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `borrow`
--

INSERT INTO `borrow` (`BorrowID`, `IDMember`, `IDBook`, `IDCD`, `IDTape`, `StartDate`, `EndDate`) VALUES
(1, 2, NULL, 2, NULL, '2016-03-11', '2016-03-21');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `cd`
--

CREATE TABLE IF NOT EXISTS `cd` (
  `IDCD` int(11) NOT NULL,
  `CDName` varchar(255) NOT NULL,
  `Type` enum('Popular','Classical') NOT NULL,
  `ISBN` varchar(30) NOT NULL,
  `ReleaseDate` date NOT NULL,
  `Availability` enum('Yes','No') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `cd`
--

INSERT INTO `cd` (`IDCD`, `CDName`, `Type`, `ISBN`, `ReleaseDate`, `Availability`) VALUES
(1, 'Magical Music', 'Popular', 'FHF23938383', '2015-03-09', 'Yes'),
(2, 'Opera', 'Classical', 'FHFh383838383', '2016-03-16', 'No'),
(3, 'Best of..', 'Popular', 'FJF38383838', '2010-03-29', 'Yes'),
(4, 'Piano Music', 'Classical', 'fhf373824', '2015-03-09', 'Yes');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `costs`
--

CREATE TABLE IF NOT EXISTS `costs` (
  `Type` varchar(255) NOT NULL,
  `DefaultDays` int(11) NOT NULL,
  `PriceOfDefaultDay` double NOT NULL,
  `PriceOfExtraDays` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `costs`
--

INSERT INTO `costs` (`Type`, `DefaultDays`, `PriceOfDefaultDay`, `PriceOfExtraDays`) VALUES
('A', 0, 2, 0),
('B', 3, 2, 1),
('Classical', 10, 2, 0.21),
('Popular', 10, 1, 0.29),
('Novel', 21, 0, 0.25),
('Study Book', 30, 0, 0.14);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `userdata`
--

CREATE TABLE IF NOT EXISTS `userdata` (
`IDMember` int(11) NOT NULL,
  `MemberName` varchar(255) NOT NULL,
  `Age` int(11) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=53 ;

--
-- Gegevens worden geëxporteerd voor tabel `userdata`
--

INSERT INTO `userdata` (`IDMember`, `MemberName`, `Age`) VALUES
(2, 'Benjamin', 13),
(16, 'steve', 18),
(37, 'emily', 20),
(38, 'emily', 20),
(41, 'emily', 20),
(42, 'emily', 20),
(43, 'emily', 20),
(44, 'emily', 20),
(45, 'emily', 20),
(46, 'emily', 20),
(47, 'emily', 20),
(48, 'emily', 20),
(49, 'emily', 20),
(50, 'emily', 20),
(51, 'emily', 20);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `videotape`
--

CREATE TABLE IF NOT EXISTS `videotape` (
  `IDTape` int(11) NOT NULL,
  `TapeName` varchar(255) NOT NULL,
  `Type` enum('A','B') NOT NULL,
  `ISBN` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `videotape`
--

INSERT INTO `videotape` (`IDTape`, `TapeName`, `Type`, `ISBN`) VALUES
(1, 'Madonna', 'A', 'dhd3838383'),
(2, 'Big Hero 6', 'B', 'DHF278282'),
(3, 'Tarzan', 'B', 'FHF393939'),
(4, 'Bridget Jones Baby', 'A', 'DHD2939393');

--
-- Indexen voor geëxporteerde tabellen
--

--
-- Indexen voor tabel `books`
--
ALTER TABLE `books`
 ADD UNIQUE KEY `IDBook` (`IDBook`);

--
-- Indexen voor tabel `borrow`
--
ALTER TABLE `borrow`
 ADD UNIQUE KEY `IDMember` (`IDMember`), ADD UNIQUE KEY `IDTape` (`IDTape`), ADD UNIQUE KEY `IDBook` (`IDBook`), ADD UNIQUE KEY `IDCD` (`IDCD`);

--
-- Indexen voor tabel `cd`
--
ALTER TABLE `cd`
 ADD UNIQUE KEY `IDCD` (`IDCD`);

--
-- Indexen voor tabel `userdata`
--
ALTER TABLE `userdata`
 ADD PRIMARY KEY (`IDMember`);

--
-- Indexen voor tabel `videotape`
--
ALTER TABLE `videotape`
 ADD UNIQUE KEY `IDTape` (`IDTape`);

--
-- AUTO_INCREMENT voor geëxporteerde tabellen
--

--
-- AUTO_INCREMENT voor een tabel `userdata`
--
ALTER TABLE `userdata`
MODIFY `IDMember` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=53;
--
-- Beperkingen voor geëxporteerde tabellen
--

--
-- Beperkingen voor tabel `borrow`
--
ALTER TABLE `borrow`
ADD CONSTRAINT `borrow_ibfk_1` FOREIGN KEY (`IDTape`) REFERENCES `videotape` (`IDTape`),
ADD CONSTRAINT `borrow_ibfk_2` FOREIGN KEY (`IDBook`) REFERENCES `books` (`IDBook`),
ADD CONSTRAINT `borrow_ibfk_3` FOREIGN KEY (`IDMember`) REFERENCES `userdata` (`IDMember`),
ADD CONSTRAINT `borrow_ibfk_4` FOREIGN KEY (`IDCD`) REFERENCES `cd` (`IDCD`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
