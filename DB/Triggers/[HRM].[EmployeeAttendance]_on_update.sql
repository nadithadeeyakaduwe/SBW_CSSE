SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Eshan Dias
-- Create date: 2017-10-16
-- Description:	This trigger wil calculate the worked hours
-- =============================================
CREATE TRIGGER Trigger_OnUpdateEmployeeAttendance
   ON  [HRM].[EmployeeAttendance]
   AFTER UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	DECLARE @empID INT, @InTime DATETIME, @today DATE, @hours DECIMAL(5,1), @outTime DATETIME, @id INT

	SELECT @empID = EmployeeID, @outTime = OutTime,  @id = [ID], @InTime = [InTime] FROM [inserted]

	SELECT @hours = (DATEDIFF(MINUTE,@InTime, @outTime) / 60.0)

	IF UPDATE ([OutTime])
		UPDATE [HRM].[EmployeeAttendance] SET [Duration] = CAST(@hours AS FLOAT) WHERE ID = @id

END
GO
