CREATE TABLE [dbo].[te$(]
(
	--Primary Keys
	[Entityd] INT NOT NULL PRIMARY KEY,
	
	--Foreign Keys
	[DomainId] int not null,

	--Business Data
	[Data] varchar(128) NULL,

	--System
	[Active] BIT NOT NULL DEFAULT 'True',
	[Created] DateTime NOT NULL DEFAULT SYSDATETIME(),
	[CreatedBy] VARCHAR(128) NOT NULL,
	[Deactivated]	DATETIME  NULL,
	[Modified] DateTime NOT NULL DEFAULT SYSDATETIME(),
	[ModifiedBy] VARCHAR(128) NOT NULL
    CONSTRAINT [FK_Entity_ToTable] FOREIGN KEY (DomainId) REFERENCES [Domain]([DomainId])
)
