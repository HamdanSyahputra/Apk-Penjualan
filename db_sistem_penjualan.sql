-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 25 Agu 2021 pada 12.27
-- Versi server: 10.4.20-MariaDB
-- Versi PHP: 8.0.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_sistem_penjualan`
--

-- --------------------------------------------------------

--
-- Stand-in struktur untuk tampilan `relasipenjualan`
-- (Lihat di bawah untuk tampilan aktual)
--
CREATE TABLE `relasipenjualan` (
`id_jual` int(3)
,`nomorFaktur` varchar(9)
,`tanggalJual` date
,`Deskripsi` varchar(30)
,`kodeProduk` varchar(5)
,`namaProduk` varchar(30)
,`kemasan` varchar(15)
,`ukuran` varchar(10)
,`hargaBeli` double
,`persediaan` int(4)
,`kodePelanggan` varchar(5)
,`nama` varchar(30)
,`alamat` varchar(30)
,`telepon` varchar(15)
,`jumlahJual` int(3)
,`hargaJual` double
,`bayar` double
,`kembalian` double
,`total` double
);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_faktur`
--

CREATE TABLE `tbl_faktur` (
  `nomorFaktur` varchar(9) NOT NULL,
  `kodePelanggan` varchar(5) NOT NULL,
  `tanggalJual` date NOT NULL,
  `Deskripsi` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_faktur`
--

INSERT INTO `tbl_faktur` (`nomorFaktur`, `kodePelanggan`, `tanggalJual`, `Deskripsi`) VALUES
('FA001', 'C001', '2021-01-01', 'Gula Pasir 2 karung'),
('FA002', 'C002', '2021-03-08', 'Beras 5 karung'),
('FA003', 'C003', '2021-03-12', 'Kecap manis 3 Plastik'),
('FA004', 'C004', '2021-03-08', 'Teh celup 5 Kotak');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_jual`
--

CREATE TABLE `tbl_jual` (
  `id_jual` int(3) NOT NULL,
  `nomorFaktur` varchar(9) NOT NULL,
  `kodeProduk` varchar(5) NOT NULL,
  `kodePelanggan` varchar(5) NOT NULL,
  `jumlahJual` int(3) NOT NULL,
  `hargaJual` double NOT NULL,
  `bayar` double DEFAULT NULL,
  `kembalian` double DEFAULT NULL,
  `total` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_jual`
--

INSERT INTO `tbl_jual` (`id_jual`, `nomorFaktur`, `kodeProduk`, `kodePelanggan`, `jumlahJual`, `hargaJual`, `bayar`, `kembalian`, `total`) VALUES
(6, 'FA001', 'BB003', 'C002', 3, 400000, 800000, -400000, 1200000),
(7, 'FA003', 'MP221', 'C003', 4, 50000, 500000, 300000, 200000),
(8, 'FA001', 'BB003', 'C001', 4, 50000, 500000, 300000, 200000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_pelanggan`
--

CREATE TABLE `tbl_pelanggan` (
  `kodePelanggan` varchar(5) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `alamat` varchar(30) NOT NULL,
  `telepon` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_pelanggan`
--

INSERT INTO `tbl_pelanggan` (`kodePelanggan`, `nama`, `alamat`, `telepon`) VALUES
('C001', 'Ayub Micheal S. Pandia', 'Kisaran', '08234254353'),
('C002', 'Endang Sriwangi Harahap', 'Kisaran', '08234254353'),
('C003', 'Agnes Tresia', 'Tanjung Balai', '0825248165'),
('C004', 'Hamdan Syahputra Marpaung', 'Kisaran', '083764832827');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_produk`
--

CREATE TABLE `tbl_produk` (
  `kodeProduk` varchar(5) NOT NULL,
  `namaProduk` varchar(30) NOT NULL,
  `kemasan` varchar(15) NOT NULL,
  `ukuran` varchar(10) NOT NULL,
  `hargaBeli` double NOT NULL,
  `persediaan` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_produk`
--

INSERT INTO `tbl_produk` (`kodeProduk`, `namaProduk`, `kemasan`, `ukuran`, `hargaBeli`, `persediaan`) VALUES
('BB003', 'Beras ', 'Kotak', '15KG', 250000, 5),
('GL002', 'Gula Pasir', 'Karung', '10KG', 500000, 6),
('KCP98', 'Kecap manis', 'Plastik', '1kg', 30000, 120),
('MI133', 'Mie Instan', 'Kotak', '5KG', 250000, 30),
('MP221', 'Mentega Premium', 'Kotak', '20KG', 300000, 20),
('MS442', 'Minyak Sayur', 'Plastik', '2KG', 30000, 100),
('TC221', 'Teh Celup', 'Kotak', '1KG', 20000, 300),
('TP001', 'Tepung Terigu', 'Kotak', '15KG', 300000, 7);

-- --------------------------------------------------------

--
-- Struktur untuk view `relasipenjualan`
--
DROP TABLE IF EXISTS `relasipenjualan`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `relasipenjualan`  AS SELECT `tbl_jual`.`id_jual` AS `id_jual`, `tbl_jual`.`nomorFaktur` AS `nomorFaktur`, `tbl_faktur`.`tanggalJual` AS `tanggalJual`, `tbl_faktur`.`Deskripsi` AS `Deskripsi`, `tbl_jual`.`kodeProduk` AS `kodeProduk`, `tbl_produk`.`namaProduk` AS `namaProduk`, `tbl_produk`.`kemasan` AS `kemasan`, `tbl_produk`.`ukuran` AS `ukuran`, `tbl_produk`.`hargaBeli` AS `hargaBeli`, `tbl_produk`.`persediaan` AS `persediaan`, `tbl_jual`.`kodePelanggan` AS `kodePelanggan`, `tbl_pelanggan`.`nama` AS `nama`, `tbl_pelanggan`.`alamat` AS `alamat`, `tbl_pelanggan`.`telepon` AS `telepon`, `tbl_jual`.`jumlahJual` AS `jumlahJual`, `tbl_jual`.`hargaJual` AS `hargaJual`, `tbl_jual`.`bayar` AS `bayar`, `tbl_jual`.`kembalian` AS `kembalian`, `tbl_jual`.`total` AS `total` FROM (((`tbl_jual` join `tbl_faktur`) join `tbl_produk`) join `tbl_pelanggan`) WHERE `tbl_jual`.`nomorFaktur` = `tbl_faktur`.`nomorFaktur` AND `tbl_jual`.`kodeProduk` = `tbl_produk`.`kodeProduk` AND `tbl_jual`.`kodePelanggan` = `tbl_pelanggan`.`kodePelanggan` ;

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbl_faktur`
--
ALTER TABLE `tbl_faktur`
  ADD PRIMARY KEY (`nomorFaktur`),
  ADD UNIQUE KEY `kodePelanggan` (`kodePelanggan`);

--
-- Indeks untuk tabel `tbl_jual`
--
ALTER TABLE `tbl_jual`
  ADD PRIMARY KEY (`id_jual`);

--
-- Indeks untuk tabel `tbl_pelanggan`
--
ALTER TABLE `tbl_pelanggan`
  ADD PRIMARY KEY (`kodePelanggan`);

--
-- Indeks untuk tabel `tbl_produk`
--
ALTER TABLE `tbl_produk`
  ADD PRIMARY KEY (`kodeProduk`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `tbl_jual`
--
ALTER TABLE `tbl_jual`
  MODIFY `id_jual` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tbl_faktur`
--
ALTER TABLE `tbl_faktur`
  ADD CONSTRAINT `tbl_faktur_ibfk_1` FOREIGN KEY (`kodePelanggan`) REFERENCES `tbl_pelanggan` (`kodePelanggan`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
