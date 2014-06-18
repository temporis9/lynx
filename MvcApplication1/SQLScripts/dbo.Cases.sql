USE [MedicalCases]
GO

/****** Object: Table [dbo].[Cases] Script Date: 2014-06-18 09:02:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cases] (
    [Id]     INT           NOT NULL,
    [Name]   NVARCHAR (50) NULL,
    [Date]   DATETIME      NULL,
    [userId] INT           NULL
);


