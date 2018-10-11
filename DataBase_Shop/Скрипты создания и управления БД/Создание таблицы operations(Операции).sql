/* Создание и управление Таблицей операций */

USE db_Shop
GO

CREATE TABLE operations
(id INT NOT NULL IDENTITY(1,1),
position_id INT,
oper_date datetime NOT NULL,
operation_type CHAR(25),
position CHAR(25),
quantity int,
price int,
summ_price int,
first_price int)
GO

--ALTER TABLE operations ADD CONSTRAINT position_unique UNIQUE (position);

--INSERT INTO operations VALUES
--(1, '2018-08-10 17:24:16.033', '1', '1', 1, 1, 1, 1)
--GO

--SELECT * FROM operations
--GO

--DELETE operations
--GO

--DROP TABLE operations
--GO