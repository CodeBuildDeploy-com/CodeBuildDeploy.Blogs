namespace CodeBuildDeploy.Blogs.DA.Entities
{
    public class Author : EntityBase
    {
        public string Name { get; set; } = null!;

        public string? Biography { get; set; }

        public string? AvatarPath { get; set; }

        public string? LinkedInUrl { get; set; }

        public string? TwitterUrl { get; set; }

        public string? FacebookUrl { get; set; }
    }
}
