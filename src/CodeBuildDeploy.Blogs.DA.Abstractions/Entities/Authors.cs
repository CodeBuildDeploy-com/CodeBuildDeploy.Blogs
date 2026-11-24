namespace CodeBuildDeploy.Blogs.DA.Entities
{
    public static class Authors
    {
        public static readonly Guid MarkPollardId = new("50f29cf4-ab70-4e9f-b225-4fc31ce5b4f6");
        public static readonly Guid AndyWhiteId = new("1e7c80bb-eaaa-4d36-9e28-573bf9c0e3d4");

        public static IEnumerable<Author> GetDefault()
        {
            return
            [
                new()
                {
                    Id = MarkPollardId,
                    Name = "Mark Pollard",
                    Biography = "I am a senior software engineering and technical leader / Microsoft technologies technical architect, with a strong passion for continuous delivery. I am a firm believer in empowered teams with true DevOps cultures. I encourage responsibility over role, high quality and full stack engineers, showing ownership of the software and its behaviour, end to end, from requirements maturing all the way through to its continual and successful running in Production.",
                    AvatarPath = "/img/about/me-profile-sm.jpg",
                    LinkedInUrl = "https://www.linkedin.com/in/mark-pollard-351aa163",
                    TwitterUrl = "https://twitter.com/m4rk5",
                    FacebookUrl = "https://www.facebook.com/m4rkpollard"
                },
                new()
                {
                    Id = AndyWhiteId,
                    Name = "Andy White",
                    Biography = "A highly motivated Senior Software Engineer, Andrew has a wide range of commercial experience in designing, developing, deploying, maintaining, and supporting a variety of systems. He is focused on quality of delivery, continually looking for opportunities to improve across the full software delivery lifecycle.\n\nAndrew has extensive knowledge of the Microsoft development ecosystem having worked with all versions of the .NET platform to develop enterprise applications.",
                    AvatarPath = "/img/about/andrew.white.png"
                }
            ];
        }
    }
}
