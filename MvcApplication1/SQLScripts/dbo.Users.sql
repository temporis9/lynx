USE [MedicalCases]
GO

/****** Object: Table [dbo].[Users] Script Date: 2014-06-18 09:03:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users] (
    [Id]       INT           NOT NULL,
    [userName] NVARCHAR (50) NULL,
    [name]     NVARCHAR (50) NULL,
    [surname]  NCHAR (10)    NULL
);


