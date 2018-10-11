/* Создание процедуры удаления товара */

USE db_Shop
GO

create procedure DeletePosition
@id int
as begin


DELETE remain WHERE
id = @id


END