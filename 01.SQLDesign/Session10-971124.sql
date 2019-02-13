CREATE DATABASE Session10
GO
USE Session10
GO
CREATE TABLE [User]
(
	Id INT IDENTITY PRIMARY KEY,
	Username NVARCHAR(50),
	Password NVARCHAR(100),
	Email VARCHAR(100)
)
GO
CREATE PROC User_Insert
(
	@Email VARCHAR(50),
	@Password NVARCHAR(50)
)
AS
BEGIN
	INSERT INTO [User] 
	VALUES(@Email, @Password, @Email)
END
GO
EXEC User_Insert 'farhangv@live.com', '13579'
GO
SELECT * FROM [User]
GO
ALTER PROC User_Insert
(
	@Email VARCHAR(50),
	@Password NVARCHAR(50)
)
AS
BEGIN
	INSERT INTO [User] 
	VALUES(@Email, HASHBYTES('SHA2_512',@Password), @Email)
END
GO
EXEC User_Insert 'farhangv@gmail.com', '13579'
GO
SELECT * FROM [User]
GO
TRUNCATE TABLE [User]
GO
DROP TABLE [User]
GO
CREATE TABLE [User]
(
	Id INT IDENTITY PRIMARY KEY,
	Username NVARCHAR(50),
	Password VARBINARY(200),
	Email VARCHAR(100)
)
GO
CREATE PROC User_Select
(
	@Id INT
)
AS
BEGIN
	SELECT * FROM [User] WHERE Id = @Id
END
GO
EXEC User_Select 1
GO
DECLARE @Result INT
EXEC @Result = User_Select 1
SELECT @Result
GO
ALTER PROC User_Insert
(
	@Email VARCHAR(50),
	@Password NVARCHAR(50)
)
AS
BEGIN
	INSERT INTO [User] 
	VALUES(@Email, HASHBYTES('SHA2_512',@Password), @Email)

	RETURN SCOPE_IDENTITY()
END
GO
DECLARE @Result INT
EXEC @Result = User_Insert 'sample@test.com' , '123'
SELECT @Result
GO
User_Select 2
GO
CREATE PROC User_Authenticate
(
	@Username NVARCHAR(50),
	@Password NVARCHAR(50)
)
AS
BEGIN
	IF EXISTS ( 
		SELECT * 
		FROM [User] 
		WHERE Username = @Username 
		AND
		Password = HASHBYTES('SHA2_512', @Password)
	)
	BEGIN
		SELECT 1
	END
	ELSE
	BEGIN
		SELECT 0
	END
END
GO
EXEC User_Insert 'john@doe.com', '123'
GO
EXEC User_Authenticate 'john@doe.com', '12345'
GO
SELECT 10/0
GO
EXEC User_Insert 'abc@jsahkhdakshdjkashdkhsakdhaskdhaskhdkajshdkjashdkjhaskjdhaskjhdkjashdkjashdkjsahdjkhskdhasjkdhkjsahdkjahdkjahskjdhaskjdhashdkjashdjkashdkjashdjkashdjashjkashdjhaskjdhaskh.com',
'123'
GO
INSERT INTO [User] 
VALUES (1,'abc@jsahkhdakshdjkashdkhsakdhaskdhaskhdkajshdkjashdkjhaskjdhaskjhdkjashdkjashdkjsahdjkhskdhasjkdhkjsahdkjahdkjahskjdhaskjdhashdkjashdjkashdkjashdjkashdjashjkashdjhaskjdhaskh.com', '123', 'abc@jsahkhdakshdjkashdkhsakdhaskdhaskhdkajshdkjashdkjhaskjdhaskjhdkjashdkjashdkjsahdjkhskdhasjkdhkjsahdkjahdkjahskjdhaskjdhashdkjashdjkashdkjashdjkashdjashjkashdjhaskjdhaskh.com')
GO
--SELECT Name
--FRO AdventureWorks2016.Production.Product
GO
CREATE PROC Divide
(
	@Num1 INT,
	@Num2 INT
)
AS
BEGIN
	SELECT @Num1 / @Num2
END
GO
EXEC Divide 10,0
GO
ALTER PROC Divide
(
	@Num1 INT,
	@Num2 INT,
	@ErrorMessage NVARCHAR(200) OUTPUT
)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
		SELECT @Num1 / @Num2
	END TRY
	BEGIN CATCH
		DECLARE @ErrorNumber INT
		SET @ErrorNumber = ERROR_NUMBER()
		IF @ErrorNumber = 8134
			PRINT N'????? ?? ??? ???? ????'
		ELSE
			PRINT N'????? ?? ????? ?????? ????? ????'
		
		SET @ErrorMessage = ERROR_MESSAGE()
		RETURN @ErrorNumber
	END CATCH
END
GO
EXEC Divide 10,2
GO
SELECT CONVERT(INT,100000000000000000000)/2
GO
DECLARE @EN INT
DECLARE @EM NVARCHAR(200)
EXEC @EN = Divide 10,0, @EM OUTPUT
IF @EN != 0
	SELECT @EN, @EM
GO
DECLARE @i INT
SET @i = 0
WHILE @i <= 10
BEGIN
	PRINT @i
	SET @i = @i + 1
END
GO
SELECT * 
FROM INFORMATION_SCHEMA.TABLES
GO
SELECT * 
FROM INFORMATION_SCHEMA.COLUMNS
GO

