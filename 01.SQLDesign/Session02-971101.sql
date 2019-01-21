SEleCT 123
select 'hello'
SELECT 'سلام'
SEleCT 123 + 10
SELECT '123' + '10'
SELECT N'سلام'
-----------------
--توضیحات
-----------------
SELECT @@CONNECTIONS
-----------------
SELECT @@LANGUAGE
-----------------
SELECT @@SPID
-----------------
SELECT GETDATE()
-----------------
SELECT SYSDATETIME()
-----------------
SELECT SYSDATETIMEOFFSET()
-----------------
DECLARE @Name NVARCHAR(50)
SELECT @Name = 'John'
SELECT @Name
-----------------
USE AdventureWorks2016
-----------------
SELECT * 
FROM Production.Product
-----------------
SELECT NEWID()
-----------------
SELECT * 
FROM Sales.SalesOrderHeader
-----------------
SELECT * 
FROM Sales.SalesOrderDetail
-----------------
SELECT *
FROM Sales.SalesOrderHeader
-----------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
-----------------
SELECT ProductID,[Name],Color
FROM Production.Product
-----------------
SELECT Name AS ProductName
FROM Production.Product
-----------------
SELECT Name AS 'Product Name'
FROM Production.Product
-----------------
SELECT Name 'نام محصول', Color 'رنگ', ListPrice 'قیمت فروش'
FROM Production.Product
-----------------
SELECT ProductId, Name, Color
FROM Production.Product
ORDER BY Name
-----------------
SELECT ProductId, Name, Color
FROM Production.Product
ORDER BY Name DESC
-----------------
SELECT ProductId, Name, Color
FROM Production.Product
ORDER BY Color DESC, Name
-----------------
SELECT DISTINCT *
FROM Production.Product
-----------------
SELECT DISTINCT Name
FROM Production.Product
-----------------
SELECT DISTINCT Color
FROM Production.Product
-----------------
SELECT DISTINCT ListPrice
FROM Production.Product
-----------------



