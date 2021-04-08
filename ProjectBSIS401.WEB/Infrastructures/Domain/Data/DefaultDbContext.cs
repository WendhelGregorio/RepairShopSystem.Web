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
        public DbSet<ShopService> ShopServices { get; set; }
        public DbSet<Service> Services { get; set; }
       
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }

        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<PricingContent> PricingContents { get; set; }
        

        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<ChatUser> ChatUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<UserGroup>().ToTable("UserGroup");
            modelBuilder.Entity<UserRole>().ToTable("UserRole");
            modelBuilder.Entity<Shop>().ToTable("Shop");
            modelBuilder.Entity<Booking>().ToTable("Booking");
            
            modelBuilder.Entity<Service>().ToTable("Service");

            modelBuilder.Entity<Rating>().ToTable("Rating");
            modelBuilder.Entity<Comment>().ToTable("Comment");
            modelBuilder.Entity<Like>().ToTable("Like");

            modelBuilder.Entity<Chat>().ToTable("Chat");
            modelBuilder.Entity<Message>().ToTable("Message");
            modelBuilder.Entity<ChatUser>().ToTable("ChatUser");

            modelBuilder.Entity<ChatUser>()
                    .HasKey(x => new { x.ChatId, x.UserId });

           
        }
    }
}