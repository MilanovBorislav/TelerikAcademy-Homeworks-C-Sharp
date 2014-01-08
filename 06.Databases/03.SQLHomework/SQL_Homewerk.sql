/*
SELECT e.FirstName,e.LastName,e.Salary,d.Name
	FROM dbo.Employees e JOIN dbo.Departments d
		ON	e.DepartmentID = d.DepartmentID	
			WHERE	Salary =
				(SELECT MIN(Salary) FROM dbo.Employees)
*/
/*
SELECT FirstName,LastName, Salary
	FROM dbo.Employees
		WHERE	Salary  >
			(SELECT MIN(Salary) FROM dbo.Employees)	*0.1
*/
/*
SELECT e.FirstName, e.LastName, e.Salary,d.Name	AS DeptName
	FROM Employees e JOIN dbo.Departments d
		ON	e.DepartmentID = d.DepartmentID
		    WHERE Salary = 
			     (SELECT MIN(Salary) FROM Employees 
				     WHERE DepartmentID = e.DepartmentID)

*/
/*
SELECT 	AVG(Salary)
	FROM	dbo.Employees e JOIN	 dbo.Departments  d
		ON e.DepartmentID = d.DepartmentID
		     WHERE d.Name = 'Sales'
*/
/*
SELECT COUNT(*)--FirstName,LastName,Name 
	FROM dbo.Employees e JOIN dbo.Departments d	
		ON e.DepartmentID = d.DepartmentID
			WHERE d.Name = 'Sales'
*/
/*
SELECT  COUNT(*)--FirstName,LastName
	FROM dbo.Employees
	    WHERE	ManagerID IS NOT NULL	
*/
/*
SELECT  COUNT(*) --FirstName,LastName
	FROM dbo.Employees
	    WHERE	ManagerID IS NULL
*/
/*
SELECT  d.Name ,AVG(Salary) AS AVGSalary
	FROM dbo.Employees e JOIN dbo.Departments d
		ON e.EmployeeID = d.DepartmentID
			 GROUP BY d.Name
*/
/*
SELECT  COUNT(EmployeeID) AS EmployeeCoun,t.Name AS TownName,d.Name AS DeptName
	FROM 
		dbo.Employees e 
		JOIN dbo.Departments d
			ON	e.DepartmentID = d.DepartmentID
				JOIN dbo.Addresses a
				   ON e.AddressID = a.AddressID
						JOIN dbo.Towns t
							ON	a.TownID = t.TownID
	  GROUP BY	t.Name,d.Name
*/	
/*
SELECT e.FirstName,e.LastName,e.EmployeeID
	FROM dbo.Employees e
		WHERE 5 =
			(
			SELECT COUNT(*)
			FROM dbo.Employees
			WHERE	ManagerID = e.EmployeeID
			)
*/
/*
SELECT e.FirstName + ' ' + e.LastName EmpName,
ISNULL(mng.FirstName+' '+mng.LastName, 'no manager') AS MngName
	FROM dbo.Employees mng RIGHT JOIN dbo.Employees e
		ON	e.ManagerID = mng.EmployeeID
*/	  			
/*
SELECT	LastName
FROM dbo.Employees 
	WHERE LEN(LastName) = 5
*/
 /*
 SELECT  CONVERT(VARCHAR(25), GETDATE(), 121) AS [DATE]
*/	
/*
CREATE TABLE Users
    (
      UserID INT IDENTITY ,
      UserName NVARCHAR(100) ,
      UserPassword CHAR(50) ,
      UserFullName NVARCHAR(100) ,
      LastLoginTime DATETIME ,
      CONSTRAINT PK_Users PRIMARY KEY ( UserID ) ,
      UNIQUE ( UserName ) ,
      CHECK ( LEN(UserPassword) >= 5 )
    )
GO
*/
/*
CREATE VIEW UsersEnteredToday AS
SELECT * FROM Users
WHERE LastLoginTime = CONVERT(VARCHAR(10),GETDATE(),111)
GO
*/
/*
 CREATE TABLE Groups (
  GroupID int IDENTITY,
  Name nvarchar(100),
  CONSTRAINT PK_Groups PRIMARY KEY(GroupID),
  UNIQUE(Name),
)
*/
/*
ALTER TABLE Users ADD GroupID INT
ALTER TABLE Users 
ADD CONSTRAINT FK_Users_Groups
FOREIGN KEY(GroupID)
REFERENCES Groups(GroupID)
*/
 /*
INSERT  INTO dbo.Users
        ( UserName ,
          UserPassword ,
          UserFullName ,
          LastLoginTime
        )
VALUES  ( N'Pesho' , -- UserName - nvarchar(100)
          '123456' , -- UserPassword - char(50)
          N'Petar Kirov' , -- UserFullName - nvarchar(100)
          '2013-07-13 16:47:58'  -- LastLoginTime - datetime
        )
*/
/*
INSERT  INTO dbo.Groups
        ( Name )
VALUES  ( N'SomeGroup'  -- Name - nvarchar(100)
          ) 
*/
/*
 UPDATE Users
 SET UserName = 'UpdatedName'
 WHERE UserID = 1

 UPDATE Groups
 SET Name = 'UpdatedGroupName'
 WHERE GroupID = 1
*/
/*
DELETE  FROM Users
WHERE   UserName = 'UpdatedName'
DELETE  FROM Groups
WHERE   Name = 'UpdatedGroupName'
*/
/*
SELECT AVG(e.Salary) AverigeSalary,e.JobTitle,d.Name FROM Employees e 
	JOIN Departments d
		ON e.DepartmentID=d.DepartmentID
			GROUP BY e.JobTitle,d.Name
*/ 
/*
SELECT MIN(e.Salary) MinSalary,e.LastName,e.JobTitle,d.Name FROM Employees e 
	JOIN Departments d
		ON e.DepartmentID=d.DepartmentID
			GROUP BY e.LastName,e.JobTitle,d.Name
			ORDER BY d.Name
*/
/*
SELECT TOP(1) t.Name
	FROM Employees e 
		JOIN Addresses a ON e.AddressId = a.AddressId
		JOIN Towns t ON t.TownId = a.TownId
			GROUP BY t.TownId, t.Name
			ORDER BY COUNT(*) DESC;
*/
/*
SELECT COUNT(m.EmployeeID),t.Name FROM Employees e
	JOIN Employees m
       ON e.ManagerID=m.EmployeeID
    JOIN Addresses a 
       ON e.AddressID = a.AddressID
    JOIN Towns t
       ON a.TownID = t.TownID
       GROUP BY t.Name
*/
/*
CREATE TABLE WorkHours
    (
      ReportID INT IDENTITY
                   PRIMARY KEY ,
      EmployeeID INT NOT NULL
                     FOREIGN KEY REFERENCES Employees ( EmployeeId ) ,
      FromDate DATETIME ,
      Task NVARCHAR(100) ,
      HoursUsed INT ,
      Comments VARCHAR(200),
    )
GO

CREATE TABLE WorkHoursLogs
    (
      ReportID INT ,
      OldEmployeeID INT ,
      OldFromDate DATETIME ,
      OldTask NVARCHAR(100) ,
      OldHoursUsed INT ,
      OldComments VARCHAR(200) ,
      NewEmployeeID INT ,
      NewFromDate DATETIME ,
      NewTask NVARCHAR(100) ,
      NewHoursUsed INT ,
      NewComments VARCHAR(200) ,
      Command VARCHAR(20)
    )
GO

CREATE TRIGGER tr_workHoursUpdate ON WorkHours
    AFTER UPDATE
AS
    BEGIN
        INSERT  INTO WorkHoursLogs
                ( ReportID ,
                  OldEmployeeID ,
                  OldFromDate ,
                  OldTask ,
                  OldHoursUsed ,
                  OldComments ,
                  NewEmployeeID ,
                  NewFromDate ,
                  NewTask ,
                  NewHoursUsed ,
                  NewComments ,
                  Command
                )
                SELECT  d.ReportID ,
                        d.EmployeeID ,
                        d.FromDate ,
                        d.Task ,
                        d.HoursUsed ,
                        d.Comments ,
                        w.EmployeeID ,
                        w.FromDate ,
                        w.Task ,
                        w.HoursUsed ,
                        w.Comments ,
                        'Update'
                FROM    deleted d
                        JOIN WorkHours w ON d.ReportID = w.ReportID
    END
go

CREATE TRIGGER tr_workHoursInsert ON WorkHours
    AFTER INSERT
AS
    BEGIN
        INSERT  INTO WorkHoursLogs
                ( ReportID ,
                  OldEmployeeID ,
                  OldFromDate ,
                  OldTask ,
                  OldHoursUsed ,
                  OldComments ,
                  NewEmployeeID ,
                  NewFromDate ,
                  NewTask ,
                  NewHoursUsed ,
                  NewComments ,
                  Command
                )
                SELECT  w.ReportID ,
                        NULL ,
                        NULL ,
                        NULL ,
                        NULL ,
                        NULL ,
                        i.EmployeeID ,
                        i.FromDate ,
                        i.Task ,
                        i.HoursUsed ,
                        i.Comments ,
                        'Insert'
                FROM    WorkHours w
                        JOIN inserted i ON w.ReportID = i.ReportID
    END
go

CREATE TRIGGER tr_workHoursDelete ON WorkHours
    AFTER DELETE
AS
    BEGIN
        INSERT  INTO WorkHoursLogs
                ( ReportID ,
                  OldEmployeeID ,
                  OldFromDate ,
                  OldTask ,
                  OldHoursUsed ,
                  OldComments ,
                  NewEmployeeID ,
                  NewFromDate ,
                  NewTask ,
                  NewHoursUsed ,
                  NewComments ,
                  Command
                )
                SELECT  ReportID ,
                        EmployeeID ,
                        FromDate ,
                        Task ,
                        HoursUsed ,
                        Comments ,
                        NULL ,
                        NULL ,
                        NULL ,
                        NULL ,
                        NULL ,
                        'Delete'
                FROM    deleted
    END
go

INSERT  INTO WorkHours
VALUES  ( 1, 12 / 12 / 2012, 'Test', 8, 'some comment' )

UPDATE  WorkHours
SET     Comments = 'another comment'
WHERE   EmployeeID = 1

DELETE  FROM WorkHours
WHERE   Comments = 'some comment'
*/
/*
 BEGIN TRAN
	ALTER TABLE EmployeesProjects
	ADD CONSTRAINT FK_CASCADE_1 FOREIGN KEY (EmployeeID)
	REFERENCES Employees (EmployeeID)
	ON DELETE CASCADE;

	ALTER TABLE Departments
	ADD CONSTRAINT FK_CASCADE_2 FOREIGN KEY (ManagerId)
	REFERENCES Employees (EmployeeID)
	ON DELETE SET NULL;

	DELETE FROM Employees 
	WHERE DepartmentId IN (SELECT DepartmentId FROM Departments WHERE Name = 'Sales')

	ROLLBACK TRANGOGO
*/
/*
USE TelerikAcademy
GO 
	BEGIN TRAN
		DROP TABLE EmployeesProjects
ROLLBACK TRAN
*/
/*
BEGIN TRAN 
	SELECT * INTO #TemporaryEmployeesProject
	FROM EmployeesProjects
	DROP TABLE EmployeesProjects

SELECT * INTO EmployeesProjects
	FROM #TemporaryEmployeesProject

DROP TABLE #TemporaryEmployeesProject
GO
ROLLBACK TRAN
*/