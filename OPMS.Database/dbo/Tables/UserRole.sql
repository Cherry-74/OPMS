CREATE TABLE [dbo].[UserRole] (
    [UserRoleId] INT      IDENTITY (1, 1) NOT NULL,
    [UserId]     INT      NULL,
    [RoleId]     INT      NULL,
    [CreatedBy]  INT      NULL,
    [CreatedOn]  DATETIME NULL,
    [UpdatedBy]  INT      NULL,
    [UpdatedOn]  DATETIME NULL,
    [IsActive]   BIT      NULL,
    CONSTRAINT [PK_UserRole] PRIMARY KEY CLUSTERED ([UserRoleId] ASC),
    CONSTRAINT [FK_UserRole_Role] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Role] ([RoleId]),
    CONSTRAINT [FK_UserRole_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([UserId]),
    CONSTRAINT [FK_UserRole_User1] FOREIGN KEY ([CreatedBy]) REFERENCES [dbo].[User] ([UserId]),
    CONSTRAINT [FK_UserRole_User2] FOREIGN KEY ([UpdatedBy]) REFERENCES [dbo].[User] ([UserId]),
    CONSTRAINT [IX_UserRole] UNIQUE NONCLUSTERED ([UserId] ASC)
);

