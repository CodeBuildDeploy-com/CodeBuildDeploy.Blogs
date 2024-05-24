namespace CodeBuildDeploy.Blogs.DA.Entities
{
    public class Tag : EntityBase
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public IList<PostTag> PostTags { get; set; } = new List<PostTag>();
    }
}
