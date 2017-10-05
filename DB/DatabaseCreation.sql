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

CREATE SCHEMA [Accounts]
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
	CivilStatus CHAR (1),
	EpfNo INT NOT NULL,
	PositionID INT NOT NULL,
	DepartmentID INT NOT NULL,
	BasicSalary DECIMAL NOT NULL,
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
	Product_ID INT NOT NULL IDENTITY(1,1),
	Product_Make VARCHAR(20),
	Product_Name VARCHAR(20),
	Product_Type VARCHAR(20),
	Reorder_Level INT,
	Quantity INT, 

	CONSTRAINT pk_Product PRIMARY KEY(Product_ID)
)
GO


CREATE TABLE [Stock].[Supplier_Details]( 

	Supplier_ID INT NOT NULL IDENTITY(1,1),
	Name varchar(30),
	Address varchar(50),
	email varchar(50),

	CONSTRAINT pk_SupplierDetails PRIMARY KEY(Supplier_ID)

)
GO

CREATE TABLE [Stock].[SupplierContact] (

	SupplierID INT NOT NULL ,
	ContactNo char(10)NOT NULL ,
	CONSTRAINT SuppCon_pk PRIMARY KEY(SupplierID,ContactNO),
	CONSTRAINT SuppCon_fk FOREIGN KEY(SupplierID) REFERENCES [Stock].[Supplier_Details] (Supplier_ID) ON UPDATE CASCADE
    
)
GO

CREATE TABLE [Stock].[Stock_Details]
(
	Stock_Id INT NOT NULL,
	Product_Id INT NOT NULL,
	Supplier_ID INT NOT NULL,
	Quantity INT,
	Unit_Price DECIMAL,
	Buying_Discount DECIMAL,
	Date DATETIME DEFAULT GETDATE(),

	CONSTRAINT pk_Stock_Details PRIMARY KEY(Stock_Id,Product_Id),
	CONSTRAINT fk1_Stock_Details FOREIGN KEY (Product_Id) References [Stock].[Product] (Product_ID) ON UPDATE CASCADE,
	CONSTRAINT fk2_Stock_Details FOREIGN KEY (Supplier_ID) References [Stock].[Supplier_Details] (Supplier_ID) ON UPDATE CASCADE

)
GO



CREATE TABLE [Accounts].[Invoice_Header]
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

CREATE TABLE [Accounts].[Invoice_Details]
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
	CONSTRAINT fk1_Invoice_Details  FOREIGN KEY (Invoice_No) References [Accounts].[Invoice_Header](Invoice_No) ON UPDATE CASCADE
	)
GO

CREATE TABLE [Accounts].[Installment]
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
	CONSTRAINT fk1_Inastallment FOREIGN KEY (Invoice_No) References [Accounts].[Invoice_Header](Invoice_No) ON UPDATE CASCADE
	)
GO

