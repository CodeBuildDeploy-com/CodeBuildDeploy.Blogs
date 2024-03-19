using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeBuildDeploy.Blogs.Data.Entities
{
    public class Tag
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }

        [StringLength(50)]
        public virtual string Name { get; set; } = null!;

        public virtual string Description { get; set; } = null!;

        public virtual IList<PostTag> PostTags { get; set; } = new List<PostTag>();
    }
}
