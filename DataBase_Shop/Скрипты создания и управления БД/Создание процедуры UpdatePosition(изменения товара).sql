/* Создание процедуры изменения товара */

USE db_Shop
GO

create procedure UpdatePosition
@id int,
@position CHAR(25),
@quantity int,
@price int,
@first_price int
as begin


UPDATE remain
SET
position = @position,
quantity = @quantity,
price = @price,
first_price = @first_price

WHERE id = @id


END