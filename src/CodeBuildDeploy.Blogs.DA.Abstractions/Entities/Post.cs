namespace CodeBuildDeploy.Blogs.DA.Entities
{
    public class Post : EntityBase
    {
        public string UrlSlug { get; set; } = null!;

        public string Title { get; set; } = null!;

        public string ShortDescription { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Content { get; set; } = null!;

        public bool Published { get; set; }

        public DateTime PostedOn { get; set; }

        public DateTime? Modified { get; set; }

        public string Author { get; set; } = null!;

        public Guid CategoryId { get; set; }

        public Category Category { get; set; } = null!;

        public IList<PostTag> PostTags { get; set; } = new List<PostTag>();
    }
}
