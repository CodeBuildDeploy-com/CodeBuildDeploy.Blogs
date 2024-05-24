namespace CodeBuildDeploy.Blogs.DA.Entities
{
    public abstract class EntityBase
    {
        public EntityBase()
        {
            if (Id == Guid.Empty)
            {
                Id = Guid.NewGuid();
            }
        }

        public virtual Guid Id { get; set; }
    }
}
