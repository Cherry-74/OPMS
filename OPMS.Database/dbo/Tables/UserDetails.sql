CREATE TABLE [dbo].[UserDetails] (
    [UserDetailsId] INT           IDENTITY (1, 1) NOT NULL,
    [UserId]        INT           NULL,
    [Address1]      NVARCHAR (50) NULL,
    [Address2]      NVARCHAR (50) NULL,
    [CityId]        NVARCHAR (50) NULL,
    [IsActive]      BIT           NULL,
    CONSTRAINT [PK_UserDetails] PRIMARY KEY CLUSTERED ([UserDetailsId] ASC),
    CONSTRAINT [FK_UserDetails_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([UserId]),
    CONSTRAINT [IX_UserDetails] UNIQUE NONCLUSTERED ([UserId] ASC)
);

