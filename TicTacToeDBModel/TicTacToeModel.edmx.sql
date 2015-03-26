
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 04/28/2014 18:52:33
-- Generated from EDMX file: C:\svn_git_local_copy\codingdojos\trials\TicTacToeNUnit\TicTacToeDBModel\TicTacToeModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TicTacToeDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[GameBoardSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GameBoardSet];
GO
IF OBJECT_ID(N'[dbo].[PlayerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PlayerSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'GameBoardSet'
CREATE TABLE [dbo].[GameBoardSet] (
    [FieldId] int IDENTITY(1,1) NOT NULL,
    [Field] int  NOT NULL,
    [FieldStatus] int  NOT NULL
);
GO

-- Creating table 'PlayerSet'
CREATE TABLE [dbo].[PlayerSet] (
    [PlayerId] int IDENTITY(1,1) NOT NULL,
    [CurrentPlayer] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [FieldId] in table 'GameBoardSet'
ALTER TABLE [dbo].[GameBoardSet]
ADD CONSTRAINT [PK_GameBoardSet]
    PRIMARY KEY CLUSTERED ([FieldId] ASC);
GO

-- Creating primary key on [PlayerId] in table 'PlayerSet'
ALTER TABLE [dbo].[PlayerSet]
ADD CONSTRAINT [PK_PlayerSet]
    PRIMARY KEY CLUSTERED ([PlayerId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------