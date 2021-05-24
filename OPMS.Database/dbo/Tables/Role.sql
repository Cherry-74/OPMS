CREATE TABLE [dbo].[Role] (
    [RoleId]    INT           IDENTITY (1, 1) NOT NULL,
    [RoleName]  NVARCHAR (50) NULL,
    [CreatedBy] INT           NULL,
    [CreatedOn] DATETIME      NULL,
    [UpdatedBy] INT           NULL,
    [UpdatedOn] DATETIME      NULL,
    [IsActive]  BIT           NULL,
    CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED ([RoleId] ASC)
);

