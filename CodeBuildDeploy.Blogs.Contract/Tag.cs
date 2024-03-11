using System.Collections.Generic;

namespace CodeBuildDeploy.Blogs.Contract
{
    public class Tag
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Description { get; set; }
    }
}
