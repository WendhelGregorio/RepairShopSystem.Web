using Microsoft.EntityFrameworkCore;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Data
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options)
            : base(options)
        {
        }


        public DbSet<Group> Groups { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }



        public DbSet<FeedBack> FeedBacks { get; set; }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Category> Categories { get; set; }
       


        public DbSet<Shop> Shops { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<UserGroup>().ToTable("UserGroup");
            modelBuilder.Entity<UserRole>().ToTable("UserRole");
            modelBuilder.Entity<Shop>().ToTable("Shop");
            modelBuilder.Entity<Booking>().ToTable("Booking");
           
            modelBuilder.Entity<Service>().ToTable("Service");
            modelBuilder.Entity<Category>().ToTable("Category");
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ReservationService>()
               .HasKey(rs => new { rs.ShopId, rs.UserId,rs.ReserveId,rs.ServiceId });
        }
    }
}