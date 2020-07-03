IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Classes] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Active] bit NOT NULL,
    CONSTRAINT [PK_Classes] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Schedules] (
    [SubjectId] int NOT NULL,
    [ClassId] int NOT NULL,
    [DayOfWeek] int NOT NULL,
    [Name] nvarchar(max) NULL,
    [Active] bit NOT NULL,
    CONSTRAINT [PK_Schedules] PRIMARY KEY ([SubjectId], [ClassId])
);

GO

CREATE TABLE [Students] (
    [Id] int NOT NULL IDENTITY,
    [FirstName] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    [DateOfBirth] nvarchar(max) NULL,
    [ClassId] int NOT NULL,
    [Active] bit NOT NULL,
    CONSTRAINT [PK_Students] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Subjects] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Active] bit NOT NULL,
    CONSTRAINT [PK_Subjects] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200703040705_InitialCreate', N'3.1.5');

GO