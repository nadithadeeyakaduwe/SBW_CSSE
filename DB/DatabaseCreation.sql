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

CREATE SCHEMA [Invoice]
GO

CREATE SCHEMA [installment]
GO

CREATE SCHEMA [Stock]
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


CREATE TABLE [Stock].[Product]
(
	Product_ID INT NOT NULL IDENTITY(10001,1),
	Product_Brand VARCHAR(50),
	Product_Name VARCHAR(50),
	Product_Type VARCHAR(50) UNIQUE,
	Status INT DEFAULT 1,
	ModifiedDate DATETIME NOT NULL DEFAULT GETDATE(),
	DateCreated DATETIME NOT NULL DEFAULT GETDATE()

	CONSTRAINT pk_Product PRIMARY KEY(Product_ID)
)
GO

CREATE TABLE [Stock].[Stock_Batch]
(
	Batch_No INT NOT NULL IDENTITY(10001,1),
	BDate DATETIME DEFAULT GETDATE(),
	Total_Amount DECIMAL(8,2),
	Status INT DEFAULT 1,
	ModifiedDate DATETIME NOT NULL DEFAULT GETDATE(),
	DateCreated DATETIME NOT NULL DEFAULT GETDATE()

	CONSTRAINT pk_Stock_Batch PRIMARY KEY(Batch_No)
)
GO

CREATE TABLE [Stock].[Stock_Header]
(
	Stock_ID INT NOT NULL IDENTITY(10001,1),
	Batch_No INT,
	Total_Amount DECIMAL(8,2),
	Status INT DEFAULT 1,
	ModifiedDate DATETIME NOT NULL DEFAULT GETDATE(),
	DateCreated DATETIME NOT NULL DEFAULT GETDATE()

	CONSTRAINT pk_Stock_Header PRIMARY KEY(Stock_ID),
	CONSTRAINT fk1_Stock_Header FOREIGN KEY (Batch_No) References [Stock].[Stock_Batch] (Batch_No) ON UPDATE CASCADE
)
GO

CREATE TABLE [Stock].[Stock_Details]
(
	Stock_Item_No INT NOT NULL IDENTITY(10001,1),
	Product_id INT,
	QTY DECIMAL(5,0),
	Price DECIMAL(6,2),
	Buying_Discount DECIMAL(3,2),
	SDate DATETIME DEFAULT GETDATE(),
	Status INT DEFAULT 1,
	ModifiedDate DATETIME NOT NULL DEFAULT GETDATE(),
	DateCreated DATETIME NOT NULL DEFAULT GETDATE()

	CONSTRAINT pk_Stock_Details PRIMARY KEY(Stock_Item_No),
	CONSTRAINT fk1_Stock_Details FOREIGN KEY (Product_id) References [Stock].[Product] (Product_ID) ON UPDATE CASCADE
)
GO



CREATE TABLE [Invoice].[Invoice_Header]
(
	Invoice_No INT NOT NULL IDENTITY(10001,1),
	SDate DATETIME DEFAULT GETDATE(),
	Customer_Name varchar(50),
	Customer_Address varchar(150),
	Customer_Telephone char(10) UNIQUE,
	Total_Amount DECIMAL(6,2),
	Status INT DEFAULT 1,
	ModifiedDate DATETIME NOT NULL DEFAULT GETDATE(),
	DateCreated DATETIME NOT NULL DEFAULT GETDATE()

	CONSTRAINT pk_Invoice_Header PRIMARY KEY(Invoice_No)
	)
GO

CREATE TABLE [Invoice].[Invoice_Details]
(
	Item_No INT NOT NULL IDENTITY(1,1),
	Invoice_No INT,
	Product_Name VARCHAR(50),
	Product_Type VARCHAR(50),
	QTY INT,
	Unit_Price DECIMAL(6,2),
	Discount DECIMAL(3,2),
	Warrenty varchar(35),
	Amount DECIMAL(7,2),
	Status INT DEFAULT 1,
	ModifiedDate DATETIME NOT NULL DEFAULT GETDATE(),
	DateCreated DATETIME NOT NULL DEFAULT GETDATE()

	CONSTRAINT pk_Invoice_Details PRIMARY KEY(Item_No,Invoice_No)
	CONSTRAINT fk1_Invoice_Details  FOREIGN KEY (Invoice_No) References [Invoice].[Invoice_Header](Invoice_No) ON UPDATE CASCADE
	)
GO

CREATE TABLE [Installment].[Installment]
(
	Inastallment_ID INT NOT NULL IDENTITY(10001,1),
	Invoice_No INT,
	Installment_date DATETIME DEFAULT GETDATE(),
	Number_of_Installment INT,
	Amount DECIMAL(6,2),
	Paid_Amount DECIMAL(6,2),
	NotPaid_Amount DECIMAL(6,2),
	Status INT DEFAULT 1,
	ModifiedDate DATETIME NOT NULL DEFAULT GETDATE(),
	DateCreated DATETIME NOT NULL DEFAULT GETDATE()

	CONSTRAINT pk_Inastallment PRIMARY KEY(Inastallment_ID),
	CONSTRAINT fk1_Inastallment FOREIGN KEY (Invoice_No) References [Invoice].[Invoice_Header](Invoice_No) ON UPDATE CASCADE
	)
GO
