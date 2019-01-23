USE AdventureWorks2016
--------------
SELECT DISTINCT Color
FROM Production.Product
--------------
SELECT TOP 4 ProductId, Name, Color, ListPrice
FROM Production.Product
ORDER BY ListPrice DESC
--------------
SELECT TOP 25 PERCENT ProductId, Name, Color, ListPrice
FROM Production.Product
ORDER BY ListPrice DESC
-------------
SELECT TOP 4 WITH TIES
ProductId, Name, Color, ListPrice
FROM Production.Product
ORDER BY ListPrice DESC
--------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
ORDER BY ProductID
OFFSET 10 ROWS FETCH NEXT 10 ROWS ONLY
-------------
SELECT TOP 10 ProductId, Name, Color, ListPrice
FROM Production.Product
ORDER BY ProductID
-------------
DECLARE @PageNumber INT
DECLARE @RowsPerPage INT
SET @PageNumber = 3
SET @RowsPerPage = 20
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
ORDER BY ProductID
OFFSET (@PageNumber - 1)*@RowsPerPage ROWS FETCH NEXT @RowsPerPage ROWS ONLY
-------------
SELECT ProductId,Name,Color, ListPrice, StandardCost
FROM Production.Product
WHERE ProductId <= 2
-------------
SELECT ProductId,Name,Color, ListPrice, StandardCost
FROM Production.Product
WHERE ProductId > 900
-------------
SELECT ProductId,Name,Color, ListPrice, StandardCost
FROM Production.Product
WHERE Color = 'Blue'
-------------
SELECT ProductId,Name,Color, ListPrice, StandardCost
FROM Production.Product
WHERE Color != 'Blue'
--------------
SELECT ProductId,Name,Color, ListPrice, StandardCost
FROM Production.Product
WHERE Color = 'Blue' OR Color = 'Red'
ORDER BY Color
--------------
SELECT ProductId,Name,Color, ListPrice, StandardCost
FROM Production.Product
WHERE Color = 'Blue' AND ListPrice > 1000
ORDER BY Color
------------
SELECT ProductId,Name,Color, ListPrice, StandardCost
FROM Production.Product
WHERE Name LIKE 'Touring'
------------
SELECT ProductId,Name,Color, ListPrice, StandardCost
FROM Production.Product
WHERE Name LIKE '%Touring%'
------------
SELECT ProductId,Name,Color, ListPrice, StandardCost
FROM Production.Product
WHERE Name LIKE '__a%'
------------
SELECT TOP 5 ProductId,Name,Color, ListPrice, StandardCost
FROM Production.Product
WHERE Name LIKE '%Touring%'
ORDER BY ListPrice DESC
------------
SELECT ProductId,Name,Color, ListPrice, StandardCost, ListPrice - StandardCost 'Profit'
FROM Production.Product
WHERE ListPrice - StandardCost > 300
ORDER BY Profit DESC
------------
SELECT ProductId,Name,Color, ListPrice, StandardCost
FROM Production.Product
WHERE Color IS NOT NULL
-------------
SELECT ProductId,Name,Color, ListPrice, StandardCost
FROM Production.Product
WHERE ProductID IN ( 4,777,852,999,998 )
--------------
SELECT ProductId,Name,Color, ListPrice, StandardCost
FROM Production.Product
WHERE ProductID = 4 OR ProductID = 777 OR ProductID = 852 OR ProductID = 999 OR ProductID = 998
--------------
SELECT DISTINCT ProductId 
FROM Sales.SalesOrderDetail
--------------
SELECT ProductId,Name,Color, ListPrice, StandardCost
FROM Production.Product
WHERE ProductID IN 
( 
	---کد محصولات فروش رفته
	SELECT DISTINCT ProductId
	FROM Sales.SalesOrderDetail
)
-------------
SELECT *
FROM Production.ProductSubcategory
-------------
SELECT * 
FROM Production.Product
--------------
SELECT ProductId, Name,Color, ListPrice
FROM Production.Product
WHERE ProductSubcategoryID IN
(
	SELECT DISTINCT ProductSubcategoryId
	FROM Production.ProductSubcategory
	WHERE Name LIKE '%Bike%'
)
----------------
SELECT ProductId,Name,Color, ListPrice, StandardCost
FROM Production.Product
WHERE ProductID NOT IN 
( 
	---کد محصولات فروش رفته
	SELECT DISTINCT ProductId
	FROM Sales.SalesOrderDetail
)
------------
SELECT ProductId,Name,Color, ListPrice, StandardCost
FROM Production.Product
-------------
SELECT COUNT(*)
FROM Production.Product
-------------
SELECT COUNT(Color)
FROM Production.Product
-------------
SELECT COUNT(DISTINCT Color)
FROM Production.Product
-------------
SELECT COUNT(ProductId)
FROM Production.Product
WHERE Color = 'Blue'
-------------
SELECT COUNT(*)
FROM Production.Product
WHERE Color = 'Blue'
-------------
SELECT SUM(UnitPrice * (1 - UnitPriceDiscount) * OrderQty) 'Total Sales Amount'
FROM Sales.SalesOrderDetail
-------------
SELECT * 
FROM Sales.SalesOrderDetail
-------------
SELECT SUM(LineTotal) 'Total Sales Amount'
FROM Sales.SalesOrderDetail
-------------
SELECT SUM(LineTotal)
FROM Sales.SalesOrderDetail
WHERE SalesOrderID = 43659
-------------
SELECT SalesOrderID, ProductId, OrderQty, UnitPrice,UnitPriceDiscount,LineTotal
FROM Sales.SalesOrderDetail
WHERE SalesOrderID = 43659
-------------
SELECT MIN(ListPrice)
FROM Production.Product
-------------
SELECT MIN(UnitPrice)
FROM Sales.SalesOrderDetail
-------------
SELECT MAX(UnitPrice)
FROM Sales.SalesOrderDetail
-------------
SELECT COUNT(*)
FROM Sales.SalesOrderDetail
WHERE UnitPrice = MAX(UnitPrice)
-------------
SELECT COUNT(*)
FROM Sales.SalesOrderDetail
WHERE ProductID IN 
(
	SELECT ProductID 
	FROM Sales.SalesOrderDetail
	WHERE UnitPrice = MAX(UnitPrice)
)
---------------
SELECT AVG(LineTotal)
FROM Sales.SalesOrderDetail
---------------
SELECT VAR(LineTotal)
FROM Sales.SalesOrderDetail
---------------
SELECT ProductId, SUM(LineTotal)
FROM Sales.SalesOrderDetail