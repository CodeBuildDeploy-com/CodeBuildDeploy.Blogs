namespace CodeBuildDeploy.Blogs.DA.Entities
{
    public static class PostTags
    {
        public static IEnumerable<PostTag> GetDefault()
        {
            return
            [
                new() { PostId = new Guid("0b7fe257-0429-4da1-94a2-89dbaa0aa583"), TagId = new Guid("2a0b3209-f46c-45fe-b7d6-8824a09f9504") },
                new() { PostId = new Guid("0b7fe257-0429-4da1-94a2-89dbaa0aa583"), TagId = new Guid("45485ccf-cc1c-40c2-ac9b-c74a17cc2711") },
                new() { PostId = new Guid("0b7fe257-0429-4da1-94a2-89dbaa0aa583"), TagId = new Guid("73dd1c87-742e-4154-b88d-7c2077b90151") },
                new() { PostId = new Guid("0b7fe257-0429-4da1-94a2-89dbaa0aa583"), TagId = new Guid("03bbd02b-0b2c-4eff-9874-8561b8bbcafa") },
                new() { PostId = new Guid("ca8d885a-3a24-4c5b-bb33-61a7956b8996"), TagId = new Guid("2a0b3209-f46c-45fe-b7d6-8824a09f9504") },
                new() { PostId = new Guid("ca8d885a-3a24-4c5b-bb33-61a7956b8996"), TagId = new Guid("45485ccf-cc1c-40c2-ac9b-c74a17cc2711") },
                new() { PostId = new Guid("d1ef2a8d-07bd-49cf-a785-a727567e9fc9"), TagId = new Guid("2a0b3209-f46c-45fe-b7d6-8824a09f9504") },
                new() { PostId = new Guid("d1ef2a8d-07bd-49cf-a785-a727567e9fc9"), TagId = new Guid("45485ccf-cc1c-40c2-ac9b-c74a17cc2711") },
                new() { PostId = new Guid("d1ef2a8d-07bd-49cf-a785-a727567e9fc9"), TagId = new Guid("73dd1c87-742e-4154-b88d-7c2077b90151") },
                new() { PostId = new Guid("d1ef2a8d-07bd-49cf-a785-a727567e9fc9"), TagId = new Guid("03bbd02b-0b2c-4eff-9874-8561b8bbcafa") },
                new() { PostId = new Guid("d1ef2a8d-07bd-49cf-a785-a727567e9fc9"), TagId = new Guid("79adf12b-1c17-42c9-9d44-5cce1b9f3c82") },
                new() { PostId = new Guid("3e54714a-521d-484c-871c-a85ab52642ea"), TagId = new Guid("6961e675-7008-46a5-a75d-1c473ada45ea") },
                new() { PostId = new Guid("c5fecdc6-549a-41ce-ad63-fc8db2ab4e01"), TagId = new Guid("2a0b3209-f46c-45fe-b7d6-8824a09f9504") },
            ];
        }
    }
}
