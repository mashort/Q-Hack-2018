CREATE PROCEDURE [dbo].[UpdateTransaction]
	@id varchar(50),
	@processed BIT,
	@processedCategory INT,
	@processedAmount MONEY
AS
	UPDATE Transactions
	SET Processed = @processed, 
		ProcessedCategory = @processedCategory,
		ProcessedAmount = @processedAmount
	WHERE Id = @id
RETURN 0
