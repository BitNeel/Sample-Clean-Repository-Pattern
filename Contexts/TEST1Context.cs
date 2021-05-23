using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BlogPosts.Models;

#nullable disable

namespace BlogPosts.Contexts
{
    public partial class TEST1Context : DbContext
    {
        public TEST1Context()
        {
        }

        public TEST1Context(DbContextOptions<TEST1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<UserPost> UserPosts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContactNumer)
                    .HasMaxLength(12)
                    .HasColumnName("contactNumer");

                entity.Property(e => e.CorrespondenceAddress)
                    .HasMaxLength(200)
                    .HasColumnName("correspondenceAddress");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .HasColumnName("createdBy");

                entity.Property(e => e.CreatedDtm)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDtm");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .HasColumnName("firstName");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .HasColumnName("lastName");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(100)
                    .HasColumnName("middleName");
            });

            modelBuilder.Entity<UserPost>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Body)
                    .HasMaxLength(500)
                    .HasColumnName("body");

                entity.Property(e => e.Title)
                    .HasMaxLength(300)
                    .HasColumnName("title");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
