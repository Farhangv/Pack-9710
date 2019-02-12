USE AdventureWorks2016
GO
SELECT * FROM HumanResources.Employee
GO
SELECT * FROM HumanResources.Department
GO
SELECT * FROM HumanResources.EmployeeDepartmentHistory
GO
CREATE DATABASE Session09
GO
SELECT CONCAT(p.FirstName,' ', p.MiddleName, ' ', p.LastName) 'FullName',
e.JobTitle, d.Name 'DepartmentName', d.GroupName
INTO Session09.dbo.Employee
FROM Person.Person p
INNER JOIN HumanResources.Employee e
ON p.BusinessEntityID = e.BusinessEntityID
INNER JOIN HumanResources.EmployeeDepartmentHistory ed
ON e.BusinessEntityID = ed.BusinessEntityID
INNER JOIN HumanResources.Department d
ON ed.DepartmentID = d.DepartmentID
WHERE ed.EndDate IS NULL

GO
USE Session09
GO
SELECT * FROM Employee
GO
CREATE VIEW VW_ExecutiveDept
AS
SELECT [FullName], [JobTitle], [DepartmentName], [GroupName]
FROM Employee
WHERE DepartmentName = 'Executive'
GO
SELECT * FROM VW_ExecutiveDept
GO
CREATE VIEW VW_ProductionDept
AS
SELECT [FullName], [JobTitle], [DepartmentName], [GroupName]
FROM Employee
WHERE DepartmentName = 'Production'
GO
SELECT * FROM VW_ProductionDept
GO
ALTER TABLE Employee 
ADD PRIMARY KEY(FullName)
GO
INSERT INTO VW_ExecutiveDept
VALUES 
(
'Chandler Bing', 
'Chief Yechizi Officer', 
'Production', 
'Tech'
)
GO
ALTER VIEW VW_ExecutiveDept
AS
SELECT [FullName], [JobTitle], [DepartmentName], [GroupName]
FROM Employee
WHERE DepartmentName = 'Executive'
WITH CHECK OPTION
GO
INSERT INTO VW_ExecutiveDept
VALUES 
(
'Sheldon Cooper', 
'Chief Yechizi Officer', 
'Production', 
'Tech'
)
GO
SELECT * FROM VW_ExecutiveDept
GO
UPDATE VW_ExecutiveDept SET DepartmentName = 'Production'
WHERE FullName = 'Monica Geller'
GO
UPDATE VW_ProductionDept SET DepartmentName = 'Sample'
WHERE FullName = 'Monica Geller'
GO
SELECT USER_NAME()
GO
SELECT * FROM dbo.Employee
GO
CREATE SCHEMA Production
GO
CREATE TABLE Production.Product
(
	Id INT PRIMARY KEY
)
GO
USE AdventureWorks2016
GO
CREATE FUNCTION GetAge
(
	@BirthDate DATETIME
)
RETURNS TINYINT
AS
BEGIN
	RETURN YEAR(GETDATE()) - YEAR(@BirthDate)
