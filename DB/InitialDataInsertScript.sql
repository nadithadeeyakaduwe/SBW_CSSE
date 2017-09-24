-- =============================================
-- Author:		Eshan Dias
-- Create date: 2017-09-24 23:27:24.600
-- Description:	Initial Data to be in the system
-- =============================================

USE [SarangaBatteryWork]
GO

--[Admin].[UserLevel] 

INSERT INTO [Admin].[UserLevel] ([Name],[Status],[ModifiedDate],[DateCreated]) VALUES ('Administrator', 1, GETDATE(), GETDATE())
INSERT INTO [Admin].[UserLevel] ([Name],[Status],[ModifiedDate],[DateCreated]) VALUES ('Owner', 1, GETDATE(), GETDATE())
INSERT INTO [Admin].[UserLevel] ([Name],[Status],[ModifiedDate],[DateCreated]) VALUES ('Manager', 1, GETDATE(), GETDATE())
INSERT INTO [Admin].[UserLevel] ([Name],[Status],[ModifiedDate],[DateCreated]) VALUES ('Operator', 1, GETDATE(), GETDATE())
GO

--[Admin].[User]

INSERT INTO [Admin].[User]([Username],[Name],[Password],[UserLevelID],[Status],[ModifiedDate],[DateCreated]) VALUES	('admin', 'SLIIT Gang', '1', 1, 1, GETDATE(), GETDATE())
INSERT INTO [Admin].[User]([Username],[Name],[Password],[UserLevelID],[Status],[ModifiedDate],[DateCreated]) VALUES	('owner', 'Saranga', '2', 2, 1, GETDATE(), GETDATE())
INSERT INTO [Admin].[User]([Username],[Name],[Password],[UserLevelID],[Status],[ModifiedDate],[DateCreated]) VALUES	('hr', 'Shashi', '3', 3, 1, GETDATE(), GETDATE())
GO

--[HRM].[Department] 

INSERT INTO [HRM].[Department] ([Name],[Status],[ModifiedDate],[DateCreated]) VALUES ('Director Board', 1, GETDATE(), GETDATE())
INSERT INTO [HRM].[Department] ([Name],[Status],[ModifiedDate],[DateCreated]) VALUES ('Maintainance Department', 1, GETDATE(), GETDATE())
INSERT INTO [HRM].[Department] ([Name],[Status],[ModifiedDate],[DateCreated]) VALUES ('Sales Department', 1, GETDATE(), GETDATE())
INSERT INTO [HRM].[Department] ([Name],[Status],[ModifiedDate],[DateCreated]) VALUES ('HR Department', 1, GETDATE(), GETDATE())
GO

--[HRM].[Position] 

INSERT INTO [HRM].[Position] ([Name],[BasicSalary],[OTRate],[Status],[ModifiedDate],[DateCreated]) VALUES ('Sales Rep', 15000.00, 1.5, 1, GETDATE(), GETDATE())
INSERT INTO [HRM].[Position] ([Name],[BasicSalary],[OTRate],[Status],[ModifiedDate],[DateCreated]) VALUES ('Machanic', 28000.00, 2.3, 1, GETDATE(), GETDATE())
INSERT INTO [HRM].[Position] ([Name],[BasicSalary],[OTRate],[Status],[ModifiedDate],[DateCreated]) VALUES ('Supervisor', 35000.00, 0.5, 1, GETDATE(), GETDATE())
INSERT INTO [HRM].[Position] ([Name],[BasicSalary],[OTRate],[Status],[ModifiedDate],[DateCreated]) VALUES ('Driver', 25000.00, 1.5, 1, GETDATE(), GETDATE())
GO

--[HRM].[Employee] 

INSERT INTO [HRM].[Employee] ([Name],[Address],[Email],[DOB],[NIC],[HomeTelNo],[MobileNumber],[Gender],[MaritalStatus],[PositionID],[DepartmentID],[CurrentSalary],[PastExperience],[Qualification],[JoinDate],[Status],[ModifiedDate],[DateCreated]) VALUES ('Tharaka Madhushanki', '12/14, liyanage Ave, Maha Ambalangoda, Ambalangoda', 'tharaka@gmail.com', '1989-11-01', '892658874V', '0112729729', '0778965544', 'F', 'S', 3, 3, 35000.00, '', '', CAST('2017-01-02' AS DATETIME), 1, GETDATE(), GETDATE())
INSERT INTO [HRM].[Employee] ([Name],[Address],[Email],[DOB],[NIC],[HomeTelNo],[MobileNumber],[Gender],[MaritalStatus],[PositionID],[DepartmentID],[CurrentSalary],[PastExperience],[Qualification],[JoinDate],[Status],[ModifiedDate],[DateCreated]) VALUES ('Naditha Harshana', '26, Athapattu Road, Horana', 'naditha@gmail.com', '1994-11-01', '942652887V', '0112739739', '0778965854', 'M', 'S', 2, 2, 28000.00, '', '', CAST('2017-02-02' AS DATETIME), 1, GETDATE(), GETDATE())
INSERT INTO [HRM].[Employee] ([Name],[Address],[Email],[DOB],[NIC],[HomeTelNo],[MobileNumber],[Gender],[MaritalStatus],[PositionID],[DepartmentID],[CurrentSalary],[PastExperience],[Qualification],[JoinDate],[Status],[ModifiedDate],[DateCreated]) VALUES ('Eshan Dias', '29, Galle Road, Dehiwala', 'eshan@gmail.com', '1995-03-08', '950625591V', '0112733733', '0778899761', 'M', 'S', 4, 2, 25000.00, '', '', CAST('2017-01-02' AS DATETIME), 1, GETDATE(), GETDATE())
INSERT INTO [HRM].[Employee] ([Name],[Address],[Email],[DOB],[NIC],[HomeTelNo],[MobileNumber],[Gender],[MaritalStatus],[PositionID],[DepartmentID],[CurrentSalary],[PastExperience],[Qualification],[JoinDate],[Status],[ModifiedDate],[DateCreated]) VALUES ('Pooja Withanage', '03, Pannipitiya Road, Morakatiya, Pannipitiya', 'pooja@gmail.com', '1994-06-21', '942652474V', '0112555555', '0768965564', 'F', 'S', 1, 3, 15000.00, '', '', CAST('2017-01-15' AS DATETIME), 1, GETDATE(), GETDATE())
INSERT INTO [HRM].[Employee] ([Name],[Address],[Email],[DOB],[NIC],[HomeTelNo],[MobileNumber],[Gender],[MaritalStatus],[PositionID],[DepartmentID],[CurrentSalary],[PastExperience],[Qualification],[JoinDate],[Status],[ModifiedDate],[DateCreated]) VALUES ('Shashi Prabagaran', '04/25, Japan Friendship Road, Awissawella', 'shashi@gmail.com', '1989-08-16', '942654874V', '0113789456', '0718965548', 'F', 'S', 1, 3, 15000.00, '', '', CAST('2017-03-02' AS DATETIME), 1, GETDATE(), GETDATE())
GO


