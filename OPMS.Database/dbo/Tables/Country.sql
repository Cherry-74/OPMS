CREATE TABLE [dbo].[Country] (
    [CountryId]   INT           IDENTITY (1, 1) NOT NULL,
    [CountryName] NVARCHAR (50) NULL,
    [IsActive]    BIT           NULL,
    CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED ([CountryId] ASC)
);

