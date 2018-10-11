/* Создание процедуры добавления операции */

USE db_Shop
GO

create procedure InsertTableOperations
@position_id INT,
@operation_type CHAR(25),
@position CHAR(25),
@quantity int,
@price int,
@first_price int
as begin



INSERT INTO operations VALUES
(@position_id,
SYSDATETIME(),
@operation_type,
@position,
@quantity,
@price,
@price*@quantity,
@first_price)


END