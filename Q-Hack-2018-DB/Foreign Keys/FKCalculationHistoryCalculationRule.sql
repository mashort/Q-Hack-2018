ALTER TABLE [dbo].[CalculationHistory]
	ADD CONSTRAINT [FKCalculationHistoryCalculationRule]
	FOREIGN KEY (CalculationRuleID)
	REFERENCES [CalculationRules] (Id)
