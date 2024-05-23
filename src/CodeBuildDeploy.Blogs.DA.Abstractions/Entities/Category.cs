using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeBuildDeploy.Blogs.DA.Entities
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }

        [StringLength(50)]
        public virtual string Name { get; set; } = null!;

        [StringLength(50)]
        public virtual string Description { get; set; } = null!;

        public virtual IList<Post> Posts { get; set; } = new List<Post>();
    }
}
