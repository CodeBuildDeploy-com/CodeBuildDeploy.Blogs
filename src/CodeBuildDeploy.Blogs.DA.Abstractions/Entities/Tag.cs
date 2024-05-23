namespace CodeBuildDeploy.Blogs.DA.Entities
{
    public class Tag
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; } = null!;

        public virtual string Description { get; set; } = null!;

        public virtual IList<PostTag> PostTags { get; set; } = new List<PostTag>();
    }
}
