ALTER TABLE [dbo].[CalculationHistory]
	ADD CONSTRAINT [FKCalculationHistoryCategory]
	FOREIGN KEY (CategoryId)
	REFERENCES [Categories] (Id)
