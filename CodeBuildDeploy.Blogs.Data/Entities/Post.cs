using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeBuildDeploy.Blogs.Data.Entities
{
    public class Post
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }

        [StringLength(50)]
        public virtual string UrlSlug { get; set; } = null!;

        [StringLength(50)]
        public virtual string Title { get; set; } = null!;

        [StringLength(50)]
        public virtual string ShortDescription { get; set; } = null!;

        [StringLength(150)]
        public virtual string Description { get; set; } = null!;

        public virtual string Content { get; set; } = null!;

        public virtual bool Published { get; set; }

        public virtual DateTime PostedOn { get; set; }

        public virtual DateTime? Modified { get; set; }

        [Column("Category_Id")]
        public virtual int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; } = null!;

        public virtual IList<PostTag> PostTags { get; set; } = new List<PostTag>();
    }
}
