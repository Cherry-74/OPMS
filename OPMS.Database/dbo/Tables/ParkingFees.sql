CREATE TABLE [dbo].[ParkingFees] (
    [ParkingFeesId] INT            IDENTITY (1, 1) NOT NULL,
    [Fees]          NUMERIC (5, 2) NULL,
    [IsActive]      BIT            NULL,
    CONSTRAINT [PK_ParkingFees] PRIMARY KEY CLUSTERED ([ParkingFeesId] ASC)
);

