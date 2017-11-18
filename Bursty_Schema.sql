PRINT N'Creating Bursty database...';  
GO
CREATE SCHEMA [Bursty]
	AUTHORIZATION [dbo];
GO
PRINT N'Creating Bursty.Logs...';
GO
CREATE TABLE [Bursty].[Logs] (
    [Id]   INT            IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR (50)  NOT NULL,
    [Frequency] INT            NOT NULL,
    [Path] NVARCHAR (260) NOT NULL,
[LastLine] BIGINT NULL
);
GO
PRINT N'Creating Bursty.Checks...';
GO
CREATE TABLE [Bursty].[Checks] (
    [Id]        INT            IDENTITY(1,1) PRIMARY KEY,
    [Pattern]   NVARCHAR (MAX) NOT NULL,
    [LastCheck] DATETIME       NULL,
    [Hit]       BIT            NOT NULL,
    [Repeat]    BIT            NOT NULL,
    [LogID]     INT            NOT NULL

);
GO
ALTER TABLE [Bursty].[Checks]
    ADD CONSTRAINT [FK_Checks_Logs] FOREIGN KEY ([LogID]) REFERENCES [Bursty].[Logs] ([Id]);
GO
PRINT N'Creating Bursty.Lines...';
GO
CREATE TABLE [Bursty].[Lines] (
    [Id]      INT IDENTITY(1,1) PRIMARY KEY,
    [Number]  BIGINT NOT NULL,
    [CheckId] INT NOT NULL
);
GO
ALTER TABLE [Bursty].[Lines]
    ADD CONSTRAINT [FK_Lines_Checks] FOREIGN KEY ([CheckId]) REFERENCES [Bursty].[Checks] ([Id]);
GO