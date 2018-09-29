CREATE PROCEDURE [dbo].[InsertGivingHistory]
	@givenAmount MONEY
AS
	INSERT INTO [GivingHistory]
	(GivenDateTime, GivenAmount)
	VALUES
	(Getdate(),
	 @givenAmount);
RETURN 0
