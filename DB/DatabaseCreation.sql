-- =============================================
-- Author:		Eshan Dias
-- Create date: 2017-09-24 23:27:24.600
-- Description:	Database creation for Saranga's Battery Work
-- =============================================

USE [master]
GO

/***THIS WILL DELETE THE EXISTING DATABASE WITH THE SAME NAME AND CREATE A NEW ONE***/
IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'SarangaBatteryWork')
BEGIN
	DECLARE @kill varchar(8000) = '';  
	SELECT @kill = @kill + 'kill ' + CONVERT(varchar(5), session_id) + ';'  
	FROM sys.dm_exec_sessions
	WHERE database_id  = db_id('SarangaBatteryWork')
	EXEC(@kill);
	DROP DATABASE [SarangaBatteryWork]
END

CREATE DATABASE [SarangaBatteryWork]
GO

USE [SarangaBatteryWork]
GO

CREATE SCHEMA [Admin]
GO

CREATE SCHEMA [HRM]
GO 

CREATE TABLE [Admin].[User]
(
	UserID INT NOT NULL IDENTITY(1,1),
	Username VARCHAR(20) NOT NULL ,
	Name VARCHAR (30),
	Password VARCHAR (20),
	UserLevelID INT,
	Status INT DEFAULT 1,
	ModifiedDate DATETIME NOT NULL DEFAULT GETDATE(),
	DateCreated DATETIME NOT NULL DEFAULT GETDATE()

	CONSTRAINT pk_User PRIMARY KEY(UserID)
)
GO

CREATE TABLE [Admin].[UserLevel]
(
	UserLevelID INT NOT NULL IDENTITY(1,1),
	Name VARCHAR(20),
	Status INT DEFAULT 1,
	ModifiedDate DATETIME NOT NULL DEFAULT GETDATE(),
	DateCreated DATETIME NOT NULL DEFAULT GETDATE()

	CONSTRAINT pk_UserLevel PRIMARY KEY(UserLevelID)
)
GO

CREATE TABLE [HRM].[Department]
(
	DepartmentID INT NOT NULL IDENTITY(1,1),
	Name VARCHAR(40),
	Status INT DEFAULT 1,
	ModifiedDate DATETIME NOT NULL DEFAULT GETDATE(),
	DateCreated DATETIME NOT NULL DEFAULT GETDATE()

	CONSTRAINT pk_Department PRIMARY KEY (DepartmentID) 
)
GO

CREATE TABLE [HRM].[Position]
(
	PositionID INT NOT NULL IDENTITY(1,1) ,
	Name VARCHAR(20) UNIQUE NOT NULL,
	BasicSalary DECIMAL,
	OTRate DECIMAL,
	Status INT DEFAULT 1,
	ModifiedDate DATETIME NOT NULL DEFAULT GETDATE(),
	DateCreated DATETIME NOT NULL DEFAULT GETDATE()

	CONSTRAINT pk_Position PRIMARY KEY (PositionID) 

)
GO

CREATE TABLE [HRM].[Employee]
(
	EmployeeID INT NOT NULL IDENTITY(1,1),
	Name VARCHAR(70) NOT NULL,
	Address VARCHAR(255),
	Email VARCHAR(50) NOT NULL,
	DOB DATETIME NOT NULL,
	NIC CHAR(10) UNIQUE NOT NULL,
	HomeTelNo CHAR(10) ,
	MobileNumber CHAR (10) UNIQUE NOT NULL,
	Gender CHAR(1) NOT NULL,
	MaritalStatus CHAR (1),
	PositionID INT NOT NULL,
	DepartmentID INT NOT NULL,
	CurrentSalary DECIMAL NOT NULL,
	PastExperience VARCHAR (1000),
	Qualification VARCHAR (1000),
	JoinDate DATETIME NOT NULL,
	Status INT DEFAULT 1,
	ModifiedDate DATETIME NOT NULL DEFAULT GETDATE(),
	DateCreated DATETIME NOT NULL DEFAULT GETDATE()

	
	CONSTRAINT pk_Employee PRIMARY KEY (EmployeeID),
	CONSTRAINT fk1_Employee FOREIGN KEY (PositionID) References [HRM].[Position] (PositionID) ON UPDATE CASCADE,
	CONSTRAINT fk2_Employee FOREIGN KEY (DepartmentID) References [HRM].[Department] (DepartmentID) ON UPDATE CASCADE
)
GO
