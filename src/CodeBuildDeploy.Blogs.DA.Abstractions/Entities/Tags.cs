namespace CodeBuildDeploy.Blogs.DA.Entities
{
    public static class Tags
    {
        public static IEnumerable<Tag> GetAll()
        {
            return
            [
                new() { Id = new Guid("313135f2-aa40-481b-9646-0e30052b5462"), Name = ".NET", Description = "Microsoft .Net Framework" },
                new() { Id = new Guid("2a0b3209-f46c-45fe-b7d6-8824a09f9504"), Name = "PowerShell", Description = "PowerShell Core and Windows PowerShell" },
                new() { Id = new Guid("f7e79415-98c9-46ab-a51e-7afd7fbd9c8a"), Name = "ASP.NET", Description = "Microsoft ASP.NET" },
                new() { Id = new Guid("45485ccf-cc1c-40c2-ac9b-c74a17cc2711"), Name = "Windows", Description = "Windows Operating System" },
                new() { Id = new Guid("73dd1c87-742e-4154-b88d-7c2077b90151"), Name = "UNIX", Description = "Unix based Operating System" },
                new() { Id = new Guid("03bbd02b-0b2c-4eff-9874-8561b8bbcafa"), Name = "Linux", Description = "Linux Operating System'" },
                new() { Id = new Guid("f5bc44bf-f42e-447d-8bed-ee6aa59061e3"), Name = "Python", Description = "Python scripting language" },
                new() { Id = new Guid("f4547542-2b7f-4f9e-8a30-01850657a6b2"), Name = "Azure", Description = "Azure Cloud" },
                new() { Id = new Guid("79adf12b-1c17-42c9-9d44-5cce1b9f3c82"), Name = "Ansible", Description = "Ansible Automation" },
                new() { Id = new Guid("6961e675-7008-46a5-a75d-1c473ada45ea"), Name = "Git", Description = "Git Source Control" }
            ];
        }
    }
}
