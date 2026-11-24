BEGIN TRANSACTION;
ALTER TABLE [blg].[Post] ADD [Author_Id] uniqueidentifier NULL;

CREATE TABLE [blg].[Author] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(40) NOT NULL,
    [Biography] nvarchar(2000) NULL,
    [AvatarPath] nvarchar(200) NULL,
    [LinkedInUrl] nvarchar(400) NULL,
    [TwitterUrl] nvarchar(400) NULL,
    [FacebookUrl] nvarchar(400) NULL,
    CONSTRAINT [PK_Author] PRIMARY KEY ([Id])
);

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AvatarPath', N'Biography', N'FacebookUrl', N'LinkedInUrl', N'Name', N'TwitterUrl') AND [object_id] = OBJECT_ID(N'[blg].[Author]'))
    SET IDENTITY_INSERT [blg].[Author] ON;
INSERT INTO [blg].[Author] ([Id], [AvatarPath], [Biography], [FacebookUrl], [LinkedInUrl], [Name], [TwitterUrl])
VALUES ('1e7c80bb-eaaa-4d36-9e28-573bf9c0e3d4', N'/img/about/andrew.white.png', CONCAT(CAST(N'A highly motivated Senior Software Engineer, Andrew has a wide range of commercial experience in designing, developing, deploying, maintaining, and supporting a variety of systems. He is focused on quality of delivery, continually looking for opportunities to improve across the full software delivery lifecycle.' AS nvarchar(max)), nchar(10), nchar(10), N'Andrew has extensive knowledge of the Microsoft development ecosystem having worked with all versions of the .NET platform to develop enterprise applications.'), NULL, NULL, N'Andy White', NULL),
('50f29cf4-ab70-4e9f-b225-4fc31ce5b4f6', N'/img/about/me-profile-sm.jpg', N'I am a senior software engineering and technical leader / Microsoft technologies technical architect, with a strong passion for continuous delivery. I am a firm believer in empowered teams with true DevOps cultures. I encourage responsibility over role, high quality and full stack engineers, showing ownership of the software and its behaviour, end to end, from requirements maturing all the way through to its continual and successful running in Production.', N'https://www.facebook.com/m4rkpollard', N'https://www.linkedin.com/in/mark-pollard-351aa163', N'Mark Pollard', N'https://twitter.com/m4rk5');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AvatarPath', N'Biography', N'FacebookUrl', N'LinkedInUrl', N'Name', N'TwitterUrl') AND [object_id] = OBJECT_ID(N'[blg].[Author]'))
    SET IDENTITY_INSERT [blg].[Author] OFF;

INSERT INTO [blg].[Author] ([Id], [Name])
SELECT NEWID(), [LegacyName]
FROM (
    SELECT DISTINCT [Author] AS [LegacyName]
    FROM [blg].[Post]
    WHERE [UrlSlug] <> N'ZeroBugs'
        AND [Author] NOT IN (N'Mark Pollard', N'Andrew White', N'Andy White')
) AS [ExistingAuthors];

UPDATE [Post]
SET [Author_Id] = [Author].[Id]
FROM [blg].[Post] AS [Post]
JOIN [blg].[Author] AS [Author] ON [Author].[Name] =
    CASE
        WHEN [Post].[UrlSlug] = N'ZeroBugs' OR [Post].[Author] = N'Andrew White' THEN N'Andy White'
        ELSE [Post].[Author]
    END;

DECLARE @var nvarchar(max);
SELECT @var = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[blg].[Post]') AND [c].[name] = N'Author_Id');
IF @var IS NOT NULL EXEC(N'ALTER TABLE [blg].[Post] DROP CONSTRAINT ' + @var + ';');
ALTER TABLE [blg].[Post] ALTER COLUMN [Author_Id] uniqueidentifier NOT NULL;

CREATE INDEX [IX_Post_Author_Id] ON [blg].[Post] ([Author_Id]);

ALTER TABLE [blg].[Post] ADD CONSTRAINT [FK_Post_Author_Author_Id] FOREIGN KEY ([Author_Id]) REFERENCES [blg].[Author] ([Id]) ON DELETE NO ACTION;

DECLARE @var1 nvarchar(max);
SELECT @var1 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[blg].[Post]') AND [c].[name] = N'Author');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [blg].[Post] DROP CONSTRAINT ' + @var1 + ';');
ALTER TABLE [blg].[Post] DROP COLUMN [Author];

INSERT INTO [blg].[__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20261124183644_AddBlogAuthors', N'10.0.15');

COMMIT;
GO

