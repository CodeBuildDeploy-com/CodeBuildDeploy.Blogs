namespace CodeBuildDeploy.Blogs.DA.Entities
{
    public class Post
    {
        public virtual int Id { get; set; }

        public virtual string UrlSlug { get; set; } = null!;

        public virtual string Title { get; set; } = null!;

        public virtual string ShortDescription { get; set; } = null!;

        public virtual string Description { get; set; } = null!;

        public virtual string Content { get; set; } = null!;

        public virtual bool Published { get; set; }

        public virtual DateTime PostedOn { get; set; }

        public virtual DateTime? Modified { get; set; }

        public virtual int CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;

        public virtual IList<PostTag> PostTags { get; set; } = new List<PostTag>();
    }
}
