/* �������� � ���������� �������� �������� */
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
--('�������� ���������', 1, 150, 120),
--('�������� ��������', 1, 150, 120),
--('�����', 1, 150, 120),
--('���������(������ 160)', 1, 80, 60),
--('���������(������ 180)', 1, 100, 80),
--('���������(������ 200)', 1, 120, 100),
--('��������(������ 180)', 1, 100, 80),
--('��������(������ 200)', 1, 120, 100)
--GO

--SELECT * FROM remain
--GO

--DELETE remain
--GO

--DROP TABLE remain
--GO