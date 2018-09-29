CREATE PROCEDURE [dbo].[GetLatestGivingHistory]
AS
BEGIN
	SELECT TOP 1 [GivenAmount]
	FROM [GivingHistory]
	ORDER BY GivenDateTime DESC
END
