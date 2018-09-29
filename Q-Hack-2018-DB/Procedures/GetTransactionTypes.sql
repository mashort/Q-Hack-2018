CREATE PROCEDURE [dbo].[GetTransactionTypes]
AS
	SELECT [Id],
		[NAME],
		[PROCESS],
		[HardCategoryID]
	FROM [TransactionTypes]
RETURN 0
