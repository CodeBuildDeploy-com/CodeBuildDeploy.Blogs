namespace CodeBuildDeploy.Blogs.Contract.Dto
{
    public class Tag
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; } = null!;

        public virtual string Description { get; set; } = null!;
    }
}
