using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using JokeWebApp.Models;
using JokeWebApp.Enum;

namespace JokeWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserCustom> UserCustom { get; set; }
        public DbSet<UserRolesCustom> UserRolesCustom { get; set; }
        public DbSet<JokeWebApp.Models.Joke> Joke { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure User entity
            modelBuilder.Entity<UserCustom>(entity =>
            {
                entity.HasKey(u => u.Id); // Primary Key
            });

            // Configure UserRole entity
            modelBuilder.Entity<UserRolesCustom>(entity =>
            {
                entity.HasKey(ur => ur.Id); // Primary Key
                entity.Property(ur => ur.Id).ValueGeneratedNever(); // Ensure Id is not identity
            });
        }
    }
}
