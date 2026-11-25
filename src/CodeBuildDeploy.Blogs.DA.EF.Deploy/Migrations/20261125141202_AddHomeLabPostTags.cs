using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeBuildDeploy.Blogs.DA.EF.Deploy.Migrations
{
    /// <inheritdoc />
    public partial class AddHomeLabPostTags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "blg",
                table: "PostTag",
                columns: new[] { "Post_Id", "Tag_Id" },
                values: new object[,]
                {
                    { new Guid("5229849a-3b83-4b6e-b75d-f0a2153e2a08"), new Guid("03bbd02b-0b2c-4eff-9874-8561b8bbcafa") },
                    { new Guid("5229849a-3b83-4b6e-b75d-f0a2153e2a08"), new Guid("8df60d46-9a9d-46e1-b90d-d9bac8110ef7") },
                    { new Guid("79a91732-fb8b-4e43-aded-1112b6ed61a9"), new Guid("37519618-949c-48dd-a099-9f991b950ada") },
                    { new Guid("79a91732-fb8b-4e43-aded-1112b6ed61a9"), new Guid("8df60d46-9a9d-46e1-b90d-d9bac8110ef7") },
                    { new Guid("79a91732-fb8b-4e43-aded-1112b6ed61a9"), new Guid("f4547542-2b7f-4f9e-8a30-01850657a6b2") },
                    { new Guid("cd018418-5306-418e-9469-d137d38f3395"), new Guid("03bbd02b-0b2c-4eff-9874-8561b8bbcafa") },
                    { new Guid("cd018418-5306-418e-9469-d137d38f3395"), new Guid("8df60d46-9a9d-46e1-b90d-d9bac8110ef7") }
                });

            migrationBuilder.InsertData(
                schema: "blg",
                table: "Tag",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("04e9a93b-dd12-4217-99cb-ece19c0b567f"), "Proxmox Virtual Environment", "Proxmox" },
                    { new Guid("1e82ea7d-e3a9-4911-b8c0-2a632bbba34a"), "Linux Containers", "LXC" },
                    { new Guid("41f7feda-af81-4e8c-85bf-0c33188bfeb3"), "Packaging and deploying Kubernetes applications", "Helm" },
                    { new Guid("451c526e-fa0e-42ca-a347-912131719bd5"), "NGINX and Nginx Proxy Manager", "NGINX" },
                    { new Guid("5feaaaff-76c9-4376-8ba7-af5314f4721d"), "Infrastructure as code with Terraform", "Terraform" },
                    { new Guid("716cfff3-594a-4074-875b-d5b958807910"), "WireGuard VPN tunnels", "WireGuard" },
                    { new Guid("79215531-adc8-4635-8777-b1a859eee870"), "Routing, switching and network infrastructure", "Network" },
                    { new Guid("9dd59d5f-d44e-4cc1-b16b-ef4ed12688e6"), "FriendlyElec firmware based on OpenWrt", "FriendlyWrt" },
                    { new Guid("a5b98f7f-be9e-4bf7-9645-db7c5a1aa1f2"), "Network-wide DNS filtering", "Pi-hole" },
                    { new Guid("becbd21d-f175-48fa-a0b1-473920a72709"), "Domain Name System and recursive resolvers", "DNS" },
                    { new Guid("f02e7311-6c1c-497b-a9f9-7a55132c517b"), "Azure DevOps pipelines and deployments", "Azure DevOps" }
                });

            migrationBuilder.InsertData(
                schema: "blg",
                table: "PostTag",
                columns: new[] { "Post_Id", "Tag_Id" },
                values: new object[,]
                {
                    { new Guid("5229849a-3b83-4b6e-b75d-f0a2153e2a08"), new Guid("04e9a93b-dd12-4217-99cb-ece19c0b567f") },
                    { new Guid("5229849a-3b83-4b6e-b75d-f0a2153e2a08"), new Guid("1e82ea7d-e3a9-4911-b8c0-2a632bbba34a") },
                    { new Guid("79a91732-fb8b-4e43-aded-1112b6ed61a9"), new Guid("41f7feda-af81-4e8c-85bf-0c33188bfeb3") },
                    { new Guid("79a91732-fb8b-4e43-aded-1112b6ed61a9"), new Guid("5feaaaff-76c9-4376-8ba7-af5314f4721d") },
                    { new Guid("79a91732-fb8b-4e43-aded-1112b6ed61a9"), new Guid("f02e7311-6c1c-497b-a9f9-7a55132c517b") },
                    { new Guid("cd018418-5306-418e-9469-d137d38f3395"), new Guid("451c526e-fa0e-42ca-a347-912131719bd5") },
                    { new Guid("cd018418-5306-418e-9469-d137d38f3395"), new Guid("716cfff3-594a-4074-875b-d5b958807910") },
                    { new Guid("cd018418-5306-418e-9469-d137d38f3395"), new Guid("79215531-adc8-4635-8777-b1a859eee870") },
                    { new Guid("cd018418-5306-418e-9469-d137d38f3395"), new Guid("9dd59d5f-d44e-4cc1-b16b-ef4ed12688e6") },
                    { new Guid("cd018418-5306-418e-9469-d137d38f3395"), new Guid("a5b98f7f-be9e-4bf7-9645-db7c5a1aa1f2") },
                    { new Guid("cd018418-5306-418e-9469-d137d38f3395"), new Guid("becbd21d-f175-48fa-a0b1-473920a72709") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "blg",
                table: "PostTag",
                keyColumns: new[] { "Post_Id", "Tag_Id" },
                keyValues: new object[] { new Guid("5229849a-3b83-4b6e-b75d-f0a2153e2a08"), new Guid("03bbd02b-0b2c-4eff-9874-8561b8bbcafa") });

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "PostTag",
                keyColumns: new[] { "Post_Id", "Tag_Id" },
                keyValues: new object[] { new Guid("5229849a-3b83-4b6e-b75d-f0a2153e2a08"), new Guid("04e9a93b-dd12-4217-99cb-ece19c0b567f") });

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "PostTag",
                keyColumns: new[] { "Post_Id", "Tag_Id" },
                keyValues: new object[] { new Guid("5229849a-3b83-4b6e-b75d-f0a2153e2a08"), new Guid("1e82ea7d-e3a9-4911-b8c0-2a632bbba34a") });

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "PostTag",
                keyColumns: new[] { "Post_Id", "Tag_Id" },
                keyValues: new object[] { new Guid("5229849a-3b83-4b6e-b75d-f0a2153e2a08"), new Guid("8df60d46-9a9d-46e1-b90d-d9bac8110ef7") });

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "PostTag",
                keyColumns: new[] { "Post_Id", "Tag_Id" },
                keyValues: new object[] { new Guid("79a91732-fb8b-4e43-aded-1112b6ed61a9"), new Guid("37519618-949c-48dd-a099-9f991b950ada") });

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "PostTag",
                keyColumns: new[] { "Post_Id", "Tag_Id" },
                keyValues: new object[] { new Guid("79a91732-fb8b-4e43-aded-1112b6ed61a9"), new Guid("41f7feda-af81-4e8c-85bf-0c33188bfeb3") });

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "PostTag",
                keyColumns: new[] { "Post_Id", "Tag_Id" },
                keyValues: new object[] { new Guid("79a91732-fb8b-4e43-aded-1112b6ed61a9"), new Guid("5feaaaff-76c9-4376-8ba7-af5314f4721d") });

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "PostTag",
                keyColumns: new[] { "Post_Id", "Tag_Id" },
                keyValues: new object[] { new Guid("79a91732-fb8b-4e43-aded-1112b6ed61a9"), new Guid("8df60d46-9a9d-46e1-b90d-d9bac8110ef7") });

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "PostTag",
                keyColumns: new[] { "Post_Id", "Tag_Id" },
                keyValues: new object[] { new Guid("79a91732-fb8b-4e43-aded-1112b6ed61a9"), new Guid("f02e7311-6c1c-497b-a9f9-7a55132c517b") });

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "PostTag",
                keyColumns: new[] { "Post_Id", "Tag_Id" },
                keyValues: new object[] { new Guid("79a91732-fb8b-4e43-aded-1112b6ed61a9"), new Guid("f4547542-2b7f-4f9e-8a30-01850657a6b2") });

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "PostTag",
                keyColumns: new[] { "Post_Id", "Tag_Id" },
                keyValues: new object[] { new Guid("cd018418-5306-418e-9469-d137d38f3395"), new Guid("03bbd02b-0b2c-4eff-9874-8561b8bbcafa") });

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "PostTag",
                keyColumns: new[] { "Post_Id", "Tag_Id" },
                keyValues: new object[] { new Guid("cd018418-5306-418e-9469-d137d38f3395"), new Guid("451c526e-fa0e-42ca-a347-912131719bd5") });

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "PostTag",
                keyColumns: new[] { "Post_Id", "Tag_Id" },
                keyValues: new object[] { new Guid("cd018418-5306-418e-9469-d137d38f3395"), new Guid("716cfff3-594a-4074-875b-d5b958807910") });

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "PostTag",
                keyColumns: new[] { "Post_Id", "Tag_Id" },
                keyValues: new object[] { new Guid("cd018418-5306-418e-9469-d137d38f3395"), new Guid("79215531-adc8-4635-8777-b1a859eee870") });

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "PostTag",
                keyColumns: new[] { "Post_Id", "Tag_Id" },
                keyValues: new object[] { new Guid("cd018418-5306-418e-9469-d137d38f3395"), new Guid("8df60d46-9a9d-46e1-b90d-d9bac8110ef7") });

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "PostTag",
                keyColumns: new[] { "Post_Id", "Tag_Id" },
                keyValues: new object[] { new Guid("cd018418-5306-418e-9469-d137d38f3395"), new Guid("9dd59d5f-d44e-4cc1-b16b-ef4ed12688e6") });

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "PostTag",
                keyColumns: new[] { "Post_Id", "Tag_Id" },
                keyValues: new object[] { new Guid("cd018418-5306-418e-9469-d137d38f3395"), new Guid("a5b98f7f-be9e-4bf7-9645-db7c5a1aa1f2") });

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "PostTag",
                keyColumns: new[] { "Post_Id", "Tag_Id" },
                keyValues: new object[] { new Guid("cd018418-5306-418e-9469-d137d38f3395"), new Guid("becbd21d-f175-48fa-a0b1-473920a72709") });

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Tag",
                keyColumn: "Id",
                keyValue: new Guid("04e9a93b-dd12-4217-99cb-ece19c0b567f"));

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Tag",
                keyColumn: "Id",
                keyValue: new Guid("1e82ea7d-e3a9-4911-b8c0-2a632bbba34a"));

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Tag",
                keyColumn: "Id",
                keyValue: new Guid("41f7feda-af81-4e8c-85bf-0c33188bfeb3"));

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Tag",
                keyColumn: "Id",
                keyValue: new Guid("451c526e-fa0e-42ca-a347-912131719bd5"));

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Tag",
                keyColumn: "Id",
                keyValue: new Guid("5feaaaff-76c9-4376-8ba7-af5314f4721d"));

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Tag",
                keyColumn: "Id",
                keyValue: new Guid("716cfff3-594a-4074-875b-d5b958807910"));

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Tag",
                keyColumn: "Id",
                keyValue: new Guid("79215531-adc8-4635-8777-b1a859eee870"));

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Tag",
                keyColumn: "Id",
                keyValue: new Guid("9dd59d5f-d44e-4cc1-b16b-ef4ed12688e6"));

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Tag",
                keyColumn: "Id",
                keyValue: new Guid("a5b98f7f-be9e-4bf7-9645-db7c5a1aa1f2"));

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Tag",
                keyColumn: "Id",
                keyValue: new Guid("becbd21d-f175-48fa-a0b1-473920a72709"));

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Tag",
                keyColumn: "Id",
                keyValue: new Guid("f02e7311-6c1c-497b-a9f9-7a55132c517b"));
        }
    }
}
