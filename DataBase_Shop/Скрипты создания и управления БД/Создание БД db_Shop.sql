USE master ;  
GO

CREATE DATABASE db_Shop  
ON   
( NAME = Store_dat,  
    FILENAME = 'C:\DataBase_Shop\db_Shopdat.mdf',  
    SIZE = 10,  
    MAXSIZE = 50,  
    FILEGROWTH = 5 )  
LOG ON  
( NAME = Sale_log,  
    FILENAME = 'C:\DataBase_Shop\db_Shoplog.ldf',  
    SIZE = 5MB,  
    MAXSIZE = 25MB,  
    FILEGROWTH = 5MB ) ;  
GO

USE db_Shop
GO