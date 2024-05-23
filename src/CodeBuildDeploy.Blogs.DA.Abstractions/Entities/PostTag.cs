namespace CodeBuildDeploy.Blogs.DA.Entities
{
    public class PostTag
    {
        public virtual int PostId { get; set; }
        public virtual Post Post { get; set; } = null!;

        public virtual int TagId { get; set; }
        public virtual Tag Tag { get; set; } = null!;
    }
}
