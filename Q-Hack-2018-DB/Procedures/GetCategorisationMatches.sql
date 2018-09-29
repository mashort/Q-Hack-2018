CREATE PROCEDURE [dbo].[GetCategorisationMatches]
AS
	SELECT [ID],
		[TextMatch],
		[CategoryID]
	FROM CategorisationMatches
RETURN 0
