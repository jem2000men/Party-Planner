CREATE TABLE [dbo].[Parties] (
    [PartyId]    INT           IDENTITY (1, 1) NOT NULL,
    [Party Name] NVARCHAR (50) NOT NULL,
    [Date]       DATETIME      NULL,
    [Location]   NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([PartyId] ASC)
);

