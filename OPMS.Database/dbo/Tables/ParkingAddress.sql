CREATE TABLE [dbo].[ParkingAddress] (
    [ParkingAddressId] INT           IDENTITY (1, 1) NOT NULL,
    [Address1]         NVARCHAR (50) NULL,
    [Address2]         NVARCHAR (50) NULL,
    [CityId]           INT           NULL,
    [IsActive]         BIT           NULL,
    CONSTRAINT [PK_ParkingAddress] PRIMARY KEY CLUSTERED ([ParkingAddressId] ASC),
    CONSTRAINT [FK_ParkingAddress_City] FOREIGN KEY ([CityId]) REFERENCES [dbo].[City] ([CityId])
);

