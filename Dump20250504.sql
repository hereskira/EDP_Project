CREATE DATABASE  IF NOT EXISTS `libsys` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `libsys`;
-- MySQL dump 10.13  Distrib 8.0.42, for Win64 (x86_64)
--
-- Host: localhost    Database: libsys
-- ------------------------------------------------------
-- Server version	8.0.42

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Temporary view structure for view `activeloans`
--

DROP TABLE IF EXISTS `activeloans`;
/*!50001 DROP VIEW IF EXISTS `activeloans`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `activeloans` AS SELECT 
 1 AS `loan_id`,
 1 AS `first_name`,
 1 AS `last_name`,
 1 AS `title`,
 1 AS `loan_date`,
 1 AS `due_date`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `archived_loans`
--

DROP TABLE IF EXISTS `archived_loans`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `archived_loans` (
  `loan_id` int NOT NULL,
  `member_id` int DEFAULT NULL,
  `book_id` int DEFAULT NULL,
  `employee_id` int DEFAULT NULL,
  `loan_date` date DEFAULT NULL,
  `due_date` date DEFAULT NULL,
  `is_paid` tinyint(1) DEFAULT NULL,
  `is_overdue` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`loan_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `archived_loans`
--

LOCK TABLES `archived_loans` WRITE;
/*!40000 ALTER TABLE `archived_loans` DISABLE KEYS */;
INSERT INTO `archived_loans` VALUES (20,1,3,4,'2024-03-17','2024-03-17',1,0);
/*!40000 ALTER TABLE `archived_loans` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `authors`
--

DROP TABLE IF EXISTS `authors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `authors` (
  `author_id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `biography` text,
  PRIMARY KEY (`author_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `authors`
--

LOCK TABLES `authors` WRITE;
/*!40000 ALTER TABLE `authors` DISABLE KEYS */;
INSERT INTO `authors` VALUES (1,'J.K. Rowling','British author, best known for the Harry Potter series.'),(2,'George Orwell','English novelist and essayist, journalist and critic.'),(3,'J.R.R. Tolkien','English writer, best known for The Lord of the Rings and The Hobbit.'),(4,'Stephen King','American author of horror, supernatural fiction, suspense, and fantasy novels.'),(5,'Agatha Christie','English writer known for her detective novels, particularly those featuring Hercule Poirot and Miss Marple.'),(6,'Isaac Asimov','Russian-born American author and professor of biochemistry, known for his works of science fiction.'),(7,'J.D. Salinger','American writer best known for his novel The Catcher in the Rye.'),(8,'Dan Brown','American author of thriller novels, best known for The Da Vinci Code.'),(9,'Terry Pratchett','English author known for his satirical fantasy novels, especially the Discworld series.'),(10,'George R.R. Martin','American novelist and short story writer, best known for the A Song of Ice and Fire series.'),(11,'Margaret Atwood','Canadian poet, novelist, and critic, best known for her works of speculative fiction.');
/*!40000 ALTER TABLE `authors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `availablebooks`
--

DROP TABLE IF EXISTS `availablebooks`;
/*!50001 DROP VIEW IF EXISTS `availablebooks`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `availablebooks` AS SELECT 
 1 AS `book_id`,
 1 AS `title`,
 1 AS `author`,
 1 AS `publisher`,
 1 AS `category`,
 1 AS `available_copies`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `availablebooks1`
--

DROP TABLE IF EXISTS `availablebooks1`;
/*!50001 DROP VIEW IF EXISTS `availablebooks1`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `availablebooks1` AS SELECT 
 1 AS `book_id`,
 1 AS `title`,
 1 AS `author`,
 1 AS `publisher`,
 1 AS `category`,
 1 AS `available_copies`,
 1 AS `availability_status`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `books`
--

DROP TABLE IF EXISTS `books`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `books` (
  `book_id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(100) NOT NULL,
  `author_id` int DEFAULT NULL,
  `publisher_id` int DEFAULT NULL,
  `category_id` int DEFAULT NULL,
  `publication_year` int DEFAULT NULL,
  `price` decimal(10,2) DEFAULT NULL,
  `available_copies` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`book_id`),
  KEY `author_id` (`author_id`),
  KEY `publisher_id` (`publisher_id`),
  KEY `category_id` (`category_id`),
  CONSTRAINT `books_ibfk_1` FOREIGN KEY (`author_id`) REFERENCES `authors` (`author_id`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `books_ibfk_2` FOREIGN KEY (`publisher_id`) REFERENCES `publishers` (`publisher_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `books_ibfk_3` FOREIGN KEY (`category_id`) REFERENCES `categories` (`category_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=50 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `books`
--

LOCK TABLES `books` WRITE;
/*!40000 ALTER TABLE `books` DISABLE KEYS */;
INSERT INTO `books` VALUES (1,'Harry Potter and the Sorcerer\'s Stone',1,1,3,1997,39.99,5),(2,'1984',2,2,1,1949,14.99,0),(3,'The Hobbit',3,3,3,1937,24.99,4),(4,'The Shining',4,4,5,1977,29.99,2),(5,'Murder on the Orient Express',5,5,1,1934,15.99,0),(6,'I, Robot',6,6,2,1950,18.99,0),(7,'The Catcher in the Rye',7,7,2,1951,13.99,3),(8,'The Da Vinci Code',8,8,1,2003,19.99,2),(9,'Guards! Guards!',9,9,3,1989,12.99,5),(10,'A Game of Thrones',10,10,1,1996,22.99,1),(11,'Animal Farm',2,11,11,1945,9.99,4),(12,'The Lord of the Rings',3,1,3,1954,25.99,8),(13,'Harry Potter and the Chamber of Secrets',1,1,3,1998,19.99,9),(14,'Harry Potter and the Prisoner of Azkaban',1,1,3,1999,19.99,0),(15,'Harry Potter and the Goblet of Fire',1,1,3,2000,22.99,4),(16,'Harry Potter and the Order of the Phoenix',1,1,3,2003,24.99,5),(17,'Harry Potter and the Half-Blood Prince',1,1,3,2005,22.99,0),(18,'Harry Potter and the Deathly Hallows',1,1,3,2007,24.99,1),(19,'It',4,12,8,1986,18.99,1),(20,'Carrie',4,12,8,1974,12.99,4),(21,'Misery',4,12,12,1987,14.99,5),(22,'Five Little Pigs',5,4,4,1942,14.49,2),(23,'And Then There Were None',5,4,4,1939,13.99,6),(24,'The Murder of Roger Ackroyd',5,4,4,1926,10.99,0),(25,'Death on the Nile',5,4,4,1937,12.99,3),(26,'The ABC Murders',5,4,4,1936,11.99,3),(27,'Foundation',6,13,2,1951,14.99,4),(28,'Foundation and Empire',6,13,2,1952,14.99,4),(29,'Second Foundation',6,13,2,1953,14.99,4),(30,'Pebble in the Sky',6,13,2,1950,14.99,5),(31,'The Gods Themselves',6,13,2,1972,16.99,5),(32,'Nine Stories',7,14,14,1953,11.99,2),(33,'Franny and Zooey',7,14,14,1961,10.99,5),(34,'Angels & Demons',8,15,5,2000,13.99,3),(35,'Inferno',8,15,5,2013,15.99,2),(36,'The Lost Symbol',8,15,5,2009,14.99,1),(37,'Origin',8,15,5,2017,16.99,5),(38,'The Colour of Magic',9,16,3,1983,12.99,4),(39,'Mort',9,16,3,1987,12.99,4),(40,'Reaper Man',9,16,3,1991,13.99,1),(41,'Good Omens',9,16,3,1990,14.99,9),(42,'A Clash of Kings',10,17,3,1998,18.99,3),(43,'A Storm of Swords',10,17,3,2000,19.99,5),(44,'A Feast for Crows',10,17,3,2005,17.99,2),(45,'A Dance with Dragons',10,17,3,2011,20.99,3),(46,'Wild Symphony',8,9,1,2020,11.07,3),(47,'Deception Point',8,7,5,2001,16.58,5),(48,'In One Sitting',8,7,1,2015,5.50,10);
/*!40000 ALTER TABLE `books` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `books_authors`
--

DROP TABLE IF EXISTS `books_authors`;
/*!50001 DROP VIEW IF EXISTS `books_authors`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `books_authors` AS SELECT 
 1 AS `name`,
 1 AS `title`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `books_categories`
--

DROP TABLE IF EXISTS `books_categories`;
/*!50001 DROP VIEW IF EXISTS `books_categories`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `books_categories` AS SELECT 
 1 AS `title`,
 1 AS `name`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categories` (
  `category_id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `description` text,
  PRIMARY KEY (`category_id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` VALUES (1,'Fiction','Novels and short stories'),(2,'Science Fiction','Fiction based on scientific concepts'),(3,'Fantasy','Stories set in magical worlds'),(4,'Mystery','Genre of fiction focused on solving a crime or puzzle.'),(5,'Thriller','Fiction characterized by suspense and excitement.'),(6,'Historical Fiction','Fiction set in a specific historical time period.'),(7,'Non-Fiction','Factual and informative books.'),(8,'Horror','Fiction intended to evoke fear or dread.'),(9,'Young Adult','Books aimed at a teenage audience, often featuring coming-of-age themes.'),(10,'Adventure','Stories that focus on excitement, challenges, and exploration.'),(11,'Political Satire','Fiction that critiques politics and society through humor and irony.'),(12,'Psychological Thriller','Thrillers that explore the psychological states of characters.'),(13,'Post-Apocalyptic','Stories set in a world after a major catastrophe.'),(14,'Literary Fiction','Fiction focused on deep themes and character-driven narratives.');
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employees` (
  `employee_id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `role` varchar(50) NOT NULL,
  `hire_date` date DEFAULT NULL,
  PRIMARY KEY (`employee_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
INSERT INTO `employees` VALUES (1,'John','Doe','Software Developer','2020-01-15'),(2,'Jane','Smith','Project Manager','2019-03-22'),(3,'Alice','Johnson','HR Manager','2018-07-10'),(4,'Bob','Williams','Accountant','2021-04-05'),(5,'Charlie','Brown','Designer','2022-06-18'),(6,'David','Wilson','Marketing Specialist','2017-09-30'),(7,'Eve','Davis','Sales Manager','2020-02-25'),(8,'Frank','Moore','Customer Support','2021-08-12'),(9,'Grace','Taylor','Business Analyst','2019-11-14'),(10,'Hank','Anderson','Product Owner','2020-05-03');
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `loanhistory`
--

DROP TABLE IF EXISTS `loanhistory`;
/*!50001 DROP VIEW IF EXISTS `loanhistory`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `loanhistory` AS SELECT 
 1 AS `book_title`,
 1 AS `member_first_name`,
 1 AS `member_last_name`,
 1 AS `loan_date`,
 1 AS `due_date`,
 1 AS `is_paid`,
 1 AS `is_overdue`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `loans`
--

DROP TABLE IF EXISTS `loans`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `loans` (
  `loan_id` int NOT NULL AUTO_INCREMENT,
  `member_id` int NOT NULL,
  `book_id` int NOT NULL,
  `employee_id` int NOT NULL,
  `loan_date` date NOT NULL,
  `due_date` date NOT NULL,
  `is_paid` tinyint(1) DEFAULT '0',
  `is_overdue` tinyint DEFAULT '0',
  PRIMARY KEY (`loan_id`),
  KEY `member_id` (`member_id`),
  KEY `book_id` (`book_id`),
  KEY `employee_id` (`employee_id`),
  CONSTRAINT `loans_ibfk_1` FOREIGN KEY (`member_id`) REFERENCES `members` (`member_id`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `loans_ibfk_2` FOREIGN KEY (`book_id`) REFERENCES `books` (`book_id`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `loans_ibfk_3` FOREIGN KEY (`employee_id`) REFERENCES `employees` (`employee_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `loans`
--

LOCK TABLES `loans` WRITE;
/*!40000 ALTER TABLE `loans` DISABLE KEYS */;
INSERT INTO `loans` VALUES (1,1,3,2,'2025-01-10','2025-01-24',0,1),(2,2,5,1,'2025-01-12','2025-01-26',0,1),(3,3,7,3,'2025-01-15','2025-01-29',1,0),(4,4,2,4,'2025-01-18','2025-02-01',0,1),(5,5,9,2,'2025-01-20','2025-02-20',1,0),(6,6,1,5,'2025-01-22','2025-03-05',0,1),(7,7,8,1,'2025-01-25','2025-02-08',0,1),(8,8,4,3,'2025-01-27','2025-02-10',1,0),(9,9,6,4,'2025-01-28','2025-02-11',1,0),(10,10,10,5,'2025-01-30','2025-02-13',1,0),(11,1,20,9,'2025-02-14','2025-02-19',0,1),(12,1,29,8,'2025-02-16','2025-04-12',0,1),(13,1,1,4,'2025-02-03','2025-03-07',0,1),(14,3,21,4,'2025-01-01','2025-02-19',0,1),(15,1,14,4,'2025-02-15','2025-02-17',0,1),(16,1,1,4,'2025-03-17','2025-03-20',0,1),(17,1,5,4,'2025-03-17','2025-03-20',0,1),(18,1,1,4,'2025-03-17','2025-03-20',0,1),(19,1,1,4,'2025-03-17','2025-04-02',0,1);
/*!40000 ALTER TABLE `loans` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `check_available_copies` BEFORE INSERT ON `loans` FOR EACH ROW BEGIN
  DECLARE copies_available INT;

  -- Get the current available copies of the book
  SELECT available_copies INTO copies_available 
  FROM Books 
  WHERE book_id = NEW.book_id;

  -- Prevent insertion if no copies are available
  IF copies_available IS NULL OR copies_available <= 0 THEN
    SIGNAL SQLSTATE '45000'
    SET MESSAGE_TEXT = 'No available copies for this book';
  END IF;

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `decrease_available_copies` AFTER INSERT ON `loans` FOR EACH ROW BEGIN
  DECLARE current_copies INT;

  -- Get the current available copies
  SELECT available_copies INTO current_copies 
  FROM books 
  WHERE book_id = NEW.book_id;

  -- Deduct only if there are available copies
  IF current_copies > 0 THEN
    UPDATE books
    SET available_copies = current_copies - 1
    WHERE book_id = NEW.book_id;
  END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `prevent_invalid_update` BEFORE UPDATE ON `loans` FOR EACH ROW BEGIN
  -- Prevent update if changing to a book with no available copies
  IF OLD.book_id != NEW.book_id AND 
     (SELECT available_copies FROM books WHERE book_id = NEW.book_id) <= 0 THEN
    SIGNAL SQLSTATE '45000'
    SET MESSAGE_TEXT = 'No available copies for the new book';
  END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `update_available_copies_after_loan_update` AFTER UPDATE ON `loans` FOR EACH ROW BEGIN
  -- Only update if the book_id changes
  IF OLD.book_id != NEW.book_id THEN
    -- Return old book copy
    UPDATE books
    SET available_copies = available_copies + 1
    WHERE book_id = OLD.book_id;

    -- Deduct from new book
    UPDATE books
    SET available_copies = available_copies - 1
    WHERE book_id = NEW.book_id;
  END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `prevent_loan_deletion_if_unpaid` BEFORE DELETE ON `loans` FOR EACH ROW BEGIN
  -- Prevent deletion if the loan is unpaid
  IF OLD.is_paid = 0 THEN
    SIGNAL SQLSTATE '45000'
    SET MESSAGE_TEXT = 'Cannot delete an unpaid loan';
  END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `increase_available_copies` AFTER DELETE ON `loans` FOR EACH ROW BEGIN
  UPDATE books
  SET available_copies = available_copies + 1
  WHERE book_id = OLD.book_id;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `members`
--

DROP TABLE IF EXISTS `members`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `members` (
  `member_id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `date_of_birth` date DEFAULT NULL,
  `email` varchar(100) NOT NULL,
  PRIMARY KEY (`member_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `members`
--

LOCK TABLES `members` WRITE;
/*!40000 ALTER TABLE `members` DISABLE KEYS */;
INSERT INTO `members` VALUES (1,'Shakira','Regalado','1990-01-01','shakiraregalado@gmail.com'),(2,'Jethro','Manzanillo','1991-02-02','jethromanzanillo@gmail.com'),(3,'Danielle','Rubis','1992-03-03','daniellerubis@gmail.com'),(4,'Juliane','Dayandante','1993-04-04','julianedayandante@gmail.com'),(5,'Robert','Rodejo','1994-05-05','robertrodejo@gmail.com'),(6,'Archie','Onoya','1995-06-06','archieonoya@gmail.com'),(7,'Ian','Villame','1996-07-07','ianvillame@gmail.com'),(8,'Vicente','Bercasio','1997-08-08','vicentebercasio@gmail.com'),(9,'Dave','Banas','1998-09-09','davebanas@gmail.com'),(10,'Adornado','Cabalbag','1999-10-10','adornadocabalbag@gmail.com');
/*!40000 ALTER TABLE `members` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `publishers`
--

DROP TABLE IF EXISTS `publishers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `publishers` (
  `publisher_id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `address` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`publisher_id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `publishers`
--

LOCK TABLES `publishers` WRITE;
/*!40000 ALTER TABLE `publishers` DISABLE KEYS */;
INSERT INTO `publishers` VALUES (1,'Bloomsbury','London, UK'),(2,'Penguin Books','New York, USA'),(3,'Houghton Mifflin Harcourt','Boston, USA'),(4,'HarperCollins','New York, USA'),(5,'Macmillan','London, UK'),(6,'Random House','New York, USA'),(7,'Simon & Schuster','New York, USA'),(8,'Tor Books','New York, USA'),(9,'Penguin Random House','New York, USA'),(10,'Delacorte Press','New York, USA'),(11,'Secker & Warburg','London, UK'),(12,'Doubleday','New York, USA'),(13,'Gnome Press','New York, USA'),(14,'Little, Brown and Company','New York, USA'),(15,'Bantam Books','New York, USA'),(16,'Corgi Books','London, UK'),(17,'Voyager Books','London, UK');
/*!40000 ALTER TABLE `publishers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `security_questions`
--

DROP TABLE IF EXISTS `security_questions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `security_questions` (
  `question_id` int NOT NULL AUTO_INCREMENT,
  `question_text` varchar(255) NOT NULL,
  PRIMARY KEY (`question_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `security_questions`
--

LOCK TABLES `security_questions` WRITE;
/*!40000 ALTER TABLE `security_questions` DISABLE KEYS */;
INSERT INTO `security_questions` VALUES (1,'What was your first pet\'s name?'),(2,'What is your favorite book from childhood?'),(3,'What is your favorite movie?'),(4,'What is your favorite food?'),(5,'What is your favorite color?');
/*!40000 ALTER TABLE `security_questions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(100) NOT NULL,
  `full_name` varchar(100) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `last_login` datetime DEFAULT NULL,
  `security_question` int DEFAULT NULL,
  `security_answer` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `username` (`username`),
  KEY `security_question` (`security_question`),
  CONSTRAINT `users_ibfk_1` FOREIGN KEY (`security_question`) REFERENCES `security_questions` (`question_id`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'admin','password','Shakira Regalado','shakiraregalado@gmail.com',NULL,1,'Fluffy'),(7,'kira','pass','Shakira','shakira@gmail.com',NULL,5,'Pink');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'libsys'
--
/*!50106 SET @save_time_zone= @@TIME_ZONE */ ;
/*!50106 DROP EVENT IF EXISTS `archive_old_loans` */;
DELIMITER ;;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;;
/*!50003 SET character_set_client  = utf8mb4 */ ;;
/*!50003 SET character_set_results = utf8mb4 */ ;;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;;
/*!50003 SET @saved_time_zone      = @@time_zone */ ;;
/*!50003 SET time_zone             = 'SYSTEM' */ ;;
/*!50106 CREATE*/ /*!50117 DEFINER=`root`@`localhost`*/ /*!50106 EVENT `archive_old_loans` ON SCHEDULE AT '2025-04-03 11:04:23' ON COMPLETION PRESERVE DISABLE DO BEGIN
  -- Move old paid loans (older than 1 year) to the archive table
  INSERT INTO archived_loans (loan_id, member_id, book_id, employee_id, loan_date, due_date, is_paid, is_overdue)
  SELECT loan_id, member_id, book_id, employee_id, loan_date, due_date, is_paid, is_overdue
  FROM loans
  WHERE loan_date < NOW() - INTERVAL 1 YEAR AND is_paid = 1;

  -- Delete archived loans from the original table
  DELETE FROM loans
  WHERE loan_date < NOW() - INTERVAL 1 YEAR AND is_paid = 1;
END */ ;;
/*!50003 SET time_zone             = @saved_time_zone */ ;;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;;
/*!50003 SET character_set_client  = @saved_cs_client */ ;;
/*!50003 SET character_set_results = @saved_cs_results */ ;;
/*!50003 SET collation_connection  = @saved_col_connection */ ;;
/*!50106 DROP EVENT IF EXISTS `backup_database` */;;
DELIMITER ;;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;;
/*!50003 SET character_set_client  = utf8mb4 */ ;;
/*!50003 SET character_set_results = utf8mb4 */ ;;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;;
/*!50003 SET @saved_time_zone      = @@time_zone */ ;;
/*!50003 SET time_zone             = 'SYSTEM' */ ;;
/*!50106 CREATE*/ /*!50117 DEFINER=`root`@`localhost`*/ /*!50106 EVENT `backup_database` ON SCHEDULE AT '2025-04-03 10:08:27' ON COMPLETION PRESERVE DISABLE DO BEGIN
  -- Runs a system command to back up the database
  SET @cmd = 'mysqldump -u root -pmysqlkira libsys > /Users/shakiraregalado/dumps/libsys_backup.sql';
  DO sys_exec(@cmd);
END */ ;;
/*!50003 SET time_zone             = @saved_time_zone */ ;;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;;
/*!50003 SET character_set_client  = @saved_cs_client */ ;;
/*!50003 SET character_set_results = @saved_cs_results */ ;;
/*!50003 SET collation_connection  = @saved_col_connection */ ;;
/*!50106 DROP EVENT IF EXISTS `mark_overdue_loans` */;;
DELIMITER ;;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;;
/*!50003 SET character_set_client  = utf8mb4 */ ;;
/*!50003 SET character_set_results = utf8mb4 */ ;;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;;
/*!50003 SET @saved_time_zone      = @@time_zone */ ;;
/*!50003 SET time_zone             = 'SYSTEM' */ ;;
/*!50106 CREATE*/ /*!50117 DEFINER=`root`@`localhost`*/ /*!50106 EVENT `mark_overdue_loans` ON SCHEDULE EVERY 1 DAY STARTS '2025-04-03 11:05:37' ON COMPLETION PRESERVE ENABLE DO BEGIN
  UPDATE loans
  SET is_overdue = 1
  WHERE due_date < NOW() AND is_paid = 0;
END */ ;;
/*!50003 SET time_zone             = @saved_time_zone */ ;;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;;
/*!50003 SET character_set_client  = @saved_cs_client */ ;;
/*!50003 SET character_set_results = @saved_cs_results */ ;;
/*!50003 SET collation_connection  = @saved_col_connection */ ;;
DELIMITER ;
/*!50106 SET TIME_ZONE= @save_time_zone */ ;

