
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/06/2020 22:55:26
-- Generated from EDMX file: C:\Users\Sinikiwe Jumba\KnowYourCircle\KnowYourCircleWebServiceApi\KnowYourCircleWebServiceApi\KYCModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [model];
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

-- Creating table 'Users1'
CREATE TABLE [dbo].[Users1] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Surname] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [BasedOffice] nvarchar(max)  NOT NULL,
    [Cellphone] smallint  NOT NULL,
    [PhotoUrl] nvarchar(max)  NOT NULL,
    [Role] nvarchar(max)  NOT NULL,
    [isFree] bit  NOT NULL,
    [DateOfEmployment] datetime  NOT NULL,
    [Level] nvarchar(max)  NOT NULL,
    [ShortDescription] nvarchar(max)  NOT NULL,
    [SuperPowers] nvarchar(max)  NOT NULL,
    [TechStack] nvarchar(max)  NOT NULL,
    [RecoveryKey] nvarchar(max)  NOT NULL,
    [isActive] bit  NOT NULL,
    [LunchOrder_Id] int  NOT NULL
);
GO

-- Creating table 'Projects'
CREATE TABLE [dbo].[Projects] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ClientName] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [TeamLead] nvarchar(max)  NOT NULL,
    [StartDate] nvarchar(max)  NOT NULL,
    [EndDate] nvarchar(max)  NULL,
    [Stacks] nvarchar(max)  NOT NULL,
    [ClosestOffice] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'NoticeBoards'
CREATE TABLE [dbo].[NoticeBoards] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Topic] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Reactions] nvarchar(max)  NOT NULL,
    [Poster] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Leaves'
CREATE TABLE [dbo].[Leaves] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StartDate] nvarchar(max)  NOT NULL,
    [EndDate] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [AvailableLeaves] nvarchar(max)  NOT NULL,
    [Authoriser] nvarchar(max)  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [Approver] int  NOT NULL
);
GO

-- Creating table 'LunchOrders'
CREATE TABLE [dbo].[LunchOrders] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Food] nvarchar(max)  NOT NULL,
    [SpecialRequest] nvarchar(max)  NOT NULL,
    [Date] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Hoster] nvarchar(max)  NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [Venue] nvarchar(max)  NOT NULL,
    [Duration] nvarchar(max)  NOT NULL,
    [Aim] nvarchar(max)  NOT NULL,
    [isCancelled] bit  NOT NULL,
    [Reactions] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Options1'
CREATE TABLE [dbo].[Options1] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Claims'
CREATE TABLE [dbo].[Claims] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [DateSent] nvarchar(max)  NOT NULL,
    [Attachements] nvarchar(max)  NOT NULL,
    [ClaimedAmount] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Client] nvarchar(max)  NOT NULL,
    [User_Id] int  NOT NULL
);
GO

-- Creating table 'UsersProjects'
CREATE TABLE [dbo].[UsersProjects] (
    [Users_Id] int  NOT NULL,
    [Projects_Id] int  NOT NULL
);
GO

-- Creating table 'UsersEvents'
CREATE TABLE [dbo].[UsersEvents] (
    [Users_Id] int  NOT NULL,
    [Events_Id] int  NOT NULL
);
GO

