using System.ComponentModel.DataAnnotations.Schema;

namespace CodeBuildDeploy.DataAccess
{
    public class PostTag
    {
        [Column("Post_Id")]
        public virtual int PostId { get; set; }
        public virtual Post Post { get; set; }

        [Column("Tag_Id")]
        public virtual int TagId { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
