IF DB_ID('EmployeeDB') IS NULL
    CREATE DATABASE EmployeeDB;
GO
USE EmployeeDB;
GO
IF OBJECT_ID('Employees', 'U') IS NOT NULL
    DROP TABLE Employees;
GO
CREATE PROCEDURE sp_InsertEmployee
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2),
    @JoinDate DATE
AS
BEGIN
    INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES (@FirstName, @LastName, @DepartmentID, @Salary, @JoinDate);
END;
GO
EXEC sp_InsertEmployee 'Srinithi', 'Mitra', 3, 6500.00, '2025-06-27';