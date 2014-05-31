CREATE PROCEDURE [dbo].[UpdateType]
	@ID	int,
	@TypeIndicator int,
	@Type varchar(100),
	@Value varchar(500),
	@ParentID int
AS
	UPDATE UnDomain
	SET TypeIndicator = @TypeIndicator,
		Type = @Type,
		Value = @Value,
		ParentID = @ParentID
	WHERE
		id = @ID
RETURN 0
