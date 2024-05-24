﻿// <auto-generated />
using System;
using CodeBuildDeploy.Blogs.DA.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeBuildDeploy.Blogs.DA.EF.Deploy.Migrations
{
    [DbContext(typeof(DAContext))]
    [Migration("20240523111930_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("blg")
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CodeBuildDeploy.Blogs.DA.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Category", "blg");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d4d99022-04a5-43ed-982e-b4741adc6478"),
                            Description = "General info topics",
                            Name = "General"
                        },
                        new
                        {
                            Id = new Guid("09a8afe4-d726-43f6-9878-41ca1a4d5b39"),
                            Description = "Blogs on topics like Continuous Delivery, DevOps Cultures, Automation, Continuous Improvement, Software Engineering Practices and all things Software Delivery",
                            Name = "Software Delivery"
                        },
                        new
                        {
                            Id = new Guid("fc3cb34b-53c9-4342-a139-9ecf6b134008"),
                            Description = "Blogs on setting up my workstation",
                            Name = "Workstation Setup"
                        });
                });

            modelBuilder.Entity("CodeBuildDeploy.Blogs.DA.Entities.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Category_Id");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PostedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Published")
                        .HasColumnType("bit");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UrlSlug")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Post", "blg");
                });

            modelBuilder.Entity("CodeBuildDeploy.Blogs.DA.Entities.PostTag", b =>
                {
                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Post_Id");

                    b.Property<Guid>("TagId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Tag_Id");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTag", "blg");
                });

            modelBuilder.Entity("CodeBuildDeploy.Blogs.DA.Entities.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Tag", "blg");

                    b.HasData(
                        new
                        {
                            Id = new Guid("313135f2-aa40-481b-9646-0e30052b5462"),
                            Description = "Microsoft .Net Framework",
                            Name = ".NET"
                        },
                        new
                        {
                            Id = new Guid("2a0b3209-f46c-45fe-b7d6-8824a09f9504"),
                            Description = "PowerShell Core and Windows PowerShell",
                            Name = "PowerShell"
                        },
                        new
                        {
                            Id = new Guid("f7e79415-98c9-46ab-a51e-7afd7fbd9c8a"),
                            Description = "Microsoft ASP.NET",
                            Name = "ASP.NET"
                        },
                        new
                        {
                            Id = new Guid("45485ccf-cc1c-40c2-ac9b-c74a17cc2711"),
                            Description = "Windows Operating System",
                            Name = "Windows"
                        },
                        new
                        {
                            Id = new Guid("73dd1c87-742e-4154-b88d-7c2077b90151"),
                            Description = "Unix based Operating System",
                            Name = "UNIX"
                        },
                        new
                        {
                            Id = new Guid("03bbd02b-0b2c-4eff-9874-8561b8bbcafa"),
                            Description = "Linux Operating System'",
                            Name = "Linux"
                        },
                        new
                        {
                            Id = new Guid("f5bc44bf-f42e-447d-8bed-ee6aa59061e3"),
                            Description = "Python scripting language",
                            Name = "Python"
                        },
                        new
                        {
                            Id = new Guid("f4547542-2b7f-4f9e-8a30-01850657a6b2"),
                            Description = "Azure Cloud",
                            Name = "Azure"
                        },
                        new
                        {
                            Id = new Guid("79adf12b-1c17-42c9-9d44-5cce1b9f3c82"),
                            Description = "Ansible Automation",
                            Name = "Ansible"
                        },
                        new
                        {
                            Id = new Guid("6961e675-7008-46a5-a75d-1c473ada45ea"),
                            Description = "Git Source Control",
                            Name = "Git"
                        });
                });

            modelBuilder.Entity("CodeBuildDeploy.Blogs.DA.Entities.Post", b =>
                {
                    b.HasOne("CodeBuildDeploy.Blogs.DA.Entities.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CodeBuildDeploy.Blogs.DA.Entities.PostTag", b =>
                {
                    b.HasOne("CodeBuildDeploy.Blogs.DA.Entities.Post", "Post")
                        .WithMany("PostTags")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeBuildDeploy.Blogs.DA.Entities.Tag", "Tag")
                        .WithMany("PostTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("CodeBuildDeploy.Blogs.DA.Entities.Category", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("CodeBuildDeploy.Blogs.DA.Entities.Post", b =>
                {
                    b.Navigation("PostTags");
                });

            modelBuilder.Entity("CodeBuildDeploy.Blogs.DA.Entities.Tag", b =>
                {
                    b.Navigation("PostTags");
                });
#pragma warning restore 612, 618
        }
    }
}
