-- MariaDB dump 10.17  Distrib 10.4.14-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: Drwal_Projekt
-- ------------------------------------------------------
-- Server version	10.4.14-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
--
-- Database: Drwal_Projekt
--
CREATE DATABASE IF NOT EXISTS Drwal_Projekt DEFAULT CHARACTER SET latin1 COLLATE latin1_german1_ci;
USE Drwal_Projekt;

-- --------------------------------------------------------
--
-- Table structure for table `kunde`
--



DROP TABLE IF EXISTS `kunde`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kunde` (
  `k_MitarbeiterID` int(11) NOT NULL,
  `k_RechnungsID` int(11) NOT NULL,
  `k_ProduktID` int(11) NOT NULL,
  KEY `fk_kunde_produkt` (`k_ProduktID`),
  KEY `fk_kunde_mitarbeiter` (`k_MitarbeiterID`),
  KEY `fk_kunde_rechnung` (`k_RechnungsID`),
  CONSTRAINT `fk_kunde_mitarbeiter` FOREIGN KEY (`k_MitarbeiterID`) REFERENCES `mitarbeiter` (`MitarbeiterID`),
  CONSTRAINT `fk_kunde_produkt` FOREIGN KEY (`k_ProduktID`) REFERENCES `produkt` (`ProduktID`),
  CONSTRAINT `fk_kunde_rechnung` FOREIGN KEY (`k_RechnungsID`) REFERENCES `rechnung` (`RechnungsID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kunde`
--

LOCK TABLES `kunde` WRITE;
/*!40000 ALTER TABLE `kunde` DISABLE KEYS */;
INSERT INTO `kunde` VALUES (1,0,3),(1,1,4),(0,2,1),(0,3,2);
/*!40000 ALTER TABLE `kunde` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mitarbeiter`
--

DROP TABLE IF EXISTS `mitarbeiter`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mitarbeiter` (
  `MitarbeiterID` int(11) NOT NULL,
  `Vorname` char(20) NOT NULL,
  `Nachname` char(20) NOT NULL,
  PRIMARY KEY (`MitarbeiterID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mitarbeiter`
--

LOCK TABLES `mitarbeiter` WRITE;
/*!40000 ALTER TABLE `mitarbeiter` DISABLE KEYS */;
INSERT INTO `mitarbeiter` VALUES (0,'Thomas','Langbauer'),(1,'Ludwig','Gilbert');
/*!40000 ALTER TABLE `mitarbeiter` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produkt`
--

DROP TABLE IF EXISTS `produkt`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produkt` (
  `ProduktID` int(11) NOT NULL,
  `Preis` decimal(10,0) NOT NULL,
  `Produktart` char(30) NOT NULL,
  `Produktname` char(30) NOT NULL,
  PRIMARY KEY (`ProduktID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produkt`
--

LOCK TABLES `produkt` WRITE;
/*!40000 ALTER TABLE `produkt` DISABLE KEYS */;
INSERT INTO `produkt` VALUES (0,25,'Hauptspeise','Chicken Nuggets'),(1,20,'Hauptspeise','Käseleberkäse Krapfen'),(2,5,'Hauptspeise','Fried Chicken'),(3,3,'Dessert','Tiramisu'),(4,8,'Dessert','Ice Cream'),(5,6,'Dessert','Kaiserschmarren'),(6,2,'Kaltgetränk','Eistee'),(7,21,'Alk','Wein'),(8,65,'Warmgetränk','Choccy Milk');
/*!40000 ALTER TABLE `produkt` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rechnung`
--

DROP TABLE IF EXISTS `rechnung`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rechnung` (
  `RechnungsID` int(11) NOT NULL AUTO_INCREMENT,
  `Zahlungsart` char(20) NOT NULL,
  `Total` int(20) NOT NULL,
  PRIMARY KEY (`RechnungsID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rechnung`
--

LOCK TABLES `rechnung` WRITE;
/*!40000 ALTER TABLE `rechnung` DISABLE KEYS */;
INSERT INTO `rechnung` VALUES (1,'Karte',15),(2,'Karte',15),(3,'Bar',12),(4,'Bar',15);
/*!40000 ALTER TABLE `rechnung` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-06-20 18:34:03
