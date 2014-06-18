USE [MedicalCases]
GO

/****** Object: Table [dbo].[Symptoms] Script Date: 2014-06-18 09:02:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Symptoms] (
    [Id]          INT           NOT NULL,
    [Name]        NVARCHAR (50) NULL,
    [Description] TEXT          NULL
);


