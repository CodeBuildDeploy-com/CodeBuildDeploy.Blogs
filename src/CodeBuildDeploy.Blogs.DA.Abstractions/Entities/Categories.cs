namespace CodeBuildDeploy.Blogs.DA.Entities
{
    public static class Categories
    {
        public static readonly Guid SoftwareDeliveryId = new ("09a8afe4-d726-43f6-9878-41ca1a4d5b39");
        public static readonly Guid HomeLabSetupId = new("42eac5c9-5d16-49d4-869d-bf050cdaa0e0");
        public static readonly Guid WorkstationSetupId = new ("fc3cb34b-53c9-4342-a139-9ecf6b134008");

        public static IEnumerable<Category> GetAll()
        {
            return
            [
                new() { Id = SoftwareDeliveryId, Name = "Software Delivery", Description = "Articles talking about how we like to deliver software here at CodeBuildDeploy, using the CodeBuildDeploy software as an example / POC delivery project. Includes key areas and concepts such as Continuous Delivery, DevOps Cultures, Automation, Continuous Improvement, Software Engineering Practices and all things Software Delivery." },
                new() { Id = HomeLabSetupId, Name = "HomeLab Setup", Description = "How I run the network, Proxmox cluster, and Azure infrastructure behind the HomeLab and CodeBuildDeploy." },
                new() { Id = WorkstationSetupId, Name = "Workstation Setup", Description = "An engineers workstation setup is an imperative part of their capability to deliver software effectively, comfortably and productively. This section details the setups of the CodeBuildDeploy family. It includes articles on how to setup tools that we find useful." }
            ];
        }
    }
}
