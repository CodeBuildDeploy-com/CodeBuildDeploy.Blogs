namespace CodeBuildDeploy.Blogs.DA.Entities
{
    public static class Categories
    {
        public static IEnumerable<Category> GetAll()
        {
            return
            [
                new() { Id = new Guid("d4d99022-04a5-43ed-982e-b4741adc6478"), Name = "General", Description = "General info topics" },
                new() { Id = new Guid("09a8afe4-d726-43f6-9878-41ca1a4d5b39"), Name = "Software Delivery", Description = "Blogs on topics like Continuous Delivery, DevOps Cultures, Automation, Continuous Improvement, Software Engineering Practices and all things Software Delivery" },
                new() { Id = new Guid("fc3cb34b-53c9-4342-a139-9ecf6b134008"), Name = "Workstation Setup", Description = "Blogs on setting up my workstation" }
            ];
        }
    }
}
