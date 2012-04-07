-- phpMyAdmin SQL Dump
-- version 3.3.10.2
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Apr 06, 2012 at 07:05 PM
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
CREATE DATABASE `teamchro_LATSQL` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `teamchro_LATSQL`;

-- --------------------------------------------------------

--
-- Table structure for table `Admin`
--

DROP TABLE IF EXISTS `Admin`;
CREATE TABLE IF NOT EXISTS `Admin` (
  `ID` int(11) NOT NULL,
  PRIMARY KEY  (`ID`),
  KEY `AID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Admin`
--

INSERT INTO `Admin` (`ID`) VALUES
(1);

-- --------------------------------------------------------

--
-- Table structure for table `Employee Jobs`
--

DROP TABLE IF EXISTS `Employee Jobs`;
CREATE TABLE IF NOT EXISTS `Employee Jobs` (
  `ID` int(11) NOT NULL,
  `JID` varchar(50) NOT NULL,
  `JPay` decimal(10,2) NOT NULL,
  KEY `EJID` (`ID`),
  KEY `EJJID` (`JID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Employee Jobs`
--

INSERT INTO `Employee Jobs` (`ID`, `JID`, `JPay`) VALUES
(1, 'Manager', '11.00'),
(5, 'Dishwasher', '7.40'),
(2, 'Server', '3.75'),
(10, 'Server', '3.75'),
(10, 'Cook', '8.10'),
(11, 'Bartender', '8.00');

-- --------------------------------------------------------

--
-- Table structure for table `Employee`
--

DROP TABLE IF EXISTS `Employee`;
CREATE TABLE IF NOT EXISTS `Employee` (
  `ID` int(11) NOT NULL auto_increment,
  `LName` text NOT NULL,
  `MName` varchar(20) NOT NULL,
  `FName` text NOT NULL,
  `SSN` int(9) NOT NULL,
  `Phone` int(10) NOT NULL,
  `Email` text NOT NULL,
  `Address1` text,
  `Address2` text,
  `City` text NOT NULL,
  `State` text,
  `Zip` int(11) default NULL,
  `SDate` date NOT NULL,
  `EDate` date default NULL,
  `EReason` text,
  PRIMARY KEY  (`ID`),
  UNIQUE KEY `ID_UNIQUE` (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=16 ;

--
-- Dumping data for table `Employee`
--

INSERT INTO `Employee` (`ID`, `LName`, `MName`, `FName`, `SSN`, `Phone`, `Email`, `Address1`, `Address2`, `City`, `State`, `Zip`, `SDate`, `EDate`, `EReason`) VALUES
(1, 'Chavez', 'L', 'Jennifer', 123845421, 2147483647, 'test@aol.com', 'address1', 'te''s\\', 'Muncie', 'Indiana', 47304, '2012-03-01', NULL, ''),
(2, 'Chavez', 'D', 'Mando', 214748364, 2147483647, '', '', '', '', 'Nebraska', 0, '2012-03-03', NULL, ''),
(4, 'Hansen', 'H', 'Chris', 123456789, 1234567890, '', '', '', '', '', 0, '2012-03-03', NULL, ''),
(5, 'Warrior', 'A', 'The', 123456789, 1234567890, '', NULL, NULL, '', NULL, NULL, '2012-03-03', NULL, ''),
(10, 'Chappel', 'Earl', 'Dave', 123456792, 2132159499, '', '', '', '', 'Nebraska', 48457, '2012-03-03', NULL, ''),
(11, 'Dole', 'Joseph', 'Bob', 334434575, 2147483647, 'bob.dole@compuserve.com', '1400 W, Jackson St', 'apartment 24', 'Funkytown', 'Indiana', 47306, '2012-03-03', NULL, ''),
(12, 'daf', 'dfa', 'dsaf', 651632132, 2147483647, 'test@yahoo.com', 'asfkaj', 'dsf', 'dalskfja', 'Idaho', 52154, '2012-03-21', NULL, ''),
(13, 'lkjlk', 'lkj', 'privtest', 546542162, 1854162165, 'a@msn.com', '6516251 sadfa', '', 'sdfa', 'Alabama', 51854, '2012-03-21', NULL, ''),
(14, 'te''s\\', 'te''s\\', 'te''s\\', 394230938, 2147483647, 'te''s\\', 'te''s\\', 'te''s\\', 'te''s\\', 'Delaware', 12345, '2012-04-05', NULL, ''),
(15, 'Me', 'M', 'Fire', 421845216, 2147483647, '65154', '51651', '551651', '216551', 'Delaware', 51621, '2012-04-01', '2012-04-07', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `EmployeeNotes`
--

DROP TABLE IF EXISTS `EmployeeNotes`;
CREATE TABLE IF NOT EXISTS `EmployeeNotes` (
  `ID` int(11) NOT NULL,
  `Manager` varchar(50) NOT NULL,
  `Date` date NOT NULL,
  `Note` text NOT NULL,
  KEY `NoteEID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `EmployeeNotes`
--

INSERT INTO `EmployeeNotes` (`ID`, `Manager`, `Date`, `Note`) VALUES
(4, 'Jennifer Chavez', '2012-03-21', 'Employee Constantly asking me to "Take a Seat"'),
(10, 'Jennifer Chavez', '2012-03-14', 'Keeps telling me he''s rich'),
(10, 'Jennifer Chavez', '2012-03-22', 'Smoking Crack in the Freezer'),
(11, 'Jennifer Chavez', '2012-03-22', 'All he says is Bob Dole'),
(11, 'Jennifer Chavez', '2012-03-22', 'Bob Dole\nBob Dole\nBob Dole'),
(12, 'Bob Dole', '2012-03-23', 'Has a dumb name'),
(2, 'Jennifer Chavez', '2012-04-01', 'Mando, Man do'),
(10, 'Jennifer Chavez', '2012-04-05', '''stringttest'),
(10, 'Jennifer Chavez', '2012-04-05', 'stringttest2'),
(10, 'Jennifer Chavez', '2012-04-05', 'note''s test\\ 2'),
(10, 'Jennifer Chavez', '2012-04-05', 'te''s\\');

-- --------------------------------------------------------

--
-- Table structure for table `Hours Worked`
--

DROP TABLE IF EXISTS `Hours Worked`;
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

--
-- Dumping data for table `Hours Worked`
--

INSERT INTO `Hours Worked` (`ID`, `Date`, `Start`, `End`, `Tips`, `JID`, `B1out`, `B1in`, `B2out`, `B2in`, `Lout`, `Lin`, `Status`) VALUES
(1, '2012-02-18', '21:15:00', '21:19:41', NULL, 'Manager', '21:19:21', '21:19:23', '21:19:26', '21:19:27', '21:19:37', '21:19:37', 'OUT'),
(1, '2012-02-19', '13:00:00', '13:30:15', NULL, 'Server', '13:19:04', '13:19:05', '13:19:06', '13:19:06', '13:19:07', '13:19:08', 'OUT'),
(2, '2012-02-21', '13:00:00', '13:30:15', NULL, 'Server', '13:19:04', '13:19:05', '13:19:06', '13:19:06', '13:19:07', '13:19:08', 'OUT'),
(4, '2012-02-21', '13:00:00', '14:47:15', NULL, 'Cook', '13:19:04', '13:19:05', '13:19:06', '13:19:06', '13:19:07', '13:19:08', 'OUT'),
(5, '2012-02-21', '13:15:00', '13:30:15', NULL, 'Dishwasher', '13:19:04', '13:19:05', '13:19:06', '13:19:06', '13:19:07', '13:19:08', 'OUT'),
(1, '2012-03-04', '21:55:00', '22:38:00', NULL, 'Bartender', NULL, NULL, NULL, NULL, NULL, NULL, 'OUT'),
(11, '2012-03-04', '22:01:29', '03:03:09', NULL, 'Bartender', NULL, NULL, NULL, NULL, '23:45:00', '00:15:00', 'OUT'),
(1, '2012-03-05', '03:02:06', '17:36:44', NULL, 'Bartender', NULL, NULL, NULL, NULL, NULL, NULL, 'OUT'),
(1, '2012-03-10', '22:02:17', '22:03:13', NULL, 'Bartender', '22:02:31', '22:02:47', '22:03:07', '22:03:08', '22:02:53', '22:02:55', 'OUT'),
(10, '2012-03-11', '23:00:00', '04:00:00', NULL, 'Bartender', '23:07:00', '23:24:00', NULL, NULL, NULL, NULL, 'OUT'),
(10, '2012-03-12', '01:20:00', '02:34:00', NULL, 'Bartender', NULL, NULL, NULL, NULL, NULL, NULL, 'OUT'),
(1, '2012-03-12', '03:32:00', '04:32:00', NULL, 'Bartender', NULL, NULL, NULL, NULL, NULL, NULL, 'OUT'),
(11, '2012-03-12', '00:30:00', '02:00:00', NULL, 'Security', NULL, NULL, NULL, NULL, NULL, NULL, 'OUT'),
(5, '2012-03-12', '11:20:00', '12:50:00', NULL, 'Cook', NULL, NULL, NULL, NULL, NULL, NULL, 'OUT'),
(11, '2012-03-13', '10:44:30', '10:19:44', NULL, 'Dishwasher', NULL, NULL, NULL, NULL, NULL, NULL, 'OUT'),
(1, '2012-03-23', '08:45:00', '09:08:31', NULL, 'Bartender', NULL, NULL, NULL, NULL, NULL, NULL, 'OUT'),
(1, '2012-03-23', '09:00:00', '09:08:31', NULL, 'Bartender', NULL, NULL, NULL, NULL, NULL, NULL, 'OUT'),
(1, '2012-03-23', '09:15:00', '09:08:31', NULL, 'Manager', NULL, NULL, NULL, NULL, NULL, NULL, 'OUT'),
(11, '2012-03-26', '19:00:00', '19:06:06', '69.00', 'Bartender', NULL, NULL, NULL, NULL, NULL, NULL, 'OUT'),
(11, '2012-03-26', '19:00:00', '19:06:06', NULL, 'Security', NULL, NULL, NULL, NULL, NULL, NULL, 'OUT'),
(1, '2012-03-26', '19:15:00', '19:34:22', '9001.00', 'Bartender', '19:13:57', '19:13:58', '19:13:58', '19:13:59', '19:13:55', '19:13:56', 'OUT'),
(1, '2012-04-01', '17:15:00', '17:47:10', '0.00', 'Server', NULL, NULL, NULL, NULL, NULL, NULL, 'OUT'),
(1, '2012-04-01', '17:45:00', '17:47:10', '0.00', 'Bartender', NULL, NULL, NULL, NULL, NULL, NULL, 'OUT');

-- --------------------------------------------------------

--
-- Table structure for table `Jobs`
--

DROP TABLE IF EXISTS `Jobs`;
CREATE TABLE IF NOT EXISTS `Jobs` (
  `JID` varchar(50) NOT NULL,
  `JSPay` decimal(10,2) NOT NULL,
  `TippedJob` varchar(5) character set latin1 collate latin1_bin default 'FALSE',
  PRIMARY KEY  (`JID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Jobs`
--

INSERT INTO `Jobs` (`JID`, `JSPay`, `TippedJob`) VALUES
('Bartender', '5.00', 'True'),
('Cook', '8.00', 'False'),
('Dishwasher', '7.00', 'False'),
('Manager', '10.00', 'False'),
('Security', '8.00', 'False'),
('Server', '3.50', 'True');

-- --------------------------------------------------------

--
-- Table structure for table `Late`
--

DROP TABLE IF EXISTS `Late`;
CREATE TABLE IF NOT EXISTS `Late` (
  `ID` int(11) NOT NULL,
  `Date` date NOT NULL,
  `Stime` time NOT NULL,
  `Atime` time NOT NULL,
  KEY `LID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Late`
--


-- --------------------------------------------------------

--
-- Table structure for table `Manager`
--

DROP TABLE IF EXISTS `Manager`;
CREATE TABLE IF NOT EXISTS `Manager` (
  `ID` int(11) NOT NULL,
  PRIMARY KEY  (`ID`),
  KEY `MID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Manager`
--

INSERT INTO `Manager` (`ID`) VALUES
(10),
(11);

-- --------------------------------------------------------

--
-- Table structure for table `Payrole YTD`
--

DROP TABLE IF EXISTS `Payrole YTD`;
CREATE TABLE IF NOT EXISTS `Payrole YTD` (
  `ID` int(11) NOT NULL,
  `Total Hours` decimal(10,0) NOT NULL,
  `Total Income` decimal(10,2) NOT NULL,
  `Total Taxes` decimal(10,2) NOT NULL,
  `Total Tips` decimal(10,2) default NULL,
  PRIMARY KEY  (`ID`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Payrole YTD`
--


-- --------------------------------------------------------

--
-- Table structure for table `Schedule`
--

DROP TABLE IF EXISTS `Schedule`;
CREATE TABLE IF NOT EXISTS `Schedule` (
  `ID` int(11) NOT NULL,
  `Date` date NOT NULL,
  `Start` time NOT NULL,
  `End` time NOT NULL,
  `JID` varchar(50) NOT NULL,
  KEY `SID` (`ID`),
  KEY `SJID` (`JID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Schedule`
--

INSERT INTO `Schedule` (`ID`, `Date`, `Start`, `End`, `JID`) VALUES
(1, '2012-02-16', '22:30:00', '05:00:00', 'Manager'),
(1, '2012-02-29', '02:00:00', '06:00:00', 'Cook'),
(10, '0000-00-00', '02:30:00', '22:15:00', 'Cook'),
(10, '2012-02-25', '01:30:00', '23:30:00', 'Dishwasher'),
(4, '2012-02-25', '21:15:00', '20:30:00', 'Dishwasher'),
(10, '2012-02-27', '13:00:00', '23:00:00', 'Manager'),
(1, '2012-02-26', '05:30:00', '05:30:00', 'Cook'),
(11, '2012-03-04', '10:00:00', '14:30:00', 'Security'),
(1, '2012-03-04', '06:15:00', '10:30:00', 'Manager'),
(1, '2012-03-05', '03:15:00', '08:15:00', 'Bartender'),
(10, '2012-03-04', '11:15:00', '12:30:00', 'Security'),
(1, '2012-03-10', '22:00:00', '05:30:00', 'Bartender'),
(10, '2012-03-11', '04:15:00', '10:30:00', 'Bartender'),
(11, '2012-03-13', '10:45:00', '11:00:00', 'Dishwasher'),
(11, '2012-03-30', '10:00:00', '18:00:00', 'Security');

-- --------------------------------------------------------

--
-- Table structure for table `Users`
--

DROP TABLE IF EXISTS `Users`;
CREATE TABLE IF NOT EXISTS `Users` (
  `ID` int(11) NOT NULL,
  `User` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  PRIMARY KEY  (`ID`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Users`
--

INSERT INTO `Users` (`ID`, `User`, `Password`) VALUES
(1, 'test', '378b243e220ca493'),
(2, 'user', '29bad1457ee5e49e'),
(4, 'chris', '1d4189ef56e6d972'),
(5, 'the', '6cef464025796393'),
(10, 'dave', '60671c896665c3fa'),
(11, 'Bobdole', '2485317568797984'),
(12, 'datetest', '60671c896665c3fa'),
(13, 'privtest', '60671c896665c3fa'),
(14, 'te''s\\', '70bda4a51e33b157'),
(15, 'fireme', '6e69ec467e82e965');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `Admin`
--
ALTER TABLE `Admin`
  ADD CONSTRAINT `AID` FOREIGN KEY (`ID`) REFERENCES `Employee` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `Employee Jobs`
--
ALTER TABLE `Employee Jobs`
  ADD CONSTRAINT `EJID` FOREIGN KEY (`ID`) REFERENCES `Employee` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `EJJID` FOREIGN KEY (`JID`) REFERENCES `Jobs` (`JID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `EmployeeNotes`
--
ALTER TABLE `EmployeeNotes`
  ADD CONSTRAINT `ENID` FOREIGN KEY (`ID`) REFERENCES `Employee` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `Hours Worked`
--
ALTER TABLE `Hours Worked`
  ADD CONSTRAINT `HWID` FOREIGN KEY (`ID`) REFERENCES `Employee` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `HWJID` FOREIGN KEY (`JID`) REFERENCES `Jobs` (`JID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `Late`
--
ALTER TABLE `Late`
  ADD CONSTRAINT `LID` FOREIGN KEY (`ID`) REFERENCES `Employee` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `Manager`
--
ALTER TABLE `Manager`
  ADD CONSTRAINT `MID` FOREIGN KEY (`ID`) REFERENCES `Employee` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `Payrole YTD`
--
ALTER TABLE `Payrole YTD`
  ADD CONSTRAINT `YTDID` FOREIGN KEY (`ID`) REFERENCES `Employee` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `Schedule`
--
ALTER TABLE `Schedule`
  ADD CONSTRAINT `SID` FOREIGN KEY (`ID`) REFERENCES `Employee` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `SJID` FOREIGN KEY (`JID`) REFERENCES `Jobs` (`JID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `Users`
--
ALTER TABLE `Users`
  ADD CONSTRAINT `ID` FOREIGN KEY (`ID`) REFERENCES `Employee` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;
