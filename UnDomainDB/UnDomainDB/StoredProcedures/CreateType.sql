CREATE PROCEDURE [dbo].[CreateType]
	@TypeIndicator int,
	@Type varchar(100),
	@Value varchar(500),
	@ParentID int
AS
	Insert into UnDomain (TypeIndicator, Type, Value, ParentId)
	Values (@TypeIndicator, @Type, @Value, @ParentID)
RETURN 0
