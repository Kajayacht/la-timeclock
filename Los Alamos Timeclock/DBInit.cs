using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Los_Alamos_Timeclock.Manager.Admin;

namespace Los_Alamos_Timeclock
{
    class DBInit
    {

        public static void initTables(MySqlConnection myConnection)
        {
            Main.maininstance.connectDB(myConnection);
            myConnection.Open();

            //build the tables if the do not exist

            //Employee
            Main.maininstance.sqlCommand("CREATE TABLE if not exists `Employee` (  `ID` int(11) NOT NULL auto_increment,  `LName` text NOT NULL,  `MName` varchar(20) NOT NULL,  `FName` text NOT NULL,  `SSN` text NOT NULL,  `Phone` int(10) NOT NULL,  `Email` text NOT NULL,  `Address1` text,  `Address2` text,  `City` text NOT NULL,  `State` text,  `Zip` int(11) default NULL,  `SDate` date NOT NULL,  `EDate` date default NULL,  `EReason` varchar(10) default NULL,  PRIMARY KEY  (`ID`),  UNIQUE KEY `ID_UNIQUE` (`ID`)) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;");
            //Admin
            Main.maininstance.sqlCommand("CREATE TABLE if not exists `Admin` (  `ID` int(11) NOT NULL,  PRIMARY KEY  (`ID`),  KEY `AID` (`ID`),  CONSTRAINT `AID` FOREIGN KEY (`ID`) REFERENCES `Employee` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE) ENGINE=InnoDB DEFAULT CHARSET=latin1;");
            //Jobs
            Main.maininstance.sqlCommand("CREATE TABLE if not exists `Jobs` (  `JID` varchar(50) NOT NULL, `JSPay` decimal(10,2) NOT NULL, `TippedJob` varchar(5) character set latin1 collate latin1_bin default 'FALSE',  `Filename` text,  PRIMARY KEY  (`JID`)) ENGINE=InnoDB DEFAULT CHARSET=latin1;");
            //Employee Jobs         
            Main.maininstance.sqlCommand("CREATE TABLE if not exists `Employee Jobs` (  `ID` int(11) NOT NULL,  `JID` varchar(50) NOT NULL,  `JPay` decimal(3,2) NOT NULL,  KEY `EJID` (`ID`),  KEY `EJJID` (`JID`),  CONSTRAINT `EJJID` FOREIGN KEY (`JID`) REFERENCES `Jobs` (`JID`) ON DELETE CASCADE ON UPDATE CASCADE,  CONSTRAINT `EJID` FOREIGN KEY (`ID`) REFERENCES `Employee` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE) ENGINE=InnoDB DEFAULT CHARSET=latin1;");
            //EmployeeNotes
            Main.maininstance.sqlCommand("CREATE TABLE if not exists `EmployeeNotes` (  `ID` int(11) NOT NULL,  `Manager` varchar(50) NOT NULL,  `Date` datetime NOT NULL,  `Note` text NOT NULL,  KEY `NoteEID` (`ID`),  CONSTRAINT `ENID` FOREIGN KEY (`ID`) REFERENCES `Employee` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE) ENGINE=InnoDB DEFAULT CHARSET=latin1;");
            //Hours Worked            
            Main.maininstance.sqlCommand("CREATE TABLE if not exists `Hours Worked` (  `ID` int(11) NOT NULL,  `Date` date NOT NULL,  `Start` time default NULL,  `End` time default NULL,  `Tips` decimal(10,2) default NULL,  `JID` varchar(50) NOT NULL,  `B1out` time default NULL,  `B1in` time default NULL,  `B2out` time default NULL,  `B2in` time default NULL,  `Lout` time default NULL,  `Lin` time default NULL,  `Status` varchar(20) default NULL,  KEY `HWID` (`ID`),  KEY `HWJID` (`JID`),  CONSTRAINT `HWJID` FOREIGN KEY (`JID`) REFERENCES `Jobs` (`JID`) ON DELETE CASCADE ON UPDATE CASCADE, CONSTRAINT `HWID` FOREIGN KEY (`ID`) REFERENCES `Employee` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE) ENGINE=InnoDB DEFAULT CHARSET=latin1;");
            //Manager
            Main.maininstance.sqlCommand("CREATE TABLE if not exists `Manager` (  `ID` int(11) NOT NULL,  PRIMARY KEY  (`ID`),  KEY `MID` (`ID`), CONSTRAINT `MID` FOREIGN KEY (`ID`) REFERENCES `Employee` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE) ENGINE=InnoDB DEFAULT CHARSET=latin1;");
            //Requests
            Main.maininstance.sqlCommand("CREATE TABLE if not exists `Requests` (  `ID` int(11) NOT NULL,  `SDate` date NOT NULL,  `EDate` date NOT NULL,  `Submitted Date` date default NULL,  `Reason` text,  KEY `RID` (`ID`),  CONSTRAINT `Rid` FOREIGN KEY (`ID`) REFERENCES `Employee` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE) ENGINE=InnoDB DEFAULT CHARSET=latin1;");
            //Schedule
            Main.maininstance.sqlCommand("CREATE TABLE if not exists `Schedule` (  `ID` int(11) NOT NULL,  `Date` date NOT NULL,  `Start` time NOT NULL,  `End` time NOT NULL,  `JID` varchar(50) NOT NULL,  KEY `SID` (`ID`),  KEY `SJID` (`JID`),  CONSTRAINT `SJID` FOREIGN KEY (`JID`) REFERENCES `Jobs` (`JID`) ON DELETE CASCADE ON UPDATE CASCADE,  CONSTRAINT `SID` FOREIGN KEY (`ID`) REFERENCES `Employee` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE) ENGINE=InnoDB DEFAULT CHARSET=latin1;");
            //Users
            Main.maininstance.sqlCommand("CREATE TABLE if not exists `Users` (  `ID` int(11) NOT NULL,  `User` varchar(45) NOT NULL,  `Password` varchar(84) NOT NULL,  PRIMARY KEY  (`ID`),  KEY `ID` (`ID`),  CONSTRAINT `ID` FOREIGN KEY (`ID`) REFERENCES `Employee` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE) ENGINE=InnoDB DEFAULT CHARSET=latin1;");

            myConnection.Close();
        }

        public static void initAdmin(MySqlConnection myConnection)
        {
            //create initial admin
            //check if there are no admins            
            Main.maininstance.connectDB(myConnection);
            myConnection.Open();
            Main.maininstance.sqlReader("select count(*) from Admin");

            if (int.Parse(Main.reader["count(*)"].ToString()) == 0)
            {
                //Alert that no admins were found, ask if they want to make one
                DialogResult result = MessageBox.Show("No Administrators were found in the Database. \r\nDo you want to create one?", "Admin Not Found", MessageBoxButtons.YesNo);


                if (result == DialogResult.Yes)
                {
                    bool init = true;

                    //make a new employee 

                    Main.maininstance.menu1.Show();
                    Main.maininstance.panel1.Controls.Clear();
                    Main.maininstance.panel1.Controls.Add(new Newemployee(init));
                    Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;

                    //give him admin rights

                }
                //Or exit the program
                else
                {
                    myConnection.Close();
                    Environment.Exit(0);
                }
            }
            myConnection.Close();
        }
    }
}