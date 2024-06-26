﻿IF OBJECT_ID(N'[blg].[__EFMigrationsHistory]') IS NULL
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
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(50) NOT NULL,
    [Description] nvarchar(400) NOT NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [blg].[Tag] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(50) NOT NULL,
    [Description] nvarchar(100) NOT NULL,
    CONSTRAINT [PK_Tag] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [blg].[Post] (
    [Id] uniqueidentifier NOT NULL,
    [UrlSlug] nvarchar(50) NOT NULL,
    [Title] nvarchar(50) NOT NULL,
    [ShortDescription] nvarchar(50) NOT NULL,
    [Description] nvarchar(300) NOT NULL,
    [Content] nvarchar(max) NOT NULL,
    [Published] bit NOT NULL,
    [PostedOn] datetime2 NOT NULL,
    [Modified] datetime2 NULL,
    [Author] nvarchar(40) NOT NULL,
    [Category_Id] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_Post] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Post_Category_Category_Id] FOREIGN KEY ([Category_Id]) REFERENCES [blg].[Category] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [blg].[PostTag] (
    [Post_Id] uniqueidentifier NOT NULL,
    [Tag_Id] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_PostTag] PRIMARY KEY ([Post_Id], [Tag_Id]),
    CONSTRAINT [FK_PostTag_Post_Post_Id] FOREIGN KEY ([Post_Id]) REFERENCES [blg].[Post] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_PostTag_Tag_Tag_Id] FOREIGN KEY ([Tag_Id]) REFERENCES [blg].[Tag] ([Id]) ON DELETE CASCADE
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Description', N'Name') AND [object_id] = OBJECT_ID(N'[blg].[Category]'))
    SET IDENTITY_INSERT [blg].[Category] ON;
INSERT INTO [blg].[Category] ([Id], [Description], [Name])
VALUES ('09a8afe4-d726-43f6-9878-41ca1a4d5b39', N'Articles talking about how we like to deliver software here at CodeBuildDeploy, using the CodeBuildDeploy software as an example / POC delivery project. Includes key areas and concepts such as Continuous Delivery, DevOps Cultures, Automation, Continuous Improvement, Software Engineering Practices and all things Software Delivery.', N'Software Delivery'),
('fc3cb34b-53c9-4342-a139-9ecf6b134008', N'An engineers workstation setup is an imperative part of their capability to deliver software effectively, comfortably and productively. This section details the setups of the CodeBuildDeploy family. It includes articles on how to setup tools that we find useful.', N'Workstation Setup');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Description', N'Name') AND [object_id] = OBJECT_ID(N'[blg].[Category]'))
    SET IDENTITY_INSERT [blg].[Category] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Description', N'Name') AND [object_id] = OBJECT_ID(N'[blg].[Tag]'))
    SET IDENTITY_INSERT [blg].[Tag] ON;
INSERT INTO [blg].[Tag] ([Id], [Description], [Name])
VALUES ('03bbd02b-0b2c-4eff-9874-8561b8bbcafa', N'Linux Operating System''', N'Linux'),
('2a0b3209-f46c-45fe-b7d6-8824a09f9504', N'PowerShell Core and Windows PowerShell', N'PowerShell'),
('313135f2-aa40-481b-9646-0e30052b5462', N'Microsoft .Net Framework', N'.NET'),
('37519618-949c-48dd-a099-9f991b950ada', N'Kubernetes / K8s, used for automating deployment, scaling, and management of containers', N'Kubernetes'),
('45485ccf-cc1c-40c2-ac9b-c74a17cc2711', N'Windows Operating System', N'Windows'),
('48306da3-dab0-4b0e-b063-0acbaf126891', N'Tracking and planning of project issues', N'Issue Management'),
('6961e675-7008-46a5-a75d-1c473ada45ea', N'Git Source Control', N'Git'),
('73dd1c87-742e-4154-b88d-7c2077b90151', N'Unix based Operating System', N'UNIX'),
('79adf12b-1c17-42c9-9d44-5cce1b9f3c82', N'Ansible Automation', N'Ansible'),
('8df60d46-9a9d-46e1-b90d-d9bac8110ef7', N'Docker Containers', N'Containers'),
('f4547542-2b7f-4f9e-8a30-01850657a6b2', N'Azure Cloud', N'Azure'),
('f5bc44bf-f42e-447d-8bed-ee6aa59061e3', N'Python scripting language', N'Python'),
('f7e79415-98c9-46ab-a51e-7afd7fbd9c8a', N'Microsoft ASP.NET', N'ASP.NET');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Description', N'Name') AND [object_id] = OBJECT_ID(N'[blg].[Tag]'))
    SET IDENTITY_INSERT [blg].[Tag] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Author', N'Category_Id', N'Content', N'Description', N'Modified', N'PostedOn', N'Published', N'ShortDescription', N'Title', N'UrlSlug') AND [object_id] = OBJECT_ID(N'[blg].[Post]'))
    SET IDENTITY_INSERT [blg].[Post] ON;
