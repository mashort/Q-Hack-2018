IF NOT EXISTS (SELECT 1 FROM [dbo].[CategorisationMatches] WHERE [Id] = 1) 
INSERT INTO [dbo].[CategorisationMatches] ([Id], [TextMatch], [CategoryID]) VALUES (1, N'Direct Line Ins', 4)
ELSE 
UPDATE [dbo].[CategorisationMatches] SET [TextMatch] = N'Direct Line Ins' WHERE [Id] = 1

IF NOT EXISTS (SELECT 1 FROM [dbo].[CategorisationMatches] WHERE [Id] = 2) 
INSERT INTO [dbo].[CategorisationMatches] ([Id], [TextMatch], [CategoryID]) VALUES (2, N'02 Mobile', 4)
ELSE 
UPDATE [dbo].[CategorisationMatches] SET [TextMatch] = N'02 Mobile' WHERE [Id] = 2

IF NOT EXISTS (SELECT 1 FROM [dbo].[CategorisationMatches] WHERE [Id] = 3) 
INSERT INTO [dbo].[CategorisationMatches] ([Id], [TextMatch], [CategoryID]) VALUES (3, N'ASDA', 3)
ELSE 
UPDATE [dbo].[CategorisationMatches] SET [TextMatch] = N'ASDA' WHERE [Id] = 3

IF NOT EXISTS (SELECT 1 FROM [dbo].[CategorisationMatches] WHERE [Id] = 4) 
INSERT INTO [dbo].[CategorisationMatches] ([Id], [TextMatch], [CategoryID]) VALUES (4, N'John Lewis Edinburgh GB', 6)

IF NOT EXISTS (SELECT 1 FROM [dbo].[CategorisationMatches] WHERE [Id] = 5) 
INSERT INTO [dbo].[CategorisationMatches] ([Id], [TextMatch], [CategoryID]) VALUES (5, N'Tesco', 3)

IF NOT EXISTS (SELECT 1 FROM [dbo].[CategorisationMatches] WHERE [Id] = 6) 
INSERT INTO [dbo].[CategorisationMatches] ([Id], [TextMatch], [CategoryID]) VALUES (6, N'M&S', 6)





