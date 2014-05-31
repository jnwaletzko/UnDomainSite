CREATE TABLE [dbo].[UnDomain]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TypeIndicator] INT NOT NULL, 
    [Type] VARCHAR(100) NULL, 
    [Value] VARCHAR(500) NULL, 
    [ParentId] INT NULL
)
