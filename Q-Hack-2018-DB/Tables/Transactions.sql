CREATE TABLE [dbo].[Transactions]
(
	[Id] VARCHAR(50) NOT NULL PRIMARY KEY,
	[TransactionDateTime] datetime not NULL,
	[TransactionType] INT not null, 
    [TransactionDescription] VARCHAR(50) NOT NULL, 
    [TransactionAmount] MONEY NOT NULL, 
    [Processed] BIT NULL, 
	[ProcessedCategory] INT NOT NULL,
    [ProcessedAmount] MONEY NULL
    

)
