USE AdventureWorks2016
----------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE ProductID >= 700 AND ProductID <= 800
----------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE ProductID BETWEEN 700 AND 800
----------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE Name BETWEEN 'a' AND 'c'
----------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE Name LIKE 'a%' OR Name LIKE 'b%'
----------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE Name BETWEEN 'a' AND 'Blade'
ORDER BY Name
----------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE Name LIKE '[ab]%'
----------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE Name LIKE '[abcd]%'
ORDER BY Name
----------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE Name LIKE '__[a-d]%'
ORDER BY Name
----------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE ProductId BETWEEN 300 AND 400 OR ProductID BETWEEN 800 AND 900
----------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE ProductId BETWEEN 400 AND 700 AND ListPrice <> 0
----------------
SELECT SUM(LineTotal)
FROM Sales.SalesOrderDetail
WHERE SalesOrderID = 43800
----------------
SELECT ProductId, SUM(OrderQty) 'TotalQty'
FROM Sales.SalesOrderDetail
GROUP BY ProductId
ORDER BY TotalQty DESC
---------------
SELECT TOP 1 ProductId, SUM(OrderQty) 'TotalQty'
FROM Sales.SalesOrderDetail
GROUP BY ProductId
ORDER BY TotalQty DESC
----------------
SELECT LEFT(Name, 4)
FROM Production.Product
----------------
SELECT LEFT('Salaam', 3)
----------------
SELECT LEFT(Name, 1), COUNT(*) 'Count'
FROM Production.Product
GROUP BY LEFT(Name, 1)
ORDER BY [Count] DESC
----------------
SELECT RIGHT('Salaam', 2)
----------------
SELECT ProductId, SUM(OrderQty) 'TotalQty'
FROM Sales.SalesOrderDetail
GROUP BY ProductId
HAVING SUM(OrderQty) <= 500
ORDER BY TotalQty DESC
----------------
SELECT ProductId, SUM(OrderQty) 'TotalQty'
FROM Sales.SalesOrderDetail
GROUP BY ProductId
HAVING ProductId > 800 AND SUM(OrderQty) <= 500
ORDER BY TotalQty DESC
----------------
SELECT GETDATE()
----------------
SELECT YEAR(GETDATE()), MONTH(GETDATE()), DAY(GETDATE())
----------------
SELECT * 
FROM HumanResources.Employee
----------------
SELECT YEAR(HireDate) 'HireYear', COUNT(*) 'Count'
FROM HumanResources.Employee
GROUP BY YEAR(HireDate)
----------------
SELECT YEAR(HireDate) 'HireYear', MONTH(HireDate) 'HireMonth', COUNT(*) 'Count'
FROM HumanResources.Employee
GROUP BY YEAR(HireDate), MONTH(HireDate)
ORDER BY HireYear, HireMonth
----------------
SELECT YEAR(HireDate) 'HireYear', MONTH(HireDate) 'HireMonth', COUNT(*) 'Count'
FROM HumanResources.Employee
GROUP BY YEAR(HireDate), MONTH(HireDate)
WITH ROLLUP
ORDER BY HireYear, HireMonth
----------------
SELECT DISTINCT YEAR(HireDate), MONTH(HireDate)
FROM HumanResources.Employee
----------------
SELECT YEAR(HireDate) 'HireYear', 
MONTH(HireDate) 'HireMonth', 
DAY(HireDate) 'HireDay',
COUNT(*) 'Count'
FROM HumanResources.Employee
GROUP BY YEAR(HireDate), MONTH(HireDate), DAY(HireDate)
WITH ROLLUP
ORDER BY HireYear, HireMonth, HireDay
----------------
SELECT YEAR(HireDate) 'HireYear', 
MONTH(HireDate) 'HireMonth', 
DAY(HireDate) 'HireDay',
COUNT(*) 'Count'
FROM HumanResources.Employee
GROUP BY YEAR(HireDate), MONTH(HireDate), DAY(HireDate)
WITH CUBE
ORDER BY HireYear, HireMonth, HireDay
-----------------
SELECT DISTINCT YEAR(ModifiedDate), MONTH(ModifiedDate)
FROM Sales.SalesOrderHeader
ORDER BY 1,2
-----------------
SELECT YEAR(ModifiedDate) 'Year', MONTH(ModifiedDate) 'Month', FORMAT(SUM(SubTotal), '0,000') 'TotalSales'
FROM Sales.SalesOrderHeader
GROUP BY YEAR(ModifiedDate), MONTH(ModifiedDate)
WITH ROLLUP
ORDER BY 1 DESC ,2
-----------------
SELECT FORMAT(123456789.12456, '0.0')
-----------------
SELECT FORMAT(123456789.12456, '0,000.00')
-----------------
SELECT ROW_NUMBER() OVER(ORDER BY Name) 'Row',
ProductId, Name, Color,ListPrice
FROM Production.Product
-----------------
SELECT RANK() OVER(ORDER BY ListPrice DESC) 'Rank',
ProductId, Name, Color,ListPrice
FROM Production.Product
-----------------
SELECT 
ROW_NUMBER() OVER (ORDER BY ListPrice DESC) 'Row',
RANK() OVER(ORDER BY ListPrice DESC) 'Rank',
ProductId, Name, Color,ListPrice
FROM Production.Product
-----------------
SELECT 
ROW_NUMBER() OVER (ORDER BY ListPrice DESC) 'Row',
RANK() OVER(ORDER BY ListPrice DESC) 'Rank',
DENSE_RANK() OVER(ORDER BY ListPrice DESC) 'DenseRank',
ProductId, Name, Color,ListPrice
FROM Production.Product
-----------------
SELECT 
ROW_NUMBER() OVER (ORDER BY ListPrice DESC) 'Row',
RANK() OVER(ORDER BY ListPrice DESC) 'Rank',
DENSE_RANK() OVER(ORDER BY ListPrice DESC) 'DenseRank',
NTILE(4) OVER(ORDER BY ListPrice DESC) 'Tile',
ProductId, Name, Color,ListPrice
FROM Production.Product
-----------------
SELECT ROW_NUMBER() OVER(PARTITION BY Color ORDER BY Name) 'Row', Name, Color
FROM Production.Product
-----------------
SELECT ROW_NUMBER() OVER(PARTITION BY Name ORDER BY Name) 'Row', Name, Color
FROM Production.Product
-----------------
SELECT RANK() OVER(PARTITION BY Color ORDER BY ListPrice DESC) 'Rank', 
Name, Color, ListPrice
FROM Production.Product
-----------------
SELECT SalesOrderID ,ProductId ,
LineTotal ,
SUM(LineTotal) OVER (PARTITION BY ProductId) 'Total',
FORMAT((LineTotal / SUM(LineTotal) OVER (PARTITION BY ProductId)) * 100, '0.00') + '%' 'Pct'
FROM Sales.SalesOrderDetail
ORDER BY Pct DESC
---------------
SELECT 1 + 2
---------------
SELECT '1' + '2'
---------------
SELECT 'a' + 'b'
---------------
SELECT ProductId, Name, Color, 
(
	SELECT Name
	FROM Production.ProductSubcategory psc
	WHERE psc.ProductSubcategoryID = p.ProductSubcategoryID
) 'SubCatName'
FROM Production.Product p
----------------
SELECT ProductId, Name, Color, 
(
	SELECT Name
	FROM Production.ProductSubcategory psc
	WHERE psc.ProductSubcategoryID = p.ProductSubcategoryID
) 'SubCatName',
(
	SELECT Name
	FROM Production.ProductCategory pc
	WHERE pc.ProductCategoryID IN
	(
		SELECT ProductCategoryID
		FROM Production.ProductSubcategory psc
		WHERE p.ProductSubcategoryID = psc.ProductSubcategoryID
	)

) 'CatName'
FROM Production.Product p