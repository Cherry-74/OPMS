CREATE TABLE [dbo].[User] (
    [UserId]    INT            IDENTITY (1, 1) NOT NULL,
    [UserName]  NVARCHAR (100) NULL,
    [Password]  NVARCHAR (100) NULL,
    [ContactNo] NVARCHAR (50)  NULL,
    [Email]     NVARCHAR (50)  NULL,
    [IsActive]  BIT            NULL,
    [CreatedBy] INT            NULL,
    [CreatedOn] DATETIME       NULL,
    [UpdatedBy] INT            NULL,
    [UpdatedOn] DATETIME       NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([UserId] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_User]
    ON [dbo].[User]([UserId] ASC);

