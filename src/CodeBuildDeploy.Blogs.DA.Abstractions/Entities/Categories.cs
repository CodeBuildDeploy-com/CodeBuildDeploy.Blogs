namespace CodeBuildDeploy.Blogs.DA.Entities
{
    public static class Categories
    {
        public static IEnumerable<Category> GetAll()
        {
            return
            [
                new() { Id = new Guid("09a8afe4-d726-43f6-9878-41ca1a4d5b39"), Name = "Software Delivery", Description = "Articles talking about how we like to deliver software here at CodeBuildDeploy, using the CodeBuildDeploy software as an example / POC delivery project. Includes key areas and concepts such as Continuous Delivery, DevOps Cultures, Automation, Continuous Improvement, Software Engineering Practices and all things Software Delivery." },
                new() { Id = new Guid("fc3cb34b-53c9-4342-a139-9ecf6b134008"), Name = "Workstation Setup", Description = "An engineers workstation setup is an imperative part of their capability to deliver software effectively, comfortably and productively. This section details the setups of the CodeBuildDeploy family. It includes articles on how to setup tools that we find useful." }
            ];
        }
    }
}
