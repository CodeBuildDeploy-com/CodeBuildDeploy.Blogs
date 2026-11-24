using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeBuildDeploy.Blogs.DA.EF.Deploy.Migrations
{
    /// <inheritdoc />
    public partial class AddBlogAuthors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Author_Id",
                schema: "blg",
                table: "Post",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Author",
                schema: "blg",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    AvatarPath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LinkedInUrl = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    TwitterUrl = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    FacebookUrl = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "blg",
                table: "Author",
                columns: new[] { "Id", "AvatarPath", "Biography", "FacebookUrl", "LinkedInUrl", "Name", "TwitterUrl" },
                values: new object[,]
                {
                    { new Guid("1e7c80bb-eaaa-4d36-9e28-573bf9c0e3d4"), "/img/about/andrew.white.png", "A highly motivated Senior Software Engineer, Andrew has a wide range of commercial experience in designing, developing, deploying, maintaining, and supporting a variety of systems. He is focused on quality of delivery, continually looking for opportunities to improve across the full software delivery lifecycle.\n\nAndrew has extensive knowledge of the Microsoft development ecosystem having worked with all versions of the .NET platform to develop enterprise applications.", null, null, "Andy White", null },
                    { new Guid("50f29cf4-ab70-4e9f-b225-4fc31ce5b4f6"), "/img/about/me-profile-sm.jpg", "I am a senior software engineering and technical leader / Microsoft technologies technical architect, with a strong passion for continuous delivery. I am a firm believer in empowered teams with true DevOps cultures. I encourage responsibility over role, high quality and full stack engineers, showing ownership of the software and its behaviour, end to end, from requirements maturing all the way through to its continual and successful running in Production.", "https://www.facebook.com/m4rkpollard", "https://www.linkedin.com/in/mark-pollard-351aa163", "Mark Pollard", "https://twitter.com/m4rk5" }
                });

            // Backfill every post before removing the old byline column.
            migrationBuilder.Sql("""
                INSERT INTO [blg].[Author] ([Id], [Name])
                SELECT NEWID(), [LegacyName]
                FROM (
                    SELECT DISTINCT [Author] AS [LegacyName]
                    FROM [blg].[Post]
                    WHERE [UrlSlug] <> N'ZeroBugs'
                        AND [Author] NOT IN (N'Mark Pollard', N'Andrew White', N'Andy White')
                ) AS [ExistingAuthors];

                UPDATE [Post]
                SET [Author_Id] = [Author].[Id]
                FROM [blg].[Post] AS [Post]
                JOIN [blg].[Author] AS [Author] ON [Author].[Name] =
                    CASE
                        WHEN [Post].[UrlSlug] = N'ZeroBugs' OR [Post].[Author] = N'Andrew White' THEN N'Andy White'
                        ELSE [Post].[Author]
                    END;
                """);

            migrationBuilder.AlterColumn<Guid>(
                name: "Author_Id",
                schema: "blg",
                table: "Post",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Post_Author_Id",
                schema: "blg",
                table: "Post",
                column: "Author_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Author_Author_Id",
                schema: "blg",
                table: "Post",
                column: "Author_Id",
                principalSchema: "blg",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.DropColumn(
                name: "Author",
                schema: "blg",
                table: "Post");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                schema: "blg",
                table: "Post",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.Sql("""
                UPDATE [Post]
                SET [Author] = CASE
                    WHEN [Author].[Id] = '1e7c80bb-eaaa-4d36-9e28-573bf9c0e3d4'
                        AND [Author].[Name] = N'Andy White' THEN N'Andrew White'
                    ELSE [Author].[Name]
                END
                FROM [blg].[Post] AS [Post]
                JOIN [blg].[Author] AS [Author] ON [Author].[Id] = [Post].[Author_Id];
                """);

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Author_Author_Id",
                schema: "blg",
                table: "Post");

            migrationBuilder.DropTable(
                name: "Author",
                schema: "blg");

            migrationBuilder.DropIndex(
                name: "IX_Post_Author_Id",
                schema: "blg",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "Author_Id",
                schema: "blg",
                table: "Post");

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                schema: "blg",
                table: "Post",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true);
        }
    }
}
