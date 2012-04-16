-- phpMyAdmin SQL Dump
-- version 3.3.10.2
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Apr 16, 2012 at 10:48 AM
-- Server version: 5.0.91
-- PHP Version: 5.2.6

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `teamchro_LATSQL`
--

-- --------------------------------------------------------

--
-- Table structure for table `Admin`
--

CREATE TABLE IF NOT EXISTS `Admin` (
  `ID` int(11) NOT NULL,
  PRIMARY KEY  (`ID`),
  KEY `AID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `Employee`
--

CREATE TABLE IF NOT EXISTS `Employee` (
  `ID` int(11) NOT NULL auto_increment,
  `LName` text NOT NULL,
  `MName` varchar(20) NOT NULL,
  `FName` text NOT NULL,
  `SSN` text NOT NULL,
  `Phone` int(10) NOT NULL,
  `Email` text NOT NULL,
  `Address1` text,
  `Address2` text,
  `City` text NOT NULL,
  `State` text,
  `Zip` int(11) default NULL,
  `SDate` date NOT NULL,
  `EDate` date default NULL,
  `EReason` varchar(10) default NULL,
  PRIMARY KEY  (`ID`),
  UNIQUE KEY `ID_UNIQUE` (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=18 ;

-- --------------------------------------------------------

--
-- Table structure for table `Employee Jobs`
--

CREATE TABLE IF NOT EXISTS `Employee Jobs` (
  `ID` int(11) NOT NULL,
  `JID` varchar(50) NOT NULL,
  `JPay` decimal(3,2) NOT NULL,
  KEY `EJID` (`ID`),
  KEY `EJJID` (`JID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `EmployeeNotes`
--

CREATE TABLE IF NOT EXISTS `EmployeeNotes` (
  `ID` int(11) NOT NULL,
  `Manager` varchar(50) NOT NULL,
  `Date` datetime NOT NULL,
  `Note` text NOT NULL,
  KEY `NoteEID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `Hours Worked`
--

CREATE TABLE IF NOT EXISTS `Hours Worked` (
  `ID` int(11) NOT NULL,
  `Date` date NOT NULL,
  `Start` time default NULL,
  `End` time default NULL,
  `Tips` decimal(10,2) default NULL,
  `JID` varchar(50) NOT NULL,
  `B1out` time default NULL,
  `B1in` time default NULL,
  `B2out` time default NULL,
  `B2in` time default NULL,
  `Lout` time default NULL,
  `Lin` time default NULL,
  `Status` varchar(20) default NULL,
  KEY `HWID` (`ID`),
  KEY `HWJID` (`JID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `Jobs`
--

CREATE TABLE IF NOT EXISTS `Jobs` (
  `JID` varchar(50) NOT NULL,
  `JSPay` decimal(10,2) NOT NULL,
  `TippedJob` varchar(5) character set latin1 collate latin1_bin default 'FALSE',
  `Filename` text,
  PRIMARY KEY  (`JID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `Manager`
--

CREATE TABLE IF NOT EXISTS `Manager` (
  `ID` int(11) NOT NULL,
  PRIMARY KEY  (`ID`),
  KEY `MID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `Requests`
--

CREATE TABLE IF NOT EXISTS `Requests` (
  `ID` int(11) NOT NULL,
  `SDate` date NOT NULL,
  `EDate` date NOT NULL,
  `Submitted Date` date default NULL,
  `Reason` text,
  KEY `RID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `Schedule`
--

CREATE TABLE IF NOT EXISTS `Schedule` (
  `ID` int(11) NOT NULL,
  `Date` date NOT NULL,
  `Start` time NOT NULL,
  `End` time NOT NULL,
  `JID` varchar(50) NOT NULL,
  KEY `SID` (`ID`),
  KEY `SJID` (`JID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `Users`
--

CREATE TABLE IF NOT EXISTS `Users` (
  `ID` int(11) NOT NULL,
  `User` varchar(45) NOT NULL,
  `Password` varchar(84) NOT NULL,
  PRIMARY KEY  (`ID`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `Admin`
--
ALTER TABLE `Admin`
  ADD CONSTRAINT `AID` FOREIGN KEY (`ID`) REFERENCES `Employee` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `Employee Jobs`
--
ALTER TABLE `Employee Jobs`
  ADD CONSTRAINT `EJJID` FOREIGN KEY (`JID`) REFERENCES `Jobs` (`JID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `EJID` FOREIGN KEY (`ID`) REFERENCES `Employee` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `EmployeeNotes`
--
ALTER TABLE `EmployeeNotes`
  ADD CONSTRAINT `ENID` FOREIGN KEY (`ID`) REFERENCES `Employee` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `Hours Worked`
--
ALTER TABLE `Hours Worked`
  ADD CONSTRAINT `HWJID` FOREIGN KEY (`JID`) REFERENCES `Jobs` (`JID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `HWID` FOREIGN KEY (`ID`) REFERENCES `Employee` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `Manager`
--
ALTER TABLE `Manager`
  ADD CONSTRAINT `MID` FOREIGN KEY (`ID`) REFERENCES `Employee` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `Requests`
--
ALTER TABLE `Requests`
  ADD CONSTRAINT `Rid` FOREIGN KEY (`ID`) REFERENCES `Employee` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `Schedule`
--
ALTER TABLE `Schedule`
  ADD CONSTRAINT `SJID` FOREIGN KEY (`JID`) REFERENCES `Jobs` (`JID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `SID` FOREIGN KEY (`ID`) REFERENCES `Employee` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `Users`
--
ALTER TABLE `Users`
  ADD CONSTRAINT `ID` FOREIGN KEY (`ID`) REFERENCES `Employee` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;
