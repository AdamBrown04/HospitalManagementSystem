-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Feb 29, 2024 at 11:08 AM
-- Server version: 10.4.10-MariaDB
-- PHP Version: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hospitalmanagementsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `appointment`
--

DROP TABLE IF EXISTS `appointment`;
CREATE TABLE IF NOT EXISTS `appointment` (
  `appointmentID` int(15) NOT NULL AUTO_INCREMENT,
  `hospitalID` int(15) NOT NULL,
  `patientDetailsID` int(15) NOT NULL,
  `appointmentDate` date NOT NULL,
  `appointmentTime` time NOT NULL,
  PRIMARY KEY (`appointmentID`),
  KEY `hospitalID` (`hospitalID`) USING BTREE,
  KEY `patientDetailsID` (`patientDetailsID`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `appointment`
--

INSERT INTO `appointment` (`appointmentID`, `hospitalID`, `patientDetailsID`, `appointmentDate`, `appointmentTime`) VALUES
(1, 1, 1, '2024-02-28', '13:30:00'),
(2, 2, 1, '2024-03-13', '16:00:00'),
(3, 5, 4, '2024-04-19', '11:45:00'),
(4, 4, 3, '2024-05-28', '13:15:00'),
(5, 1, 1, '2024-09-13', '10:40:00');

-- --------------------------------------------------------

--
-- Table structure for table `department`
--

DROP TABLE IF EXISTS `department`;
CREATE TABLE IF NOT EXISTS `department` (
  `departmentID` int(15) NOT NULL AUTO_INCREMENT,
  `departmentName` char(50) NOT NULL,
  PRIMARY KEY (`departmentID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `department`
--

INSERT INTO `department` (`departmentID`, `departmentName`) VALUES
(1, 'Radiology'),
(2, 'Administrative'),
(3, 'Nursing'),
(4, 'Inpatient'),
(5, 'Outpatient'),
(6, 'Medical'),
(7, 'emergency team'),
(8, 'food and beverages');

-- --------------------------------------------------------

--
-- Table structure for table `diagnosis`
--

DROP TABLE IF EXISTS `diagnosis`;
CREATE TABLE IF NOT EXISTS `diagnosis` (
  `diagnosisID` int(15) NOT NULL AUTO_INCREMENT,
  `staffID` int(15) NOT NULL,
  `patientRecordsID` int(15) NOT NULL,
  `diagnosisInformation` char(255) NOT NULL,
  PRIMARY KEY (`diagnosisID`),
  KEY `patientRecordsID` (`patientRecordsID`) USING BTREE,
  KEY `staffID` (`staffID`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `diagnosis`
--

INSERT INTO `diagnosis` (`diagnosisID`, `staffID`, `patientRecordsID`, `diagnosisInformation`) VALUES
(1, 3, 3, 'broken arm with multiple additional fractures and a fracture leg');

-- --------------------------------------------------------

--
-- Table structure for table `hospital`
--

DROP TABLE IF EXISTS `hospital`;
CREATE TABLE IF NOT EXISTS `hospital` (
  `hospitalID` int(15) NOT NULL AUTO_INCREMENT,
  `hospitalName` char(50) NOT NULL,
  `addressLine1` char(50) NOT NULL,
  `addressLine2` char(50) NOT NULL,
  `addressLine3` char(50) NOT NULL,
  `postcode` char(12) NOT NULL,
  PRIMARY KEY (`hospitalID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `hospital`
--

INSERT INTO `hospital` (`hospitalID`, `hospitalName`, `addressLine1`, `addressLine2`, `addressLine3`, `postcode`) VALUES
(1, 'Northern General', 'Herries Road', 'Fir Vale', 'Sheffield', 'S5 7AU'),
(2, 'Royal Hallamshire', 'Glossop Road', 'Hallam', 'Sheffield', 'S10 2FJ'),
(3, 'Children\'s Hospital', 'Western Bank', 'Hallam', 'Sheffield', 'S10 2TH'),
(4, 'Thornbury', '312 Fullwood Road', 'Hallam', 'Sheffield', 'S10 3BR'),
(5, 'Western Park', 'Whitham Road', 'Hallam', 'Sheffield', 'S10 2SJ');

-- --------------------------------------------------------

--
-- Table structure for table `jobs`
--

DROP TABLE IF EXISTS `jobs`;
CREATE TABLE IF NOT EXISTS `jobs` (
  `jobsID` int(15) NOT NULL AUTO_INCREMENT,
  `departmentID` int(15) NOT NULL,
  `jobName` char(50) NOT NULL,
  PRIMARY KEY (`jobsID`),
  KEY `departmentID` (`departmentID`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `jobs`
--

INSERT INTO `jobs` (`jobsID`, `departmentID`, `jobName`) VALUES
(1, 2, 'receptionist'),
(2, 2, 'system administrator'),
(6, 6, 'junior doctor'),
(7, 3, 'head nurse'),
(8, 1, 'radiologist'),
(9, 4, 'senior doctor'),
(10, 5, 'nurse'),
(11, 3, 'Department head'),
(12, 1, 'Lab technician'),
(13, 7, 'Paramedic'),
(14, 8, 'chef');

-- --------------------------------------------------------

--
-- Table structure for table `patientdetails`
--

DROP TABLE IF EXISTS `patientdetails`;
CREATE TABLE IF NOT EXISTS `patientdetails` (
  `patientDetailsID` int(15) NOT NULL AUTO_INCREMENT,
  `firstName` char(50) NOT NULL,
  `lastName` char(50) NOT NULL,
  `DoB` date NOT NULL,
  `email` char(50) NOT NULL,
  `phoneNumber` char(11) NOT NULL,
  `gender` char(50) NOT NULL,
  `addressLine1` char(50) NOT NULL,
  `addressLine2` char(50) NOT NULL,
  `addressLine3` char(50) NOT NULL,
  PRIMARY KEY (`patientDetailsID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `patientdetails`
--

INSERT INTO `patientdetails` (`patientDetailsID`, `firstName`, `lastName`, `DoB`, `email`, `phoneNumber`, `gender`, `addressLine1`, `addressLine2`, `addressLine3`) VALUES
(1, 'Lewis', 'Hardy', '2004-05-01', 'L.Hardy2004@outlook.com', '05232638915', 'male', '15 Iron road', 'Clowne', 'Sheffield'),
(2, 'Max', 'Dudley', '2003-11-04', 'maxdudley03@outlook.com', '01835677834', 'male', '27 Beighton road', 'Woodhouse', 'Sheffield'),
(3, 'Jessica', 'Maxwell', '1999-06-23', 'MaxwellJ@gmail.com', '06698416126', 'female', '84', 'Rotherham Road', 'Sheffield'),
(4, 'Katrina', 'Perrins', '1967-10-14', 'KatrinaPerrins67@hotmail.com', '02190084512', 'female', '03 Woodburn lane', 'Darnal', 'Sheffield'),
(5, 'Leo', 'Green', '2002-04-16', 'LGreen02@gmail.com', '09129812532', 'male', '78 Bradford Road', 'Attercliffe', 'Sheffield');

-- --------------------------------------------------------

--
-- Table structure for table `patientrecords`
--

DROP TABLE IF EXISTS `patientrecords`;
CREATE TABLE IF NOT EXISTS `patientrecords` (
  `patientRecordsID` int(15) NOT NULL AUTO_INCREMENT,
  `patientDetailsID` int(15) NOT NULL,
  `heightCM` int(15) NOT NULL,
  `weightKG` int(15) NOT NULL,
  `bloodType` char(15) NOT NULL,
  PRIMARY KEY (`patientRecordsID`),
  KEY `patientDetailsID` (`patientDetailsID`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `patientrecords`
--

INSERT INTO `patientrecords` (`patientRecordsID`, `patientDetailsID`, `heightCM`, `weightKG`, `bloodType`) VALUES
(1, 1, 179, 74, 'O-'),
(2, 2, 182, 83, 'AB+'),
(3, 3, 157, 55, 'B-'),
(4, 4, 169, 67, 'A+'),
(5, 5, 151, 63, 'O-');

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
CREATE TABLE IF NOT EXISTS `staff` (
  `staffID` int(15) NOT NULL AUTO_INCREMENT,
  `jobID` int(15) NOT NULL,
  `hospitalID` int(15) NOT NULL,
  `firstName` char(50) NOT NULL,
  `lastName` char(50) NOT NULL,
  `DoB` date NOT NULL,
  `phoneNumber` char(11) NOT NULL,
  `email` char(50) NOT NULL,
  `addressLine1` char(50) NOT NULL,
  `addressLine2` char(50) NOT NULL,
  `addressLine3` char(50) NOT NULL,
  `username` char(50) NOT NULL,
  `password` char(50) NOT NULL,
  `accessLevel` int(11) NOT NULL,
  PRIMARY KEY (`staffID`),
  UNIQUE KEY `username` (`username`),
  KEY `jobID` (`jobID`) USING BTREE,
  KEY `hospitalID` (`hospitalID`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`staffID`, `jobID`, `hospitalID`, `firstName`, `lastName`, `DoB`, `phoneNumber`, `email`, `addressLine1`, `addressLine2`, `addressLine3`, `username`, `password`, `accessLevel`) VALUES
(1, 2, 1, 'John', 'Vanthoor', '1996-02-27', '0375931238', 'JohnVanthoor96@hotmail.com', '18 Fullwood drive', 'Hansworth', 'Sheffield', 'admin', 'password', 1),
(2, 1, 3, 'Oliver', 'Brown', '2000-09-04', '02512753634', 'OBrown@outlook.com', '87 Spa Lane', 'Woodhouse', 'Sheffield', 'BrownOliver', 'password123', 3),
(3, 9, 1, 'Jamie', 'Adams', '1984-05-15', '09241259821', 'AdamsJ84@hotmail.com', '11 Retford Close', 'Burnley', 'Sheffield', 'AdamsJamie', 'passwordabc', 5),
(4, 10, 4, 'Jessica', 'Hardy', '1994-01-23', '01219568125', 'JHardy@gmail.com', '234 London Road', 'Manor', 'Sheffield', 'HardyJessica', 'password987', 7),
(5, 11, 3, 'Daniel', 'Jackson', '1968-07-17', '03532935763', 'DJackson1968@hotmail.com', '53 Stradbrooke Road', 'Stradbrooke', 'Sheffield', 'JacksonDaniel', 'passwordzyx', 2),
(6, 14, 2, 'Dale', 'Tucker', '1982-05-04', '03354239735', 'TuckerD@aol.com', '7 Fernwood Close', 'Doore', 'Sheffield', 'TuckerDale', 'password456', 4),
(7, 13, 2, 'John', 'Kissinger', '2000-09-23', '07423523523', 'Kissinger000@hotmail.com', '96 Fullbeck Way', 'Stradbrooke', 'Sheffield', 'KissingerJohn', 'passwordOne', 6),
(8, 12, 4, 'Matthew', 'Clarke', '1997-05-15', '08823531863', 'MattClarke@outlook.com', '13 Skelton Lane', 'Woodhouse', 'Sheffield', 'ClarkeMatthew', 'password930', 8),
(9, 8, 1, 'Sergio', 'Alonso', '1982-07-01', '01313500235', 'SAlonso82@outlook.com', '19 Chester Road', 'Beighton', 'Sheffield', 'AlonsoSergio', 'password962', 9);

-- --------------------------------------------------------

--
-- Table structure for table `test`
--

DROP TABLE IF EXISTS `test`;
CREATE TABLE IF NOT EXISTS `test` (
  `testID` int(15) NOT NULL AUTO_INCREMENT,
  `staffID` int(15) NOT NULL,
  `patientRecordsID` int(15) NOT NULL,
  `testResults` char(255) NOT NULL,
  `testName` char(50) NOT NULL,
  PRIMARY KEY (`testID`),
  KEY `staffID` (`staffID`) USING BTREE,
  KEY `patientRecordsID` (`patientRecordsID`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `test`
--

INSERT INTO `test` (`testID`, `staffID`, `patientRecordsID`, `testResults`, `testName`) VALUES
(1, 8, 2, 'Blood test - Ran a blood test to see if there was any blood borne viruses. None was found', 'Blood test'),
(2, 8, 1, 'Urine sample - found nothing outside of the acceptable results', 'Urine sample'),
(3, 9, 3, 'X-Ray - got results back, found a small fracture on patients left leg', 'X-ray'),
(4, 9, 3, 'X-Ray - checked results and right arm has 3 fractures and a break', 'X-ray'),
(5, 8, 4, 'CBC - no medication side affects found. Can move onto next stage of treatment', 'CBC');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `appointment`
--
ALTER TABLE `appointment`
  ADD CONSTRAINT `appointment_ibfk_1` FOREIGN KEY (`hospitalID`) REFERENCES `hospital` (`hospitalID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `appointment_ibfk_2` FOREIGN KEY (`patientDetailsID`) REFERENCES `patientdetails` (`patientDetailsID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `diagnosis`
--
ALTER TABLE `diagnosis`
  ADD CONSTRAINT `diagnosis_ibfk_1` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `diagnosis_ibfk_2` FOREIGN KEY (`patientRecordsID`) REFERENCES `patientrecords` (`patientRecordsID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `jobs`
--
ALTER TABLE `jobs`
  ADD CONSTRAINT `jobs_ibfk_1` FOREIGN KEY (`departmentID`) REFERENCES `department` (`departmentID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `patientrecords`
--
ALTER TABLE `patientrecords`
  ADD CONSTRAINT `patientrecords_ibfk_1` FOREIGN KEY (`patientDetailsID`) REFERENCES `patientdetails` (`patientDetailsID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `staff`
--
ALTER TABLE `staff`
  ADD CONSTRAINT `staff_ibfk_1` FOREIGN KEY (`jobID`) REFERENCES `jobs` (`jobsID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `staff_ibfk_2` FOREIGN KEY (`hospitalID`) REFERENCES `hospital` (`hospitalID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `test`
--
ALTER TABLE `test`
  ADD CONSTRAINT `test_ibfk_1` FOREIGN KEY (`patientRecordsID`) REFERENCES `patientrecords` (`patientRecordsID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `test_ibfk_2` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
