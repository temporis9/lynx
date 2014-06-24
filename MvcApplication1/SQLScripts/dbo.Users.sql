CREATE TABLE [dbo].[Users] (
    [Id]       INT           NOT NULL IDENTITY,
    [userName] NVARCHAR (50) NULL,
    [name]     NVARCHAR (50) NULL,
    [surname]  NCHAR (10)    NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

