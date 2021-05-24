CREATE TABLE [dbo].[ParkingCollection] (
    [ParkingCollectionId] INT           IDENTITY (1, 1) NOT NULL,
    [ParkingAddressId]    INT           NULL,
    [ParkingDate]         DATETIME      NOT NULL,
    [VechileRegNo]        NVARCHAR (50) NULL,
    [VechileTypeId]       INT           NULL,
    [InTime]              DATETIME      NOT NULL,
    [OutTime]             DATETIME      NULL,
    [IsActive]            BIT           NULL,
    CONSTRAINT [PK_ParkingCollection] PRIMARY KEY CLUSTERED ([ParkingCollectionId] ASC),
    CONSTRAINT [FK_ParkingCollection_ParkingAddress] FOREIGN KEY ([ParkingAddressId]) REFERENCES [dbo].[ParkingAddress] ([ParkingAddressId]),
    CONSTRAINT [FK_ParkingCollection_ParkingDetails] FOREIGN KEY ([ParkingAddressId]) REFERENCES [dbo].[ParkingDetails] ([ParkingdetailId])
);



