CREATE TABLE [dbo].[RelationType]
(
	--Primary Key
	[RelationTypeId] INT Primary Key,
	
	--Business
	[Name] VARCHAR(20),

	--System
	[EffectiveStart] DATE NOT NULL DEFAULT DATEADD(DAY,-1,SYSDATETIME()),
	[EffectiveEnd] DATE NULL,
	[Created] DateTime NOT NULL DEFAULT SYSDATETIME(),
	[CreatedBy] VARCHAR(128) NOT NULL,
	[Deactivated]	DATETIME  NULL,
	[Modified] DateTime NOT NULL DEFAULT SYSDATETIME(),
	[ModifiedBy] VARCHAR(128) NOT NULL

)
