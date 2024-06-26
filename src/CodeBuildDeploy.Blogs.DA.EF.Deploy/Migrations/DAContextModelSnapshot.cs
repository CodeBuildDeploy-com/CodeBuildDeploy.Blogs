﻿// <auto-generated />
using System;
using CodeBuildDeploy.Blogs.DA.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeBuildDeploy.Blogs.DA.EF.Deploy.Migrations
{
    [DbContext(typeof(DAContext))]
    partial class DAContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Category", "blg");

                    b.HasData(
                        new
                        {
                            Id = new Guid("09a8afe4-d726-43f6-9878-41ca1a4d5b39"),
                            Description = "Articles talking about how we like to deliver software here at CodeBuildDeploy, using the CodeBuildDeploy software as an example / POC delivery project. Includes key areas and concepts such as Continuous Delivery, DevOps Cultures, Automation, Continuous Improvement, Software Engineering Practices and all things Software Delivery.",
                            Name = "Software Delivery"
                        },
                        new
                        {
                            Id = new Guid("fc3cb34b-53c9-4342-a139-9ecf6b134008"),
                            Description = "An engineers workstation setup is an imperative part of their capability to deliver software effectively, comfortably and productively. This section details the setups of the CodeBuildDeploy family. It includes articles on how to setup tools that we find useful.",
                            Name = "Workstation Setup"
                        });
                });

            modelBuilder.Entity("CodeBuildDeploy.Blogs.DA.Entities.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Category_Id");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

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

                    b.HasData(
                        new
                        {
                            Id = new Guid("30c34d37-a663-4879-a294-e1b78431d611"),
                            Author = "Mark Pollard",
                            CategoryId = new Guid("fc3cb34b-53c9-4342-a139-9ecf6b134008"),
                            Content = "Libraries",
                            Description = "This section lists libraries I often use. These range from logging frameworks to testing tools used for testing / mocking etc.",
                            Modified = new DateTime(2015, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostedOn = new DateTime(2015, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Published = true,
                            ShortDescription = "Libraries you may like",
                            Title = "Libraries",
                            UrlSlug = "Libraries"
                        },
                        new
                        {
                            Id = new Guid("26d005b9-5505-4646-9194-cd8358817ac8"),
                            Author = "Mark Pollard",
                            CategoryId = new Guid("fc3cb34b-53c9-4342-a139-9ecf6b134008"),
                            Content = "Tools",
                            Description = "This section lists the tools I frequently use. Some are development tools others utility tools making general day to day working easier.",
                            Modified = new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostedOn = new DateTime(2015, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Published = true,
                            ShortDescription = "My favourite software tools",
                            Title = "Tools",
                            UrlSlug = "Tools"
                        },
                        new
                        {
                            Id = new Guid("ca8d885a-3a24-4c5b-bb33-61a7956b8996"),
                            Author = "Mark Pollard",
                            CategoryId = new Guid("fc3cb34b-53c9-4342-a139-9ecf6b134008"),
                            Content = "PowerShellRemoting",
                            Description = "This section talks about how to enable and work with powershell remoting.",
                            Modified = new DateTime(2015, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostedOn = new DateTime(2015, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Published = true,
                            ShortDescription = "Enable and work with powershell remoting",
                            Title = "PowerShell Remoting",
                            UrlSlug = "PowerShellRemoting"
                        },
                        new
                        {
                            Id = new Guid("0b7fe257-0429-4da1-94a2-89dbaa0aa583"),
                            Author = "Mark Pollard",
                            CategoryId = new Guid("fc3cb34b-53c9-4342-a139-9ecf6b134008"),
                            Content = "WSLInterop",
                            Description = "Read how to seamlessly call Linux commands, such as grep, directly from Powershell on you Windows machine.",
                            Modified = new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostedOn = new DateTime(2019, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Published = true,
                            ShortDescription = "Linux commands on Windows",
                            Title = "WSL Interop",
                            UrlSlug = "WSLInterop"
                        },
                        new
                        {
                            Id = new Guid("d1ef2a8d-07bd-49cf-a785-a727567e9fc9"),
                            Author = "Mark Pollard",
                            CategoryId = new Guid("fc3cb34b-53c9-4342-a139-9ecf6b134008"),
                            Content = "WslAnsible",
                            Description = "Read how to setup Ansible on Windows Subsystem for Linux, including setting up for seamlessly calling from windows powershell.",
                            Modified = new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostedOn = new DateTime(2019, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Published = true,
                            ShortDescription = "Setting up Ansible on WSL",
                            Title = "Ansible on WSL",
                            UrlSlug = "WslAnsible"
                        },
                        new
                        {
                            Id = new Guid("3e54714a-521d-484c-871c-a85ab52642ea"),
                            Author = "Mark Pollard",
                            CategoryId = new Guid("09a8afe4-d726-43f6-9878-41ca1a4d5b39"),
                            Content = "TrunkBasedDev",
                            Description = "Trunk Based Development is a branching strategy that operates with no long-running branches. Commits are made directly on main and releases come from builds of main.",
                            Modified = new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostedOn = new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Published = true,
                            ShortDescription = "Trunk Based Development",
                            Title = "Trunk Based Development",
                            UrlSlug = "TrunkBasedDev"
                        },
                        new
                        {
                            Id = new Guid("c5fecdc6-549a-41ce-ad63-fc8db2ab4e01"),
                            Author = "Mark Pollard",
                            CategoryId = new Guid("fc3cb34b-53c9-4342-a139-9ecf6b134008"),
                            Content = "MyShell",
                            Description = "Having fun customizing my terminal and making my prompt look awesome, with Oh my Posh 3 and Nerd fonts.",
                            Modified = new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostedOn = new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Published = true,
                            ShortDescription = "Having fun customizing my PowerShell terminal",
                            Title = "Oh MY Shell",
                            UrlSlug = "MyShell"
                        },
                        new
                        {
                            Id = new Guid("d8632d22-eb92-41a6-b3c4-dc1235846084"),
                            Author = "Mark Pollard",
                            CategoryId = new Guid("09a8afe4-d726-43f6-9878-41ca1a4d5b39"),
                            Content = "DevOpsCLI",
                            Description = "A container configured with all the CLI tools, scripts and extensions, a full stack DevOps cultured engineer needs for managing Azure environments resources such as AKS clusters.",
                            Modified = new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostedOn = new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Published = true,
                            ShortDescription = "Azure Envs CLI container for DevOps teams",
                            Title = "Azure Envs CLI container",
                            UrlSlug = "devops-cli-azenvs"
                        },
                        new
                        {
                            Id = new Guid("6181d9cc-ef13-42b3-aa66-ef2dc5b54fae"),
                            Author = "Andrew White",
                            CategoryId = new Guid("09a8afe4-d726-43f6-9878-41ca1a4d5b39"),
                            Content = "ZeroBugs",
                            Description = "It is impossible for software engineers to continuously produce bug-free, production ready code. Bugs will always exist. This article is about how we effectively handle such issues, acheiving a state of zero bugs backlog.",
                            Modified = new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostedOn = new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Published = true,
                            ShortDescription = "Delete all the bugs from your backlog, now!",
                            Title = "Zero Bugs",
                            UrlSlug = "ZeroBugs"
                        });
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

                    b.HasData(
                        new
                        {
                            PostId = new Guid("0b7fe257-0429-4da1-94a2-89dbaa0aa583"),
                            TagId = new Guid("2a0b3209-f46c-45fe-b7d6-8824a09f9504")
                        },
                        new
                        {
                            PostId = new Guid("0b7fe257-0429-4da1-94a2-89dbaa0aa583"),
                            TagId = new Guid("45485ccf-cc1c-40c2-ac9b-c74a17cc2711")
                        },
                        new
                        {
                            PostId = new Guid("0b7fe257-0429-4da1-94a2-89dbaa0aa583"),
                            TagId = new Guid("73dd1c87-742e-4154-b88d-7c2077b90151")
                        },
                        new
                        {
                            PostId = new Guid("0b7fe257-0429-4da1-94a2-89dbaa0aa583"),
                            TagId = new Guid("03bbd02b-0b2c-4eff-9874-8561b8bbcafa")
                        },
                        new
                        {
                            PostId = new Guid("ca8d885a-3a24-4c5b-bb33-61a7956b8996"),
                            TagId = new Guid("2a0b3209-f46c-45fe-b7d6-8824a09f9504")
                        },
                        new
                        {
                            PostId = new Guid("ca8d885a-3a24-4c5b-bb33-61a7956b8996"),
                            TagId = new Guid("45485ccf-cc1c-40c2-ac9b-c74a17cc2711")
                        },
                        new
                        {
                            PostId = new Guid("d1ef2a8d-07bd-49cf-a785-a727567e9fc9"),
                            TagId = new Guid("2a0b3209-f46c-45fe-b7d6-8824a09f9504")
                        },
                        new
                        {
                            PostId = new Guid("d1ef2a8d-07bd-49cf-a785-a727567e9fc9"),
                            TagId = new Guid("45485ccf-cc1c-40c2-ac9b-c74a17cc2711")
                        },
                        new
                        {
                            PostId = new Guid("d1ef2a8d-07bd-49cf-a785-a727567e9fc9"),
                            TagId = new Guid("73dd1c87-742e-4154-b88d-7c2077b90151")
                        },
                        new
                        {
                            PostId = new Guid("d1ef2a8d-07bd-49cf-a785-a727567e9fc9"),
                            TagId = new Guid("03bbd02b-0b2c-4eff-9874-8561b8bbcafa")
                        },
                        new
                        {
                            PostId = new Guid("d1ef2a8d-07bd-49cf-a785-a727567e9fc9"),
                            TagId = new Guid("79adf12b-1c17-42c9-9d44-5cce1b9f3c82")
                        },
                        new
                        {
                            PostId = new Guid("3e54714a-521d-484c-871c-a85ab52642ea"),
                            TagId = new Guid("6961e675-7008-46a5-a75d-1c473ada45ea")
                        },
                        new
                        {
                            PostId = new Guid("c5fecdc6-549a-41ce-ad63-fc8db2ab4e01"),
                            TagId = new Guid("2a0b3209-f46c-45fe-b7d6-8824a09f9504")
                        },
                        new
                        {
                            PostId = new Guid("d8632d22-eb92-41a6-b3c4-dc1235846084"),
                            TagId = new Guid("45485ccf-cc1c-40c2-ac9b-c74a17cc2711")
                        },
                        new
                        {
                            PostId = new Guid("d8632d22-eb92-41a6-b3c4-dc1235846084"),
                            TagId = new Guid("73dd1c87-742e-4154-b88d-7c2077b90151")
                        },
                        new
                        {
                            PostId = new Guid("d8632d22-eb92-41a6-b3c4-dc1235846084"),
                            TagId = new Guid("03bbd02b-0b2c-4eff-9874-8561b8bbcafa")
                        },
                        new
                        {
                            PostId = new Guid("d8632d22-eb92-41a6-b3c4-dc1235846084"),
                            TagId = new Guid("f4547542-2b7f-4f9e-8a30-01850657a6b2")
                        },
                        new
                        {
                            PostId = new Guid("d8632d22-eb92-41a6-b3c4-dc1235846084"),
                            TagId = new Guid("8df60d46-9a9d-46e1-b90d-d9bac8110ef7")
                        },
                        new
                        {
                            PostId = new Guid("d8632d22-eb92-41a6-b3c4-dc1235846084"),
                            TagId = new Guid("37519618-949c-48dd-a099-9f991b950ada")
                        },
                        new
                        {
                            PostId = new Guid("6181d9cc-ef13-42b3-aa66-ef2dc5b54fae"),
                            TagId = new Guid("48306da3-dab0-4b0e-b063-0acbaf126891")
                        });
                });

            modelBuilder.Entity("CodeBuildDeploy.Blogs.DA.Entities.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

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
                        },
                        new
                        {
                            Id = new Guid("8df60d46-9a9d-46e1-b90d-d9bac8110ef7"),
                            Description = "Docker Containers",
                            Name = "Containers"
                        },
                        new
                        {
                            Id = new Guid("37519618-949c-48dd-a099-9f991b950ada"),
                            Description = "Kubernetes / K8s, used for automating deployment, scaling, and management of containers",
                            Name = "Kubernetes"
                        },
                        new
                        {
                            Id = new Guid("48306da3-dab0-4b0e-b063-0acbaf126891"),
                            Description = "Tracking and planning of project issues",
                            Name = "Issue Management"
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
