namespace CodeBuildDeploy.Blogs.DA.Entities
{
    public class Category : EntityBase
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public IList<Post> Posts { get; set; } = new List<Post>();
    }
}
