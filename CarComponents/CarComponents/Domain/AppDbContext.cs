using CarComponents.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarComponents.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<TextField> TextFields { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "3CFB3FB9-502D-46EE-A390-56F4A8E0A9C9",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "A6B399DC-1F54-448A-A267-CFA45D3FF03B",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "nikd926@gmail.com",
                NormalizedEmail = "NIKD926@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "3CFB3FB9-502D-46EE-A390-56F4A8E0A9C9",
                UserId = "A6B399DC-1F54-448A-A267-CFA45D3FF03B"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("AE84F8B9-BF23-42D4-953A-E3D861623C51"),
                Codeword = "PageIndex",
                Title = "Главная"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("357BBA7C-5344-4AE8-9E01-AA985E7EC4A7"),
                Codeword = "PageComponents",
                Title = "Комплектующие"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("B4BCA534-F149-4648-BDCA-178A051A3B35"),
                Codeword = "PageContacts",
                Title = "Контакты"
            });
        }
    }
}
