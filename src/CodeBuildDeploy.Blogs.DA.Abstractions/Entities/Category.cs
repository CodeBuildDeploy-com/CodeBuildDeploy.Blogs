namespace CodeBuildDeploy.Blogs.DA.Entities
{
    public class Category
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; } = null!;

        public virtual string Description { get; set; } = null!;

        public virtual IList<Post> Posts { get; set; } = new List<Post>();
    }
}
