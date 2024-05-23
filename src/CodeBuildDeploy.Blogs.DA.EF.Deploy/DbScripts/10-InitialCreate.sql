IF OBJECT_ID(N'[blg].[__EFMigrationsHistory]') IS NULL
BEGIN
    IF SCHEMA_ID(N'blg') IS NULL EXEC(N'CREATE SCHEMA [blg];');
    CREATE TABLE [blg].[__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF SCHEMA_ID(N'blg') IS NULL EXEC(N'CREATE SCHEMA [blg];');
GO

CREATE TABLE [blg].[Category] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NOT NULL,
    [Description] nvarchar(50) NOT NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [blg].[Tag] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NOT NULL,
    [Description] nvarchar(200) NOT NULL,
    CONSTRAINT [PK_Tag] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [blg].[Post] (
    [Id] int NOT NULL IDENTITY,
    [UrlSlug] nvarchar(50) NOT NULL,
    [Title] nvarchar(50) NOT NULL,
    [ShortDescription] nvarchar(50) NOT NULL,
    [Description] nvarchar(150) NOT NULL,
    [Content] nvarchar(max) NOT NULL,
    [Published] bit NOT NULL,
    [PostedOn] datetime2 NOT NULL,
    [Modified] datetime2 NULL,
    [Category_Id] int NOT NULL,
    CONSTRAINT [PK_Post] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Post_Category_Category_Id] FOREIGN KEY ([Category_Id]) REFERENCES [blg].[Category] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [blg].[PostTag] (
    [Post_Id] int NOT NULL,
    [Tag_Id] int NOT NULL,
    CONSTRAINT [PK_PostTag] PRIMARY KEY ([Post_Id], [Tag_Id]),
    CONSTRAINT [FK_PostTag_Post_Post_Id] FOREIGN KEY ([Post_Id]) REFERENCES [blg].[Post] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_PostTag_Tag_Tag_Id] FOREIGN KEY ([Tag_Id]) REFERENCES [blg].[Tag] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Post_Category_Id] ON [blg].[Post] ([Category_Id]);
GO

CREATE INDEX [IX_PostTag_Tag_Id] ON [blg].[PostTag] ([Tag_Id]);
GO

INSERT INTO [blg].[__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240523111930_InitialCreate', N'8.0.3');
GO

COMMIT;
GO

