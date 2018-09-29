IF NOT EXISTS (SELECT 1 FROM CalculationHistory WHERE CalculationDate = '2018-09-29 12:01' AND CategoryID = 3)
INSERT INTO [CalculationHistory] (CalculationDate, CategoryID) VALUES ('2018-09-29 12:01',3)

IF NOT EXISTS (SELECT 1 FROM CalculationHistory WHERE CalculationDate = '2018-09-29 12:01' AND CategoryID = 4)
INSERT INTO [CalculationHistory] (CalculationDate, CategoryID) VALUES ('2018-09-29 12:01',4)

IF NOT EXISTS (SELECT 1 FROM CalculationHistory WHERE CalculationDate = '2018-09-29 12:01' AND CategoryID = 6)
INSERT INTO [CalculationHistory] (CalculationDate, CategoryID) VALUES ('2018-09-29 12:01',6)