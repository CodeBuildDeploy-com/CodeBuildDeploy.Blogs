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
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
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
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
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
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Published = table.Column<bool>(type: "bit", nullable: false),
                    PostedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    { new Guid("09a8afe4-d726-43f6-9878-41ca1a4d5b39"), "Blogs on topics like Continuous Delivery, DevOps Cultures, Automation, Continuous Improvement, Software Engineering Practices and all things Software Delivery", "Software Delivery" },
                    { new Guid("d4d99022-04a5-43ed-982e-b4741adc6478"), "General info topics", "General" },
                    { new Guid("fc3cb34b-53c9-4342-a139-9ecf6b134008"), "Blogs on setting up my workstation", "Workstation Setup" }
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
                    { new Guid("45485ccf-cc1c-40c2-ac9b-c74a17cc2711"), "Windows Operating System", "Windows" },
                    { new Guid("6961e675-7008-46a5-a75d-1c473ada45ea"), "Git Source Control", "Git" },
                    { new Guid("73dd1c87-742e-4154-b88d-7c2077b90151"), "Unix based Operating System", "UNIX" },
                    { new Guid("79adf12b-1c17-42c9-9d44-5cce1b9f3c82"), "Ansible Automation", "Ansible" },
                    { new Guid("f4547542-2b7f-4f9e-8a30-01850657a6b2"), "Azure Cloud", "Azure" },
                    { new Guid("f5bc44bf-f42e-447d-8bed-ee6aa59061e3"), "Python scripting language", "Python" },
                    { new Guid("f7e79415-98c9-46ab-a51e-7afd7fbd9c8a"), "Microsoft ASP.NET", "ASP.NET" }
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
