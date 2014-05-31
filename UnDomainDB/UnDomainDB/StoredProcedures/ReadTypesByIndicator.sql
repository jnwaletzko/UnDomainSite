CREATE PROCEDURE [dbo].[ReadTypesByIndicator]
	@TypeIndicator int
AS
	SELECT * FROM UnDomain
	WHERE TypeIndicator = @TypeIndicator
