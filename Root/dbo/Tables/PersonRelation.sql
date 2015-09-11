CREATE TABLE [dbo].[Relationship]
(
	--Primary Key
	[PersonRelationId] INT NOT NULL PRIMARY KEY,
	[Parent_PersonId] INT NOT NULL,
	[Child_PersonId] INT NOT NULL,
	[RelationTypeId] INT NOT NULL,
	--System
	[Active] BIT NOT NULL DEFAULT 'True',
	[Created] DateTime NOT NULL DEFAULT SYSDATETIME(),
	[CreatedBy] VARCHAR(128) NOT NULL,
	[Deactivated]	DATETIME  NULL,
	[Modified] DateTime NOT NULL DEFAULT SYSDATETIME(),
	[ModifiedBy] VARCHAR(128) NOT NULL
)
