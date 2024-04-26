namespace CodeBuildDeploy.Blogs.Contract.Dto
{
    public class Post
    {
        public int Id { get; set; }

        public string UrlSlug { get; set; } = null!;

        public string Title { get; set; } = null!;

        public string ShortDescription { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Content { get; set; } = null!;

        public bool Published { get; set; }

        public DateTime PostedOn { get; set; }

        public DateTime? Modified { get; set; }

        public Category Category { get; set; } = null!;

        public IList<Tag> Tags { get; set; } = new List<Tag>();
    }
}
