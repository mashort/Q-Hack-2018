IF NOT EXISTS (SELECT 1 FROM [dbo].[CategorisationMatches] WHERE [Id] = 1) 
INSERT INTO [dbo].[CategorisationMatches] ([Id], [TextMatch], [CategoryID]) VALUES (1, N'Direct Line Ins', 4)

IF NOT EXISTS (SELECT 1 FROM [dbo].[CategorisationMatches] WHERE [Id] = 2) 
INSERT INTO [dbo].[CategorisationMatches] ([Id], [TextMatch], [CategoryID]) VALUES (2, N'O2 Mobile', 4)

IF NOT EXISTS (SELECT 1 FROM [dbo].[CategorisationMatches] WHERE [Id] = 3) 
INSERT INTO [dbo].[CategorisationMatches] ([Id], [TextMatch], [CategoryID]) VALUES (3, N'Asda', 3)

IF NOT EXISTS (SELECT 1 FROM [dbo].[CategorisationMatches] WHERE [Id] = 4) 
INSERT INTO [dbo].[CategorisationMatches] ([Id], [TextMatch], [CategoryID]) VALUES (4, N'John Lewis Edinburgh GB', 6)

IF NOT EXISTS (SELECT 1 FROM [dbo].[CategorisationMatches] WHERE [Id] = 5) 
INSERT INTO [dbo].[CategorisationMatches] ([Id], [TextMatch], [CategoryID]) VALUES (5, N'Tesco', 3)

IF NOT EXISTS (SELECT 1 FROM [dbo].[CategorisationMatches] WHERE [Id] = 6) 
INSERT INTO [dbo].[CategorisationMatches] ([Id], [TextMatch], [CategoryID]) VALUES (6, N'M&S', 6)





