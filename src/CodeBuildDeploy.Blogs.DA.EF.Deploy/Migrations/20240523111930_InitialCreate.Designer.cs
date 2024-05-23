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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Category", "blg");
                });

            modelBuilder.Entity("CodeBuildDeploy.Blogs.DA.Entities.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
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
                    b.Property<int>("PostId")
                        .HasColumnType("int")
                        .HasColumnName("Post_Id");

                    b.Property<int>("TagId")
                        .HasColumnType("int")
                        .HasColumnName("Tag_Id");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTag", "blg");
                });

            modelBuilder.Entity("CodeBuildDeploy.Blogs.DA.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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
