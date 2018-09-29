CREATE PROCEDURE [dbo].[InsertCalculationHistory]
	@calculationDate datetime,
	@categoryID int
AS
	INSERT INTO [CalculationHistory]
	([CalculationDate], [CategoryID])
	VALUES (@calculationDate, @categoryID)

RETURN 0
