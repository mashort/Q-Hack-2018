CREATE PROCEDURE [dbo].[GetCategories]
AS
	SELECT [Id],
		[Name]
	FROM [Categories]
RETURN 0
