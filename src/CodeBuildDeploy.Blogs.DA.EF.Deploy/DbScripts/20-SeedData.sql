SET IDENTITY_INSERT [dbo].[Category] ON

INSERT INTO [dbo].[Category] ([Id], [Name], [Description]) VALUES (1, N'General', N'General info topics')
INSERT INTO [dbo].[Category] ([Id], [Name], [Description]) VALUES (2, N'Software Delivery', N'Blogs on topics like Continuous Delivery, DevOps Cultures, Automation, Continuous Improvement, Software Engineering Practices and all things Software Delivery')
INSERT INTO [dbo].[Category] ([Id], [Name], [Description]) VALUES (3, N'Workstation Setup', N'Blogs on setting up my workstation')

SET IDENTITY_INSERT [dbo].[Category] OFF

SET IDENTITY_INSERT [dbo].[Tag] ON

INSERT INTO [dbo].[Tag] ([Id], [Name], [Description]) VALUES (1, N'.NET', N'Microsoft .Net Framework')
INSERT INTO [dbo].[Tag] ([Id], [Name], [Description]) VALUES (2, N'PowerShell', N'PowerShell Core and Windows PowerShell')
INSERT INTO [dbo].[Tag] ([Id], [Name], [Description]) VALUES (3, N'ASP.NET', N'Microsoft ASP.NET')
INSERT INTO [dbo].[Tag] ([Id], [Name], [Description]) VALUES (4, N'Windows', N'Windows Operating System')
INSERT INTO [dbo].[Tag] ([Id], [Name], [Description]) VALUES (5, N'UNIX', N'Unix based Operating System')
INSERT INTO [dbo].[Tag] ([Id], [Name], [Description]) VALUES (6, N'Linux', N'Linux Operating System')
INSERT INTO [dbo].[Tag] ([Id], [Name], [Description]) VALUES (7, N'Python', N'Python scripting language')
INSERT INTO [dbo].[Tag] ([Id], [Name], [Description]) VALUES (8, N'Azure', N'Azure Cloud')
INSERT INTO [dbo].[Tag] ([Id], [Name], [Description]) VALUES (9, N'Ansible', N'Ansible Automation')
INSERT INTO [dbo].[Tag] ([Id], [Name], [Description]) VALUES (10, N'Git', N'Git Source Control')

SET IDENTITY_INSERT [dbo].[Tag] OFF

SET IDENTITY_INSERT [dbo].[Post] ON

INSERT INTO [dbo].[Post] ([Id], [Title], [ShortDescription], [Description], [Content], [Published], [PostedOn], [Modified], [Category_Id], [UrlSlug]) VALUES (1, N'Libraries', N'Libraries you may like', N'This section lists libraries I often use. These range from logging frameworks to testing tools used for testing / mocking etc.', N'Libraries', 1, N'2015-03-31 00:00:00', N'2015-03-31 00:00:00', 3, N'Libraries')
INSERT INTO [dbo].[Post] ([Id], [Title], [ShortDescription], [Description], [Content], [Published], [PostedOn], [Modified], [Category_Id], [UrlSlug]) VALUES (2, N'Links', N'Useful links and resources', N'Links to External Articles / Resources.', N'Links', 1, N'2015-03-31 00:00:00', N'2015-03-31 00:00:00', 1, N'Links')
INSERT INTO [dbo].[Post] ([Id], [Title], [ShortDescription], [Description], [Content], [Published], [PostedOn], [Modified], [Category_Id], [UrlSlug]) VALUES (3, N'Tools', N'My favourite software tools', N'This section lists the tools I frequently use. Some are development tools others utility tools making general day to day working easier.', N'Tools', 1, N'2015-03-31 00:00:00', N'2015-03-31 00:00:00', 3, N'Tools')
INSERT INTO [dbo].[Post] ([Id], [Title], [ShortDescription], [Description], [Content], [Published], [PostedOn], [Modified], [Category_Id], [UrlSlug]) VALUES (4, N'PowerShell Grep', N'Grep for Windows PowerShell.', N'Need more...', N'PowerShellGrep', 1, N'2015-05-31 00:00:00', N'2015-05-31 00:00:00', 3, N'PowerShellGrep')
INSERT INTO [dbo].[Post] ([Id], [Title], [ShortDescription], [Description], [Content], [Published], [PostedOn], [Modified], [Category_Id], [UrlSlug]) VALUES (5, N'PowerShell Remoting', N'Enable and work with powershell remoting.', N'This section talks about how to enable and work with powershell remoting.', N'PowerShellRemoting', 1, N'2015-05-31 00:00:00', N'2015-05-31 00:00:00', 3, N'PowerShellRemoting')
INSERT INTO [dbo].[Post] ([Id], [Title], [ShortDescription], [Description], [Content], [Published], [PostedOn], [Modified], [Category_Id], [UrlSlug])  VALUES (6, N'WSL and Ansible', N'Setting up WSL with Ansible.', N'How to setup Ansible on Windows Subsystem for Linux.', N'WslAnsible', 1, N'2019-10-09 00:00:00', N'2019-10-09 00:00:00', 3, N'WslAnsible')
INSERT INTO [dbo].[Post] ([Id], [Title], [ShortDescription], [Description], [Content], [Published], [PostedOn], [Modified], [Category_Id], [UrlSlug])  VALUES (7, N'Trunk Based Development', N'Trunk Based Development', N'Trunk Based Development.', N'TrunkBasedDev', 1, N'2021-10-11 00:00:00', N'2021-10-11 00:00:00', 2, N'TrunkBasedDev')

SET IDENTITY_INSERT [dbo].[Post] OFF

INSERT INTO [dbo].[PostTag] ([Post_Id], [Tag_Id]) VALUES (4, 2)
INSERT INTO [dbo].[PostTag] ([Post_Id], [Tag_Id]) VALUES (4, 4)
INSERT INTO [dbo].[PostTag] ([Post_Id], [Tag_Id]) VALUES (5, 2)
INSERT INTO [dbo].[PostTag] ([Post_Id], [Tag_Id]) VALUES (5, 4)
INSERT INTO [dbo].[PostTag] ([Post_Id], [Tag_Id]) VALUES (6, 2)
INSERT INTO [dbo].[PostTag] ([Post_Id], [Tag_Id]) VALUES (6, 4)
INSERT INTO [dbo].[PostTag] ([Post_Id], [Tag_Id]) VALUES (6, 5)
INSERT INTO [dbo].[PostTag] ([Post_Id], [Tag_Id]) VALUES (6, 6)
INSERT INTO [dbo].[PostTag] ([Post_Id], [Tag_Id]) VALUES (6, 9)
INSERT INTO [dbo].[PostTag] ([Post_Id], [Tag_Id]) VALUES (7, 10)