/* Создание и управление Таблицей остатков */
USE db_Shop
GO

CREATE TABLE remain
(id INT NOT NULL IDENTITY(1,1),
position CHAR(25),
quantity int,
price int,
first_price int)
GO

--INSERT INTO remain VALUES
--('Отвертка крестовая', 1, 150, 120),
--('Отвертка шлицевая', 1, 150, 120),
--('Веник', 1, 150, 120),
--('Пассатижи(Размер 160)', 1, 80, 60),
--('Пассатижи(Размер 180)', 1, 100, 80),
--('Пассатижи(Размер 200)', 1, 120, 100),
--('Бокорезы(Размер 180)', 1, 100, 80),
--('Бокорезы(Размер 200)', 1, 120, 100)
--GO

--SELECT * FROM remain
--GO

--DELETE remain
--GO

--DROP TABLE remain
--GO