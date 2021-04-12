-- MySQL dump 10.13  Distrib 8.0.23, for Win64 (x86_64)
--
-- Host: localhost    Database: kelime_oyunu
-- ------------------------------------------------------
-- Server version	8.0.23

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
-- Table structure for table `alti_harfli`
--

DROP TABLE IF EXISTS `alti_harfli`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `alti_harfli` (
  `id_alti` int unsigned NOT NULL AUTO_INCREMENT,
  `soru_alti` varchar(300) NOT NULL,
  `cevap_alti` varchar(6) NOT NULL,
  PRIMARY KEY (`id_alti`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alti_harfli`
--

LOCK TABLES `alti_harfli` WRITE;
/*!40000 ALTER TABLE `alti_harfli` DISABLE KEYS */;
INSERT INTO `alti_harfli` VALUES (1,'Yakınma ve hafifseme yoluyla “Şimdiki devir” anlamında kullanılan sözcük','Zamane'),(2,'Argoda, “Aldatarak parasını çekmek”','Sağmak'),(3,'“Güncel” anlamına gelen Fransızca kökenli sözcük','Aktüel'),(4,'“Eklemek, katmak, ilave etmek” anlamında bir söz','Ulamak'),(5,'Dikiş nakış işlerinde kullanılan parmak korumalığı','Yüksük'),(6,'“Havlamak” anlamında bir söz','Ürümek'),(7,'Kolayca, haksız ele geçen kazanç','Vurgun'),(8,'Döndürerek bükmek','Burmak'),(9,'“Hayali” sözünün Türkçe kökenli karşılıklarından biri','Düşsel'),(10,'Canlı bir sarı tonunu da adıyla niteleyen, dünyanın en pahalı baharatı','Safran'),(11,'Gönlü değişken, aşkı vefasız olan','Hercai'),(12,'Şerit biçimde metal veya plastik levhalardan yapılmış bir tür perde','Jaluzi');
/*!40000 ALTER TABLE `alti_harfli` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bes_harfli`
--

DROP TABLE IF EXISTS `bes_harfli`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bes_harfli` (
  `id_bes` int unsigned NOT NULL AUTO_INCREMENT,
  `soru_bes` varchar(300) NOT NULL,
  `cevap_bes` varchar(5) NOT NULL,
  PRIMARY KEY (`id_bes`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bes_harfli`
--

LOCK TABLES `bes_harfli` WRITE;
/*!40000 ALTER TABLE `bes_harfli` DISABLE KEYS */;
INSERT INTO `bes_harfli` VALUES (1,'Haber toplama, yayma ve üyelerine dağıtma işiyle uğraşan kuruluş','Ajans'),(2,'Gelişen teknolojiyle birçok alanda insanın yerini alabileceği düşünülen elektromekanik araç','Robot'),(3,'Karanın deniz boyunca uzanan bölümü','Sahil'),(4,'Kişinin kendine taktığı simgesel isim','Rumuz'),(5,'Dar alanlarda kendini tekrarlayan gezinti','Volta'),(6,'“Çöl” anlamında Arapça kökenli bir sözcük','Sahra'),(7,'“Atlas” da denen kumaş türü','Saten'),(8,'Çeşitli işlerde kullanılmak üzere hazırlanmış, işlenmiş ağaç parçası','Tahta'),(9,'Bir şeyi yapabilme, başarabilme gücü, derman','Takat'),(10,'Kuzey Amerika’ya özgü, kafası tilkiye benzeyen, uzun kuyruğu alaca halkalı olan kürklü hayvan','Rakun');
/*!40000 ALTER TABLE `bes_harfli` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dokuz_harfli`
--

DROP TABLE IF EXISTS `dokuz_harfli`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dokuz_harfli` (
  `id_dokuz` int unsigned NOT NULL AUTO_INCREMENT,
  `soru_dokuz` varchar(300) NOT NULL,
  `cevap_dokuz` varchar(9) NOT NULL,
  PRIMARY KEY (`id_dokuz`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dokuz_harfli`
--

LOCK TABLES `dokuz_harfli` WRITE;
/*!40000 ALTER TABLE `dokuz_harfli` DISABLE KEYS */;
INSERT INTO `dokuz_harfli` VALUES (1,'“Bu işle ilgilenmem, buna karışmam” anlamında bir tabir','Nemelazım'),(2,'Genellikle ev işlerinde çalışan, işverenlerin isteklerini yerine getiren emekçi','Hizmetkar'),(3,'Örnek ve feyzalınan, öykünülen, taklit edilen kişi','Rolmodeli'),(4,'Bir cismi bir yöne doğru ansızın, çabucak fırlatmak','Atıvermek'),(5,'“Belik” de denen, nakış ve örgü işlerinde kullanılan bir motif','Saçörgüsü'),(6,'“Ne çok katı ne de çok yumuşak” anlamında bir tabir','Tatlısert'),(7,'Lükse ve gösterişten uzak, yalın bir bakış açısıyla sürdürülen hayat','Sadeyaşam'),(8,'“Adını söylemek, sözünü söylemek, anmak” anlamlarında bir tabir','Zikretmek'),(9,'“Yankı” anlamında eski bir tabir','Aksiseda'),(10,'Tiz, keskin ve yüksek bir ses çıkarıp, ortamda yankılanmasını sağlamak','Çınlatmak');
/*!40000 ALTER TABLE `dokuz_harfli` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dort_harfli`
--

DROP TABLE IF EXISTS `dort_harfli`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dort_harfli` (
  `id_dort` int unsigned NOT NULL AUTO_INCREMENT,
  `soru_dort` varchar(300) NOT NULL,
  `cevap_dort` varchar(4) NOT NULL,
  PRIMARY KEY (`id_dort`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dort_harfli`
--

LOCK TABLES `dort_harfli` WRITE;
/*!40000 ALTER TABLE `dort_harfli` DISABLE KEYS */;
INSERT INTO `dort_harfli` VALUES (1,'“Ulvi” sözünün Türkçe kökenli eş anlamlısı','Yüce'),(2,'Deride sinirler boyunca beliren, “Gece yanığı” olarak da bilinen hastalık','Zona'),(3,'Çabuk ve kolay kavrayan, zeyrek','Zeki'),(4,'Ruhi yaşam ve bedenle uyumlu olmayı amaçlayan kültürfizik ve felsefe sistemi','Yoga'),(5,'Temel niteliği bir olan dil, hayvan veya bitki topluluğu','Aile'),(6,'Adını bir dondurma türüne de vermiş olan Avrupa şehri','Roma'),(7,'“Anlamsız ve faydasız yere” anlamında bir söz','Boşa'),(8,'“Filiz, sürgün” anlamına gelen bir kadın adı','Ajda'),(9,'Bayağı kesirlerde pay ile payda arasına konulan yatay çizginin okunuşu','Bölü'),(10,'Halk ağzında, “Alev, yalım”','Alaz'),(11,'Ait olunan fakat uzak kalıp özlenen yer','Sıla'),(12,'Bakıma ve barınmaya muhtaç bir grup insanın oturduğu, yetiştirildiği veya bakıldığı kurum','Yurt');
/*!40000 ALTER TABLE `dort_harfli` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `on_harfli`
--

DROP TABLE IF EXISTS `on_harfli`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `on_harfli` (
  `id_on` int unsigned NOT NULL AUTO_INCREMENT,
  `soru_on` varchar(300) NOT NULL,
  `cevap_on` varchar(10) NOT NULL,
  PRIMARY KEY (`id_on`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `on_harfli`
--

LOCK TABLES `on_harfli` WRITE;
/*!40000 ALTER TABLE `on_harfli` DISABLE KEYS */;
INSERT INTO `on_harfli` VALUES (1,'Okey oyununda taşların eşlerini toplama','Çiftegitme'),(2,'Bir bütünü keserek ince ve yassı parçalara ayırmak','Dilimlemek'),(3,'“İmece”nin kurumsallaşıp sermayeli ortaklığa dönüşmüş hali','Kooperatif'),(4,'“Tüm hava koşullarında, yaz kış kullanılabilen” gereçlere yönelik bir tabir','Dörtmevsim'),(5,'Psikolojik denge','Ruhsağlığı'),(6,'“Kefeni yırtmayı adet haline getirmiş kişiler” için kullanılan bir söz','Dokuzcanlı'),(7,'Esintinin yönünü, bazen de adını gösteren levhalara verilen ad','Rüzgargülü'),(8,'Mecazi anlamda, “Birinin aklını başına toplamasını sağlamak”','Uyandırmak'),(9,'Gazetelerin birinci sayfasındaki logonun üzerinde kullanılan başlık','Sürmanşet'),(10,'“Ulaşmak, varmak” anlamındaki eski bir tabir','Vasılolmak');
/*!40000 ALTER TABLE `on_harfli` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sekiz_harfli`
--

DROP TABLE IF EXISTS `sekiz_harfli`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sekiz_harfli` (
  `id_sekiz` int unsigned NOT NULL AUTO_INCREMENT,
  `soru_sekiz` varchar(300) NOT NULL,
  `cevap_sekiz` varchar(8) NOT NULL,
  PRIMARY KEY (`id_sekiz`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sekiz_harfli`
--

LOCK TABLES `sekiz_harfli` WRITE;
/*!40000 ALTER TABLE `sekiz_harfli` DISABLE KEYS */;
INSERT INTO `sekiz_harfli` VALUES (1,'Alacakların toplanması','Tahsilat'),(2,'“Acınmak, yazıklanmak, teessüf etmek” anlamlarındaki söz','Yerinmek'),(3,'Kendini tutamayıp çökmek, bayılıp düşmek','Yığılmak'),(4,'“Üretim fiyatının altında yapılan satışları” niteleyen söz','Zararına'),(5,'“Orkestra için bestelenmiş, birkaç bölümden oluşan uzun müzik eserleriyle ilgili” anlamında bir söz','Senfonik'),(6,'Kötü bir olayı duyuran bilgi','Acıhaber'),(7,'Her dizenin ilk harfi yukarıdan aşağıya doğru okunduğunda ortaya bir söz çıkacak biçimde düzenlenmiş manzume','Akrostiş'),(8,'Duygusal bağ veya akrabalık ilişkisi','Yakınlık'),(9,'Argoda, “Normal formunu, halini, durumunu kaybetmek, bozulmak”','Yamulmak'),(10,'“Yankı” anlamında eski bir tabir','Aksiseda');
/*!40000 ALTER TABLE `sekiz_harfli` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `yedi_harfli`
--

DROP TABLE IF EXISTS `yedi_harfli`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `yedi_harfli` (
  `id_yedi` int unsigned NOT NULL AUTO_INCREMENT,
  `soru_yedi` varchar(300) NOT NULL,
  `cevap_yedi` varchar(7) NOT NULL,
  PRIMARY KEY (`id_yedi`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `yedi_harfli`
--

LOCK TABLES `yedi_harfli` WRITE;
/*!40000 ALTER TABLE `yedi_harfli` DISABLE KEYS */;
INSERT INTO `yedi_harfli` VALUES (1,'“Amacında, yolunda” anlamında bir zarf','Uğrunda'),(2,'Evliya mucizesi','Keramet'),(3,'Bir iş için, “Gereği gibi yürümemek, geri kalmak” anlamında kullanılan tabir','Aksamak'),(4,'“Öküz, manda ve deve” gibi hayvanlar için, “Diyaframını kullanarak bağırma”','Böğürme'),(5,'Bir yere ağırlanmak üzere çağrılmış kişi','Davetli'),(6,'Neşeli ve hoşça vakit geçirilen toplantı','Eğlenti'),(7,'Yapılması istenmeyen bir davranışı engellemek için söylenen, iki farklı ünlemden oluşan sözcük dizisi','Sakınha'),(8,'“Birbiri arkasından” anlamında bir söz dizisi','Üstüste'),(9,'Duvar veya asma tavan yapımında kullanılan, iki tarafı kağıt kaplı olan levha','Alçıpan'),(10,'Çok zorluk çekerek sürekli çalışma','Didinme'),(11,'Buz pisti üzerinde kaydırma taşları ve fırçalarla oynanan olimpik bir takım oyunu.','Körling');
/*!40000 ALTER TABLE `yedi_harfli` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-04-12 16:01:02
