-- phpMyAdmin SQL Dump
-- version 4.8.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 31, 2018 at 03:57 PM
-- Server version: 10.1.32-MariaDB
-- PHP Version: 5.6.36

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `donordarah`
--

-- --------------------------------------------------------

--
-- Table structure for table `adminn`
--

CREATE TABLE `adminn` (
  `idadmin` varchar(4) NOT NULL,
  `namaadmin` varchar(10) NOT NULL,
  `passadmin` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `inputdarah`
--

CREATE TABLE `inputdarah` (
  `idinput` varchar(10) NOT NULL,
  `namapendonor` text NOT NULL,
  `tanggalmasuk` date NOT NULL,
  `inputgoldar` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `inputdatapendonor`
--

CREATE TABLE `inputdatapendonor` (
  `idnama` varchar(10) NOT NULL,
  `namapendonor` text NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `umur` int(3) NOT NULL,
  `tanggallahir` date NOT NULL,
  `beratbadan` int(3) NOT NULL,
  `inputgoldar` varchar(5) NOT NULL,
  `riwayatpenyakit` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `inputdatapendonor`
--

INSERT INTO `inputdatapendonor` (`idnama`, `namapendonor`, `alamat`, `umur`, `tanggallahir`, `beratbadan`, `inputgoldar`, `riwayatpenyakit`) VALUES
('dp001', 'dani indrobani', 'kebraon', 20, '1997-05-01', 88, 'O', 'pusing , panas dalam');

-- --------------------------------------------------------

--
-- Table structure for table `outputdarah`
--

CREATE TABLE `outputdarah` (
  `idkeluar` varchar(10) NOT NULL,
  `golongandarah` varchar(5) NOT NULL,
  `banyakkantong` int(3) NOT NULL,
  `tanggalkeluar` date NOT NULL,
  `keterangan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `outputdarah`
--

INSERT INTO `outputdarah` (`idkeluar`, `golongandarah`, `banyakkantong`, `tanggalkeluar`, `keterangan`) VALUES
('dk001', 'O', 2, '2018-05-01', 'untuk rumah sakit');

-- --------------------------------------------------------

--
-- Table structure for table `stokdarah`
--

CREATE TABLE `stokdarah` (
  `idstok` varchar(10) NOT NULL,
  `kantongo` int(3) NOT NULL,
  `kantonga` int(3) NOT NULL,
  `kantongb` int(3) NOT NULL,
  `kantongab` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `adminn`
--
ALTER TABLE `adminn`
  ADD PRIMARY KEY (`idadmin`);

--
-- Indexes for table `inputdarah`
--
ALTER TABLE `inputdarah`
  ADD PRIMARY KEY (`idinput`);

--
-- Indexes for table `inputdatapendonor`
--
ALTER TABLE `inputdatapendonor`
  ADD PRIMARY KEY (`idnama`);

--
-- Indexes for table `outputdarah`
--
ALTER TABLE `outputdarah`
  ADD PRIMARY KEY (`idkeluar`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
