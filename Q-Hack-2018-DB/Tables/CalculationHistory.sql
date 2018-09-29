CREATE TABLE [dbo].[CalculationHistory]
(
	[Id] INT NOT NULL , 
    [CalculationDate] DATETIME NOT NULL, 
    [CalculationRuleID] INT NOT NULL, 
    [CategoryID] INT NOT NULL, 
    CONSTRAINT [PK_CalculationHistory] PRIMARY KEY ([Id], [CalculationDate])
)
