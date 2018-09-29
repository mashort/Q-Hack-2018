﻿IF NOT EXISTS (SELECT 1 FROM [dbo].[CalculationRules] WHERE [Id] = 1) INSERT INTO [dbo].[CalculationRules] ([Id], [Name]) VALUES (1, N'Rounding')
IF NOT EXISTS (SELECT 1 FROM [dbo].[CalculationRules] WHERE [Id] = 2) INSERT INTO [dbo].[CalculationRules] ([Id], [Name], [Value]) VALUES (2, N'Amount 0.50', 0.50)
IF NOT EXISTS (SELECT 1 FROM [dbo].[CalculationRules] WHERE [Id] = 3) INSERT INTO [dbo].[CalculationRules] ([Id], [Name], [Value]) VALUES (3, N'Amount 0.75', 0.75)
IF NOT EXISTS (SELECT 1 FROM [dbo].[CalculationRules] WHERE [Id] = 4) INSERT INTO [dbo].[CalculationRules] ([Id], [Name], [Value]) VALUES (4, N'Amount 1.0', 1)
IF NOT EXISTS (SELECT 1 FROM [dbo].[CalculationRules] WHERE [Id] = 5) INSERT INTO [dbo].[CalculationRules] ([Id], [Name], [Value]) VALUES (5, N'Amount 2.0', 2)
IF NOT EXISTS (SELECT 1 FROM [dbo].[CalculationRules] WHERE [Id] = 6) INSERT INTO [dbo].[CalculationRules] ([Id], [Name], [Value]) VALUES (6, N'Percentage 1', 1)
IF NOT EXISTS (SELECT 1 FROM [dbo].[CalculationRules] WHERE [Id] = 7) INSERT INTO [dbo].[CalculationRules] ([Id], [Name], [Value]) VALUES (7, N'Percentage 2', 2)
IF NOT EXISTS (SELECT 1 FROM [dbo].[CalculationRules] WHERE [Id] = 8) INSERT INTO [dbo].[CalculationRules] ([Id], [Name], [Value]) VALUES (8, N'Percentage 5', 5)
IF NOT EXISTS (SELECT 1 FROM [dbo].[CalculationRules] WHERE [Id] = 8) INSERT INTO [dbo].[CalculationRules] ([Id], [Name], [Value]) VALUES (9, N'Percentage 10', 10)
IF NOT EXISTS (SELECT 1 FROM [dbo].[CalculationRules] WHERE [Id] = 10) INSERT INTO [dbo].[CalculationRules] ([Id], [Name], [Value]) VALUES (10, N'Percentage 20', 20)