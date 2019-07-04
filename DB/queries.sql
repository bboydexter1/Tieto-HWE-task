--display today's weather
SELECT wather.celsius , wather.Pressure , wather.Humidity , wather.wind_speed , clouds.name FROM wather
INNER JOIN clouds ON wather.clouds_id = clouds.id WHERE (SELECT id FROM cities WHERE name = 'Szczecin') = wather.city_id
--add new entry 
INSERT INTO wather (id, measurement_date, city_id , celsius, pressure , humidity , wind_speed, clouds_id)
VALUES (5, NOW(), 3 , 19 , 1018 , 52 , 8.5 ,2);
--change existing entry
UPDATE wather
SET pressure = 1000, wind_speed = 4
WHERE id = 5;
--delete one entry 
DELETE FROM wather WHERE celsius = 19 AND city_id = (SELECT id FROM cities WHERE name = 'Szczecin')



