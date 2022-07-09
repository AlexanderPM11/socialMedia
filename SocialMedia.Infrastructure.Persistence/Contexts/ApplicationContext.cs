using Microsoft.EntityFrameworkCore;
using SocialMedia.Core.Domain;
using SocialMedia.Core.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Persistence.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Comment> Products { get; set; }
        public DbSet<Friends> Categories { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Publication> Publications { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.CreatedBy = "DefaultAppUser";
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModified = DateTime.Now;
                        entry.Entity.LastModifiedBy = "DefaultAppUser";
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //FLUENT API

            #region tables

            modelBuilder.Entity<Publication>()
                .ToTable("Publication");

            modelBuilder.Entity<Friends>()
                .ToTable("Friends");
            modelBuilder.Entity<Comment>()
               .ToTable("Comment");

            modelBuilder.Entity<Users>()
                .ToTable("Users");

            #endregion

            #region "primary keys"
            modelBuilder.Entity<Comment>()
                .HasKey(product => product.Id);

            modelBuilder.Entity<Publication>()
                .HasKey(category => category.Id);
            modelBuilder.Entity<Friends>()
              .HasKey(category => category.Id);

            modelBuilder.Entity<Users>()
              .HasKey(user => user.Id);
            #endregion

            #region "Relationships"
            modelBuilder.Entity<Users>()
                .HasMany<Publication>(category => category.Publication)
                .WithOne(product => product.User)
                .HasForeignKey(product => product.Id_User)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Users>()
             .HasMany<Friends>(user => user.Friends)
             .WithOne(product => product.User)
             .HasForeignKey(product => product.Id_User)
             .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Users>()
             .HasMany<Comment>(user => user.Comments)
             .WithOne(product => product.User)
             .HasForeignKey(product => product.Id_User)
             .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Friends>()
              .HasMany<Comment>(user => user.Comments)
              .WithOne(product => product.Friend)
              .HasForeignKey(product => product.Id_Friends)
              .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Publication>()
             .HasMany<Comment>(user => user.Comments)
             .WithOne(product => product.Publication)
             .HasForeignKey(product => product.Id_Publication)
             .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region "Property configurations"            

            #region users

            modelBuilder.Entity<Users>().
                Property(user => user.Name)
                .IsRequired();

            modelBuilder.Entity<Users>().
               Property(user => user.UserName)
               .IsRequired();

            modelBuilder.Entity<Users>().
              Property(user => user.Password)
              .IsRequired();

            modelBuilder.Entity<Users>().
              Property(user => user.Email)
              .IsRequired();

            modelBuilder.Entity<Users>().
               Property(user => user.Tel)
               .IsRequired();

            #endregion

            #endregion
        }

    }
}
