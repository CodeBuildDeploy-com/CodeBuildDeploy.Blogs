using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

using CodeBuildDeploy.Blogs.DA.Entities;

namespace CodeBuildDeploy.Blogs.DA.EF
{
    public sealed class DAContext : DbContext
    {
        public const string SchemaName = "blg";

        public DAContext(DbContextOptions<DAContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(SchemaName);
            
            // Database does not pluralize table names
            foreach (IMutableEntityType entityType in modelBuilder.Model.GetEntityTypes())
            {
                entityType.SetTableName(entityType.DisplayName());
            }

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).HasMaxLength(50);
                entity.Property(e => e.Description).HasMaxLength(400);
                entity.HasData(Entities.Categories.GetAll());
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).HasMaxLength(50);
                entity.Property(e => e.Description).HasMaxLength(100);
                entity.HasData(Entities.Tags.GetDefault());
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne<Category>(e => e.Category).WithMany(e => e.Posts).HasForeignKey(e => e.CategoryId);
                entity.Property(e => e.CategoryId).HasColumnName("Category_Id");
                entity.Property(e => e.UrlSlug).HasMaxLength(50);
                entity.Property(e => e.Title).HasMaxLength(50);
                entity.Property(e => e.ShortDescription).HasMaxLength(50);
                entity.Property(e => e.Description).HasMaxLength(300);
                entity.Property(e => e.Author).HasMaxLength(40);
                entity.HasData(Entities.Posts.GetDefault());
            });

            modelBuilder.Entity<PostTag>(entity =>
            {
                entity.HasKey(pt => new { pt.PostId, pt.TagId });
                entity.HasOne<Post>(e => e.Post).WithMany(e => e.PostTags).HasForeignKey(e => e.PostId);
                entity.HasOne<Tag>(e => e.Tag).WithMany(e => e.PostTags).HasForeignKey(e => e.TagId);
                entity.Property(e => e.PostId).HasColumnName("Post_Id");
                entity.Property(e => e.TagId).HasColumnName("Tag_Id");
                entity.HasData(PostTags.GetDefault());
            });
        }
    }
}
