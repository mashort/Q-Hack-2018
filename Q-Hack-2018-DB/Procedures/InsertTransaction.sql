CREATE PROCEDURE [dbo].[InsertTransaction]
	@id varchar(50),
	@transactionDateTime DATETIME,
	@transactionType INT,
	@transactionDescription VARCHAR(MAX),
	@transactionAmount MONEY
AS
	INSERT INTO Transactions
		(Id, TransactionDateTime, TransactionType, TransactionDescription, TransactionAmount)
	VALUES (@id, @transactionDateTime, @transactionType, @transactionDescription, @transactionAmount)
		
RETURN 0