-- Creating table 'UsersNoticeBoard'
CREATE TABLE [dbo].[UsersNoticeBoard] (
    [Users_Id] int  NOT NULL,
    [NoticeBoards_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Users1'
ALTER TABLE [dbo].[Users1]
ADD CONSTRAINT [PK_Users1]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Projects'
ALTER TABLE [dbo].[Projects]
ADD CONSTRAINT [PK_Projects]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'NoticeBoards'
ALTER TABLE [dbo].[NoticeBoards]
ADD CONSTRAINT [PK_NoticeBoards]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Leaves'
ALTER TABLE [dbo].[Leaves]
ADD CONSTRAINT [PK_Leaves]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LunchOrders'
ALTER TABLE [dbo].[LunchOrders]
ADD CONSTRAINT [PK_LunchOrders]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Options1'
ALTER TABLE [dbo].[Options1]
ADD CONSTRAINT [PK_Options1]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Claims'
ALTER TABLE [dbo].[Claims]
ADD CONSTRAINT [PK_Claims]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Users_Id], [Projects_Id] in table 'UsersProjects'
ALTER TABLE [dbo].[UsersProjects]
ADD CONSTRAINT [PK_UsersProjects]
    PRIMARY KEY CLUSTERED ([Users_Id], [Projects_Id] ASC);
GO

-- Creating primary key on [Users_Id], [Events_Id] in table 'UsersEvents'
ALTER TABLE [dbo].[UsersEvents]
ADD CONSTRAINT [PK_UsersEvents]
    PRIMARY KEY CLUSTERED ([Users_Id], [Events_Id] ASC);
GO

-- Creating primary key on [Users_Id], [NoticeBoards_Id] in table 'UsersNoticeBoard'
ALTER TABLE [dbo].[UsersNoticeBoard]
ADD CONSTRAINT [PK_UsersNoticeBoard]
    PRIMARY KEY CLUSTERED ([Users_Id], [NoticeBoards_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Users_Id] in table 'UsersProjects'
ALTER TABLE [dbo].[UsersProjects]
ADD CONSTRAINT [FK_UsersProjects_Users]
    FOREIGN KEY ([Users_Id])
    REFERENCES [dbo].[Users1]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Projects_Id] in table 'UsersProjects'
ALTER TABLE [dbo].[UsersProjects]
ADD CONSTRAINT [FK_UsersProjects_Projects]
    FOREIGN KEY ([Projects_Id])
    REFERENCES [dbo].[Projects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsersProjects_Projects'
CREATE INDEX [IX_FK_UsersProjects_Projects]
ON [dbo].[UsersProjects]
    ([Projects_Id]);
GO

-- Creating foreign key on [Users_Id] in table 'UsersEvents'
ALTER TABLE [dbo].[UsersEvents]
ADD CONSTRAINT [FK_UsersEvents_Users]
    FOREIGN KEY ([Users_Id])
    REFERENCES [dbo].[Users1]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Events_Id] in table 'UsersEvents'
ALTER TABLE [dbo].[UsersEvents]
ADD CONSTRAINT [FK_UsersEvents_Events]
    FOREIGN KEY ([Events_Id])
    REFERENCES [dbo].[Events]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsersEvents_Events'
CREATE INDEX [IX_FK_UsersEvents_Events]
ON [dbo].[UsersEvents]
    ([Events_Id]);
GO

-- Creating foreign key on [LunchOrder_Id] in table 'Users1'
ALTER TABLE [dbo].[Users1]
ADD CONSTRAINT [FK_UsersLunchOrders]
    FOREIGN KEY ([LunchOrder_Id])
    REFERENCES [dbo].[LunchOrders]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsersLunchOrders'
CREATE INDEX [IX_FK_UsersLunchOrders]
ON [dbo].[Users1]
    ([LunchOrder_Id]);
GO

-- Creating foreign key on [Approver] in table 'Leaves'
ALTER TABLE [dbo].[Leaves]
ADD CONSTRAINT [FK_UsersLeaves]
    FOREIGN KEY ([Approver])
    REFERENCES [dbo].[Users1]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsersLeaves'
CREATE INDEX [IX_FK_UsersLeaves]
ON [dbo].[Leaves]
    ([Approver]);
GO

-- Creating foreign key on [User_Id] in table 'Claims'
ALTER TABLE [dbo].[Claims]
ADD CONSTRAINT [FK_ClaimsUsers]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[Users1]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClaimsUsers'
CREATE INDEX [IX_FK_ClaimsUsers]
ON [dbo].[Claims]
    ([User_Id]);
GO

-- Creating foreign key on [Users_Id] in table 'UsersNoticeBoard'
ALTER TABLE [dbo].[UsersNoticeBoard]
ADD CONSTRAINT [FK_UsersNoticeBoard_Users]
    FOREIGN KEY ([Users_Id])
    REFERENCES [dbo].[Users1]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NoticeBoards_Id] in table 'UsersNoticeBoard'
ALTER TABLE [dbo].[UsersNoticeBoard]
ADD CONSTRAINT [FK_UsersNoticeBoard_NoticeBoard]
    FOREIGN KEY ([NoticeBoards_Id])
    REFERENCES [dbo].[NoticeBoards]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsersNoticeBoard_NoticeBoard'
CREATE INDEX [IX_FK_UsersNoticeBoard_NoticeBoard]
ON [dbo].[UsersNoticeBoard]
    ([NoticeBoards_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------