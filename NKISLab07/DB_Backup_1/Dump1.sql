CREATE DATABASE  IF NOT EXISTS `dev1` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `dev1`;
-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: dev
-- ------------------------------------------------------
-- Server version	8.0.32

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
-- Table structure for table `clients`
--

DROP TABLE IF EXISTS `clients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clients` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `Client` varchar(80) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Credit` int NOT NULL,
  `Tel` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_esperanto_ci NOT NULL,
  `Money` int NOT NULL,
  `Dolg` int NOT NULL,
  `Comments` varchar(80) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `Client_UNIQUE` (`Client`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clients`
--

LOCK TABLES `clients` WRITE;
/*!40000 ALTER TABLE `clients` DISABLE KEYS */;
INSERT INTO `clients` VALUES (1,'Иванов',10,'+7(495)123-4567',0,490,'Постоянно в долгу'),(2,'Петров',50,'+1(612)654-2345',0,4950,'Хороший клиент'),(3,'Сидоров',1000,'+7(812)567-2378',795,0,'Нормальный клиент');
/*!40000 ALTER TABLE `clients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `clients_info`
--

DROP TABLE IF EXISTS `clients_info`;
/*!50001 DROP VIEW IF EXISTS `clients_info`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `clients_info` AS SELECT 
 1 AS `Клиент`,
 1 AS `Телефон`,
 1 AS `Заказов на`,
 1 AS `На Счету`,
 1 AS `Ост. кредита`,
 1 AS `Долг`,
 1 AS `Весь кредит`,
 1 AS `Комментарий`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `goods`
--

DROP TABLE IF EXISTS `goods`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `goods` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `Good` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Price` int NOT NULL,
  `QTYinStore` int NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `Good_UNIQUE` (`Good`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `goods`
--

LOCK TABLES `goods` WRITE;
/*!40000 ALTER TABLE `goods` DISABLE KEYS */;
INSERT INTO `goods` VALUES (1,'Карандаш',5,1022),(2,'Ручка',10,1033),(3,'Блокнот',50,1000),(4,'Тетрадь',10,1100);
/*!40000 ALTER TABLE `goods` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `goods_qty`
--

DROP TABLE IF EXISTS `goods_qty`;
/*!50001 DROP VIEW IF EXISTS `goods_qty`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `goods_qty` AS SELECT 
 1 AS `Good`,
 1 AS `ngoods`,
 1 AS `id`,
 1 AS `price`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `items`
--

DROP TABLE IF EXISTS `items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `items` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `orderID` int unsigned NOT NULL,
  `goodID` int unsigned NOT NULL,
  `qty` int NOT NULL,
  `vidProdazi` int NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `ItemID_UNIQUE` (`id`),
  KEY `itemsord_idx` (`orderID`),
  KEY `itemgood_idx` (`goodID`),
  CONSTRAINT `itemsgood` FOREIGN KEY (`goodID`) REFERENCES `goods` (`id`),
  CONSTRAINT `itemsord` FOREIGN KEY (`orderID`) REFERENCES `orders` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=147 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `items`
--

LOCK TABLES `items` WRITE;
/*!40000 ALTER TABLE `items` DISABLE KEYS */;
INSERT INTO `items` VALUES (104,230,3,4,1),(105,231,1,3,1),(106,232,2,2,1),(107,233,3,-3,5),(108,236,4,5,2),(109,236,2,8,2),(111,237,3,10,3),(112,238,3,-10,5),(113,245,3,6,1),(114,246,2,5,2),(115,247,3,10,3),(117,247,2,10,3),(120,249,4,7,3),(121,249,2,8,3),(126,254,3,9,3),(127,254,3,1,3),(128,256,4,1,3),(129,263,1,10,2),(130,263,1,1,2),(131,269,3,10,3),(133,269,4,2,3),(139,272,3,100,3),(140,272,3,18,3),(141,274,1,6,1),(142,274,3,7,1),(143,277,3,-7,5),(144,278,2,3,4),(145,278,1,-6,4);
/*!40000 ALTER TABLE `items` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `items_cost`
--

DROP TABLE IF EXISTS `items_cost`;
/*!50001 DROP VIEW IF EXISTS `items_cost`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `items_cost` AS SELECT 
 1 AS `orderID`,
 1 AS `Всего в заказе`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `items_gqty`
--

DROP TABLE IF EXISTS `items_gqty`;
/*!50001 DROP VIEW IF EXISTS `items_gqty`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `items_gqty` AS SELECT 
 1 AS `goodID`,
 1 AS `smg`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `clientID` int unsigned NOT NULL,
  PRIMARY KEY (`id`),
  KEY `ord_client_idx` (`clientID`),
  CONSTRAINT `ord_client` FOREIGN KEY (`clientID`) REFERENCES `clients` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=280 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (229,1),(230,1),(231,1),(232,1),(233,1),(234,1),(236,1),(237,1),(238,1),(239,1),(254,1),(255,1),(256,1),(257,1),(258,1),(240,2),(241,2),(242,2),(243,2),(244,2),(245,2),(246,2),(264,2),(269,2),(272,2),(247,3),(249,3),(253,3),(259,3),(260,3),(261,3),(262,3),(263,3),(274,3),(275,3),(277,3),(278,3);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `sales_info`
--

DROP TABLE IF EXISTS `sales_info`;
/*!50001 DROP VIEW IF EXISTS `sales_info`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `sales_info` AS SELECT 
 1 AS `Клиент`,
 1 AS `Заказ`,
 1 AS `Элемент`,
 1 AS `Товар`,
 1 AS `Цена`,
 1 AS `Количество`,
 1 AS `Стоимость`,
 1 AS `Вид продажи`,
 1 AS `Всего в заказе`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `sales_infocl`
--

DROP TABLE IF EXISTS `sales_infocl`;
/*!50001 DROP VIEW IF EXISTS `sales_infocl`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `sales_infocl` AS SELECT 
 1 AS `Клиент`,
 1 AS `sm`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `user` varchar(8) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `F` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `I` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `O` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Position` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `WorkPh` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `HomeAdr` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `HomePh` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `Gr` varchar(1) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Password` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`user`),
  UNIQUE KEY `user_UNIQUE` (`user`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES ('a1','Антонов','Петр','Сергеевич','Директор','201-2','Снежная, 22','495-301','1','aa11'),('i3','Иванова','Анна','Петровна','Секретарь','203-205','Северная,1','','3','ii33'),('i33','Иванова','Анна','Петровна','Секретарь','203-204','Северная,1','','3','ii33'),('p2','Петров','Иван','Петрович','Аналитик','202','Горная, 3','985-322','2','pp22'),('s4','Сидоров','Андрей','Иванович','Сотрудник','210','Новая, 144','988-765','4','ss44');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `clients_info`
--

/*!50001 DROP VIEW IF EXISTS `clients_info`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`dev`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `clients_info` AS select `clients`.`Client` AS `Клиент`,`clients`.`Tel` AS `Телефон`,ifnull(`sales_infocl`.`sm`,0) AS `Заказов на`,`clients`.`Money` AS `На Счету`,`clients`.`Credit` AS `Ост. кредита`,`clients`.`Dolg` AS `Долг`,(`clients`.`Credit` + `clients`.`Dolg`) AS `Весь кредит`,`clients`.`Comments` AS `Комментарий` from (`clients` left join `sales_infocl` on((`sales_infocl`.`Клиент` = `clients`.`Client`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `goods_qty`
--

/*!50001 DROP VIEW IF EXISTS `goods_qty`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`dev`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `goods_qty` AS select `goods`.`Good` AS `Good`,(`goods`.`QTYinStore` - ifnull(`items_gqty`.`smg`,0)) AS `ngoods`,`goods`.`id` AS `id`,`goods`.`Price` AS `price` from (`goods` left join `items_gqty` on((`goods`.`id` = `items_gqty`.`goodID`))) order by `goods`.`Good` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `items_cost`
--

/*!50001 DROP VIEW IF EXISTS `items_cost`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`dev`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `items_cost` AS select `i`.`orderID` AS `orderID`,sum((`i`.`qty` * `g`.`Price`)) AS `Всего в заказе` from (`items` `i` join `goods` `g`) where (`i`.`goodID` = `g`.`id`) group by `i`.`orderID` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `items_gqty`
--

/*!50001 DROP VIEW IF EXISTS `items_gqty`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`dev`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `items_gqty` AS select `items`.`goodID` AS `goodID`,sum(`items`.`qty`) AS `smg` from `items` group by `items`.`goodID` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `sales_info`
--

/*!50001 DROP VIEW IF EXISTS `sales_info`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`dev`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `sales_info` AS select `clients`.`Client` AS `Клиент`,`orders`.`id` AS `Заказ`,`items`.`id` AS `Элемент`,`goods`.`Good` AS `Товар`,`goods`.`Price` AS `Цена`,`items`.`qty` AS `Количество`,(`items`.`qty` * `goods`.`Price`) AS `Стоимость`,`items`.`vidProdazi` AS `Вид продажи`,`items_cost`.`Всего в заказе` AS `Всего в заказе` from ((((`clients` join `orders`) join `items`) join `goods`) join `items_cost`) where ((`clients`.`id` = `orders`.`clientID`) and (`orders`.`id` = `items`.`orderID`) and (`goods`.`id` = `items`.`goodID`) and (`items`.`orderID` = `items_cost`.`orderID`)) order by `clients`.`Client`,`orders`.`id`,`goods`.`id` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `sales_infocl`
--

/*!50001 DROP VIEW IF EXISTS `sales_infocl`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`dev`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `sales_infocl` AS select `sales_info`.`Клиент` AS `Клиент`,sum(`sales_info`.`Стоимость`) AS `sm` from `sales_info` group by `sales_info`.`Клиент` */;
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

-- Dump completed on 2023-04-09 18:52:29
