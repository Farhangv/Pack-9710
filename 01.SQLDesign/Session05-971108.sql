USE AdventureWorks2016
----------------
SELECT ProductId, Name, 
(
	SELECT Name
	FROM Production.ProductSubcategory psc
	WHERE p.ProductSubCategoryId = psc.ProductSubcategoryID
) 'SubCatName'
FROM Production.Product p
---------------
SELECT BusinessEntityId ,
(
	SELECT FirstName
	FROM Person.Person p
	WHERE p.BusinessEntityID = e.BusinessEntityID
) 'Name',
(
	SELECT LastName
	FROM Person.Person p
	WHERE p.BusinessEntityID = e.BusinessEntityID
) 'Family', 
HireDate,
YEAR(GETDATE()) - YEAR(HireDate) 'Experience'
FROM HumanResources.Employee e
-------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE ProductId =
(
	SELECT TOP 1
	ProductId 
	FROM Sales.SalesOrderDetail
	ORDER BY UnitPrice, ProductId
)
-------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE ListPrice =
(
	SELECT MIN(UnitPrice)
	FROM Sales.SalesOrderDetail
)
-------------------
SELECT AVG(SUM(OrderQty))
FROM Sales.SalesOrderDetail
GROUP BY ProductId
-------------------
SELECT ROW_NUMBER() OVER (ORDER BY ProductId) 'Row', ProductId, Name, Color
FROM Production.Product
WHERE ROW_NUMBER() OVER (ORDER BY ProductId) BETWEEN 1 AND 10
-------------------
SELECT *
FROM (
SELECT DENSE_RANK() OVER (ORDER BY ListPrice DESC) 'Rank', Name, ListPrice, Color
FROM Production.Product) src
WHERE [Rank] = 2
-------------------
SELECT AVG([Sum])
FROM
(
SELECT ProductId,SUM(OrderQty) 'Sum'
FROM Sales.SalesOrderDetail
GROUP BY ProductId
) src
-------------------
WITH src
AS
(
SELECT ProductId,SUM(OrderQty) 'Sum'
FROM Sales.SalesOrderDetail
GROUP BY ProductId
)
SELECT AVG([Sum]) FROM src
---------------------
SELECT p.Name, p.Color ,OrderQty, UnitPrice, UnitPriceDiscount * 100 'Discount', LineTotal
FROM Sales.SalesOrderDetail s
INNER JOIN Production.Product p
ON s.ProductID = p.ProductID
WHERE SalesOrderID = 55439
---------------------
SELECT p.Name, s.Name 'SubCatName', c.Name 'CatName'
FROM Production.Product p 
INNER JOIN Production.ProductSubcategory s
ON p.ProductSubcategoryID = s.ProductSubcategoryID
INNER JOIN Production.ProductCategory c
ON s.ProductCategoryID = c.ProductCategoryID
---------------------
SELECT p.Name, s.Name 'SubCatName'
FROM Production.Product p 
LEFT OUTER JOIN Production.ProductSubcategory s
ON p.ProductSubcategoryID = s.ProductSubcategoryID
---------------------
SELECT p.Name, s.Name 'SubCatName'
FROM Production.Product p 
RIGHT OUTER JOIN Production.ProductSubcategory s
ON p.ProductSubcategoryID = s.ProductSubcategoryID
---------------------
SELECT p.Name, s.Name 'SubCatName'
FROM Production.Product p 
FULL OUTER JOIN Production.ProductSubcategory s
ON p.ProductSubcategoryID = s.ProductSubcategoryID
---------------------
SELECT p.ProductId, p.Name, SUM(s.OrderQty) 'TotalQty'
FROM Sales.SalesOrderDetail s
RIGHT OUTER JOIN Production.Product p
ON s.ProductID = p.ProductID
GROUP BY p.ProductId, p.Name
---------------------
SELECT p.ProductId, p.Name, SUM(s.OrderQty) 'TotalQty'
FROM Production.Product p
RIGHT OUTER JOIN Sales.SalesOrderDetail s
ON s.ProductID = p.ProductID
GROUP BY p.ProductId, p.Name
----------------------
SELECT sc.Name, FORMAT(SUM(s.OrderQty), '###,#') 'TotalQty'
FROM Production.ProductSubcategory sc
INNER JOIN Production.Product p 
ON sc.ProductSubcategoryID = p.ProductSubcategoryID
LEFT OUTER JOIN Sales.SalesOrderDetail s
ON p.ProductID = s.ProductID
GROUP BY sc.Name
----------------------
SELECT c.Name 'CatName', FORMAT(SUM(s.OrderQty), '###,#') 'TotalQty'
FROM Production.ProductCategory c
INNER JOIN Production.ProductSubcategory sc
ON c.ProductCategoryID = sc.ProductCategoryID
INNER JOIN Production.Product p
ON sc.ProductSubcategoryID = p.ProductSubcategoryID
INNER JOIN Sales.SalesOrderDetail s
ON p.ProductID = s.ProductID
GROUP BY c.Name
----------------------------
CREATE DATABASE Session05
----------------------------
USE Session05
----------------------------
CREATE TABLE Team
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(50)
)
----------------------------
ALTER TABLE Team
ADD [Group] CHAR(1)
----------------------------
INSERT INTO Team VALUES('Iran', 'D')
,('Oman', 'D'),('Vietnam', 'D'),('Iraq', 'D')
,('KSA', 'B'),('Qatar', 'B'),('Japan', 'B'), ('UAE', 'B')
-----------------------------
SELECT * FROM Team
-----------------------------
SELECT t1.Name 'Team1', t2.Name 'Team2'
FROM Team t1
CROSS JOIN Team t2
WHERE t1.[Group] = 'D' AND t2.[Group] = 'D'
AND t1.Id <> t2.Id
-----------------------------
CREATE TABLE Course
(
	ID INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(50)
)
---------------
CREATE TABLE Student
(
	ID INT IDENTITY PRIMARY KEY,
	FullName NVARCHAR(50)
)
----------------
INSERT INTO Student VALUES('John Doe'), ('Ross Geller'), ('Joey Tribianni')
----------------
INSERT INTO Course VALUES('SQL Server'), ('Software Engineering'), ('C#'), ('Math')
----------------
SELECT s.FullName, c.Name
FROM Student s
CROSS JOIN Course c
----------------
CREATE TABLE Employee
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50),
	ManagerId INT
)
---------------
SELECT e.Name 'EmployeeName', m.Name 'ManagerName'
FROM Employee e
FULL OUTER JOIN Employee m
ON e.ManagerId = m.Id
---------------
USE AdventureWorks2016
---------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE Color = 'Blue'
--UNION
--UNION ALL
--INTERSECT
EXCEPT
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE ListPrice >= 1000

