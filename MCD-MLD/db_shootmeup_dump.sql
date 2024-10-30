-- MySQL dump 10.13  Distrib 8.0.30, for Linux (x86_64)
--
-- Host: localhost    Database: db_shootmeup
-- ------------------------------------------------------
-- Server version	8.0.30

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `t_avoir_ennemi`
--

DROP TABLE IF EXISTS `t_avoir_ennemi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `t_avoir_ennemi` (
  `niveau_id` int NOT NULL,
  `ennemi_id` int NOT NULL,
  PRIMARY KEY (`niveau_id`,`ennemi_id`),
  KEY `ennemi_id` (`ennemi_id`),
  CONSTRAINT `t_avoir_ennemi_ibfk_1` FOREIGN KEY (`niveau_id`) REFERENCES `t_niveau` (`niveau_id`),
  CONSTRAINT `t_avoir_ennemi_ibfk_2` FOREIGN KEY (`ennemi_id`) REFERENCES `t_ennemi` (`ennemi_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_avoir_ennemi`
--

LOCK TABLES `t_avoir_ennemi` WRITE;
/*!40000 ALTER TABLE `t_avoir_ennemi` DISABLE KEYS */;
INSERT INTO `t_avoir_ennemi` VALUES (1,1),(1,2),(2,3),(3,4);
/*!40000 ALTER TABLE `t_avoir_ennemi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_avoir_obstacles`
--

DROP TABLE IF EXISTS `t_avoir_obstacles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `t_avoir_obstacles` (
  `niveau_id` int NOT NULL,
  `obstacle_id` int NOT NULL,
  PRIMARY KEY (`niveau_id`,`obstacle_id`),
  KEY `obstacle_id` (`obstacle_id`),
  CONSTRAINT `t_avoir_obstacles_ibfk_1` FOREIGN KEY (`niveau_id`) REFERENCES `t_niveau` (`niveau_id`),
  CONSTRAINT `t_avoir_obstacles_ibfk_2` FOREIGN KEY (`obstacle_id`) REFERENCES `t_obstacle` (`obstacle_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_avoir_obstacles`
--

LOCK TABLES `t_avoir_obstacles` WRITE;
/*!40000 ALTER TABLE `t_avoir_obstacles` DISABLE KEYS */;
INSERT INTO `t_avoir_obstacles` VALUES (1,1),(3,1),(1,2),(2,3);
/*!40000 ALTER TABLE `t_avoir_obstacles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_ennemi`
--

DROP TABLE IF EXISTS `t_ennemi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `t_ennemi` (
  `ennemi_id` int NOT NULL AUTO_INCREMENT,
  `nbrVies` int DEFAULT NULL,
  `tir` tinyint(1) DEFAULT NULL,
  `sprite` blob,
  PRIMARY KEY (`ennemi_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_ennemi`
--

LOCK TABLES `t_ennemi` WRITE;
/*!40000 ALTER TABLE `t_ennemi` DISABLE KEYS */;
INSERT INTO `t_ennemi` VALUES (1,1,1,_binary 'alien_vert.png'),(2,2,1,_binary 'alien_bleu.png'),(3,1,0,_binary 'alien_rouge.png'),(4,3,1,_binary 'boss.png');
/*!40000 ALTER TABLE `t_ennemi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_highscores`
--

DROP TABLE IF EXISTS `t_highscores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `t_highscores` (
  `score_id` int NOT NULL AUTO_INCREMENT,
  `score` int DEFAULT NULL,
  `nom_joueur` varchar(50) DEFAULT NULL,
  `niveau_id` int NOT NULL,
  PRIMARY KEY (`score_id`),
  KEY `niveau_id` (`niveau_id`),
  CONSTRAINT `t_highscores_ibfk_1` FOREIGN KEY (`niveau_id`) REFERENCES `t_niveau` (`niveau_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_highscores`
--

LOCK TABLES `t_highscores` WRITE;
/*!40000 ALTER TABLE `t_highscores` DISABLE KEYS */;
INSERT INTO `t_highscores` VALUES (1,2500,'Joueur1',1),(2,3200,'Joueur2',2),(3,2800,'Joueur3',3);
/*!40000 ALTER TABLE `t_highscores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_joueur`
--

DROP TABLE IF EXISTS `t_joueur`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `t_joueur` (
  `joueur_id` int NOT NULL AUTO_INCREMENT,
  `nbrVies` int DEFAULT NULL,
  `sprite` blob,
  PRIMARY KEY (`joueur_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_joueur`
--

LOCK TABLES `t_joueur` WRITE;
/*!40000 ALTER TABLE `t_joueur` DISABLE KEYS */;
INSERT INTO `t_joueur` VALUES (1,3,_binary 'vaisseau_joueur_1.png'),(2,5,_binary 'vaisseau_joueur_2.png'),(3,4,_binary 'vaisseau_joueur_3.png');
/*!40000 ALTER TABLE `t_joueur` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_niveau`
--

DROP TABLE IF EXISTS `t_niveau`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `t_niveau` (
  `niveau_id` int NOT NULL AUTO_INCREMENT,
  `joueur_id` int NOT NULL,
  PRIMARY KEY (`niveau_id`),
  KEY `joueur_id` (`joueur_id`),
  CONSTRAINT `t_niveau_ibfk_1` FOREIGN KEY (`joueur_id`) REFERENCES `t_joueur` (`joueur_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_niveau`
--

LOCK TABLES `t_niveau` WRITE;
/*!40000 ALTER TABLE `t_niveau` DISABLE KEYS */;
INSERT INTO `t_niveau` VALUES (1,1),(2,2),(3,3);
/*!40000 ALTER TABLE `t_niveau` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_obstacle`
--

DROP TABLE IF EXISTS `t_obstacle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `t_obstacle` (
  `obstacle_id` int NOT NULL AUTO_INCREMENT,
  `hauteur` int DEFAULT NULL,
  `largeur` int DEFAULT NULL,
  `position_x` int DEFAULT NULL,
  `position_y` int DEFAULT NULL,
  `sprite` blob,
  PRIMARY KEY (`obstacle_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_obstacle`
--

LOCK TABLES `t_obstacle` WRITE;
/*!40000 ALTER TABLE `t_obstacle` DISABLE KEYS */;
INSERT INTO `t_obstacle` VALUES (1,20,100,50,400,_binary 'barriere_1.png'),(2,25,120,200,380,_binary 'barriere_2.png'),(3,15,90,350,390,_binary 'barriere_3.png');
/*!40000 ALTER TABLE `t_obstacle` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-10-30  7:33:01
