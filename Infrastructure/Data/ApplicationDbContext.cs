using Infrastructure.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        //
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AppUser>().ToTable("AppUsers");
            // تحديد استراتيجية الوراثة (TPT أو TPH)
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<Professor>().ToTable("Professors");
            modelBuilder.Entity<Admin>().ToTable("Admins");
            // التأكد من أن UniversityNumber فريد
            modelBuilder.Entity<Student>()
                .HasIndex(s => s.UniversityNumber)
                .IsUnique();

        }
    }

}
//Add-Migration InitialCreate -OutputDir Infrastructure/Data/Migrations