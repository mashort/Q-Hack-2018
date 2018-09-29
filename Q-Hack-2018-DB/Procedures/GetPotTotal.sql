CREATE PROCEDURE [dbo].[GetPotTotal]
AS
	SELECT SUM(GivenAmount)
	FROM GivingHistory
RETURN 0
