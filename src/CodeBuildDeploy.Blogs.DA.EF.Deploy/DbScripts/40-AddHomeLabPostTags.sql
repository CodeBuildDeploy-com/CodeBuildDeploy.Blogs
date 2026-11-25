BEGIN TRANSACTION;
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Post_Id', N'Tag_Id') AND [object_id] = OBJECT_ID(N'[blg].[PostTag]'))
    SET IDENTITY_INSERT [blg].[PostTag] ON;
INSERT INTO [blg].[PostTag] ([Post_Id], [Tag_Id])
VALUES ('5229849a-3b83-4b6e-b75d-f0a2153e2a08', '03bbd02b-0b2c-4eff-9874-8561b8bbcafa'),
('5229849a-3b83-4b6e-b75d-f0a2153e2a08', '8df60d46-9a9d-46e1-b90d-d9bac8110ef7'),
('79a91732-fb8b-4e43-aded-1112b6ed61a9', '37519618-949c-48dd-a099-9f991b950ada'),
('79a91732-fb8b-4e43-aded-1112b6ed61a9', '8df60d46-9a9d-46e1-b90d-d9bac8110ef7'),
('79a91732-fb8b-4e43-aded-1112b6ed61a9', 'f4547542-2b7f-4f9e-8a30-01850657a6b2'),
('cd018418-5306-418e-9469-d137d38f3395', '03bbd02b-0b2c-4eff-9874-8561b8bbcafa'),
('cd018418-5306-418e-9469-d137d38f3395', '8df60d46-9a9d-46e1-b90d-d9bac8110ef7');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Post_Id', N'Tag_Id') AND [object_id] = OBJECT_ID(N'[blg].[PostTag]'))
    SET IDENTITY_INSERT [blg].[PostTag] OFF;

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Description', N'Name') AND [object_id] = OBJECT_ID(N'[blg].[Tag]'))
    SET IDENTITY_INSERT [blg].[Tag] ON;
INSERT INTO [blg].[Tag] ([Id], [Description], [Name])
VALUES ('04e9a93b-dd12-4217-99cb-ece19c0b567f', N'Proxmox Virtual Environment', N'Proxmox'),
('1e82ea7d-e3a9-4911-b8c0-2a632bbba34a', N'Linux Containers', N'LXC'),
('41f7feda-af81-4e8c-85bf-0c33188bfeb3', N'Packaging and deploying Kubernetes applications', N'Helm'),
('451c526e-fa0e-42ca-a347-912131719bd5', N'NGINX and Nginx Proxy Manager', N'NGINX'),
('5feaaaff-76c9-4376-8ba7-af5314f4721d', N'Infrastructure as code with Terraform', N'Terraform'),
('716cfff3-594a-4074-875b-d5b958807910', N'WireGuard VPN tunnels', N'WireGuard'),
('79215531-adc8-4635-8777-b1a859eee870', N'Routing, switching and network infrastructure', N'Network'),
('9dd59d5f-d44e-4cc1-b16b-ef4ed12688e6', N'FriendlyElec firmware based on OpenWrt', N'FriendlyWrt'),
('a5b98f7f-be9e-4bf7-9645-db7c5a1aa1f2', N'Network-wide DNS filtering', N'Pi-hole'),
('becbd21d-f175-48fa-a0b1-473920a72709', N'Domain Name System and recursive resolvers', N'DNS'),
('f02e7311-6c1c-497b-a9f9-7a55132c517b', N'Azure DevOps pipelines and deployments', N'Azure DevOps');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Description', N'Name') AND [object_id] = OBJECT_ID(N'[blg].[Tag]'))
    SET IDENTITY_INSERT [blg].[Tag] OFF;

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Post_Id', N'Tag_Id') AND [object_id] = OBJECT_ID(N'[blg].[PostTag]'))
    SET IDENTITY_INSERT [blg].[PostTag] ON;
INSERT INTO [blg].[PostTag] ([Post_Id], [Tag_Id])
VALUES ('5229849a-3b83-4b6e-b75d-f0a2153e2a08', '04e9a93b-dd12-4217-99cb-ece19c0b567f'),
('5229849a-3b83-4b6e-b75d-f0a2153e2a08', '1e82ea7d-e3a9-4911-b8c0-2a632bbba34a'),
('79a91732-fb8b-4e43-aded-1112b6ed61a9', '41f7feda-af81-4e8c-85bf-0c33188bfeb3'),
('79a91732-fb8b-4e43-aded-1112b6ed61a9', '5feaaaff-76c9-4376-8ba7-af5314f4721d'),
('79a91732-fb8b-4e43-aded-1112b6ed61a9', 'f02e7311-6c1c-497b-a9f9-7a55132c517b'),
('cd018418-5306-418e-9469-d137d38f3395', '451c526e-fa0e-42ca-a347-912131719bd5'),
('cd018418-5306-418e-9469-d137d38f3395', '716cfff3-594a-4074-875b-d5b958807910'),
('cd018418-5306-418e-9469-d137d38f3395', '79215531-adc8-4635-8777-b1a859eee870'),
('cd018418-5306-418e-9469-d137d38f3395', '9dd59d5f-d44e-4cc1-b16b-ef4ed12688e6'),
('cd018418-5306-418e-9469-d137d38f3395', 'a5b98f7f-be9e-4bf7-9645-db7c5a1aa1f2'),
('cd018418-5306-418e-9469-d137d38f3395', 'becbd21d-f175-48fa-a0b1-473920a72709');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Post_Id', N'Tag_Id') AND [object_id] = OBJECT_ID(N'[blg].[PostTag]'))
    SET IDENTITY_INSERT [blg].[PostTag] OFF;

INSERT INTO [blg].[__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20261125141202_AddHomeLabPostTags', N'10.0.15');

COMMIT;
GO

