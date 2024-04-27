using System.ComponentModel.DataAnnotations.Schema;

namespace CodeBuildDeploy.Blogs.Data.Entities
{
    public class PostTag
    {
        [Column("Post_Id")]
        public virtual int PostId { get; set; }
        public virtual Post Post { get; set; } = null!;

        [Column("Tag_Id")]
        public virtual int TagId { get; set; }
        public virtual Tag Tag { get; set; } = null!;
    }
}
