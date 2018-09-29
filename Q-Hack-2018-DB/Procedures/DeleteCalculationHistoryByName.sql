CREATE PROCEDURE [dbo].[DeleteCalculationHistoryByName]
	@calculationDate DATETIME,
	@categoryName NVARCHAR(50)
AS
	DELETE FROM CalculationHistory
	WHERE CalculationDate = @calculationDate
	AND CategoryID = (SELECT TOP 1 [Id] FROM Categories WHERE [Name] = @categoryName)

RETURN 0
