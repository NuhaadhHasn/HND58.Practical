-- Database for the BookStore site (WAD58 batch).
-- The `book` table is the one from my local `bookstore` database (its single test row is not kept).
-- The `user` table did not exist in that database, although Login.php / User.php read it:
-- its columns are the ones the User class uses. The demo rows below are made up for this repository.

CREATE DATABASE IF NOT EXISTS `bookstore` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `bookstore`;

DROP TABLE IF EXISTS `book`;
CREATE TABLE `book` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `Title` varchar(255) NOT NULL,
  `Desctiption` varchar(255) NOT NULL,
  `Price` int(11) NOT NULL,
  `CoverFront` varchar(255) NOT NULL,
  `CoverBack` varchar(255) NOT NULL,
  `ISBN` int(11) NOT NULL,
  `Category` varchar(255) NOT NULL,
  `Author` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `UserId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) NOT NULL,
  `Username` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `Type` varchar(50) NOT NULL,
  PRIMARY KEY (`UserId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `user` (`Name`, `Username`, `Password`, `Email`, `Type`) VALUES
('Shop Admin', 'admin', 'admin', 'admin@example.com', 'Admin');

INSERT INTO `book` (`Title`, `Desctiption`, `Price`, `CoverFront`, `CoverBack`, `ISBN`, `Category`, `Author`) VALUES
('Sample Book One',   'A made-up book so the shop front is not empty.', 1500, './BookCovers/1F.jpg',  './BookCovers/1B.jpg',  100001, 'Fiction',   'A. Writer'),
('Sample Book Two',   'Another made-up book.',                          1200, './BookCovers/2F.jpg',  './BookCovers/2B.jpg',  100002, 'Education', 'B. Author'),
('Sample Book Three', 'A third made-up book.',                           900, './BookCovers/3F.jpg',  './BookCovers/3B.jpg',  100003, 'Fiction',   'C. Novelist'),
('Sample Book Four',  'A fourth made-up book.',                         2100, './BookCovers/4F.jpg',  './BookCovers/4B.jpg',  100004, 'Science',   'D. Scholar');
