/* Создание процедуры добавления товара */

USE db_Shop
GO

create procedure InsertNewPosition
@position CHAR(25),
@quantity int,
@price int,
@first_price int
as begin


INSERT INTO remain VALUES
(@position,
@quantity,
@price,
@first_price)


END