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
INSERT INTO `employees` VALUES (2,'000','Lambert','October',_binary '\0ø]\È*\ãs\\ÀA7	«qp£U’BžþÏ\Ýr\\Ÿ¾(ú%˜TuzX+_“°ölV¹_>>Ó¸Ñ´«¶•»µ\ï¸­‰IÚ¨(ª)öB\"3¬\Ü\Çp­É±\îá‘œU.D¾b:¯K¢# g\ÍÇ§ÅKH\Ì9\ãf-t”9‹9`>‘¾Iª ¬»ò£\ÊñÑ…wÁf\ß1Ïª¿µ\è\é\ËÿV\É)>\ì\ÚÀ48\Ôž\âðð±Z»\å\Ò\ÌM”WC\0\ì\ÐPj™0,\×Võ§-‘š\æ<´m/ðöxðù%§¼r»…­urr[\Ëk²…X–#Nü,ŒÁ‹&\Å\Ï\éEø\Îf\ØDÎ®•Kˆ3W\ã©Ò¢ü\Ó\Ï\ë‚:4h\Ò\ÜiŠ0\îi\ïªA\å½\ÂuM\çLpž\r0Y9J\"h~—\íUqb¼$pp\É?¬cÁ\Ñ\"Îˆû§T[ŽPóþñ?M\"hV.°’»#K>o\0ø\È*\ãs\\ÀA7	«qðµU’P\"º‰*ROA\íVs·Œ4uXT\'À\'\ÖPg\ë\ïl…\ÐpJ¸©˜Ÿ—´¬ø„ÁÑ‰*ÉŸÁ\r‹L\ÄÙ£Z1¿ñf‘/ˆ>›\0ƒª\"yW\Ç\åý\"¿\"o\Ì\è<¹¦À\Ã\ÕG¬¢cþpq©¨?®\ÔJJ™m‚Ÿ\"ß—Îƒ2ö\èsXSêº˜\É\Ú\éš\íòt~·œT\03‘9;±€\Ø\ÐK	.IÈŒ?»\rGºy\ÎR’\Ë\"ó÷\ÂI”›\ã^\\\ÛCôö¡@\"–6t+Ü¨|X\ró`@òF†@ö\Öð“•yW¥÷eò‘L^¨„EË¼ñ\ï>Gt¸û\ÝYXz~~%2e©ù7!ó·žs“2†¿-<ÿ;Mú\n,\Å¬_#\ê •u\Ù]M‹¤±µYµyd˜a ¡ ¶:{pGV—Ê»]>:BWþ¨\áE¦@\ã\×˜e¨p`R\í\Ó\ïó&R¯,\Z©‘/\ß‡Z1\ÆUÀ°\ç4ý%«¦ŽUT4€o\0ør\È*\ãs\\ÀA7	«q°IU’‹¼¿P˜\r»\å,©V«¯\è1 \×\Z\Å\Ï\nô$MB7›{\ÝHx™b\rT:Ü¶®\è\É\ëBW*M\Èð¬/!Nñò9\rN\'¯0K\Ðò[Ÿ\Ù^›o_³x\ëo\èHK(}â‘œò·ž3\â§-¥A\à%Vù#dY-òÕ¤\è\Ô]”¥ \ázr5þ-\è=@\Ëbü*|\îo]\ÔR“£âµ¢O]žñ3¾\0M:y\Å\à\à\ÈA$\Ã2È–øTŒH?ˆ&¤—l•c\ì\'a`\Â%™#öÇ¸ö®´[R<ÀwÙŽ,Pq\ÂP1\"\Ò\ÅÙ½\Ý\Ä,4JÈ„ý”òl±”bŽ\ÒK’\Ü\ë\ä\Øi¨½‰¹:u±>“ykKg\Ïþ\Ä\Ú\îÌ…ö¨R\ÚbG˜NP\ëÆ¶\r°i\Éh\ãÄŒùýúÀ[‘\Ã	ª\Ü+G+U\ÆÓœ[!þÁvfr‰?M)MðI¥\Å4\àž\É1xo\0\èA\È*\ãs\\ÀA7	«qp¹U’06\á~1øUZ\Çþ|¥^pY-\É+Ž-]“ññ\Ýwñ\nO­üÙ©®¯ýFIt\Æö\á%\ß\ï\Ïv:)&\ÆCp–Ax]\î¾p¢3µ\ë¸\â®Ã¥Ë•\ËGU\ÄZta\Ô,\çK\\5\Ê‘=ýƒj \èswsŽ.Að¸\ëÿýH\Ï6òCS\Ø:Kû\êµ\Ø\Ö_\Çºº!O\è\è\Ã5\ê*9‹`l;û Yõ\ß\Ú\ÒgYx\ZF\Ç²Zn&b\Ê\nÈy\Ø%Á“\ïÕž¿‘Vÿ\ÝdHc\Öö­Ù¸.Þ‹û“KhjñÀô]Êœe¹¾\à³òE8\nÆk\ÄPD\\\rH\"\ÅW–¶\Ã)\Þþ°¶”z˜[OŽC\ç\Ù@¡x¸4«B{gc\ß/³1\ç/[(\Ð\Ï\æŸ(ñ’­ýa\Æ\ê\Î\å\ï\ÇYŠe\åM\r+o$\0$\00\00\0<\0<\0H\0H\0`\0`\0l\0l\0x\0x\0„\0„\0\0\0œ\0œ\0À\0À\0\Ì\0\Ì\0ð\0ð\0ü\0ü\0\0\0\0\0,\0,\08\08\0D\0D\0P\0P\0h\0h\0t\0t\0€\0€\0Œ\0',1,'posit_b156081a893449e0ae14cf741a304d1e','2022-08-02 09:48:52','2022-08-14 06:36:01',1,'{44DA6005-4649-474A-A218-34A7E55E87E8}'),(3,'111','Test','Testing',_binary '\0øe\È*\ãs\\ÀA7	«q0¥U’\"b§OLÁK#M†«)nx´\ÂAs\ÝS\'z\Ë\æ¢|G!\ïË¿\ÑþN#ö¶Œ+\Ë}~%Û™aRp¨D½\Ño*ÀeiL…±=N“ï’ˆ]¡(œ^<€LýóÄ‘·ys’^0UŒ&¦\Ø@\Ý§93ñ“‡¶ªž«ø#¸ –¸\çó\âœ\å$Z`U›\È\ã3q/\Ä\ïû¿ª½\í\ßÄ¤z\ÅWòø*w‡3\Ãxó™xO-ü\ÍNco)fR!\Ú9¢\Ùÿ%“o\Ïþ\í/\ï\Ãb®¯6Ê ûÕ´\Æ\ÊÂ\ç\Ç\r:;\Ï’ˆjÏ†Xf– \Û\Þ\Â\éF\×Rp°	»}°ÿ\×KB‡\Ò\×\Øü\Ê{ïƒ;AtK\×\nî©6\îO{Ï§¾\ZI÷¹[\à\00BÁŠ\0ß½Œ!« ›¼]\ÃTÛ·\\\êfª2\ãüp?‘\Ûaö¨on\ÖO4I¢¤E—žb®\ß{ðQß­‘o\0øs\È*\ãs\\ÀA7	«qp”U’\ÙÃ±“APYß´zv\ãô”€ðÌ¡¾\äQ\Ú.\rw\Ê)\Å1 5ƒü´ñ§¬&\ß`–@>\åP3#\Ã\Ý\0\ÖÃ½\È\\Œµ\05’:\á`¬\ÝA@ü8Ê¦,Kad$‰>\'\Ôû\ã$ô\n6&ö\â½ YB_\â¿$¥¯O$¢\î0²™;-»˜“G\ØUˆ\Z\Ô\Ê\Ç\"\ÞRf&[\Ì}-A¢Àod\Ç\\‰p÷K\Î)‹6«\Þwaù\ïˆ\ÝXƒIõUvV’_d·¶¾]p\0A¹šŽ¨v\ä*üuP/\n´h\0\"Ð¼JS\ßJ²žr`o\ÎkxGü—\ã\ÇP·{yž\í8C9¨Iv¸\Â\rƒ–K›À<9k\ì!÷À…v*o \Èc1>X._i€__»\Î\\µf\Û2V‰\Æ\ß8°qÄ³«Ú‰\å	€P\å^\î¥\â$•D\ÒEz¨ITd\Ûøœ0÷U\à¤Ww\\´¹¶»è‡‘\×1·Œ$B¡~^FôoRÛ’]po\0ør\È*\ãs\\ÀA7	«qp¨U’\Ï\ÐÏˆ86I0._¸\È\î\Ì=CŒ!¨|d4G\' ˜}|çª¯&÷\É@\ÌkV¦\"¹¹ƒ\×H‚n†¹µû=°\Ì\è’F!‹\Íô\ÑH•³U¡j0\Ñ*8‘\ä\Ûc\ã#\âÐ·q«$H˜oJž¨½Û‚ì‡…c”>ã¿…²;C\ÃF1ðO®X§¸60£w¯8N€©‚ÕŸ\ß\êf¹»p$¢3B´\\ ×‰IR\ÖYO\ã\Úz\×<|›ù\'‘÷Ü\0\ìkø\0}b„\ä9 Wo÷´­¶C\Ó\ß=y\rt¤Sš\Ç;g}¢mªŸYEŸˆõM¿¤¿N“I]\ÉVø¥6\Ì[P\Ø@k\Ì\ã&—vñ}\áûH¿$e\å`¹\àrÄ¦`žUõ\æmaœ“ç ½	\íüòcRKü{“Í¾žs©:ƒ‘~‰2\Í\ÕAúJ\ÆŒŸªÊž–ó§ömŒeB@ô™\Ð\ë’\Ç`…˜‘`…¼\Ìn\æý0\Û	|!FˆUo\0\è€\È*\ãs\\ÀA7	«q0ˆU’\ÍN\Ø5ýi\îSœ‘•kI8¬Ò³‘euW\ßöB?I\×\Ç0{¨\Ç9K\Îý\ï¬}·Õ•¼„z\á?q\0šþd\ëeEÝ‚)\ÑýV	x–\\\ç©òÁû§*m\È/þyu¡\áñ<$œ\0&\ß·0/š\Üð\ÖD=px¤w*º\ë\0\Õr\Ûâª“\à8\"|ª£ž‡K{\Û\É\åE–\Þý³&\í¥\Z\ÛgÂ¢˜m,Ÿ•\ç‚õ-\î/©’ðöVóû­»\Ëq9H\í\é&V\'öP†ºÓ„\'Þ¬N,\æ!˜\á“,ñ6#—\ïñù c\åi^\Ê\ä³È­Ú´>j4·$\áûrsöS\r\Ì\Í\ß\Øø$\î!zPr0Å†›=¨­\íYø\ç7M\árpvþ-›v«,+\å~£[\Z3¬\íù¢yccGÀCc`} B\ÎÕ¼³!£\Ð\ÓQ	\ÊU\á.º\n&ü\ÙS…I’\Z9\åra°R*\0ûV85oÎ©q>ºs1\á+û5œh\Ê(:1o\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0',1,'posit_b156081a893449e0ae14cf741a304d1e','2022-08-02 13:51:25','2022-08-14 06:39:46',1,'{47C5F778-6E30-4DAA-A56A-D8153FB1938B}'),(4,'222','Test2','Testing2',_binary '\0øu\È*\ãs\\ÀA7	«qð’U’ú«F8!N\Îð\á\Í1\0`ˆ¤þX\îo‹¥\åÑ‰u\à°\\\êNJ“ÿ–«j1Pª˜H|v	\àKF\ÂºS¢$¨\Ï0\å\ÔùŒƒ™\Æ\Ös»6´tsY¦\ÔÁ§K\Éq¹A^[=¬R9¯\ÎT\'°\íZ\í\â\É`j¨\Â(º$¯pHPa¬\è\Ý6UJå¤´rº~o\ßxxP\Ï¨\É<\'<½\Ï\0(g\nò[öCˆ=Á\íOŠ’Dõþ±H\àh¦\rB\ÒMSmð‘@ \â\ëOš¿Mw¬(üðO\Î}OIg\Z>’øQ\í¢O•M$³\Ùc\ï\×\ËN\Èj^›!Xm|˜\ÊÏ\ÓóÜ‘7»cŽ©5Jlj>_\î,\ël²)\æ\0I>WÜ†:\ÈD\Äú?M­\Ü^ÛŸ°ekY²\Â\ìK\î\Ým1X”^\í²‰±p ýM\èZ\ç—†p]\Ý\ßqz$%\æ\ÍñÍ‹\Ò\Úl\Ðasq¼\ÅÀ€¼%7þ’‹Eo\0øl\È*\ãs\\ÀA7	«q°…U’•\Õ\ß+\ê+,OSa5E’Ò²\Õÿ¡g\Îˆ.Ì¹ÊŠ7–2¼\ÑÀ\Ú\Ê#lf\Ôe\Ã:q\ä%sþs\ÙKL#\Ãx\æ_\ØJvš&s=û¸„-\ë@\ÞÀ«œ\ãR‰/{[ö¾Ÿ\Ç4–a«\è ô^«ò’‹9\Û\Ò\Ü@\Ð¾,t÷H\Ë\Ëèª³X`§T±¥U7 Ž\È\Û	•·$c»ú s™T:…’Ž\'\ß4þ»»©Y‚(C›¤§½À>\Û\æ\æuq\Îù|Ž†¼²%`\ÚE²Q\æñ>ƒX	\ÝùF¥\âl»ü‡3ýj9h\ÅGºN\í™J²\Ð\ì\à\ìxWX¹\\Zø‰&7\Ý-\Þ,»ô«\ÐÁ\æe¨‚&²°Áú[‘¾¶”§\äQ¼Öƒrb7™B\Éòÿ•É•ø\Í|dð‹¦1rƒ]\Ò8¼\ã\Åö¨M\Â\Þ\Ë`JLÝ‘\Ù\êKˆ\ÔŽ\Úü†zª\Þ<˜•K\Åo\0øk\È*\ãs\\ÀA7	«q°‘U’ú¢\×\')\å\ßkBB\ë}bUsðD\ÝXa\ê\Ã\Ëü¬€\í–Õ‰\Ôý,H\ÊÙ“ýA‰\r\ånj\äþ\ï›\Ó7\Ø\ØFø®†¥|ˆ‚L¾d:ZtŽ\×<¹#\Ä[uw\ÆršºM¡Œ¬µË¥8È§\Z\Çxoýó\èŒ~_¿\ä’\Å|9y)4\Ï\ç_;GI(²–Ö¯MY\êäŒ¯;&$(*“› X³Hƒ·žŠ½p*©Î¢`~xU-kt\ÛV\Ë\á\"žQŠ\àGG­Uü[I¨\á;w-?Ç›\å%\Ë4\ë\Ê%ö’ª\Ñù¶×ŽÙ—X¾Ë¥ò\ÖEóN‘\èk¿\Ó\ç šcˆ—ˆ\Ð.Ž\ÇT‡ŠO´e+RŸ¤zM¯1©m\Ý\ÑùŠ\Ý	ÀADW[ªmŠþ\Û2”{\ÍÀGÖ¢aI;\ìõi¯X-ž€¸z\'‘SZ^p€ ‚&œr^i¼\åI3\Æ\Û\áô˜šEú¿\Ïo\0\è€\È*\ãs\\ÀA7	«q0¼U’ ×€†[‡$O\ßPX6Ee \å¬y\ÅgsC¤9™¸ƒ\'r\ÌWÓ›ŠÖ©<\r–*\Ùð\Õõñ´BŠþ²D8Pl¤\ìG3	\Ñþ7\r¬ö&ŠD\àr­–¿3\ìö„YXWýR’0v1B°\×\Ñù•ˆòTP„\ïD\Â4Lð<Ô¢~õ­U\":½\Ô\ëN5k\É\éae’\ÂŸ°TI^|#\Ç\"v{°ž	\í´VAq?¤Œ¥g	W\Æ|Ø’¯\"¾»»V¬Z>–Gç®“\n–	\í®é€˜ƒÈ¹¹­-W!\Ü\Ç]P©6»\ã®þö\Ø6‹U-\Öñ”“\0¿;+\ë\éðvÑ¢\Ö}}\é\Ñ\ÐC\ëLl‘´.“E•\r \Êð\0nj©ô©G\å¯Ó™Cù2|Œ»6—;sAüõ÷\0´g¨\çücøƒÉ³\'K‹\ë‹CR–\à¼:%\ÄÆ¬¤D\\5zöi \Ü\"5:G\å+\Ø+Ã;È‡BxVl\È\0\ì®Ò¤%\âþœ†Y\Ü(„3o\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0',1,'posit_156bed53635b4931bb7cd75c6e46847b','2022-08-02 14:19:30','2022-08-14 06:39:50',1,'{BB861F30-17C4-42FA-A48E-29BE1E6A3866}');
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
INSERT INTO `users` VALUES (1,'aa','Ayo','Ajayi','123456',_binary '\0ø^\È*\ãs\\ÀA7	«qp˜U’B8/\ã6Àøh\Ç\'¢kóž\ß\\\ï’\Ã\ê´\ãke4\é`\ç\Ò¾5?\Ä|\Ô?`ýµ\ì\Å&\ìþ¹b\é\Ñ5Œí“Ÿ*‘meõ\Ç \ÒüÁ‘\Ñöfß 7H…òF!\ÄC§9¨™}b\ë\Î#©\Ãõ\×ý3-²x\Üx‰\Ò~-(6¯¡\Ô\Ï2«^\ÎKŽõ¯kk²y\'”e2÷T\á\ä³Mt\Õ\Zýñx™|ÿnHõ„³wöm\ä¾H•“œ€¿›,zŒ‹$¼’¤G\â¹r7\è¯9´Ei \\^\Ö\É>\Å\Æ#š°\Ã|ø\Þ\îjÁÀ£\Ê6õ ÐŠ	o>4\çt…d\Ì\Øp¹Q±ö…‘Á\Ç!ný&J­#C\Z¶¸½,\ä\Ãt<\îK€À\Ê`\ã_\0m¸\Ç&\âÃ°\ÄËŠKÞ¾¶\ÜIô½¶0¸	+ž§öÕ£\í¹\êË™Zg\æ\È\îÇ¹ƒyk\Âw0\Ú1„o\0øV\È*\ãs\\ÀA7	«q°‰U’¶–¡\Ø£ˆ¿w\ÅH§$@œ3\×O×‹³û,\Ó$f=\ËlnŒ\â¯G©œ\ÖÀ\Ãj\á}Ô™¾\é2\Å\ã\Þ)\ÛNb\íµPÁö JŽ2˜µw\Ë.ž%üW‘\ÈZq—\ãÍŽ&®ó³±r\ÊÞ¶\å\ÑoG\èZ,d´ÜœŽ*Š‹ÿ•\nmr);@I\íE‡¦3FY¸_wO¾\é¢#d\Æ\ê\âøf#ý±OŸ\ì5™\çF:-°\"cpeL[µƒ	¸i\\\éKÖ©\ÊB…\Í	­ø~Ø§a\Â1J­\àh«B¸‹\ç\0?yZ(	(eÒ¤W/·œI\Ð\ËêŸƒ\Ë[\Ù·¤\Æ¿\Û\ßq#\êl…\0\ÊkŽ}Ÿ‰A°wº\r\Ò1°œ\Ç\ï•\É\n\'\ÏùDÀ¼*%QO\ÔGŸtDVÊ¡\ëB#\Òm`¶ªq•´Nsö¹’H•Nòs\Zn6\æÀ\ÊD\Îë‘º®o\0ø1\È*\ãs\\ÀA7	«qp†U’Žò¨¿\Â0ð…„L5k‰\ê_\r+\Ýœþ°-šûÃ€¬\ÝvmmnuqƒŽ|3\îˆ]—<u#\Ï{xb;\È\Ýv·\å]3\ßôƒ\á\È\\¸4‹9ƒ0I_™0¬=†´h[Ÿ\íÊ\0\Ø\Ùm\reY’„û\\\Çõ[ÊyJ«c\ã\ãþƒ·®¨,µO–\çžBœY\í–Ç€\Ï\äØ|ð0y>>]ø˜}·y\Üt\r5°K~½„t-]”“­\Ö`ªg`\Õ\ÊX61Ñ™9Ž=]q€\Û¼|\Õv!’\Òýÿ«\Ökp74ŽBõZ{8\ÉE\å2<\ÍQ#%M\Ë\ßö=V\Ãò#kn!\0/\Ðû\"ù\Õ4…kõª˜J‘H\Ï?1 –Šù½\ç\'\Â&Å°”ko\0\è!\È*\ãs\\ÀA7	«qp’U’\Ì\r½@f&yª<\Ø\ç÷M„ŸTœ¾\ÉM\ä\Ø`oE\éFšó©8§’+žt\çxd¤ñH7ˆy\Ïk²0®«±¸þ/-P‚9û±74CüXÚ´\à=k&;c\ÈÝ®$ª­Aƒ_uM÷wõË„³1¢°\Ó*.\æ~SøEJ\às„[»\ä&%?0\Âe\ÂñUº\ßU¥j¶V–¶89ûg‹˜þZv´$\03ª(ðŸ¶J³z|\Õt\æ=0‹C(F\ä²:\â\Z®%‡³\ÏN0t=<ñ6\ás\Ò1]{¶\È2Ä—n¸\éq?õü‚v~ÎºPŠ•+g@\\÷£Ç¾\Ä\ÙwSN.\ìê¥žÿ±\ç£\n¡~C\ì/^\Ã1|\Þ&üo\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0','2022-07-16 23:28:45','2022-08-05 12:38:00',1);
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
