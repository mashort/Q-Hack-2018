CREATE TABLE [dbo].[TransactionTypes]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Process] BIT NOT NULL, 
    [HardCategoryID] INT NULL
)
