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
WITH order_data
AS
(
	SELECT 766 'ProductId', 70 'Qty'
	UNION
	SELECT 776 'ProductId', 12 'Qty'
	UNION
	SELECT 780 'ProductId', 30 'Qty'
	UNION
	SELECT 517 'ProductId', 20 'Qty'
	UNION
	SELECT 514 'ProductId', 300 'Qty'
	UNION
	SELECT 524 'ProductId', 100 'Qty'
)
SELECT p.ProductId, p.Name 'Product', SUM(i.Quantity) 'AvailableQty', o.Qty 'OrderQty', DaysToManufacture,  
CASE
WHEN SUM(i.Quantity) < o.Qty AND DaysToManufacture > 2 THEN 'No'
WHEN SUM(i.Quantity) < o.Qty AND DaysToManufacture <= 2 THEN 'Yes'
WHEN SUM(i.Quantity) > o.Qty THEN 'Yes'
END 'CanDeliver'
FROM Production.Product p
INNER JOIN Production.ProductInventory i
ON p.ProductID = i.ProductID
INNER JOIN order_data o
ON o.ProductId = p.ProductID
GROUP BY p.ProductId, p.Name, o.Qty, DaysToManufacture
