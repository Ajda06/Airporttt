-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Време на генериране: 11 юли 2024 в 19:00
-- Версия на сървъра: 10.4.32-MariaDB
-- Версия на PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данни: `airportdb`
--

-- --------------------------------------------------------

--
-- Структура на таблица `aircrafttypes`
--

CREATE TABLE `aircrafttypes` (
  `AircraftTypeID` int(11) NOT NULL,
  `AircraftTypeName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Схема на данните от таблица `aircrafttypes`
--

INSERT INTO `aircrafttypes` (`AircraftTypeID`, `AircraftTypeName`) VALUES
(1, 'Boeing 737'),
(2, 'Airbus A320'),
(3, 'Boeing 747'),
(4, 'Airbus A380'),
(5, 'Embraer 190'),
(6, 'ATR 72'),
(7, 'Boeing 787 Dreamliner'),
(8, 'Lockheed Martin C-130 Hercules'),
(9, 'McDonnell Douglas MD-80'),
(10, 'Gulfstream G650'),
(11, 'Cessna 172'),
(12, 'Pilatus PC-12'),
(13, 'Tupolev Tu-154'),
(14, 'Bombardier Challenger 350'),
(15, 'Douglas DC-'),
(16, 'Dassault Falcon 7X'),
(17, 'Northrop Grumman B-2 Spirit'),
(18, 'Boeing KC-135 Stratotanker'),
(19, 'Antonov An-225 Mriya'),
(20, 'Lockheed SR-71 Blackbird');

-- --------------------------------------------------------

--
-- Структура на таблица `airlines`
--

CREATE TABLE `airlines` (
  `airline_id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `country` varchar(100) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Схема на данните от таблица `airlines`
--

INSERT INTO `airlines` (`airline_id`, `name`, `country`, `created_at`, `updated_at`) VALUES
(1, 'България Ер', 'България', '2024-06-29 12:10:25', '2024-06-29 12:10:25'),
(2, 'Wizz Air', 'Унгария', '2024-06-29 12:10:25', '2024-06-29 12:10:25'),
(3, 'Ryanair', 'Ирландия', '2024-06-29 12:10:25', '2024-06-29 12:10:25'),
(4, 'EasyJet', 'Обединеното кралство', '2024-06-29 12:10:25', '2024-06-29 12:10:25'),
(5, 'Турски Авиолинии (Turkish Airlines)', 'Турция', '2024-06-29 12:10:25', '2024-06-29 12:10:25'),
(6, 'Hamburg International', 'Германия', '2024-06-29 12:10:25', '2024-06-29 12:10:25'),
(7, 'Air France', 'Франция', '2024-06-29 12:10:25', '2024-06-29 12:10:25'),
(8, 'Pegasus Airlines', 'Турция', '2024-06-29 12:10:25', '2024-06-29 12:10:25'),
(9, 'Lufthansa', 'Германия', '2024-06-29 12:10:25', '2024-06-29 12:10:25'),
(10, 'British Airways', 'Обединеното кралство', '2024-06-29 12:10:25', '2024-06-29 12:10:25'),
(11, 'Austrian Airlines', 'Австрия', '2024-06-29 12:10:25', '2024-06-29 12:10:25'),
(12, 'Swiss International Air Lines', 'Швейцария', '2024-06-29 12:10:25', '2024-06-29 12:10:25'),
(13, 'KLM', 'Нидерландия', '2024-06-29 12:10:25', '2024-06-29 12:10:25'),
(14, 'Emirates', 'ОАЕ', '2024-06-29 12:10:25', '2024-06-29 12:10:25'),
(15, 'Qatar Airways', 'Катар', '2024-06-29 12:10:25', '2024-06-29 12:10:25'),
(16, 'Aeroflot', 'Русия', '2024-06-29 12:10:25', '2024-06-29 12:10:25'),
(17, 'Scandinavian Airlines', 'Швеция', '2024-06-29 12:10:25', '2024-06-29 12:10:25'),
(18, 'Alitalia', 'Италия', '2024-06-29 12:10:25', '2024-06-29 12:10:25'),
(19, 'Iberia', 'Испания', '2024-06-29 12:10:25', '2024-06-29 12:10:25'),
(20, 'Finnair', 'Финландия', '2024-06-29 12:10:25', '2024-06-29 12:10:25');

-- --------------------------------------------------------

--
-- Структура на таблица `airports`
--

CREATE TABLE `airports` (
  `airport_id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `city` varchar(100) NOT NULL,
  `country` varchar(100) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Схема на данните от таблица `airports`
--

INSERT INTO `airports` (`airport_id`, `name`, `city`, `country`, `created_at`, `updated_at`) VALUES
(1, 'Sofia Airport', 'София', 'България', '2024-06-29 12:11:35', '2024-06-29 12:11:35'),
(2, 'London Heathrow Airport', 'Лондон', 'Обединеното кралство', '2024-06-29 12:11:35', '2024-06-29 12:11:35'),
(3, 'Paris Charles de Gaulle Airport', 'Париж', 'Франция', '2024-06-29 12:11:35', '2024-06-29 12:11:35'),
(4, 'Frankfurt Airport', 'Франкфурт', 'Германия', '2024-06-29 12:11:35', '2024-06-29 12:11:35'),
(5, 'Istanbul Airport', 'Истанбул', 'Турция', '2024-06-29 12:11:35', '2024-06-29 12:11:35'),
(6, 'Amsterdam Airport Schiphol', 'Амстердам', 'Нидерландия', '2024-06-29 12:11:35', '2024-06-29 12:11:35'),
(7, 'Dubai International Airport', 'Дубай', 'Обединените арабски емирства', '2024-06-29 12:11:35', '2024-06-29 12:11:35'),
(8, 'Los Angeles International Airport', 'Лос Анджелис', 'САЩ', '2024-06-29 12:11:35', '2024-06-29 12:11:35');

-- --------------------------------------------------------

--
-- Структура на таблица `customers`
--

CREATE TABLE `customers` (
  `CustomerID` int(11) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `username` varchar(11) NOT NULL,
  `password` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Схема на данните от таблица `customers`
--

INSERT INTO `customers` (`CustomerID`, `FirstName`, `LastName`, `Email`, `username`, `password`) VALUES
(1, 'Ajda', 'Velieva', 'ajda@11', 'ajda', 123),
(2, 'Emily', 'Thompson', 'emi@19', 'emily', 111),
(3, 'David', 'Johnson', 'david@11', 'david', 433),
(4, 'Michael', 'Robinson', 'mike@11', 'mike', 921);

-- --------------------------------------------------------

--
-- Структура на таблица `flightaircraft`
--

CREATE TABLE `flightaircraft` (
  `flight_id` int(11) NOT NULL,
  `AircraftTypeID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Схема на данните от таблица `flightaircraft`
--

INSERT INTO `flightaircraft` (`flight_id`, `AircraftTypeID`) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5);

-- --------------------------------------------------------

--
-- Структура на таблица `flights`
--

CREATE TABLE `flights` (
  `flight_id` int(11) NOT NULL,
  `airline` varchar(100) NOT NULL,
  `flight_number` varchar(20) NOT NULL,
  `departure_airport` varchar(100) NOT NULL,
  `arrival_airport` varchar(100) NOT NULL,
  `departure_datetime` datetime NOT NULL,
  `arrival_datetime` datetime NOT NULL,
  `status` enum('Scheduled','On Time','Delayed','Cancelled') NOT NULL DEFAULT 'Scheduled',
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Схема на данните от таблица `flights`
--

INSERT INTO `flights` (`flight_id`, `airline`, `flight_number`, `departure_airport`, `arrival_airport`, `departure_datetime`, `arrival_datetime`, `status`, `created_at`, `updated_at`) VALUES
(1, 'България ЕР', 'BG1001', 'София', 'Лондон', '2024-07-01 08:00:00', '2024-07-01 10:00:00', 'On Time', '2024-07-02 11:09:21', '2024-07-11 16:46:19'),
(2, 'Wizz Air', 'WZ2002', 'София', 'Милано', '2024-07-02 12:00:00', '2024-07-02 14:00:00', 'Scheduled', '2024-07-02 11:09:21', '2024-07-11 16:46:34'),
(3, 'Ryanair', 'RY3003', 'София', 'Барселона', '2024-07-03 16:00:00', '2024-07-03 18:00:00', 'Scheduled', '2024-07-02 11:09:21', '2024-07-11 16:46:45'),
(4, 'EasyJet', 'EZ4004', 'София', 'Берлин', '2024-07-04 10:00:00', '2024-07-04 12:00:00', 'Scheduled', '2024-07-02 11:09:21', '2024-07-11 16:46:58'),
(5, 'Турски Авиолинии', 'TK5005', 'София', 'Истанбул', '2024-07-05 14:00:00', '2024-07-05 15:30:00', 'Scheduled', '2024-07-02 11:09:21', '2024-07-11 16:47:11'),
(6, 'Hamburg International', 'HI6006', 'София', 'Хамбург', '2024-07-06 06:00:00', '2024-07-06 08:30:00', 'Scheduled', '2024-07-02 11:09:21', '2024-07-11 16:47:22'),
(7, 'Air France', 'AF7007', 'София', 'Париж', '2024-07-07 09:00:00', '2024-07-07 11:30:00', 'Scheduled', '2024-07-02 11:09:21', '2024-07-11 16:47:34'),
(8, 'Pegasus Airlines', 'PG8008', 'София', 'Анкара', '2024-07-08 13:00:00', '2024-07-08 15:00:00', 'Scheduled', '2024-07-02 11:09:21', '2024-07-11 16:50:46'),
(9, 'Lufthansa', 'LH9009', 'София', 'Франкфурт', '2024-07-09 11:00:00', '2024-07-09 13:00:00', 'Scheduled', '2024-07-09 12:00:00', '2024-07-11 16:50:28'),
(10, 'British Airways', 'BA1010', 'София', 'Лондон', '2024-07-10 15:00:00', '2024-07-10 17:00:00', 'Scheduled', '2024-07-10 12:00:00', '2024-07-11 16:49:08'),
(11, 'Austrian Airlines', 'OS1111', 'София', 'Виена', '2024-07-11 07:00:00', '2024-07-11 08:30:00', 'Scheduled', '2024-07-11 12:00:00', '2024-07-11 16:50:12'),
(12, 'Swiss International Air Lines', 'LX1212', 'София', 'Цюрих', '2024-07-12 16:00:00', '2024-07-12 18:30:00', 'Scheduled', '2024-07-12 12:00:00', '2024-07-11 16:49:28'),
(13, 'KLM', 'KL1313', 'София', 'Амстердам', '2024-07-13 12:00:00', '2024-07-13 14:00:00', 'Scheduled', '2024-07-13 12:00:00', '2024-07-11 16:49:42'),
(14, 'Emirates', 'EK1414', 'София', 'Дубай', '2024-07-14 23:00:00', '2024-07-15 04:00:00', 'Scheduled', '2024-07-14 12:00:00', '2024-07-11 16:49:57'),
(15, 'Qatar Airways', 'QR1515', 'София', 'Доха', '2024-07-15 01:00:00', '2024-07-15 05:00:00', 'Scheduled', '2024-07-15 12:00:00', '2024-07-11 16:48:55'),
(16, 'Aeroflot', 'SU1616', 'София', 'Москва', '2024-07-16 05:00:00', '2024-07-16 09:00:00', 'Scheduled', '2024-07-16 12:00:00', '2024-07-11 16:48:41'),
(17, 'Scandinavian Airlines', 'SK1717', 'София', 'Копенхаген', '2024-07-17 14:00:00', '2024-07-17 16:30:00', 'Scheduled', '2024-07-17 12:00:00', '2024-07-11 16:48:29'),
(18, 'Alitalia', 'AZ1818', 'София', 'Рим', '2024-07-18 10:00:00', '2024-07-18 12:00:00', 'Scheduled', '2024-07-18 12:00:00', '2024-07-11 16:48:15'),
(19, 'Iberia', 'IB1919', 'София', 'Мадрид', '2024-07-19 06:00:00', '2024-07-19 08:30:00', 'Scheduled', '2024-07-19 12:00:00', '2024-07-11 16:48:02'),
(20, 'Finnair', 'AY2020', 'София', 'Хелзинки', '2024-07-20 09:00:00', '2024-07-20 11:30:00', 'Scheduled', '2024-07-20 12:00:00', '2024-07-11 16:47:48');

-- --------------------------------------------------------

--
-- Структура на таблица `passengers`
--

CREATE TABLE `passengers` (
  `passenger_id` int(11) NOT NULL,
  `first_name` varchar(100) NOT NULL,
  `last_name` varchar(100) NOT NULL,
  `gender` enum('Male','Female','Other') NOT NULL,
  `date_of_birth` date NOT NULL,
  `passport_number` varchar(20) NOT NULL,
  `nationality` varchar(100) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Схема на данните от таблица `passengers`
--

INSERT INTO `passengers` (`passenger_id`, `first_name`, `last_name`, `gender`, `date_of_birth`, `passport_number`, `nationality`, `created_at`, `updated_at`) VALUES
(1, 'Калоян', 'Генчев', 'Male', '1999-08-10', '912345678', 'България', '2024-06-29 11:06:46', '2024-07-11 14:53:23'),
(2, 'Неделина', 'Костадинова', 'Female', '2000-07-12', '698765432', 'България', '2024-07-01 11:06:46', '2024-07-01 11:06:46'),
(3, 'Питър', 'Янакиев', 'Other', '1998-01-10', 'BBA567943', 'Испания', '2024-07-01 11:06:46', '2024-07-01 11:06:46');

-- --------------------------------------------------------

--
-- Структура на таблица `seats`
--

CREATE TABLE `seats` (
  `seat_id` int(11) NOT NULL,
  `flight_id` int(11) NOT NULL,
  `seat_number` varchar(10) NOT NULL,
  `passenger_id` int(11) DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Схема на данните от таблица `seats`
--

INSERT INTO `seats` (`seat_id`, `flight_id`, `seat_number`, `passenger_id`, `created_at`, `updated_at`) VALUES
(1, 1, 'A1', 1, '2024-07-02 11:15:12', '2024-07-02 11:15:12'),
(2, 1, 'B2', 2, '2024-07-02 11:15:12', '2024-07-02 11:15:12'),
(3, 2, 'C3', 3, '2024-07-02 11:15:12', '2024-07-02 11:15:12'),
(4, 2, 'D4', NULL, '2024-07-02 11:15:12', '2024-07-02 11:15:12'),
(5, 3, 'E5', NULL, '2024-07-02 11:15:12', '2024-07-02 11:15:12'),
(6, 3, 'F6', 1, '2024-07-02 11:15:12', '2024-07-02 11:15:12'),
(7, 4, 'G7', 2, '2024-07-02 11:15:12', '2024-07-02 11:15:12'),
(8, 4, 'H8', 3, '2024-07-02 11:15:12', '2024-07-02 11:15:12'),
(9, 5, 'I9', NULL, '2024-07-02 11:15:12', '2024-07-02 11:15:12'),
(10, 5, 'J10', 1, '2024-07-02 11:15:12', '2024-07-02 11:15:12');

-- --------------------------------------------------------

--
-- Структура на таблица `tickets`
--

CREATE TABLE `tickets` (
  `TicketID` int(11) NOT NULL,
  `FlightID` int(11) DEFAULT NULL,
  `CustomerID` int(11) DEFAULT NULL,
  `Price` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Схема на данните от таблица `tickets`
--

INSERT INTO `tickets` (`TicketID`, `FlightID`, `CustomerID`, `Price`) VALUES
(21, 1, 1, 200.00),
(22, 2, 2, 150.00),
(23, 3, 3, 300.00),
(24, 4, 4, 250.00);

-- --------------------------------------------------------

--
-- Структура на таблица `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Схема на данните от таблица `users`
--

INSERT INTO `users` (`user_id`, `username`, `password`, `created_at`, `updated_at`) VALUES
(1, 'ajda', '123', '2024-07-08 14:02:30', '2024-07-11 14:50:30'),
(2, 'rali', '456', '2024-07-08 14:02:30', '2024-07-11 14:50:46'),
(3, 'nedelina', '678', '2024-07-08 14:02:30', '2024-07-11 14:51:05'),
(4, 'ani', '900', '2024-07-08 14:02:30', '2024-07-11 14:51:26'),
(6, 'katev', '122', '2024-07-09 09:59:29', '2024-07-11 14:51:16'),
(7, 'ivaila', '999', '2024-07-09 13:20:33', '2024-07-11 14:51:48'),
(8, 'petur', '999', '2024-07-09 13:20:33', '2024-07-11 14:52:08'),
(9, 'todor', '999', '2024-07-09 13:20:33', '2024-07-11 14:51:59'),
(10, 'selin', '999', '2024-07-09 13:20:33', '2024-07-11 14:51:38'),
(11, 'teodor', '999', '2024-07-09 13:20:33', '2024-07-11 14:52:34'),
(12, 'ivan', '999', '2024-07-09 13:20:33', '2024-07-11 14:52:20');

--
-- Indexes for dumped tables
--

--
-- Индекси за таблица `aircrafttypes`
--
ALTER TABLE `aircrafttypes`
  ADD PRIMARY KEY (`AircraftTypeID`);

--
-- Индекси за таблица `airlines`
--
ALTER TABLE `airlines`
  ADD PRIMARY KEY (`airline_id`);

--
-- Индекси за таблица `airports`
--
ALTER TABLE `airports`
  ADD PRIMARY KEY (`airport_id`);

--
-- Индекси за таблица `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`CustomerID`);

--
-- Индекси за таблица `flightaircraft`
--
ALTER TABLE `flightaircraft`
  ADD PRIMARY KEY (`flight_id`,`AircraftTypeID`),
  ADD KEY `AircraftTypeID` (`AircraftTypeID`);

--
-- Индекси за таблица `flights`
--
ALTER TABLE `flights`
  ADD PRIMARY KEY (`flight_id`);

--
-- Индекси за таблица `passengers`
--
ALTER TABLE `passengers`
  ADD PRIMARY KEY (`passenger_id`);

--
-- Индекси за таблица `seats`
--
ALTER TABLE `seats`
  ADD PRIMARY KEY (`seat_id`),
  ADD KEY `flight_id` (`flight_id`);

--
-- Индекси за таблица `tickets`
--
ALTER TABLE `tickets`
  ADD PRIMARY KEY (`TicketID`),
  ADD KEY `FlightID` (`FlightID`),
  ADD KEY `CustomerID` (`CustomerID`);

--
-- Индекси за таблица `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `aircrafttypes`
--
ALTER TABLE `aircrafttypes`
  MODIFY `AircraftTypeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `airlines`
--
ALTER TABLE `airlines`
  MODIFY `airline_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `airports`
--
ALTER TABLE `airports`
  MODIFY `airport_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `CustomerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `flights`
--
ALTER TABLE `flights`
  MODIFY `flight_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `passengers`
--
ALTER TABLE `passengers`
  MODIFY `passenger_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `seats`
--
ALTER TABLE `seats`
  MODIFY `seat_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tickets`
--
ALTER TABLE `tickets`
  MODIFY `TicketID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- Ограничения за дъмпнати таблици
--

--
-- Ограничения за таблица `flightaircraft`
--
ALTER TABLE `flightaircraft`
  ADD CONSTRAINT `flightaircraft_ibfk_1` FOREIGN KEY (`flight_id`) REFERENCES `flightss` (`FlightID`),
  ADD CONSTRAINT `flightaircraft_ibfk_2` FOREIGN KEY (`AircraftTypeID`) REFERENCES `aircrafttypes` (`AircraftTypeID`);

--
-- Ограничения за таблица `tickets`
--
ALTER TABLE `tickets`
  ADD CONSTRAINT `tickets_ibfk_1` FOREIGN KEY (`FlightID`) REFERENCES `flightss` (`FlightID`),
  ADD CONSTRAINT `tickets_ibfk_2` FOREIGN KEY (`CustomerID`) REFERENCES `customers` (`CustomerID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
