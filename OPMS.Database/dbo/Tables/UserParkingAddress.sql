CREATE TABLE [dbo].[UserParkingAddress] (
    [UserParkingAddressId] INT IDENTITY (1, 1) NOT NULL,
    [UserId]               INT NULL,
    [ParkingAddressId]     INT NULL,
    [IsActive]             BIT NULL,
    CONSTRAINT [PK_UserParkingAddress] PRIMARY KEY CLUSTERED ([UserParkingAddressId] ASC),
    CONSTRAINT [FK_UserParkingAddress_ParkingAddress] FOREIGN KEY ([ParkingAddressId]) REFERENCES [dbo].[ParkingAddress] ([ParkingAddressId]),
    CONSTRAINT [FK_UserParkingAddress_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([UserId])
);

