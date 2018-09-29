CREATE PROCEDURE [dbo].[GetSetting]
	@name varchar(50)
AS
	SELECT [Value]
	FROM [Settings]
	WHERE [Name] = @name
RETURN 0
