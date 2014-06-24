CREATE TABLE [dbo].[CaseSymptoms] (
    [Id]        INT NOT NULL IDENTITY,
    [symptomId] INT NULL,
    [caseId]    INT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

