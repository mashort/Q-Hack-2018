IF NOT EXISTS (SELECT 1 FROM [GivingHistory] WHERE [GivenDateTime] = '2018-09-29 12:01')
INSERT INTO [dbo].[GivingHistory] ([GivenDateTime], [GivenAmount]) VALUES (N'2018-09-29 12:01', CAST(21.3800 AS Money))
ELSE
UPDATE [GivingHistory] SET [GivenAmount] = CAST(21.3800 AS Money) WHERE [GivenDateTime] = '2018-09-29 12:01'

IF NOT EXISTS (SELECT 1 FROM [GivingHistory] WHERE [GivenDateTime] = '2018-09-28 12:01')
INSERT INTO [dbo].[GivingHistory] ([GivenDateTime], [GivenAmount]) VALUES (N'2018-09-28 12:01', CAST(27.1200 AS Money))
ELSE
UPDATE [GivingHistory] SET [GivenAmount] = CAST(21.3800 AS Money) WHERE [GivenDateTime] = N'2018-09-28 12:01'