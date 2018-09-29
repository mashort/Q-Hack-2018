CREATE TABLE [dbo].[GivingHistory]
(
    [GivenDateTime] DATETIME NOT NULL, 
    [GivenAmount] MONEY NOT NULL, 
    CONSTRAINT [PK_GivingHistory] PRIMARY KEY ([GivenDateTime])
)
