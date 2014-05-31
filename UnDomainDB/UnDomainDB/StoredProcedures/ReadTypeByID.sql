CREATE PROCEDURE [dbo].[ReadTypeByID]
	@ID int
AS
	SELECT * FROM UnDomain
	WHERE ID = @ID
