CREATE TABLE [dbo].[State] (
    [StateId]   INT           IDENTITY (1, 1) NOT NULL,
    [StateName] NVARCHAR (50) NULL,
    [CountryId] INT           NULL,
    [IsActive]  BIT           NULL,
    CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED ([StateId] ASC),
    CONSTRAINT [FK_State_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([CountryId])
);