INSERT INTO [blg].[Post] ([Id], [Author], [Category_Id], [Content], [Description], [Modified], [PostedOn], [Published], [ShortDescription], [Title], [UrlSlug])
VALUES ('0b7fe257-0429-4da1-94a2-89dbaa0aa583', N'Mark Pollard', 'fc3cb34b-53c9-4342-a139-9ecf6b134008', N'WSLInterop', N'Read how to seamlessly call Linux commands, such as grep, directly from Powershell on you Windows machine.', '2024-06-07T00:00:00.0000000', '2019-10-09T00:00:00.0000000', CAST(1 AS bit), N'Linux commands on Windows', N'WSL Interop', N'WSLInterop'),
('26d005b9-5505-4646-9194-cd8358817ac8', N'Mark Pollard', 'fc3cb34b-53c9-4342-a139-9ecf6b134008', N'Tools', N'This section lists the tools I frequently use. Some are development tools others utility tools making general day to day working easier.', '2024-06-17T00:00:00.0000000', '2015-03-31T00:00:00.0000000', CAST(1 AS bit), N'My favourite software tools', N'Tools', N'Tools'),
('30c34d37-a663-4879-a294-e1b78431d611', N'Mark Pollard', 'fc3cb34b-53c9-4342-a139-9ecf6b134008', N'Libraries', N'This section lists libraries I often use. These range from logging frameworks to testing tools used for testing / mocking etc.', '2015-03-31T00:00:00.0000000', '2015-03-31T00:00:00.0000000', CAST(1 AS bit), N'Libraries you may like', N'Libraries', N'Libraries'),
('3e54714a-521d-484c-871c-a85ab52642ea', N'Mark Pollard', '09a8afe4-d726-43f6-9878-41ca1a4d5b39', N'TrunkBasedDev', N'Trunk Based Development is a branching strategy that operates with no long-running branches. Commits are made directly on main and releases come from builds of main.', '2021-10-11T00:00:00.0000000', '2021-10-11T00:00:00.0000000', CAST(1 AS bit), N'Trunk Based Development', N'Trunk Based Development', N'TrunkBasedDev'),
('6181d9cc-ef13-42b3-aa66-ef2dc5b54fae', N'Andrew White', '09a8afe4-d726-43f6-9878-41ca1a4d5b39', N'ZeroBugs', N'It is impossible for software engineers to continuously produce bug-free, production ready code. Bugs will always exist. This article is about how we effectively handle such issues, acheiving a state of zero bugs backlog.', '2024-06-18T00:00:00.0000000', '2024-06-18T00:00:00.0000000', CAST(1 AS bit), N'Delete all the bugs from your backlog, now!', N'Zero Bugs', N'ZeroBugs'),
('c5fecdc6-549a-41ce-ad63-fc8db2ab4e01', N'Mark Pollard', 'fc3cb34b-53c9-4342-a139-9ecf6b134008', N'MyShell', N'Having fun customizing my terminal and making my prompt look awesome, with Oh my Posh 3 and Nerd fonts.', '2024-06-10T00:00:00.0000000', '2024-06-10T00:00:00.0000000', CAST(1 AS bit), N'Having fun customizing my PowerShell terminal', N'Oh MY Shell', N'MyShell'),
('ca8d885a-3a24-4c5b-bb33-61a7956b8996', N'Mark Pollard', 'fc3cb34b-53c9-4342-a139-9ecf6b134008', N'PowerShellRemoting', N'This section talks about how to enable and work with powershell remoting.', '2015-05-31T00:00:00.0000000', '2015-05-31T00:00:00.0000000', CAST(1 AS bit), N'Enable and work with powershell remoting', N'PowerShell Remoting', N'PowerShellRemoting'),
('d1ef2a8d-07bd-49cf-a785-a727567e9fc9', N'Mark Pollard', 'fc3cb34b-53c9-4342-a139-9ecf6b134008', N'WslAnsible', N'Read how to setup Ansible on Windows Subsystem for Linux, including setting up for seamlessly calling from windows powershell.', '2024-06-07T00:00:00.0000000', '2019-10-09T00:00:00.0000000', CAST(1 AS bit), N'Setting up Ansible on WSL', N'Ansible on WSL', N'WslAnsible'),
('d8632d22-eb92-41a6-b3c4-dc1235846084', N'Mark Pollard', '09a8afe4-d726-43f6-9878-41ca1a4d5b39', N'DevOpsCLI', N'A container configured with all the CLI tools, scripts and extensions, a full stack DevOps cultured engineer needs for managing Azure environments resources such as AKS clusters.', '2024-06-18T00:00:00.0000000', '2024-06-18T00:00:00.0000000', CAST(1 AS bit), N'Azure Envs CLI container for DevOps teams', N'Azure Envs CLI container', N'devops-cli-azenvs');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Author', N'Category_Id', N'Content', N'Description', N'Modified', N'PostedOn', N'Published', N'ShortDescription', N'Title', N'UrlSlug') AND [object_id] = OBJECT_ID(N'[blg].[Post]'))
    SET IDENTITY_INSERT [blg].[Post] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Post_Id', N'Tag_Id') AND [object_id] = OBJECT_ID(N'[blg].[PostTag]'))
    SET IDENTITY_INSERT [blg].[PostTag] ON;
