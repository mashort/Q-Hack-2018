CREATE PROCEDURE [dbo].[InsertCalculationHistoryByName]
	@calculationDate DATETIME,
	@categoryName NVARCHAR(50)
AS
	INSERT INTO CalculationHistory
	(CalculationDate, CategoryID)
	VALUES
	(@calculationDate, (SELECT TOP 1 [Id] FROM Categories WHERE [Name] = @categoryName))
RETURN 0
