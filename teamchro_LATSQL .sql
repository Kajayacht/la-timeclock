SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL';

CREATE SCHEMA IF NOT EXISTS `teamchro_LATSQL` DEFAULT CHARACTER SET latin1 ;
USE `teamchro_LATSQL` ;

-- -----------------------------------------------------
-- Table `teamchro_LATSQL`.`Employee`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `teamchro_LATSQL`.`Employee` (
  `ID` INT NOT NULL AUTO_INCREMENT ,
  `Priv` VARCHAR(45) NOT NULL ,
  `LName` TEXT NOT NULL ,
  `FName` TEXT NOT NULL ,
  `SSN` INT(9) NOT NULL ,
  `Phone` INT(10) NOT NULL ,
  `Address1` TEXT NULL DEFAULT NULL ,
  `Address2` TEXT NULL ,
  `State` TEXT NULL ,
  `Email` TEXT NULL DEFAULT NULL ,
  `Zip` INT NULL ,
  PRIMARY KEY (`ID`) ,
  UNIQUE INDEX `ID_UNIQUE` (`ID` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `teamchro_LATSQL`.`Jobs`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `teamchro_LATSQL`.`Jobs` (
  `JID` VARCHAR(50) NOT NULL ,
  `JSPay` DECIMAL(10,2) NOT NULL ,
  `Img` TEXT NULL DEFAULT NULL ,
  PRIMARY KEY (`JID`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `teamchro_LATSQL`.`Payrole YTD`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `teamchro_LATSQL`.`Payrole YTD` (
  `ID` INT NOT NULL ,
  `Total Hours` DECIMAL NOT NULL ,
  `Total Income` DECIMAL(10,2) NOT NULL ,
  `Total Taxes` DECIMAL(10,2) NOT NULL ,
  PRIMARY KEY (`ID`) ,
  INDEX `ID` (`ID` ASC) ,
  CONSTRAINT `YTDID`
    FOREIGN KEY (`ID` )
    REFERENCES `teamchro_LATSQL`.`Employee` (`ID` )
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `teamchro_LATSQL`.`Employee Jobs`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `teamchro_LATSQL`.`Employee Jobs` (
  `ID` INT NOT NULL ,
  `JID` VARCHAR(50) NOT NULL ,
  `JPay` DECIMAL NOT NULL ,
  INDEX `EJID` (`ID` ASC) ,
  INDEX `EJJID` (`JID` ASC) ,
  CONSTRAINT `EJID`
    FOREIGN KEY (`ID` )
    REFERENCES `teamchro_LATSQL`.`Employee` (`ID` )
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `EJJID`
    FOREIGN KEY (`JID` )
    REFERENCES `teamchro_LATSQL`.`Jobs` (`JID` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `teamchro_LATSQL`.`Late`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `teamchro_LATSQL`.`Late` (
  `ID` INT NOT NULL ,
  `Date` DATE NOT NULL ,
  `Stime` TIME NOT NULL ,
  `Atime` TIME NOT NULL ,
  INDEX `LID` (`ID` ASC) ,
  CONSTRAINT `LID`
    FOREIGN KEY (`ID` )
    REFERENCES `teamchro_LATSQL`.`Employee` (`ID` )
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `teamchro_LATSQL`.`Users`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `teamchro_LATSQL`.`Users` (
  `ID` INT NOT NULL ,
  `User` VARCHAR(45) NOT NULL ,
  `Password` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`ID`) ,
  INDEX `ID` (`ID` ASC) ,
  CONSTRAINT `ID`
    FOREIGN KEY (`ID` )
    REFERENCES `teamchro_LATSQL`.`Employee` (`ID` )
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `teamchro_LATSQL`.`Schedule`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `teamchro_LATSQL`.`Schedule` (
  `ID` INT NOT NULL ,
  `Date` DATE NOT NULL ,
  `Start` TIME NOT NULL ,
  `End` TIME NOT NULL ,
  `JID` VARCHAR(50) NOT NULL ,
  INDEX `SID` (`ID` ASC) ,
  INDEX `SJID` (`JID` ASC) ,
  CONSTRAINT `SID`
    FOREIGN KEY (`ID` )
    REFERENCES `teamchro_LATSQL`.`Employee` (`ID` )
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `SJID`
    FOREIGN KEY (`JID` )
    REFERENCES `teamchro_LATSQL`.`Jobs` (`JID` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `teamchro_LATSQL`.`Hours Worked`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `teamchro_LATSQL`.`Hours Worked` (
  `ID` INT NOT NULL ,
  `Date` DATE NOT NULL ,
  `Start` TIME NULL ,
  `End` TIME NULL ,
  `JID` VARCHAR(50) NOT NULL ,
  `B1out` TIME NULL ,
  `B1in` TIME NULL ,
  `B2out` TIME NULL ,
  `B2in` TIME NULL ,
  `Lout` TIME NULL ,
  `Lin` TIME NULL ,
  INDEX `HWID` (`ID` ASC) ,
  INDEX `HWJID` (`JID` ASC) ,
  CONSTRAINT `HWID`
    FOREIGN KEY (`ID` )
    REFERENCES `teamchro_LATSQL`.`Employee` (`ID` )
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `HWJID`
    FOREIGN KEY (`JID` )
    REFERENCES `teamchro_LATSQL`.`Jobs` (`JID` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;



SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- Data for table `teamchro_LATSQL`.`Employee`
-- -----------------------------------------------------
SET AUTOCOMMIT=0;
USE `teamchro_LATSQL`;
INSERT INTO `teamchro_LATSQL`.`Employee` (`ID`, `Priv`, `LName`, `FName`, `SSN`, `Phone`, `Address1`, `Address2`, `State`, `Email`, `Zip`) VALUES ('1', 'Admin', 'Chavez', 'Jenn', '123456789', '0123456789', NULL, NULL, NULL, NULL, NULL);

COMMIT;

-- -----------------------------------------------------
-- Data for table `teamchro_LATSQL`.`Jobs`
-- -----------------------------------------------------
SET AUTOCOMMIT=0;
USE `teamchro_LATSQL`;
INSERT INTO `teamchro_LATSQL`.`Jobs` (`JID`, `JSPay`, `Img`) VALUES ('Manager', '10.00', NULL);
INSERT INTO `teamchro_LATSQL`.`Jobs` (`JID`, `JSPay`, `Img`) VALUES ('Cook', '8.00', NULL);
INSERT INTO `teamchro_LATSQL`.`Jobs` (`JID`, `JSPay`, `Img`) VALUES ('Server', '3.50', NULL);
INSERT INTO `teamchro_LATSQL`.`Jobs` (`JID`, `JSPay`, `Img`) VALUES ('Bartender', '5.00', NULL);
INSERT INTO `teamchro_LATSQL`.`Jobs` (`JID`, `JSPay`, `Img`) VALUES ('Dishwasher', '7.00', NULL);
INSERT INTO `teamchro_LATSQL`.`Jobs` (`JID`, `JSPay`, `Img`) VALUES ('Security', '8.00', NULL);

COMMIT;

-- -----------------------------------------------------
-- Data for table `teamchro_LATSQL`.`Users`
-- -----------------------------------------------------
SET AUTOCOMMIT=0;
USE `teamchro_LATSQL`;
INSERT INTO `teamchro_LATSQL`.`Users` (`ID`, `User`, `Password`) VALUES ('1', 'test', 'test');

COMMIT;

-- -----------------------------------------------------
-- Data for table `teamchro_LATSQL`.`Schedule`
-- -----------------------------------------------------
SET AUTOCOMMIT=0;
USE `teamchro_LATSQL`;
INSERT INTO `teamchro_LATSQL`.`Schedule` (`ID`, `Date`, `Start`, `End`, `JID`) VALUES ('1', '2/13/2012', '3:00', '4:00', 'Manager');

COMMIT;