--
-- Dumping routines for database 'libsys'
--
/*!50003 DROP FUNCTION IF EXISTS `checkAvailability` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `checkAvailability`(copies INT) RETURNS varchar(20) CHARSET utf8mb4
    DETERMINISTIC
BEGIN

RETURN IF(copies > 5, 'Available', 'Limited Stock');
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `fullname` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `fullname`(fname VARCHAR(45), lname VARCHAR(45)) RETURNS varchar(90) CHARSET utf8mb4
    DETERMINISTIC
BEGIN

RETURN CONCAT(fname, ' ', lname);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `GetMemberFullName` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `GetMemberFullName`(memberID INT) RETURNS varchar(100) CHARSET utf8mb4
    DETERMINISTIC
BEGIN
	DECLARE full_name VARCHAR(100); 
    
    SELECT CONCAT(first_name, ' ', last_name) INTO full_name 
    FROM Members 
    WHERE member_id = memberID;
RETURN full_name;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `GetTotalBooksLoaned` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `GetTotalBooksLoaned`(memberID INT) RETURNS int
    DETERMINISTIC
BEGIN
	DECLARE total_loans INT;
    
    SELECT COUNT(loan_id) INTO total_loans
    FROM Loans
    WHERE member_id = memberID;
RETURN total_loans;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `increaseBookPrice` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `increaseBookPrice`(currentPrice DECIMAL(10, 2), percentage DOUBLE) RETURNS double
    DETERMINISTIC
BEGIN
	DECLARE newPrice DOUBLE;
    SET newPrice = currentPrice * (1 + percentage / 100);
RETURN newPrice;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetMembersWithOverdueBooks` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetMembersWithOverdueBooks`()
BEGIN
    DECLARE done INT DEFAULT 0;
    DECLARE member_id INT;
    DECLARE first_name VARCHAR(100);
    DECLARE last_name VARCHAR(100);
    DECLARE book_title VARCHAR(255);
    DECLARE due_date DATE;

    -- Declare the cursor to select members with overdue books
    DECLARE cur CURSOR FOR 
        SELECT m.member_id, m.first_name, m.last_name, b.title, l.due_date
        FROM Loans l
        JOIN Members m ON l.member_id = m.member_id
        JOIN Books b ON l.book_id = b.book_id
        WHERE l.is_paid = 0 AND l.due_date < CURDATE(); -- Only unpaid and overdue loans
    
    -- Declare a handler for when no more records are found
    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;
    
    -- Create a temporary table to store the results
    CREATE TEMPORARY TABLE IF NOT EXISTS temp_overdue_books (
        member_id INT,
        first_name VARCHAR(100),
        last_name VARCHAR(100),
        book_title VARCHAR(255),
        due_date DATE
    );
    
    OPEN cur;
    
    read_loop: LOOP
        FETCH cur INTO member_id, first_name, last_name, book_title, due_date;
        
        -- Exit loop if no more records
        IF done THEN
            LEAVE read_loop;
        END IF;
        
        -- Insert the result into the temporary table
        INSERT INTO temp_overdue_books (member_id, first_name, last_name, book_title, due_date)
        VALUES (member_id, first_name, last_name, book_title, due_date);
    END LOOP;
    
    CLOSE cur;
    
    -- Now select all the results from the temporary table
    SELECT * FROM temp_overdue_books;
    
    -- Drop the temporary table after use
    DROP TEMPORARY TABLE IF EXISTS temp_overdue_books;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetTotalBooksLoanedByMembers` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetTotalBooksLoanedByMembers`()
BEGIN
    DECLARE done INT DEFAULT 0;
    DECLARE v_member_id INT;
    DECLARE v_member_name VARCHAR(100);
    DECLARE v_books_loaned INT;
    
    DECLARE member_cursor CURSOR FOR
        SELECT member_id FROM Members;
    
    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;

    -- Ensure the temporary table is deleted before recreating
    DROP TEMPORARY TABLE IF EXISTS member_loans;

    -- Create the temporary table
    CREATE TEMPORARY TABLE member_loans (
        member_name VARCHAR(100),
        total_loaned_books INT
    );

    OPEN member_cursor;

    read_loop: LOOP
        FETCH member_cursor INTO v_member_id;
        IF done THEN
            LEAVE read_loop;
        END IF;
        
        -- Use the stored functions
        SET v_member_name = GetMemberFullName(v_member_id);
        SET v_books_loaned = GetTotalBooksLoaned(v_member_id);
        
        -- Insert result into the temporary table
        INSERT INTO member_loans (member_name, total_loaned_books)
        VALUES (v_member_name, v_books_loaned);
    END LOOP;

    CLOSE member_cursor;

    -- Output all results
    SELECT * FROM member_loans;

    -- Optional: Drop the temporary table after outputting results
    DROP TEMPORARY TABLE IF EXISTS member_loans;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `MarkOverdueLoans` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `MarkOverdueLoans`()
BEGIN
    -- Update the Loans table to mark as overdue only if the due date has passed and the loan is unpaid
    UPDATE Loans
    SET is_overdue = 1
    WHERE is_paid = 0
      AND due_date < CURDATE()  -- Check if the due date has passed
      AND is_overdue = 0;  -- Only mark it as overdue if it's not already marked
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `UpdateBookAvailability` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateBookAvailability`(IN p_book_id INT, IN new_available_copies INT)
BEGIN
    UPDATE Books
    SET available_copies = new_available_copies
    WHERE book_id = p_book_id;  -- Use the procedure parameter
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `activeloans`
--

/*!50001 DROP VIEW IF EXISTS `activeloans`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `activeloans` AS select `l`.`loan_id` AS `loan_id`,`m`.`first_name` AS `first_name`,`m`.`last_name` AS `last_name`,`b`.`title` AS `title`,`l`.`loan_date` AS `loan_date`,`l`.`due_date` AS `due_date` from ((`loans` `l` join `members` `m` on((`l`.`member_id` = `m`.`member_id`))) join `books` `b` on((`l`.`book_id` = `b`.`book_id`))) where (`l`.`is_paid` = 0) */
/*!50002 WITH CASCADED CHECK OPTION */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `availablebooks`
--

