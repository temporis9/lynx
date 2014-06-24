CREATE TABLE [dbo].[Symptoms] (
    [Id]          INT           NOT NULL IDENTITY,
    [Name]        NVARCHAR (50) NULL,
    [Description] TEXT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC) 
);


GO
