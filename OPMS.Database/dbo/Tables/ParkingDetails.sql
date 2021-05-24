CREATE TABLE [dbo].[ParkingDetails] (
    [ParkingdetailId]  INT IDENTITY (1, 1) NOT NULL,
    [ParkingAddressId] INT NULL,
    [VechileTypeId]    INT NULL,
    [MaxSlot]          INT NOT NULL,
    [IsActive]         BIT NULL,
    CONSTRAINT [PK_ParkingDetails] PRIMARY KEY CLUSTERED ([ParkingdetailId] ASC),
    CONSTRAINT [FK_ParkingDetails_ParkingAddress] FOREIGN KEY ([ParkingAddressId]) REFERENCES [dbo].[ParkingAddress] ([ParkingAddressId]),
    CONSTRAINT [FK_ParkingDetails_VechileType] FOREIGN KEY ([VechileTypeId]) REFERENCES [dbo].[VechileType] ([VechileTypeId])
);

