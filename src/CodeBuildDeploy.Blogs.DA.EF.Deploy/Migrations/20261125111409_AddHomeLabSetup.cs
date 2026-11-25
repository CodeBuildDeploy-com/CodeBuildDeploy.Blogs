using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeBuildDeploy.Blogs.DA.EF.Deploy.Migrations
{
    /// <inheritdoc />
    public partial class AddHomeLabSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "blg",
                table: "Category",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("42eac5c9-5d16-49d4-869d-bf050cdaa0e0"), "How I run the network, Proxmox cluster, and Azure infrastructure behind the HomeLab and CodeBuildDeploy.", "HomeLab Setup" });

            migrationBuilder.InsertData(
                schema: "blg",
                table: "Post",
                columns: new[] { "Id", "Author_Id", "Category_Id", "Content", "Description", "Modified", "PostedOn", "Published", "ShortDescription", "Title", "UrlSlug" },
                values: new object[,]
                {
                    { new Guid("5229849a-3b83-4b6e-b75d-f0a2153e2a08"), new Guid("50f29cf4-ab70-4e9f-b225-4fc31ce5b4f6"), new Guid("42eac5c9-5d16-49d4-869d-bf050cdaa0e0"), "HomeLabProxmoxCluster", "How I use a three-node Proxmox cluster to run home automation, media services, cameras and development workstations.", null, new DateTime(2026, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Virtualization, storage and backups", "Proxmox cluster", "homelab-proxmox-cluster" },
                    { new Guid("79a91732-fb8b-4e43-aded-1112b6ed61a9"), new Guid("50f29cf4-ab70-4e9f-b225-4fc31ce5b4f6"), new Guid("42eac5c9-5d16-49d4-869d-bf050cdaa0e0"), "HomeLabAzureInfrastructure", "How I provision CodeBuildDeploy on Azure with Terraform and deploy the application to Kubernetes with Helm.", null, new DateTime(2026, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Terraform, Azure DevOps and AKS", "Azure Infrastructure", "homelab-azure-infrastructure" },
                    { new Guid("cd018418-5306-418e-9469-d137d38f3395"), new Guid("50f29cf4-ab70-4e9f-b225-4fc31ce5b4f6"), new Guid("42eac5c9-5d16-49d4-869d-bf050cdaa0e0"), "HomeLabNetworkAndEdge", "How I run the HomeLab network and publish the CodeBuildDeploy dev sites through a private connection to Azure.", null, new DateTime(2026, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Routing, DNS and private ingress", "Network and edge", "homelab-network-and-edge" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("5229849a-3b83-4b6e-b75d-f0a2153e2a08"));

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("79a91732-fb8b-4e43-aded-1112b6ed61a9"));

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("cd018418-5306-418e-9469-d137d38f3395"));

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("42eac5c9-5d16-49d4-869d-bf050cdaa0e0"));
        }
    }
}
