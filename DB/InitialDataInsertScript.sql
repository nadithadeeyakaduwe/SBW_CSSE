-- =============================================
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

INSERT INTO [HRM].[Employee] ([Name],[Address],[Email],[DOB],[NIC],[HomeTelNo],[MobileNumber],[Gender],[MaritalStatus],[EpfNo],[PositionID],[DepartmentID],[CurrentSalary],[PastExperience],[Qualification],[JoinDate],[Status],[ModifiedDate],[DateCreated]) VALUES ('Tharaka Madhushanki', '12/14, liyanage Ave, Maha Ambalangoda, Ambalangoda', 'tharaka@gmail.com', '1989-11-01', '892658874V', '0112729729', '0778965544', 'F', 'S', 1, 3, 3, 35000.00, '', '', CAST('2017-01-02' AS DATETIME), 1, GETDATE(), GETDATE())
INSERT INTO [HRM].[Employee] ([Name],[Address],[Email],[DOB],[NIC],[HomeTelNo],[MobileNumber],[Gender],[MaritalStatus],[EpfNo],[PositionID],[DepartmentID],[CurrentSalary],[PastExperience],[Qualification],[JoinDate],[Status],[ModifiedDate],[DateCreated]) VALUES ('Naditha Harshana', '26, Athapattu Road, Horana', 'naditha@gmail.com', '1994-11-01', '942652887V', '0112739739', '0778965854', 'M', 'S', 2, 2, 2, 28000.00, '', '', CAST('2017-02-02' AS DATETIME), 1, GETDATE(), GETDATE())
INSERT INTO [HRM].[Employee] ([Name],[Address],[Email],[DOB],[NIC],[HomeTelNo],[MobileNumber],[Gender],[MaritalStatus],[EpfNo],[PositionID],[DepartmentID],[CurrentSalary],[PastExperience],[Qualification],[JoinDate],[Status],[ModifiedDate],[DateCreated]) VALUES ('Eshan Dias', '29, Galle Road, Dehiwala', 'eshan@gmail.com', '1995-03-08', '950625591V', '0112733733', '0778899761', 'M', 'S', 3, 4, 2, 25000.00, '', '', CAST('2017-01-02' AS DATETIME), 1, GETDATE(), GETDATE())
INSERT INTO [HRM].[Employee] ([Name],[Address],[Email],[DOB],[NIC],[HomeTelNo],[MobileNumber],[Gender],[MaritalStatus],[EpfNo],[PositionID],[DepartmentID],[CurrentSalary],[PastExperience],[Qualification],[JoinDate],[Status],[ModifiedDate],[DateCreated]) VALUES ('Pooja Withanage', '03, Pannipitiya Road, Morakatiya, Pannipitiya', 'pooja@gmail.com', '1994-06-21', '942652474V', '0112555555', '0768965564', 'F', 'S', 4, 1, 3, 15000.00, '', '', CAST('2017-01-15' AS DATETIME), 1, GETDATE(), GETDATE())
INSERT INTO [HRM].[Employee] ([Name],[Address],[Email],[DOB],[NIC],[HomeTelNo],[MobileNumber],[Gender],[MaritalStatus],[EpfNo],[PositionID],[DepartmentID],[CurrentSalary],[PastExperience],[Qualification],[JoinDate],[Status],[ModifiedDate],[DateCreated]) VALUES ('Shashi Prabagaran', '04/25, Japan Friendship Road, Awissawella', 'shashi@gmail.com', '1989-08-16', '942654874V', '0113789456', '0718965548', 'F', 'S', 5, 1, 3, 15000.00, '', '', CAST('2017-03-02' AS DATETIME), 1, GETDATE(), GETDATE())
GO

--[Consumer].[Customer]

