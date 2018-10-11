/* Создание процедуры выполнения продажи(иного движения товара) */

USE db_Shop
GO

create procedure sale
@op_quantity INT,
@op_id INT,
@op_price INT,
@op_type INT
as begin

UPDATE remain
SET quantity =
(
CASE 
	WHEN (@op_type = 1) 
		THEN quantity - @op_quantity
	WHEN (@op_type = 2) 
		THEN quantity + @op_quantity
	WHEN (@op_type = 3) 
		THEN quantity + @op_quantity
	WHEN (@op_type = 4) 
		THEN quantity - @op_quantity
	  
END
)		 
		
WHERE remain.id = @op_id;
	


END