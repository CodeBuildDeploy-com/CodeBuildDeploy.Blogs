CREATE TABLE [dbo].[Category]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(200) NOT NULL
)

SET IDENTITY_INSERT [dbo].[Category] ON

INSERT INTO [dbo].[Category] ([Id], [Name], [Description]) VALUES (1, N'General', N'General info topics')
INSERT INTO [dbo].[Category] ([Id], [Name], [Description]) VALUES (2, N'Software Delivery', N'Blogs on topics like Continuous Delivery, DevOps Cultures, Automation, Continuous Improvement, Software Engineering Practices and all things Software Delivery')
INSERT INTO [dbo].[Category] ([Id], [Name], [Description]) VALUES (3, N'Workstation Setup', N'Blogs on setting up my workstation')

SET IDENTITY_INSERT [dbo].[Category] OFF