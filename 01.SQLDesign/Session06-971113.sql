USE AdventureWorks2016
----------------
SELECT * 
FROM INFORMATION_SCHEMA.COLUMNS
----------------
SELECT * 
FROM INFORMATION_SCHEMA.COLUMNS
WHERE COLUMN_NAME = 'Color'
----------------
SELECT 'John' + ' Doe'
----------------
SELECT FirstName + ' ' + MiddleName + ' ' + LastName
FROM Person.Person
WHERE PersonType = 'EM'
----------------
SELECT FirstName + ' ' + MiddleName + ' ' + LastName
FROM Person.Person
WHERE PersonType = 'EM'
----------------
SELECT CONCAT(FirstName , ' ' , MiddleName, ' ', LastName)
FROM Person.Person
WHERE PersonType = 'EM'
----------------
SELECT SUBSTRING('Salaaam', 1, 3)
----------------
SELECT SUBSTRING('Salaaam', 3, 3)
----------------
SELECT CHARINDEX('?', 'Salam,Chetori? Khoobi?')
----------------
DECLARE @Text NVARCHAR(50)
SET @Text = 'Salam,Chetori? -Merci Khoobam'
SELECT  SUBSTRING(
	@Text, 
	CHARINDEX('?', @Text) + 1, 
	LEN(@Text) - CHARINDEX('?', @Text) + 1
)
----------------
SELECT * FROM Production.Product
----------------
SELECT REPLACE('1397 11 13', ' ', '/')
----------------
SELECT REPLICATE('1', 10)
----------------
SELECT LEN('Salam')
----------------
SELECT UPPER(Name) 'Upper', Name , LOWER(Name) 'Lower'
FROM Production.Product

---------------
SELECT '               Salam', LTRIM('               Salam')
---------------
SELECT 'Salam          ' + 'Chetori?', RTRIM('Salam          ') + 'Chetori?'
---------------
SELECT *
FROM Production.Product 
WHERE Color IS NULL
---------------
SELECT Name, ISNULL(Color, '[NoColor]') 'Color', ListPrice
FROM Production.Product
---------------
SELECT ProductId, Name, 
CASE Color
WHEN 'Black' THEN N'مشکی'
WHEN 'Blue'  THEN N'آبی'
WHEN 'Red' THEN N'قرمز'
ELSE N'سایر رنگ های'
END 'Color'
FROM Production.Product
----------------
SELECT ProductId, Name, ListPrice,
CASE 
WHEN ListPrice > 1000 AND Color = 'Red' THEN N'گران'
WHEN ListPrice > 500 THEN N'متوسط'
ELSE N'ارزان'
END 'PriceRange'
FROM Production.Product
----------------
SELECT sc.Name 'SubCatName', SUM(s.OrderQty) 'TotalSales'
FROM Production.ProductSubcategory sc
INNER JOIN Production.Product p
ON sc.ProductSubcategoryID = p.ProductSubcategoryID
INNER JOIN Sales.SalesOrderDetail s
ON p.ProductID = s.ProductID
GROUP BY sc.Name
----------------
SELECT sc.Name 'SubCatName', 
CASE
WHEN SUM(s.OrderQty) >= 5000 THEN N'پرفروش'
WHEN SUM(s.OrderQty) >= 1000 THEN N'فروش متوسط'
ELSE N'کم فروش'
END 'TotalSales'
FROM Production.ProductSubcategory sc
INNER JOIN Production.Product p
ON sc.ProductSubcategoryID = p.ProductSubcategoryID
INNER JOIN Sales.SalesOrderDetail s
ON p.ProductID = s.ProductID
GROUP BY sc.Name
-----------------
SELECT GETDATE(), SYSDATETIME(), SYSDATETIMEOFFSET()
-----------------
SELECT DATEPART(YEAR, GETDATE()),  DATEPART(MONTH, GETDATE()), DATEPART(DAY, GETDATE()),
DATEPART(HOUR, GETDATE()), DATEPART(MINUTE, GETDATE()), DATEPART(SECOND, GETDATE()),
DATEPART(MILLISECOND, GETDATE())
-----------------
SELECT YEAR(GETDATE()),  MONTH(GETDATE()), DAY(GETDATE())
-----------------
SELECT BusinessEntityID, YEAR(GETDATE()) - YEAR(BirthDate) 'Age'
FROM HumanResources.Employee
-----------------
SELECT GETDATE() ,DATEADD(DAY, 10, GETDATE()), DATEADD(MONTH, -3, GETDATE())
-----------------
SELECT DATEDIFF(DAY, '2018/06/12 00:00:00', GETDATE())
-----------------
SELECT SWITCHOFFSET(SYSDATETIMEOFFSET(), '-05:30')
-----------------
SELECT TODATETIMEOFFSET(GETDATE(), '-05:30')
-----------------
--DML
--Create Retrive Update Delete
--CRUD Operations
-----------------
CREATE DATABASE Session06
-----------------
USE Session06
-----------------
CREATE TABLE Student
(
	Id INT PRIMARY KEY,
	Name NVARCHAR(50),
	Family NVARCHAR(50),
	BirthDate DATETIME
)
----------------
SELECT * FROM Student
----------------
INSERT INTO Student(Id, Name, Family, BirthDate)
VALUES(1, 'John', 'Doe', '1980-10-10 00:00:00')
----------------
INSERT INTO Student(Id, Name, Family, BirthDate)
VALUES(2, 'Joey', 'Tribbiani', '1970-10-10 00:00:00'),
      (3, 'Ross', 'Geller', '1960-10-10 00:00:00')
----------------
INSERT INTO Student
VALUES('Monica', 'Geller', '1950-10-10 00:00:00')
----------------SELECT...INTO
SELECT ProductId, Name, Color, ListPrice
INTO Product --جدول مقصد
FROM AdventureWorks2016.Production.Product
WHERE ListPrice != 0
-----------------INSERT...SELECT
INSERT INTO Student(Id, Name, Family, BirthDate)
SELECT p.BusinessEntityId, FirstName, LastName, BirthDate
FROM AdventureWorks2016.Person.Person p
LEFT OUTER JOIN AdventureWorks2016.HumanResources.Employee e
ON p.BusinessEntityID = e.BusinessEntityID
------------------
TRUNCATE TABLE Student
------------------
SELECT * FROM Student
------------------
UPDATE Student 
SET Name = 'Chandler', Family = 'Bing'
WHERE Id = 1
------------------
UPDATE Student 
SET Name = 'Rachel', Family = 'Green'
------------------
DELETE FROM Student
WHERE Id = 1
------------------
SELECT * 
INTO Sales
FROM AdventureWorks2016.Sales.SalesOrderDetail
------------------
SELECT * FROM Sales
------------------
DELETE FROM Sales
------------------
DROP TABLE Sales
------------------
SELECT * 
INTO Sales
FROM AdventureWorks2016.Sales.SalesOrderDetail
------------------
TRUNCATE TABLE Sales

