namespace CodeBuildDeploy.Blogs.DA.Entities
{
    public static class Posts
    {
        public static IEnumerable<Post> GetDefault()
        {
            return
            [
                new() { 
                    Id = new Guid("30c34d37-a663-4879-a294-e1b78431d611"), 
                    Title = "Libraries",
                    ShortDescription = "Libraries you may like",
                    Description = "This section lists libraries I often use. These range from logging frameworks to testing tools used for testing / mocking etc.",
                    Content = "Libraries",
                    Published = true,
                    PostedOn = DateTime.Parse("2015-03-31 00:00:00"),
                    Modified = DateTime.Parse("2015-03-31 00:00:00"),
                    AuthorId = Authors.MarkPollardId,
                    CategoryId = Categories.WorkstationSetupId,
                    UrlSlug = "Libraries" },
                
                new() {
                    Id = new Guid("26d005b9-5505-4646-9194-cd8358817ac8"),
                    Title = "Tools",
                    ShortDescription = "My favourite software tools",
                    Description = "This section lists the tools I frequently use. Some are development tools others utility tools making general day to day working easier.",
                    Content = "Tools",
                    Published = true,
                    PostedOn = DateTime.Parse("2015-03-31 00:00:00"),
                    Modified = DateTime.Parse("2024-06-17 00:00:00"),
                    AuthorId = Authors.MarkPollardId,
                    CategoryId = Categories.WorkstationSetupId,
                    UrlSlug = "Tools" },
                
                new() {
                    Id = new Guid("ca8d885a-3a24-4c5b-bb33-61a7956b8996"),
                    Title = "PowerShell Remoting",
                    ShortDescription = "Enable and work with powershell remoting",
                    Description = "This section talks about how to enable and work with powershell remoting.",
                    Content = "PowerShellRemoting",
                    Published = true,
                    PostedOn = DateTime.Parse("2015-05-31 00:00:00"),
                    Modified = DateTime.Parse("2015-05-31 00:00:00"),
                    AuthorId = Authors.MarkPollardId,
                    CategoryId = Categories.WorkstationSetupId,
                    UrlSlug = "PowerShellRemoting" },

                new() {
                    Id = new Guid("0b7fe257-0429-4da1-94a2-89dbaa0aa583"),
                    Title = "WSL Interop",
                    ShortDescription = "Linux commands on Windows",
                    Description = "Read how to seamlessly call Linux commands, such as grep, directly from Powershell on you Windows machine.",
                    Content = "WSLInterop",
                    Published = true,
                    PostedOn = DateTime.Parse("2019-10-09 00:00:00"),
                    Modified = DateTime.Parse("2024-06-07 00:00:00"),
                    AuthorId = Authors.MarkPollardId,
                    CategoryId = Categories.WorkstationSetupId,
                    UrlSlug = "WSLInterop" },

                new() {
                    Id = new Guid("d1ef2a8d-07bd-49cf-a785-a727567e9fc9"),
                    Title = "Ansible on WSL",
                    ShortDescription = "Setting up Ansible on WSL",
                    Description = "Read how to setup Ansible on Windows Subsystem for Linux, including setting up for seamlessly calling from windows powershell.",
                    Content = "WslAnsible",
                    Published = true,
                    PostedOn = DateTime.Parse("2019-10-09 00:00:00"),
                    Modified = DateTime.Parse("2024-06-07 00:00:00"),
                    AuthorId = Authors.MarkPollardId,
                    CategoryId = Categories.WorkstationSetupId,
                    UrlSlug = "WslAnsible" },
                
                new() {
                    Id = new Guid("3e54714a-521d-484c-871c-a85ab52642ea"),
                    Title = "Trunk Based Development",
                    ShortDescription = "Trunk Based Development",
                    Description = "Trunk Based Development is a branching strategy that operates with no long-running branches. Commits are made directly on main and releases come from builds of main.",
                    Content = "TrunkBasedDev",
                    Published = true,
                    PostedOn = DateTime.Parse("2021-10-11 00:00:00"),
                    Modified = DateTime.Parse("2021-10-11 00:00:00"),
                    AuthorId = Authors.MarkPollardId,
                    CategoryId = Categories.SoftwareDeliveryId,
                    UrlSlug = "TrunkBasedDev" },

                new() {
                    Id = new Guid("c5fecdc6-549a-41ce-ad63-fc8db2ab4e01"),
                    Title = "Oh MY Shell",
                    ShortDescription = "Having fun customizing my PowerShell terminal",
                    Description = "Having fun customizing my terminal and making my prompt look awesome, with Oh my Posh 3 and Nerd fonts.",
                    Content = "MyShell",
                    Published = true,
                    PostedOn = DateTime.Parse("2024-06-10 00:00:00"),
                    Modified = DateTime.Parse("2024-06-10 00:00:00"),
                    AuthorId = Authors.MarkPollardId,
                    CategoryId = Categories.WorkstationSetupId,
                    UrlSlug = "MyShell" },

                new() {
                    Id = new Guid("d8632d22-eb92-41a6-b3c4-dc1235846084"),
                    Title = "Azure Envs CLI container",
                    ShortDescription = "Azure Envs CLI container for DevOps teams",
                    Description = "A container configured with all the CLI tools, scripts and extensions, a full stack DevOps cultured engineer needs for managing Azure environments resources such as AKS clusters.",
                    Content = "DevOpsCLI",
                    Published = true,
                    PostedOn = DateTime.Parse("2024-06-18 00:00:00"),
                    Modified = DateTime.Parse("2024-06-18 00:00:00"),
                    AuthorId = Authors.MarkPollardId,
                    CategoryId = Categories.SoftwareDeliveryId,
                    UrlSlug = "devops-cli-azenvs" },


                new() {
                    Id = new Guid("6181d9cc-ef13-42b3-aa66-ef2dc5b54fae"),
                    Title = "Zero Bugs",
                    ShortDescription = "Delete all the bugs from your backlog, now!",
                    Description = "It is impossible for software engineers to continuously produce bug-free, production ready code. Bugs will always exist. This article is about how we effectively handle such issues, acheiving a state of zero bugs backlog.",
                    Content = "ZeroBugs",
                    Published = true,
                    PostedOn = DateTime.Parse("2024-06-18 00:00:00"),
                    Modified = DateTime.Parse("2024-06-18 00:00:00"),
                    AuthorId = Authors.AndyWhiteId,
                    CategoryId = Categories.SoftwareDeliveryId,
                    UrlSlug = "ZeroBugs" },

                new()
                {
                    Id = new Guid("cd018418-5306-418e-9469-d137d38f3395"),
                    Title = "Network and edge",
                    ShortDescription = "Routing, DNS and private ingress",
                    Description = "How I run the HomeLab network and publish the CodeBuildDeploy dev sites through a private connection to Azure.",
                    Content = "HomeLabNetworkAndEdge",
                    Published = true,
                    PostedOn = new DateTime(2026, 11, 25),
                    AuthorId = Authors.MarkPollardId,
                    CategoryId = Categories.HomeLabSetupId,
                    UrlSlug = "homelab-network-and-edge"
                },

                new()
                {
                    Id = new Guid("5229849a-3b83-4b6e-b75d-f0a2153e2a08"),
                    Title = "Proxmox cluster",
                    ShortDescription = "Virtualization, storage and backups",
                    Description = "How I use a three-node Proxmox cluster to run home automation, media services, cameras and development workstations.",
                    Content = "HomeLabProxmoxCluster",
                    Published = true,
                    PostedOn = new DateTime(2026, 11, 25),
                    AuthorId = Authors.MarkPollardId,
                    CategoryId = Categories.HomeLabSetupId,
                    UrlSlug = "homelab-proxmox-cluster"
                },

                new()
                {
                    Id = new Guid("79a91732-fb8b-4e43-aded-1112b6ed61a9"),
                    Title = "Azure Infrastructure",
                    ShortDescription = "Terraform, Azure DevOps and AKS",
                    Description = "How I provision CodeBuildDeploy on Azure with Terraform and deploy the application to Kubernetes with Helm.",
                    Content = "HomeLabAzureInfrastructure",
                    Published = true,
                    PostedOn = new DateTime(2026, 11, 25),
                    AuthorId = Authors.MarkPollardId,
                    CategoryId = Categories.HomeLabSetupId,
                    UrlSlug = "homelab-azure-infrastructure"
                }
            ];
        }
    }
}
