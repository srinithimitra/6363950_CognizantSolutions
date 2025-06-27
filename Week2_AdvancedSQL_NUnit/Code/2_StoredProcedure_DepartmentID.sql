IF OBJECT_ID('Departments', 'U') IS NOT NULL
    DROP TABLE Departments;
GO
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);
GO
INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
(1, 'HR'),
(2, 'Finance'),
(3, 'IT'),
(4, 'Marketing');
GO
IF OBJECT_ID('sp_GetEmployeesByDepartment', 'P') IS NOT NULL
    DROP PROCEDURE sp_GetEmployeesByDepartment;
GO

CREATE PROCEDURE sp_GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT 
        EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate
    FROM 
        Employees
    WHERE 
        DepartmentID = @DepartmentID;
END;
GO
EXEC sp_GetEmployeesByDepartment @DepartmentID = 3;