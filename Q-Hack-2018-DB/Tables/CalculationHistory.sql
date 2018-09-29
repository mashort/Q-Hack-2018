CREATE TABLE [dbo].[CalculationHistory]
(
    [CalculationDate] DATETIME NOT NULL, 
    [CategoryID] INT NOT NULL, 
    CONSTRAINT [PK_CalculationHistory] PRIMARY KEY ([CategoryID], [CalculationDate])
)
