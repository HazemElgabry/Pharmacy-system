-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 18, 2020 at 02:42 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sw_project`
--

-- --------------------------------------------------------

--
-- Table structure for table `admins`
--

CREATE TABLE `admins` (
  `adminID` int(50) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` int(255) NOT NULL,
  `firstName` varchar(255) NOT NULL,
  `lastName` varchar(255) NOT NULL,
  `phoneNumber` int(20) NOT NULL,
  `dateOfBirth` int(20) NOT NULL,
  `emailAddress` varchar(30) NOT NULL,
  `cardID` int(30) NOT NULL,
  `creditCardNo` int(30) NOT NULL,
  `branshID` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `branches`
--

CREATE TABLE `branches` (
  `branchID` int(50) NOT NULL,
  `branchNo` int(50) NOT NULL,
  `managerName` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `phoneNumber` int(30) NOT NULL,
  `employeeID` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `cib`
--

CREATE TABLE `cib` (
  `branchID` int(50) NOT NULL,
  `customerID` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `customerorders`
--

CREATE TABLE `customerorders` (
  `cOrderID` int(50) NOT NULL,
  `customerName` varchar(255) NOT NULL,
  `branchName` varchar(255) NOT NULL,
  `destiny` varchar(255) NOT NULL,
  `deliveryDate` int(11) NOT NULL,
  `serviceType` varchar(255) NOT NULL,
  `medicineID` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `customerID` int(50) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` int(30) NOT NULL,
  `firstName` varchar(255) NOT NULL,
  `lastName` varchar(255) NOT NULL,
  `address` varchar(50) NOT NULL,
  `zipCode` int(30) NOT NULL,
  `phoneNumber` int(20) NOT NULL,
  `emailAddress` varchar(30) NOT NULL,
  `dateOfBirth` int(20) NOT NULL,
  `cardID` int(30) NOT NULL,
  `creditCardNo` int(30) NOT NULL,
  `cOrderID` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE `employees` (
  `employeeID` int(50) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` int(20) NOT NULL,
  `firstName` varchar(255) NOT NULL,
  `lastName` varchar(255) NOT NULL,
  `phoneNumber` int(20) NOT NULL,
  `address` varchar(50) NOT NULL,
  `emailAddress` varchar(50) NOT NULL,
  `zipCode` int(30) NOT NULL,
  `dateOfBirth` varchar(20) NOT NULL,
  `cardID` int(30) NOT NULL,
  `dateOfWork` varchar(20) NOT NULL,
  `salary` varchar(20) NOT NULL,
  `jopType` varchar(255) NOT NULL,
  `creditCardNo` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `medicines`
--

CREATE TABLE `medicines` (
  `medicineID` int(50) NOT NULL,
  `name` varchar(255) NOT NULL,
  `expireDate` int(20) NOT NULL,
  `description` varchar(255) NOT NULL,
  `imporDate` int(20) NOT NULL,
  `blackList` varchar(255) NOT NULL,
  `maxDose` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `mib`
--

CREATE TABLE `mib` (
  `branchID` int(50) NOT NULL,
  `customerID` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `vendororders`
--

CREATE TABLE `vendororders` (
  `vendorID` int(50) NOT NULL,
  `orderNo` int(50) NOT NULL,
  `vendorName` varchar(255) NOT NULL,
  `branchName` varchar(255) NOT NULL,
  `orderDescription` varchar(255) NOT NULL,
  `deliveryDate` int(20) NOT NULL,
  `medicineID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `vendors`
--

CREATE TABLE `vendors` (
  `vendorID` int(50) NOT NULL,
  `name` varchar(255) NOT NULL,
  `companyPhoneNumber` int(11) NOT NULL,
  `managerPhoneNumber` int(11) NOT NULL,
  `contractDate` int(11) NOT NULL,
  `numberOfBranches` int(11) NOT NULL,
  `companyEmailAddress` int(11) NOT NULL,
  `vOrderID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `vib`
--

CREATE TABLE `vib` (
  `branchID` int(50) NOT NULL,
  `vendorID` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admins`
--
ALTER TABLE `admins`
  ADD PRIMARY KEY (`adminID`),
  ADD KEY `admins_ibfk_1` (`branshID`);

--
-- Indexes for table `branches`
--
ALTER TABLE `branches`
  ADD PRIMARY KEY (`branchID`),
  ADD KEY `employeeID` (`employeeID`);

--
-- Indexes for table `cib`
--
ALTER TABLE `cib`
  ADD KEY `branchID` (`branchID`,`customerID`),
  ADD KEY `customerID` (`customerID`);

--
-- Indexes for table `customerorders`
--
ALTER TABLE `customerorders`
  ADD PRIMARY KEY (`cOrderID`),
  ADD KEY `medicineID` (`medicineID`);

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`customerID`),
  ADD KEY `cOrderID` (`cOrderID`);

--
-- Indexes for table `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`employeeID`);

--
-- Indexes for table `medicines`
--
ALTER TABLE `medicines`
  ADD PRIMARY KEY (`medicineID`);

--
-- Indexes for table `mib`
--
ALTER TABLE `mib`
  ADD KEY `branchID` (`branchID`,`customerID`),
  ADD KEY `mib_ibfk_2` (`customerID`);

--
-- Indexes for table `vendororders`
--
ALTER TABLE `vendororders`
  ADD PRIMARY KEY (`vendorID`),
  ADD KEY `medicineID` (`medicineID`);

--
-- Indexes for table `vendors`
--
ALTER TABLE `vendors`
  ADD PRIMARY KEY (`vendorID`),
  ADD KEY `vOrderID` (`vOrderID`);

--
-- Indexes for table `vib`
--
ALTER TABLE `vib`
  ADD KEY `branchID` (`branchID`,`vendorID`),
  ADD KEY `vendorID` (`vendorID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admins`
--
ALTER TABLE `admins`
  MODIFY `adminID` int(50) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `branches`
--
ALTER TABLE `branches`
  MODIFY `branchID` int(50) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `customerorders`
--
ALTER TABLE `customerorders`
  MODIFY `cOrderID` int(50) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `customerID` int(50) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `employees`
--
ALTER TABLE `employees`
  MODIFY `employeeID` int(50) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `vendororders`
--
ALTER TABLE `vendororders`
  MODIFY `vendorID` int(50) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `vendors`
--
ALTER TABLE `vendors`
  MODIFY `vendorID` int(50) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `admins`
--
ALTER TABLE `admins`
  ADD CONSTRAINT `admins_ibfk_1` FOREIGN KEY (`branshID`) REFERENCES `branches` (`branchID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `branches`
--
ALTER TABLE `branches`
  ADD CONSTRAINT `branches_ibfk_1` FOREIGN KEY (`employeeID`) REFERENCES `employees` (`employeeID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `cib`
--
ALTER TABLE `cib`
  ADD CONSTRAINT `cib_ibfk_1` FOREIGN KEY (`branchID`) REFERENCES `branches` (`branchID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cib_ibfk_2` FOREIGN KEY (`customerID`) REFERENCES `customers` (`customerID`);

--
-- Constraints for table `customerorders`
--
ALTER TABLE `customerorders`
  ADD CONSTRAINT `customerorders_ibfk_1` FOREIGN KEY (`medicineID`) REFERENCES `medicines` (`medicineID`);

--
-- Constraints for table `customers`
--
ALTER TABLE `customers`
  ADD CONSTRAINT `customers_ibfk_1` FOREIGN KEY (`cOrderID`) REFERENCES `customerorders` (`cOrderID`);

--
-- Constraints for table `mib`
--
ALTER TABLE `mib`
  ADD CONSTRAINT `mib_ibfk_1` FOREIGN KEY (`branchID`) REFERENCES `branches` (`branchID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `mib_ibfk_2` FOREIGN KEY (`customerID`) REFERENCES `medicines` (`medicineID`);

--
-- Constraints for table `vendororders`
--
ALTER TABLE `vendororders`
  ADD CONSTRAINT `vendororders_ibfk_1` FOREIGN KEY (`medicineID`) REFERENCES `medicines` (`medicineID`);

--
-- Constraints for table `vendors`
--
ALTER TABLE `vendors`
  ADD CONSTRAINT `vendors_ibfk_1` FOREIGN KEY (`vOrderID`) REFERENCES `vendororders` (`vendorID`);

--
-- Constraints for table `vib`
--
ALTER TABLE `vib`
  ADD CONSTRAINT `vib_ibfk_1` FOREIGN KEY (`branchID`) REFERENCES `branches` (`branchID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `vib_ibfk_2` FOREIGN KEY (`vendorID`) REFERENCES `vendors` (`vendorID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
