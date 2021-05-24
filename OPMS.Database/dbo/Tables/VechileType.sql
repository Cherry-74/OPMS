CREATE TABLE [dbo].[VechileType] (
    [VechileTypeId] INT           IDENTITY (1, 1) NOT NULL,
    [TypeName]      NVARCHAR (50) NULL,
    [ParkingFeesId] INT           NULL,
    [IsActive]      BIT           NULL,
    CONSTRAINT [PK_VechileType] PRIMARY KEY CLUSTERED ([VechileTypeId] ASC),
    CONSTRAINT [FK_VechileType_ParkingFees] FOREIGN KEY ([ParkingFeesId]) REFERENCES [dbo].[ParkingFees] ([ParkingFeesId])
);

