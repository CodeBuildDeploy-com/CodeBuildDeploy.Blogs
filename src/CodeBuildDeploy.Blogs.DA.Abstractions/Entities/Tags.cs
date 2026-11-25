namespace CodeBuildDeploy.Blogs.DA.Entities
{
    public static class Tags
    {
        public static IEnumerable<Tag> GetDefault()
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
                new() { Id = new Guid("6961e675-7008-46a5-a75d-1c473ada45ea"), Name = "Git", Description = "Git Source Control" },
                new() { Id = new Guid("8df60d46-9a9d-46e1-b90d-d9bac8110ef7"), Name = "Containers", Description = "Docker Containers" },
                new() { Id = new Guid("37519618-949c-48dd-a099-9f991b950ada"), Name = "Kubernetes", Description = "Kubernetes / K8s, used for automating deployment, scaling, and management of containers" },
                new() { Id = new Guid("48306da3-dab0-4b0e-b063-0acbaf126891"), Name = "Issue Management", Description = "Tracking and planning of project issues" },
                new() { Id = new Guid("79215531-adc8-4635-8777-b1a859eee870"), Name = "Network", Description = "Routing, switching and network infrastructure" },
                new() { Id = new Guid("9dd59d5f-d44e-4cc1-b16b-ef4ed12688e6"), Name = "FriendlyWrt", Description = "FriendlyElec firmware based on OpenWrt" },
                new() { Id = new Guid("becbd21d-f175-48fa-a0b1-473920a72709"), Name = "DNS", Description = "Domain Name System and recursive resolvers" },
                new() { Id = new Guid("a5b98f7f-be9e-4bf7-9645-db7c5a1aa1f2"), Name = "Pi-hole", Description = "Network-wide DNS filtering" },
                new() { Id = new Guid("451c526e-fa0e-42ca-a347-912131719bd5"), Name = "NGINX", Description = "NGINX and Nginx Proxy Manager" },
                new() { Id = new Guid("716cfff3-594a-4074-875b-d5b958807910"), Name = "WireGuard", Description = "WireGuard VPN tunnels" },
                new() { Id = new Guid("04e9a93b-dd12-4217-99cb-ece19c0b567f"), Name = "Proxmox", Description = "Proxmox Virtual Environment" },
                new() { Id = new Guid("1e82ea7d-e3a9-4911-b8c0-2a632bbba34a"), Name = "LXC", Description = "Linux Containers" },
                new() { Id = new Guid("5feaaaff-76c9-4376-8ba7-af5314f4721d"), Name = "Terraform", Description = "Infrastructure as code with Terraform" },
                new() { Id = new Guid("f02e7311-6c1c-497b-a9f9-7a55132c517b"), Name = "Azure DevOps", Description = "Azure DevOps pipelines and deployments" },
                new() { Id = new Guid("41f7feda-af81-4e8c-85bf-0c33188bfeb3"), Name = "Helm", Description = "Packaging and deploying Kubernetes applications" }
            ];
        }
    }
}
