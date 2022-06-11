-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 05 Şub 2021, 08:01:07
-- Sunucu sürümü: 10.4.17-MariaDB
-- PHP Sürümü: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `realwaterui`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `gdveriler`
--

CREATE TABLE `gdveriler` (
  `idGüncel` int(11) NOT NULL,
  `idHesaplama` int(31) NOT NULL,
  `idKullanıcı` int(11) NOT NULL,
  `KazanılanP` int(200) NOT NULL,
  `idGeçmiş` int(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `gdveriler`
--

INSERT INTO `gdveriler` (`idGüncel`, `idHesaplama`, `idKullanıcı`, `KazanılanP`, `idGeçmiş`) VALUES
(1, 1, 1, 6000, 1);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `hesaplamaverileri`
--

CREATE TABLE `hesaplamaverileri` (
  `idHesaplama` int(31) NOT NULL,
  `BuGüniçilenSu` int(255) NOT NULL,
  `Tarih` date NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `hesaplamaverileri`
--

INSERT INTO `hesaplamaverileri` (`idHesaplama`, `BuGüniçilenSu`, `Tarih`) VALUES
(1, 1071, '2021-01-30'),
(2, 1453, '2021-02-04'),
(3, 0, '2021-02-05');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `istatikselveriler`
--

CREATE TABLE `istatikselveriler` (
  `idGeçmiş` int(200) NOT NULL,
  `1günlükORT` int(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `istatikselveriler`
--

INSERT INTO `istatikselveriler` (`idGeçmiş`, `1günlükORT`) VALUES
(1, 1603);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanıcı`
--

CREATE TABLE `kullanıcı` (
  `idKullanıcı` int(11) NOT NULL,
  `İsim` varchar(200) NOT NULL,
  `Şifre` int(200) NOT NULL,
  `Eposta` varchar(200) NOT NULL,
  `Soyisim` varchar(200) NOT NULL,
  `Boy` int(200) NOT NULL,
  `Kilo` int(200) NOT NULL,
  `Cinsiyet` varchar(200) NOT NULL,
  `Yaş` int(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `kullanıcı`
--

INSERT INTO `kullanıcı` (`idKullanıcı`, `İsim`, `Şifre`, `Eposta`, `Soyisim`, `Boy`, `Kilo`, `Cinsiyet`, `Yaş`) VALUES
(1, 'ali', 1, 'Mstt@outlook.com', 'veli', 170, 70, 'Erkek', 20);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `market`
--

CREATE TABLE `market` (
  `idMarket` int(200) NOT NULL,
  `idGüncel` int(11) NOT NULL,
  `Fiyat` int(255) NOT NULL,
  `kullanılabilirlik` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `market`
--

INSERT INTO `market` (`idMarket`, `idGüncel`, `Fiyat`, `kullanılabilirlik`) VALUES
(1, 1, 2000, 0),
(2, 1, 2000, 0),
(3, 1, 2000, 0),
(4, 1, 2000, 0),
(5, 1, 2000, 0),
(6, 1, 2000, 0),
(7, 1, 2000, 0),
(8, 1, 2000, 1);

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `gdveriler`
--
ALTER TABLE `gdveriler`
  ADD PRIMARY KEY (`idGüncel`),
  ADD KEY `idKullanıcı` (`idKullanıcı`),
  ADD KEY `idGeçmiş` (`idGeçmiş`),
  ADD KEY `idHesaplama` (`idHesaplama`);

--
-- Tablo için indeksler `hesaplamaverileri`
--
ALTER TABLE `hesaplamaverileri`
  ADD PRIMARY KEY (`idHesaplama`);

--
-- Tablo için indeksler `istatikselveriler`
--
ALTER TABLE `istatikselveriler`
  ADD PRIMARY KEY (`idGeçmiş`);

--
-- Tablo için indeksler `kullanıcı`
--
ALTER TABLE `kullanıcı`
  ADD PRIMARY KEY (`idKullanıcı`);

--
-- Tablo için indeksler `market`
--
ALTER TABLE `market`
  ADD PRIMARY KEY (`idMarket`),
  ADD KEY `idGüncel` (`idGüncel`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `gdveriler`
--
ALTER TABLE `gdveriler`
  MODIFY `idGüncel` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Tablo için AUTO_INCREMENT değeri `hesaplamaverileri`
--
ALTER TABLE `hesaplamaverileri`
  MODIFY `idHesaplama` int(31) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Tablo için AUTO_INCREMENT değeri `kullanıcı`
--
ALTER TABLE `kullanıcı`
  MODIFY `idKullanıcı` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Tablo için AUTO_INCREMENT değeri `market`
--
ALTER TABLE `market`
  MODIFY `idMarket` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Dökümü yapılmış tablolar için kısıtlamalar
--

--
-- Tablo kısıtlamaları `gdveriler`
--
ALTER TABLE `gdveriler`
  ADD CONSTRAINT `gdveriler_ibfk_1` FOREIGN KEY (`idKullanıcı`) REFERENCES `kullanıcı` (`idKullanıcı`),
  ADD CONSTRAINT `gdveriler_ibfk_3` FOREIGN KEY (`idGeçmiş`) REFERENCES `istatikselveriler` (`idGeçmiş`),
  ADD CONSTRAINT `gdveriler_ibfk_4` FOREIGN KEY (`idHesaplama`) REFERENCES `hesaplamaverileri` (`idHesaplama`);

--
-- Tablo kısıtlamaları `market`
--
ALTER TABLE `market`
  ADD CONSTRAINT `market_ibfk_1` FOREIGN KEY (`idGüncel`) REFERENCES `gdveriler` (`idGüncel`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
