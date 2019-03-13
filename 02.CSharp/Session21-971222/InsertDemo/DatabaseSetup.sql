IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'BookStore')
BEGIN
CREATE DATABASE BookStore
END
