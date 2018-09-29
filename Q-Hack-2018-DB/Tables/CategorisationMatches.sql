CREATE TABLE [dbo].[CategorisationMatches]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [TextMatch] NVARCHAR(MAX) NOT NULL, 
    [CategoryID] INT NOT NULL
)
