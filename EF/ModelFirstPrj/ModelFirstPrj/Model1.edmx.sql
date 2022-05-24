
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/24/2022 16:51:25
-- Generated from EDMX file: E:\Banu\Zensar\Batch 2\EF\ModelFirstPrj\ModelFirstPrj\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BookstoreDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Books'
CREATE TABLE [dbo].[Books] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BookName] nvarchar(max)  NOT NULL,
    [Price] real  NOT NULL,
    [PublisherPId] int  NOT NULL
);
GO

-- Creating table 'Publishers'
CREATE TABLE [dbo].[Publishers] (
    [PId] int IDENTITY(1,1) NOT NULL,
    [PName] nvarchar(max)  NOT NULL,
    [Estd] datetime  NOT NULL,
    [BookId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Books'
ALTER TABLE [dbo].[Books]
ADD CONSTRAINT [PK_Books]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [PId] in table 'Publishers'
ALTER TABLE [dbo].[Publishers]
ADD CONSTRAINT [PK_Publishers]
    PRIMARY KEY CLUSTERED ([PId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PublisherPId] in table 'Books'
ALTER TABLE [dbo].[Books]
ADD CONSTRAINT [FK_PublisherBook]
    FOREIGN KEY ([PublisherPId])
    REFERENCES [dbo].[Publishers]
        ([PId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PublisherBook'
CREATE INDEX [IX_FK_PublisherBook]
ON [dbo].[Books]
    ([PublisherPId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------