SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL';

CREATE SCHEMA IF NOT EXISTS `teamchro_LATSQL` DEFAULT CHARACTER SET latin1 ;
USE `teamchro_LATSQL` ;

-- -----------------------------------------------------
-- Table `teamchro_LATSQL`.`Employee`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `teamchro_LATSQL`.`Employee` (
  `ID` INT NOT NULL ,
  `LName` VARCHAR(45) NOT NULL ,
  `FName` VARCHAR(45) NOT NULL ,
  `SSN` INT NOT NULL ,
  `Phone` INT NOT NULL ,
  `Address` VARCHAR(200) NULL DEFAULT NULL ,
  `Email` VARCHAR(45) NULL DEFAULT NULL ,
  PRIMARY KEY (`ID`) ,
  UNIQUE INDEX `ID_UNIQUE` (`ID` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `teamchro_LATSQL`.`Jobs`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `teamchro_LATSQL`.`Jobs` (
  `JID` INT NOT NULL ,
  `JName` VARCHAR(45) NOT NULL ,
  `JSPay` DECIMAL NOT NULL ,
  `Img` VARCHAR(100) NULL DEFAULT NULL ,
  PRIMARY KEY (`JID`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `teamchro_LATSQL`.`Payrole YTD`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `teamchro_LATSQL`.`Payrole YTD` (
  `ID` INT NOT NULL ,
  `Total Hours` DECIMAL NOT NULL ,
  `Total Income` DECIMAL NOT NULL ,
  `Total Taxes` DECIMAL NOT NULL ,
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
  `JID` INT NOT NULL ,
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
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `teamchro_LATSQL`.`Hours Worked`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `teamchro_LATSQL`.`Hours Worked` (
  `ID` INT NOT NULL ,
  `JID` INT NOT NULL ,
  `Date` DATE NOT NULL ,
  `In` TIME NOT NULL ,
  `Out` TIME NOT NULL ,
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
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `teamchro_LATSQL`.`Schedule`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `teamchro_LATSQL`.`Schedule` (
  `ID` INT NOT NULL ,
  `JID` INT NOT NULL ,
  `Date` DATE NOT NULL ,
  `Stime` TIME NOT NULL ,
  `Etime` TIME NOT NULL ,
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
    ON DELETE CASCADE
    ON UPDATE CASCADE)
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



SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
