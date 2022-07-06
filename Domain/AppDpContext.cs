using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebSite11.Domain.Entities;

namespace WebSite11.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; } // текстовое поле
        public DbSet<ServiceItem> ServiceItem { get; set; } // услуга 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole  //роль
            {
                Id = "6FF66B6D-FDEC-4825-A115-56836471C40F",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser // юзер админ
            {
                Id = "D25C0E94-A64A-4537-B56E-8840E806F971",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "denis_loko@mail.ru",
                NormalizedEmail = "DENIS_LOKO@MAIL.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "6FF66B6D-FDEC-4825-A115-56836471C40F",
                UserId = "D25C0E94-A64A-4537-B56E-8840E806F971"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField {
                Id = new Guid("D64793A6-40BA-4D23-A1C3-2EA4761B8FE3"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("329043FD-7BF9-4BFE-9040-59B4F8C600BF"),
                CodeWord = "PageServices",
                Title = "Наши услуги"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("E5001545-08C4-40A8-99B0-2F906F4420E4"),
                CodeWord = "PageContacts",
                Title = "Контакты"
            });
        }

    }
}
