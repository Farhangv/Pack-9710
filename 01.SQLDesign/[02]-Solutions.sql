USE AdventureWorks2016
GO
SELECT * FROM Production.ProductInventory
GO
SELECT * FROM Production.Location
GO
--Q02
SELECT l.Name 'LocationName', c.Name 'CategoryName', 
FORMAT(
(
	CONVERT(DECIMAL(10,3),SUM(i.Quantity)) / 
	CONVERT(DECIMAL(10,3),(SELECT SUM(Quantity) FROM Production.ProductInventory si WHERE si.LocationID = l.LocationID)) 
) * 100
, '00.00') + '%' 'Pct'
FROM Production.Location l
INNER JOIN Production.ProductInventory i
ON l.LocationID = i.LocationID
INNER JOIN Production.Product p 
ON i.ProductID = p.ProductID
INNER JOIN Production.ProductSubcategory sc
ON p.ProductSubcategoryID = sc.ProductSubcategoryID
INNER JOIN Production.ProductCategory c
ON sc.ProductCategoryID = c.ProductCategoryID
GROUP BY l.LocationID, l.Name, c.Name
ORDER BY 1,2
GO
--Q06