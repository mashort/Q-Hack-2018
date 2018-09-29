CREATE PROCEDURE [dbo].[GetLatestCalculationHistory]
	AS
	SELECT 
		c.[Name]
	FROM 
		[CalculationHistory] h INNER JOIN [Categories] c ON h.[CategoryID] = c.[Id]
	WHERE CalculationDate IN (
	SELECT MAX(CalculationDate) FROM CalculationHistory)
RETURN 0
