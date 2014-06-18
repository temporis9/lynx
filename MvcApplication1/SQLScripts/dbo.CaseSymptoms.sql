USE [MedicalCases]
GO

/****** Object: Table [dbo].[CaseSymptoms] Script Date: 2014-06-18 09:02:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CaseSymptoms] (
    [Id]        INT NOT NULL,
    [symptomId] INT NULL,
    [caseId]    INT NULL
);


