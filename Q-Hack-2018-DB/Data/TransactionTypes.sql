﻿IF NOT EXISTS (SELECT 1 FROM [dbo].[TransactionTypes] WHERE [Id] = 1) INSERT INTO [dbo].[TransactionTypes] ([Id], [Name], [Process]) VALUES (1, N'XFR', 0)
IF NOT EXISTS (SELECT 1 FROM [dbo].[TransactionTypes] WHERE [Id] = 2) INSERT INTO [dbo].[TransactionTypes] ([Id], [Name], [Process]) VALUES (2, N'S/O', 0)
IF NOT EXISTS (SELECT 1 FROM [dbo].[TransactionTypes] WHERE [Id] = 3) INSERT INTO [dbo].[TransactionTypes] ([Id], [Name], [Process]) VALUES (3, N'D/D', 1)
IF NOT EXISTS (SELECT 1 FROM [dbo].[TransactionTypes] WHERE [Id] = 4) INSERT INTO [dbo].[TransactionTypes] ([Id], [Name], [Process]) VALUES (4, N'C/L', 0)
IF NOT EXISTS (SELECT 1 FROM [dbo].[TransactionTypes] WHERE [Id] = 5) INSERT INTO [dbo].[TransactionTypes] ([Id], [Name], [Process]) VALUES (5, N'POS', 1)
IF NOT EXISTS (SELECT 1 FROM [dbo].[TransactionTypes] WHERE [Id] = 6) INSERT INTO [dbo].[TransactionTypes] ([Id], [Name], [Process]) VALUES (6, N'DPC', 0)