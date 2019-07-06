--display today's weather
SELECT weather.celsius , weather.Pressure , weather.Humidity , weather.wind_speed , clouds.name FROM weather
INNER JOIN clouds ON weather.clouds_id = clouds.id WHERE (SELECT id FROM cities WHERE name = 'Szczecin') = weather.city_id
--add new entry 
INSERT INTO weather (id, measurement_date, city_id , celsius, pressure , humidity , wind_speed, clouds_id)
VALUES (5, NOW(), 3 , 19 , 1018 , 52 , 8.5 ,2);
--change existing entry
UPDATE weather
SET pressure = 1000, wind_speed = 4
WHERE id = 5;
--delete one entry 
DELETE FROM weather WHERE celsius = 19 AND city_id = (SELECT id FROM cities WHERE name = 'Szczecin')