END
GO
SELECT GETDATE()
GO
SELECT dbo.GetAge('1980-10-10')
GO
SELECT JobTitle, dbo.GetAge(BirthDate) 'Age'
FROM HumanResources.Employee
GO
CREATE FUNCTION GetEmployeesByDeparmentName
(
	@DepartmentName NVARCHAR(50)
)
RETURNS TABLE
AS
RETURN
SELECT CONCAT(p.FirstName,' ', p.MiddleName, ' ', p.LastName) 'FullName',
e.JobTitle, d.Name 'DepartmentName', d.GroupName
FROM Person.Person p
INNER JOIN HumanResources.Employee e
ON p.BusinessEntityID = e.BusinessEntityID
INNER JOIN HumanResources.EmployeeDepartmentHistory ed
ON e.BusinessEntityID = ed.BusinessEntityID
INNER JOIN HumanResources.Department d
ON ed.DepartmentID = d.DepartmentID
WHERE ed.EndDate IS NULL AND d.Name = @DepartmentName
GO
SELECT *
FROM GetEmployeesByDeparmentName('Executive')
GO
ALTER FUNCTION GetProductSalesReport
(
	@SubCategoryName NVARCHAR(50),
	@MinQty INT,
	@MaxQty INT,
	@Page INT,
	@RecordsPerPage INT
)
RETURNS TABLE
AS
RETURN 
SELECT ROW_NUMBER() OVER (ORDER BY ProductId) 'RowNumber',
ProductId, Name, SubCatName,SumQty, SumAmount
FROM 
(
	SELECT 
	p.ProductId, p.Name, 
	ISNULL(sc.Name, '') 'SubCatName',
	ISNULL(SUM(s.OrderQty), 0) 'SumQty', 
	FORMAT(ISNULL(SUM(s.LineTotal),0), '###,0') 'SumAmount'
	FROM Production.Product p
	LEFT OUTER JOIN Sales.SalesOrderDetail s
	ON p.ProductID = s.ProductID
	LEFT OUTER JOIN Production.ProductSubcategory sc
	ON p.ProductSubcategoryID = sc.ProductSubcategoryID
	GROUP BY p.ProductID, p.Name, sc.Name
) s
WHERE 
SumQty BETWEEN @MinQty AND @MaxQty
AND SubCatName LIKE '%' + @SubCategoryName + '%'
ORDER BY RowNumber
OFFSET (@Page - 1) * @RecordsPerPage ROWS FETCH NEXT @RecordsPerPage ROWS ONLY
GO
SELECT * 
FROM GetProductSalesReport('Bike', 1000, 2000, 1, 10)
GO
USE Session09
GO
CREATE TABLE SalesReportLog
(
	Id INT IDENTITY PRIMARY KEY,
	ReportTime DATETIME
)
GO
USE AdventureWorks2016
GO
DROP FUNCTION GetProductSalesReport
GO
CREATE FUNCTION GetProductSalesReport
(
	@SubCategoryName NVARCHAR(50),
	@MinQty INT,
	@MaxQty INT,
	@Page INT,
	@RecordsPerPage INT
)
RETURNS @Result TABLE 
(
	RowNumber INT,
	ProductId INT,
	Name NVARCHAR(50),
	SubCatName NVARCHAR(50),
	SumQty INT,
	SumAmount VARCHAR(15)
)
AS
BEGIN
INSERT INTO @Result
SELECT ROW_NUMBER() OVER (ORDER BY ProductId) 'RowNumber',
ProductId, Name, SubCatName,SumQty, SumAmount
FROM 
(
	SELECT 
	p.ProductId, p.Name, 
	ISNULL(sc.Name, '') 'SubCatName',
	ISNULL(SUM(s.OrderQty), 0) 'SumQty', 
	FORMAT(ISNULL(SUM(s.LineTotal),0), '###,0') 'SumAmount'
	FROM Production.Product p
	LEFT OUTER JOIN Sales.SalesOrderDetail s
	ON p.ProductID = s.ProductID
	LEFT OUTER JOIN Production.ProductSubcategory sc
	ON p.ProductSubcategoryID = sc.ProductSubcategoryID
	GROUP BY p.ProductID, p.Name, sc.Name
) s
WHERE 
SumQty BETWEEN @MinQty AND @MaxQty
AND SubCatName LIKE '%' + @SubCategoryName + '%'
ORDER BY RowNumber
OFFSET (@Page - 1) * @RecordsPerPage ROWS FETCH NEXT @RecordsPerPage ROWS ONLY
RETURN
END
GO
SELECT * 
FROM GetProductSalesReport('Bike', 1000, 2000, 3, 10)
GO
--Variable
DECLARE @Name NVARCHAR(50)

--SET @Name = 'John'

SELECT @Name = FirstName 
FROM Person.Person
WHERE BusinessEntityID = 19269

SELECT @Name
GO
SELECT * FROM Person.Person
GO
CREATE TABLE #MyTemp
(
	Name NVARCHAR(50)
)
GO
INSERT INTO #MyTemp
VALUES ('Test')
GO
SELECT * FROM #MyTemp
GO
CREATE TABLE ##MyGlobalTemp
(
	Name NVARCHAR(50)
)
GO
INSERT INTO ##MyGlobalTemp
VALUES ('Test')
GO
SELECT * FROM ##MyGlobalTemp
GO
IF 1 = 0
BEGIN
	PRINT N'شرط برقرار است'
END
ELSE
BEGIN
	PRINT N'شرط برقرار نیست'
END

