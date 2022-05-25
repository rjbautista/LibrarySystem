-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 25, 2022 at 02:14 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `library`
--

-- --------------------------------------------------------

--
-- Table structure for table `bookcategories`
--

CREATE TABLE `bookcategories` (
  `ID` int(11) NOT NULL,
  `Name` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `bookcategories`
--

INSERT INTO `bookcategories` (`ID`, `Name`) VALUES
(1, 'test'),
(3, 'Science'),
(4, 'Math'),
(5, 'English'),
(6, 'Sibika at Kultura');

-- --------------------------------------------------------

--
-- Table structure for table `bookdetails`
--

CREATE TABLE `bookdetails` (
  `ID` int(11) NOT NULL,
  `BookHeaderId` int(11) NOT NULL,
  `BookNo` int(11) NOT NULL,
  `IsAvailable` tinyint(1) NOT NULL,
  `Status` varchar(20) NOT NULL,
  `Created` datetime NOT NULL DEFAULT current_timestamp(),
  `LastUpdated` datetime NOT NULL DEFAULT current_timestamp(),
  `Note` longtext DEFAULT NULL,
  `UserId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `bookdetails`
--

INSERT INTO `bookdetails` (`ID`, `BookHeaderId`, `BookNo`, `IsAvailable`, `Status`, `Created`, `LastUpdated`, `Note`, `UserId`) VALUES
(1, 1, 1001, 0, 'unreturned', '2022-05-23 22:43:08', '2022-05-25 05:12:08', 'This book has not been returned by John with USN: 333 BS Computer Science. \nTransaction ID: 1', 3),
(2, 1, 1002, 1, 'active', '2022-05-24 00:16:50', '2022-05-24 20:34:42', NULL, NULL),
(3, 1, 1003, 1, 'active', '2022-05-24 00:17:05', '2022-05-24 00:18:00', NULL, NULL),
(4, 1, 1004, 1, 'active', '2022-05-24 00:25:47', '2022-05-25 04:43:53', NULL, NULL),
(5, 2, 2001, 1, 'active', '2022-05-24 00:29:45', '2022-05-25 04:44:26', NULL, NULL),
(6, 2, 2002, 1, 'active', '2022-05-24 00:29:55', '2022-05-25 04:44:30', NULL, NULL),
(7, 2, 2003, 1, 'active', '2022-05-24 00:30:13', '2022-05-24 00:32:20', NULL, NULL),
(8, 2, 2004, 1, 'active', '2022-05-24 00:30:37', '2022-05-24 00:31:55', NULL, NULL),
(9, 3, 3001, 1, 'active', '2022-05-24 04:42:43', '2022-05-25 04:44:56', NULL, NULL),
(10, 3, 3002, 1, 'active', '2022-05-24 04:43:09', '2022-05-25 04:45:00', NULL, NULL),
(11, 3, 3003, 1, 'active', '2022-05-24 04:43:28', '2022-05-24 05:05:39', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `bookheaders`
--

CREATE TABLE `bookheaders` (
  `ID` int(11) NOT NULL,
  `ISBN` varchar(255) DEFAULT NULL,
  `Title` varchar(255) NOT NULL,
  `Author` varchar(255) DEFAULT NULL,
  `Edition` varchar(255) DEFAULT NULL,
  `Publisher` varchar(255) DEFAULT NULL,
  `PublicationYear` varchar(20) DEFAULT NULL,
  `AvailableQty` int(11) NOT NULL DEFAULT 0,
  `TotalQty` int(11) NOT NULL DEFAULT 0,
  `CategoryId` int(11) NOT NULL,
  `Status` varchar(20) NOT NULL DEFAULT 'active',
  `Created` datetime NOT NULL DEFAULT current_timestamp(),
  `LastUpdated` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `bookheaders`
--

INSERT INTO `bookheaders` (`ID`, `ISBN`, `Title`, `Author`, `Edition`, `Publisher`, `PublicationYear`, `AvailableQty`, `TotalQty`, `CategoryId`, `Status`, `Created`, `LastUpdated`) VALUES
(1, 'isbn', 'Harry Potter and the Sorcerrer Stone', 'author', 'edition', 'publisher', '111', 3, 4, 4, 'active', '2022-05-23 06:22:38', '2022-05-23 22:49:13'),
(2, '1223-3213', 'Book1', 'Author', 'Editon 1', 'Pulish', '2021', 4, 4, 3, 'active', '2022-05-23 07:41:50', '2022-05-25 05:12:14'),
(3, '111-111', 'Learning with English 1', 'Angelo Cendana', 'First', 'Publisher', '2021', 3, 3, 1, 'active', '2022-05-24 04:40:57', '2022-05-25 05:12:17');

-- --------------------------------------------------------

--
-- Table structure for table `booklogs`
--

CREATE TABLE `booklogs` (
  `ID` int(11) NOT NULL,
  `BookHeaderId` int(11) NOT NULL,
  `BookDetailId` int(11) NOT NULL,
  `BookNo` int(11) NOT NULL,
  `Description` longtext NOT NULL,
  `Created` datetime NOT NULL DEFAULT current_timestamp(),
  `UserId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `booklogs`
--

INSERT INTO `booklogs` (`ID`, `BookHeaderId`, `BookDetailId`, `BookNo`, `Description`, `Created`, `UserId`) VALUES
(1, 1, 1, 0, 'Book has been updated. Details below:\r\n BookNo=1001,IsAvailable=1,Status=active,Note=,Status=active', '2022-05-25 05:12:08', 1),
(2, 2, 0, 0, 'Book has been updated. Details below:\r\n ISBN=1223-3213,Title=Book1,Author=Author,Edition=Editon 1,Publisher=Pulish,PublicationYear=2021,TotalQty=4,CategoryId=3,Status=active', '2022-05-25 05:12:14', 1),
(3, 3, 0, 0, 'Book has been updated. Details below:\r\n ISBN=111-111,Title=Learning with English 1,Author=Angelo Cendana,Edition=First,Publisher=Publisher,PublicationYear=2021,TotalQty=3,CategoryId=1,Status=active', '2022-05-25 05:12:17', 1),
(4, 3, 9, 0, 'Borrowed by John with USN: 333 System.Windows.Forms.Label, Text: BS Computer Science. \nTransaction ID: 1', '2022-05-25 05:14:20', 1),
(5, 2, 5, 0, 'Borrowed by John with USN: 333 System.Windows.Forms.Label, Text: BS Computer Science. \nTransaction ID: 1', '2022-05-25 05:14:20', 1),
(6, 1, 1, 0, 'Borrowed by John with USN: 333 System.Windows.Forms.Label, Text: BS Computer Science. \nTransaction ID: 1', '2022-05-25 05:14:20', 1),
(7, 3, 9, 0, 'Returned by John with USN: 333 BS Computer Science. \nTransaction ID: 1', '2022-05-25 05:16:33', 1),
(8, 2, 5, 0, 'Returned by John with USN: 333 BS Computer Science. \nTransaction ID: 1', '2022-05-25 05:16:35', 1);

-- --------------------------------------------------------

--
-- Table structure for table `booktxndetails`
--

CREATE TABLE `booktxndetails` (
  `ID` int(11) NOT NULL,
  `BookTxnHeaderId` int(11) NOT NULL,
  `BookHeaderId` int(11) NOT NULL,
  `BookDetailId` int(11) DEFAULT NULL,
  `UserId` int(11) NOT NULL,
  `Note` longtext NOT NULL,
  `IsReturned` tinyint(1) NOT NULL DEFAULT 0,
  `RequestDate` datetime NOT NULL DEFAULT current_timestamp(),
  `BorrowDate` datetime DEFAULT NULL,
  `ReturnDate` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `booktxndetails`
--

INSERT INTO `booktxndetails` (`ID`, `BookTxnHeaderId`, `BookHeaderId`, `BookDetailId`, `UserId`, `Note`, `IsReturned`, `RequestDate`, `BorrowDate`, `ReturnDate`) VALUES
(1, 1, 3, 9, 3, '', 1, '2022-05-25 05:13:20', '2022-05-25 05:14:14', '2022-05-25 05:16:33'),
(2, 1, 2, 5, 3, '', 1, '2022-05-25 05:13:20', '2022-05-25 05:14:16', '2022-05-25 05:16:35'),
(3, 1, 1, 1, 3, '', 0, '2022-05-25 05:13:20', '2022-05-25 05:14:17', NULL),
(4, 2, 3, NULL, 3, '', 0, '2022-05-25 05:43:21', NULL, NULL),
(5, 2, 2, NULL, 3, '', 0, '2022-05-25 05:43:21', NULL, NULL),
(6, 2, 1, NULL, 3, '', 0, '2022-05-25 05:43:21', NULL, NULL),
(7, 3, 3, NULL, 3, '', 0, '2022-05-25 05:43:38', NULL, NULL),
(8, 3, 2, NULL, 3, '', 0, '2022-05-25 05:43:38', NULL, NULL),
(9, 3, 1, NULL, 3, '', 0, '2022-05-25 05:43:38', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `booktxnheaders`
--

CREATE TABLE `booktxnheaders` (
  `ID` int(11) NOT NULL,
  `UserId` int(11) NOT NULL,
  `RequestDate` datetime NOT NULL DEFAULT current_timestamp(),
  `BorrowDate` datetime DEFAULT NULL,
  `ReturnDate` datetime DEFAULT NULL,
  `DeclineDate` datetime DEFAULT NULL,
  `Status` varchar(30) NOT NULL DEFAULT 'Request',
  `Note` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `booktxnheaders`
--

INSERT INTO `booktxnheaders` (`ID`, `UserId`, `RequestDate`, `BorrowDate`, `ReturnDate`, `DeclineDate`, `Status`, `Note`) VALUES
(1, 3, '2022-05-25 05:13:20', '2022-05-25 05:14:20', '2022-05-25 05:16:40', NULL, 'Returned', NULL),
(2, 3, '2022-05-25 05:43:21', NULL, NULL, NULL, 'Request', NULL),
(3, 3, '2022-05-25 05:43:38', NULL, NULL, NULL, 'Request', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `courses`
--

CREATE TABLE `courses` (
  `ID` int(11) NOT NULL,
  `Name` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `courses`
--

INSERT INTO `courses` (`ID`, `Name`) VALUES
(1, 'BS Computer Science'),
(2, 'BS Information Technology'),
(3, 'BS Information System'),
(4, 'BS Business Administration'),
(5, 'BS Accountancy'),
(6, 'BS Entrepreneurship'),
(7, 'BS Accounting Technology'),
(8, 'BS Real Estate Management'),
(9, 'Associate in Accounting Technology'),
(10, 'Associate in Computer Technology'),
(11, 'Computer Systems Design and Programming'),
(12, 'Computer Systems and Network Technology'),
(13, 'Networking and Telecommunications Technology'),
(14, 'Computer Graphics and Animation'),
(15, 'Web Development Technology'),
(16, 'Computer Hardware and Servicing'),
(17, 'Architectural Design Technology'),
(18, 'Computer-based Accounting'),
(19, 'Business and Office Administrative Services'),
(20, 'Game Programming NC III');

-- --------------------------------------------------------

--
-- Table structure for table `incidents`
--

CREATE TABLE `incidents` (
  `ID` int(11) NOT NULL,
  `IRNo` varchar(20) NOT NULL,
  `Title` varchar(500) NOT NULL,
  `Description` longtext NOT NULL,
  `UserId` int(11) NOT NULL,
  `StudentId` int(11) NOT NULL,
  `BookTxnHeaderId` int(11) NOT NULL,
  `Created` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `incidents`
--

INSERT INTO `incidents` (`ID`, `IRNo`, `Title`, `Description`, `UserId`, `StudentId`, `BookTxnHeaderId`, `Created`) VALUES
(1, '220625060624', 'Incident Report #220625060624 - 333:John', 'testing', 1, 3, 2, '2022-05-25 06:06:35');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `ID` int(11) NOT NULL,
  `USN` varchar(20) DEFAULT NULL,
  `Role` varchar(20) NOT NULL,
  `Name` varchar(250) NOT NULL,
  `Gender` varchar(50) DEFAULT NULL,
  `Position` varchar(50) DEFAULT NULL,
  `Course` varchar(250) DEFAULT NULL,
  `Year` varchar(5) DEFAULT NULL,
  `ContactNo` varchar(50) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Password` varchar(50) NOT NULL,
  `Status` varchar(20) DEFAULT NULL,
  `IsVisitor` tinyint(1) DEFAULT NULL,
  `Created` datetime NOT NULL DEFAULT current_timestamp(),
  `IsEnrolled` tinyint(1) NOT NULL,
  `QR` varchar(300) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`ID`, `USN`, `Role`, `Name`, `Gender`, `Position`, `Course`, `Year`, `ContactNo`, `Email`, `Password`, `Status`, `IsVisitor`, `Created`, `IsEnrolled`, `QR`) VALUES
(1, '111', 'Student', 'Administrator', 'Male', 'Administrator', 'BS Computer Science', '2021', '111', 'admin@admin.com', '111', 'active', 0, '2022-05-23 00:00:00', 0, NULL),
(2, '222', 'Student', 'RJ', 'Male', 'Student', 'BS Computer Science', '2021', '222', 'test@test.com', '222', 'active', 0, '2022-05-23 04:51:37', 0, 'qr/2.jpg'),
(3, '333', 'Student', 'John', 'Female', 'Administrator', 'BS Computer Science', '', '111', '', '111', 'active', 1, '2022-05-24 02:32:20', 1, 'qr/3.jpg'),
(4, '444', 'Student', 'Mark', 'Male', 'Professor', 'BS Computer Science', '', '111', '', '', 'active', 1, '2022-05-24 02:38:32', 0, 'qr/4.jpg'),
(5, '555', 'Student', 'Jerry', 'Male', 'Administrator', 'BS Computer Science', '', '1111', '', '555', 'active', 0, '2022-05-24 02:39:26', 1, 'qr/5.jpg'),
(6, '666', 'Student', 'James', 'Male', 'Student', 'BS Computer Science', '', '111', '', '', 'active', 0, '2022-05-24 02:41:01', 1, 'qr/6.jpg'),
(7, '777', 'Student', 'Angelo Cendana', 'Male', 'Administrator', 'BS Computer Science', '', '111', '', '', 'active', 0, '2022-05-24 04:47:20', 1, 'qr/7.jpg');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bookcategories`
--
ALTER TABLE `bookcategories`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bookdetails`
--
ALTER TABLE `bookdetails`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bookheaders`
--
ALTER TABLE `bookheaders`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `booklogs`
--
ALTER TABLE `booklogs`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `booktxndetails`
--
ALTER TABLE `booktxndetails`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `booktxnheaders`
--
ALTER TABLE `booktxnheaders`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `courses`
--
ALTER TABLE `courses`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `incidents`
--
ALTER TABLE `incidents`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bookcategories`
--
ALTER TABLE `bookcategories`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `bookdetails`
--
ALTER TABLE `bookdetails`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `bookheaders`
--
ALTER TABLE `bookheaders`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `booklogs`
--
ALTER TABLE `booklogs`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `booktxndetails`
--
ALTER TABLE `booktxndetails`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `booktxnheaders`
--
ALTER TABLE `booktxnheaders`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `courses`
--
ALTER TABLE `courses`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `incidents`
--
ALTER TABLE `incidents`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
