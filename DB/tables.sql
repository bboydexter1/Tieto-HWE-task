CREATE TABLE `wather`
(
  `id` int PRIMARY KEY,
  `measurement_date` date NOT NULL,
  `city_id` int NOT NULL,
  `celsius` int NOT NULL,
  `pressure` int,
  `humidity` int,
  `wind_speed` float,
  `clouds_id` int
);

CREATE TABLE `cities`
(
  `id` int PRIMARY KEY,
  `name` varchar(50),
  `province_id` int
);

CREATE TABLE `provinces`
(
  `id` int PRIMARY KEY,
  `name` varchar(50),
  `country_id` int
);

CREATE TABLE `countries`
(
  `id` int PRIMARY KEY,
  `name` varchar(50)
);

CREATE TABLE `clouds`
(
  `id` int PRIMARY KEY,
  `name` varchar(255)
);

ALTER TABLE `wather` ADD FOREIGN KEY (`city_id`) REFERENCES `cities` (`id`);

ALTER TABLE `wather` ADD FOREIGN KEY (`clouds_id`) REFERENCES `clouds` (`id`);

ALTER TABLE `cities` ADD FOREIGN KEY (`province_id`) REFERENCES `provinces` (`id`);

ALTER TABLE `provinces` ADD FOREIGN KEY (`country_id`) REFERENCES `countries` (`id`);

