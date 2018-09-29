ALTER TABLE [dbo].[Transactions]
	ADD CONSTRAINT [FKTransactionsTransactionTypeID]
	FOREIGN KEY (TransactionType)
	REFERENCES [TransactionTypes] (Id)
