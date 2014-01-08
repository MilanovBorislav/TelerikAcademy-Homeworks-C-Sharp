/*
SELECT  *
FROM  dbo.Departments
*/
/*
SELECT dbo.Departments.Name
FROM dbo.Departments 
*/
/*
SELECT dbo.Employees.Salary
FROM dbo.Employees
*/
/*
SELECT dbo.Employees.FirstName,dbo.Employees.LastName
FROM dbo.Employees
*/
/*
SELECT  dbo.Employees.FirstName + '.' + dbo.Employees.LastName
        + '@telerik.com' AS FullEmailAddresses
FROM    Employees
*/
/*
SELECT DISTINCT dbo.Employees.Salary
FROM dbo.Employees
*/
/*
SELECT * 
FROM dbo.Employees	
WHERE dbo.Employees.JobTitle = 'Sales Representative'
*/
/*
SELECT *
FROM dbo.Employees
WHERE dbo.Employees.FirstName LIKE 'SA%'
*/
/*
SELECT *
FROM dbo.Employees
WHERE dbo.Employees.LastName LIKE '%ei%'
*/
/*
SELECT dbo.Employees.Salary
FROM dbo.Employees
WHERE	Salary BETWEEN 	20000 AND 30000
*/
/*
SELECT  dbo.Employees.FirstName + ' ' + dbo.Employees.LastName AS EmpName ,
        dbo.Employees.Salary
FROM    dbo.Employees
WHERE   ( dbo.Employees.Salary = 25000
          OR dbo.Employees.Salary = 14000
          OR dbo.Employees.Salary = 12500
          OR dbo.Employees.Salary = 23600
        )
*/
/*
SELECT  dbo.Employees.FirstName + ' ' + dbo.Employees.LastName AS EmpName 
FROM dbo.Employees
WHERE ManagerID IS NULL
*/
/*
SELECT  dbo.Employees.FirstName + ' ' + dbo.Employees.LastName AS EmpName,
dbo.Employees.Salary
FROM dbo.Employees
WHERE Salary > 50000
ORDER BY Salary DESC
*/
/*
SELECT TOP 5  dbo.Employees.FirstName + ' ' + dbo.Employees.LastName AS EmpName,
dbo.Employees.Salary
FROM dbo.Employees
ORDER	BY Salary DESC
*/
/*
SELECT  e.FirstName ,
        e.LastName ,
        e.AddressID ,
        a.AddressText AS Adress
FROM    dbo.Employees e	INNER	JOIN dbo.Addresses a
ON e.AddressID = a.AddressID
*/
/*
SELECT  e.FirstName ,
        e.LastName ,
        e.AddressID ,
        a.AddressText AS Adress
FROM  dbo.Employees e,dbo.Addresses a
WHERE e.AddressID = a.AddressID
*/
/*
SELECT  e.FirstName + ' ' + e.LastName AS EmpName ,
        e.ManagerID ,
        m.FirstName + ' ' + m.LastName MngName ,
        m.EmployeeID
FROM    dbo.Employees e	INNER JOIN dbo.Employees m 
ON e.ManagerID = m.EmployeeID
*/
/*
SELECT  e.FirstName + ' ' + e.LastName AS EmpName ,
        -- e.ManagerID ,
        m.FirstName + ' ' + m.LastName MngName ,
        --m.EmployeeID,
		--e.AddressID,
		a.AddressText
FROM    dbo.Employees e
	INNER JOIN dbo.Employees m
	ON	e.ManagerID = m.EmployeeID
	JOIN dbo.Addresses a
	ON	e.AddressID = a.AddressID
*/
/*
SELECT Name	  AS Name
FROM dbo.Departments
UNION	
SELECT Name AS Name
FROM dbo.Towns
*/
/*
SELECT  e.LastName EmpLastName ,
        m.EmployeeID MgrID ,
        m.LastName MgrLastName
FROM    Employees e
        LEFT OUTER JOIN Employees m ON e.ManagerID = m.EmployeeID
*/
/*
SELECT  e.LastName EmpLastName ,
        m.EmployeeID MgrID ,
        m.LastName MgrLastName
FROM    Employees e
        RIGHT OUTER JOIN Employees m ON e.ManagerID = m.EmployeeID
*/
/*
SELECT  dbo.Employees.FirstName ,
        dbo.Employees.LastName ,
        dbo.Employees.DepartmentID ,
        dbo.Employees.HireDate
FROM    dbo.Employees
WHERE   DepartmentID IN ( SELECT    DepartmentID
                          FROM      dbo.Departments
                          WHERE     Name = 'Sales'
                                    OR Name = 'Finance' )
*/