insert into [Consumer].[Customer] ([NIC],[Name],[Email],[Address],[Rate],[CustomerType]) values('985645451v','Liyanage T.M.','tharakamadushanki@gmail.com','110,New Kandy Rd,Malabe',0,'Loyalty')
insert into [Consumer].[Customer] ([NIC],[Name],[Email],[Address],[Rate],[CustomerType]) values('788552411v','Shashi D.N.','shashydb@gmail.com','12,Delgoda Rd,Gampaha',0,'Regular')
insert into [Consumer].[Customer] ([NIC],[Name],[Email],[Address],[Rate],[CustomerType]) values('934141328v','Naditha D.D.N.','ddn.harshana@gmail.com','45,Yalagala rd,Horana',0,'Loyalty')
insert into [Consumer].[Customer] ([NIC],[Name],[Email],[Address],[Rate],[CustomerType]) values('923456789v','Pooja T.W','psathsaranee@gmail.com','56,Morakatiya,Pannipitiya',0,'Regular')
insert into [Consumer].[Customer] ([NIC],[Name],[Email],[Address],[Rate],[CustomerType]) values('523456789v','Nipun K.L.','nipun@gmail.com','110/1,wijaya Rd,Gampaha',0,'Loyalty')
insert into [Consumer].[Customer] ([NIC],[Name],[Email],[Address],[Rate],[CustomerType]) values('925679324v','Sahan L.P','sahan@gmail.com','45,dodangoda,Kaluthara',0,'Regular')
insert into [Consumer].[Customer] ([NIC],[Name],[Email],[Address],[Rate],[CustomerType]) values('936591478v','Bimal E.R','bimal@gmail.com','11, gamunu mawatha,Anuradhapura',0,'Loyalty')
insert into [Consumer].[Customer] ([NIC],[Name],[Email],[Address],[Rate],[CustomerType]) values('915482674v','Sajith S.L','sajitha@gmail.com','78,wijerama mawatha,Nugegoda',0,'Loyalty')
insert into [Consumer].[Customer] ([NIC],[Name],[Email],[Address],[Rate],[CustomerType]) values('957816458v','Thulakshi C.M','thulakshi@gmail.com','9,pitipana,pannipitiya',0,'Regular')
insert into [Consumer].[Customer] ([NIC],[Name],[Email],[Address],[Rate],[CustomerType]) values('945873157v','Kaweesha L.m','kaweesha@gmail.com','56,Galle Rd,Galle',0,'Regular')
insert into [Consumer].[Customer] ([NIC],[Name],[Email],[Address],[Rate],[CustomerType]) values('934552621v','Gawesh T.J.','gawesh@gmail.com','NewKandy Rd,Kaduwela',0,'Loyalty')
GO

--[Consumer].[CustomerContact]

insert into  [Consumer].[CustomerContact] ([NIC],[ContactNo]) values('985645451v','0774787514')
insert into  [Consumer].[CustomerContact] ([NIC],[ContactNo]) values('788552411v','0715456521')
insert into  [Consumer].[CustomerContact] ([NIC],[ContactNo]) values('934141328v','0769868652')
insert into  [Consumer].[CustomerContact] ([NIC],[ContactNo]) values('923456789v','0713224498')
insert into  [Consumer].[CustomerContact] ([NIC],[ContactNo]) values('523456789v','0715828580')
insert into  [Consumer].[CustomerContact] ([NIC],[ContactNo]) values('925679324v','0774490430')
insert into  [Consumer].[CustomerContact] ([NIC],[ContactNo]) values('936591478v','0777546890')
insert into  [Consumer].[CustomerContact] ([NIC],[ContactNo]) values('915482674v','0766124588')
insert into  [Consumer].[CustomerContact] ([NIC],[ContactNo]) values('957816458v','0718355253')
insert into  [Consumer].[CustomerContact] ([NIC],[ContactNo]) values('945873157v','0776464212')
insert into  [Consumer].[CustomerContact] ([NIC],[ContactNo]) values('934552621v','0775454545')

--[Consumer].[CustomerLoyaltyCard]

insert into [Consumer].[CustomerLoyaltyCard] ([NIC],[Card_No],[Card_Points],[CardType]) values('523456789v','GO523456789',0,'BRONZE')
insert into [Consumer].[CustomerLoyaltyCard] ([NIC],[Card_No],[Card_Points],[CardType]) values('915482674v','GO915482674',0,'SILVER')
insert into [Consumer].[CustomerLoyaltyCard] ([NIC],[Card_No],[Card_Points],[CardType]) values('934141328v','SI934141328',0,'BRONZE')
insert into [Consumer].[CustomerLoyaltyCard] ([NIC],[Card_No],[Card_Points],[CardType]) values('934552621v','SI934552621',0,'BRONZE')
insert into [Consumer].[CustomerLoyaltyCard] ([NIC],[Card_No],[Card_Points],[CardType]) values('936591478v','SI936591478',0,'BRONZE')
insert into [Consumer].[CustomerLoyaltyCard] ([NIC],[Card_No],[Card_Points],[CardType]) values('985645451v','BR985645451',0,'BRONZE')
--insert into [Consumer].[CustomerLoyaltyCard] ([NIC],[Card_No],[Card_Points],[CardType]) values('934552621v','BR934552621',0,'Bronze') duplication of ID