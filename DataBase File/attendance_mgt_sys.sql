-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: localhost    Database: attenance_mgt
-- ------------------------------------------------------
-- Server version	5.7.14

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
-- Table structure for table `attendance_record`
--

DROP TABLE IF EXISTS `attendance_record`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `attendance_record` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `attendance_id` varchar(65) NOT NULL,
  `time_in` datetime DEFAULT NULL,
  `time_out` datetime DEFAULT NULL,
  `schedule_timein` time NOT NULL,
  `schedule_timeout` time NOT NULL,
  `schedule_name` varchar(55) NOT NULL,
  `position_name` varchar(55) NOT NULL,
  `employee_id` varchar(25) NOT NULL,
  `date_created` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `date_updated` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `attendance_id_UNIQUE` (`attendance_id`),
  KEY `emp_fk_idx` (`employee_id`),
  CONSTRAINT `emp_fk` FOREIGN KEY (`employee_id`) REFERENCES `employees` (`employee_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `attendance_record`
--

LOCK TABLES `attendance_record` WRITE;
/*!40000 ALTER TABLE `attendance_record` DISABLE KEYS */;
INSERT INTO `attendance_record` VALUES (1,'{370C7A84-6990-4964-97CC-EF408097B585}','2022-08-04 06:00:50','2022-08-04 18:29:41','06:00:00','18:00:00','Operators','Operators','111','2022-08-04 08:04:58','2022-08-05 13:21:37'),(2,'{C1FC8133-5E4E-4A4D-B1E3-BA9F22385C16}','2022-08-04 09:09:28','2022-08-04 09:30:07','06:00:00','18:00:00','Operators','Operators','000','2022-08-04 08:09:28','2022-08-04 08:30:07'),(3,'{85364D74-9245-49BB-86EE-3D367999C93D}','2022-08-04 09:50:15','2022-08-06 06:15:47','06:00:00','18:00:00','Operators','Operators','000','2022-08-04 08:50:15','2022-08-06 05:15:47'),(4,'{2F060B81-D058-4E9A-B9AA-93D1CB18DE0B}','2022-08-04 09:50:31','2022-08-04 09:53:06','08:00:00','16:00:00','Base Timing','Staff','222','2022-08-04 08:50:32','2022-08-04 08:53:06'),(5,'{AD310378-E73E-47F1-A503-62D7854E504D}','2022-07-04 09:50:34','2022-08-04 09:53:12','06:00:00','18:00:00','Operators','Operators','111','2022-08-04 08:50:34','2022-08-07 08:34:04'),(6,'{5936A213-3916-479E-B859-C1563EE91DC0}','2022-08-06 06:16:02','2022-08-14 07:36:08','06:00:00','18:00:00','Operators','Operators','111','2022-08-06 05:16:02','2022-08-14 06:36:08'),(7,'{AEE69D4D-330B-4A8E-91BD-400A3DC83F4A}','2022-08-06 06:16:07','2022-08-14 07:36:14','08:00:00','16:00:00','Base Timing','Staff','222','2022-08-06 05:16:07','2022-08-14 06:36:14'),(8,'{D695049C-4A92-40A6-AFB9-AAC5B769D473}','2022-08-06 06:16:20','2022-08-06 06:33:16','06:00:00','18:00:00','Operators','Operators','000','2022-08-06 05:16:20','2022-08-06 05:33:16'),(9,'{817E5C91-8115-49F4-8234-472B8EEADE94}','2022-08-10 20:27:42','2022-08-10 20:28:14','06:00:00','18:00:00','Operators','Operators','000','2022-08-10 19:27:43','2022-08-10 19:28:14'),(10,'{44DA6005-4649-474A-A218-34A7E55E87E8}','2022-08-14 07:36:00',NULL,'06:00:00','18:00:00','Operators','Operators','000','2022-08-14 06:36:01',NULL),(11,'{47C5F778-6E30-4DAA-A56A-D8153FB1938B}','2022-08-14 07:39:46',NULL,'06:00:00','18:00:00','Operators','Operators','111','2022-08-14 06:39:46',NULL),(12,'{BB861F30-17C4-42FA-A48E-29BE1E6A3866}','2022-08-14 07:39:50',NULL,'08:00:00','16:00:00','Base Timing','Staff','222','2022-08-14 06:39:50',NULL);
/*!40000 ALTER TABLE `attendance_record` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employees` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `employee_id` varchar(25) NOT NULL,
  `first_name` varchar(65) NOT NULL,
  `last_name` varchar(65) NOT NULL,
  `fingerprint` mediumblob NOT NULL,
  `status` tinyint(2) NOT NULL,
  `position_id` varchar(65) DEFAULT NULL,
  `date_created` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `date_updated` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  `curr_state` tinyint(4) DEFAULT NULL,
  `curr_id` varchar(65) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `employee_id_UNIQUE` (`employee_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
INSERT INTO `employees` VALUES (2,'000','Lambert','October',_binary '\0�]\�*\�s\\�A7	�qp�U�B��Ϗ\�r\\��(�%�TuzX+_���lV�_>>ӸѴ�����\���Iڨ(�)��B\"3�\�\�p�ɱ\�ᑜU.D�b:�K�# g\�ǧŁKH\�9\�f-t�9�9`>��I�����\��хw�f\�1Ϫ��\�\�\��V\�)>\�\��48\��\���Z�\�\�\�M�W�C\0\�\�Pj�0,\�V��-��\�<�m/��x��%��r���urr[\�k��X�#N�,���&\�\�\�E�\�f\�Dή�K�3W\�Ң�\�\�\�:4h\�\�i�0\�i\�A\�\�uM\�Lp�\r0Y9J\"h~�\�Uqb�$�pp\�?�c�\�\"Έ��T[�P����?M\"hV.���#K>o\0�\�*\�s\\�A7	�q�U�P\"��*ROA\�Vs��4uXT\'�\'\�Pg\�\�l�\�pJ����������щ*ɟ�\r�L�\�٣Z1��f�/�>�\0��\"yW\�\��\"�\"o\�\�<���\�\�G��c�pq��?�\�JJ�m��\"ߗ΃2�\�sXS꺘\�\�\�\��t~���T\03�9;��\�\�K	.IȌ?�\rG�y\�R�\�\"��\�I��\�^\\\�C���@\"�6t+ܨ|X\r�`@�F�@�\��yW��e�L^��E˼�\�>Gt��\�YXz~~%2e��7!�s�2��-<�;M�\n,\��_#\� �u\�]M����Y�yd�a � �:{pGV�ʻ]>:BW��\�E�@\�\��e�p`R\�\�\��&R�,\Z��/\���Z1\�U��\�4��%���UT4�o\0�r\�*\�s\\�A7	�q�IU����P��\r�\�,�V��\�1�\�\Z\�\�\n�$MB�7�{\�Hx�b\rT:ܶ�\�\�\�BW*M\��/!N��9\r�N\'�0K\��[�\�^�o_���x\�o�\�HK(}⑜�3\�-�A\�%V�#dY-�դ\�\�]���\�zr5�-\�=@\�b�*�|\�o]\�R��ⵢO]��3�\0�M:y\�\�\�\��A$\�2Ȗ�T�H?�&��l�c\�\'a`\�%�#�Ǹ���[R<�wَ,Pq\�P1\"\�\�ٽ\�\�,4JȄ���l��b�\�K�\�\�\�\�i����:u�>�ykKg\��\�\�\�̅��R\�bG�NP\�ƶ\r�i\�h\�Č����[�\�	�\�+G+U\�Ӝ[!��vfr�?M)M�I�\�4\��\�1xo\0\�A\�*\�s\\�A7	�qp�U�06\�~1�UZ\��|�^pY-\�+�-]���\�w�\nO��٩���FIt\��\�%\�\�\�v:)&\�Cp�Ax]\�p�3�\�\�å˕\�GU�\�Zta\�,\�K\\5\��=��j�\�sws�.A�\���H\�6�CS\�:K�\�\�\�_\���!O\�\�\�5\�*9�`l;� Y�\�\�\�gYx\Z�F\��Zn&b\�\nȁy\�%��\�՞��V�\�dHc\���ٸ.ދ��Khj���]ʜe��\����E8\nƏk\�PD\\\r�H\"\�W��\�)�\�����z�[O�C\�\�@�x�4��B{gc\�/�1\�/[(\�\�\�(��a\�\�\�\�\�\�Y��e\�M\r+o$\0$\00\00\0<\0<\0H\0H\0`\0`\0l\0l\0x\0x\0�\0�\0�\0�\0�\0�\0�\0�\0\�\0\�\0�\0�\0�\0�\0\0\0\0\0,\0,\08\08\0D\0D\0P\0P\0h\0h\0t\0t\0�\0�\0�\0',1,'posit_b156081a893449e0ae14cf741a304d1e','2022-08-02 09:48:52','2022-08-14 06:36:01',1,'{44DA6005-4649-474A-A218-34A7E55E87E8}'),(3,'111','Test','Testing',_binary '\0�e\�*\�s\\�A7	�q0�U�\"b�OL��K#M��)nx�\�As\�S\'z\�\��|G!\�˿\��N#���+\�}~%ۙaRp�D�\�o*�eiL��=N�]�(�^<�L��đ�ys�^0U�&�\�@\��93񓇶����#�����\��\�\�$Z�`U�\�\�3q/\�\������\�\�Ĥz\�W��*w�3\�x�xO-�\�Nco)fR!\�9�\��%�o\���\�/\�\�b��6ʠ�մ\�\�\�\�\r:;\���jφXf� \�\�\�\�F\�Rp��	�}��\�KB�\�\�\��\�{;�AtK\�\n�6\�O{ϧ�\ZI��[\�\00B��\0߽�!����]\�T۷\\\�f�2\��p?�\�a��on\�O4I��E��b�\�{�Q߭�o\0�s\�*\�s\\�A7	�qp�U�\�ñ�APYߴzv\�����̡�\�Q\�.\rw\�)\�1 5������&\�`�@>\�P3#\�\�\0\�ý\�\\���\05�:\�`�\�A@��8ʦ�,Kad$�>\'\��\�$�\n6&�\� YB_\�$��O$�\�0��;-���G\�U�\Z\�\�\�\"\�Rf&[\�}-A��od\�\\�p�K\�)�6�\�wa�\�\�X�I�UvV�_d���]p\0A����v\�*�uP/\n�h\0\"мJS\�J��r`o\�kxG��\�\�P�{�y�\�8C9�Iv�\�\r��K��<9k\�!���v*o�\�c1>X._i�__�\�\\�f\�2V�\�\�8�qĳ�ډ\�	�P\�^\�\�$�D\�Ez�ITd\���0�U\�W�w\\����臑\�1��$B�~^F�oRے]po\0�r\�*\�s\\�A7	�qp�U�\�\�ψ86I0._�\�\�\�=C�!�|d4G\' ��}|窯&�\�@\�kV�\"���\�H�n�����=�\�\�F!�\��\�H���U�j0\�*8�\�\�c\�#\�зq�$H�oJ���ۂ쇅c�>㿅�;C\�F1�O�X��6���0�w�8N���՟\�\�f��p$�3B��\\�׉IR\�YO\�\�z\�<|��\'��܁\0\�k�\0}b�\�9�Wo����C\�\�=y\rt�S�\�;g}�m��YE���M���N�I]\�V��6\�[P\�@k\�\�&�v�}\��H�$e\�`�\�rĦ`�U�\�ma��砽	\���cRK�{�;�s�:��~�2\�\�A�J\����ʞ����m�eB@��\�\�\�`���`��\�n\��0\�	|!F�Uo\0\�\�*\�s\\�A7	�q0�U�\�N\�5�i\�S���kI8�ҳ��euW\��B?I\�\�0{�\�9K\��\�}�Օ��z\�?q\0��d\�eE݂)\��V	x�\\\�����*m\�/�yu�\��<$�\0&\��0/�\��\�D=px�w*�\�\0\�r\�⪓\�8\"|����K{\�\�\�E�\���&\�\Z\�g¢�m,��\��-\�/����V����\�q9H\�\�&V\'�P���ӄ\'ެN,\�!�\�,�6#�\����c\�i^\�\�ȭڴ>j4�$\��rs�S\r\�\�\�\��$\�!zPr0ņ�=��\�Y�\�7M\�rpv�-��v�,+\�~�[\Z3�\���y�ccG�Cc`}�B\�ռ�!�\�\�Q	\�U\�.�\n&�\�S�I�\Z9\�ra�R*\0�V85oΩq>�s1\�+�5�h\�(:1o\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0',1,'posit_b156081a893449e0ae14cf741a304d1e','2022-08-02 13:51:25','2022-08-14 06:39:46',1,'{47C5F778-6E30-4DAA-A56A-D8153FB1938B}'),(4,'222','Test2','Testing2',_binary '\0�u\�*\�s\\�A7	�q�U���F8!N\��\�\�1\0`���X\�o��\�щu\�\\\�NJ����j1P��H|v	\�KF\��S�$�\�0\�\�����\�\�s�6�tsY�\���K\�q�A^[=�R9�\�T\'�\�Z\�\�\�`j�\�(�$�pHPa�\�\�6UJ头r�~o\�xxP\��\�<\'<�\�\0(g\n�[�C�=�\�O��D���H\�h�\rB\�MSm�@�\�\�O��Mw�(��O\�}OIg\Z>���Q\��O�M$��\�c\�\�\�N\�j^�!Xm|�\�ρ\��ܑ7�c��5Jlj>_\�,\�l�)\�\0I>W܆:\�D\��?M�\�^۟�ekY�\�\�K\�\�m1X�^\���p��M\�Z\��p]\�\�qz$%\�\��͋\�\�l\�asq�\����%7���Eo\0�l\�*\�s\\�A7	�q��U��\�\�+\�+,O�Sa5E�Ҳ\���g\��.̹ʊ7�2�\��\�\�#lf\�e\�:q\�%s�s\�KL#\�x\�_\�Jv�&s=���-\�@\����\�R�/{[���\�4�a�\� �^����9\�\�\�@\��,t�H\�\�誳X�`�T��U7� �\�\�	��$c�� s�T:���\'\�4����Y�(C�����>\�\�\�uq\��|����%`\�E�Q\��>�X�	\��F�\�l���3�j9h\�G�N\�J�\�\�\�\�xWX�\\Z��&7\�-\�,��\��\�e��&����[�����\�Q�փrb7�B\����ɕ�\�|d���1r�]\�8�\�\���M\�\�\�`JLݑ\�\�K�\��\���z�\�<��K\�o\0�k\�*\�s\\�A7	�q��U���\�\')\�\�kBB\�}bUs�D\�Xa\�\�\����\�Չ�\��,H\�ف��A�\r�\�nj\��\�\�7\�\�F����|���L�d:Zt�\�<�#\�[uw\�r��M����˥8ȧ\Z\�xo��\�~_�\�\�|9y)4\�\�_;GI(��֯MY\�䌯;&$(*���X�H�����p*�΢`~xU-kt�\�V\�\�\"�Q�\�GG�U�[I�\�;w-?Ǜ\�%\�4\�\�%���\���׎ٗX�˥�\�E�N�\�k�\�\� �c���\�.�\�T���O�e+R��zM�1�m\�\���\�	�ADW[�m��\�2�{\��G֢aI;\��i�X-���z\'�SZ^p�� �&�r^i�\�I3\�\�\����E��\�o\0\�\�*\�s\\�A7	�q0�U� ׀�[�$O\�PX6Ee \�y\�gsC�9���\'r\�WӍ��֩<\r�*\��\���B���D8Pl�\�G3�	\��7\r��&�D\�r���3\����YXW�R�0v1B�\�\�����TP�\�D\�4L�<Ԣ~���U\":�\�\�N5k\�\�ae�\���TI^|#\�\"v{��	\�VAq?���g	W\�|ؒ�\"���V�Z>�G箓\n�	\�逘�ȹ��-W!\�\�]P�6�\����\�6�U-\��\0�;+\�\��vѢ\�}}\�\�\�C\�Ll��.�E�\r \��\0nj���G\�әC�2|��6�;sA���\0�g�\��c��ɳ\'K�\�CR�\��:%\�Ƭ�D\\5z�i \�\"5:G\�+\�+Ý;ȇBxVl\�\0\�Ҥ%\����Y\�(�3o\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0',1,'posit_156bed53635b4931bb7cd75c6e46847b','2022-08-02 14:19:30','2022-08-14 06:39:50',1,'{BB861F30-17C4-42FA-A48E-29BE1E6A3866}');
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `positions`
--

DROP TABLE IF EXISTS `positions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `positions` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `position_id` varchar(65) NOT NULL,
  `name` varchar(65) NOT NULL,
  `status` tinyint(2) NOT NULL,
  `schedule_id` varchar(65) DEFAULT NULL,
  `date_created` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `date_updated` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `position_id_UNIQUE` (`position_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `positions`
--

LOCK TABLES `positions` WRITE;
/*!40000 ALTER TABLE `positions` DISABLE KEYS */;
INSERT INTO `positions` VALUES (2,'posit_156bed53635b4931bb7cd75c6e46847b','Staff',1,'schd_ae2809a345354f74a2750d59d1703d49','2022-08-01 07:49:57','2022-08-02 09:25:09'),(3,'posit_b156081a893449e0ae14cf741a304d1e','Operators',1,'schd_abb56a6dbb9345519f3fd52bfd4e4d44','2022-08-01 09:54:41','2022-08-02 14:12:49');
/*!40000 ALTER TABLE `positions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `schedules`
--

DROP TABLE IF EXISTS `schedules`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `schedules` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `schedule_id` varchar(65) NOT NULL,
  `name` varchar(65) NOT NULL,
  `start_time` time NOT NULL,
  `end_time` time NOT NULL,
  `status` tinyint(2) NOT NULL,
  `date_created` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `date_updated` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `schedule_id_UNIQUE` (`schedule_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `schedules`
--

LOCK TABLES `schedules` WRITE;
/*!40000 ALTER TABLE `schedules` DISABLE KEYS */;
INSERT INTO `schedules` VALUES (1,'schd_ae2809a345354f74a2750d59d1703d49','Base Timing','08:00:00','16:00:00',1,'2022-07-27 09:43:05','2022-08-02 13:52:10'),(3,'schd_abb56a6dbb9345519f3fd52bfd4e4d44','Operators','06:00:00','18:00:00',1,'2022-07-28 16:36:42','2022-08-02 14:07:01');
/*!40000 ALTER TABLE `schedules` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(65) NOT NULL,
  `first_name` varchar(65) NOT NULL,
  `last_name` varchar(65) NOT NULL,
  `password` varchar(55) NOT NULL,
  `fingerprint` mediumblob,
  `date_created` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `date_updated` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  `status` tinyint(4) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `username_UNIQUE` (`username`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'aa','Ayo','Ajayi','123456',_binary '\0�^\�*\�s\\�A7	�qp�U�B�8/\�6��h\�\'�k�\�\\\�\�\��\�ke4\�`\�\��5?\�|\�?`��\�\�&\���b\�\�5�퓁�*�me�\� \����\��fߠ7H��F!\�C�9��}b\�\�#�\��\��3-�x\�x�\�~-(6��\�\�2�^\�K���kk�y\'�e2�T\�\��Mt\�\Z��x�|�nH���w�m\�H������,z��$���G\�r7\�9�Ei�\\^\�\�>\�\�#��\�|�\�\�j���\�6��Њ	o>4\�t�d\�\�p�Q�����\�!n�&J�#C\Z���,\�\�t<\�K��\�`\�_\0m�\�&\�ð\�ˊK޾�\�I���0�	+���գ\�\�˙Zg\�\�\�ǹ�yk\�w0\�1�o\0�V\�*\�s\\�A7	�q��U����\����w\�H�$@�3\�O׋��,\�$f=\�ln�\�G��\��\�j\�}ԙ�\�2\�\�\�)\�Nb\�P�� J�2��w\�.�%�W�\�Zq�\�͎&��r\�޶\�\�oG\�Z,d�ܜ�*����\nmr);@I\�E��3FY�_wO�\�#d\�\�\��f�#��O�\�5�\�F�:-�\"c�pe�L[��	�i\\\�K֩\�B�\�	��~اa\�1J�\�h�B��\�\0?y�Z(	(eҤW/��I\�\�ꟃ\�[\���\��\�\�q#\�l�\0\�k�}���A�w�\r\�1��\�\�\�\n\'\��D��*%QO\�G�tDVʡ\�B#\�m`��q��Ns���H��N�s\Zn6\��\�D\�둺�o\0�1\�*\�s\\�A7	�qp�U���\�0���L5k�\�_�\r+\����-��À�\�vmmnuq��|3\�]�<u#\�{xb;\�\�v�\�]3\��\�\�\\�4�9�0I_�0�=��h[�\�ʏ\0\�\�m\reY����\\\��[ʁyJ�c\�\������,�O�\�B�Y\�ǀ\�\�؏|�0y>>]��}�y\�t�\r5�K~��t-]���\�`�g`\�\�X6�1љ9�=]q��\��|\�v!�\����\�kp74�B�Z{8\�E\�2<\�Q#%M\�\��=V\��#kn!\0/\��\"�\�4�k���J�H\�?1�����\�\'\�&Ű�ko\0\�!\�*\�s\\�A7	�qp�U�\�\r�@f�&y�<\�\��M��T��\�M\�\�`oE�\�F��8��+�t\�xd��H7�y\�k�0�����/-P�9���74C��Xڴ\�=k&;c\�ݮ$��A�_uM�w�˄�1��\�*.\�~S�EJ�\�s�[�\�&%?0\�e\��U�\�U�j�V��89�g���Zv�$\03�(�J�z|\�t\�=0�C(F\�:\�\Z�%��\�N0t=<�6\�s\�1�]{��\�2�ėn�\�q?���v~κP���+g@\\��Ǿ\�\�wSN.\�꥞��\�\n�~C\�/^\�1|\�&�o\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0','2022-07-16 23:28:45','2022-08-05 12:38:00',1);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-08-14 12:18:39
