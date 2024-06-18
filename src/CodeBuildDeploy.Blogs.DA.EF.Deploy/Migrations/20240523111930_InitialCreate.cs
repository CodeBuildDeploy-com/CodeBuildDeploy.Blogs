using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeBuildDeploy.Blogs.DA.EF.Deploy.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "blg");

            migrationBuilder.CreateTable(
                name: "Category",
                schema: "blg",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                schema: "blg",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                schema: "blg",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UrlSlug = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Published = table.Column<bool>(type: "bit", nullable: false),
                    PostedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Category_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Post_Category_Category_Id",
                        column: x => x.Category_Id,
                        principalSchema: "blg",
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostTag",
                schema: "blg",
                columns: table => new
                {
                    Post_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tag_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTag", x => new { x.Post_Id, x.Tag_Id });
                    table.ForeignKey(
                        name: "FK_PostTag_Post_Post_Id",
                        column: x => x.Post_Id,
                        principalSchema: "blg",
                        principalTable: "Post",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTag_Tag_Tag_Id",
                        column: x => x.Tag_Id,
                        principalSchema: "blg",
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "blg",
                table: "Category",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("09a8afe4-d726-43f6-9878-41ca1a4d5b39"), "Articles talking about how we like to deliver software here at CodeBuildDeploy, using the CodeBuildDeploy software as an example / POC delivery project. Includes key areas and concepts such as Continuous Delivery, DevOps Cultures, Automation, Continuous Improvement, Software Engineering Practices and all things Software Delivery.", "Software Delivery" },
                    { new Guid("fc3cb34b-53c9-4342-a139-9ecf6b134008"), "An engineers workstation setup is an imperative part of their capability to deliver software effectively, comfortably and productively. This section details the setups of the CodeBuildDeploy family. It includes articles on how to setup tools that we find useful.", "Workstation Setup" }
                });

            migrationBuilder.InsertData(
                schema: "blg",
                table: "Tag",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("03bbd02b-0b2c-4eff-9874-8561b8bbcafa"), "Linux Operating System'", "Linux" },
                    { new Guid("2a0b3209-f46c-45fe-b7d6-8824a09f9504"), "PowerShell Core and Windows PowerShell", "PowerShell" },
                    { new Guid("313135f2-aa40-481b-9646-0e30052b5462"), "Microsoft .Net Framework", ".NET" },
                    { new Guid("37519618-949c-48dd-a099-9f991b950ada"), "Kubernetes / K8s, used for automating deployment, scaling, and management of containers", "Kubernetes" },
                    { new Guid("45485ccf-cc1c-40c2-ac9b-c74a17cc2711"), "Windows Operating System", "Windows" },
                    { new Guid("48306da3-dab0-4b0e-b063-0acbaf126891"), "Tracking and planning of project issues", "Issue Management" },
                    { new Guid("6961e675-7008-46a5-a75d-1c473ada45ea"), "Git Source Control", "Git" },
                    { new Guid("73dd1c87-742e-4154-b88d-7c2077b90151"), "Unix based Operating System", "UNIX" },
                    { new Guid("79adf12b-1c17-42c9-9d44-5cce1b9f3c82"), "Ansible Automation", "Ansible" },
                    { new Guid("8df60d46-9a9d-46e1-b90d-d9bac8110ef7"), "Docker Containers", "Containers" },
                    { new Guid("f4547542-2b7f-4f9e-8a30-01850657a6b2"), "Azure Cloud", "Azure" },
                    { new Guid("f5bc44bf-f42e-447d-8bed-ee6aa59061e3"), "Python scripting language", "Python" },
                    { new Guid("f7e79415-98c9-46ab-a51e-7afd7fbd9c8a"), "Microsoft ASP.NET", "ASP.NET" }
                });

            migrationBuilder.InsertData(
                schema: "blg",
                table: "Post",
                columns: new[] { "Id", "Author", "Category_Id", "Content", "Description", "Modified", "PostedOn", "Published", "ShortDescription", "Title", "UrlSlug" },
                values: new object[,]
                {
                    { new Guid("0b7fe257-0429-4da1-94a2-89dbaa0aa583"), "Mark Pollard", new Guid("fc3cb34b-53c9-4342-a139-9ecf6b134008"), "WSLInterop", "Read how to seamlessly call Linux commands, such as grep, directly from Powershell on you Windows machine.", new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Linux commands on Windows", "WSL Interop", "WSLInterop" },
                    { new Guid("26d005b9-5505-4646-9194-cd8358817ac8"), "Mark Pollard", new Guid("fc3cb34b-53c9-4342-a139-9ecf6b134008"), "Tools", "This section lists the tools I frequently use. Some are development tools others utility tools making general day to day working easier.", new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "My favourite software tools", "Tools", "Tools" },
                    { new Guid("30c34d37-a663-4879-a294-e1b78431d611"), "Mark Pollard", new Guid("fc3cb34b-53c9-4342-a139-9ecf6b134008"), "Libraries", "This section lists libraries I often use. These range from logging frameworks to testing tools used for testing / mocking etc.", new DateTime(2015, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Libraries you may like", "Libraries", "Libraries" },
                    { new Guid("3e54714a-521d-484c-871c-a85ab52642ea"), "Mark Pollard", new Guid("09a8afe4-d726-43f6-9878-41ca1a4d5b39"), "TrunkBasedDev", "Trunk Based Development is a branching strategy that operates with no long-running branches. Commits are made directly on main and releases come from builds of main.", new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Trunk Based Development", "Trunk Based Development", "TrunkBasedDev" },
                    { new Guid("6181d9cc-ef13-42b3-aa66-ef2dc5b54fae"), null, new Guid("09a8afe4-d726-43f6-9878-41ca1a4d5b39"), "ZeroBugs", "It is impossible for software engineers to continuously produce bug-free, production ready code. Bugs will always exist. This article is about how we effectively handle such issues, acheiving a state of zero bugs backlog.", new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Delete all the bugs from your backlog, now!", "Zero Bugs", "ZeroBugs" },
                    { new Guid("c5fecdc6-549a-41ce-ad63-fc8db2ab4e01"), "Mark Pollard", new Guid("fc3cb34b-53c9-4342-a139-9ecf6b134008"), "MyShell", "Having fun customizing my terminal and making my prompt look awesome, with Oh my Posh 3 and Nerd fonts.", new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Having fun customizing my PowerShell terminal", "Oh MY Shell", "MyShell" },
                    { new Guid("ca8d885a-3a24-4c5b-bb33-61a7956b8996"), "Mark Pollard", new Guid("fc3cb34b-53c9-4342-a139-9ecf6b134008"), "PowerShellRemoting", "This section talks about how to enable and work with powershell remoting.", new DateTime(2015, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Enable and work with powershell remoting", "PowerShell Remoting", "PowerShellRemoting" },
                    { new Guid("d1ef2a8d-07bd-49cf-a785-a727567e9fc9"), "Mark Pollard", new Guid("fc3cb34b-53c9-4342-a139-9ecf6b134008"), "WslAnsible", "Read how to setup Ansible on Windows Subsystem for Linux, including setting up for seamlessly calling from windows powershell.", new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Setting up Ansible on WSL", "Ansible on WSL", "WslAnsible" },
                    { new Guid("d8632d22-eb92-41a6-b3c4-dc1235846084"), "Mark Pollard", new Guid("09a8afe4-d726-43f6-9878-41ca1a4d5b39"), "DevOpsCLI", "A container configured with all the CLI tools, scripts and extensions, a full stack DevOps cultured engineer needs for managing the AKS cluster instance.", new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "AKS CLI container for DevOps teams", "AKS CLI container", "devops-cli-aks" }
                });

            migrationBuilder.InsertData(
                schema: "blg",
                table: "PostTag",
                columns: new[] { "Post_Id", "Tag_Id" },
                values: new object[,]
                {
                    { new Guid("0b7fe257-0429-4da1-94a2-89dbaa0aa583"), new Guid("03bbd02b-0b2c-4eff-9874-8561b8bbcafa") },
                    { new Guid("0b7fe257-0429-4da1-94a2-89dbaa0aa583"), new Guid("2a0b3209-f46c-45fe-b7d6-8824a09f9504") },
                    { new Guid("0b7fe257-0429-4da1-94a2-89dbaa0aa583"), new Guid("45485ccf-cc1c-40c2-ac9b-c74a17cc2711") },
                    { new Guid("0b7fe257-0429-4da1-94a2-89dbaa0aa583"), new Guid("73dd1c87-742e-4154-b88d-7c2077b90151") },
                    { new Guid("3e54714a-521d-484c-871c-a85ab52642ea"), new Guid("6961e675-7008-46a5-a75d-1c473ada45ea") },
                    { new Guid("6181d9cc-ef13-42b3-aa66-ef2dc5b54fae"), new Guid("48306da3-dab0-4b0e-b063-0acbaf126891") },
                    { new Guid("c5fecdc6-549a-41ce-ad63-fc8db2ab4e01"), new Guid("2a0b3209-f46c-45fe-b7d6-8824a09f9504") },
                    { new Guid("ca8d885a-3a24-4c5b-bb33-61a7956b8996"), new Guid("2a0b3209-f46c-45fe-b7d6-8824a09f9504") },
                    { new Guid("ca8d885a-3a24-4c5b-bb33-61a7956b8996"), new Guid("45485ccf-cc1c-40c2-ac9b-c74a17cc2711") },
                    { new Guid("d1ef2a8d-07bd-49cf-a785-a727567e9fc9"), new Guid("03bbd02b-0b2c-4eff-9874-8561b8bbcafa") },
                    { new Guid("d1ef2a8d-07bd-49cf-a785-a727567e9fc9"), new Guid("2a0b3209-f46c-45fe-b7d6-8824a09f9504") },
                    { new Guid("d1ef2a8d-07bd-49cf-a785-a727567e9fc9"), new Guid("45485ccf-cc1c-40c2-ac9b-c74a17cc2711") },
                    { new Guid("d1ef2a8d-07bd-49cf-a785-a727567e9fc9"), new Guid("73dd1c87-742e-4154-b88d-7c2077b90151") },
                    { new Guid("d1ef2a8d-07bd-49cf-a785-a727567e9fc9"), new Guid("79adf12b-1c17-42c9-9d44-5cce1b9f3c82") },
                    { new Guid("d8632d22-eb92-41a6-b3c4-dc1235846084"), new Guid("03bbd02b-0b2c-4eff-9874-8561b8bbcafa") },
                    { new Guid("d8632d22-eb92-41a6-b3c4-dc1235846084"), new Guid("37519618-949c-48dd-a099-9f991b950ada") },
                    { new Guid("d8632d22-eb92-41a6-b3c4-dc1235846084"), new Guid("45485ccf-cc1c-40c2-ac9b-c74a17cc2711") },
                    { new Guid("d8632d22-eb92-41a6-b3c4-dc1235846084"), new Guid("73dd1c87-742e-4154-b88d-7c2077b90151") },
                    { new Guid("d8632d22-eb92-41a6-b3c4-dc1235846084"), new Guid("8df60d46-9a9d-46e1-b90d-d9bac8110ef7") },
                    { new Guid("d8632d22-eb92-41a6-b3c4-dc1235846084"), new Guid("f4547542-2b7f-4f9e-8a30-01850657a6b2") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Post_Category_Id",
                schema: "blg",
                table: "Post",
                column: "Category_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_Tag_Id",
                schema: "blg",
                table: "PostTag",
                column: "Tag_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostTag",
                schema: "blg");

            migrationBuilder.DropTable(
                name: "Post",
                schema: "blg");

            migrationBuilder.DropTable(
                name: "Tag",
                schema: "blg");

            migrationBuilder.DropTable(
                name: "Category",
                schema: "blg");
        }
    }
}
