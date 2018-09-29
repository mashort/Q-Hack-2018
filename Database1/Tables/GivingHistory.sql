CREATE TABLE [dbo].[GivingHistory]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [GivenDate] DATETIME NOT NULL, 
    [GivenAmount] MONEY NOT NULL
)
