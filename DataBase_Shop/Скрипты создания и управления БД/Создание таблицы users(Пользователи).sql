/* Создание и управление Таблицей пользователей */

USE db_Shop
GO

CREATE TABLE users
(user_id INT NOT NULL IDENTITY(1,1),
user_name VARCHAR(25) UNIQUE NOT NULL,
password VARCHAR(25) NOT NULL,
isadmin BIT NOT NULL,
iskassir BIT NOT NULL,
status int NOT NULL)
GO

--INSERT INTO users VALUES
--('kassir', 'kassir', 0, 1, 1),
--('admin', 'admin', 1, 1, 1)
--GO

--ALTER TABLE users ADD CONSTRAINT user_unique UNIQUE (user_name);

--SELECT * FROM users
--GO

--DELETE users 
--GO

--DROP TABLE users
--GO