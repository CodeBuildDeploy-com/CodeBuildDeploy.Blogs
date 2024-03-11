using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeBuildDeploy.DataAccess
{
    public class Post
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }

        [StringLength(50)]
        public virtual string UrlSlug { get; set; }

        [StringLength(50)]
        public virtual string Title { get; set; }

        [StringLength(50)]
        public virtual string ShortDescription { get; set; }

        [StringLength(150)]
        public virtual string Description { get; set; }

        public virtual string Content { get; set; }

        public virtual bool Published { get; set; }

        public virtual DateTime PostedOn { get; set; }

        public virtual DateTime? Modified { get; set; }

        [Column("Category_Id")]
        public virtual int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public virtual IList<PostTag> PostTags { get; set; }
    }
}
