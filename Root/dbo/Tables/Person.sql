CREATE TABLE [dbo].[Person]
(
	--Primary Keys
	[PersonId] INT NOT NULL PRIMARY KEY,
	
	--Business Data
	[Born] DATE NULL,
	[Died] DATE NULL,
	[FirstName] VARCHAR(128) NULL,
	[LastName] VARCHAR(128) NULL,
	[MaidenName] VARCHAR(128) NULL,
	[SexId] INT NULL,
	--System
	[Active] BIT NOT NULL DEFAULT 'True',
	[Created] DateTime NOT NULL DEFAULT SYSDATETIME(),
	[CreatedBy] VARCHAR(128) NOT NULL,
	[Deactivated]	DATETIME  NULL,
	[Modified] DateTime NOT NULL DEFAULT SYSDATETIME(),
	[ModifiedBy] VARCHAR(128) NOT NULL
)