/*!50001 DROP VIEW IF EXISTS `availablebooks`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `availablebooks` AS select `b`.`book_id` AS `book_id`,`b`.`title` AS `title`,`a`.`name` AS `author`,`p`.`name` AS `publisher`,`c`.`name` AS `category`,`b`.`available_copies` AS `available_copies` from (((`books` `b` join `authors` `a` on((`b`.`author_id` = `a`.`author_id`))) join `publishers` `p` on((`b`.`publisher_id` = `p`.`publisher_id`))) join `categories` `c` on((`b`.`category_id` = `c`.`category_id`))) where (`b`.`available_copies` > 0) */
/*!50002 WITH CASCADED CHECK OPTION */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `availablebooks1`
--

/*!50001 DROP VIEW IF EXISTS `availablebooks1`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `availablebooks1` AS select `b`.`book_id` AS `book_id`,`b`.`title` AS `title`,`a`.`name` AS `author`,`p`.`name` AS `publisher`,`c`.`name` AS `category`,`b`.`available_copies` AS `available_copies`,`checkAvailability`(`b`.`available_copies`) AS `availability_status` from (((`books` `b` join `authors` `a` on((`b`.`author_id` = `a`.`author_id`))) join `publishers` `p` on((`b`.`publisher_id` = `p`.`publisher_id`))) join `categories` `c` on((`b`.`category_id` = `c`.`category_id`))) where (`b`.`available_copies` > 0) */
/*!50002 WITH CASCADED CHECK OPTION */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `books_authors`
--

/*!50001 DROP VIEW IF EXISTS `books_authors`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `books_authors` AS select `authors`.`name` AS `name`,`books`.`title` AS `title` from (`authors` join `books`) where (`authors`.`author_id` = `books`.`author_id`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `books_categories`
--

/*!50001 DROP VIEW IF EXISTS `books_categories`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `books_categories` AS select `books`.`title` AS `title`,`categories`.`name` AS `name` from (`books` join `categories`) where (`books`.`category_id` = `categories`.`category_id`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `loanhistory`
--

/*!50001 DROP VIEW IF EXISTS `loanhistory`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `loanhistory` AS select `b`.`title` AS `book_title`,`m`.`first_name` AS `member_first_name`,`m`.`last_name` AS `member_last_name`,`l`.`loan_date` AS `loan_date`,`l`.`due_date` AS `due_date`,`l`.`is_paid` AS `is_paid`,`l`.`is_overdue` AS `is_overdue` from ((`loans` `l` join `books` `b` on((`l`.`book_id` = `b`.`book_id`))) join `members` `m` on((`l`.`member_id` = `m`.`member_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-05-04 14:44:56
