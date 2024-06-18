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
                    CategoryId = new Guid("fc3cb34b-53c9-4342-a139-9ecf6b134008"), 
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
                    CategoryId = new Guid("fc3cb34b-53c9-4342-a139-9ecf6b134008"),
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
                    CategoryId = new Guid("fc3cb34b-53c9-4342-a139-9ecf6b134008"),
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
                    CategoryId = new Guid("fc3cb34b-53c9-4342-a139-9ecf6b134008"),
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
                    CategoryId = new Guid("fc3cb34b-53c9-4342-a139-9ecf6b134008"),
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
                    CategoryId = new Guid("09a8afe4-d726-43f6-9878-41ca1a4d5b39"),
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
                    CategoryId = new Guid("fc3cb34b-53c9-4342-a139-9ecf6b134008"),
                    UrlSlug = "MyShell" },

                new() {
                    Id = new Guid("d8632d22-eb92-41a6-b3c4-dc1235846084"),
                    Title = "AKS CLI container",
                    ShortDescription = "AKS CLI container for DevOps Teams",
                    Description = "A container configured with all the CLI tools, scripts and extensions, a full stack DevOps cultured engineer needs for managing the AKS cluster instance.",
                    Content = "DevOpsCLI",
                    Published = true,
                    PostedOn = DateTime.Parse("2024-06-18 00:00:00"),
                    Modified = DateTime.Parse("2024-06-18 00:00:00"),
                    CategoryId = new Guid("09a8afe4-d726-43f6-9878-41ca1a4d5b39"),
                    UrlSlug = "devops-cli-aks" }
            ];
        }
    }
}
