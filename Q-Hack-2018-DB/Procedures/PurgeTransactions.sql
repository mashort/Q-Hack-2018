CREATE PROCEDURE [dbo].[PurgeTransactions]
AS
	-- Need this to process between runs, to fake repeatedly running.
	DELETE FROM [Transactions]
RETURN 0
