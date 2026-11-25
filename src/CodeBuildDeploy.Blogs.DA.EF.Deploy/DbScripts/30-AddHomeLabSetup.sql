BEGIN TRANSACTION;
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Description', N'Name') AND [object_id] = OBJECT_ID(N'[blg].[Category]'))
    SET IDENTITY_INSERT [blg].[Category] ON;
INSERT INTO [blg].[Category] ([Id], [Description], [Name])
VALUES ('42eac5c9-5d16-49d4-869d-bf050cdaa0e0', N'How I run the network, Proxmox cluster, and Azure infrastructure behind the HomeLab and CodeBuildDeploy.', N'HomeLab Setup');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Description', N'Name') AND [object_id] = OBJECT_ID(N'[blg].[Category]'))
    SET IDENTITY_INSERT [blg].[Category] OFF;

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Author_Id', N'Category_Id', N'Content', N'Description', N'Modified', N'PostedOn', N'Published', N'ShortDescription', N'Title', N'UrlSlug') AND [object_id] = OBJECT_ID(N'[blg].[Post]'))
    SET IDENTITY_INSERT [blg].[Post] ON;
INSERT INTO [blg].[Post] ([Id], [Author_Id], [Category_Id], [Content], [Description], [Modified], [PostedOn], [Published], [ShortDescription], [Title], [UrlSlug])
VALUES ('5229849a-3b83-4b6e-b75d-f0a2153e2a08', '50f29cf4-ab70-4e9f-b225-4fc31ce5b4f6', '42eac5c9-5d16-49d4-869d-bf050cdaa0e0', N'HomeLabProxmoxCluster', N'How I use a three-node Proxmox cluster to run home automation, media services, cameras and development workstations.', NULL, '2026-11-25T00:00:00.0000000', CAST(1 AS bit), N'Virtualization, storage and backups', N'Proxmox cluster', N'homelab-proxmox-cluster'),
('79a91732-fb8b-4e43-aded-1112b6ed61a9', '50f29cf4-ab70-4e9f-b225-4fc31ce5b4f6', '42eac5c9-5d16-49d4-869d-bf050cdaa0e0', N'HomeLabAzureInfrastructure', N'How I provision CodeBuildDeploy on Azure with Terraform and deploy the application to Kubernetes with Helm.', NULL, '2026-11-25T00:00:00.0000000', CAST(1 AS bit), N'Terraform, Azure DevOps and AKS', N'Azure Infrastructure', N'homelab-azure-infrastructure'),
('cd018418-5306-418e-9469-d137d38f3395', '50f29cf4-ab70-4e9f-b225-4fc31ce5b4f6', '42eac5c9-5d16-49d4-869d-bf050cdaa0e0', N'HomeLabNetworkAndEdge', N'How I run the HomeLab network and publish the CodeBuildDeploy dev sites through a private connection to Azure.', NULL, '2026-11-25T00:00:00.0000000', CAST(1 AS bit), N'Routing, DNS and private ingress', N'Network and edge', N'homelab-network-and-edge');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Author_Id', N'Category_Id', N'Content', N'Description', N'Modified', N'PostedOn', N'Published', N'ShortDescription', N'Title', N'UrlSlug') AND [object_id] = OBJECT_ID(N'[blg].[Post]'))
    SET IDENTITY_INSERT [blg].[Post] OFF;

INSERT INTO [blg].[__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20261125111409_AddHomeLabSetup', N'10.0.15');

COMMIT;
GO

