SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Eshan Dias
-- Create date: 2017-10-10 03:54:32.503
-- Description:	Promote Employee
-- =============================================

IF NOT EXISTS (select * from dbo.sysobjects where id = object_id(N'[HRM].[PromoteEmployee]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	EXEC('CREATE PROCEDURE [HRM].[PromoteEmployee] AS SET NOCOUNT ON;')
	
END
GO

ALTER PROCEDURE [HRM].[PromoteEmployee]
	@EmployeeID int = 0,
	@NewPositionID int = 0, 
	@NewSalary decimal = 0.00,
	@Reason VARCHAR(200) = '',
	@Status INT = 1
AS
BEGIN
	SET NOCOUNT OFF;
	DECLARE @CurrentPositionID INT, @CurrentSalary DECIMAL
	
	SELECT @CurrentPositionID = [PositionID], @CurrentSalary = [BasicSalary] FROM [HRM].[Employee]

	UPDATE [HRM].[Employee] 
	SET [PositionID] = @NewPositionID, 
		[BasicSalary] = @NewSalary,
		[ModifiedDate] = GETDATE()
	WHERE [EmployeeID] = @EmployeeID;
	
INSERT INTO [HRM].[EmployeePerformance]
           ([EmployeeID]
           ,[EffectiveDate]
           ,[Reason]
           ,[OldPosition]
           ,[NewPosition]
           ,[OldSalary]
           ,[NewSalary]
           ,[Status]
           ,[ModifiedDate]
           ,[DateCreated])
	VALUES	(@EmployeeID
			,GETDATE()
			,@Reason
			,@CurrentPositionID
			,@NewPositionID
			,@CurrentSalary
			,@NewSalary
			,@Status
			,GETDATE()
			,GETDATE())
END
GO