INSERT INTO [blg].[PostTag] ([Post_Id], [Tag_Id])
VALUES ('0b7fe257-0429-4da1-94a2-89dbaa0aa583', '03bbd02b-0b2c-4eff-9874-8561b8bbcafa'),
('0b7fe257-0429-4da1-94a2-89dbaa0aa583', '2a0b3209-f46c-45fe-b7d6-8824a09f9504'),
('0b7fe257-0429-4da1-94a2-89dbaa0aa583', '45485ccf-cc1c-40c2-ac9b-c74a17cc2711'),
('0b7fe257-0429-4da1-94a2-89dbaa0aa583', '73dd1c87-742e-4154-b88d-7c2077b90151'),
('3e54714a-521d-484c-871c-a85ab52642ea', '6961e675-7008-46a5-a75d-1c473ada45ea'),
('6181d9cc-ef13-42b3-aa66-ef2dc5b54fae', '48306da3-dab0-4b0e-b063-0acbaf126891'),
('c5fecdc6-549a-41ce-ad63-fc8db2ab4e01', '2a0b3209-f46c-45fe-b7d6-8824a09f9504'),
('ca8d885a-3a24-4c5b-bb33-61a7956b8996', '2a0b3209-f46c-45fe-b7d6-8824a09f9504'),
('ca8d885a-3a24-4c5b-bb33-61a7956b8996', '45485ccf-cc1c-40c2-ac9b-c74a17cc2711'),
('d1ef2a8d-07bd-49cf-a785-a727567e9fc9', '03bbd02b-0b2c-4eff-9874-8561b8bbcafa'),
('d1ef2a8d-07bd-49cf-a785-a727567e9fc9', '2a0b3209-f46c-45fe-b7d6-8824a09f9504'),
('d1ef2a8d-07bd-49cf-a785-a727567e9fc9', '45485ccf-cc1c-40c2-ac9b-c74a17cc2711'),
('d1ef2a8d-07bd-49cf-a785-a727567e9fc9', '73dd1c87-742e-4154-b88d-7c2077b90151'),
('d1ef2a8d-07bd-49cf-a785-a727567e9fc9', '79adf12b-1c17-42c9-9d44-5cce1b9f3c82'),
('d8632d22-eb92-41a6-b3c4-dc1235846084', '03bbd02b-0b2c-4eff-9874-8561b8bbcafa'),
('d8632d22-eb92-41a6-b3c4-dc1235846084', '37519618-949c-48dd-a099-9f991b950ada'),
('d8632d22-eb92-41a6-b3c4-dc1235846084', '45485ccf-cc1c-40c2-ac9b-c74a17cc2711'),
('d8632d22-eb92-41a6-b3c4-dc1235846084', '73dd1c87-742e-4154-b88d-7c2077b90151'),
('d8632d22-eb92-41a6-b3c4-dc1235846084', '8df60d46-9a9d-46e1-b90d-d9bac8110ef7'),
('d8632d22-eb92-41a6-b3c4-dc1235846084', 'f4547542-2b7f-4f9e-8a30-01850657a6b2');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Post_Id', N'Tag_Id') AND [object_id] = OBJECT_ID(N'[blg].[PostTag]'))
    SET IDENTITY_INSERT [blg].[PostTag] OFF;
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

