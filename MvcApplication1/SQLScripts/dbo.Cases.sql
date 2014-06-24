CREATE TABLE [dbo].[Cases] (
    [Id]     INT           NOT NULL IDENTITY,
    [Name]   NVARCHAR (50) NULL,
    [Date]   DATETIME      DEFAULT (getdate()) NULL,
    [userId] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

